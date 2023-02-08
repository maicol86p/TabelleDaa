Imports FunzioniIntegra
Imports System.Data.SqlClient
Imports Integra.WebAcsi
Imports System.ComponentModel


Public Class TabelleDaa
    Inherits BaseForm

    ReadOnly Property Deposito()
        Get
            Deposito = CmbDeposito.SelectedValue
        End Get
    End Property

    ReadOnly Property DaaAcciseRow() As Integer
        Get
            DaaAcciseRow = DBGridDaaAccise.Bookmark 'DBGridDaaAccise.Row
        End Get
    End Property

    ReadOnly Property CurrentTipoTabella() As String
        Get
            CurrentTipoTabella = DBGridDaaAcciseDef.Item(DBGridDaaAcciseDef.Row, "Tabella")
        End Get
    End Property

    Private Sub AnagraficheDaa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.Form_Load(sender, e)
        'ReDim Qtm(2)

        Database.ConnString = Globali.databaseManager.getConnectionString()
        PgnUserCurrent.UserName = Globali.utente
        PgnUserCurrent.AccessCode = Globali.codiceSocieta

        loadComboDeposito()
        loadGridDaaAcciseDef()
        formatGridDaaAccise()
    End Sub

    Sub formatGridDaaAccise()
        For Each item As C1.Win.C1TrueDBGrid.C1DataColumn In DBGridDaaAccise.Columns
            Dim txt As New TextBoxIntegra()
            txt.BorderStyle = BorderStyle.None
            txt.StatusBar = StatusBar1
            txt.StatusBarText = item.Caption
            txt.StatusBarType = "ALFA"
            txt.StatusBarLenght = 10
            txt.KeyPressFormat = StrDup(10, "A")
            item.Editor = txt
        Next
    End Sub

    Sub loadGridDaaAccise(ByVal tipo_tabella As String)
        Try
            Dim listaCampi = getListaCampiVisibili(tipo_tabella)

            If String.IsNullOrEmpty(Me.Deposito) Then
                DBGridDaaAccise.Enabled = False
                BtnApplyAll.Enabled = False
                BtnCancelAll.Enabled = False
            Else
                DBGridDaaAccise.Enabled = True
                BtnApplyAll.Enabled = True
                BtnCancelAll.Enabled = True
            End If

            Dim filter As New DaaAcciseFilter()
            filter.Tipo_Tabella = tipo_tabella
            filter.Visibile = Utility.TristateBool.NotSet  'visualizza tutte le righe
            Dim datasource = New BindingList(Of DaaAccise)(New DaaAcciseManager(Deposito).GetByFilter(filter, ""))
            DBGridDaaAccise.SetDataBinding(datasource, "", True)

            For Each item As C1.Win.C1TrueDBGrid.C1DisplayColumn In DBGridDaaAccise.Splits(0).DisplayColumns
                If listaCampi.ContainsKey(item.DataColumn.DataField.ToLower()) _
                        Or listaCampi.ContainsKey(item.DataColumn.Caption.ToLower()) Then
                    item.Visible = True
                Else
                    item.Visible = False
                End If
            Next

            For Each item As C1.Win.C1TrueDBGrid.C1DataColumn In DBGridDaaAccise.Columns
                If listaCampi.ContainsKey(item.DataField.ToLower()) _
                        Or listaCampi.ContainsKey(item.Caption.ToLower()) Then

                    Dim txt As New TextBoxIntegra()
                    txt.BorderStyle = BorderStyle.None
                    txt.StatusBar = StatusBar1
                    txt.StatusBarText = item.Caption
                    txt.StatusBarType = "ALFA"
                    txt.StatusBarLenght = listaCampi(item.DataField.ToLower())
                    txt.KeyPressFormat = StrDup(listaCampi(item.DataField.ToLower()), "A")

                    item.Editor = txt
                End If
            Next

            DBGridDaaAccise.Rebind(True)

        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Sub loadGridDaaAcciseDef()
        Try
            Dim filter As New DaaAcciseDefFilter()
            Dim datasource = New BindingList(Of DaaAcciseDef)(New DaaAcciseDefManager().GetByFilter(filter, ""))
            DBGridDaaAcciseDef.SetDataBinding(datasource, "", True)

        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Sub loadComboDeposito()
        Try
            Dim qtmDeposito As QueryTableManager
            Dim sql As String

            CmbDeposito.HoldFields()

            sql = "Select  accisada, deposito " _
            & " From tabella_accise_utenti " _
            & " WHERE codsoc = '" & FunzioniIntegra.Globali.codiceSocieta & "' "
            qtmDeposito = Dbm.getQueryTableManager(sql)
            CmbDeposito.ValueMember = "accisada"
            CmbDeposito.DisplayMember = "accisada"
            CmbDeposito.DataSource = qtmDeposito.Table
            CmbDeposito.Rebind(True)


        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Private Function getListaCampiVisibili(ByVal tipo_tabella As String) As Dictionary(Of String, Integer)
        'Dim listaCampi As New List(Of String)
        Dim listaCampi As New Dictionary(Of String, Integer)
        Dim tabdef = New DaaAcciseDefManager().GetByKey(tipo_tabella)

        'listaCampi.Add("societa")
        'listaCampi.Add("tabella")
        'listaCampi.Add("id")
        'listaCampi.Add("visibile")
        'listaCampi.Add("edit")
        'listaCampi.Add("cancella")

        listaCampi.Add("visibile", 0)

        'colonne grid
        With tabdef
            If (.Codice_Tabella > 0) Then listaCampi.Add("codice_tabella", .Codice_Tabella)
            If (.Descrizione > 0) Then listaCampi.Add("descrizione", .Descrizione)
            If (.DescrizioneInglese > 0) Then listaCampi.Add("descrizioneinglese", .DescrizioneInglese)
            If (.Numerabile > 0) Then listaCampi.Add("numerabile", .Numerabile)
            If (.Cpa > 0) Then listaCampi.Add("cpa", .Cpa)
            If (.Cat > 0) Then listaCampi.Add("cat", .Cat)
            If (.Um > 0) Then listaCampi.Add("um", .Um)
            If (.GradoA > 0) Then listaCampi.Add("gradoa", .GradoA)
            If (.GradoP > 0) Then listaCampi.Add("gradop", .GradoP)
            If (.Densita > 0) Then listaCampi.Add("densita", .Densita)
            If (.Ie815 > 0) Then listaCampi.Add("ie815", .Ie815)
            If (.Ie813 > 0) Then listaCampi.Add("ie813", .Ie813)
        End With
        getListaCampiVisibili = listaCampi
    End Function

    Private Sub DBGridDaaAcciseDef_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles DBGridDaaAcciseDef.RowColChange
        If e.LastRow <> DBGridDaaAcciseDef.Row Then
            If (Not String.IsNullOrEmpty(Me.CurrentTipoTabella)) Then
                loadGridDaaAccise(Me.CurrentTipoTabella)
            End If
        End If
    End Sub

    Private Sub DBGridDaaAcciseDef_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DBGridDaaAcciseDef.MouseClick
        If DBGridDaaAcciseDef.Row > -1 Then
            DBGridDaaAcciseDef.SelectedRows.Add(DBGridDaaAcciseDef.Row)
        End If
    End Sub

    Private Sub DBGridDaaAcciseDef_BeforeDelete(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridDaaAcciseDef.BeforeDelete
        If MessageBox.Show("Cancellare il record?", "Conferma cancellazione", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Try
                Dim man As New DaaAcciseDefManager()
                Dim row As New DaaAcciseDef()
                Dim ds As BindingList(Of DaaAcciseDef) = DBGridDaaAcciseDef.DataSource
                row = ds(DBGridDaaAcciseDef.Row)
                man.DeleteById(row.Tipo_Tabella)
            Catch ex As Exception
                GestioneErrori.erroreStandard(ex)
            End Try
        End If
    End Sub

    Private Sub DBGridDaaAcciseDef_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridDaaAcciseDef.BeforeUpdate
        Try
            Dim man As New DaaAcciseDefManager()
            Dim row As New DaaAcciseDef()
            Dim ds As BindingList(Of DaaAcciseDef) = DBGridDaaAcciseDef.DataSource
            row = ds(DBGridDaaAcciseDef.Bookmark)
            If String.IsNullOrEmpty(row.Tipo_Tabella) Then

            End If
            If Not String.IsNullOrEmpty(man.GetByKey(row.Tipo_Tabella).Tipo_Tabella) Then
                man.Update(row)
            Else
                man.Insert(row)
            End If
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Private Sub DBGridDaaAccise_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridDaaAccise.BeforeUpdate
        Try
            Dim man As New DaaAcciseManager(Me.Deposito)
            Dim row As New DaaAccise()
            Dim ds As BindingList(Of DaaAccise) = DBGridDaaAccise.DataSource
            row = ds(DaaAcciseRow)
            If String.IsNullOrEmpty(row.Tipo_Tabella) Then
                'valori di default per la nuova riga
                row.Tipo_Tabella = Me.CurrentTipoTabella
            End If
            If Not String.IsNullOrEmpty( _
                man.GetByKey(row.Tipo_Tabella, row.Codice_Tabella, row.Cpa).Tipo_Tabella) Then
                man.Update(row)
            Else
                man.Insert(row)
            End If
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub


    Private Sub DBGridDaaAccise_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles DBGridDaaAccise.AfterColUpdate
        Try
            If e.Column.DataColumn.Caption.ToLower() = "visualizza" Then
                Dim man As New DaaAcciseManager(Me.Deposito)
                Dim row As New DaaAccise()
                Dim ds As BindingList(Of DaaAccise) = DBGridDaaAccise.DataSource
                row = ds(DaaAcciseRow)
                man.UpdateDett(row.Tipo_Tabella, row.Codice_Tabella, row.Cpa, _
                            Me.Deposito, row.Visibile)
            End If
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Private Sub DBGridDaaAccise_BeforeDelete(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles DBGridDaaAccise.BeforeDelete
        If MessageBox.Show("Cancellare il record?", "Conferma cancellazione", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Try
                Dim man As New DaaAcciseManager(Me.Deposito)
                Dim row As New DaaAccise()
                Dim ds As BindingList(Of DaaAccise) = DBGridDaaAccise.DataSource
                row = ds(DBGridDaaAccise.Row)
                man.DeleteByKey(row.Tipo_Tabella, row.Codice_Tabella, row.Cpa)
            Catch ex As Exception
                GestioneErrori.erroreStandard(ex)
            End Try
        End If
    End Sub


    Private Sub CmbDeposito_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDeposito.Change
        loadGridDaaAccise(Me.CurrentTipoTabella)
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim grid = DBGridDaaAcciseDef
        Dim ds As BindingList(Of DaaAcciseDef) = grid.DataSource
        grid.Focus()
        grid.Row = ds.Count

    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Dim grid = DBGridDaaAcciseDef
        grid.Focus()
        grid.Row += 1
    End Sub

    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Dim grid = DBGridDaaAcciseDef
        grid.Focus()
        grid.Row -= 1
    End Sub

    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Dim grid = DBGridDaaAcciseDef
        grid.Focus()
        grid.Row = 0
    End Sub

    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Dim grid = DBGridDaaAcciseDef
        Dim ds As BindingList(Of DaaAcciseDef) = grid.DataSource
        grid.Focus()
        If ds.Count > 0 Then
            grid.Row = ds.Count - 1
        End If
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Try
            Dim grid = DBGridDaaAcciseDef
            Dim cancel As C1.Win.C1TrueDBGrid.CancelEventArgs
            DBGridDaaAcciseDef_BeforeDelete(grid, cancel)
            grid.Delete()
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub

    Private Sub BtnApplyAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApplyAll.Click
        sellAll(True)
    End Sub

    Private Sub BtnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelAll.Click
        sellAll(False)
    End Sub

    Private Sub sellAll(ByVal visible As Boolean)
        Try
            Dim man As New DaaAcciseManager(Me.Deposito)
            man.UpdateDettByTipoTabella(Me.CurrentTipoTabella, Me.Deposito, visible)
            loadGridDaaAccise(Me.CurrentTipoTabella)
        Catch ex As Exception
            GestioneErrori.erroreStandard(ex)
        End Try
    End Sub
End Class

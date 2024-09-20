Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Threading


'Imports System.Data.SqlClient
'Imports System.Data.SqlTypes
'Imports Microsoft.SqlServer.Server


#Region "This Code Used For Deal With FrmMessageBox"

'       Dim Frm As New FrmMessageBox

'       Dim Result As String = Frm.ShowMessage("This Is My First Message", "Title", _
'       MessageBoxIcon.Question, MessageBoxButtons.OKCancel, Frm)

'        Me.Text = ""
'        Me.Text = "Custom Message Box"

'        If Result = "Ok" Then
'            Me.Text += " - Pressed On Ok"
'        Else
'            Me.Text += " - Pressed On Cancel"
'        End If

#End Region

Module OperatorModule

    Private isProcessRunning As Boolean = False

    Public _selectedNode As TreeNode = Nothing
    Public _acountsTb As DataTable = Nothing
    Public _connection As SqlConnection
    Public _command As SqlCommand
    Public _adapter As SqlDataAdapter
    Public _newNode As Boolean, _thisLevel As Boolean, _update As Boolean
    Public _parent As Integer = -1


    'Private Sub PopulateTreeView(parentId As Integer, parentNode As TreeNode)

    '    Dim childNode As TreeNode

    '    For Each dr As DataRow In _acountsTb.[Select]("[parent]=" + parentId)
    '        Dim t As New TreeNode()
    '        t.Text = dr("code").ToString() + " - " + dr("ac_name").ToString()
    '        t.Name = dr("code").ToString()
    '        t.Tag = _acountsTb.Rows.IndexOf(dr)
    '        If parentNode Is Nothing Then
    '            treeView1.Nodes.Add(t)
    '            childNode = t
    '        Else
    '            parentNode.Nodes.Add(t)
    '            childNode = t
    '        End If
    '        PopulateTreeView(Convert.ToInt32(dr("code").ToString()), childNode)
    '    Next
    'End Sub

    Public Sub DISPLAYTREEVIEW(parentId As Object, parentNode As TreeNode, TVGet As TreeView, DataTableVar As String, Optional ByVal ConditionVar As Integer = 0,
                                            Optional ByRef CondFiled1 As String = Nothing, Optional ByVal CondFieldVal1 As Object = Nothing,
                                            Optional ByRef CondFiled2 As String = Nothing, Optional ByVal CondFieldVal2 As Object = Nothing)

        Dim childNode As TreeNode

        _newNode = _thisLevel = _update = False
        _acountsTb = New DataTable()
        '_connection = New SqlConnection("Data Source=(local);Initial Catalog=PetraDB;Integrated Security=True")

        '_connection = New SqlConnection("Data Source=192.168.1.7,1433;NetWork Library=DBMSSOCN;" &
        '                                                        "Password=Omnya1012;User ID=sa;Initial Catalog=AliLabDB; multipleactiveresultsets=True")

        '_connection = New SqlConnection("Data Source=Soka;Password=Omnya1012;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True")
        '_connection = New SqlConnection("Data Source=Akram;Password=123;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True")

        _connection = New SqlConnection("Data Source=TMLSERVER;Password=love1972;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True")


        _command = New SqlCommand()
        _command.Connection = _connection

        Dim sql As String

        If ConditionVar = 0 Then

            sql = "SELECT *  FROM " & DataTableVar & ""

        End If

        If ConditionVar = 1 Then

            sql = "SELECT *  FROM " & DataTableVar & " where " & CondFiled1 & " = " & CondFieldVal1 & ""

        End If

        If ConditionVar = 2 Then

            sql = "SELECT *  FROM " & DataTableVar & " where " & CondFiled1 & " = " &
                                                 CondFieldVal1 & " and " & CondFiled2 & " = " &
                                                 CondFieldVal2 & ""
        End If

        Try
            _connection.Open()
            _adapter = New SqlDataAdapter(sql, _connection)
            _adapter.Fill(_acountsTb)

        Catch ex As SqlException

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])

        Finally

            _connection.Close()

        End Try

        For Each dr As DataRow In _acountsTb.[Select]("[RootID]=" & parentId)

            Dim t As New TreeNode()
            t.Text = dr("ValueName").ToString()
            t.Name = dr("ValueId").ToString()
            t.Tag = _acountsTb.Rows.IndexOf(dr)
            If parentNode Is Nothing Then
                TVGet.Nodes.Add(t)
                childNode = t
            Else
                parentNode.Nodes.Add(t)
                childNode = t
            End If

            DISPLAYTREEVIEW(Convert.ToInt32(dr("ValueId").ToString()), childNode, TVGet, DataTableVar)

        Next

    End Sub

    Public Enum AnimateWindowFlags

        AW_HOR_POSITIVE = &H1
        AW_HOR_NEGATIVE = &H2
        AW_VER_POSITIVE = &H4
        AW_VER_NEGATIVE = &H8
        AW_CENTER = &H10
        AW_HIDE = &H10000
        AW_ACTIVATE = &H20000
        AW_SLIDE = &H40000
        AW_BLEND = &H80000

    End Enum

    Public Enum MessageDirection
        Right
        Left
    End Enum

    Public Declare Auto Function AnimateWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal time As Integer, ByVal flags As AnimateWindowFlags) As Boolean

    Sub animateWin(ByVal frmToAnimate As Form, ByVal showForm As Integer)

        If showForm = 1 Then

            AnimateWindow(frmToAnimate.Handle, 1500, AnimateWindowFlags.AW_HOR_POSITIVE Or AnimateWindowFlags.AW_SLIDE)

        ElseIf showForm = 2 Then

            AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_NEGATIVE Or AnimateWindowFlags.AW_HIDE)

        ElseIf showForm = 3 Then

            AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_VER_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)

        End If

    End Sub

    Public Sub ShowProgress(ByVal TXTMessage As String, MessageAlgin As MessageDirection, WaitTime As Integer)


        ' Initialize the dialog that will contain the progress bar
        Dim progressDialog As New frmProgressDialog()


        If MessageAlgin = MessageDirection.Right Then

            progressDialog.lblMessage.TextAlign = ContentAlignment.BottomRight

        End If

        If MessageAlgin = MessageDirection.Left Then

            progressDialog.lblMessage.TextAlign = ContentAlignment.BottomLeft

        End If

        If isProcessRunning Then
            progressDialog.lblMessage.Text = "A process Is already running."
            Return
        End If

        ' Initialize the thread that will handle the background process
        Dim backgroundThread As New Thread(New ThreadStart(Function()

                                                               ' Set the flag that indicates if a process is currently running
                                                               isProcessRunning = True

                                                               ' Set the dialog to operate in indeterminate mode

                                                               progressDialog.lblMessage.Text = TXTMessage
                                                               progressDialog.SetIndeterminate(True)


                                                               ' Pause the thread for five seconds
                                                               Thread.Sleep(WaitTime)

                                                               ' Show a dialog box that confirms the process has completed
                                                               ' MessageBox.Show("Thread completed!");

                                                               ' Close the dialog if it hasn't been already
                                                               If progressDialog.progressBar1.InvokeRequired Then
                                                                   progressDialog.progressBar1.BeginInvoke(New Action(Sub() progressDialog.Close()))

                                                               End If

                                                               ' Reset the flag that indicates if a process is currently running
                                                               isProcessRunning = False


                                                           End Function))

        ' Start the background process thread
        backgroundThread.Start()

        ' Open the dialog
        progressDialog.ShowDialog()


    End Sub

    'Public connTemp = New SqlConnection("Data Source=Akram;Password=123;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True")
    'Public connTemp = New SqlConnection("Data Source=NADIRMUSA-PC;Password=love1972;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True")
    Public connTemp = New SqlConnection("Data Source=TMLSERVER;Password=love1972;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True")

    'Public conn = New SqlConnection("Data Source=192.168.1.107,1433;NetWork Library=DBMSSOCN;" &
    '                                                                        "Password=Omnya1012;User ID=sa;Initial Catalog=LooliSalesDB; multipleactiveresultsets=True")


    'Public conn = New SqlConnection("Data Source=Akram;Password=123;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True")

    Public conn = New SqlConnection("Data Source=TMLSERVER;Password=love1972;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True")


    'Public conn = New sql.sqlConnection("Provider=Microsoft.ACE.sql.12.0; Data Source=" & Application.StartupPath & "\DBFile.accdb;Jet sqlDatabase Password = MyOne1972;")

    'Public ConnBackup = New SqlConnection("Data Source=Akram;Password=love1972;User ID=sa;Initial Catalog=LabERPDB")

    Public ConnBackup = New SqlConnection("Data Source=TMLSERVER;Password=love1972;User ID=sa;Initial Catalog=LabERPDB")

    Public cmdBackup As SqlCommand = ConnBackup.CreateCommand

    Public ConAcc As SqlConnection

    Public cmd As SqlCommand = conn.CreateCommand
    Public cmdReader As SqlCommand = conn.createcommand
    Public cmdOther As SqlCommand = connTemp.createcommand

    Public myreader As SqlDataReader
    Public myreaderOther As SqlDataReader
    Public ReaderAcc As SqlDataReader
    Public TempReader As SqlDataReader
    Public WillReader As SqlDataReader
    Public JITReader As SqlDataReader

    Public TransOne As SqlTransaction
    Public TransTemp As SqlTransaction

    Public str As String


    Public UserChkAuther As Integer = 0

    Public Sub openconBackUp()

        If ConnBackup.State = ConnectionState.Closed Then

            ConnBackup.open()

        End If

    End Sub

    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub operationBackUp(ByVal x As String)
        Dim intRowsAffected As Integer

        Call openconBackUp()

        cmdBackup = New SqlCommand(x, ConnBackup)
        cmdBackup.CommandTimeout = 120

        intRowsAffected = cmdBackup.ExecuteNonQuery()
    End Sub

    Public Sub openconTemp()
        Try
            If connTemp.State = ConnectionState.Closed Then

                connTemp.open()

            End If

        Catch ex As Exception

            MsgBox("Check Network Connection or Server is Down", vbOKOnly, "TMLCC")

        End Try


    End Sub

    Public Sub searchOther(ByVal x As String)

        Call openconTemp()

        cmdOther = New SqlCommand(x, connTemp)

        cmdOther.CommandTimeout = 1000

        myreaderOther = cmdOther.ExecuteReader
        myreaderOther.Read()

    End Sub

    Public Sub opencon()
        Try

            If conn.State = ConnectionState.Open Then

                conn.close()

            End If

            conn.Open()

        Catch ex As Exception

            MsgBox("Check Network Connection or Server is Down", vbOKOnly, "TMLCC")

        End Try


    End Sub

    Public Sub openconSer()

        Try
            If conn.State = ConnectionState.Closed Then

                conn.open()

            End If

        Catch ex As Exception
            MsgBox("Check Network Connection or Server is Down", vbOKOnly, "TMLCC")
        End Try



    End Sub

    Public Sub frmCleanUp(ByVal frm As Form)
        Dim obj As Control
        For Each obj In frm.Controls
            If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
                obj.Text = ""
            End If
        Next
    End Sub
    Public Sub pnlCleanUp(ByVal pnl As Panel)
        Dim obj As Control
        For Each obj In pnl.Controls
            If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
                obj.Text = ""

            End If
        Next
    End Sub

    Public Sub pnlCleckUp(ByVal pnl As Panel)
        Dim obj As Control
        For Each obj In pnl.Controls
            If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
                If obj.Text = "" Then
                    MsgBox(" ÊÃœ »Ì«‰«  ‰«ﬁ’…")
                    obj.Focus()
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Public Sub frmCleckUp(ByVal frm As Form)
        Dim obj As Control
        For Each obj In frm.Controls
            If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
                If obj.Text = "" Then
                    MsgBox(" ÊÃœ »Ì«‰«  ‰«ﬁ’…")
                    obj.Focus()
                    Exit Sub
                End If

            End If
        Next
    End Sub

    Public Sub FillCombo(ByRef cboChange As ComboBox, ByVal TblName As String, ByVal DisplayField As String, ByVal ValueField As String,
                                            ByVal OrderVar As Integer, Optional ByVal ConditionVar As Integer = 0,
                                            Optional ByRef CondFiled1 As String = Nothing, Optional ByVal CondFieldVal1 As Object = Nothing,
                                            Optional ByRef CondFiled2 As String = Nothing, Optional ByVal CondFieldVal2 As Object = Nothing,
                                            Optional ByVal OrderFieldVar As Object = Nothing)

        Call opencon()

        Dim DS As New DataSet
        Dim strSQL As New SqlCommand
        Dim OrderField As String = Nothing

        If OrderVar = 1 Then

            OrderField = ValueField

        ElseIf OrderVar = 2 Then

            OrderField = DisplayField

        ElseIf OrderVar = 3 Then

            OrderField = OrderFieldVar

        End If

        If ConditionVar = 0 Then

            strSQL.CommandText = "Select " & DisplayField & ", " & ValueField & " From " & TblName & " order by " & OrderField & ""
            strSQL.Connection = conn

        ElseIf ConditionVar = 1 Then

            strSQL.CommandText = "Select " & DisplayField & ", " & ValueField & " From " & TblName & " where " & CondFiled1 & " = " &
                                            CondFieldVal1 & "  order by " & OrderField & ""
            strSQL.Connection = conn

        ElseIf ConditionVar = 2 Then

            strSQL.CommandText = "Select " & DisplayField & ", " & ValueField & " From " & TblName & " where " & CondFiled1 & " <> " &
                                            CondFieldVal1 & "  order by " & OrderField & ""
            strSQL.Connection = conn

        ElseIf ConditionVar = 3 Then

            strSQL.CommandText = "Select " & DisplayField & ", " & ValueField & " From " & TblName & " where " & CondFiled1 & " = " &
                                            CondFieldVal1 & " Or " & CondFiled2 & " = " &
                                            CondFieldVal2 & " order by " & OrderField & ""
            strSQL.Connection = conn

        ElseIf ConditionVar = 4 Then

            strSQL.CommandText = "Select " & DisplayField & ", " & ValueField & " From " & TblName & " where " & CondFiled1 & " < " &
                                            CondFieldVal1 & "  order by " & OrderField & ""
            strSQL.Connection = conn

        ElseIf ConditionVar = 5 Then

            strSQL.CommandText = "Select " & DisplayField & ", " & ValueField & " From " & TblName & " where " & CondFiled1 & " = '" &
            CondFieldVal1 & "'  order by " & OrderField & ""
            strSQL.Connection = conn

        ElseIf ConditionVar = 6 Then

            strSQL.CommandText = "Select " & DisplayField & "," & ValueField & " From " & TblName & " where " & CondFiled1 & " = " &
                                            CondFieldVal1 & " and " & CondFiled2 & " = " &
                                            CondFieldVal2 & " order by " & OrderField & ""
            strSQL.Connection = conn

        End If

        Dim DA As New SqlDataAdapter(strSQL)

        DA.Fill(DS, TblName)

        'cboChange.DropDownStyle = ComboBoxStyle.DropDownList

        Try

            With cboChange
                .DataSource = DS.Tables(TblName)
                .DisplayMember = DisplayField
                .ValueMember = ValueField
                .SelectedIndex = 0
                .FlatStyle = FlatStyle.Flat
            End With

        Catch ex As Exception

        End Try

        DA.Dispose()
        DS.Dispose()
        strSQL.Dispose()


    End Sub

    Public Sub dgvCreate(ByRef dgvTemp As DataGridView, ByVal ColType As String, ByVal ColWidth As Integer,
                                 ByVal ColDisplay As String, Optional Visiblity As Boolean = True,
                                 Optional ByVal TblName As String = Nothing,
                                 Optional ByVal DisplayField As String = Nothing,
                                 Optional ByVal ValueField As String = Nothing,
                                 Optional ByRef CondFiled1 As String = Nothing,
                                 Optional ByVal CondFieldVal1 As Object = Nothing)

        Dim dgvColText As New DataGridViewTextBoxColumn
        Dim dgvColCHK As New DataGridViewCheckBoxColumn
        Dim dgvColCombo As New DataGridViewComboBoxColumn
        Dim dgvColBottom As New DataGridViewButtonColumn
        Dim dgvColImage As New DataGridViewImageColumn

        If ColType = 1 Then

            With dgvColText

                If ColWidth = 0 And Visiblity = True Then

                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                Else
                    .Width = ColWidth

                End If

                .HeaderText = ColDisplay
                .Name = ColDisplay
                .Visible = Visiblity
            End With

            dgvTemp.Columns.Add(dgvColText)

        ElseIf ColType = 2 Then

            With dgvColCHK

                If ColWidth = 0 And Visiblity = True Then

                    .AutoSizeMode = True

                Else
                    .Width = ColWidth

                End If

                .HeaderText = ColDisplay
                .Name = ColDisplay
                .Visible = Visiblity
            End With

            dgvTemp.Columns.Add(dgvColCHK)

        ElseIf ColType = 3 Then

            Dim col As New CalendarColumn()
            col.HeaderText = ColDisplay
            col.DataPropertyName = "InvoiceDate"
            col.Visible = Visiblity
            dgvTemp.Columns.Add(col)

        ElseIf ColType = 4 Then

            With dgvColBottom

                If ColWidth = 0 And Visiblity = True Then

                    .AutoSizeMode = True

                Else
                    .Width = ColWidth

                End If
                .FlatStyle = FlatStyle.Flat
                '.HeaderText = ColDisplay
                .UseColumnTextForButtonValue = True
                .Text = ColDisplay
                '.Name = ColDisplay
                .FlatStyle = FlatStyle.System
                .DefaultCellStyle.BackColor = Color.Transparent
                .DefaultCellStyle.ForeColor = Color.White
                .Visible = Visiblity

            End With

            dgvTemp.Columns.Add(dgvColBottom)

        ElseIf ColType = 5 Then

            Call opencon()

            Dim DS As New DataSet
            Dim strSQL As New SqlCommand("Select " & DisplayField & "," & ValueField & " From " &
                                                            TblName & " order by " & DisplayField & "", conn)
            Dim DA As New SqlDataAdapter(strSQL)

            DA.Fill(DS, TblName)

            With dgvColCombo

                .DataPropertyName = "GoodNo"

                .HeaderText = ColDisplay

                If ColWidth = 0 And Visiblity = True Then

                    .AutoSizeMode = True

                Else
                    .Width = ColWidth

                End If

                'Bind ColumnCar to Cars table  

                .DataSource = DS.Tables(TblName)

                .ValueMember = ValueField

                .DisplayMember = DisplayField

                .MaxDropDownItems = 1

                .Visible = Visiblity

            End With

            dgvTemp.Columns.Add(dgvColCombo)

            'DA.Dispose()
            'DS.Clear()

            'conn.close


        ElseIf ColType = 6 Then

            Call opencon()

            Dim DS As New DataSet
            Dim strSQL As New SqlCommand("Select " & DisplayField & "," & ValueField & " From " &
                                                            TblName & " where " & CondFiled1 & " = " &
                                                            CondFieldVal1 & "  order by " & DisplayField & "", conn)
            Dim DA As New SqlDataAdapter(strSQL)

            DA.Fill(DS, TblName)

            With dgvColCombo

                .DataPropertyName = "GoodNo"

                .HeaderText = ColDisplay

                If ColWidth = 0 And Visiblity = True Then

                    .AutoSizeMode = True

                Else
                    .Width = ColWidth

                End If

                'Bind ColumnCar to Cars table  

                .DataSource = DS.Tables(TblName)

                .ValueMember = ValueField

                .DisplayMember = DisplayField

                .Visible = Visiblity

            End With

            dgvTemp.Columns.Add(dgvColCombo)

            'DA.Dispose()

            'DS.Clear()

            'conn.close

        ElseIf ColType = 7 Then

            Dim col As New TimeColumn()
            col.HeaderText = ColDisplay
            col.DataPropertyName = "Time"
            dgvTemp.Columns.Add(col)

        ElseIf ColType = 8 Then

            With dgvColImage

                .ImageLayout = DataGridViewImageCellLayout.Stretch

                If ColWidth = 0 And Visiblity = True Then

                    .AutoSizeMode = True

                Else
                    .Width = ColWidth

                End If

                .HeaderText = ColDisplay
                .Name = ColDisplay
                .Visible = Visiblity

            End With

            dgvTemp.Columns.Add(dgvColImage)

        End If

    End Sub

    Public Sub AutoCompleteFill(ByRef VarAutoComplete As AutoCompleteStringCollection, ByVal TblName As String, ByVal FillField As String,
                                            ByVal ValCHK As Integer, Optional ByRef TxTVar As TextBox = Nothing,
                                            Optional ByVal ConditionVar As Integer = 0,
                                            Optional ByRef CondFiled1 As String = Nothing, Optional ByVal CondFieldVal1 As Object = Nothing,
                                            Optional ByRef CondFiled2 As String = Nothing, Optional ByVal CondFieldVal2 As Object = Nothing,
                                            Optional ByRef CondFiled3 As String = Nothing, Optional ByVal CondFieldVal3 As Object = Nothing,
                                            Optional ByRef CondFiled4 As String = Nothing, Optional ByVal CondFieldVal4 As Object = Nothing)

        VarAutoComplete.Clear()

        Dim DS As New DataSet
        Dim strSQL As New SqlCommand

        Dim StrAuto As String = Nothing

        If ConditionVar = 0 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " order by " & FillField & ""

        ElseIf ConditionVar = 1 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = '" &
                                                    CondFieldVal1 & "' order by " & FillField & " "

        ElseIf ConditionVar = 2 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " &
                                    CondFieldVal1 & " and " & CondFiled2 & " = " &
                                    CondFieldVal2 & "  order by " & FillField & ""

        ElseIf ConditionVar = 3 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " &
                                    CondFieldVal1 & " or " & CondFiled2 & " = " &
                                    CondFieldVal2 & "  order by " & FillField & ""
        ElseIf ConditionVar = 4 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " <> '" &
                                            CondFieldVal1 & "' order by " & FillField & " "

        ElseIf ConditionVar = 5 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = '" &
                                    CondFieldVal1 & "' or " & CondFiled2 & " = '" &
                                    CondFieldVal2 & "'  order by " & FillField & ""


        ElseIf ConditionVar = 6 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = '" &
                                    CondFieldVal1 & "' or " & CondFiled2 & " = '" &
                                    CondFieldVal2 & "' or " & CondFiled3 & " = '" &
                                    CondFieldVal3 & "'  order by " & FillField & ""
        ElseIf ConditionVar = 7 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = '" &
                                    CondFieldVal1 & "' or " & CondFiled2 & " = '" &
                                    CondFieldVal2 & "' or " & CondFiled3 & " = '" &
                                    CondFieldVal3 & "' or " & CondFiled4 & " = '" &
                                    CondFieldVal4 & "'  order by " & FillField & ""
        ElseIf ConditionVar = 8 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " &
                                                                                    CondFieldVal1 & " order by " & FillField & " "

        ElseIf ConditionVar = 9 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " &
                                    CondFieldVal1 & " and " & CondFiled2 & " > " &
                                    CondFieldVal2 & "  order by " & FillField & ""

        ElseIf ConditionVar = 10 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " > " &
                                                                            CondFieldVal1 & " order by " & FillField & " "

        ElseIf ConditionVar = 11 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " &
                                    CondFieldVal1 & " and " & CondFiled2 & " = '" &
                                    CondFieldVal2 & "'  order by " & FillField & ""

        ElseIf ConditionVar = 12 Then

            StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " &
                                    CondFieldVal1 & " and " & CondFiled2 & " > " &
                                    CondFieldVal2 & "  order by " & FillField & ""

        End If

        Dim dtPosts As New DataTable()

        strSQL.CommandText = StrAuto
        strSQL.Connection = conn

        Dim DA As New SqlDataAdapter(strSQL)

        DA.Fill(DS, TblName)

        DA.Fill(dtPosts)

        Dim source As String() = dtPosts.Rows.OfType(Of DataRow)().[Select](Function(k) k(0).ToString()).ToArray()


        VarAutoComplete.AddRange(source)


        'SerTemp(StrAuto)


        'If TempReader.HasRows = True Then

        '    'VarAutoComplete.AddRange(TempReader(0))

        '    Do
        '        If Not IsDBNull(TempReader(0)) Then

        '            VarAutoComplete.Add(TempReader(0))

        '        End If

        '    Loop Until TempReader.Read = False

        'End If

        If ValCHK = 1 Then

            TxTVar.AutoCompleteCustomSource = VarAutoComplete

        End If

    End Sub

    Public Sub FillList(ByRef VarItems As AutoCompleteStringCollection, ByVal TblName As String, ByVal SelectedField As String)

        SerTemp("select " & SelectedField & "  from " & TblName & "")

        If TempReader.HasRows = True Then

            Do

                If Not IsDBNull(TempReader(0)) Then

                    VarItems.Add(TempReader(0).ToString)

                End If



            Loop Until TempReader.Read = False

        End If

    End Sub

    Public Sub AutoCompleteFillMulti(ByRef VarAutoComplete1 As AutoCompleteStringCollection,
                                     ByRef VarAutoComplete2 As AutoCompleteStringCollection,
                                     ByRef VarAutoComplete3 As AutoCompleteStringCollection,
                                     ByRef VarAutoComplete4 As AutoCompleteStringCollection,
                                     ByRef VarAutoComplete5 As AutoCompleteStringCollection,
                                     ByRef VarAutoComplete6 As AutoCompleteStringCollection,
                                     ByRef VarAutoComplete7 As AutoCompleteStringCollection,
                                     ByRef VarAutoComplete8 As AutoCompleteStringCollection,
                                     ByRef VarAutoComplete9 As AutoCompleteStringCollection,
                                     ByVal TblName As String,
                                           ByVal FillField1 As String,
                                           ByVal FillField2 As String,
                                           ByVal FillField3 As String,
                                           ByVal FillField4 As String,
                                           ByVal FillField5 As String,
                                           ByVal FillField6 As String,
                                           ByVal FillField7 As String,
                                           ByVal FillField8 As String,
                                           ByVal FillField9 As String,
                                               ByVal ValCHK As Integer,
                                                   Optional ByRef TxTVar1 As TextBox = Nothing, Optional ByRef TxTVar2 As TextBox = Nothing,
                                                   Optional ByRef TxTVar3 As TextBox = Nothing, Optional ByRef TxTVar4 As TextBox = Nothing,
                                                   Optional ByRef TxTVar5 As TextBox = Nothing, Optional ByRef TxTVar6 As TextBox = Nothing,
                                                   Optional ByRef TxTVar7 As TextBox = Nothing, Optional ByRef TxTVar8 As TextBox = Nothing,
                                                   Optional ByRef TxTVar9 As TextBox = Nothing,
                                                   Optional ByVal ConditionVar As Integer = 0,
                                                   Optional ByRef CondFiled1 As String = Nothing, Optional ByVal CondFieldVal1 As Object = Nothing,
                                                   Optional ByRef CondFiled2 As String = Nothing, Optional ByVal CondFieldVal2 As Object = Nothing)

        VarAutoComplete1.Clear()
        VarAutoComplete2.Clear()
        VarAutoComplete3.Clear()
        VarAutoComplete4.Clear()
        VarAutoComplete5.Clear()
        VarAutoComplete6.Clear()
        VarAutoComplete7.Clear()
        VarAutoComplete8.Clear()
        VarAutoComplete9.Clear()

        Dim StrAuto As String = Nothing

        If ConditionVar = 0 Then

            StrAuto = "select DISTINCT " & FillField1 & " , " & FillField2 & " , " & FillField3 & " , " & FillField4 & " , " &
                                    "" & FillField5 & " , " & FillField6 & " , " & FillField7 & " , " & FillField8 & " , " &
                                    "" & FillField9 & " from " & TblName & " order by " & FillField1 & ""

            'ElseIf ConditionVar = 1 Then

            '    StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " & CondFieldVal1 & " order by " & FillField & " "

            'ElseIf ConditionVar = 2 Then

            '    StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " & _
            '                            CondFieldVal1 & " and " & CondFiled2 & " = " & _
            '                            CondFieldVal2 & "  order by " & FillField & ""

            'ElseIf ConditionVar = 3 Then

            '    StrAuto = "select DISTINCT " & FillField & " from " & TblName & " where " & CondFiled1 & " = " & _
            '                            CondFieldVal1 & " or " & CondFiled2 & " = " & _
            '                            CondFieldVal2 & "  order by " & FillField & ""
        End If

        SerTemp(StrAuto)

        If TempReader.HasRows = True Then

            Do

                If Not IsDBNull(TempReader(0)) Then

                    VarAutoComplete1.Add(TempReader(0))

                End If

                If Not IsDBNull(TempReader(1)) Then

                    VarAutoComplete2.Add(TempReader(1))

                End If

                If Not IsDBNull(TempReader(2)) Then

                    VarAutoComplete3.Add(TempReader(2))

                End If

                If Not IsDBNull(TempReader(3)) Then

                    VarAutoComplete4.Add(TempReader(3))

                End If

                If Not IsDBNull(TempReader(4)) Then

                    VarAutoComplete5.Add(TempReader(4))

                End If

                If Not IsDBNull(TempReader(5)) Then

                    VarAutoComplete6.Add(TempReader(5))

                End If

                If Not IsDBNull(TempReader(6)) Then

                    VarAutoComplete7.Add(TempReader(6))

                End If

                If Not IsDBNull(TempReader(7)) Then

                    VarAutoComplete8.Add(TempReader(7))

                End If

                If Not IsDBNull(TempReader(8)) Then

                    VarAutoComplete9.Add(TempReader(8))

                End If

            Loop Until TempReader.Read = False

        End If

        If ValCHK = 1 Then

            TxTVar1.AutoCompleteCustomSource = VarAutoComplete1
            TxTVar2.AutoCompleteCustomSource = VarAutoComplete2
            TxTVar3.AutoCompleteCustomSource = VarAutoComplete3
            TxTVar4.AutoCompleteCustomSource = VarAutoComplete4
            TxTVar5.AutoCompleteCustomSource = VarAutoComplete5
            TxTVar6.AutoCompleteCustomSource = VarAutoComplete6
            TxTVar7.AutoCompleteCustomSource = VarAutoComplete7
            TxTVar8.AutoCompleteCustomSource = VarAutoComplete8
            TxTVar9.AutoCompleteCustomSource = VarAutoComplete9

        End If

        TempReader.Close()


    End Sub

    Public Sub dgvComboCreate(ByRef dgvTemp As DataGridView, ByVal ColWidth As Integer, ByVal ColDisplay As String, ByVal TblName As String, ByVal DisplayField As String, ByVal ValueField As String)

        Dim dgvColCombo As New DataGridViewComboBoxColumn

        Call opencon()

        Dim DS As New DataSet
        Dim strSQL As New SqlCommand("Select " & DisplayField & "," & ValueField & " From " & TblName & "", conn)
        Dim DA As New SqlDataAdapter(strSQL)

        DA.Fill(DS, TblName)

        With dgvColCombo

            .DataPropertyName = "GoodNo"

            .HeaderText = ColDisplay

            .Width = ColWidth

            'Bind ColumnCar to Cars table  

            .DataSource = DS.Tables(TblName)

            .ValueMember = ValueField

            .DisplayMember = DisplayField

        End With

        dgvTemp.Columns.Add(dgvColCombo)

        DA.Dispose()

    End Sub


    Public Sub OpenAcc()

        Try

            If ConAcc.State = ConnectionState.Open Then
                ConAcc.Close()
            End If

            ConAcc.Open()

        Catch ex As Exception

            MsgBox("Check Network Connection or Server is Down", vbOKOnly, "TMLCC")

        End Try


    End Sub

    Public Sub operation(ByVal x As String)

        Dim intRowsAffected As Integer

        Call openconSer()

        cmd = New SqlCommand(x, conn)
        cmd.CommandTimeout = 120

        intRowsAffected = cmd.ExecuteNonQuery()

    End Sub

    Public Sub OperTemp(ByVal x As String)

        Dim intRowsAffected As Integer

        Call OpenAcc()

        cmd = New SqlCommand(x, ConAcc)
        intRowsAffected = cmd.ExecuteNonQuery()
    End Sub

    Public Sub search(ByVal x As String)

        Call openconSer()

        cmdReader = New SqlCommand(x, conn)
        myreader = cmdReader.ExecuteReader
        myreader.Read()

    End Sub

    Public Sub searchAcc(ByVal x As String)

        Call OpenAcc()

        cmd = New SqlCommand(x, ConAcc)
        ReaderAcc = cmd.ExecuteReader
        ReaderAcc.Read()

    End Sub

    Public Sub SerTemp(ByVal x As String)

        Call openconSer()

        cmd = New SqlCommand(x, conn)
        TempReader = cmd.ExecuteReader
        TempReader.Read()

    End Sub

    Public Sub SerJIT(ByVal x As String)

        Call openconSer()

        cmd = New SqlCommand(x, conn)
        JITReader = cmd.ExecuteReader
        JITReader.Read()

    End Sub

    Public Sub SerWill(ByVal x As String)

        Call openconSer()

        cmd = New SqlCommand(x, conn)
        WillReader = cmd.ExecuteReader
        WillReader.Read()

    End Sub


    Public Sub GETSERVERNAMEANDDATABASENAME(ByVal rpt As Object, ByVal DATABASENAME As String) ', Optional ByVal PASSWORD As String = "", Optional ByVal USER As String = "")

        Dim I As Integer
        Dim TBL1 As New CrystalDecisions.Shared.TableLogOnInfo

        TBL1.ConnectionInfo.ServerName = "TMLSERVER"
        'TBL1.ConnectionInfo.ServerName = "Akram"
        'TBL1.ConnectionInfo.ServerName = "NADIRMUSA-PC"


        TBL1.ConnectionInfo.DatabaseName = DATABASENAME

        TBL1.ConnectionInfo.UserID = "sa"
        'TBL1.ConnectionInfo.Password = "123"
        TBL1.ConnectionInfo.Password = "love1972"

        'TBL1.ConnectionInfo.IntegratedSecurity = True

        For I = 0 To rpt.Database.Tables.Count - 1

            rpt.Database.Tables(I).ApplyLogOnInfo(TBL1)

        Next I

    End Sub

    Public Class Sound

        Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name _
          As String, ByVal hmod As Integer, ByVal flags As Integer) As Integer

        Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name _
          As Byte(), ByVal hmod As Integer, ByVal flags As Integer) As Integer

        Public Const SND_SYNC = &H0 ' play synchronously 

        Public Const SND_ASYNC = &H1 ' play asynchronously 

        Public Const SND_MEMORY = &H4  'Play wav in memory

        Public Const SND_ALIAS = &H10000 'Play system alias wav 

        Public Const SND_NODEFAULT = &H2
        Public Const SND_FILENAME = &H20000 ' name is file name 

        Public Const SND_RESOURCE = &H40004 ' name is resource name or atom 


    End Class

End Module

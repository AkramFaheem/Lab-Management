Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmReportCenter
    Public RepOption As String

    Private Sub BtnGenerateReport_Click(sender As Object, e As EventArgs) Handles BtnGenerateReport.Click

        If Not RBtHisto.Checked And Not RBtHaematology.Checked And RBtCommon10.Checked Then
            MsgBox("Please choose one of the option under search criteria", vbOKOnly, "TMLCC")
        End If

        Dim Canreg As Integer
        Dim ProfileID As Integer
        Canreg = Convert.ToInt32(CmbCanreg.SelectedValue)
        ProfileID = Convert.ToInt32(CMBProfiles.SelectedValue)

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try
            Dim Rpt As New StatisticRep
            Dim RptHCR As New CRHaemCanRep
            Dim RptProfile As New CRProfiles
            Select Case [RepOption]

                Case "Histopathology"

                    GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                    Rpt.ParameterFields("From").CurrentValues.AddValue(DTPFrom.Value)
                    Rpt.ParameterFields("To").CurrentValues.AddValue(DTPTo.Value)

                    Rpt.RecordSelectionFormula = "{V_H_CanRegRep.CanRegID} = " & Canreg & ""

                    FrmReport.CRView.ReportSource = Rpt
                    FrmReport.CRView.Zoom(1)
                    'FrmReport.CRView.RefreshReport()
                    FrmReport.Show()

                Case "Haematolgy"

                    GETSERVERNAMEANDDATABASENAME(RptHCR, "LabERPDB")
                    RptHCR.ParameterFields("From").CurrentValues.AddValue(DTPFrom.Value)
                    RptHCR.ParameterFields("To").CurrentValues.AddValue(DTPTo.Value)

                    RptHCR.RecordSelectionFormula = "{V_Haem_CanRegRep.CanRegID} = " & Canreg & ""

                    FrmReport.CRView.ReportSource = RptHCR
                    FrmReport.CRView.Zoom(1)
                    'FrmReport.CRView.RefreshReport()
                    FrmReport.Show()

                Case "Common10"

                Case "HistbySex"

                Case "HaembySex"

                Case "Hisagerang"

                Case "Haemagerang"

                Case Else

                    If ProfileID = 1 Or ProfileID = 2 Then
                        MsgBox("Histopathology/Haematology reports are not applicable from this link", vbOKOnly, "TMLCC report center")

                    ElseIf ProfileID > 2 Then

                        GETSERVERNAMEANDDATABASENAME(RptProfile, "LabERPDB")
                        RptProfile.ParameterFields("From").CurrentValues.AddValue(DTPFrom.Value)
                        RptProfile.ParameterFields("To").CurrentValues.AddValue(DTPTo.Value)

                        RptProfile.RecordSelectionFormula = "{V_Profiles.TestId} = " & ProfileID & ""

                        FrmReport.CRView.ReportSource = RptProfile
                        FrmReport.CRView.Zoom(1)
                        'FrmReport.CRView.RefreshReport()
                        FrmReport.Show()

                    End If





            End Select


        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub ComboFill()


        If RBtHisto.Checked = True Then

            Call FillCombo(CmbCanreg, "BasCancers", "InternationalCode", "CanRegID", 1, 1, "TestId", 2)

        ElseIf RBtHaematology.Checked = True Then

            Call FillCombo(CmbCanreg, "BasCancers", "InternationalCode", "CanRegID", 1, 1, "TestId", 1)

        ElseIf RBtCommon10.Checked = True Then

            CmbCanreg.Enabled = False

        End If

    End Sub

    Private Sub RBtHisto_CheckedChanged(sender As Object, e As EventArgs) Handles RBtHisto.CheckedChanged
        If RBtHisto.Checked = True Then

            Call ComboFill()

            RepOption = "Histopathology"

        End If
    End Sub

    Private Sub RBtHaematology_CheckedChanged(sender As Object, e As EventArgs) Handles RBtHaematology.CheckedChanged

        If RBtHaematology.Checked = True Then

            Call ComboFill()

            RepOption = "Haematolgy"

        End If
    End Sub

    'Private Sub RBtCommon10_CheckedChanged(sender As Object, e As EventArgs) Handles RBtCommon10.CheckedChanged

    '    If RBtCommon10.Checked = True Then

    '        Call ComboFill()

    '    End If
    'End Sub

    Private Sub FrmReportCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillCombo(CMBProfiles, "TestsMaster", "TestName", "TestId", 1, 0, "TestId")
    End Sub

    Private Sub DTPFrom_Click(sender As Object, e As EventArgs) Handles DTPFrom.Click


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        '        Dim Count As Integer = 0
        '        Dim PatName As String = Nothing
        '        Dim Patid, exam_id, clinicalinfo, Prefix, request, consultant, frq_date, comment, canreg_id, rep_date, Lab_no, frq As String

        '        PBar.Minimum = 0
        '        PBar.Maximum = 6175
        '        Dim StrConn As String = "Data Source=Akram;Password=123;User ID=sa;Initial Catalog=LabERPDB; multipleactiveresultsets=True"
        '        Dim SqlCon As SqlConnection

        '        SqlCon = New SqlConnection(StrConn)

        '#Region "Merge"
        '        search("select * from master_detalis where exam_id = '2' and canreg_id <> '1'")

        '        'opencon()

        '        'TransOne = conn.BeginTransaction

        '        'cmd.Connection = conn

        '        'cmd.Transaction = TransOne

        '        Try
        '            If myreader.HasRows Then

        '                Do


        '                    Count = Count + 1
        '                    PBar.Value = Count
        '                    SerJIT("Select CanRegID from BasCancers where canreg_id ='" & myreader(7).ToString & "'")
        '                    If JITReader.HasRows Then

        '                        SerTemp("select DescripName from CrDrMaster where pat_id = " & myreader(0) & "")
        '                        If TempReader.HasRows Then
        '                            PatName = TempReader(0).ToString
        '                            Patid = myreader(0).ToString
        '                            exam_id = myreader(1).ToString
        '                            clinicalinfo = myreader(2).ToString
        '                            request = myreader(3).ToString
        '                            consultant = myreader(4).ToString
        '                            frq_date = myreader(5).ToString
        '                            comment = myreader(6).ToString
        '                            canreg_id = JITReader(0).ToString
        '                            rep_date = myreader(8).ToString
        '                            Lab_no = myreader(9).ToString
        '                            frq = myreader(10).ToString
        '                            Prefix = "Case"


        '                            Using (SqlCon)

        '                                Dim sqlComm As New SqlCommand
        '                                sqlComm.Connection = SqlCon
        '                                sqlComm.CommandText = "InsertTransactionMaster"
        '                                sqlComm.CommandType = CommandType.StoredProcedure
        '                                sqlComm.Parameters.AddWithValue("TransDate", frq_date)
        '                                sqlComm.Parameters.AddWithValue("YearID", 2022)
        '                                sqlComm.Parameters.AddWithValue("MonthID", 1)
        '                                sqlComm.Parameters.AddWithValue("TransType", 10)
        '                                sqlComm.Parameters.AddWithValue("Prefix", Prefix)
        '                                sqlComm.Parameters.AddWithValue("PayeeName  ", PatName)
        '                                sqlComm.Parameters.AddWithValue("UserID", 13)
        '                                sqlComm.Parameters.AddWithValue("RecStatus", 2)
        '                                sqlComm.Parameters.AddWithValue("clinic_info", clinicalinfo)
        '                                sqlComm.Parameters.AddWithValue("request", request)
        '                                sqlComm.Parameters.AddWithValue("consultant", consultant)
        '                                sqlComm.Parameters.AddWithValue("Macro", comment)
        '                                sqlComm.Parameters.AddWithValue("CanRegID", canreg_id)
        '                                sqlComm.Parameters.AddWithValue("ReportDate", rep_date)
        '                                sqlComm.Parameters.AddWithValue("frq", frq)
        '                                sqlComm.Parameters.AddWithValue("PrintDate", rep_date)
        '                                sqlComm.Parameters.AddWithValue("AccountNo", Patid)
        '                                sqlComm.Parameters.AddWithValue("TestId", exam_id)
        '                                sqlComm.Parameters.AddWithValue("ProfileName", request)
        '                                sqlComm.Parameters.AddWithValue("LabNo", 0)
        '                                sqlComm.Parameters.AddWithValue("HistoLabNo", Lab_no)
        '                                SqlCon.Open()
        '                                sqlComm.ExecuteNonQuery()

        '                            End Using
        '                            'operation("INSERT INTO [TransactionsMaster] ([TransDate],[YearID],[MonthID] ,[TransType]" &
        '                            '                                            ",[Prefix],[PayeeName],[UserID],[RecStatus],[clinic_info]" &
        '                            '                                            ",[request],[consultant],[Macro],[CanRegID],[ReportDate]" &
        '                            '                                            ", [frq], [PrintDate], [AccountNo], [TestId], [ProfileName], [LabNo], [HistoLabNo]) VALUES ('" &
        '                            '                                             frq_date & "','2022','1','10','Case','" &
        '                            '                                             PatName & "','13','2','" &
        '                            '                                             clinicalinfo & "','" &
        '                            '                                             request & "','" & consultant & "','" & comment & "','" &
        '                            '                                             canreg_id & "','" & rep_date & "','" & frq & "','" & Now.Date & "','" &
        '                            '                                             Patid & "','" & exam_id & "','" & request & "','0','" & Lab_no & "')")
        '                        End If

        '                    End If
        '                Loop Until myreader.Read = False

        '                Dim response As String
        '                response = MsgBox("Record mereged are =", Count)


        '            End If

        '            'cmd.ExecuteNonQuery()
        '            'TransOne.Commit()
        '        Catch ex As Exception

        '            MsgBox(ex.Message)
        '            'Dim FrmError As New FrmMessageBox
        '            'Dim ResultError

        '            'ResultError = FrmError.ShowMessage(ex.Message, "TMLCC",
        '            '                           MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

        '            'TransOne.Rollback()

        '        Finally
        '            conn.Close()

        '        End Try




        '#End Region


    End Sub

    Private Sub PBar_Click(sender As Object, e As EventArgs) Handles PBar.Click

    End Sub


End Class
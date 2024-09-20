
Module modWIA

    Public Function _WiaErrCode(Optional ByVal exMessage As String = "") As String
        Dim msgStr As String = ""
        Dim errNumber As String = ""

        Dim posFound As Integer = InStr(exMessage, ":")

        If posFound <> 0 Then
            errNumber = Mid(exMessage, posFound + 2)
            msgStr = errNumber
        End If

        Return msgStr

    End Function

    Public Sub _DeleteTemporaryImages()


        Dim _Path As String = _DefaultPathname

        If Not My.Computer.FileSystem.DirectoryExists(_Path) Then GoTo Exit_Here

        Try
            For Each filename As String In My.Computer.FileSystem.GetFiles(_Path)

                Debug.Print(filename)
                My.Computer.FileSystem.DeleteFile(filename)

            Next

        Catch ex As Exception

            Debug.Print("Error: " & ex.Message)

        End Try

Exit_Here:

    End Sub

End Module

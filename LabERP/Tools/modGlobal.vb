
Module modGlobal

    Public Const _ScannedImageFilename As String = "\Scanned_Image-"

    Public ReadOnly Property _DefaultPathname() As String
        Get
            Dim pathname As String = My.Application.Info.DirectoryPath

            pathname &= "\temp"

            Return pathname
        End Get
    End Property

End Module

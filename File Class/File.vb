Public MustInherit Class File

    Protected fileName As String
    Protected fileType As Integer ' 0:OPTION ; 1:MAT ; 2:Assem ; 3:FA .

    Public Function getFileName() As String
        Return Me.fileName
    End Function

    Public Function getFileType() As Integer
        Return Me.fileType
    End Function

    Public MustOverride Sub generateFile()

End Class

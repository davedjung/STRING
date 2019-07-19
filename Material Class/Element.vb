Public Class Element

    Private atomicInfo As String
    Private numberDensity As String

    Public Sub New(atomicInfo As String)
        Me.atomicInfo = atomicInfo
    End Sub

    Public Sub setNumberDensity(numberDensity As String)
        Me.numberDensity = numberDensity
    End Sub

    Public Function toString() As String
        Dim output = ""
        output = atomicInfo & "  " & numberDensity
        Return output
    End Function

End Class

Public Class PrefabMaterial
    Inherits Material

    Private options() As String

    Public Sub New(materialName As String, identifier As String)
        Me.materialName = materialName
        Me.identifier = identifier
        Me.isPrefab = True
    End Sub

    Public Sub setOption(input As String())
        Me.options = input
    End Sub

    Public Function getAllOption() As String()
        Return Me.options
    End Function

    Public Overrides Function toString() As String

        Dim output = ""

        output = output & "MAT " & Me.identifier & vbNewLine

        If Me.materialName = "GAP" Then
            output = output & ""
        Else
            output = output & Me.materialName & " "
        End If
        For i = 0 To options.Length() - 1 Step 1
            output = output & options(i) & " "
        Next

        Return output

    End Function

End Class

Public Class PinMaterial

    Private outerRadius As String
    Private materialName As String
    Private temperature As String

    Public Sub New(outerRadius As String, materialName As String, temperature As String)
        Me.outerRadius = outerRadius
        Me.materialName = materialName
        Me.temperature = temperature
    End Sub

    Public Function getOuterRadius() As Double
        Return CDbl(Me.outerRadius)
    End Function

    Public Overrides Function ToString() As String
        Dim output = ""
        output = output & outerRadius & " "
        output = output & String.Format("{0, -6}", materialName) & " "
        output = output & temperature
        Return output
    End Function

End Class

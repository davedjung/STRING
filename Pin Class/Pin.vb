Public Class Pin

    Private pinID As String
    Private sectorCount As String
    Private innerSector As String
    Private outerSector As String
    Private pinMaterial As List

    Public Sub New(ID As String, sectorCount As String, innerSector As String, outerSector As String)
        Me.pinID = ID
        Me.sectorCount = sectorCount
        Me.innerSector = innerSector
        Me.outerSector = outerSector
        pinMaterial = New List()
    End Sub

    Public Sub addPinMaterial(material As PinMaterial)
        pinMaterial.addItem(material)
    End Sub

    Public Function getPinID() As String
        Return Me.pinID
    End Function

    Public Function getAllPinMaterial() As List
        Return pinMaterial
    End Function

    Public Overrides Function ToString() As String

        Dim output = ""
        output = output & "Pin " & pinID & " % " & sectorCount & " @ " & innerSector & " " & outerSector & vbNewLine

        For i = 0 To pinMaterial.length() Step 1
            output = output & pinMaterial.getItem(i).ToString() & vbNewLine
        Next

        Return output

    End Function

End Class

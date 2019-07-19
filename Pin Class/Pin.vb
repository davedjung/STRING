Public Class Pin

    Private pinID As String
    Private sectorCount As String
    Private innerSector As String
    Private outerSector As String
    Private pinMaterial(0) As PinMaterial

    Public Sub New(ID As String, sectorCount As String, innerSector As String, outerSector As String)
        Me.pinID = ID
        Me.sectorCount = sectorCount
        Me.innerSector = innerSector
        Me.outerSector = outerSector
    End Sub

    Public Sub addPinMaterial(material As PinMaterial)
        Dim pinMaterialCount As Integer
        If IsNothing(pinMaterial(0)) Then
            pinMaterialCount = 0
        Else
            pinMaterialCount = pinMaterial.Length()
        End If
        Dim newPinMaterialList(pinMaterialCount) As PinMaterial
        For i = 0 To pinMaterialCount - 1 Step 1
            newPinMaterialList(i) = Me.pinMaterial(i)
        Next
        newPinMaterialList(pinMaterialCount) = material
        Me.pinMaterial = newPinMaterialList
    End Sub

    Public Function getPinID() As String
        Return Me.pinID
    End Function

    Public Function getAllPinMaterial() As PinMaterial()
        Return Me.pinMaterial
    End Function

    Public Overrides Function ToString() As String

        Dim output = ""
        output = output & "Pin " & pinID & " % " & sectorCount & " @ " & innerSector & " " & outerSector & vbNewLine

        For i = 0 To pinMaterial.Length() - 1 Step 1
            output = output & pinMaterial(i).ToString() & vbNewLine
        Next

        Return output

    End Function

End Class

Public Class CustomMaterial
    Inherits Material

    Private composition(0) As Element

    Public Sub New(materialName As String, identifier As String, burnable As Boolean)
        Me.materialName = materialName
        Me.identifier = identifier
        Me.isBurnable = burnable
        Me.isPrefab = False
    End Sub

    Public Sub addComposition(composition As Element)
        Dim compositionCount As Integer
        If IsNothing(Me.composition(0)) Then
            compositionCount = 0
        Else
            compositionCount = Me.composition.Length()
        End If
        Dim newCompositionList(compositionCount) As Element
        For i = 0 To compositionCount - 1 Step 1
            newCompositionList(i) = Me.composition(i)
        Next
        newCompositionList(compositionCount) = composition
        Me.composition = newCompositionList
    End Sub

    Public Sub removeComposition(index As Integer)
        Dim elementCount As Integer
        elementCount = Me.composition.Length()
        For i = index To elementCount - 2 Step 1
            Me.composition(i) = Me.composition(i + 1)
        Next
        Dim newElementList(elementCount - 2) As Element
        For i = 0 To elementCount - 2 Step 1
            newElementList(i) = Me.composition(i)
        Next
        Me.composition = newElementList
    End Sub

    Public Function getAllComposition() As Element()
        Return Me.composition
    End Function

    Public Overrides Function toString() As String

        Dim output = ""

        output = output & "MAT " & materialName & vbNewLine

        For i = 0 To composition.Length() - 1 Step 1
            output = output & composition(i).toString() & vbNewLine
        Next

    End Function

End Class

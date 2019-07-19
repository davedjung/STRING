Public Class Homogeneous

    Private homoName As String
    Private composition(0) As String

    Public Sub New(name As String)
        Me.homoName = name
    End Sub

    Public Sub addComposition(composition As String)
        Dim compositionCount As Integer
        If IsNothing(Me.composition(0)) Then
            compositionCount = 0
        Else
            compositionCount = Me.composition.Length()
        End If
        Dim newCompositionList(compositionCount) As String
        For i = 0 To compositionCount - 1 Step 1
            newCompositionList(i) = Me.composition(i)
        Next
        newCompositionList(compositionCount) = composition
        Me.composition = newCompositionList
    End Sub

    Public Sub removeComposition(index As Integer)
        Dim compositionCount = Me.composition.Length()
        For i = index To compositionCount - 2 Step 1
            Me.composition(i) = Me.composition(i + 1)
        Next
        Dim newCompositionList(compositionCount - 2) As String
        For i = 0 To compositionCount - 2 Step 1
            newCompositionList(i) = Me.composition(i)
        Next
        Me.composition = newCompositionList
    End Sub

    Public Function getAllComposition() As String()
        Return Me.composition
    End Function

    Public Function getName() As String
        Return Me.homoName
    End Function

    Public Overrides Function ToString() As String

        Dim output = ""

        output = output & "HOMO " & homoName & vbNewLine
        For i = 0 To composition.Length() - 1 Step 1
            output = output & composition(i) & vbNewLine
        Next

        Return output

    End Function

End Class

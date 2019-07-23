Imports System.IO

Public Class MaterialFile
    Inherits File

    Private material(0) As Material
    Private homogeneous(0) As Homogeneous

    Public Sub New(fileName As String)
        Me.fileName = fileName
        Me.fileType = 1
    End Sub

    Public Sub addMaterial(material As Material)
        Dim materialCount As Integer
        If IsNothing(Me.material(0)) Then
            materialCount = 0
        Else
            materialCount = Me.material.Length()
        End If
        Dim newMaterialList(materialCount) As Material
        For i = 0 To materialCount - 1 Step 1
            newMaterialList(i) = Me.material(i)
        Next
        newMaterialList(materialCount) = material
        Me.material = newMaterialList
    End Sub

    Public Sub removeMaterial(index As Integer)
        Dim materialCount As Integer
        materialCount = Me.material.Length()
        For i = index To materialCount - 2 Step 1
            Me.material(i) = Me.material(i + 1)
        Next
        Dim newMaterialList(materialCount - 2) As Material
        For i = 0 To materialCount - 2 Step 1
            newMaterialList(i) = Me.material(i)
        Next
        Me.material = newMaterialList
    End Sub

    Public Function getAllMaterial() As Material()
        Return Me.material
    End Function

    Public Sub addHomo(homogeneous As Homogeneous)
        Dim homoCount As Integer
        If IsNothing(Me.homogeneous(0)) Then
            homoCount = 0
        Else
            homoCount = Me.homogeneous.Length()
        End If
        Dim newHomoList(homoCount) As Homogeneous
        For i = 0 To homoCount - 1 Step 1
            newHomoList(i) = Me.homogeneous(i)
        Next
        newHomoList(homoCount) = homogeneous
        Me.homogeneous = newHomoList
    End Sub

    Public Sub removeHomo(index As Integer)
        Dim homoCount As Integer
        homoCount = Me.homogeneous.Length()
        For i = index To homoCount - 2 Step 1
            Me.homogeneous(i) = Me.homogeneous(i + 1)
        Next
        Dim newHomoList(homoCount - 2) As Homogeneous
        For i = 0 To homoCount - 2 Step 1
            newHomoList(i) = Me.homogeneous(i)
        Next
        Me.homogeneous = newHomoList
    End Sub

    Public Function getAllHomogeneous() As Homogeneous()
        Return Me.homogeneous
    End Function

    Public Overrides Sub generateFile()

        Dim filePath As String
        filePath = MainMenu.getPath() & "\" & Me.fileName
        Dim output = ""

        If Not IsNothing(material(0)) Then
            For i = 0 To material.Length() - 1 Step 1
                output = output & "MAT " & material(i).getIdentifier()
                If Not material(i).getPrefab() And material(i).getBurnable() Then output = output & " BURN"
                output = output & vbNewLine
                If material(i).getPrefab() Then
                    output = output & material(i).getName() & " "
                    Dim optionList() = DirectCast(material(i), PrefabMaterial).getAllOption()
                    For j = 0 To optionList.Length() - 1 Step 1
                        output = output & optionList(j) & " "
                    Next
                    output = output & vbNewLine
                Else
                    Dim compositionList() = DirectCast(material(i), CustomMaterial).getAllComposition()
                    For j = 0 To compositionList.Length() - 1 Step 1
                        output = output & compositionList(j).toString() & vbNewLine
                    Next
                End If
                output = output & vbNewLine
            Next
        End If

        If IsNothing(homogeneous(0)) Then Exit Sub
        For i = 0 To homogeneous.Length() - 1 Step 1
            output = output & "HOMO " & homogeneous(i).getName() & vbNewLine
            Dim compositionList() = homogeneous(i).getAllComposition()
            For j = 0 To compositionList.Length() - 1 Step 1
                output = output & compositionList(j) & vbNewLine
            Next
            output = output & vbNewLine
        Next

        My.Computer.FileSystem.WriteAllText(filePath, output, False)


    End Sub

End Class

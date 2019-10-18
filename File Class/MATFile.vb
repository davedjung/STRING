Imports System.IO

Public Class MATFile
    Inherits File

    Private materialList As List

    Public Sub New(fileName As String)
        Me.fileName = fileName
        Me.fileType = 1
        materialList = New List()
    End Sub

    Public Sub addMaterial(material As Material)
        materialList.addItem(material)
    End Sub

    Public Sub removeMaterial(index As Integer)
        materialList.removeItem(index)
    End Sub

    Public Function getAllMaterial() As Material()
        Dim allMaterial(materialList.length()) As Material
        For i = 0 To materialList.length()
            allMaterial(i) = materialList.getItem(i)
        Next
        Return allMaterial
    End Function


    Public Overrides Sub generateFile(ByVal path As String)

        Dim filePath = path & "\" & Me.fileName
        Dim output = ""

        If Not materialList.isEmpty() Then
            For i = 0 To materialList.length() Step 1
                output = output & "MAT " & materialList.getItem(i).getIdentifier()
                If Not materialList.getItem(i).getPrefab() And materialList.getItem(i).getBurnable() Then output = output & " BURN"
                output = output & vbNewLine
                If materialList.getItem(i).getPrefab() Then
                    If materialList.getItem(i).getName() <> "GAP" Then
                        output = output & materialList.getItem(i).getName() & " "
                    End If
                    Dim optionList() = DirectCast(materialList.getItem(i), PrefabMaterial).getAllOption()
                    For j = 0 To optionList.Length() - 1 Step 1
                        output = output & optionList(j) & " "
                    Next
                    output = output & vbNewLine
                Else
                    Dim compositionList() = DirectCast(materialList.getItem(i), CustomMaterial).getAllComposition()
                    For j = 0 To compositionList.Length() - 1 Step 1
                        output = output & compositionList(j).toString() & vbNewLine
                    Next
                End If
                output = output & vbNewLine
            Next
        End If


        Dim UTFwithoutBOM As New System.Text.UTF8Encoding(False)
        My.Computer.FileSystem.WriteAllText(filePath, output, False, UTFwithoutBOM)


    End Sub

End Class

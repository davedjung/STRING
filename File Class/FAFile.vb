Imports System.IO

Public Class FAFile
    Inherits File

    Private FA(0) As FuelAssembly

    Public Sub New(fileName As String)
        Me.fileName = fileName
        Me.fileType = 3
    End Sub

    Public Sub addFuelAssembly(FA As FuelAssembly)
        Dim FACount As Integer
        If IsNothing(Me.FA(0)) Then
            FACount = 0
        Else
            FACount = Me.FA.Length()
        End If
        Dim newFAList(FACount) As FuelAssembly
        For i = 0 To FACount - 1 Step 1
            newFAList(i) = Me.FA(i)
        Next
        newFAList(FACount) = FA
        Me.FA = newFAList
    End Sub

    Public Function getAllFuelAssembly() As FuelAssembly()
        Return Me.FA
    End Function

    Public Overrides Sub generateFile()

        Dim filePath As String
        filePath = MainMenu.getPath() & "\" & Me.fileName
        Dim output = ""

        Dim FACount = Me.FA.Length()
        For i = 0 To FACount - 1 Step 1
            output = output & "FA " & FA(i).getIndex() & " " & FA(i).getDimension() & " " & FA(i).getDimension() & " "
            output = output & FA(i).getPitch() & " " & FA(i).getMaterial() & " " & FA(i).getInletTemperature() & vbNewLine
            For j = 0 To FA(i).getDimension() - 1 Step 1
                For k = 0 To FA(i).getDimension() - 1 Step 1
                    output = output & FA(i).getPinConfiguration()(j, k) & " "
                Next
                output = output & vbNewLine
            Next
            output = output & "SEG " & FA(i).getHalfAssemGap() & vbNewLine
            output = output & vbNewLine
        Next

        My.Computer.FileSystem.WriteAllText(filePath, output, False)

    End Sub

End Class

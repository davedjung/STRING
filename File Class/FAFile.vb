Imports System.IO

Public Class FAFile
    Inherits File

    Private FA As List

    Public Sub New(fileName As String)
        Me.fileName = fileName
        Me.fileType = 3
        FA = New List()
    End Sub

    Public Sub addFuelAssembly(FA As FuelAssembly)
        Me.FA.addItem(FA)
    End Sub

    Public Function getAllFuelAssembly() As List
        Return Me.FA
    End Function

    Public Overrides Sub generateFile(ByVal path As String)

        Dim filePath As String
        filePath = path & "\" & Me.fileName
        Dim output = ""

        Dim FACount = Me.FA.Length()
        For i = 0 To FACount Step 1
            output = output & "FA " & FA.getItem(i).getIndex() & " " & FA.getItem(i).getDimension() & " " & FA.getItem(i).getDimension() & " "
            output = output & FA.getItem(i).getPitch() & " " & FA.getItem(i).getMaterial() & " " & FA.getItem(i).getInletTemperature() & vbNewLine
            For j = 0 To FA.getItem(i).getDimension() - 1 Step 1
                For k = 0 To FA.getItem(i).getDimension() - 1 Step 1
                    output = output & FA.getItem(i).getPinConfiguration()(j, k) & " "
                Next
                output = output & vbNewLine
            Next
            output = output & "SEG " & FA.getItem(i).getHalfAssemGap() & vbNewLine
            output = output & vbNewLine
        Next

        Dim UTFwithoutBOM As New System.Text.UTF8Encoding(False)
        My.Computer.FileSystem.WriteAllText(filePath, output, False, UTFwithoutBOM)

    End Sub

End Class

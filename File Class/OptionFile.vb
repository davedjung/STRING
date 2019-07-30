Imports System.IO

Public Class OptionFile
    Inherits File

    Private XSLIB As Integer 'Index
    Private DEPLIB As Integer 'Index
    Private KAPPALIB As Integer 'Index
    Private DET As Integer 'Index
    Private ONstatus() As Boolean
    Private CRI As Integer 'Index
    Private BRANCH As Integer 'Index
    Private H2OTemp As String 'Format(,"0.0")
    Private H2OBoron As String 'Format(,"0.0")
    Private DEPPower As String 'Format(,"0.00")
    Private DEPBurnup As String ' Format(,"0.0")

    Sub New(ByVal fileName As String)
        Me.fileName = fileName
        Me.fileType = 0
    End Sub
    Public Function getXSLIB() As Integer
        Return Me.XSLIB
    End Function
    Public Function getDEPLIB() As Integer
        Return Me.DEPLIB
    End Function
    Public Function getKAPPALIB() As Integer
        Return Me.KAPPALIB
    End Function
    Public Function getDET() As Integer
        Return Me.DET
    End Function
    Public Function getON() As Boolean()
        Return Me.ONstatus
    End Function
    Public Function getCRI() As Integer
        Return Me.CRI
    End Function
    Public Function getBRANCH() As Integer
        Return Me.BRANCH
    End Function
    Public Function getH2OTemp() As String
        Return Me.H2OTemp
    End Function
    Public Function getH2OBoron() As String
        Return Me.H2OBoron
    End Function
    Public Function getDEPPower() As String
        Return Me.DEPPower
    End Function
    Public Function getDEPBurnup() As String
        Return Me.DEPBurnup
    End Function
    Public Sub setXSLIB(XSLIB As Integer)
        Me.XSLIB = XSLIB
    End Sub
    Public Sub setDEPLIB(DEPLIB As Integer)
        Me.DEPLIB = DEPLIB
    End Sub
    Public Sub setKAPPALIB(KAPPALIB As Integer)
        Me.KAPPALIB = KAPPALIB
    End Sub
    Public Sub setDET(DET As Integer)
        Me.DET = DET
    End Sub
    Public Sub setON(ONstatus As Boolean())
        Me.ONstatus = ONstatus
    End Sub
    Public Sub setCRI(CRI As Integer)
        Me.CRI = CRI
    End Sub
    Public Sub setBRANCH(BRANCH As Integer)
        Me.BRANCH = BRANCH
    End Sub
    Public Sub setH2OTemp(temp As Double)
        Me.H2OTemp = Format(temp, "0.0")
    End Sub
    Public Sub setH2OBoron(boron As Double)
        Me.H2OBoron = Format(boron, "0.0")
    End Sub
    Public Sub setDEPPower(power As Double)
        Me.DEPPower = Format(power, "0.00")
    End Sub
    Public Sub setDEPBurnup(burnup As Double)
        Me.DEPBurnup = Format(burnup, "0.0")
    End Sub



    Public Overrides Sub generateFile()
        Dim filePath As String
        filePath = MainMenu.getPath() & "\" & Me.fileName
        Dim output As String
        output = ""

        Dim content() As String

        findContent("XSLIB", content)
        output = output & "XSLIB " & content(Me.XSLIB) & vbNewLine
        findContent("DEPLIB", content)
        output = output & "DEPLIB " & content(Me.DEPLIB) & vbNewLine
        findContent("KAPPALIB", content)
        output = output & "KAPPALIB " & content(Me.KAPPALIB) & vbNewLine
        findContent("DET", content)
        output = output & "DET " & content(Me.DET) & vbNewLine

        findContent("ON", content)
        output = output & "ON "
        For i = 0 To content.Length - 1 Step 1
            If Me.ONstatus(i) Then output = output & content(i) & " "
        Next
        output = output & vbNewLine

        findContent("CRI", content)
        output = output & "CRI " & content(Me.CRI) & vbNewLine
        findContent("BRANCH", content)
        output = output & "BRANCH " & content(Me.BRANCH) & vbNewLine

        output = output & "H2O " & Me.H2OTemp & " " & Me.H2OBoron & vbNewLine
        output = output & "DEP " & Me.DEPPower & " -" & Me.DEPBurnup

        Dim UTFwithoutBOM As New System.Text.UTF8Encoding(False)
        My.Computer.FileSystem.WriteAllText(filePath, output, False, UTFwithoutBOM)

    End Sub

    Private Sub findContent(ByVal target As String, ByRef content() As String)
        Dim dataFile As String = My.Resources.OPTION_DATA
        Dim line As String
        Dim reader As TextReader = New StringReader(dataFile)

        line = reader.ReadLine
        Do While line <> "END OF FILE"
            If line = target Then
                line = reader.ReadLine()
                content = line.Split("#")
                Exit Do
            End If
            line = reader.ReadLine()
        Loop
    End Sub

End Class

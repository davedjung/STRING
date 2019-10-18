Imports System.IO

Public Class AssemFile
    Inherits File

    Private LINK(2) As Boolean
    Private SPA(2) As String
    Private pin As List
    Private CORE(2) As String

    Public Sub New(fileName As String)
        Me.fileName = fileName
        Me.fileType = 2
        pin = New List()
    End Sub

    Public Sub setLINK(LINK As Boolean())
        Me.LINK = LINK
    End Sub

    Public Sub setSPA(SPA As String())
        Me.SPA = SPA
    End Sub

    Public Sub addPin(pin As Pin)
        Me.pin.addItem(pin)
    End Sub

    Public Sub removePin(index As Integer)
        pin.removeItem(index)
    End Sub

    Public Sub setCORE(CORE As String())
        Me.CORE = CORE
    End Sub

    Public Function getLINK() As Boolean()
        Return Me.LINK
    End Function

    Public Function getSPA() As String()
        Return Me.SPA
    End Function

    Public Function getAllPin() As List
        Return pin
    End Function

    Public Function getPin(index As Integer) As Pin
        Return Me.pin.getItem(index)
    End Function

    Public Function getCORE() As String()
        Return Me.CORE
    End Function

    Public Overrides Sub generateFile(ByVal path As String)

        Dim filePath = path & "\" & Me.fileName
        Dim output = ""

        If LINK(0) Then output = output & "LINK LINK_OPTION_" & MainMenu.ReactorID & ".dat" & vbNewLine
        If LINK(1) Then output = output & "LINK LINK_MAT_" & MainMenu.ReactorID & ".dat" & vbNewLine
        If LINK(2) Then output = output & "LINK LINK_FA_" & MainMenu.ReactorID & ".dat" & vbNewLine

        output = output & vbNewLine

        output = output & "SPA " & SPA(0) & " " & SPA(1) & " " & SPA(2) & vbNewLine

        output = output & vbNewLine

        Dim pinCount = pin.length()
        For i = 0 To pinCount Step 1
            output = output & pin.getItem(i).ToString()
            output = output & vbNewLine
        Next

        output = output & "CORE " & CORE(0) & " " & CORE(1) & vbNewLine
        output = output & CORE(2)

        Dim UTFwithoutBOM As New System.Text.UTF8Encoding(False)
        My.Computer.FileSystem.WriteAllText(filePath, output, False, UTFwithoutBOM)

    End Sub

End Class

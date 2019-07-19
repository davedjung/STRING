Imports System.IO

Public Class AssemblyFile
    Inherits File

    Private LINK(2) As Boolean
    Private SPA(2) As String
    Private pin(0) As Pin
    Private CORE(2) As String

    Public Sub New(fileName As String)
        Me.fileName = fileName
        Me.fileType = 2
    End Sub

    Public Sub setLINK(LINK As Boolean())
        Me.LINK = LINK
    End Sub

    Public Sub setSPA(SPA As String())
        Me.SPA = SPA
    End Sub

    Public Sub addPin(pin As Pin)
        Dim pinCount As Integer
        If IsNothing(Me.pin(0)) Then
            pinCount = 0
        Else
            pinCount = Me.pin.Length()
        End If
        Dim newPinList(pinCount) As Pin
        For i = 0 To pinCount - 1 Step 1
            newPinList(i) = Me.pin(i)
        Next
        newPinList(pinCount) = pin
        Me.pin = newPinList
    End Sub

    Public Sub removePin(index As Integer)
        Dim pinCount = Me.pin.Length()
        For i = index To pinCount - 2 Step 1
            Me.pin(i) = Me.pin(i + 1)
        Next
        Dim newPinList(pinCount - 2) As Pin
        For i = 0 To pinCount - 2 Step 1
            newPinList(i) = Me.pin(i)
        Next
        Me.pin = newPinList
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

    Public Function getAllPin() As Pin()
        Return Me.pin
    End Function

    Public Function getPin(index As Integer) As Pin
        Return Me.pin(index)
    End Function

    Public Function getCORE() As String()
        Return Me.CORE
    End Function

    Public Overrides Sub generateFile()

        Dim filePath As String
        filePath = MainMenu.getPath() & "\" & Me.fileName
        Dim output = ""

        If LINK(0) Then output = output & "LINK LINK_OPTION_" & MainMenu.getReactorCode() & ".dat" & vbNewLine
        If LINK(1) Then output = output & "LINK LINK_MAT_" & MainMenu.getReactorCode() & ".dat" & vbNewLine
        If LINK(2) Then output = output & "LINK LINK_FA_" & MainMenu.getReactorCode() & ".dat" & vbNewLine

        output = output & vbNewLine

        output = output & "SPA " & SPA(0) & " " & SPA(1) & " " & SPA(2) & vbNewLine

        output = output & vbNewLine

        Dim pinCount = pin.Length()
        For i = 0 To pinCount - 1 Step 1
            output = output & pin(i).ToString()
            output = output & vbNewLine
        Next

        output = output & "CORE " & CORE(0) & " " & CORE(1) & vbNewLine
        output = output & CORE(2)

        My.Computer.FileSystem.WriteAllText(filePath, output, False)

    End Sub

End Class

﻿Public Class MainMenu

    Private path As String
    Private ReactorCode As String
    Private assemCount As Integer
    Private fileList(0) As File

    Private Sub BtnConfLinkFa_Click(sender As Object, e As EventArgs) Handles btnConfLinkFa.Click

        LINK_FA.setFileIndex(-1)
        LINK_FA.Show()

    End Sub

    Private Sub BtnConfLinkOption_Click(sender As Object, e As EventArgs) Handles btnConfLinkOption.Click

        LINK_OPTION.setFileIndex(-1)
        LINK_OPTION.Show()

    End Sub

    Private Sub BtnConfLinkMat_Click(sender As Object, e As EventArgs) Handles btnConfLinkMat.Click

        LINK_MAT.setFileIndex(-1)
        LINK_MAT.Show()

    End Sub

    Private Sub BtnConfAssem_Click(sender As Object, e As EventArgs) Handles btnConfAssem.Click

        Assem.setFileIndex(-1)
        Assem.Show()

    End Sub

    Private Sub txtReactorID_MouseDown(sender As Object, e As MouseEventArgs) Handles txtReactorID.MouseDown
        txtReactorID.Text = ""
    End Sub

    Private Sub TxtReactorID_TextChanged(sender As Object, e As EventArgs) Handles txtReactorID.TextChanged
        ReactorCode = txtReactorID.Text

        lblLinkOption.Text = "1. LINK_OPTION_" & ReactorCode & ".dat"
        lblLinkMat.Text = "2. LINK_MAT_" & ReactorCode & ".dat"
        lblAssem.Text = "3. " & ReactorCode & "_Assem_" & assemCount & ".dat"
        lblLinkFA.Text = "4. LINK_FA_" & ReactorCode & ".dat"
        btnConfLinkOption.Text = "Configure LINK_&OPTION_" & ReactorCode & ".dat"
        btnConfLinkMat.Text = "Configure LINK_&MAT_" & ReactorCode & ".dat"
        btnConfAssem.Text = "Configure " & ReactorCode & "_&Assem_" & assemCount & ".dat"
        btnConfLinkFa.Text = "Configure LINK_&FA_" & ReactorCode & ".dat"

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\STREAM"
        txtPath.Text = path
        ReactorCode = ""
        assemCount = 1
        lblAssem.Text = "3. [Reactor Code]_Assem_" & assemCount & ".dat"
        btnConfAssem.Text = "Configure [Reactor Code]_&Assem_" & assemCount & ".dat"



    End Sub

    Private Sub RdbCreateNew_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCreateNew.CheckedChanged

        If rdbCreateNew.Checked = True Then
            txtReactorID.Enabled = True
            cbxPreset.Enabled = False
        Else
            txtReactorID.Enabled = False
            cbxPreset.Enabled = True
        End If

    End Sub

    Private Sub RdbChoosePreset_CheckedChanged(sender As Object, e As EventArgs) Handles rdbChoosePreset.CheckedChanged

        If rdbChoosePreset.Checked = False Then
            txtReactorID.Enabled = True
            cbxPreset.Enabled = False
        Else
            txtReactorID.Enabled = False
            cbxPreset.Enabled = True
        End If

    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim fileCount As Integer
        fileCount = fileList.Length()
        If fileCount = 0 Then
            MessageBox.Show("No file to generate.", "Error")
            Exit Sub
        End If
        For i = 0 To fileCount - 1 Step 1
            fileList(i).generateFile()
        Next

        MessageBox.Show("Files generated.", "Result")

    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim fileIndex As Integer
        fileIndex = lbxFileList.SelectedIndex
        Dim targetFile As File
        targetFile = fileList(fileIndex)
        Select Case targetFile.getFileType
            Case 0
                LINK_OPTION.setFileIndex(fileIndex)
                LINK_OPTION.Show()
            Case 1
                LINK_MAT.setFileIndex(fileIndex)
                LINK_MAT.Show()
            Case 2
                Assem.setFileIndex(fileIndex)
                Assem.Show()
            Case 3
                LINK_FA.setFileIndex(fileIndex)
                LINK_FA.Show()
        End Select


    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lbxFileList.SelectedIndex = -1 Then
            MessageBox.Show("No file selected", "Error")
            Exit Sub
        End If

        Dim index = lbxFileList.SelectedIndex
        Dim fileCount = fileList.Length()
        For i = index To fileCount - 2 Step 1
            fileList(i) = fileList(i + 1)
        Next

        Dim newFileList(fileCount - 2) As File
        For i = 0 To fileCount - 2 Step 1
            newFileList(i) = fileList(i)
        Next
        fileList = newFileList

        lbxFileList.Items.Clear()
        For i = 0 To fileCount - 2 Step 1
            lbxFileList.Items.Add(fileList(i).getFileName())
        Next

    End Sub

    Private Sub TxtPath_TextChanged(sender As Object, e As EventArgs) Handles txtPath.TextChanged
        path = txtPath.Text
    End Sub









    Public Function getPath() As String
        Return Me.path
    End Function
    Public Function getReactorCode() As String
        Return Me.ReactorCode
    End Function
    Public Function getAssemCount() As Integer
        Return Me.assemCount
    End Function
    Public Function getFile(index As Integer) As File
        Return Me.fileList(index)
    End Function
    Public Function getAllFile() As File()
        Return Me.fileList
    End Function
    Public Sub saveFile(file As File, index As Integer)
        fileList(index) = file
    End Sub
    Public Sub addFile(file As File)

        Dim fileCount As Integer
        If IsNothing(fileList(0)) Then
            fileCount = 0
        Else
            fileCount = fileList.Length()
        End If
        Dim newFileList(fileCount) As File
        For i = 0 To fileCount - 1 Step 1
            newFileList(i) = fileList(i)
        Next
        newFileList(fileCount) = file
        fileList = newFileList

        lbxFileList.Items.Clear()
        For i = 0 To fileCount Step 1
            lbxFileList.Items.Add(fileList(i).getFileName())
        Next

    End Sub

End Class

Public Class MainMenu

    Public ReactorID As String
    Public AssemCounter As Integer
    Public fileList As List
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPath.Text = My.Computer.FileSystem.SpecialDirectories.Desktop & "\STREAM"
        ReactorID = ""
        AssemCounter = 1
        fileList = New List()
        ReactorID = txtID.Text

        If ReactorID = "" Then
            ReactorID = "[Reactor]"
        End If
        lblAssem.Text = "3. " + ReactorID + "_Assem_" + CStr(AssemCounter) + ".inp"
        btnAssem.Text = "Configure " + ReactorID + "_Assem_" + CStr(AssemCounter) + ".inp"
    End Sub
    Private Sub lblVersion_Click(sender As Object, e As EventArgs) Handles lblVersion.Click
        Dim info As String
        info = "Check out https://www.github.com/davedjung/STRING for updates and more information"
        MessageBox.Show(info, "Information")
    End Sub
    Private Sub lblCredit_Click(sender As Object, e As EventArgs) Handles lblCredit.Click
        Dim info As String
        info = "Email: davedjung@gmail.com" + vbNewLine + "Github: http://www.github.com/davedjung" + vbNewLine
        info += vbNewLine + "Department of Nuclear Engineering" + vbNewLine + "Seoul National University"
        MessageBox.Show(info, "Contact Information")
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

        txtID.Text = txtID.Text.Replace(" ", "")
        ReactorID = txtID.Text

        If ReactorID = "" Then
            ReactorID = "[Reactor]"
        End If

        lblOPTION.Text = "1. LINK_OPTION_" + ReactorID + ".dat"
        lblMAT.Text = "2. LINK_MAT_" + ReactorID + ".dat"
        lblAssem.Text = "3. " + ReactorID + "_Assem_" + CStr(AssemCounter) + ".inp"
        lblFA.Text = "4. LINK_FA_" + ReactorID + ".dat"
        btnOPTION.Text = "Configure LINK_OPTION_" + ReactorID + ".dat"
        btnMAT.Text = "Configure LINK_MAT_" + ReactorID + ".dat"
        btnAssem.Text = "Configure " + ReactorID + "_Assem_" + CStr(AssemCounter) + ".inp"
        btnFA.Text = "Configure LINK_FA_" + ReactorID + ".dat"

    End Sub
    Private Sub btnOPTION_Click(sender As Object, e As EventArgs) Handles btnOPTION.Click
        LINK_OPTION.setFileIndex(-1)
        LINK_OPTION.Show()
    End Sub

    Private Sub btnMAT_Click(sender As Object, e As EventArgs) Handles btnMAT.Click
        LINK_MAT.setFileIndex(-1)
        LINK_MAT.Show()
    End Sub

    Private Sub btnAssem_Click(sender As Object, e As EventArgs) Handles btnAssem.Click
        Assem.setFileIndex(-1)
        Assem.Show()
    End Sub

    Private Sub btnFA_Click(sender As Object, e As EventArgs) Handles btnFA.Click
        LINK_FA.setFileIndex(-1)
        LINK_FA.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim index = lbxList.SelectedIndex
        Dim fileType = fileList.getItem(index).GetFileType()
        Select Case fileType
            Case 0 'OPTION
                LINK_OPTION.setFileIndex(index)
                LINK_OPTION.Show()
            Case 1 'MAT
                LINK_MAT.setFileIndex(index)
                LINK_MAT.Show()
            Case 2 'Assem
                Assem.setFileIndex(index)
                Assem.Show()
            Case 3 'FA
                LINK_FA.setFileIndex(index)
                LINK_FA.Show()
        End Select
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim index = lbxList.SelectedIndex
        If fileList.getItem(index).GetfileType() = 2 Then
            AssemCounter -= 1
        End If
        fileList.removeItem(index)
        updateFileList()
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim length = fileList.length()
        For i = 0 To length
            fileList.getItem(i).generateFile(txtPath.Text)
        Next
    End Sub
    Public Sub updateFileList()
        Dim length = fileList.length()
        lbxList.Items.Clear()
        For i = 0 To length
            lbxList.Items.Add(fileList.getItem(i).getFileName())
        Next
    End Sub

End Class
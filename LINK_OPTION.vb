Imports System.IO
Public Class LINK_OPTION

    Private fileIndex As Integer
    Private saveFile As OPTIONFile
    Private Sub LINK_OPTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fileIndex = -1 Then
            Dim fileName = "LINK_OPTION_" + MainMenu.ReactorID + ".dat"
            Me.Text = "Configure " & fileName
            lblTitle.Text = fileName & " Configurator"
            saveFile = New OPTIONFile(fileName)
            initialization()
        Else
            saveFile = MainMenu.fileList.getItem(fileIndex)
            Dim fileName = saveFile.getFileName()
            Me.Text = "Configure " & fileName
            lblTitle.Text = fileName & " Configurator"
            initialization()
            loadConfiguration()
        End If
    End Sub
    Public Sub setFileIndex(ByVal index As Integer)
        fileIndex = index
    End Sub
    Public Sub initialization()
        cbxXSLIB.Items.Clear()
        cbxDEPLIB.Items.Clear()
        cbxKAPPALIB.Items.Clear()
        cbxDET.Items.Clear()
        cbxCRI.Items.Clear()
        cbxBRANCH.Items.Clear()

        Dim settingFile As String = My.Resources.OPTION_SETTING
        Dim line As String
        Dim reader As TextReader = New StringReader(settingFile)
        line = reader.ReadLine
        Do While line <> "END OF FILE"
            Select Case line
                Case "XSLIB"
                    line = reader.ReadLine
                    SetUpComboBox(line, cbxXSLIB)
                Case "DEPLIB"
                    line = reader.ReadLine
                    SetUpComboBox(line, cbxDEPLIB)
                Case "KAPPALIB"
                    line = reader.ReadLine
                    SetUpComboBox(line, cbxKAPPALIB)
                Case "DET"
                    line = reader.ReadLine
                    SetUpComboBox(line, cbxDET)
                Case "CRI"
                    line = reader.ReadLine
                    SetUpComboBox(line, cbxCRI)
                Case "BRANCH"
                    line = reader.ReadLine
                    SetUpComboBox(line, cbxBRANCH)
                Case "H2O"
                    txtInletTemp.Text = reader.ReadLine
                    txtBoron.Text = reader.ReadLine
                Case "DEP"
                    txtPower.Text = reader.ReadLine
                    txtBurnup.Text = reader.ReadLine
            End Select
            line = reader.ReadLine
        Loop

        chkRUP.Checked = True
        chkHOMADF.Checked = True
        chkRESTART.Checked = True
        chkSTN.Checked = True
        chkTHE.Checked = True
    End Sub
    Public Sub loadConfiguration()
        Dim saveFile = DirectCast(MainMenu.fileList.getItem(fileIndex), OPTIONFile)

        cbxXSLIB.SelectedIndex = saveFile.getXSLIB()
        cbxDEPLIB.SelectedIndex = saveFile.getDEPLIB()
        cbxKAPPALIB.SelectedIndex = saveFile.getKAPPALIB()
        cbxDET.SelectedIndex = saveFile.getDET()

        Dim ONstatus(4) As Boolean
        ONstatus = saveFile.getON()
        chkRUP.Checked = ONstatus(0)
        chkHOMADF.Checked = ONstatus(1)
        chkRESTART.Checked = ONstatus(2)
        chkSTN.Checked = ONstatus(3)
        chkTHE.Checked = ONstatus(4)

        cbxCRI.SelectedIndex = saveFile.getCRI()
        cbxBRANCH.SelectedIndex = saveFile.getBRANCH()
        txtInletTemp.Text = saveFile.getInletTemp()
        txtBoron.Text = saveFile.getBoron()
        txtPower.Text = saveFile.getPower()
        txtBurnup.Text = saveFile.getBurnup()

        Me.Text = "Configure " & saveFile.getFileName
        lblTitle.Text = saveFile.getFileName & " Configurator"
    End Sub
    Private Sub SetUpComboBox(ByVal line As String, ByVal control As ComboBox)

        Dim content = line.Split("#")
        For i = 0 To content.Length - 1 Step 1
            control.Items.Add(content(i))
            If content(i).Contains("[Default]") Then control.SelectedIndex = i
        Next
        If control.SelectedIndex = -1 Then control.SelectedIndex = 0
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim information As String
        information = "0: User creates branch cases manually" & vbNewLine
        information = information & "1: Hot-state full case matrix created with coolant temperature of +-20K change without rod insertion" & vbNewLine
        information = information & "2: Hot-state full case matrix created with coolant temperature of +-20K change [Default]" & vbNewLine
        information = information & "3: Hot-state full case matrix created with coolant temperature of +-25K change" & vbNewLine
        information = information & "4: Cold-state full case matrix created"

        MessageBox.Show(information, "Branch calculation options")
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        initialization()
        If fileIndex <> -1 Then loadConfiguration()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not IsNumeric(txtInletTemp.Text) Then
            MessageBox.Show("Moderator Inlet Temperature is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtBoron.Text) Then
            MessageBox.Show("Boron Concentration is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtPower.Text) Then
            MessageBox.Show("Power Density is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtBurnup.Text) Then
            MessageBox.Show("Final Burnup is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric("-" + txtBurnup.Text) Then
            MessageBox.Show("Final Burnup must be non-negative", "Error")
            Exit Sub
        End If

        saveFile.setXSLIB(cbxXSLIB.SelectedIndex)
        saveFile.setDEPLIB(cbxDEPLIB.SelectedIndex)
        saveFile.setKAPPALIB(cbxKAPPALIB.SelectedIndex)
        saveFile.setDET(cbxDET.SelectedIndex)

        Dim ONstatus(4) As Boolean
        ONstatus(0) = chkRUP.Checked
        ONstatus(1) = chkHOMADF.Checked
        ONstatus(2) = chkRESTART.Checked
        ONstatus(3) = chkSTN.Checked
        ONstatus(4) = chkTHE.Checked
        saveFile.setON(ONstatus)

        saveFile.setCRI(cbxCRI.SelectedIndex)
        saveFile.setBRANCH(cbxBRANCH.SelectedIndex)
        saveFile.setInletTemp(CDbl(txtInletTemp.Text))
        saveFile.setBoron(CDbl(txtBoron.Text))
        saveFile.setPower(CDbl(txtPower.Text))
        saveFile.setBurnup(CDbl(txtBurnup.Text))


        If fileIndex = -1 Then
            MainMenu.fileList.addItem(saveFile)
        Else
            MainMenu.fileList.addItem(saveFile, fileIndex)
        End If
        MainMenu.updateFileList()
        Me.Close()
    End Sub


End Class
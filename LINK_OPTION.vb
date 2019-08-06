Imports System.IO

Public Class LINK_OPTION

    Private fileIndex As Integer
    Private saveFile As OptionFile

    Private Sub LINK_OPTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If fileIndex = -1 Then
            Dim reactorCode = MainMenu.getReactorCode()
            Dim assemCount = MainMenu.getAssemCount()
            Dim fileName = "LINK_OPTION_" & reactorCode & ".dat"
            Me.Text = "Configure " & fileName
            lblTitle.Text = fileName & " Configurator"
            saveFile = New OptionFile(fileName)
            initialization()
        Else
            saveFile = MainMenu.getFile(fileIndex)
            Dim filename = saveFile.getFileName()
            Me.Text = "Configure " & filename
            lblTitle.Text = filename & " Configurator"
            initialization()
            loadConfiguration()
        End If

    End Sub



    Private Sub SetUpComboBox(ByVal line As String, ByVal control As ComboBox)

        Dim content = line.Split("#")
        For i = 0 To content.Length - 1 Step 1
            control.Items.Add(content(i))
            If content(i).Contains("[Default]") Then control.SelectedIndex = i
        Next
        If control.SelectedIndex = -1 Then control.SelectedIndex = 0
    End Sub
          
    Private Sub BtnBRANCHHelp_Click(sender As Object, e As EventArgs) Handles btnBRANCHHelp.Click

        Dim information As String
        information = "0: User creates branch cases manually" & vbNewLine
        information = information & "1: Hot-state full case matrix created with coolant temperature of +-20K change without rod insertion" & vbNewLine
        information = information & "2: Hot-state full case matrix created with coolant temperature of +-20K change [Default]" & vbNewLine
        information = information & "3: Hot-state full case matrix created with coolant temperature of +-25K change" & vbNewLine
        information = information & "4: Cold-state full case matrix created"

        MessageBox.Show(information, "Branch calculation options")

    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        initialization()
        If fileIndex <> -1 Then loadConfiguration()

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not IsNumeric(txtH2OTemp.Text) Then
            MessageBox.Show("Moderator Inlet Temperature is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtH2OBoron.Text) Then
            MessageBox.Show("Boron Concentration is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtDEPPower.Text) Then
            MessageBox.Show("Power Density is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtDEPBurnup.Text) Then
            MessageBox.Show("Final Burnup is not a number", "Error")
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
        saveFile.setH2OTemp(CDbl(txtH2OTemp.Text))
        saveFile.setH2OBoron(CDbl(txtH2OBoron.Text))
        saveFile.setDEPPower(CDbl(txtDEPPower.Text))
        saveFile.setDEPBurnup(CDbl(txtDEPBurnup.Text))


        If fileIndex = -1 Then
            MainMenu.addFile(saveFile)
        Else
            MainMenu.saveFile(saveFile, fileIndex)
        End If

        Me.Close()

    End Sub

















    Public Sub setFileIndex(index As Integer)
        Me.fileIndex = index
    End Sub
    Private Sub initialization()

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
                    txtH2OTemp.Text = reader.ReadLine
                    txtH2OBoron.Text = reader.ReadLine
                Case "DEP"
                    txtDEPPower.Text = reader.ReadLine
                    txtDEPBurnup.Text = reader.ReadLine
            End Select
            line = reader.ReadLine
        Loop

        chkRUP.Checked = True
        chkHOMADF.Checked = True
        chkRESTART.Checked = True
        chkSTN.Checked = True
        chkTHE.Checked = True

    End Sub
    Private Sub loadConfiguration()

        Dim saveFile = DirectCast(MainMenu.getFile(fileIndex), OptionFile)

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
        txtH2OTemp.Text = saveFile.getH2OTemp()
        txtH2OBoron.Text = saveFile.getH2OBoron()
        txtDEPPower.Text = saveFile.getDEPPower()
        txtDEPBurnup.Text = saveFile.getDEPBurnup()

        Me.Text = "Configure " & saveFile.getFileName
        lblTitle.Text = saveFile.getFileName & " Configurator"

    End Sub

    Private Sub PbxExit_Click(sender As Object, e As EventArgs) Handles pbxExit.Click
        Me.Close()
    End Sub
End Class
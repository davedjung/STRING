Imports System.IO
Public Class LINK_MAT

    Private fileIndex As Integer
    Private saveFile As MATFile
    Private materialOfInterest As CustomMaterial

    Private Sub LINK_MAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If fileIndex = -1 Then
            Dim fileName = "LINK_MAT_" + MainMenu.ReactorID + ".dat"
            Me.Text = "Configure " & fileName
            lblTitle.Text = fileName & " Configurator"
            saveFile = New MATFile(fileName)
            initialization()
        Else
            saveFile = MainMenu.fileList.getItem(fileIndex)
            Dim filename = saveFile.getFileName()
            Me.Text = "Configure " & filename
            lblTitle.Text = filename & " Configurator"
            initialization()
            loadConfiguration()
        End If

    End Sub


    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        initialization()
        If fileIndex <> -1 Then loadConfiguration()

    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If fileIndex = -1 Then
            MainMenu.fileList.addItem(saveFile)
        Else
            MainMenu.fileList.addItem(saveFile, fileIndex)
        End If

        MainMenu.updateFileList()
        Me.Close()

    End Sub

    Public Sub setFileIndex(index As Integer)
        Me.fileIndex = index
    End Sub
    Private Sub initialization()

        cbxMaterial.Items.Clear()
        cbxMaterial.Text = ""
        txtMATName.Text = ""
        lblMATOption1.Text = ""
        lblMATOption2.Text = ""
        lblMATOption3.Text = ""
        txtMATOption1.Text = ""
        txtMATOption2.Text = ""
        txtMATOption3.Text = ""
        txtMATName.Enabled = False
        txtMATOption1.Enabled = False
        txtMATOption2.Enabled = False
        txtMATOption3.Enabled = False
        lbxMATList.Items.Clear()

        txtCustomName.Text = ""
        chkBURN.Checked = False
        txtAtomicNumber.Text = ""
        txtMassNumber.Text = ""
        txtNumberDensity.Text = ""
        txtE.Text = ""
        lbxCustom.Items.Clear()

        Dim databaseFile As String = My.Resources.MAT_DATA
        Dim line As String
        Dim reader As TextReader = New StringReader(databaseFile)
        line = reader.ReadLine
        Do While line <> "END OF FILE"
            cbxMaterial.Items.Add(line)
            line = reader.ReadLine
            line = reader.ReadLine
            line = reader.ReadLine
        Loop

        If lbxMATList.Items.Count = 0 Then
            btnMATRemove.Enabled = False
        Else
            btnMATRemove.Enabled = True
        End If

        If lbxCustom.Items.Count = 0 Then
            btnElementRemove.Enabled = False
            btnCustomGenerate.Enabled = False
        Else
            btnElementRemove.Enabled = True
            btnCustomGenerate.Enabled = True
        End If


    End Sub
    Private Sub loadConfiguration()

        Dim materialList = saveFile.getAllMaterial()
        If Not materialList.Length() = 0 Then
            If Not IsNothing(materialList(0)) Then
                For i = 0 To materialList.Length() - 1 Step 1
                    lbxMATList.Items.Add(materialList(i).getIdentifier())
                Next
            End If
        End If


        'Dim databaseFile As String = My.Resources.MAT_DATA
        'Dim line As String
        'Dim reader As TextReader = New StringReader(databaseFile)
        'line = reader.ReadLine
        'Do While line <> "END OF FILE"
        'cbxMATMaterialList.Items.Add(line)
        'line = reader.ReadLine
        'line = reader.ReadLine
        'line = reader.ReadLine
        'Loop

        If lbxMATList.Items.Count = 0 Then
            btnMATRemove.Enabled = False
        Else
            btnMATRemove.Enabled = True
        End If

        If lbxCustom.Items.Count = 0 Then
            btnElementRemove.Enabled = False
            btnCustomGenerate.Enabled = False
        Else
            btnElementRemove.Enabled = True
            btnCustomGenerate.Enabled = True
        End If


    End Sub

    Private Sub btnMATGenerate_Click(sender As Object, e As EventArgs) Handles btnMATGenerate.Click
        If txtMATOption1.Enabled And Not IsNumeric(txtMATOption1.Text) And cbxMaterial.SelectedIndex <> 1 Then
            MessageBox.Show("Inappropriate value detected", "Error")
            Exit Sub
        End If
        If txtMATOption2.Enabled And Not IsNumeric(txtMATOption2.Text) Then
            MessageBox.Show("Inappropriate value detected", "Error")
            Exit Sub
        End If
        If txtMATOption3.Enabled And Not IsNumeric(txtMATOption3.Text) Then
            MessageBox.Show("Inappropriate value detected", "Error")
            Exit Sub
        End If

        Dim materialName As String
        Dim identifier As String
        materialName = cbxMaterial.SelectedItem.ToString()
        identifier = txtMATName.Text
        If txtMATName.Text = "UO2" Then
            identifier = txtMATName.Text & "_" & txtMATOption2.Text
        End If

        Dim newMaterial = New PrefabMaterial(materialName, identifier)

        Dim optionCount As Integer
        If txtMATOption3.Enabled Then
            optionCount = 3
        ElseIf txtMATOption2.Enabled Then
            optionCount = 2
        Else
            optionCount = 1
        End If

        Dim optionList(optionCount - 1) As String

        If txtMATOption1.Enabled Then optionList(0) = txtMATOption1.Text
        If txtMATOption2.Enabled Then optionList(1) = txtMATOption2.Text
        If txtMATOption3.Enabled Then optionList(2) = txtMATOption3.Text

        newMaterial.setOption(optionList)

        saveFile.addMaterial(newMaterial)

        lbxMATList.Items.Clear()
        Dim materialList() = saveFile.getAllMaterial()
        For i = 0 To materialList.Length() - 1 Step 1
            lbxMATList.Items.Add(materialList(i).getIdentifier())
        Next

        lblMATOption1.Text = ""
        lblMATOption2.Text = ""
        lblMATOption3.Text = ""
        txtMATOption1.Text = ""
        txtMATOption2.Text = ""
        txtMATOption3.Text = ""
        txtMATName.Enabled = True
        txtMATOption1.Enabled = False
        txtMATOption2.Enabled = False
        txtMATOption3.Enabled = False

        Dim settingFile As String = My.Resources.MAT_DATA
        Dim line As String
        Dim reader As TextReader = New StringReader(settingFile)
        line = reader.ReadLine
        Do While line <> "END OF FILE"
            If line = cbxMaterial.SelectedItem.ToString Then
                txtMATName.Text = line
                line = reader.ReadLine
                Dim content() = line.Split("#")
                lblMATOption1.Text = content(0)
                lblMATOption2.Text = content(1)
                lblMATOption3.Text = content(2)
                line = reader.ReadLine
                content = line.Split("#")
                If lblMATOption1.Text <> " " Then
                    txtMATOption1.Enabled = True
                    txtMATOption1.Text = content(0)
                End If
                If lblMATOption2.Text <> " " Then
                    txtMATOption2.Enabled = True
                    txtMATOption2.Text = content(1)
                End If
                If lblMATOption3.Text <> " " Then
                    txtMATOption3.Enabled = True
                    txtMATOption3.Text = content(2)
                End If
                Exit Do
            End If
            line = reader.ReadLine
        Loop

        If lbxMATList.Items.Count = 0 Then
            btnMATRemove.Enabled = False
        Else
            btnMATRemove.Enabled = True
        End If

    End Sub

    Private Sub btnMATRemove_Click(sender As Object, e As EventArgs) Handles btnMATRemove.Click
        If lbxMATList.SelectedIndex = -1 Then
            MessageBox.Show("No material selected", "Error")
            Exit Sub
        End If

        Dim index = lbxMATList.SelectedIndex

        saveFile.removeMaterial(index)

        lbxMATList.Items.Clear()
        Dim materialList() = saveFile.getAllMaterial()
        If Not materialList.Length() = 0 Then
            For i = 0 To materialList.Length() - 1 Step 1
                lbxMATList.Items.Add(materialList(i).getIdentifier())
            Next
        End If

        If lbxMATList.Items.Count = 0 Then
            btnMATRemove.Enabled = False
        Else
            btnMATRemove.Enabled = True
        End If
    End Sub

    Private Sub btnElementAdd_Click(sender As Object, e As EventArgs) Handles btnElementAdd.Click

        If txtCustomName.Text = "" Then
            MessageBox.Show("Missing Material Name", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtAtomicNumber.Text) Then
            MessageBox.Show("Atomic Number is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtMassNumber.Text) Then
            MessageBox.Show("Mass Number is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtNumberDensity.Text) Then
            MessageBox.Show("Number Density is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtE.Text) Then
            MessageBox.Show("Number Density Exponent is not a number", "Error")
            Exit Sub
        End If

        If txtCustomName.Enabled Then
            Dim materialName = txtCustomName.Text
            Dim identifier = materialName
            Dim burnable = chkBURN.Checked
            Dim newCustomMaterial = New CustomMaterial(materialName, identifier, burnable)
            materialOfInterest = newCustomMaterial
        End If

        Dim atomicInfo As String
        atomicInfo = CStr(CInt(txtAtomicNumber.Text) * 1000 + CInt(txtMassNumber.Text))
        Dim newElement = New Element(atomicInfo)
        Dim numberDensity As String
        numberDensity = Format(CDbl(txtNumberDensity.Text), "0.00000") & "E" & Format(CDbl(txtE.Text), "#0.")
        newElement.setNumberDensity(numberDensity)
        materialOfInterest.addComposition(newElement)

        lbxCustom.Items.Clear()
        lbxCustom.Items.Add(materialOfInterest.getIdentifier())
        Dim elementList() = materialOfInterest.getAllComposition()
        For i = 0 To elementList.Length() - 1 Step 1
            lbxCustom.Items.Add(elementList(i).toString())
        Next

        txtCustomName.Enabled = False
        chkBURN.Enabled = False
        txtAtomicNumber.Text = ""
        txtMassNumber.Text = ""
        txtNumberDensity.Text = ""
        txtE.Text = ""

        If lbxCustom.Items.Count = 0 Then
            btnElementRemove.Enabled = False
            btnCustomGenerate.Enabled = False
        Else
            btnElementRemove.Enabled = True
            btnCustomGenerate.Enabled = True
        End If
    End Sub

    Private Sub btnElementRemove_Click(sender As Object, e As EventArgs) Handles btnElementRemove.Click
        If lbxCustom.SelectedIndex = -1 Then
            MessageBox.Show("No element selected", "Error")
            Exit Sub
        ElseIf lbxCustom.SelectedIndex = 0 Then
            lbxCustom.Items.Clear()
            If lbxCustom.Items.Count = 0 Then
                btnElementRemove.Enabled = False
                btnCustomGenerate.Enabled = False
            Else
                btnElementRemove.Enabled = True
                btnCustomGenerate.Enabled = True
            End If
            txtCustomName.Enabled = True
            txtCustomName.Text = ""
            chkBURN.Enabled = True
            chkBURN.Checked = False
            Exit Sub
        End If

        Dim index = lbxCustom.SelectedIndex - 1

        materialOfInterest.removeComposition(index)

        lbxCustom.Items.Clear()
        Dim elementList() = materialOfInterest.getAllComposition()
        If elementList.Length() = 0 Then
            txtCustomName.Enabled = True
            txtCustomName.Text = ""
            chkBURN.Enabled = True
            chkBURN.Checked = False
        Else
            lbxCustom.Items.Add(materialOfInterest.getIdentifier())
            For i = 0 To elementList.Length() - 1 Step 1
                lbxCustom.Items.Add(elementList(i).toString())
            Next
        End If

        If lbxCustom.Items.Count() = 1 Then
            lbxCustom.Items.Clear()
        End If

        If lbxCustom.Items.Count = 0 Then
            btnElementRemove.Enabled = False
            btnCustomGenerate.Enabled = False
        Else
            btnElementRemove.Enabled = True
            btnCustomGenerate.Enabled = True
        End If
    End Sub

    Private Sub btnCustomGenerate_Click(sender As Object, e As EventArgs) Handles btnCustomGenerate.Click
        txtCustomName.Enabled = True
        chkBURN.Enabled = True

        txtCustomName.Text = ""
        chkBURN.Checked = False

        saveFile.addMaterial(materialOfInterest)

        lbxMATList.Items.Clear()
        Dim materialList = saveFile.getAllMaterial()
        For i = 0 To materialList.Length() - 1 Step 1
            lbxMATList.Items.Add(materialList(i).getIdentifier())
        Next

        lbxCustom.Items.Clear()

        If lbxCustom.Items.Count = 0 Then
            btnElementRemove.Enabled = False
            btnCustomGenerate.Enabled = False
        Else
            btnElementRemove.Enabled = True
            btnCustomGenerate.Enabled = True
        End If
    End Sub

    Private Sub cbxMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMaterial.SelectedIndexChanged
        lblMATOption1.Text = ""
        lblMATOption2.Text = ""
        lblMATOption3.Text = ""
        txtMATOption1.Text = ""
        txtMATOption2.Text = ""
        txtMATOption3.Text = ""
        txtMATName.Enabled = True
        txtMATOption1.Enabled = False
        txtMATOption2.Enabled = False
        txtMATOption3.Enabled = False

        Dim settingFile As String = My.Resources.MAT_DATA
        Dim line As String
        Dim reader As TextReader = New StringReader(settingFile)
        line = reader.ReadLine
        Do While line <> "END OF FILE"
            If line = cbxMaterial.SelectedItem.ToString Then
                txtMATName.Text = line
                line = reader.ReadLine
                Dim content() = line.Split("#")
                lblMATOption1.Text = content(0)
                lblMATOption2.Text = content(1)
                lblMATOption3.Text = content(2)
                line = reader.ReadLine
                content = line.Split("#")
                If lblMATOption1.Text <> " " Then
                    txtMATOption1.Enabled = True
                    txtMATOption1.Text = content(0)
                End If
                If lblMATOption2.Text <> " " Then
                    txtMATOption2.Enabled = True
                    txtMATOption2.Text = content(1)
                End If
                If lblMATOption3.Text <> " " Then
                    txtMATOption3.Enabled = True
                    txtMATOption3.Text = content(2)
                End If
                Exit Do
            End If
            line = reader.ReadLine
        Loop
    End Sub
End Class
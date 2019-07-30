Public Class Assem

    Dim graphics As Graphics
    Dim brush As Brush
    Private fileIndex As Integer
    Private saveFile As AssemblyFile
    Private pinOfInterest As Pin

    Private Sub Assem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If fileIndex = -1 Then
            Dim reactorCode = MainMenu.getReactorCode()
            Dim assemCount = MainMenu.getAssemCount()
            Dim fileName = reactorCode & "_Assem_" & assemCount & ".inp"
            Me.Text = "Configure " & fileName
            lblTitle.Text = fileName & " Configurator"
            saveFile = New AssemblyFile(fileName)
            initialization()
        Else
            saveFile = MainMenu.getFile(fileIndex)
            Dim fileName = saveFile.getFileName()
            Me.Text = "Configure " & fileName
            lblTitle.Text = fileName & " Configurator"
            initialization()
            loadConfiguration()
        End If

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtPinID.Enabled Then
            pinOfInterest = New Pin(txtPinID.Text, txtSector.Text, txtInnerSubdivision.Text, txtOuterSubdivision.Text)
            lbxPinInfo.Items.Add("Pin " & pinOfInterest.getPinID())
            txtPinID.Enabled = False
            txtSector.Enabled = False
            txtInnerSubdivision.Enabled = False
            txtOuterSubdivision.Enabled = False
        End If

        If Not IsNumeric(txtOuterRadius.Text) Then
            MessageBox.Show("Outer Radius is not a number")
            Exit Sub
        End If
        If Not IsNumeric(txtTemperature.Text) Then
            MessageBox.Show("Temperature is not a number")
            Exit Sub
        End If

        Dim newPinMaterial = New PinMaterial(Format(CDbl(txtOuterRadius.Text), "0.0000"), cbxMaterial.Text, Format(CDbl(txtTemperature.Text), "0.0"))

        pinOfInterest.addPinMaterial(newPinMaterial)
        Dim pinMaterialList() = pinOfInterest.getAllPinMaterial()

        lbxPinInfo.Items.Clear()
        For i = 0 To pinMaterialList.Length - 1 Step 1
            lbxPinInfo.Items.Add(pinMaterialList(i).ToString())
        Next

        txtOuterRadius.Text = ""
        cbxMaterial.ResetText()
        txtTemperature.Text = ""

        drawPreview()

    End Sub

    Private Sub drawPreview()

        graphics = pbxPreview.CreateGraphics()

        graphics.Clear(pbxPreview.BackColor)

        Dim allPinMaterial() = pinOfInterest.getAllPinMaterial()

        Dim allRadii(allPinMaterial.Length() - 1) As Double
        For i = 0 To allPinMaterial.Length() - 1 Step 1
            allRadii(i) = allPinMaterial(i).getOuterRadius()
        Next

        Array.Sort(allRadii)
        Array.Reverse(allRadii)

        Dim large As Boolean
        If allRadii(0) > 0.75 Then
            large = True
        Else
            large = False
        End If
        For i = 0 To allPinMaterial.Length() - 1 Step 1
            Select Case i
                Case 0
                    brush = New SolidBrush(Color.Goldenrod)
                Case 1
                    brush = New SolidBrush(Color.IndianRed)
                Case 2
                    brush = New SolidBrush(Color.MidnightBlue)
                Case 3
                    brush = New SolidBrush(Color.RosyBrown)
                Case 4
                    brush = New SolidBrush(Color.MediumPurple)
                Case 5
                    brush = New SolidBrush(Color.LightPink)
                Case 6
                    brush = New SolidBrush(Color.ForestGreen)
                Case 7
                    brush = New SolidBrush(Color.LightSlateGray)
                Case 8
                    brush = New SolidBrush(Color.Indigo)
                Case Else
                    brush = New SolidBrush(Color.Black)
            End Select

            Dim reference As Double
            If large = True Then
                reference = 1.5
            Else
                reference = 0.75
            End If
            Dim scale As Double
            scale = pbxPreview.Size.Width / reference * allRadii(i)

            graphics.FillEllipse(brush, CInt((pbxPreview.Size.Width - scale) / 2), CInt((pbxPreview.Size.Width - scale) / 2), CInt(scale), CInt(scale))

        Next

    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        txtPinID.Enabled = True
        txtSector.Enabled = True
        txtInnerSubdivision.Enabled = True
        txtOuterSubdivision.Enabled = True
        txtPinID.Text = ""
        txtSector.Text = ""
        txtInnerSubdivision.Text = ""
        txtOuterSubdivision.Text = ""

        txtOuterRadius.Text = ""
        cbxMaterial.ResetText()
        txtTemperature.Text = ""

        lbxPinInfo.Items.Clear()

        saveFile.addPin(pinOfInterest)

        lbxPinList.Items.Clear()
        Dim allPin() = saveFile.getAllPin()
        For i = 0 To allPin.Length() - 1 Step 1
            lbxPinList.Items.Add("Pin " & allPin(i).getPinID)
        Next

        graphics = pbxPreview.CreateGraphics()

        graphics.Clear(pbxPreview.BackColor)

        If lbxPinList.Items.Count = 0 Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True
        End If

    End Sub


    Private Sub txtPinID_TextChanged(sender As Object, e As EventArgs) Handles txtPinID.TextChanged

        If txtPinID.Text <> "" Then
            txtSector.Text = "8"
            txtInnerSubdivision.Text = "1"
            txtOuterSubdivision.Text = "2"
        End If

    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        initialization()
        If fileIndex <> -1 Then loadConfiguration()

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Public Sub setFileIndex(index As Integer)
        Me.fileIndex = index
    End Sub
    Public Sub initialization()

        chkLINK_OPTION.Checked = True
        chkLINK_MAT.Checked = True
        chkLINK_FA.Checked = True

        txtSPACoolant.Text = ""
        txtSPASpacerGrid.Text = ""
        txtSPALinDensity.Text = ""

        txtPinID.Text = ""
        txtSector.Text = ""
        txtInnerSubdivision.Text = ""
        txtOuterSubdivision.Text = ""
        txtOuterRadius.Text = ""
        cbxMaterial.Items.Clear()
        cbxMaterial.ResetText()
        txtTemperature.Text = ""
        lbxPinInfo.Items.Clear()
        lbxPinList.Items.Clear()

        Dim graphics = pbxPreview.CreateGraphics()
        graphics.Clear(pbxPreview.BackColor)

        txtCOREAssemX.Text = ""
        txtCOREAssemY.Text = ""
        txtCOREAssemIndex.Text = ""

        Dim allFile() = MainMenu.getAllFile()
        Dim fileCount As Integer
        If IsNothing(allFile(0)) Then
            Exit Sub
        Else
            fileCount = allFile.Length()
        End If
        For i = 0 To fileCount - 1 Step 1
            If allFile(i).getFileType = 1 Then
                Dim materialList() = DirectCast(allFile(i), MaterialFile).getAllMaterial()
                Dim materialCount = materialList.Length()
                For j = 0 To materialCount - 1 Step 1
                    cbxMaterial.Items.Add(materialList(j).getIdentifier())
                Next

            End If
        Next

        If lbxPinList.Items.Count = 0 Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True
        End If

    End Sub
    Public Sub loadConfiguration()

        Dim LINK() = saveFile.getLINK()
        chkLINK_OPTION.Checked = LINK(0)
        chkLINK_MAT.Checked = LINK(1)
        chkLINK_FA.Checked = LINK(2)

        Dim SPA() = saveFile.getSPA()
        txtSPACoolant.Text = SPA(0)
        txtSPASpacerGrid.Text = SPA(1)
        txtSPALinDensity.Text = SPA(2)

        Dim pin() = saveFile.getAllPin()
        For i = 0 To pin.Length - 1 Step 1
            lbxPinList.Items.Add(pin(i).getPinID())
        Next

        Dim CORE() = saveFile.getCORE()
        txtCOREAssemX.Text = CORE(0)
        txtCOREAssemY.Text = CORE(1)
        txtCOREAssemIndex.Text = CORE(2)

        If lbxPinList.Items.Count = 0 Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lbxPinList.SelectedIndex = -1 Then
            MessageBox.Show("No pin selected", "Error")
            Exit Sub
        End If

        Dim index = lbxPinList.SelectedIndex
        saveFile.removePin(index)
        lbxPinList.Items.Clear()
        Dim allPin() = saveFile.getAllPin()
        For i = 0 To allPin.Length() - 1 Step 1
            lbxPinList.Items.Add("Pin " & allPin(i).getPinID)
        Next

        If lbxPinList.Items.Count = 0 Then
            btnRemove.Enabled = False
        Else
            btnRemove.Enabled = True
        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not IsNumeric(txtSPALinDensity.Text) Then
            MessageBox.Show("SPA Card Linear Density is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtCOREAssemX.Text) Then
            MessageBox.Show("Number of Assemblies in x-direction is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtCOREAssemY.Text) Then
            MessageBox.Show("Number of Assemblies in y-direction is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtCOREAssemIndex.Text) Then
            MessageBox.Show("Fuel Assembly Index is not a number", "Error")
            Exit Sub
        End If

        Dim LINK(2) As Boolean
        LINK(0) = chkLINK_OPTION.Checked
        LINK(1) = chkLINK_MAT.Checked
        LINK(2) = chkLINK_FA.Checked
        saveFile.setLINK(LINK)

        Dim SPA(2) As String
        SPA(0) = txtSPACoolant.Text
        SPA(1) = txtSPASpacerGrid.Text
        SPA(2) = Format(CDbl(txtSPALinDensity.Text), "0.0000")
        saveFile.setSPA(SPA)

        Dim CORE(2) As String
        CORE(0) = CStr(CInt(txtCOREAssemX.Text))
        CORE(1) = CStr(CInt(txtCOREAssemY.Text))
        CORE(2) = CStr(CInt(txtCOREAssemIndex.Text))
        saveFile.setCORE(CORE)

        If fileIndex = -1 Then
            MainMenu.addFile(saveFile)
        Else
            MainMenu.saveFile(saveFile, fileIndex)
        End If

        Me.Close()

    End Sub

End Class
﻿Public Class LINK_FA

    Private fileIndex As Integer
    Private saveFile As FAFile
    Private dimension As Integer
    Private pinConfiguration(,) As Integer
    Private pinSelected(,) As Boolean
    Private assemFile As List

    Dim graphicsFA As Graphics
    Dim penFA As Pen
    Dim brushFA As Brush
    Dim fontFA As Font

    Dim graphicsPin As Graphics
    Dim brushPin As Brush

    Private Sub LINK_FA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        assemFile = New List()
        If fileIndex = -1 Then
            Dim fileName = "LINK_FA_" + MainMenu.ReactorID + ".dat"
            Me.Text = "Configure " & fileName
            lblTitle.Text = fileName & " Configurator"
            saveFile = New FAFile(fileName)
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

    Private Sub BtnCreateFA_Click(sender As Object, e As EventArgs) Handles btnCreateFA.Click

        If Not IsNumeric(txtPinNo.Text) Then
            MessageBox.Show("# of Pins in x-direction is not a number", "Error")
            Exit Sub
        End If

        dimension = CInt(txtPinNo.Text)
        txtPinNoCalc.Text = txtPinNo.Text
        txtPinPitchCalc.Text = txtPinPitch.Text

        Dim pinGridInt(dimension, dimension) As Integer
        pinConfiguration = pinGridInt
        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                pinConfiguration(i, j) = 0
            Next
        Next

        Dim pinGridBool(dimension, dimension) As Boolean
        pinSelected = pinGridBool
        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                pinSelected(i, j) = False
            Next
        Next

        pbxFA.Enabled = True

        graphicsFA = pbxFA.CreateGraphics()
        graphicsFA.Clear(pbxFA.BackColor)
        Dim paletteDimension As Single
        paletteDimension = pbxFA.Size.Width
        Dim pinDimension As Single
        pinDimension = paletteDimension / dimension
        Dim r As Single
        r = pinDimension * 0.8
        Dim x, y As Single

        penFA = New Pen(Drawing.Color.Black, 2)

        For i = 0 To paletteDimension Step pinDimension
            For j = 0 To paletteDimension Step pinDimension
                x = i + pinDimension * 0.1
                y = j + pinDimension * 0.1
                graphicsFA.DrawEllipse(penFA, x, y, r, r)
            Next
        Next

    End Sub
    Private Sub drawFAView(i, j)

        graphicsFA = pbxFA.CreateGraphics()

        Dim paletteDimension As Single
        paletteDimension = pbxFA.Size.Width
        Dim pinDimension As Single
        pinDimension = paletteDimension / dimension
        Dim r As Single
        r = pinDimension * 0.8
        Dim x, y As Single

        brushFA = New SolidBrush(Color.White)
        graphicsFA.FillRectangle(brushFA, i * pinDimension, j * pinDimension, pinDimension, pinDimension)

        If pinConfiguration(i, j) <> 0 Then
            fontFA = New System.Drawing.Font(“Arial”, pinDimension / 2)

            Select Case pinConfiguration(i, j)
                Case 1
                    brushFA = New SolidBrush(Color.ForestGreen)
                Case 2
                    brushFA = New SolidBrush(Color.IndianRed)
                Case 3
                    brushFA = New SolidBrush(Color.Goldenrod)
                Case 4
                    brushFA = New SolidBrush(Color.MidnightBlue)
                Case 5
                    brushFA = New SolidBrush(Color.MediumPurple)
                Case 6
                    brushFA = New SolidBrush(Color.LightPink)
                Case 7
                    brushFA = New SolidBrush(Color.RosyBrown)
                Case 8
                    brushFA = New SolidBrush(Color.LightSlateGray)
                Case 9
                    brushFA = New SolidBrush(Color.Indigo)
                Case Else
                    brushFA = New SolidBrush(Color.Black)
            End Select
            x = i * pinDimension + pinDimension * 0.1
            y = j * pinDimension + pinDimension * 0.1
            graphicsFA.FillEllipse(brushFA, x, y, r, r)
            brushFA = New SolidBrush(Color.White)
            graphicsFA.DrawString(pinConfiguration(i, j), fontFA, brushFA, x, y)
            penFA = New Pen(Drawing.Color.Black, 1)
            graphicsFA.DrawEllipse(penFA, x, y, r, r)
        End If

        x = i * pinDimension + pinDimension * 0.1
                y = j * pinDimension + pinDimension * 0.1
        If pinSelected(i, j) Then
            penFA = New Pen(Drawing.Color.Coral, 2)
            graphicsFA.DrawEllipse(penFA, x, y, r, r)
        Else
            penFA = New Pen(Drawing.Color.Black, 2)
            graphicsFA.DrawEllipse(penFA, x, y, r, r)
        End If

    End Sub
    Private Sub drawFAView_old()
        graphicsFA = pbxFA.CreateGraphics()
        penFA = New Pen(Drawing.Color.Black, 1)
        graphicsFA.Clear(pbxFA.BackColor)

        Dim paletteDimension As Single
        paletteDimension = pbxFA.Size.Width - 1
        Dim pinDimension As Single
        pinDimension = paletteDimension / dimension

        For x = 0 To paletteDimension Step pinDimension
            For y = 0 To paletteDimension Step pinDimension
                graphicsFA.DrawRectangle(penFA, x, y, pinDimension, pinDimension)
            Next
        Next

        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                If pinConfiguration(i, j) <> 0 Then
                    fontFA = New System.Drawing.Font(“Arial”, pinDimension / 2)

                    Select Case pinConfiguration(i, j)
                        Case 1
                            brushFA = New SolidBrush(Color.ForestGreen)
                        Case 2
                            brushFA = New SolidBrush(Color.IndianRed)
                        Case 3
                            brushFA = New SolidBrush(Color.Goldenrod)
                        Case 4
                            brushFA = New SolidBrush(Color.MidnightBlue)
                        Case 5
                            brushFA = New SolidBrush(Color.MediumPurple)
                        Case 6
                            brushFA = New SolidBrush(Color.LightPink)
                        Case 7
                            brushFA = New SolidBrush(Color.RosyBrown)
                        Case 8
                            brushFA = New SolidBrush(Color.LightSlateGray)
                        Case 9
                            brushFA = New SolidBrush(Color.Indigo)
                        Case Else
                            brushFA = New SolidBrush(Color.Black)
                    End Select

                    graphicsFA.FillRectangle(brushFA, i * pinDimension, j * pinDimension, pinDimension, pinDimension)
                    brushFA = New SolidBrush(Color.White)
                    graphicsFA.DrawString(pinConfiguration(i, j), fontFA, brushFA, i * pinDimension, j * pinDimension)
                    penFA = New Pen(Drawing.Color.Black, 1)
                    graphicsFA.DrawRectangle(penFA, i * pinDimension, j * pinDimension, pinDimension, pinDimension)
                End If
            Next
        Next

        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                If pinSelected(i, j) Then
                    penFA = New Pen(Drawing.Color.Coral, 2)
                    graphicsFA.DrawRectangle(penFA, i * pinDimension, j * pinDimension, pinDimension, pinDimension)
                End If
            Next
        Next

    End Sub
    Private Sub pbxFA_MouseDown(sender As Object, e As MouseEventArgs) Handles pbxFA.MouseDown

        Dim x, y As Double
        x = e.X
        y = e.Y

        Dim paletteDimension As Single
        paletteDimension = pbxFA.Size.Width
        Dim pinDimension As Single
        pinDimension = paletteDimension / dimension

        Dim indexX, indexY As Integer
        indexX = x \ pinDimension
        indexY = y \ pinDimension



        If pinSelected(indexX, indexY) Then
            pinSelected(indexX, indexY) = False
        Else
            pinSelected(indexX, indexY) = True
        End If
        drawFAView(indexX, indexY)
    End Sub
    Private Sub BtnSetPin_Click(sender As Object, e As EventArgs) Handles btnSetPin.Click

        Dim currentAssemFileIndex = cbxAssemFile.SelectedIndex
        Dim currentPinIndex = lbxPinList.SelectedIndex
        Dim currentPinID = assemFile.getItem(currentAssemFileIndex).getAllPin().getItem(currentPinIndex).getPinID
        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                If pinSelected(i, j) = True Then
                    pinConfiguration(i, j) = currentPinID
                    pinSelected(i, j) = False
                    drawFAView(i, j)
                End If
            Next
        Next

    End Sub
    Private Sub BtnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click

        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                pinSelected(i, j) = True
                drawFAView(i, j)
            Next
        Next


    End Sub
    Private Sub BtnClearSelection_Click(sender As Object, e As EventArgs) Handles btnClearSelection.Click
        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                pinSelected(i, j) = False
                drawFAView(i, j)
            Next
        Next

    End Sub
    Private Sub BtnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click

        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                If pinSelected(i, j) Then
                    pinConfiguration(i, j) = 0
                End If
            Next
        Next

        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                pinSelected(i, j) = False
                drawFAView(i, j)
            Next
        Next


    End Sub
    Private Sub BtnEraseAll_Click(sender As Object, e As EventArgs) Handles btnEraseAll.Click

        For i = 0 To dimension Step 1
            For j = 0 To dimension Step 1
                pinConfiguration(i, j) = 0
                pinSelected(i, j) = False
                drawFAView(i, j)
            Next
        Next


    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim fuelAssembly As New FuelAssembly(txtFAIndex.Text)
        fuelAssembly.setDimension(dimension)
        fuelAssembly.setPitch(txtPinPitch.Text)
        fuelAssembly.setMaterial(txtFAMaterial.Text)
        fuelAssembly.setInletTemperature(txtMaterialTemp.Text)
        fuelAssembly.setPinConfiguration(pinConfiguration)
        fuelAssembly.setHalfAssemGap(txtHalfAssemGap.Text)

        Me.saveFile.addFuelAssembly(fuelAssembly)

        lbxFAList.Items.Clear()
        Dim FAList = Me.saveFile.getAllFuelAssembly()
        Dim FACount = FAList.Length()
        For i = 0 To FACount Step 1
            lbxFAList.Items.Add("FA _ " & FAList.getItem(i).getIndex)
        Next

    End Sub

    Private Sub CbxAssemFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAssemFile.SelectedIndexChanged

        If cbxAssemFile.SelectedIndex = -1 Then
            lbxPinList.Items.Clear()
            Exit Sub
        End If
        Dim assemFileIndex = cbxAssemFile.SelectedIndex
        Dim pinList = assemFile.getItem(assemFileIndex).getAllPin()
        Dim pinCount = pinList.Length()
        For i = 0 To pinCount Step 1
            lbxPinList.Items.Add("Pin " & pinList.getItem(i).getPinID)
        Next

    End Sub
    Private Sub LbxPinList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPinList.SelectedIndexChanged

        lbxPinInfo.Items.Clear()
        If lbxPinList.SelectedIndex = -1 Then

            Exit Sub
        End If
        Dim assemFileIndex = cbxAssemFile.SelectedIndex
        Dim PinIndex = lbxPinList.SelectedIndex
        Dim currentPin = assemFile.getItem(assemFileIndex).getAllPin().getItem(PinIndex)
        Dim pinMaterialList = currentPin.getAllPinMaterial()
        Dim pinMaterialCount = pinMaterialList.Length()
        For i = 0 To pinMaterialCount Step 1
            lbxPinInfo.Items.Add(pinMaterialList.getitem(i).ToString())
        Next

        drawPinView(currentPin)

    End Sub
    Private Sub drawPinView(pin As Pin)

        graphicsPin = pbxPin.CreateGraphics()
        graphicsPin.Clear(pbxPin.BackColor)

        Dim pinMaterialList = pin.getAllPinMaterial()
        Dim pinMaterialCount = pinMaterialList.Length()
        Dim radii(pinMaterialCount) As Double
        For i = 0 To pinMaterialCount Step 1
            radii(i) = pinMaterialList.getItem(i).getOuterRadius()
        Next

        Array.Sort(radii)
        Array.Reverse(radii)

        Dim large As Boolean
        If radii(0) > 0.75 Then
            large = True
        Else
            large = False
        End If
        For i = 0 To pinMaterialCount Step 1
            Select Case i
                Case 0
                    brushPin = New SolidBrush(Color.Goldenrod)
                Case 1
                    brushPin = New SolidBrush(Color.IndianRed)
                Case 2
                    brushPin = New SolidBrush(Color.MidnightBlue)
                Case 3
                    brushPin = New SolidBrush(Color.RosyBrown)
                Case 4
                    brushPin = New SolidBrush(Color.MediumPurple)
                Case 5
                    brushPin = New SolidBrush(Color.LightPink)
                Case 6
                    brushPin = New SolidBrush(Color.ForestGreen)
                Case 7
                    brushPin = New SolidBrush(Color.LightSlateGray)
                Case 8
                    brushPin = New SolidBrush(Color.Indigo)
                Case Else
                    brushPin = New SolidBrush(Color.Black)
            End Select

            Dim reference As Double
            If large = True Then
                reference = 1.5
            Else
                reference = 0.75
            End If
            Dim scale As Double
            scale = pbxPin.Size.Width / reference * radii(i)

            graphicsPin.FillEllipse(brushPin, CInt((pbxPin.Size.Width - scale) / 2), CInt((pbxPin.Size.Width - scale) / 2), CInt(scale), CInt(scale))

        Next


    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If Not IsNumeric(txtAssemPitchCalc.Text) Then
            MessageBox.Show("Assembly Pitch is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtPinNoCalc.Text) Then
            MessageBox.Show("# of Pins is not a number", "Error")
            Exit Sub
        End If
        If Not IsNumeric(txtPinPitchCalc.Text) Then
            MessageBox.Show("Pin Pitch is not a number", "Error")
            Exit Sub
        End If

        txtHalfAssemGap.Text = Format((CDbl(txtAssemPitchCalc.Text) - CDbl(txtPinNoCalc.Text) * CDbl(txtPinPitchCalc.Text)) * 0.5, "0.00000")

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

        txtFAIndex.Text = ""
        txtPinNo.Text = ""
        txtPinPitch.Text = ""
        txtFAMaterial.Text = ""
        txtMaterialTemp.Text = ""

        graphicsFA = pbxFA.CreateGraphics()
        graphicsFA.Clear(pbxFA.BackColor)
        lbxFAList.Items.Clear()

        cbxAssemFile.Items.Clear()
        cbxAssemFile.ResetText()
        lbxPinList.Items.Clear()
        graphicsPin = pbxPin.CreateGraphics()
        graphicsPin.Clear(pbxPin.BackColor)
        lbxPinInfo.Items.Clear()

        txtHalfAssemGap.Text = ""
        txtAssemPitchCalc.Text = ""
        txtPinNoCalc.Text = ""
        txtPinPitchCalc.Text = ""

        Dim allFile = MainMenu.fileList
        Dim fileCount As Integer
        If allFile.isEmpty() Then
            Exit Sub
        Else
            fileCount = allFile.Length()
        End If
        For i = 0 To fileCount Step 1
            If allFile.getItem(i).getFileType = 2 Then
                Me.assemFile.addItem(allFile.getItem(i))
            End If
        Next

        Dim finalAssemFileCount = Me.assemFile.length()
        If Not Me.assemFile.isEmpty() Then
            For i = 0 To finalAssemFileCount Step 1
                cbxAssemFile.Items.Add(Me.assemFile.getItem(i).getFileName())
            Next
        End If


    End Sub
    Private Sub loadConfiguration()

        Dim FAList = DirectCast(saveFile, FAFile).getAllFuelAssembly
        Dim FACount = FAList.Length()
        For i = 0 To FACount Step 1
            lbxFAList.Items.Add("FA " & FAList.getItem(i).getIndex())
        Next

    End Sub

End Class
Imports System.IO
Public Class LINK_MAT

    Private fileIndex As Integer
    Private saveFile As MaterialFile
    Private materialOfInterest As CustomMaterial
    Private homoOfInterest As Homogeneous

    Private Sub LINK_MAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If fileIndex = -1 Then
            Dim reactorCode = MainMenu.getReactorCode()
            Dim assemcount = MainMenu.getAssemCount()
            Dim fileName = "LINK_MAT_" & reactorCode & ".dat"
            Me.Text = "Configure " & fileName
            lblTitle.Text = fileName & " Configurator"
            saveFile = New MaterialFile(fileName)
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

    Private Sub CbxMATMaterialList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMATMaterialList.SelectedIndexChanged

        lblMATOption1.Text = ""
        lblMATOption2.Text = ""
        lblMATOption3.Text = ""
        txtMATOption1.Text = ""
        txtMATOption2.Text = ""
        txtMATOption3.Text = ""
        txtMATMaterialName.Enabled = True
        txtMATOption1.Enabled = False
        txtMATOption2.Enabled = False
        txtMATOption3.Enabled = False

        Dim settingFile As String = My.Resources.MAT_DATA
        Dim line As String
        Dim reader As TextReader = New StringReader(settingFile)
        line = reader.ReadLine
        Do While line <> "END OF FILE"
            If line = cbxMATMaterialList.SelectedItem.ToString Then
                txtMATMaterialName.Text = line
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

    Private Sub BtnMATGenerateMaterial_Click(sender As Object, e As EventArgs) Handles btnMATGenerateMaterial.Click

        Dim materialName As String
        Dim identifier As String
        materialName = txtMATMaterialName.Text
        If txtMATMaterialName.Text = "UO2" Then
            identifier = txtMATMaterialName.Text & "_" & txtMATOption2.Text
        Else
            identifier = materialName
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

        lbxMAT.Items.Clear()
        Dim materialList() = saveFile.getAllMaterial()
        For i = 0 To materialList.Length() - 1 Step 1
            lbxMAT.Items.Add(materialList(i).getIdentifier())
        Next

        lblMATOption1.Text = ""
        lblMATOption2.Text = ""
        lblMATOption3.Text = ""
        txtMATOption1.Text = ""
        txtMATOption2.Text = ""
        txtMATOption3.Text = ""
        txtMATMaterialName.Enabled = True
        txtMATOption1.Enabled = False
        txtMATOption2.Enabled = False
        txtMATOption3.Enabled = False

        Dim settingFile As String = My.Resources.MAT_DATA
        Dim line As String
        Dim reader As TextReader = New StringReader(settingFile)
        line = reader.ReadLine
        Do While line <> "END OF FILE"
            If line = cbxMATMaterialList.SelectedItem.ToString Then
                txtMATMaterialName.Text = line
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
    Private Sub BtnMATAddCustomElement_Click(sender As Object, e As EventArgs) Handles btnMATAddCustomElement.Click

        If txtMATMaterialNameCustom.Enabled Then
            Dim materialName = txtMATMaterialNameCustom.Text
            Dim identifier = materialName
            Dim burnable = chkMATMaterialBURN.Checked
            Dim newCustomMaterial = New CustomMaterial(materialName, identifier, burnable)
            materialOfInterest = newCustomMaterial
        End If

        Dim atomicInfo As String
        atomicInfo = CStr(CInt(txtMATAtomicNumber.Text) * 1000 + CInt(txtMATMassNumber.Text))
        Dim newElement = New Element(atomicInfo)
        Dim numberDensity As String
        numberDensity = Format(CDbl(txtMATNumberDensity.Text), "0.00000") & "E" & Format(CDbl(txtMATNumberDensityE.Text), "#0.")
        newElement.setNumberDensity(numberDensity)
        materialOfInterest.addComposition(newElement)

        lbxMATCustom.Items.Clear()
        lbxMATCustom.Items.Add(materialOfInterest.getIdentifier())
        Dim elementList() = materialOfInterest.getAllComposition()
        For i = 0 To elementList.Length() - 1 Step 1
            lbxMATCustom.Items.Add(elementList(i).toString())
        Next

        txtMATMaterialNameCustom.Enabled = False
        chkMATMaterialBURN.Enabled = False
        txtMATAtomicNumber.Text = ""
        txtMATMassNumber.Text = ""
        txtMATNumberDensity.Text = ""
        txtMATNumberDensityE.Text = ""

    End Sub
    Private Sub BtnMATGenerateCustomMaterial_Click(sender As Object, e As EventArgs) Handles btnMATGenerateCustomMaterial.Click

        txtMATMaterialNameCustom.Enabled = True
        chkMATMaterialBURN.Enabled = True

        txtMATMaterialNameCustom.Text = ""
        chkMATMaterialBURN.Checked = False

        saveFile.addMaterial(materialOfInterest)

        lbxMAT.Items.Clear()
        Dim materialList = saveFile.getAllMaterial()
        For i = 0 To materialList.Length() - 1 Step 1
            lbxMAT.Items.Add(materialList(i).getIdentifier())
        Next

        lbxMATCustom.Items.Clear()

    End Sub
    Private Sub BtnHOMOAddMaterial_Click(sender As Object, e As EventArgs) Handles btnHOMOAddMaterial.Click

        If txtHOMOHomoMaterialName.Enabled Then
            Dim homoName = txtHOMOHomoMaterialName.Text
            Dim newHomoMaterial = New Homogeneous(homoName)
            homoOfInterest = newHomoMaterial
        End If

        Dim composition As String
        composition = txtHOMOMaterialName.Text & " " & txtHOMOFraction.Text
        homoOfInterest.addComposition(composition)

        lbxHOMOMaterial.Items.Clear()
        lbxHOMOMaterial.Items.Add(homoOfInterest.getName())
        Dim compositionList() = homoOfInterest.getAllComposition()
        For i = 0 To compositionList.Length() - 1 Step 1
            lbxHOMOMaterial.Items.Add(compositionList(i))
        Next

        txtHOMOHomoMaterialName.Enabled = False
        txtHOMOMaterialName.Text = ""
        txtHOMOFraction.Text = ""

    End Sub
    Private Sub BtnHOMOGenerateHomoMaterial_Click(sender As Object, e As EventArgs) Handles btnHOMOGenerateHomoMaterial.Click

        txtHOMOHomoMaterialName.Enabled = True
        txtHOMOHomoMaterialName.Text = ""

        saveFile.addHomo(homoOfInterest)

        lbxHOMOHomoMaterial.Items.Clear()
        Dim homoList = saveFile.getAllHomogeneous()
        For i = 0 To homoList.Length() - 1 Step 1
            lbxHOMOHomoMaterial.Items.Add(homoList(i).getName())
        Next

        lbxHOMOMaterial.Items.Clear()

    End Sub

    Private Sub BtnMATRemoveMaterial_Click(sender As Object, e As EventArgs) Handles btnMATRemoveMaterial.Click

        Dim index = lbxMAT.SelectedIndex

        saveFile.removeMaterial(index)

        lbxMAT.Items.Clear()
        Dim materialList() = saveFile.getAllMaterial()
        If Not IsNothing(materialList(0)) Then
            For i = 0 To materialList.Length() - 1 Step 1
                lbxMAT.Items.Add(materialList(i).getIdentifier())
            Next
        End If

    End Sub
    Private Sub BtnMATRemoveElement_Click(sender As Object, e As EventArgs) Handles btnMATRemoveElement.Click

        Dim index = lbxMATCustom.SelectedIndex - 1

        materialOfInterest.removeComposition(index)

        lbxMATCustom.Items.Clear()
        Dim elementList() = materialOfInterest.getAllComposition()
        If Not IsNothing(elementList(0)) Then
            For i = 0 To elementList.Length() - 1 Step 1
                lbxMATCustom.Items.Add(elementList(i).toString())
            Next
        End If

        If lbxMATCustom.Items.Count() = 1 Then
            lbxMATCustom.Items.Clear()
        End If

    End Sub
    Private Sub BtnHOMORemoveHomoMaterial_Click(sender As Object, e As EventArgs) Handles btnHOMORemoveHomoMaterial.Click

        Dim index = lbxHOMOHomoMaterial.SelectedIndex

        saveFile.removeHomo(index)

        lbxHOMOMaterial.Items.Clear()
        Dim homoList() = saveFile.getAllHomogeneous()
        If Not IsNothing(homoList(0)) Then
            For i = 0 To homoList.Length() - 1 Step 1
                lbxHOMOHomoMaterial.Items.Add(homoList(i).getName())
            Next
        End If

    End Sub
    Private Sub BtnHOMORemoveMaterial_Click(sender As Object, e As EventArgs) Handles btnHOMORemoveMaterial.Click
        Dim index = lbxHOMOMaterial.SelectedIndex - 1

        homoOfInterest.removeComposition(index)

        lbxHOMOHomoMaterial.Items.Clear()
        Dim compositionList() = homoOfInterest.getAllComposition()
        If Not IsNothing(compositionList(0)) Then
            For i = 0 To compositionList.Length() - 1 Step 1
                lbxHOMOMaterial.Items.Add(compositionList(i))
            Next
        End If

        If lbxHOMOMaterial.Items.Count() = 1 Then
            lbxHOMOMaterial.Items.Clear()
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

        cbxMATMaterialList.Items.Clear()
        cbxMATMaterialList.Text = ""
        txtMATMaterialName.Text = ""
        lblMATOption1.Text = ""
        lblMATOption2.Text = ""
        lblMATOption3.Text = ""
        txtMATOption1.Text = ""
        txtMATOption2.Text = ""
        txtMATOption3.Text = ""
        txtMATMaterialName.Enabled = False
        txtMATOption1.Enabled = False
        txtMATOption2.Enabled = False
        txtMATOption3.Enabled = False
        lbxMAT.Items.Clear()

        txtMATMaterialNameCustom.Text = ""
        chkMATMaterialBURN.Checked = False
        txtMATAtomicNumber.Text = ""
        txtMATMassNumber.Text = ""
        txtMATNumberDensity.Text = ""
        txtMATNumberDensityE.Text = ""
        lbxMATCustom.Items.Clear()

        txtHOMOHomoMaterialName.Text = ""
        txtHOMOMaterialName.Text = ""
        txtHOMOFraction.Text = ""
        lbxHOMOMaterial.Items.Clear()
        lbxHOMOHomoMaterial.Items.Clear()

        Dim databaseFile As String = My.Resources.MAT_DATA
        Dim line As String
        Dim reader As TextReader = New StringReader(databaseFile)
        line = reader.ReadLine
        Do While line <> "END OF FILE"
            cbxMATMaterialList.Items.Add(line)
            line = reader.ReadLine
            line = reader.ReadLine
            line = reader.ReadLine
        Loop

    End Sub
    Private Sub loadConfiguration()

        Dim materialList = saveFile.getAllMaterial()
        For i = 0 To materialList.Length() - 1 Step 1
            lbxMAT.Items.Add(materialList(i).getIdentifier())
        Next

        Dim homoList = saveFile.getAllHomogeneous()
        For i = 0 To homoList.Length() - 1 Step 1
            lbxHOMOHomoMaterial.Items.Add(homoList(i).getName())
        Next

        Dim databaseFile As String = My.Resources.MAT_DATA
        Dim line As String
        Dim reader As TextReader = New StringReader(databaseFile)
        line = reader.ReadLine
        Do While line <> "END OF FILE"
            cbxMATMaterialList.Items.Add(line)
            line = reader.ReadLine
            line = reader.ReadLine
            line = reader.ReadLine
        Loop

    End Sub

End Class
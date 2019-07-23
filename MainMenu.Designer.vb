<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblVersionInfo = New System.Windows.Forms.Label()
        Me.lblLabInfo = New System.Windows.Forms.Label()
        Me.gbxEssential = New System.Windows.Forms.GroupBox()
        Me.txtReactorID = New System.Windows.Forms.TextBox()
        Me.rdbChoosePreset = New System.Windows.Forms.RadioButton()
        Me.rdbCreateNew = New System.Windows.Forms.RadioButton()
        Me.cbxPreset = New System.Windows.Forms.ComboBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.gbxCheckList = New System.Windows.Forms.GroupBox()
        Me.btnConfAssem = New System.Windows.Forms.Button()
        Me.lblAssem = New System.Windows.Forms.Label()
        Me.lblLinkFA = New System.Windows.Forms.Label()
        Me.btnConfLinkFa = New System.Windows.Forms.Button()
        Me.btnConfLinkMat = New System.Windows.Forms.Button()
        Me.lblLinkMat = New System.Windows.Forms.Label()
        Me.btnConfLinkOption = New System.Windows.Forms.Button()
        Me.lblLinkOption = New System.Windows.Forms.Label()
        Me.lbxFileList = New System.Windows.Forms.ListBox()
        Me.gbpOverview = New System.Windows.Forms.GroupBox()
        Me.btnDuplicate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblFileList = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.gbxEssential.SuspendLayout()
        Me.gbxCheckList.SuspendLayout()
        Me.gbpOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(89, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(442, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "STRING: STReam INput Generator"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(467, 46)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(113, 14)
        Me.lblCredit.TabIndex = 1
        Me.lblCredit.Text = "created by Jung Min Ki"
        '
        'lblVersionInfo
        '
        Me.lblVersionInfo.AutoSize = True
        Me.lblVersionInfo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersionInfo.Location = New System.Drawing.Point(15, 46)
        Me.lblVersionInfo.Name = "lblVersionInfo"
        Me.lblVersionInfo.Size = New System.Drawing.Size(95, 14)
        Me.lblVersionInfo.TabIndex = 2
        Me.lblVersionInfo.Text = "version 0.2 [alpha]"
        '
        'lblLabInfo
        '
        Me.lblLabInfo.AutoSize = True
        Me.lblLabInfo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabInfo.Location = New System.Drawing.Point(281, 46)
        Me.lblLabInfo.Name = "lblLabInfo"
        Me.lblLabInfo.Size = New System.Drawing.Size(55, 14)
        Me.lblLabInfo.TabIndex = 3
        Me.lblLabInfo.Text = "SNU MCL"
        '
        'gbxEssential
        '
        Me.gbxEssential.Controls.Add(Me.txtReactorID)
        Me.gbxEssential.Controls.Add(Me.rdbChoosePreset)
        Me.gbxEssential.Controls.Add(Me.rdbCreateNew)
        Me.gbxEssential.Controls.Add(Me.cbxPreset)
        Me.gbxEssential.Controls.Add(Me.txtPath)
        Me.gbxEssential.Controls.Add(Me.lblPath)
        Me.gbxEssential.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEssential.Location = New System.Drawing.Point(18, 67)
        Me.gbxEssential.Name = "gbxEssential"
        Me.gbxEssential.Size = New System.Drawing.Size(568, 78)
        Me.gbxEssential.TabIndex = 0
        Me.gbxEssential.TabStop = False
        Me.gbxEssential.Text = "Essential Settings"
        '
        'txtReactorID
        '
        Me.txtReactorID.Enabled = False
        Me.txtReactorID.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReactorID.Location = New System.Drawing.Point(98, 45)
        Me.txtReactorID.Name = "txtReactorID"
        Me.txtReactorID.Size = New System.Drawing.Size(164, 21)
        Me.txtReactorID.TabIndex = 2
        Me.txtReactorID.Text = "Reactor Identification Code"
        Me.txtReactorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdbChoosePreset
        '
        Me.rdbChoosePreset.AutoSize = True
        Me.rdbChoosePreset.Enabled = False
        Me.rdbChoosePreset.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbChoosePreset.Location = New System.Drawing.Point(271, 46)
        Me.rdbChoosePreset.Name = "rdbChoosePreset"
        Me.rdbChoosePreset.Size = New System.Drawing.Size(120, 19)
        Me.rdbChoosePreset.TabIndex = 3
        Me.rdbChoosePreset.TabStop = True
        Me.rdbChoosePreset.Text = "Choose from &Preset"
        Me.rdbChoosePreset.UseVisualStyleBackColor = True
        '
        'rdbCreateNew
        '
        Me.rdbCreateNew.AutoSize = True
        Me.rdbCreateNew.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCreateNew.Location = New System.Drawing.Point(10, 46)
        Me.rdbCreateNew.Name = "rdbCreateNew"
        Me.rdbCreateNew.Size = New System.Drawing.Size(82, 19)
        Me.rdbCreateNew.TabIndex = 1
        Me.rdbCreateNew.TabStop = True
        Me.rdbCreateNew.Text = "Create &New"
        Me.rdbCreateNew.UseVisualStyleBackColor = True
        '
        'cbxPreset
        '
        Me.cbxPreset.Enabled = False
        Me.cbxPreset.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPreset.FormattingEnabled = True
        Me.cbxPreset.Location = New System.Drawing.Point(397, 45)
        Me.cbxPreset.Name = "cbxPreset"
        Me.cbxPreset.Size = New System.Drawing.Size(165, 23)
        Me.cbxPreset.TabIndex = 4
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(139, 19)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(423, 21)
        Me.txtPath.TabIndex = 0
        Me.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.Location = New System.Drawing.Point(7, 22)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(126, 15)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Path to STREAM folder"
        '
        'gbxCheckList
        '
        Me.gbxCheckList.Controls.Add(Me.btnConfAssem)
        Me.gbxCheckList.Controls.Add(Me.lblAssem)
        Me.gbxCheckList.Controls.Add(Me.lblLinkFA)
        Me.gbxCheckList.Controls.Add(Me.btnConfLinkFa)
        Me.gbxCheckList.Controls.Add(Me.btnConfLinkMat)
        Me.gbxCheckList.Controls.Add(Me.lblLinkMat)
        Me.gbxCheckList.Controls.Add(Me.btnConfLinkOption)
        Me.gbxCheckList.Controls.Add(Me.lblLinkOption)
        Me.gbxCheckList.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCheckList.Location = New System.Drawing.Point(18, 151)
        Me.gbxCheckList.Name = "gbxCheckList"
        Me.gbxCheckList.Size = New System.Drawing.Size(568, 172)
        Me.gbxCheckList.TabIndex = 1
        Me.gbxCheckList.TabStop = False
        Me.gbxCheckList.Text = "Check List"
        '
        'btnConfAssem
        '
        Me.btnConfAssem.Location = New System.Drawing.Point(210, 93)
        Me.btnConfAssem.Name = "btnConfAssem"
        Me.btnConfAssem.Size = New System.Drawing.Size(352, 29)
        Me.btnConfAssem.TabIndex = 2
        Me.btnConfAssem.Text = "Configure [Reactor Code]_&Assem_#.inp"
        Me.btnConfAssem.UseVisualStyleBackColor = True
        '
        'lblAssem
        '
        Me.lblAssem.AutoSize = True
        Me.lblAssem.Location = New System.Drawing.Point(7, 100)
        Me.lblAssem.Name = "lblAssem"
        Me.lblAssem.Size = New System.Drawing.Size(162, 15)
        Me.lblAssem.TabIndex = 6
        Me.lblAssem.Text = "3. [Reactor Code]_Assem_#.inp"
        '
        'lblLinkFA
        '
        Me.lblLinkFA.AutoSize = True
        Me.lblLinkFA.Location = New System.Drawing.Point(7, 135)
        Me.lblLinkFA.Name = "lblLinkFA"
        Me.lblLinkFA.Size = New System.Drawing.Size(166, 15)
        Me.lblLinkFA.TabIndex = 4
        Me.lblLinkFA.Text = "4. LINK_FA_[Reactor Code].dat"
        '
        'btnConfLinkFa
        '
        Me.btnConfLinkFa.Location = New System.Drawing.Point(210, 128)
        Me.btnConfLinkFa.Name = "btnConfLinkFa"
        Me.btnConfLinkFa.Size = New System.Drawing.Size(352, 29)
        Me.btnConfLinkFa.TabIndex = 3
        Me.btnConfLinkFa.Text = "Configure LINK_&FA_[Reactor Code].dat"
        Me.btnConfLinkFa.UseVisualStyleBackColor = True
        '
        'btnConfLinkMat
        '
        Me.btnConfLinkMat.Location = New System.Drawing.Point(210, 58)
        Me.btnConfLinkMat.Name = "btnConfLinkMat"
        Me.btnConfLinkMat.Size = New System.Drawing.Size(352, 29)
        Me.btnConfLinkMat.TabIndex = 1
        Me.btnConfLinkMat.Text = "Configure LINK_&MAT_[Reactor Code].dat"
        Me.btnConfLinkMat.UseVisualStyleBackColor = True
        '
        'lblLinkMat
        '
        Me.lblLinkMat.AutoSize = True
        Me.lblLinkMat.Location = New System.Drawing.Point(7, 65)
        Me.lblLinkMat.Name = "lblLinkMat"
        Me.lblLinkMat.Size = New System.Drawing.Size(179, 15)
        Me.lblLinkMat.TabIndex = 2
        Me.lblLinkMat.Text = "2. LINK_MAT_[Reactor Code].dat"
        '
        'btnConfLinkOption
        '
        Me.btnConfLinkOption.Location = New System.Drawing.Point(210, 22)
        Me.btnConfLinkOption.Name = "btnConfLinkOption"
        Me.btnConfLinkOption.Size = New System.Drawing.Size(352, 29)
        Me.btnConfLinkOption.TabIndex = 0
        Me.btnConfLinkOption.Text = "Configure LINK_&OPTION_[Reactor Code].dat"
        Me.btnConfLinkOption.UseVisualStyleBackColor = True
        '
        'lblLinkOption
        '
        Me.lblLinkOption.AutoSize = True
        Me.lblLinkOption.Location = New System.Drawing.Point(7, 29)
        Me.lblLinkOption.Name = "lblLinkOption"
        Me.lblLinkOption.Size = New System.Drawing.Size(197, 15)
        Me.lblLinkOption.TabIndex = 0
        Me.lblLinkOption.Text = "1. LINK_OPTION_[Reactor Code].dat"
        '
        'lbxFileList
        '
        Me.lbxFileList.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxFileList.FormattingEnabled = True
        Me.lbxFileList.ItemHeight = 15
        Me.lbxFileList.Location = New System.Drawing.Point(6, 35)
        Me.lbxFileList.Name = "lbxFileList"
        Me.lbxFileList.Size = New System.Drawing.Size(556, 94)
        Me.lbxFileList.TabIndex = 0
        '
        'gbpOverview
        '
        Me.gbpOverview.Controls.Add(Me.btnDuplicate)
        Me.gbpOverview.Controls.Add(Me.btnEdit)
        Me.gbpOverview.Controls.Add(Me.btnDelete)
        Me.gbpOverview.Controls.Add(Me.lblFileList)
        Me.gbpOverview.Controls.Add(Me.lbxFileList)
        Me.gbpOverview.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpOverview.Location = New System.Drawing.Point(18, 329)
        Me.gbpOverview.Name = "gbpOverview"
        Me.gbpOverview.Size = New System.Drawing.Size(568, 171)
        Me.gbpOverview.TabIndex = 2
        Me.gbpOverview.TabStop = False
        Me.gbpOverview.Text = "Overview"
        '
        'btnDuplicate
        '
        Me.btnDuplicate.Enabled = False
        Me.btnDuplicate.Location = New System.Drawing.Point(289, 135)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Size = New System.Drawing.Size(87, 29)
        Me.btnDuplicate.TabIndex = 1
        Me.btnDuplicate.Text = "D&uplicate"
        Me.btnDuplicate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(382, 135)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 29)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(475, 135)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 29)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblFileList
        '
        Me.lblFileList.AutoSize = True
        Me.lblFileList.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileList.Location = New System.Drawing.Point(241, 17)
        Me.lblFileList.Name = "lblFileList"
        Me.lblFileList.Size = New System.Drawing.Size(99, 15)
        Me.lblFileList.TabIndex = 9
        Me.lblFileList.Text = "List of Files Added"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(18, 506)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(568, 70)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "&Generate Input File(s)"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 596)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.gbpOverview)
        Me.Controls.Add(Me.gbxCheckList)
        Me.Controls.Add(Me.gbxEssential)
        Me.Controls.Add(Me.lblLabInfo)
        Me.Controls.Add(Me.lblVersionInfo)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainMenu"
        Me.Text = "Project Joshua"
        Me.gbxEssential.ResumeLayout(False)
        Me.gbxEssential.PerformLayout()
        Me.gbxCheckList.ResumeLayout(False)
        Me.gbxCheckList.PerformLayout()
        Me.gbpOverview.ResumeLayout(False)
        Me.gbpOverview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCredit As Label
    Friend WithEvents lblVersionInfo As Label
    Friend WithEvents lblLabInfo As Label
    Friend WithEvents gbxEssential As GroupBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents cbxPreset As ComboBox
    Friend WithEvents txtReactorID As TextBox
    Friend WithEvents rdbCreateNew As RadioButton
    Friend WithEvents rdbChoosePreset As RadioButton
    Friend WithEvents gbxCheckList As GroupBox
    Friend WithEvents btnConfAssem As Button
    Friend WithEvents lblAssem As Label
    Friend WithEvents btnConfLinkFa As Button
    Friend WithEvents lblLinkFA As Label
    Friend WithEvents btnConfLinkMat As Button
    Friend WithEvents lblLinkMat As Label
    Friend WithEvents btnConfLinkOption As Button
    Friend WithEvents lblLinkOption As Label
    Friend WithEvents lbxFileList As ListBox
    Friend WithEvents gbpOverview As GroupBox
    Friend WithEvents btnDuplicate As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblFileList As Label
    Friend WithEvents btnGenerate As Button
End Class

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
        Me.lblReactorIDExample = New System.Windows.Forms.Label()
        Me.lblReactorID = New System.Windows.Forms.Label()
        Me.txtReactorID = New System.Windows.Forms.TextBox()
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblFileList = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.pbxExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pbxLegacy = New System.Windows.Forms.PictureBox()
        Me.pbxMinimize = New System.Windows.Forms.PictureBox()
        Me.gbxEssential.SuspendLayout()
        Me.gbxCheckList.SuspendLayout()
        Me.gbpOverview.SuspendLayout()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.pbxLegacy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(78, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(501, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "STRING: STReam INput Generator"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(455, 89)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(121, 15)
        Me.lblCredit.TabIndex = 1
        Me.lblCredit.Text = "created by Jung Min Ki"
        '
        'lblVersionInfo
        '
        Me.lblVersionInfo.AutoSize = True
        Me.lblVersionInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersionInfo.Location = New System.Drawing.Point(12, 89)
        Me.lblVersionInfo.Name = "lblVersionInfo"
        Me.lblVersionInfo.Size = New System.Drawing.Size(97, 15)
        Me.lblVersionInfo.TabIndex = 2
        Me.lblVersionInfo.Text = "version 0.2 [alpha]"
        '
        'lblLabInfo
        '
        Me.lblLabInfo.AutoSize = True
        Me.lblLabInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabInfo.Location = New System.Drawing.Point(256, 89)
        Me.lblLabInfo.Name = "lblLabInfo"
        Me.lblLabInfo.Size = New System.Drawing.Size(61, 15)
        Me.lblLabInfo.TabIndex = 3
        Me.lblLabInfo.Text = "SNU MCL"
        '
        'gbxEssential
        '
        Me.gbxEssential.Controls.Add(Me.lblReactorIDExample)
        Me.gbxEssential.Controls.Add(Me.lblReactorID)
        Me.gbxEssential.Controls.Add(Me.txtReactorID)
        Me.gbxEssential.Controls.Add(Me.txtPath)
        Me.gbxEssential.Controls.Add(Me.lblPath)
        Me.gbxEssential.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEssential.Location = New System.Drawing.Point(12, 107)
        Me.gbxEssential.Name = "gbxEssential"
        Me.gbxEssential.Size = New System.Drawing.Size(564, 70)
        Me.gbxEssential.TabIndex = 0
        Me.gbxEssential.TabStop = False
        Me.gbxEssential.Text = "Essential Settings"
        '
        'lblReactorIDExample
        '
        Me.lblReactorIDExample.AutoSize = True
        Me.lblReactorIDExample.Location = New System.Drawing.Point(311, 45)
        Me.lblReactorIDExample.Name = "lblReactorIDExample"
        Me.lblReactorIDExample.Size = New System.Drawing.Size(110, 15)
        Me.lblReactorIDExample.TabIndex = 4
        Me.lblReactorIDExample.Text = "eg.) KORI, YGN3, ..."
        '
        'lblReactorID
        '
        Me.lblReactorID.AutoSize = True
        Me.lblReactorID.Location = New System.Drawing.Point(6, 45)
        Me.lblReactorID.Name = "lblReactorID"
        Me.lblReactorID.Size = New System.Drawing.Size(139, 15)
        Me.lblReactorID.TabIndex = 3
        Me.lblReactorID.Text = "Reactor Identification Code"
        '
        'txtReactorID
        '
        Me.txtReactorID.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReactorID.Location = New System.Drawing.Point(151, 43)
        Me.txtReactorID.Name = "txtReactorID"
        Me.txtReactorID.Size = New System.Drawing.Size(154, 20)
        Me.txtReactorID.TabIndex = 2
        Me.txtReactorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("NanumSquare", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(146, 17)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(412, 20)
        Me.txtPath.TabIndex = 0
        Me.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.Location = New System.Drawing.Point(6, 17)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(134, 15)
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
        Me.gbxCheckList.Location = New System.Drawing.Point(12, 183)
        Me.gbxCheckList.Name = "gbxCheckList"
        Me.gbxCheckList.Size = New System.Drawing.Size(568, 140)
        Me.gbxCheckList.TabIndex = 1
        Me.gbxCheckList.TabStop = False
        Me.gbxCheckList.Text = "Check List"
        '
        'btnConfAssem
        '
        Me.btnConfAssem.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnConfAssem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfAssem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfAssem.ForeColor = System.Drawing.Color.White
        Me.btnConfAssem.Location = New System.Drawing.Point(237, 74)
        Me.btnConfAssem.Name = "btnConfAssem"
        Me.btnConfAssem.Size = New System.Drawing.Size(325, 25)
        Me.btnConfAssem.TabIndex = 2
        Me.btnConfAssem.Text = "Configure [Reactor Code]_&Assem_#.inp"
        Me.btnConfAssem.UseVisualStyleBackColor = False
        '
        'lblAssem
        '
        Me.lblAssem.AutoSize = True
        Me.lblAssem.Location = New System.Drawing.Point(6, 79)
        Me.lblAssem.Name = "lblAssem"
        Me.lblAssem.Size = New System.Drawing.Size(162, 15)
        Me.lblAssem.TabIndex = 6
        Me.lblAssem.Text = "3. [Reactor Code]_Assem_#.inp"
        '
        'lblLinkFA
        '
        Me.lblLinkFA.AutoSize = True
        Me.lblLinkFA.Location = New System.Drawing.Point(6, 110)
        Me.lblLinkFA.Name = "lblLinkFA"
        Me.lblLinkFA.Size = New System.Drawing.Size(166, 15)
        Me.lblLinkFA.TabIndex = 4
        Me.lblLinkFA.Text = "4. LINK_FA_[Reactor Code].dat"
        '
        'btnConfLinkFa
        '
        Me.btnConfLinkFa.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnConfLinkFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfLinkFa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkFa.ForeColor = System.Drawing.Color.White
        Me.btnConfLinkFa.Location = New System.Drawing.Point(237, 105)
        Me.btnConfLinkFa.Name = "btnConfLinkFa"
        Me.btnConfLinkFa.Size = New System.Drawing.Size(325, 25)
        Me.btnConfLinkFa.TabIndex = 3
        Me.btnConfLinkFa.Text = "Configure LINK_&FA_[Reactor Code].dat"
        Me.btnConfLinkFa.UseVisualStyleBackColor = False
        '
        'btnConfLinkMat
        '
        Me.btnConfLinkMat.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnConfLinkMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfLinkMat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkMat.ForeColor = System.Drawing.Color.White
        Me.btnConfLinkMat.Location = New System.Drawing.Point(237, 43)
        Me.btnConfLinkMat.Name = "btnConfLinkMat"
        Me.btnConfLinkMat.Size = New System.Drawing.Size(325, 25)
        Me.btnConfLinkMat.TabIndex = 1
        Me.btnConfLinkMat.Text = "Configure LINK_&MAT_[Reactor Code].dat"
        Me.btnConfLinkMat.UseVisualStyleBackColor = False
        '
        'lblLinkMat
        '
        Me.lblLinkMat.AutoSize = True
        Me.lblLinkMat.Location = New System.Drawing.Point(6, 48)
        Me.lblLinkMat.Name = "lblLinkMat"
        Me.lblLinkMat.Size = New System.Drawing.Size(179, 15)
        Me.lblLinkMat.TabIndex = 2
        Me.lblLinkMat.Text = "2. LINK_MAT_[Reactor Code].dat"
        '
        'btnConfLinkOption
        '
        Me.btnConfLinkOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnConfLinkOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfLinkOption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkOption.ForeColor = System.Drawing.Color.White
        Me.btnConfLinkOption.Location = New System.Drawing.Point(237, 12)
        Me.btnConfLinkOption.Name = "btnConfLinkOption"
        Me.btnConfLinkOption.Size = New System.Drawing.Size(325, 25)
        Me.btnConfLinkOption.TabIndex = 0
        Me.btnConfLinkOption.Text = "Configure LINK_&OPTION_[Reactor Code].dat"
        Me.btnConfLinkOption.UseVisualStyleBackColor = False
        '
        'lblLinkOption
        '
        Me.lblLinkOption.AutoSize = True
        Me.lblLinkOption.Location = New System.Drawing.Point(6, 17)
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
        Me.lbxFileList.Size = New System.Drawing.Size(556, 64)
        Me.lbxFileList.TabIndex = 0
        '
        'gbpOverview
        '
        Me.gbpOverview.Controls.Add(Me.btnEdit)
        Me.gbpOverview.Controls.Add(Me.btnDelete)
        Me.gbpOverview.Controls.Add(Me.lblFileList)
        Me.gbpOverview.Controls.Add(Me.lbxFileList)
        Me.gbpOverview.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpOverview.Location = New System.Drawing.Point(12, 329)
        Me.gbpOverview.Name = "gbpOverview"
        Me.gbpOverview.Size = New System.Drawing.Size(568, 135)
        Me.gbpOverview.TabIndex = 2
        Me.gbpOverview.TabStop = False
        Me.gbpOverview.Text = "Overview"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(382, 105)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 25)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(475, 105)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 25)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblFileList
        '
        Me.lblFileList.AutoSize = True
        Me.lblFileList.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileList.Location = New System.Drawing.Point(234, 17)
        Me.lblFileList.Name = "lblFileList"
        Me.lblFileList.Size = New System.Drawing.Size(99, 15)
        Me.lblFileList.TabIndex = 9
        Me.lblFileList.Text = "List of Files Added"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(12, 470)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(568, 61)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "&Generate Input File(s)"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'pbxExit
        '
        Me.pbxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxExit.Image = Global.Project_Joshua.My.Resources.Resources._exit
        Me.pbxExit.InitialImage = Nothing
        Me.pbxExit.Location = New System.Drawing.Point(574, 0)
        Me.pbxExit.Name = "pbxExit"
        Me.pbxExit.Size = New System.Drawing.Size(20, 20)
        Me.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxExit.TabIndex = 4
        Me.pbxExit.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_Joshua.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.pbxLegacy)
        Me.pnlTop.Controls.Add(Me.pbxMinimize)
        Me.pnlTop.Controls.Add(Me.pbxExit)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(594, 20)
        Me.pnlTop.TabIndex = 6
        '
        'pbxLegacy
        '
        Me.pbxLegacy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxLegacy.InitialImage = Nothing
        Me.pbxLegacy.Location = New System.Drawing.Point(536, 0)
        Me.pbxLegacy.Name = "pbxLegacy"
        Me.pbxLegacy.Size = New System.Drawing.Size(20, 20)
        Me.pbxLegacy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLegacy.TabIndex = 6
        Me.pbxLegacy.TabStop = False
        '
        'pbxMinimize
        '
        Me.pbxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxMinimize.Image = Global.Project_Joshua.My.Resources.Resources.minimize
        Me.pbxMinimize.InitialImage = Nothing
        Me.pbxMinimize.Location = New System.Drawing.Point(555, 0)
        Me.pbxMinimize.Name = "pbxMinimize"
        Me.pbxMinimize.Size = New System.Drawing.Size(20, 20)
        Me.pbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMinimize.TabIndex = 5
        Me.pbxMinimize.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 544)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.gbpOverview)
        Me.Controls.Add(Me.gbxCheckList)
        Me.Controls.Add(Me.gbxEssential)
        Me.Controls.Add(Me.lblLabInfo)
        Me.Controls.Add(Me.lblVersionInfo)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("NanumSquare Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.Text = "Project Joshua"
        Me.gbxEssential.ResumeLayout(False)
        Me.gbxEssential.PerformLayout()
        Me.gbxCheckList.ResumeLayout(False)
        Me.gbxCheckList.PerformLayout()
        Me.gbpOverview.ResumeLayout(False)
        Me.gbpOverview.PerformLayout()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        CType(Me.pbxLegacy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtReactorID As TextBox
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
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblFileList As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lblReactorIDExample As Label
    Friend WithEvents lblReactorID As Label
    Friend WithEvents pbxExit As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pbxMinimize As PictureBox
    Friend WithEvents pbxLegacy As PictureBox
End Class

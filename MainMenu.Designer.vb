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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblAffiliation = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.gbxEssential = New System.Windows.Forms.GroupBox()
        Me.lblIDeg = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.gbxCheckList = New System.Windows.Forms.GroupBox()
        Me.lblFA = New System.Windows.Forms.Label()
        Me.btnFA = New System.Windows.Forms.Button()
        Me.lblAssem = New System.Windows.Forms.Label()
        Me.btnAssem = New System.Windows.Forms.Button()
        Me.lblMAT = New System.Windows.Forms.Label()
        Me.btnMAT = New System.Windows.Forms.Button()
        Me.lblOPTION = New System.Windows.Forms.Label()
        Me.btnOPTION = New System.Windows.Forms.Button()
        Me.gbxOverview = New System.Windows.Forms.GroupBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lbxList = New System.Windows.Forms.ListBox()
        Me.lblList = New System.Windows.Forms.Label()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxEssential.SuspendLayout()
        Me.gbxCheckList.SuspendLayout()
        Me.gbxOverview.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.STREAM_Input_Generator.My.Resources.Resources.logo
        Me.pbxLogo.Location = New System.Drawing.Point(1, 1)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(150, 150)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(149, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(883, 61)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "STRING: STReam INput Generator"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(156, 99)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(223, 31)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "version 0.3 [beta]"
        '
        'lblAffiliation
        '
        Me.lblAffiliation.AutoSize = True
        Me.lblAffiliation.Location = New System.Drawing.Point(497, 99)
        Me.lblAffiliation.Name = "lblAffiliation"
        Me.lblAffiliation.Size = New System.Drawing.Size(136, 31)
        Me.lblAffiliation.TabIndex = 3
        Me.lblAffiliation.Text = "SNU MCL"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(732, 99)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(288, 31)
        Me.lblCredit.TabIndex = 4
        Me.lblCredit.Text = "created by Jung Min Ki"
        '
        'gbxEssential
        '
        Me.gbxEssential.Controls.Add(Me.lblIDeg)
        Me.gbxEssential.Controls.Add(Me.lblID)
        Me.gbxEssential.Controls.Add(Me.txtID)
        Me.gbxEssential.Controls.Add(Me.txtPath)
        Me.gbxEssential.Controls.Add(Me.lblPath)
        Me.gbxEssential.Location = New System.Drawing.Point(12, 157)
        Me.gbxEssential.Name = "gbxEssential"
        Me.gbxEssential.Size = New System.Drawing.Size(1008, 131)
        Me.gbxEssential.TabIndex = 0
        Me.gbxEssential.TabStop = False
        Me.gbxEssential.Text = "Essential Settings"
        '
        'lblIDeg
        '
        Me.lblIDeg.AutoSize = True
        Me.lblIDeg.Location = New System.Drawing.Point(564, 84)
        Me.lblIDeg.Name = "lblIDeg"
        Me.lblIDeg.Size = New System.Drawing.Size(255, 31)
        Me.lblIDeg.TabIndex = 4
        Me.lblIDeg.Text = "eg.) KORI, YGN3 ..."
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 84)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(217, 31)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "Reactor ID Code"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(229, 81)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(329, 38)
        Me.txtID.TabIndex = 1
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(307, 37)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(695, 38)
        Me.txtPath.TabIndex = 0
        Me.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(6, 40)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(295, 31)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Path to STREAM folder"
        '
        'gbxCheckList
        '
        Me.gbxCheckList.Controls.Add(Me.lblFA)
        Me.gbxCheckList.Controls.Add(Me.btnFA)
        Me.gbxCheckList.Controls.Add(Me.lblAssem)
        Me.gbxCheckList.Controls.Add(Me.btnAssem)
        Me.gbxCheckList.Controls.Add(Me.lblMAT)
        Me.gbxCheckList.Controls.Add(Me.btnMAT)
        Me.gbxCheckList.Controls.Add(Me.lblOPTION)
        Me.gbxCheckList.Controls.Add(Me.btnOPTION)
        Me.gbxCheckList.Location = New System.Drawing.Point(12, 294)
        Me.gbxCheckList.Name = "gbxCheckList"
        Me.gbxCheckList.Size = New System.Drawing.Size(1008, 241)
        Me.gbxCheckList.TabIndex = 1
        Me.gbxCheckList.TabStop = False
        Me.gbxCheckList.Text = "Check List"
        '
        'lblFA
        '
        Me.lblFA.AutoSize = True
        Me.lblFA.Location = New System.Drawing.Point(6, 194)
        Me.lblFA.Name = "lblFA"
        Me.lblFA.Size = New System.Drawing.Size(328, 31)
        Me.lblFA.TabIndex = 11
        Me.lblFA.Text = "4. LINK_FA_[Reactor].dat"
        '
        'btnFA
        '
        Me.btnFA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnFA.FlatAppearance.BorderSize = 2
        Me.btnFA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnFA.Location = New System.Drawing.Point(482, 187)
        Me.btnFA.Name = "btnFA"
        Me.btnFA.Size = New System.Drawing.Size(520, 44)
        Me.btnFA.TabIndex = 3
        Me.btnFA.Text = "Configure LINK_&FA_[Reactor].dat"
        Me.btnFA.UseVisualStyleBackColor = True
        '
        'lblAssem
        '
        Me.lblAssem.AutoSize = True
        Me.lblAssem.Location = New System.Drawing.Point(6, 144)
        Me.lblAssem.Name = "lblAssem"
        Me.lblAssem.Size = New System.Drawing.Size(328, 31)
        Me.lblAssem.TabIndex = 9
        Me.lblAssem.Text = "3. [Reactor]_Assem_#.inp"
        '
        'btnAssem
        '
        Me.btnAssem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnAssem.FlatAppearance.BorderSize = 2
        Me.btnAssem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAssem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAssem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnAssem.Location = New System.Drawing.Point(482, 137)
        Me.btnAssem.Name = "btnAssem"
        Me.btnAssem.Size = New System.Drawing.Size(520, 44)
        Me.btnAssem.TabIndex = 2
        Me.btnAssem.Text = "Configure [Reactor]_&Assem_#.inp"
        Me.btnAssem.UseVisualStyleBackColor = True
        '
        'lblMAT
        '
        Me.lblMAT.AutoSize = True
        Me.lblMAT.Location = New System.Drawing.Point(6, 94)
        Me.lblMAT.Name = "lblMAT"
        Me.lblMAT.Size = New System.Drawing.Size(350, 31)
        Me.lblMAT.TabIndex = 7
        Me.lblMAT.Text = "2. LINK_MAT_[Reactor].dat"
        '
        'btnMAT
        '
        Me.btnMAT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnMAT.FlatAppearance.BorderSize = 2
        Me.btnMAT.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMAT.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnMAT.Location = New System.Drawing.Point(482, 87)
        Me.btnMAT.Name = "btnMAT"
        Me.btnMAT.Size = New System.Drawing.Size(520, 44)
        Me.btnMAT.TabIndex = 1
        Me.btnMAT.Text = "Configure LINK_&MAT_[Reactor].dat"
        Me.btnMAT.UseVisualStyleBackColor = True
        '
        'lblOPTION
        '
        Me.lblOPTION.AutoSize = True
        Me.lblOPTION.Location = New System.Drawing.Point(6, 44)
        Me.lblOPTION.Name = "lblOPTION"
        Me.lblOPTION.Size = New System.Drawing.Size(398, 31)
        Me.lblOPTION.TabIndex = 5
        Me.lblOPTION.Text = "1. LINK_OPTION_[Reactor].dat"
        '
        'btnOPTION
        '
        Me.btnOPTION.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnOPTION.FlatAppearance.BorderSize = 2
        Me.btnOPTION.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOPTION.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOPTION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOPTION.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnOPTION.Location = New System.Drawing.Point(482, 37)
        Me.btnOPTION.Name = "btnOPTION"
        Me.btnOPTION.Size = New System.Drawing.Size(520, 44)
        Me.btnOPTION.TabIndex = 0
        Me.btnOPTION.Text = "Configure LINK_&OPTION_[Reactor].dat"
        Me.btnOPTION.UseVisualStyleBackColor = True
        '
        'gbxOverview
        '
        Me.gbxOverview.Controls.Add(Me.btnGenerate)
        Me.gbxOverview.Controls.Add(Me.btnDelete)
        Me.gbxOverview.Controls.Add(Me.btnEdit)
        Me.gbxOverview.Controls.Add(Me.lbxList)
        Me.gbxOverview.Controls.Add(Me.lblList)
        Me.gbxOverview.Location = New System.Drawing.Point(12, 541)
        Me.gbxOverview.Name = "gbxOverview"
        Me.gbxOverview.Size = New System.Drawing.Size(1008, 247)
        Me.gbxOverview.TabIndex = 2
        Me.gbxOverview.TabStop = False
        Me.gbxOverview.Text = "Overview"
        '
        'btnGenerate
        '
        Me.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnGenerate.FlatAppearance.BorderSize = 2
        Me.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnGenerate.Location = New System.Drawing.Point(753, 180)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(249, 57)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "&Generate File(s)"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(753, 129)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(249, 45)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 2
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(753, 78)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(249, 45)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lbxList
        '
        Me.lbxList.FormattingEnabled = True
        Me.lbxList.ItemHeight = 31
        Me.lbxList.Location = New System.Drawing.Point(6, 78)
        Me.lbxList.Name = "lbxList"
        Me.lbxList.Size = New System.Drawing.Size(741, 159)
        Me.lbxList.TabIndex = 0
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Location = New System.Drawing.Point(271, 34)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(255, 31)
        Me.lblList.TabIndex = 0
        Me.lblList.Text = "List of File(s) Added"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1034, 804)
        Me.Controls.Add(Me.gbxOverview)
        Me.Controls.Add(Me.gbxCheckList)
        Me.Controls.Add(Me.gbxEssential)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblAffiliation)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbxLogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.Text = "STRING version 0.3"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxEssential.ResumeLayout(False)
        Me.gbxEssential.PerformLayout()
        Me.gbxCheckList.ResumeLayout(False)
        Me.gbxCheckList.PerformLayout()
        Me.gbxOverview.ResumeLayout(False)
        Me.gbxOverview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblAffiliation As Label
    Friend WithEvents lblCredit As Label
    Friend WithEvents gbxEssential As GroupBox
    Friend WithEvents lblIDeg As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents gbxCheckList As GroupBox
    Friend WithEvents lblFA As Label
    Friend WithEvents btnFA As Button
    Friend WithEvents lblAssem As Label
    Friend WithEvents btnAssem As Button
    Friend WithEvents lblMAT As Label
    Friend WithEvents btnMAT As Button
    Friend WithEvents lblOPTION As Label
    Friend WithEvents btnOPTION As Button
    Friend WithEvents gbxOverview As GroupBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lbxList As ListBox
    Friend WithEvents lblList As Label
End Class

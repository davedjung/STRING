<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Legacy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.gbpOverview = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblFileList = New System.Windows.Forms.Label()
        Me.lbxFileList = New System.Windows.Forms.ListBox()
        Me.gbxCheckList = New System.Windows.Forms.GroupBox()
        Me.btnConfAssem = New System.Windows.Forms.Button()
        Me.lblAssem = New System.Windows.Forms.Label()
        Me.lblLinkFA = New System.Windows.Forms.Label()
        Me.btnConfLinkFa = New System.Windows.Forms.Button()
        Me.btnConfLinkMat = New System.Windows.Forms.Button()
        Me.lblLinkMat = New System.Windows.Forms.Label()
        Me.btnConfLinkOption = New System.Windows.Forms.Button()
        Me.lblLinkOption = New System.Windows.Forms.Label()
        Me.gbxEssential = New System.Windows.Forms.GroupBox()
        Me.lblReactorIDExample = New System.Windows.Forms.Label()
        Me.lblReactorID = New System.Windows.Forms.Label()
        Me.txtReactorID = New System.Windows.Forms.TextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lblLabInfo = New System.Windows.Forms.Label()
        Me.lblVersionInfo = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbpOverview.SuspendLayout()
        Me.gbxCheckList.SuspendLayout()
        Me.gbxEssential.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_Joshua.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.SystemColors.Control
        Me.btnGenerate.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGenerate.Location = New System.Drawing.Point(12, 456)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(568, 61)
        Me.btnGenerate.TabIndex = 12
        Me.btnGenerate.Text = "&Generate Input File(s)"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'gbpOverview
        '
        Me.gbpOverview.Controls.Add(Me.btnEdit)
        Me.gbpOverview.Controls.Add(Me.btnDelete)
        Me.gbpOverview.Controls.Add(Me.lblFileList)
        Me.gbpOverview.Controls.Add(Me.lbxFileList)
        Me.gbpOverview.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpOverview.ForeColor = System.Drawing.Color.Black
        Me.gbpOverview.Location = New System.Drawing.Point(12, 315)
        Me.gbpOverview.Name = "gbpOverview"
        Me.gbpOverview.Size = New System.Drawing.Size(568, 135)
        Me.gbpOverview.TabIndex = 10
        Me.gbpOverview.TabStop = False
        Me.gbpOverview.Text = "Overview"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEdit.Location = New System.Drawing.Point(382, 105)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 25)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(475, 105)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 25)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblFileList
        '
        Me.lblFileList.AutoSize = True
        Me.lblFileList.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileList.ForeColor = System.Drawing.Color.Black
        Me.lblFileList.Location = New System.Drawing.Point(234, 17)
        Me.lblFileList.Name = "lblFileList"
        Me.lblFileList.Size = New System.Drawing.Size(99, 15)
        Me.lblFileList.TabIndex = 9
        Me.lblFileList.Text = "List of Files Added"
        '
        'lbxFileList
        '
        Me.lbxFileList.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxFileList.ForeColor = System.Drawing.Color.Black
        Me.lbxFileList.FormattingEnabled = True
        Me.lbxFileList.ItemHeight = 15
        Me.lbxFileList.Location = New System.Drawing.Point(6, 35)
        Me.lbxFileList.Name = "lbxFileList"
        Me.lbxFileList.Size = New System.Drawing.Size(556, 64)
        Me.lbxFileList.TabIndex = 0
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
        Me.gbxCheckList.ForeColor = System.Drawing.Color.Black
        Me.gbxCheckList.Location = New System.Drawing.Point(12, 169)
        Me.gbxCheckList.Name = "gbxCheckList"
        Me.gbxCheckList.Size = New System.Drawing.Size(568, 140)
        Me.gbxCheckList.TabIndex = 8
        Me.gbxCheckList.TabStop = False
        Me.gbxCheckList.Text = "Check List"
        '
        'btnConfAssem
        '
        Me.btnConfAssem.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfAssem.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfAssem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConfAssem.Location = New System.Drawing.Point(237, 74)
        Me.btnConfAssem.Name = "btnConfAssem"
        Me.btnConfAssem.Size = New System.Drawing.Size(325, 25)
        Me.btnConfAssem.TabIndex = 2
        Me.btnConfAssem.Text = "Configure [Reactor Code]_&Assem_#.inp"
        Me.btnConfAssem.UseVisualStyleBackColor = True
        '
        'lblAssem
        '
        Me.lblAssem.AutoSize = True
        Me.lblAssem.ForeColor = System.Drawing.Color.Black
        Me.lblAssem.Location = New System.Drawing.Point(6, 79)
        Me.lblAssem.Name = "lblAssem"
        Me.lblAssem.Size = New System.Drawing.Size(162, 15)
        Me.lblAssem.TabIndex = 6
        Me.lblAssem.Text = "3. [Reactor Code]_Assem_#.inp"
        '
        'lblLinkFA
        '
        Me.lblLinkFA.AutoSize = True
        Me.lblLinkFA.ForeColor = System.Drawing.Color.Black
        Me.lblLinkFA.Location = New System.Drawing.Point(6, 110)
        Me.lblLinkFA.Name = "lblLinkFA"
        Me.lblLinkFA.Size = New System.Drawing.Size(166, 15)
        Me.lblLinkFA.TabIndex = 4
        Me.lblLinkFA.Text = "4. LINK_FA_[Reactor Code].dat"
        '
        'btnConfLinkFa
        '
        Me.btnConfLinkFa.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfLinkFa.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkFa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConfLinkFa.Location = New System.Drawing.Point(237, 105)
        Me.btnConfLinkFa.Name = "btnConfLinkFa"
        Me.btnConfLinkFa.Size = New System.Drawing.Size(325, 25)
        Me.btnConfLinkFa.TabIndex = 3
        Me.btnConfLinkFa.Text = "Configure LINK_&FA_[Reactor Code].dat"
        Me.btnConfLinkFa.UseVisualStyleBackColor = True
        '
        'btnConfLinkMat
        '
        Me.btnConfLinkMat.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfLinkMat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkMat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConfLinkMat.Location = New System.Drawing.Point(237, 43)
        Me.btnConfLinkMat.Name = "btnConfLinkMat"
        Me.btnConfLinkMat.Size = New System.Drawing.Size(325, 25)
        Me.btnConfLinkMat.TabIndex = 1
        Me.btnConfLinkMat.Text = "Configure LINK_&MAT_[Reactor Code].dat"
        Me.btnConfLinkMat.UseVisualStyleBackColor = True
        '
        'lblLinkMat
        '
        Me.lblLinkMat.AutoSize = True
        Me.lblLinkMat.ForeColor = System.Drawing.Color.Black
        Me.lblLinkMat.Location = New System.Drawing.Point(6, 48)
        Me.lblLinkMat.Name = "lblLinkMat"
        Me.lblLinkMat.Size = New System.Drawing.Size(179, 15)
        Me.lblLinkMat.TabIndex = 2
        Me.lblLinkMat.Text = "2. LINK_MAT_[Reactor Code].dat"
        '
        'btnConfLinkOption
        '
        Me.btnConfLinkOption.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfLinkOption.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkOption.ForeColor = System.Drawing.Color.Black
        Me.btnConfLinkOption.Location = New System.Drawing.Point(237, 12)
        Me.btnConfLinkOption.Name = "btnConfLinkOption"
        Me.btnConfLinkOption.Size = New System.Drawing.Size(325, 25)
        Me.btnConfLinkOption.TabIndex = 0
        Me.btnConfLinkOption.Text = "Configure LINK_&OPTION_[Reactor Code].dat"
        Me.btnConfLinkOption.UseVisualStyleBackColor = True
        '
        'lblLinkOption
        '
        Me.lblLinkOption.AutoSize = True
        Me.lblLinkOption.ForeColor = System.Drawing.Color.Black
        Me.lblLinkOption.Location = New System.Drawing.Point(6, 17)
        Me.lblLinkOption.Name = "lblLinkOption"
        Me.lblLinkOption.Size = New System.Drawing.Size(197, 15)
        Me.lblLinkOption.TabIndex = 0
        Me.lblLinkOption.Text = "1. LINK_OPTION_[Reactor Code].dat"
        '
        'gbxEssential
        '
        Me.gbxEssential.Controls.Add(Me.lblReactorIDExample)
        Me.gbxEssential.Controls.Add(Me.lblReactorID)
        Me.gbxEssential.Controls.Add(Me.txtReactorID)
        Me.gbxEssential.Controls.Add(Me.txtPath)
        Me.gbxEssential.Controls.Add(Me.lblPath)
        Me.gbxEssential.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEssential.ForeColor = System.Drawing.Color.Black
        Me.gbxEssential.Location = New System.Drawing.Point(12, 93)
        Me.gbxEssential.Name = "gbxEssential"
        Me.gbxEssential.Size = New System.Drawing.Size(564, 70)
        Me.gbxEssential.TabIndex = 6
        Me.gbxEssential.TabStop = False
        Me.gbxEssential.Text = "Essential Settings"
        '
        'lblReactorIDExample
        '
        Me.lblReactorIDExample.AutoSize = True
        Me.lblReactorIDExample.ForeColor = System.Drawing.Color.Black
        Me.lblReactorIDExample.Location = New System.Drawing.Point(311, 45)
        Me.lblReactorIDExample.Name = "lblReactorIDExample"
        Me.lblReactorIDExample.Size = New System.Drawing.Size(110, 15)
        Me.lblReactorIDExample.TabIndex = 4
        Me.lblReactorIDExample.Text = "eg.) KORI, YGN3, ..."
        '
        'lblReactorID
        '
        Me.lblReactorID.AutoSize = True
        Me.lblReactorID.ForeColor = System.Drawing.Color.Black
        Me.lblReactorID.Location = New System.Drawing.Point(6, 45)
        Me.lblReactorID.Name = "lblReactorID"
        Me.lblReactorID.Size = New System.Drawing.Size(139, 15)
        Me.lblReactorID.TabIndex = 3
        Me.lblReactorID.Text = "Reactor Identification Code"
        '
        'txtReactorID
        '
        Me.txtReactorID.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReactorID.ForeColor = System.Drawing.Color.Black
        Me.txtReactorID.Location = New System.Drawing.Point(151, 43)
        Me.txtReactorID.Name = "txtReactorID"
        Me.txtReactorID.Size = New System.Drawing.Size(154, 20)
        Me.txtReactorID.TabIndex = 2
        Me.txtReactorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("NanumSquare", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.ForeColor = System.Drawing.Color.Black
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
        Me.lblPath.ForeColor = System.Drawing.Color.Black
        Me.lblPath.Location = New System.Drawing.Point(6, 17)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(134, 15)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Path to STREAM folder"
        '
        'lblLabInfo
        '
        Me.lblLabInfo.AutoSize = True
        Me.lblLabInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabInfo.ForeColor = System.Drawing.Color.Black
        Me.lblLabInfo.Location = New System.Drawing.Point(256, 75)
        Me.lblLabInfo.Name = "lblLabInfo"
        Me.lblLabInfo.Size = New System.Drawing.Size(61, 15)
        Me.lblLabInfo.TabIndex = 13
        Me.lblLabInfo.Text = "SNU MCL"
        '
        'lblVersionInfo
        '
        Me.lblVersionInfo.AutoSize = True
        Me.lblVersionInfo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersionInfo.ForeColor = System.Drawing.Color.Black
        Me.lblVersionInfo.Location = New System.Drawing.Point(12, 75)
        Me.lblVersionInfo.Name = "lblVersionInfo"
        Me.lblVersionInfo.Size = New System.Drawing.Size(97, 15)
        Me.lblVersionInfo.TabIndex = 11
        Me.lblVersionInfo.Text = "version 0.2 [alpha]"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.ForeColor = System.Drawing.Color.Black
        Me.lblCredit.Location = New System.Drawing.Point(455, 75)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(121, 15)
        Me.lblCredit.TabIndex = 9
        Me.lblCredit.Text = "created by Jung Min Ki"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(78, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(501, 31)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "STRING: STReam INput Generator"
        '
        'Legacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 530)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.gbpOverview)
        Me.Controls.Add(Me.gbxCheckList)
        Me.Controls.Add(Me.gbxEssential)
        Me.Controls.Add(Me.lblLabInfo)
        Me.Controls.Add(Me.lblVersionInfo)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Legacy"
        Me.Text = "Legacy"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbpOverview.ResumeLayout(False)
        Me.gbpOverview.PerformLayout()
        Me.gbxCheckList.ResumeLayout(False)
        Me.gbxCheckList.PerformLayout()
        Me.gbxEssential.ResumeLayout(False)
        Me.gbxEssential.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents gbpOverview As GroupBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblFileList As Label
    Friend WithEvents lbxFileList As ListBox
    Friend WithEvents gbxCheckList As GroupBox
    Friend WithEvents btnConfAssem As Button
    Friend WithEvents lblAssem As Label
    Friend WithEvents lblLinkFA As Label
    Friend WithEvents btnConfLinkFa As Button
    Friend WithEvents btnConfLinkMat As Button
    Friend WithEvents lblLinkMat As Label
    Friend WithEvents btnConfLinkOption As Button
    Friend WithEvents lblLinkOption As Label
    Friend WithEvents gbxEssential As GroupBox
    Friend WithEvents lblReactorIDExample As Label
    Friend WithEvents lblReactorID As Label
    Friend WithEvents txtReactorID As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents lblLabInfo As Label
    Friend WithEvents lblVersionInfo As Label
    Friend WithEvents lblCredit As Label
    Friend WithEvents lblTitle As Label
End Class

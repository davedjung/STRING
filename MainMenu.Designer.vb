﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.gbxEssential.SuspendLayout()
        Me.gbxCheckList.SuspendLayout()
        Me.gbpOverview.SuspendLayout()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(73, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(501, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "STRING: STReam INput Generator"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(453, 71)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(144, 14)
        Me.lblCredit.TabIndex = 1
        Me.lblCredit.Text = "created by Jung Min Ki"
        '
        'lblVersionInfo
        '
        Me.lblVersionInfo.AutoSize = True
        Me.lblVersionInfo.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersionInfo.Location = New System.Drawing.Point(32, 71)
        Me.lblVersionInfo.Name = "lblVersionInfo"
        Me.lblVersionInfo.Size = New System.Drawing.Size(120, 14)
        Me.lblVersionInfo.TabIndex = 2
        Me.lblVersionInfo.Text = "version 0.2 [alpha]"
        '
        'lblLabInfo
        '
        Me.lblLabInfo.AutoSize = True
        Me.lblLabInfo.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabInfo.Location = New System.Drawing.Point(292, 71)
        Me.lblLabInfo.Name = "lblLabInfo"
        Me.lblLabInfo.Size = New System.Drawing.Size(62, 14)
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
        Me.gbxEssential.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxEssential.Location = New System.Drawing.Point(29, 89)
        Me.gbxEssential.Name = "gbxEssential"
        Me.gbxEssential.Size = New System.Drawing.Size(568, 68)
        Me.gbxEssential.TabIndex = 0
        Me.gbxEssential.TabStop = False
        Me.gbxEssential.Text = "Essential Settings"
        '
        'lblReactorIDExample
        '
        Me.lblReactorIDExample.AutoSize = True
        Me.lblReactorIDExample.Location = New System.Drawing.Point(325, 42)
        Me.lblReactorIDExample.Name = "lblReactorIDExample"
        Me.lblReactorIDExample.Size = New System.Drawing.Size(122, 14)
        Me.lblReactorIDExample.TabIndex = 4
        Me.lblReactorIDExample.Text = "eg.) KORI, YGN3, ..."
        '
        'lblReactorID
        '
        Me.lblReactorID.AutoSize = True
        Me.lblReactorID.Location = New System.Drawing.Point(7, 42)
        Me.lblReactorID.Name = "lblReactorID"
        Me.lblReactorID.Size = New System.Drawing.Size(171, 14)
        Me.lblReactorID.TabIndex = 3
        Me.lblReactorID.Text = "Reactor Identification Code"
        '
        'txtReactorID
        '
        Me.txtReactorID.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReactorID.Location = New System.Drawing.Point(184, 38)
        Me.txtReactorID.Name = "txtReactorID"
        Me.txtReactorID.Size = New System.Drawing.Size(135, 21)
        Me.txtReactorID.TabIndex = 2
        Me.txtReactorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(157, 16)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(405, 21)
        Me.txtPath.TabIndex = 0
        Me.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.Location = New System.Drawing.Point(7, 19)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(144, 14)
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
        Me.gbxCheckList.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCheckList.Location = New System.Drawing.Point(29, 162)
        Me.gbxCheckList.Name = "gbxCheckList"
        Me.gbxCheckList.Size = New System.Drawing.Size(568, 149)
        Me.gbxCheckList.TabIndex = 1
        Me.gbxCheckList.TabStop = False
        Me.gbxCheckList.Text = "Check List"
        '
        'btnConfAssem
        '
        Me.btnConfAssem.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnConfAssem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfAssem.Font = New System.Drawing.Font("NanumSquare Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfAssem.ForeColor = System.Drawing.Color.White
        Me.btnConfAssem.Location = New System.Drawing.Point(237, 81)
        Me.btnConfAssem.Name = "btnConfAssem"
        Me.btnConfAssem.Size = New System.Drawing.Size(325, 25)
        Me.btnConfAssem.TabIndex = 2
        Me.btnConfAssem.Text = "Configure [Reactor Code]_&Assem_#.inp"
        Me.btnConfAssem.UseVisualStyleBackColor = False
        '
        'lblAssem
        '
        Me.lblAssem.AutoSize = True
        Me.lblAssem.Location = New System.Drawing.Point(7, 87)
        Me.lblAssem.Name = "lblAssem"
        Me.lblAssem.Size = New System.Drawing.Size(198, 14)
        Me.lblAssem.TabIndex = 6
        Me.lblAssem.Text = "3. [Reactor Code]_Assem_#.inp"
        '
        'lblLinkFA
        '
        Me.lblLinkFA.AutoSize = True
        Me.lblLinkFA.Location = New System.Drawing.Point(7, 117)
        Me.lblLinkFA.Name = "lblLinkFA"
        Me.lblLinkFA.Size = New System.Drawing.Size(195, 14)
        Me.lblLinkFA.TabIndex = 4
        Me.lblLinkFA.Text = "4. LINK_FA_[Reactor Code].dat"
        '
        'btnConfLinkFa
        '
        Me.btnConfLinkFa.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnConfLinkFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfLinkFa.Font = New System.Drawing.Font("NanumSquare Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkFa.ForeColor = System.Drawing.Color.White
        Me.btnConfLinkFa.Location = New System.Drawing.Point(237, 111)
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
        Me.btnConfLinkMat.Font = New System.Drawing.Font("NanumSquare Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkMat.ForeColor = System.Drawing.Color.White
        Me.btnConfLinkMat.Location = New System.Drawing.Point(237, 50)
        Me.btnConfLinkMat.Name = "btnConfLinkMat"
        Me.btnConfLinkMat.Size = New System.Drawing.Size(325, 25)
        Me.btnConfLinkMat.TabIndex = 1
        Me.btnConfLinkMat.Text = "Configure LINK_&MAT_[Reactor Code].dat"
        Me.btnConfLinkMat.UseVisualStyleBackColor = False
        '
        'lblLinkMat
        '
        Me.lblLinkMat.AutoSize = True
        Me.lblLinkMat.Location = New System.Drawing.Point(7, 56)
        Me.lblLinkMat.Name = "lblLinkMat"
        Me.lblLinkMat.Size = New System.Drawing.Size(206, 14)
        Me.lblLinkMat.TabIndex = 2
        Me.lblLinkMat.Text = "2. LINK_MAT_[Reactor Code].dat"
        '
        'btnConfLinkOption
        '
        Me.btnConfLinkOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnConfLinkOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfLinkOption.Font = New System.Drawing.Font("NanumSquare Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfLinkOption.ForeColor = System.Drawing.Color.White
        Me.btnConfLinkOption.Location = New System.Drawing.Point(237, 19)
        Me.btnConfLinkOption.Name = "btnConfLinkOption"
        Me.btnConfLinkOption.Size = New System.Drawing.Size(325, 25)
        Me.btnConfLinkOption.TabIndex = 0
        Me.btnConfLinkOption.Text = "Configure LINK_&OPTION_[Reactor Code].dat"
        Me.btnConfLinkOption.UseVisualStyleBackColor = False
        '
        'lblLinkOption
        '
        Me.lblLinkOption.AutoSize = True
        Me.lblLinkOption.Location = New System.Drawing.Point(7, 25)
        Me.lblLinkOption.Name = "lblLinkOption"
        Me.lblLinkOption.Size = New System.Drawing.Size(224, 14)
        Me.lblLinkOption.TabIndex = 0
        Me.lblLinkOption.Text = "1. LINK_OPTION_[Reactor Code].dat"
        '
        'lbxFileList
        '
        Me.lbxFileList.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxFileList.FormattingEnabled = True
        Me.lbxFileList.ItemHeight = 14
        Me.lbxFileList.Location = New System.Drawing.Point(6, 31)
        Me.lbxFileList.Name = "lbxFileList"
        Me.lbxFileList.Size = New System.Drawing.Size(556, 74)
        Me.lbxFileList.TabIndex = 0
        '
        'gbpOverview
        '
        Me.gbpOverview.Controls.Add(Me.btnEdit)
        Me.gbpOverview.Controls.Add(Me.btnDelete)
        Me.gbpOverview.Controls.Add(Me.lblFileList)
        Me.gbpOverview.Controls.Add(Me.lbxFileList)
        Me.gbpOverview.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpOverview.Location = New System.Drawing.Point(29, 316)
        Me.gbpOverview.Name = "gbpOverview"
        Me.gbpOverview.Size = New System.Drawing.Size(568, 148)
        Me.gbpOverview.TabIndex = 2
        Me.gbpOverview.TabStop = False
        Me.gbpOverview.Text = "Overview"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(382, 117)
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
        Me.btnDelete.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(475, 117)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 25)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblFileList
        '
        Me.lblFileList.AutoSize = True
        Me.lblFileList.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileList.Location = New System.Drawing.Point(224, 14)
        Me.lblFileList.Name = "lblFileList"
        Me.lblFileList.Size = New System.Drawing.Size(116, 14)
        Me.lblFileList.TabIndex = 9
        Me.lblFileList.Text = "List of Files Added"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("NanumSquare Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(29, 470)
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
        Me.pbxExit.Location = New System.Drawing.Point(605, 3)
        Me.pbxExit.Name = "pbxExit"
        Me.pbxExit.Size = New System.Drawing.Size(20, 20)
        Me.pbxExit.TabIndex = 4
        Me.pbxExit.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 561)
        Me.Controls.Add(Me.pbxExit)
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
End Class

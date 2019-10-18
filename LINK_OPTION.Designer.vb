<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINK_OPTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LINK_OPTION))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbxXSLIB = New System.Windows.Forms.GroupBox()
        Me.lblXSLIB = New System.Windows.Forms.Label()
        Me.cbxXSLIB = New System.Windows.Forms.ComboBox()
        Me.gbxDEPLIB = New System.Windows.Forms.GroupBox()
        Me.lblDEPLIB = New System.Windows.Forms.Label()
        Me.cbxDEPLIB = New System.Windows.Forms.ComboBox()
        Me.gbxDET = New System.Windows.Forms.GroupBox()
        Me.lblDET = New System.Windows.Forms.Label()
        Me.cbxDET = New System.Windows.Forms.ComboBox()
        Me.gbxON = New System.Windows.Forms.GroupBox()
        Me.chkTHE = New System.Windows.Forms.CheckBox()
        Me.lblON = New System.Windows.Forms.Label()
        Me.chkRUP = New System.Windows.Forms.CheckBox()
        Me.chkSTN = New System.Windows.Forms.CheckBox()
        Me.chkHOMADF = New System.Windows.Forms.CheckBox()
        Me.chkRESTART = New System.Windows.Forms.CheckBox()
        Me.gbxCRI = New System.Windows.Forms.GroupBox()
        Me.lblCRI = New System.Windows.Forms.Label()
        Me.cbxCRI = New System.Windows.Forms.ComboBox()
        Me.gbxBRANCH = New System.Windows.Forms.GroupBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.cbxBRANCH = New System.Windows.Forms.ComboBox()
        Me.lblBRANCH = New System.Windows.Forms.Label()
        Me.gbxH2O = New System.Windows.Forms.GroupBox()
        Me.lblBoron = New System.Windows.Forms.Label()
        Me.txtBoron = New System.Windows.Forms.TextBox()
        Me.txtInletTemp = New System.Windows.Forms.TextBox()
        Me.lblInletTemp = New System.Windows.Forms.Label()
        Me.gbxDEP = New System.Windows.Forms.GroupBox()
        Me.lblDEP = New System.Windows.Forms.Label()
        Me.lblBurnup = New System.Windows.Forms.Label()
        Me.txtBurnup = New System.Windows.Forms.TextBox()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxKAPPALIB = New System.Windows.Forms.ComboBox()
        Me.gbxXSLIB.SuspendLayout()
        Me.gbxDEPLIB.SuspendLayout()
        Me.gbxDET.SuspendLayout()
        Me.gbxON.SuspendLayout()
        Me.gbxCRI.SuspendLayout()
        Me.gbxBRANCH.SuspendLayout()
        Me.gbxH2O.SuspendLayout()
        Me.gbxDEP.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(655, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "LINK_OPTION_[Reactor].dat Configurator"
        '
        'gbxXSLIB
        '
        Me.gbxXSLIB.Controls.Add(Me.lblXSLIB)
        Me.gbxXSLIB.Controls.Add(Me.cbxXSLIB)
        Me.gbxXSLIB.Location = New System.Drawing.Point(10, 46)
        Me.gbxXSLIB.Name = "gbxXSLIB"
        Me.gbxXSLIB.Size = New System.Drawing.Size(844, 79)
        Me.gbxXSLIB.TabIndex = 0
        Me.gbxXSLIB.TabStop = False
        Me.gbxXSLIB.Text = "XSLIB Card"
        '
        'lblXSLIB
        '
        Me.lblXSLIB.AutoSize = True
        Me.lblXSLIB.Location = New System.Drawing.Point(5, 37)
        Me.lblXSLIB.Name = "lblXSLIB"
        Me.lblXSLIB.Size = New System.Drawing.Size(332, 29)
        Me.lblXSLIB.TabIndex = 1
        Me.lblXSLIB.Text = "XSLIB (Cross Section Library)"
        '
        'cbxXSLIB
        '
        Me.cbxXSLIB.FormattingEnabled = True
        Me.cbxXSLIB.Location = New System.Drawing.Point(365, 34)
        Me.cbxXSLIB.Name = "cbxXSLIB"
        Me.cbxXSLIB.Size = New System.Drawing.Size(473, 37)
        Me.cbxXSLIB.TabIndex = 0
        '
        'gbxDEPLIB
        '
        Me.gbxDEPLIB.Controls.Add(Me.lblDEPLIB)
        Me.gbxDEPLIB.Controls.Add(Me.cbxDEPLIB)
        Me.gbxDEPLIB.Location = New System.Drawing.Point(10, 130)
        Me.gbxDEPLIB.Name = "gbxDEPLIB"
        Me.gbxDEPLIB.Size = New System.Drawing.Size(844, 79)
        Me.gbxDEPLIB.TabIndex = 1
        Me.gbxDEPLIB.TabStop = False
        Me.gbxDEPLIB.Text = "DEPLIB Card"
        '
        'lblDEPLIB
        '
        Me.lblDEPLIB.AutoSize = True
        Me.lblDEPLIB.Location = New System.Drawing.Point(5, 37)
        Me.lblDEPLIB.Name = "lblDEPLIB"
        Me.lblDEPLIB.Size = New System.Drawing.Size(302, 29)
        Me.lblDEPLIB.TabIndex = 1
        Me.lblDEPLIB.Text = "DEPLIB (Depletion Library)"
        '
        'cbxDEPLIB
        '
        Me.cbxDEPLIB.FormattingEnabled = True
        Me.cbxDEPLIB.Location = New System.Drawing.Point(365, 34)
        Me.cbxDEPLIB.Name = "cbxDEPLIB"
        Me.cbxDEPLIB.Size = New System.Drawing.Size(473, 37)
        Me.cbxDEPLIB.TabIndex = 0
        '
        'gbxDET
        '
        Me.gbxDET.Controls.Add(Me.lblDET)
        Me.gbxDET.Controls.Add(Me.cbxDET)
        Me.gbxDET.Location = New System.Drawing.Point(11, 298)
        Me.gbxDET.Name = "gbxDET"
        Me.gbxDET.Size = New System.Drawing.Size(843, 79)
        Me.gbxDET.TabIndex = 3
        Me.gbxDET.TabStop = False
        Me.gbxDET.Text = "DET Card"
        '
        'lblDET
        '
        Me.lblDET.AutoSize = True
        Me.lblDET.Location = New System.Drawing.Point(5, 37)
        Me.lblDET.Name = "lblDET"
        Me.lblDET.Size = New System.Drawing.Size(62, 29)
        Me.lblDET.TabIndex = 1
        Me.lblDET.Text = "DET"
        '
        'cbxDET
        '
        Me.cbxDET.FormattingEnabled = True
        Me.cbxDET.Location = New System.Drawing.Point(364, 34)
        Me.cbxDET.Name = "cbxDET"
        Me.cbxDET.Size = New System.Drawing.Size(473, 37)
        Me.cbxDET.TabIndex = 0
        '
        'gbxON
        '
        Me.gbxON.Controls.Add(Me.chkTHE)
        Me.gbxON.Controls.Add(Me.lblON)
        Me.gbxON.Controls.Add(Me.chkRUP)
        Me.gbxON.Controls.Add(Me.chkSTN)
        Me.gbxON.Controls.Add(Me.chkHOMADF)
        Me.gbxON.Controls.Add(Me.chkRESTART)
        Me.gbxON.Location = New System.Drawing.Point(11, 383)
        Me.gbxON.Name = "gbxON"
        Me.gbxON.Size = New System.Drawing.Size(843, 79)
        Me.gbxON.TabIndex = 4
        Me.gbxON.TabStop = False
        Me.gbxON.Text = "ON Card"
        '
        'chkTHE
        '
        Me.chkTHE.AutoSize = True
        Me.chkTHE.Location = New System.Drawing.Point(756, 36)
        Me.chkTHE.Name = "chkTHE"
        Me.chkTHE.Size = New System.Drawing.Size(81, 33)
        Me.chkTHE.TabIndex = 4
        Me.chkTHE.Text = "THE"
        Me.chkTHE.UseVisualStyleBackColor = True
        '
        'lblON
        '
        Me.lblON.AutoSize = True
        Me.lblON.Location = New System.Drawing.Point(5, 37)
        Me.lblON.Name = "lblON"
        Me.lblON.Size = New System.Drawing.Size(50, 29)
        Me.lblON.TabIndex = 1
        Me.lblON.Text = "ON"
        '
        'chkRUP
        '
        Me.chkRUP.AutoSize = True
        Me.chkRUP.Location = New System.Drawing.Point(305, 36)
        Me.chkRUP.Name = "chkRUP"
        Me.chkRUP.Size = New System.Drawing.Size(82, 33)
        Me.chkRUP.TabIndex = 0
        Me.chkRUP.Text = "RUP"
        Me.chkRUP.UseVisualStyleBackColor = True
        '
        'chkSTN
        '
        Me.chkSTN.AutoSize = True
        Me.chkSTN.Location = New System.Drawing.Point(674, 36)
        Me.chkSTN.Name = "chkSTN"
        Me.chkSTN.Size = New System.Drawing.Size(82, 33)
        Me.chkSTN.TabIndex = 3
        Me.chkSTN.Text = "STN"
        Me.chkSTN.UseVisualStyleBackColor = True
        '
        'chkHOMADF
        '
        Me.chkHOMADF.AutoSize = True
        Me.chkHOMADF.Location = New System.Drawing.Point(390, 36)
        Me.chkHOMADF.Name = "chkHOMADF"
        Me.chkHOMADF.Size = New System.Drawing.Size(135, 33)
        Me.chkHOMADF.TabIndex = 1
        Me.chkHOMADF.Text = "HOMADF"
        Me.chkHOMADF.UseVisualStyleBackColor = True
        '
        'chkRESTART
        '
        Me.chkRESTART.AutoSize = True
        Me.chkRESTART.Location = New System.Drawing.Point(528, 36)
        Me.chkRESTART.Name = "chkRESTART"
        Me.chkRESTART.Size = New System.Drawing.Size(145, 33)
        Me.chkRESTART.TabIndex = 2
        Me.chkRESTART.Text = "RESTART"
        Me.chkRESTART.UseVisualStyleBackColor = True
        '
        'gbxCRI
        '
        Me.gbxCRI.Controls.Add(Me.lblCRI)
        Me.gbxCRI.Controls.Add(Me.cbxCRI)
        Me.gbxCRI.Location = New System.Drawing.Point(11, 467)
        Me.gbxCRI.Name = "gbxCRI"
        Me.gbxCRI.Size = New System.Drawing.Size(843, 79)
        Me.gbxCRI.TabIndex = 5
        Me.gbxCRI.TabStop = False
        Me.gbxCRI.Text = "CRI Card"
        '
        'lblCRI
        '
        Me.lblCRI.AutoSize = True
        Me.lblCRI.Location = New System.Drawing.Point(5, 37)
        Me.lblCRI.Name = "lblCRI"
        Me.lblCRI.Size = New System.Drawing.Size(53, 29)
        Me.lblCRI.TabIndex = 1
        Me.lblCRI.Text = "CRI"
        '
        'cbxCRI
        '
        Me.cbxCRI.FormattingEnabled = True
        Me.cbxCRI.Location = New System.Drawing.Point(364, 34)
        Me.cbxCRI.Name = "cbxCRI"
        Me.cbxCRI.Size = New System.Drawing.Size(473, 37)
        Me.cbxCRI.TabIndex = 0
        '
        'gbxBRANCH
        '
        Me.gbxBRANCH.Controls.Add(Me.btnHelp)
        Me.gbxBRANCH.Controls.Add(Me.cbxBRANCH)
        Me.gbxBRANCH.Controls.Add(Me.lblBRANCH)
        Me.gbxBRANCH.Location = New System.Drawing.Point(11, 553)
        Me.gbxBRANCH.Name = "gbxBRANCH"
        Me.gbxBRANCH.Size = New System.Drawing.Size(843, 79)
        Me.gbxBRANCH.TabIndex = 6
        Me.gbxBRANCH.TabStop = False
        Me.gbxBRANCH.Text = "BRANCH Card"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(800, 33)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(37, 37)
        Me.btnHelp.TabIndex = 1
        Me.btnHelp.Text = "&?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'cbxBRANCH
        '
        Me.cbxBRANCH.FormattingEnabled = True
        Me.cbxBRANCH.Location = New System.Drawing.Point(363, 34)
        Me.cbxBRANCH.Name = "cbxBRANCH"
        Me.cbxBRANCH.Size = New System.Drawing.Size(431, 37)
        Me.cbxBRANCH.TabIndex = 0
        '
        'lblBRANCH
        '
        Me.lblBRANCH.AutoSize = True
        Me.lblBRANCH.Location = New System.Drawing.Point(5, 37)
        Me.lblBRANCH.Name = "lblBRANCH"
        Me.lblBRANCH.Size = New System.Drawing.Size(335, 29)
        Me.lblBRANCH.TabIndex = 1
        Me.lblBRANCH.Text = "BRANCH (Branch Calculation)"
        '
        'gbxH2O
        '
        Me.gbxH2O.Controls.Add(Me.lblBoron)
        Me.gbxH2O.Controls.Add(Me.txtBoron)
        Me.gbxH2O.Controls.Add(Me.txtInletTemp)
        Me.gbxH2O.Controls.Add(Me.lblInletTemp)
        Me.gbxH2O.Location = New System.Drawing.Point(11, 637)
        Me.gbxH2O.Name = "gbxH2O"
        Me.gbxH2O.Size = New System.Drawing.Size(843, 121)
        Me.gbxH2O.TabIndex = 7
        Me.gbxH2O.TabStop = False
        Me.gbxH2O.Text = "H2O Card"
        '
        'lblBoron
        '
        Me.lblBoron.AutoSize = True
        Me.lblBoron.Location = New System.Drawing.Point(6, 79)
        Me.lblBoron.Name = "lblBoron"
        Me.lblBoron.Size = New System.Drawing.Size(303, 29)
        Me.lblBoron.TabIndex = 4
        Me.lblBoron.Text = "Boron Concentration (ppm)"
        '
        'txtBoron
        '
        Me.txtBoron.Location = New System.Drawing.Point(364, 76)
        Me.txtBoron.Name = "txtBoron"
        Me.txtBoron.Size = New System.Drawing.Size(473, 35)
        Me.txtBoron.TabIndex = 1
        '
        'txtInletTemp
        '
        Me.txtInletTemp.Location = New System.Drawing.Point(364, 34)
        Me.txtInletTemp.Name = "txtInletTemp"
        Me.txtInletTemp.Size = New System.Drawing.Size(473, 35)
        Me.txtInletTemp.TabIndex = 0
        '
        'lblInletTemp
        '
        Me.lblInletTemp.AutoSize = True
        Me.lblInletTemp.Location = New System.Drawing.Point(5, 37)
        Me.lblInletTemp.Name = "lblInletTemp"
        Me.lblInletTemp.Size = New System.Drawing.Size(359, 29)
        Me.lblInletTemp.TabIndex = 1
        Me.lblInletTemp.Text = "Moderator Inlet Temperature (K)"
        '
        'gbxDEP
        '
        Me.gbxDEP.Controls.Add(Me.lblDEP)
        Me.gbxDEP.Controls.Add(Me.lblBurnup)
        Me.gbxDEP.Controls.Add(Me.txtBurnup)
        Me.gbxDEP.Controls.Add(Me.txtPower)
        Me.gbxDEP.Controls.Add(Me.lblPower)
        Me.gbxDEP.Location = New System.Drawing.Point(11, 763)
        Me.gbxDEP.Name = "gbxDEP"
        Me.gbxDEP.Size = New System.Drawing.Size(843, 149)
        Me.gbxDEP.TabIndex = 8
        Me.gbxDEP.TabStop = False
        Me.gbxDEP.Text = "DEP Card"
        '
        'lblDEP
        '
        Me.lblDEP.AutoSize = True
        Me.lblDEP.Location = New System.Drawing.Point(6, 32)
        Me.lblDEP.Name = "lblDEP"
        Me.lblDEP.Size = New System.Drawing.Size(332, 29)
        Me.lblDEP.TabIndex = 5
        Me.lblDEP.Text = "Depletion Calculation Options"
        '
        'lblBurnup
        '
        Me.lblBurnup.AutoSize = True
        Me.lblBurnup.Location = New System.Drawing.Point(6, 105)
        Me.lblBurnup.Name = "lblBurnup"
        Me.lblBurnup.Size = New System.Drawing.Size(297, 29)
        Me.lblBurnup.TabIndex = 4
        Me.lblBurnup.Text = "Final Burnup (MWd/kgHM)"
        '
        'txtBurnup
        '
        Me.txtBurnup.Location = New System.Drawing.Point(364, 102)
        Me.txtBurnup.Name = "txtBurnup"
        Me.txtBurnup.Size = New System.Drawing.Size(473, 35)
        Me.txtBurnup.TabIndex = 1
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(364, 61)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(473, 35)
        Me.txtPower.TabIndex = 0
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Location = New System.Drawing.Point(5, 64)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(270, 29)
        Me.lblPower.TabIndex = 1
        Me.lblPower.Text = "Power Density (W/gHM)"
        '
        'btnReset
        '
        Me.btnReset.FlatAppearance.BorderSize = 2
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(10, 918)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(206, 69)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(222, 918)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(255, 69)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close without Saving"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(482, 918)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(372, 69)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbxKAPPALIB)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 79)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KAPPALIB Card"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KAPPALIB (Kappa Library)"
        '
        'cbxKAPPALIB
        '
        Me.cbxKAPPALIB.FormattingEnabled = True
        Me.cbxKAPPALIB.Location = New System.Drawing.Point(365, 34)
        Me.cbxKAPPALIB.Name = "cbxKAPPALIB"
        Me.cbxKAPPALIB.Size = New System.Drawing.Size(473, 37)
        Me.cbxKAPPALIB.TabIndex = 0
        '
        'LINK_OPTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(866, 993)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbxDEP)
        Me.Controls.Add(Me.gbxH2O)
        Me.Controls.Add(Me.gbxBRANCH)
        Me.Controls.Add(Me.gbxCRI)
        Me.Controls.Add(Me.gbxON)
        Me.Controls.Add(Me.gbxDET)
        Me.Controls.Add(Me.gbxDEPLIB)
        Me.Controls.Add(Me.gbxXSLIB)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.Name = "LINK_OPTION"
        Me.Text = "LINK_OPTION"
        Me.gbxXSLIB.ResumeLayout(False)
        Me.gbxXSLIB.PerformLayout()
        Me.gbxDEPLIB.ResumeLayout(False)
        Me.gbxDEPLIB.PerformLayout()
        Me.gbxDET.ResumeLayout(False)
        Me.gbxDET.PerformLayout()
        Me.gbxON.ResumeLayout(False)
        Me.gbxON.PerformLayout()
        Me.gbxCRI.ResumeLayout(False)
        Me.gbxCRI.PerformLayout()
        Me.gbxBRANCH.ResumeLayout(False)
        Me.gbxBRANCH.PerformLayout()
        Me.gbxH2O.ResumeLayout(False)
        Me.gbxH2O.PerformLayout()
        Me.gbxDEP.ResumeLayout(False)
        Me.gbxDEP.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbxXSLIB As GroupBox
    Friend WithEvents lblXSLIB As Label
    Friend WithEvents cbxXSLIB As ComboBox
    Friend WithEvents gbxDEPLIB As GroupBox
    Friend WithEvents lblDEPLIB As Label
    Friend WithEvents cbxDEPLIB As ComboBox
    Friend WithEvents gbxDET As GroupBox
    Friend WithEvents lblDET As Label
    Friend WithEvents cbxDET As ComboBox
    Friend WithEvents gbxON As GroupBox
    Friend WithEvents lblON As Label
    Friend WithEvents chkTHE As CheckBox
    Friend WithEvents chkRUP As CheckBox
    Friend WithEvents chkSTN As CheckBox
    Friend WithEvents chkHOMADF As CheckBox
    Friend WithEvents chkRESTART As CheckBox
    Friend WithEvents gbxCRI As GroupBox
    Friend WithEvents lblCRI As Label
    Friend WithEvents cbxCRI As ComboBox
    Friend WithEvents gbxBRANCH As GroupBox
    Friend WithEvents lblBRANCH As Label
    Friend WithEvents cbxBRANCH As ComboBox
    Friend WithEvents gbxH2O As GroupBox
    Friend WithEvents lblBoron As Label
    Friend WithEvents txtBoron As TextBox
    Friend WithEvents txtInletTemp As TextBox
    Friend WithEvents lblInletTemp As Label
    Friend WithEvents gbxDEP As GroupBox
    Friend WithEvents lblBurnup As Label
    Friend WithEvents txtBurnup As TextBox
    Friend WithEvents txtPower As TextBox
    Friend WithEvents lblPower As Label
    Friend WithEvents lblDEP As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxKAPPALIB As ComboBox
End Class

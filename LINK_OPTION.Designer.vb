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
        Me.gbxXSLIB = New System.Windows.Forms.GroupBox()
        Me.cbxXSLIB = New System.Windows.Forms.ComboBox()
        Me.lblXSLIB = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbxDEPLIB = New System.Windows.Forms.GroupBox()
        Me.cbxDEPLIB = New System.Windows.Forms.ComboBox()
        Me.lblDEPLIB = New System.Windows.Forms.Label()
        Me.gbxKAPPALIB = New System.Windows.Forms.GroupBox()
        Me.cbxKAPPALIB = New System.Windows.Forms.ComboBox()
        Me.lblKAPPALIB = New System.Windows.Forms.Label()
        Me.gbxDET = New System.Windows.Forms.GroupBox()
        Me.cbxDET = New System.Windows.Forms.ComboBox()
        Me.lblDET = New System.Windows.Forms.Label()
        Me.gbxON = New System.Windows.Forms.GroupBox()
        Me.lblONcf = New System.Windows.Forms.Label()
        Me.chkTHE = New System.Windows.Forms.CheckBox()
        Me.chkSTN = New System.Windows.Forms.CheckBox()
        Me.chkRESTART = New System.Windows.Forms.CheckBox()
        Me.chkHOMADF = New System.Windows.Forms.CheckBox()
        Me.chkRUP = New System.Windows.Forms.CheckBox()
        Me.lblON = New System.Windows.Forms.Label()
        Me.gbxCRI = New System.Windows.Forms.GroupBox()
        Me.cbxCRI = New System.Windows.Forms.ComboBox()
        Me.lblCRI = New System.Windows.Forms.Label()
        Me.gbxBRANCH = New System.Windows.Forms.GroupBox()
        Me.btnBRANCHHelp = New System.Windows.Forms.Button()
        Me.cbxBRANCH = New System.Windows.Forms.ComboBox()
        Me.lblBRANCH = New System.Windows.Forms.Label()
        Me.gbxH2O = New System.Windows.Forms.GroupBox()
        Me.txtH2OBoron = New System.Windows.Forms.TextBox()
        Me.lblH2OBoron = New System.Windows.Forms.Label()
        Me.txtH2OTemp = New System.Windows.Forms.TextBox()
        Me.lblH2OTemp = New System.Windows.Forms.Label()
        Me.gbxDEP = New System.Windows.Forms.GroupBox()
        Me.lblDEP = New System.Windows.Forms.Label()
        Me.txtDEPBurnup = New System.Windows.Forms.TextBox()
        Me.lblDEPBurnup = New System.Windows.Forms.Label()
        Me.txtDEPPower = New System.Windows.Forms.TextBox()
        Me.lblDEPPower = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pbxExit = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.gbxXSLIB.SuspendLayout()
        Me.gbxDEPLIB.SuspendLayout()
        Me.gbxKAPPALIB.SuspendLayout()
        Me.gbxDET.SuspendLayout()
        Me.gbxON.SuspendLayout()
        Me.gbxCRI.SuspendLayout()
        Me.gbxBRANCH.SuspendLayout()
        Me.gbxH2O.SuspendLayout()
        Me.gbxDEP.SuspendLayout()
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxXSLIB
        '
        Me.gbxXSLIB.Controls.Add(Me.cbxXSLIB)
        Me.gbxXSLIB.Controls.Add(Me.lblXSLIB)
        Me.gbxXSLIB.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxXSLIB.Location = New System.Drawing.Point(17, 64)
        Me.gbxXSLIB.Name = "gbxXSLIB"
        Me.gbxXSLIB.Size = New System.Drawing.Size(466, 58)
        Me.gbxXSLIB.TabIndex = 0
        Me.gbxXSLIB.TabStop = False
        Me.gbxXSLIB.Text = "XSLIB Card"
        '
        'cbxXSLIB
        '
        Me.cbxXSLIB.FormattingEnabled = True
        Me.cbxXSLIB.Location = New System.Drawing.Point(180, 20)
        Me.cbxXSLIB.Name = "cbxXSLIB"
        Me.cbxXSLIB.Size = New System.Drawing.Size(280, 20)
        Me.cbxXSLIB.TabIndex = 0
        '
        'lblXSLIB
        '
        Me.lblXSLIB.AutoSize = True
        Me.lblXSLIB.Location = New System.Drawing.Point(6, 23)
        Me.lblXSLIB.Name = "lblXSLIB"
        Me.lblXSLIB.Size = New System.Drawing.Size(157, 12)
        Me.lblXSLIB.TabIndex = 0
        Me.lblXSLIB.Text = "XSLIB (Cross Section Library)"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(471, 25)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "LINK_OPTION_[Reactor Core].dat Configurator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbxDEPLIB
        '
        Me.gbxDEPLIB.Controls.Add(Me.cbxDEPLIB)
        Me.gbxDEPLIB.Controls.Add(Me.lblDEPLIB)
        Me.gbxDEPLIB.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDEPLIB.Location = New System.Drawing.Point(17, 128)
        Me.gbxDEPLIB.Name = "gbxDEPLIB"
        Me.gbxDEPLIB.Size = New System.Drawing.Size(466, 58)
        Me.gbxDEPLIB.TabIndex = 1
        Me.gbxDEPLIB.TabStop = False
        Me.gbxDEPLIB.Text = "DEPLIB Card"
        '
        'cbxDEPLIB
        '
        Me.cbxDEPLIB.FormattingEnabled = True
        Me.cbxDEPLIB.Location = New System.Drawing.Point(180, 20)
        Me.cbxDEPLIB.Name = "cbxDEPLIB"
        Me.cbxDEPLIB.Size = New System.Drawing.Size(280, 20)
        Me.cbxDEPLIB.TabIndex = 0
        '
        'lblDEPLIB
        '
        Me.lblDEPLIB.AutoSize = True
        Me.lblDEPLIB.Location = New System.Drawing.Point(6, 23)
        Me.lblDEPLIB.Name = "lblDEPLIB"
        Me.lblDEPLIB.Size = New System.Drawing.Size(145, 12)
        Me.lblDEPLIB.TabIndex = 0
        Me.lblDEPLIB.Text = "DEPLIB (Depletion Library)"
        '
        'gbxKAPPALIB
        '
        Me.gbxKAPPALIB.Controls.Add(Me.cbxKAPPALIB)
        Me.gbxKAPPALIB.Controls.Add(Me.lblKAPPALIB)
        Me.gbxKAPPALIB.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxKAPPALIB.Location = New System.Drawing.Point(17, 192)
        Me.gbxKAPPALIB.Name = "gbxKAPPALIB"
        Me.gbxKAPPALIB.Size = New System.Drawing.Size(466, 58)
        Me.gbxKAPPALIB.TabIndex = 2
        Me.gbxKAPPALIB.TabStop = False
        Me.gbxKAPPALIB.Text = "KAPPALIB Card"
        '
        'cbxKAPPALIB
        '
        Me.cbxKAPPALIB.FormattingEnabled = True
        Me.cbxKAPPALIB.Location = New System.Drawing.Point(180, 20)
        Me.cbxKAPPALIB.Name = "cbxKAPPALIB"
        Me.cbxKAPPALIB.Size = New System.Drawing.Size(280, 20)
        Me.cbxKAPPALIB.TabIndex = 0
        '
        'lblKAPPALIB
        '
        Me.lblKAPPALIB.AutoSize = True
        Me.lblKAPPALIB.Location = New System.Drawing.Point(6, 23)
        Me.lblKAPPALIB.Name = "lblKAPPALIB"
        Me.lblKAPPALIB.Size = New System.Drawing.Size(141, 12)
        Me.lblKAPPALIB.TabIndex = 0
        Me.lblKAPPALIB.Text = "KAPPALIB (Kappa Library)"
        '
        'gbxDET
        '
        Me.gbxDET.Controls.Add(Me.cbxDET)
        Me.gbxDET.Controls.Add(Me.lblDET)
        Me.gbxDET.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDET.Location = New System.Drawing.Point(17, 256)
        Me.gbxDET.Name = "gbxDET"
        Me.gbxDET.Size = New System.Drawing.Size(466, 58)
        Me.gbxDET.TabIndex = 3
        Me.gbxDET.TabStop = False
        Me.gbxDET.Text = "DET Card"
        '
        'cbxDET
        '
        Me.cbxDET.FormattingEnabled = True
        Me.cbxDET.Location = New System.Drawing.Point(180, 20)
        Me.cbxDET.Name = "cbxDET"
        Me.cbxDET.Size = New System.Drawing.Size(280, 20)
        Me.cbxDET.TabIndex = 0
        '
        'lblDET
        '
        Me.lblDET.AutoSize = True
        Me.lblDET.Location = New System.Drawing.Point(6, 23)
        Me.lblDET.Name = "lblDET"
        Me.lblDET.Size = New System.Drawing.Size(26, 12)
        Me.lblDET.TabIndex = 0
        Me.lblDET.Text = "DET"
        '
        'gbxON
        '
        Me.gbxON.Controls.Add(Me.lblONcf)
        Me.gbxON.Controls.Add(Me.chkTHE)
        Me.gbxON.Controls.Add(Me.chkSTN)
        Me.gbxON.Controls.Add(Me.chkRESTART)
        Me.gbxON.Controls.Add(Me.chkHOMADF)
        Me.gbxON.Controls.Add(Me.chkRUP)
        Me.gbxON.Controls.Add(Me.lblON)
        Me.gbxON.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxON.Location = New System.Drawing.Point(17, 320)
        Me.gbxON.Name = "gbxON"
        Me.gbxON.Size = New System.Drawing.Size(466, 100)
        Me.gbxON.TabIndex = 4
        Me.gbxON.TabStop = False
        Me.gbxON.Text = "ON Card"
        '
        'lblONcf
        '
        Me.lblONcf.AutoSize = True
        Me.lblONcf.Location = New System.Drawing.Point(6, 49)
        Me.lblONcf.Name = "lblONcf"
        Me.lblONcf.Size = New System.Drawing.Size(405, 36)
        Me.lblONcf.TabIndex = 13
        Me.lblONcf.Text = "RESTART: restart calculation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "STN: creation of STN file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE: geometry and materi" &
    "al density change according to given temperature"
        '
        'chkTHE
        '
        Me.chkTHE.AutoSize = True
        Me.chkTHE.Location = New System.Drawing.Point(410, 22)
        Me.chkTHE.Name = "chkTHE"
        Me.chkTHE.Size = New System.Drawing.Size(45, 16)
        Me.chkTHE.TabIndex = 4
        Me.chkTHE.Text = "THE"
        Me.chkTHE.UseVisualStyleBackColor = True
        '
        'chkSTN
        '
        Me.chkSTN.AutoSize = True
        Me.chkSTN.Location = New System.Drawing.Point(355, 22)
        Me.chkSTN.Name = "chkSTN"
        Me.chkSTN.Size = New System.Drawing.Size(45, 16)
        Me.chkSTN.TabIndex = 3
        Me.chkSTN.Text = "STN"
        Me.chkSTN.UseVisualStyleBackColor = True
        '
        'chkRESTART
        '
        Me.chkRESTART.AutoSize = True
        Me.chkRESTART.Location = New System.Drawing.Point(271, 22)
        Me.chkRESTART.Name = "chkRESTART"
        Me.chkRESTART.Size = New System.Drawing.Size(71, 16)
        Me.chkRESTART.TabIndex = 2
        Me.chkRESTART.Text = "RESTART"
        Me.chkRESTART.UseVisualStyleBackColor = True
        '
        'chkHOMADF
        '
        Me.chkHOMADF.AutoSize = True
        Me.chkHOMADF.Location = New System.Drawing.Point(184, 22)
        Me.chkHOMADF.Name = "chkHOMADF"
        Me.chkHOMADF.Size = New System.Drawing.Size(70, 16)
        Me.chkHOMADF.TabIndex = 1
        Me.chkHOMADF.Text = "HOMADF"
        Me.chkHOMADF.UseVisualStyleBackColor = True
        '
        'chkRUP
        '
        Me.chkRUP.AutoSize = True
        Me.chkRUP.Location = New System.Drawing.Point(128, 22)
        Me.chkRUP.Name = "chkRUP"
        Me.chkRUP.Size = New System.Drawing.Size(46, 16)
        Me.chkRUP.TabIndex = 0
        Me.chkRUP.Text = "RUP"
        Me.chkRUP.UseVisualStyleBackColor = True
        '
        'lblON
        '
        Me.lblON.AutoSize = True
        Me.lblON.Location = New System.Drawing.Point(6, 23)
        Me.lblON.Name = "lblON"
        Me.lblON.Size = New System.Drawing.Size(21, 12)
        Me.lblON.TabIndex = 0
        Me.lblON.Text = "ON"
        '
        'gbxCRI
        '
        Me.gbxCRI.Controls.Add(Me.cbxCRI)
        Me.gbxCRI.Controls.Add(Me.lblCRI)
        Me.gbxCRI.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCRI.Location = New System.Drawing.Point(489, 64)
        Me.gbxCRI.Name = "gbxCRI"
        Me.gbxCRI.Size = New System.Drawing.Size(466, 58)
        Me.gbxCRI.TabIndex = 5
        Me.gbxCRI.TabStop = False
        Me.gbxCRI.Text = "CRI Card"
        '
        'cbxCRI
        '
        Me.cbxCRI.FormattingEnabled = True
        Me.cbxCRI.Location = New System.Drawing.Point(180, 20)
        Me.cbxCRI.Name = "cbxCRI"
        Me.cbxCRI.Size = New System.Drawing.Size(280, 20)
        Me.cbxCRI.TabIndex = 0
        '
        'lblCRI
        '
        Me.lblCRI.AutoSize = True
        Me.lblCRI.Location = New System.Drawing.Point(6, 23)
        Me.lblCRI.Name = "lblCRI"
        Me.lblCRI.Size = New System.Drawing.Size(22, 12)
        Me.lblCRI.TabIndex = 0
        Me.lblCRI.Text = "CRI"
        '
        'gbxBRANCH
        '
        Me.gbxBRANCH.Controls.Add(Me.btnBRANCHHelp)
        Me.gbxBRANCH.Controls.Add(Me.cbxBRANCH)
        Me.gbxBRANCH.Controls.Add(Me.lblBRANCH)
        Me.gbxBRANCH.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBRANCH.Location = New System.Drawing.Point(489, 128)
        Me.gbxBRANCH.Name = "gbxBRANCH"
        Me.gbxBRANCH.Size = New System.Drawing.Size(466, 58)
        Me.gbxBRANCH.TabIndex = 6
        Me.gbxBRANCH.TabStop = False
        Me.gbxBRANCH.Text = "BRANCH Card"
        '
        'btnBRANCHHelp
        '
        Me.btnBRANCHHelp.Location = New System.Drawing.Point(438, 20)
        Me.btnBRANCHHelp.Name = "btnBRANCHHelp"
        Me.btnBRANCHHelp.Size = New System.Drawing.Size(22, 23)
        Me.btnBRANCHHelp.TabIndex = 0
        Me.btnBRANCHHelp.TabStop = False
        Me.btnBRANCHHelp.Text = "&?"
        Me.btnBRANCHHelp.UseVisualStyleBackColor = True
        '
        'cbxBRANCH
        '
        Me.cbxBRANCH.FormattingEnabled = True
        Me.cbxBRANCH.Location = New System.Drawing.Point(180, 20)
        Me.cbxBRANCH.Name = "cbxBRANCH"
        Me.cbxBRANCH.Size = New System.Drawing.Size(252, 20)
        Me.cbxBRANCH.TabIndex = 0
        '
        'lblBRANCH
        '
        Me.lblBRANCH.AutoSize = True
        Me.lblBRANCH.Location = New System.Drawing.Point(6, 23)
        Me.lblBRANCH.Name = "lblBRANCH"
        Me.lblBRANCH.Size = New System.Drawing.Size(159, 12)
        Me.lblBRANCH.TabIndex = 0
        Me.lblBRANCH.Text = "BRANCH (Branch Calculation)"
        '
        'gbxH2O
        '
        Me.gbxH2O.Controls.Add(Me.txtH2OBoron)
        Me.gbxH2O.Controls.Add(Me.lblH2OBoron)
        Me.gbxH2O.Controls.Add(Me.txtH2OTemp)
        Me.gbxH2O.Controls.Add(Me.lblH2OTemp)
        Me.gbxH2O.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxH2O.Location = New System.Drawing.Point(489, 192)
        Me.gbxH2O.Name = "gbxH2O"
        Me.gbxH2O.Size = New System.Drawing.Size(466, 85)
        Me.gbxH2O.TabIndex = 7
        Me.gbxH2O.TabStop = False
        Me.gbxH2O.Text = "H2O Card"
        '
        'txtH2OBoron
        '
        Me.txtH2OBoron.Location = New System.Drawing.Point(180, 47)
        Me.txtH2OBoron.Name = "txtH2OBoron"
        Me.txtH2OBoron.Size = New System.Drawing.Size(280, 20)
        Me.txtH2OBoron.TabIndex = 1
        '
        'lblH2OBoron
        '
        Me.lblH2OBoron.AutoSize = True
        Me.lblH2OBoron.Location = New System.Drawing.Point(6, 50)
        Me.lblH2OBoron.Name = "lblH2OBoron"
        Me.lblH2OBoron.Size = New System.Drawing.Size(148, 12)
        Me.lblH2OBoron.TabIndex = 2
        Me.lblH2OBoron.Text = "Boron Concentration (ppm)"
        '
        'txtH2OTemp
        '
        Me.txtH2OTemp.Location = New System.Drawing.Point(180, 20)
        Me.txtH2OTemp.Name = "txtH2OTemp"
        Me.txtH2OTemp.Size = New System.Drawing.Size(280, 20)
        Me.txtH2OTemp.TabIndex = 0
        '
        'lblH2OTemp
        '
        Me.lblH2OTemp.AutoSize = True
        Me.lblH2OTemp.Location = New System.Drawing.Point(6, 23)
        Me.lblH2OTemp.Name = "lblH2OTemp"
        Me.lblH2OTemp.Size = New System.Drawing.Size(174, 12)
        Me.lblH2OTemp.TabIndex = 0
        Me.lblH2OTemp.Text = "Moderator Inlet Temperature (K)"
        '
        'gbxDEP
        '
        Me.gbxDEP.Controls.Add(Me.lblDEP)
        Me.gbxDEP.Controls.Add(Me.txtDEPBurnup)
        Me.gbxDEP.Controls.Add(Me.lblDEPBurnup)
        Me.gbxDEP.Controls.Add(Me.txtDEPPower)
        Me.gbxDEP.Controls.Add(Me.lblDEPPower)
        Me.gbxDEP.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDEP.Location = New System.Drawing.Point(489, 283)
        Me.gbxDEP.Name = "gbxDEP"
        Me.gbxDEP.Size = New System.Drawing.Size(466, 97)
        Me.gbxDEP.TabIndex = 8
        Me.gbxDEP.TabStop = False
        Me.gbxDEP.Text = "DEP Card"
        '
        'lblDEP
        '
        Me.lblDEP.AutoSize = True
        Me.lblDEP.Location = New System.Drawing.Point(6, 17)
        Me.lblDEP.Name = "lblDEP"
        Me.lblDEP.Size = New System.Drawing.Size(159, 12)
        Me.lblDEP.TabIndex = 4
        Me.lblDEP.Text = "Depletion Calculation Options"
        '
        'txtDEPBurnup
        '
        Me.txtDEPBurnup.Location = New System.Drawing.Point(180, 64)
        Me.txtDEPBurnup.Name = "txtDEPBurnup"
        Me.txtDEPBurnup.Size = New System.Drawing.Size(280, 20)
        Me.txtDEPBurnup.TabIndex = 1
        '
        'lblDEPBurnup
        '
        Me.lblDEPBurnup.AutoSize = True
        Me.lblDEPBurnup.Location = New System.Drawing.Point(6, 67)
        Me.lblDEPBurnup.Name = "lblDEPBurnup"
        Me.lblDEPBurnup.Size = New System.Drawing.Size(146, 12)
        Me.lblDEPBurnup.TabIndex = 2
        Me.lblDEPBurnup.Text = "Final Burnup (MWd/kgHM)"
        '
        'txtDEPPower
        '
        Me.txtDEPPower.Location = New System.Drawing.Point(180, 37)
        Me.txtDEPPower.Name = "txtDEPPower"
        Me.txtDEPPower.Size = New System.Drawing.Size(280, 20)
        Me.txtDEPPower.TabIndex = 0
        '
        'lblDEPPower
        '
        Me.lblDEPPower.AutoSize = True
        Me.lblDEPPower.Location = New System.Drawing.Point(6, 40)
        Me.lblDEPPower.Name = "lblDEPPower"
        Me.lblDEPPower.Size = New System.Drawing.Size(130, 12)
        Me.lblDEPPower.TabIndex = 0
        Me.lblDEPPower.Text = "Power Density (W/gHM)"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(489, 386)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(99, 34)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(727, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(228, 34)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("NanumSquare Bold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(594, 386)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(127, 34)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close without Saving"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pbxExit
        '
        Me.pbxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxExit.Image = Global.Project_Joshua.My.Resources.Resources._exit
        Me.pbxExit.InitialImage = Nothing
        Me.pbxExit.Location = New System.Drawing.Point(956, 0)
        Me.pbxExit.Name = "pbxExit"
        Me.pbxExit.Size = New System.Drawing.Size(20, 20)
        Me.pbxExit.TabIndex = 5
        Me.pbxExit.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.pbxExit)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(976, 20)
        Me.pnlTop.TabIndex = 12
        '
        'LINK_OPTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 433)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.gbxDEP)
        Me.Controls.Add(Me.gbxH2O)
        Me.Controls.Add(Me.gbxBRANCH)
        Me.Controls.Add(Me.gbxCRI)
        Me.Controls.Add(Me.gbxON)
        Me.Controls.Add(Me.gbxDET)
        Me.Controls.Add(Me.gbxKAPPALIB)
        Me.Controls.Add(Me.gbxDEPLIB)
        Me.Controls.Add(Me.gbxXSLIB)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LINK_OPTION"
        Me.Text = "Configure LINK_OPTION_[Reactor Code].dat"
        Me.gbxXSLIB.ResumeLayout(False)
        Me.gbxXSLIB.PerformLayout()
        Me.gbxDEPLIB.ResumeLayout(False)
        Me.gbxDEPLIB.PerformLayout()
        Me.gbxKAPPALIB.ResumeLayout(False)
        Me.gbxKAPPALIB.PerformLayout()
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
        CType(Me.pbxExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxXSLIB As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cbxXSLIB As ComboBox
    Friend WithEvents lblXSLIB As Label
    Friend WithEvents gbxDEPLIB As GroupBox
    Friend WithEvents cbxDEPLIB As ComboBox
    Friend WithEvents lblDEPLIB As Label
    Friend WithEvents gbxKAPPALIB As GroupBox
    Friend WithEvents cbxKAPPALIB As ComboBox
    Friend WithEvents lblKAPPALIB As Label
    Friend WithEvents gbxDET As GroupBox
    Friend WithEvents cbxDET As ComboBox
    Friend WithEvents lblDET As Label
    Friend WithEvents gbxON As GroupBox
    Friend WithEvents chkTHE As CheckBox
    Friend WithEvents chkSTN As CheckBox
    Friend WithEvents chkRESTART As CheckBox
    Friend WithEvents chkHOMADF As CheckBox
    Friend WithEvents chkRUP As CheckBox
    Friend WithEvents lblON As Label
    Friend WithEvents lblONcf As Label
    Friend WithEvents gbxCRI As GroupBox
    Friend WithEvents cbxCRI As ComboBox
    Friend WithEvents lblCRI As Label
    Friend WithEvents gbxBRANCH As GroupBox
    Friend WithEvents cbxBRANCH As ComboBox
    Friend WithEvents lblBRANCH As Label
    Friend WithEvents gbxH2O As GroupBox
    Friend WithEvents txtH2OBoron As TextBox
    Friend WithEvents txtH2OTemp As TextBox
    Friend WithEvents lblH2OTemp As Label
    Friend WithEvents gbxDEP As GroupBox
    Friend WithEvents lblDEP As Label
    Friend WithEvents txtDEPBurnup As TextBox
    Friend WithEvents lblDEPBurnup As Label
    Friend WithEvents txtDEPPower As TextBox
    Friend WithEvents lblDEPPower As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblH2OBoron As Label
    Friend WithEvents btnBRANCHHelp As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents pbxExit As PictureBox
    Friend WithEvents pnlTop As Panel
End Class

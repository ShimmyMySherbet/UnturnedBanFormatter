<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI))
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.cb_Cheat = New System.Windows.Forms.CheckBox()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.cb_StaffDis = New System.Windows.Forms.CheckBox()
        Me.cb_GlitchedBase = New System.Windows.Forms.CheckBox()
        Me.cb_glitch = New System.Windows.Forms.CheckBox()
        Me.cb_racism = New System.Windows.Forms.CheckBox()
        Me.cb_LoadAbuse = New System.Windows.Forms.CheckBox()
        Me.cb_advert = New System.Windows.Forms.CheckBox()
        Me.cb_CheatAssisted = New System.Windows.Forms.CheckBox()
        Me.cb_alt = New System.Windows.Forms.CheckBox()
        Me.cb_Greif = New System.Windows.Forms.CheckBox()
        Me.cb_minge = New System.Windows.Forms.CheckBox()
        Me.cb_AtemptServerCrash = New System.Windows.Forms.CheckBox()
        Me.cb_ServerCrash = New System.Windows.Forms.CheckBox()
        Me.cb_staffimpers = New System.Windows.Forms.CheckBox()
        Me.cb_staffevade = New System.Windows.Forms.CheckBox()
        Me.cb_ignoringstaff = New System.Windows.Forms.CheckBox()
        Me.cb_fearrp = New System.Windows.Forms.CheckBox()
        Me.cb_falserp = New System.Windows.Forms.CheckBox()
        Me.cb_nointent = New System.Windows.Forms.CheckBox()
        Me.cb_FalseRaid = New System.Windows.Forms.CheckBox()
        Me.cb_kos = New System.Windows.Forms.CheckBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.cbReadRules = New System.Windows.Forms.CheckBox()
        Me.cbChangeName = New System.Windows.Forms.CheckBox()
        Me.lblBanDuration = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtCommandOut = New System.Windows.Forms.TextBox()
        Me.lblOutCMD = New System.Windows.Forms.Label()
        Me.txtOtherReason = New System.Windows.Forms.TextBox()
        Me.lblOtherReason = New System.Windows.Forms.Label()
        Me.pbCopyCmd = New System.Windows.Forms.PictureBox()
        Me.pbSett = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.pbCopyCmd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSett, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPlayer
        '
        Me.txtPlayer.Location = New System.Drawing.Point(12, 30)
        Me.txtPlayer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(268, 26)
        Me.txtPlayer.TabIndex = 0
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(12, 9)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(56, 20)
        Me.lblPlayer.TabIndex = 1
        Me.lblPlayer.Text = "Player:"
        '
        'cb_Cheat
        '
        Me.cb_Cheat.AutoSize = True
        Me.cb_Cheat.Location = New System.Drawing.Point(16, 84)
        Me.cb_Cheat.Name = "cb_Cheat"
        Me.cb_Cheat.Size = New System.Drawing.Size(154, 24)
        Me.cb_Cheat.TabIndex = 2
        Me.cb_Cheat.Text = "Hacking/Cheating"
        Me.cb_Cheat.UseVisualStyleBackColor = True
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Location = New System.Drawing.Point(12, 61)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(69, 20)
        Me.lblReason.TabIndex = 3
        Me.lblReason.Text = "Reason:"
        '
        'cb_StaffDis
        '
        Me.cb_StaffDis.AutoSize = True
        Me.cb_StaffDis.Location = New System.Drawing.Point(16, 114)
        Me.cb_StaffDis.Name = "cb_StaffDis"
        Me.cb_StaffDis.Size = New System.Drawing.Size(143, 24)
        Me.cb_StaffDis.TabIndex = 4
        Me.cb_StaffDis.Text = "Staff Disrespect"
        Me.cb_StaffDis.UseVisualStyleBackColor = True
        '
        'cb_GlitchedBase
        '
        Me.cb_GlitchedBase.AutoSize = True
        Me.cb_GlitchedBase.Location = New System.Drawing.Point(16, 144)
        Me.cb_GlitchedBase.Name = "cb_GlitchedBase"
        Me.cb_GlitchedBase.Size = New System.Drawing.Size(128, 24)
        Me.cb_GlitchedBase.TabIndex = 5
        Me.cb_GlitchedBase.Text = "Glitched Base"
        Me.cb_GlitchedBase.UseVisualStyleBackColor = True
        '
        'cb_glitch
        '
        Me.cb_glitch.AutoSize = True
        Me.cb_glitch.Location = New System.Drawing.Point(16, 174)
        Me.cb_glitch.Name = "cb_glitch"
        Me.cb_glitch.Size = New System.Drawing.Size(144, 24)
        Me.cb_glitch.TabIndex = 6
        Me.cb_glitch.Text = "Glitching (Other)"
        Me.cb_glitch.UseVisualStyleBackColor = True
        '
        'cb_racism
        '
        Me.cb_racism.AutoSize = True
        Me.cb_racism.Location = New System.Drawing.Point(176, 174)
        Me.cb_racism.Name = "cb_racism"
        Me.cb_racism.Size = New System.Drawing.Size(81, 24)
        Me.cb_racism.TabIndex = 7
        Me.cb_racism.Text = "Racism"
        Me.cb_racism.UseVisualStyleBackColor = True
        '
        'cb_LoadAbuse
        '
        Me.cb_LoadAbuse.AutoSize = True
        Me.cb_LoadAbuse.Location = New System.Drawing.Point(176, 114)
        Me.cb_LoadAbuse.Name = "cb_LoadAbuse"
        Me.cb_LoadAbuse.Size = New System.Drawing.Size(114, 24)
        Me.cb_LoadAbuse.TabIndex = 8
        Me.cb_LoadAbuse.Text = "Load Abuse"
        Me.cb_LoadAbuse.UseVisualStyleBackColor = True
        '
        'cb_advert
        '
        Me.cb_advert.AutoSize = True
        Me.cb_advert.Location = New System.Drawing.Point(176, 144)
        Me.cb_advert.Name = "cb_advert"
        Me.cb_advert.Size = New System.Drawing.Size(106, 24)
        Me.cb_advert.TabIndex = 9
        Me.cb_advert.Text = "Advertising"
        Me.cb_advert.UseVisualStyleBackColor = True
        '
        'cb_CheatAssisted
        '
        Me.cb_CheatAssisted.AutoSize = True
        Me.cb_CheatAssisted.Location = New System.Drawing.Point(308, 84)
        Me.cb_CheatAssisted.Name = "cb_CheatAssisted"
        Me.cb_CheatAssisted.Size = New System.Drawing.Size(150, 24)
        Me.cb_CheatAssisted.TabIndex = 10
        Me.cb_CheatAssisted.Text = "Cheater Assisted"
        Me.cb_CheatAssisted.UseVisualStyleBackColor = True
        '
        'cb_alt
        '
        Me.cb_alt.AutoSize = True
        Me.cb_alt.Location = New System.Drawing.Point(16, 204)
        Me.cb_alt.Name = "cb_alt"
        Me.cb_alt.Size = New System.Drawing.Size(110, 24)
        Me.cb_alt.TabIndex = 11
        Me.cb_alt.Text = "Alt Account"
        Me.cb_alt.UseVisualStyleBackColor = True
        '
        'cb_Greif
        '
        Me.cb_Greif.AutoSize = True
        Me.cb_Greif.Location = New System.Drawing.Point(176, 84)
        Me.cb_Greif.Name = "cb_Greif"
        Me.cb_Greif.Size = New System.Drawing.Size(84, 24)
        Me.cb_Greif.TabIndex = 99
        Me.cb_Greif.Text = "Greifing"
        Me.cb_Greif.UseVisualStyleBackColor = True
        '
        'cb_minge
        '
        Me.cb_minge.AutoSize = True
        Me.cb_minge.Location = New System.Drawing.Point(176, 204)
        Me.cb_minge.Name = "cb_minge"
        Me.cb_minge.Size = New System.Drawing.Size(71, 24)
        Me.cb_minge.TabIndex = 13
        Me.cb_minge.Text = "Minge"
        Me.cb_minge.UseVisualStyleBackColor = True
        '
        'cb_AtemptServerCrash
        '
        Me.cb_AtemptServerCrash.AutoSize = True
        Me.cb_AtemptServerCrash.Location = New System.Drawing.Point(308, 114)
        Me.cb_AtemptServerCrash.Name = "cb_AtemptServerCrash"
        Me.cb_AtemptServerCrash.Size = New System.Drawing.Size(199, 24)
        Me.cb_AtemptServerCrash.TabIndex = 14
        Me.cb_AtemptServerCrash.Text = "Attempted Server Crash"
        Me.cb_AtemptServerCrash.UseVisualStyleBackColor = True
        '
        'cb_ServerCrash
        '
        Me.cb_ServerCrash.AutoSize = True
        Me.cb_ServerCrash.Location = New System.Drawing.Point(308, 144)
        Me.cb_ServerCrash.Name = "cb_ServerCrash"
        Me.cb_ServerCrash.Size = New System.Drawing.Size(141, 24)
        Me.cb_ServerCrash.TabIndex = 15
        Me.cb_ServerCrash.Text = "Crashing Server"
        Me.cb_ServerCrash.UseVisualStyleBackColor = True
        '
        'cb_staffimpers
        '
        Me.cb_staffimpers.AutoSize = True
        Me.cb_staffimpers.Location = New System.Drawing.Point(308, 174)
        Me.cb_staffimpers.Name = "cb_staffimpers"
        Me.cb_staffimpers.Size = New System.Drawing.Size(169, 24)
        Me.cb_staffimpers.TabIndex = 16
        Me.cb_staffimpers.Text = "Staff Impersonation"
        Me.cb_staffimpers.UseVisualStyleBackColor = True
        '
        'cb_staffevade
        '
        Me.cb_staffevade.AutoSize = True
        Me.cb_staffevade.Location = New System.Drawing.Point(16, 234)
        Me.cb_staffevade.Name = "cb_staffevade"
        Me.cb_staffevade.Size = New System.Drawing.Size(123, 24)
        Me.cb_staffevade.TabIndex = 17
        Me.cb_staffevade.Text = "Staff Evasion"
        Me.cb_staffevade.UseVisualStyleBackColor = True
        '
        'cb_ignoringstaff
        '
        Me.cb_ignoringstaff.AutoSize = True
        Me.cb_ignoringstaff.Location = New System.Drawing.Point(308, 204)
        Me.cb_ignoringstaff.Name = "cb_ignoringstaff"
        Me.cb_ignoringstaff.Size = New System.Drawing.Size(204, 24)
        Me.cb_ignoringstaff.TabIndex = 18
        Me.cb_ignoringstaff.Text = "Ignoring Staff Instruction"
        Me.cb_ignoringstaff.UseVisualStyleBackColor = True
        '
        'cb_fearrp
        '
        Me.cb_fearrp.AutoSize = True
        Me.cb_fearrp.Location = New System.Drawing.Point(176, 234)
        Me.cb_fearrp.Name = "cb_fearrp"
        Me.cb_fearrp.Size = New System.Drawing.Size(87, 24)
        Me.cb_fearrp.TabIndex = 19
        Me.cb_fearrp.Text = "Fear RP"
        Me.cb_fearrp.UseVisualStyleBackColor = True
        '
        'cb_falserp
        '
        Me.cb_falserp.AutoSize = True
        Me.cb_falserp.Location = New System.Drawing.Point(308, 234)
        Me.cb_falserp.Name = "cb_falserp"
        Me.cb_falserp.Size = New System.Drawing.Size(93, 24)
        Me.cb_falserp.TabIndex = 20
        Me.cb_falserp.Text = "False RP"
        Me.cb_falserp.UseVisualStyleBackColor = True
        '
        'cb_nointent
        '
        Me.cb_nointent.AutoSize = True
        Me.cb_nointent.Location = New System.Drawing.Point(16, 264)
        Me.cb_nointent.Name = "cb_nointent"
        Me.cb_nointent.Size = New System.Drawing.Size(94, 24)
        Me.cb_nointent.TabIndex = 21
        Me.cb_nointent.Text = "No Intent"
        Me.cb_nointent.UseVisualStyleBackColor = True
        '
        'cb_FalseRaid
        '
        Me.cb_FalseRaid.AutoSize = True
        Me.cb_FalseRaid.Location = New System.Drawing.Point(176, 264)
        Me.cb_FalseRaid.Name = "cb_FalseRaid"
        Me.cb_FalseRaid.Size = New System.Drawing.Size(104, 24)
        Me.cb_FalseRaid.TabIndex = 22
        Me.cb_FalseRaid.Text = "False Raid"
        Me.cb_FalseRaid.UseVisualStyleBackColor = True
        '
        'cb_kos
        '
        Me.cb_kos.AutoSize = True
        Me.cb_kos.Location = New System.Drawing.Point(308, 265)
        Me.cb_kos.Name = "cb_kos"
        Me.cb_kos.Size = New System.Drawing.Size(61, 24)
        Me.cb_kos.TabIndex = 23
        Me.cb_kos.Text = "KOS"
        Me.cb_kos.UseVisualStyleBackColor = True
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(16, 295)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(55, 20)
        Me.lblNotes.TabIndex = 24
        Me.lblNotes.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(16, 319)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(231, 26)
        Me.txtNotes.TabIndex = 25
        '
        'cbReadRules
        '
        Me.cbReadRules.AutoSize = True
        Me.cbReadRules.Location = New System.Drawing.Point(16, 351)
        Me.cbReadRules.Name = "cbReadRules"
        Me.cbReadRules.Size = New System.Drawing.Size(112, 24)
        Me.cbReadRules.TabIndex = 26
        Me.cbReadRules.Text = "Read Rules"
        Me.cbReadRules.UseVisualStyleBackColor = True
        '
        'cbChangeName
        '
        Me.cbChangeName.AutoSize = True
        Me.cbChangeName.Location = New System.Drawing.Point(129, 351)
        Me.cbChangeName.Name = "cbChangeName"
        Me.cbChangeName.Size = New System.Drawing.Size(130, 24)
        Me.cbChangeName.TabIndex = 27
        Me.cbChangeName.Text = "Change Name"
        Me.cbChangeName.UseVisualStyleBackColor = True
        '
        'lblBanDuration
        '
        Me.lblBanDuration.AutoSize = True
        Me.lblBanDuration.Location = New System.Drawing.Point(304, 6)
        Me.lblBanDuration.Name = "lblBanDuration"
        Me.lblBanDuration.Size = New System.Drawing.Size(107, 20)
        Me.lblBanDuration.TabIndex = 28
        Me.lblBanDuration.Text = "Ban Duration:"
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(308, 30)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(115, 26)
        Me.txtDuration.TabIndex = 1
        '
        'txtCommandOut
        '
        Me.txtCommandOut.Location = New System.Drawing.Point(16, 405)
        Me.txtCommandOut.Name = "txtCommandOut"
        Me.txtCommandOut.Size = New System.Drawing.Size(491, 26)
        Me.txtCommandOut.TabIndex = 30
        '
        'lblOutCMD
        '
        Me.lblOutCMD.AutoSize = True
        Me.lblOutCMD.Location = New System.Drawing.Point(16, 382)
        Me.lblOutCMD.Name = "lblOutCMD"
        Me.lblOutCMD.Size = New System.Drawing.Size(86, 20)
        Me.lblOutCMD.TabIndex = 31
        Me.lblOutCMD.Text = "Command:"
        '
        'txtOtherReason
        '
        Me.txtOtherReason.Location = New System.Drawing.Point(267, 319)
        Me.txtOtherReason.Name = "txtOtherReason"
        Me.txtOtherReason.Size = New System.Drawing.Size(240, 26)
        Me.txtOtherReason.TabIndex = 101
        '
        'lblOtherReason
        '
        Me.lblOtherReason.AutoSize = True
        Me.lblOtherReason.Location = New System.Drawing.Point(262, 295)
        Me.lblOtherReason.Name = "lblOtherReason"
        Me.lblOtherReason.Size = New System.Drawing.Size(113, 20)
        Me.lblOtherReason.TabIndex = 100
        Me.lblOtherReason.Text = "Other Reason:"
        '
        'pbCopyCmd
        '
        Me.pbCopyCmd.Image = Global.BanManager.My.Resources.Icons.paste
        Me.pbCopyCmd.Location = New System.Drawing.Point(485, 407)
        Me.pbCopyCmd.Name = "pbCopyCmd"
        Me.pbCopyCmd.Size = New System.Drawing.Size(21, 23)
        Me.pbCopyCmd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCopyCmd.TabIndex = 32
        Me.pbCopyCmd.TabStop = False
        '
        'pbSett
        '
        Me.pbSett.Image = Global.BanManager.My.Resources.Icons.settings
        Me.pbSett.Location = New System.Drawing.Point(485, 6)
        Me.pbSett.Name = "pbSett"
        Me.pbSett.Size = New System.Drawing.Size(27, 23)
        Me.pbSett.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSett.TabIndex = 102
        Me.pbSett.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(20, 437)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 24)
        Me.btnReset.TabIndex = 103
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 473)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.pbSett)
        Me.Controls.Add(Me.txtOtherReason)
        Me.Controls.Add(Me.lblOtherReason)
        Me.Controls.Add(Me.pbCopyCmd)
        Me.Controls.Add(Me.lblOutCMD)
        Me.Controls.Add(Me.txtCommandOut)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.lblBanDuration)
        Me.Controls.Add(Me.cbChangeName)
        Me.Controls.Add(Me.cbReadRules)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.cb_kos)
        Me.Controls.Add(Me.cb_FalseRaid)
        Me.Controls.Add(Me.cb_nointent)
        Me.Controls.Add(Me.cb_falserp)
        Me.Controls.Add(Me.cb_fearrp)
        Me.Controls.Add(Me.cb_ignoringstaff)
        Me.Controls.Add(Me.cb_staffevade)
        Me.Controls.Add(Me.cb_staffimpers)
        Me.Controls.Add(Me.cb_ServerCrash)
        Me.Controls.Add(Me.cb_AtemptServerCrash)
        Me.Controls.Add(Me.cb_minge)
        Me.Controls.Add(Me.cb_Greif)
        Me.Controls.Add(Me.cb_alt)
        Me.Controls.Add(Me.cb_CheatAssisted)
        Me.Controls.Add(Me.cb_advert)
        Me.Controls.Add(Me.cb_LoadAbuse)
        Me.Controls.Add(Me.cb_racism)
        Me.Controls.Add(Me.cb_glitch)
        Me.Controls.Add(Me.cb_GlitchedBase)
        Me.Controls.Add(Me.cb_StaffDis)
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.cb_Cheat)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.txtPlayer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UI"
        Me.Text = "UI"
        CType(Me.pbCopyCmd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSett, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPlayer As TextBox
    Friend WithEvents lblPlayer As Label
    Friend WithEvents cb_Cheat As CheckBox
    Friend WithEvents lblReason As Label
    Friend WithEvents cb_StaffDis As CheckBox
    Friend WithEvents cb_GlitchedBase As CheckBox
    Friend WithEvents cb_glitch As CheckBox
    Friend WithEvents cb_racism As CheckBox
    Friend WithEvents cb_LoadAbuse As CheckBox
    Friend WithEvents cb_advert As CheckBox
    Friend WithEvents cb_CheatAssisted As CheckBox
    Friend WithEvents cb_alt As CheckBox
    Friend WithEvents cb_Greif As CheckBox
    Friend WithEvents cb_minge As CheckBox
    Friend WithEvents cb_AtemptServerCrash As CheckBox
    Friend WithEvents cb_ServerCrash As CheckBox
    Friend WithEvents cb_staffimpers As CheckBox
    Friend WithEvents cb_staffevade As CheckBox
    Friend WithEvents cb_ignoringstaff As CheckBox
    Friend WithEvents cb_fearrp As CheckBox
    Friend WithEvents cb_falserp As CheckBox
    Friend WithEvents cb_nointent As CheckBox
    Friend WithEvents cb_FalseRaid As CheckBox
    Friend WithEvents cb_kos As CheckBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents cbReadRules As CheckBox
    Friend WithEvents cbChangeName As CheckBox
    Friend WithEvents lblBanDuration As Label
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents txtCommandOut As TextBox
    Friend WithEvents lblOutCMD As Label
    Friend WithEvents pbCopyCmd As PictureBox
    Friend WithEvents txtOtherReason As TextBox
    Friend WithEvents lblOtherReason As Label
    Friend WithEvents pbSett As PictureBox
    Friend WithEvents btnReset As Button
End Class

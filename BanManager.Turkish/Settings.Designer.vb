<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRDlim = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNdelim = New System.Windows.Forms.TextBox()
        Me.btnSaveNClose = New System.Windows.Forms.Button()
        Me.cbOnTop = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(13, 31)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(191, 26)
        Me.txtname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kullanıcı adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sebep Ayırıcı:"
        '
        'txtRDlim
        '
        Me.txtRDlim.Location = New System.Drawing.Point(13, 87)
        Me.txtRDlim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRDlim.Name = "txtRDlim"
        Me.txtRDlim.Size = New System.Drawing.Size(191, 26)
        Me.txtRDlim.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Not Ayırıcı:"
        '
        'txtNdelim
        '
        Me.txtNdelim.Location = New System.Drawing.Point(13, 143)
        Me.txtNdelim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNdelim.Name = "txtNdelim"
        Me.txtNdelim.Size = New System.Drawing.Size(191, 26)
        Me.txtNdelim.TabIndex = 4
        '
        'btnSaveNClose
        '
        Me.btnSaveNClose.Location = New System.Drawing.Point(13, 207)
        Me.btnSaveNClose.Name = "btnSaveNClose"
        Me.btnSaveNClose.Size = New System.Drawing.Size(191, 30)
        Me.btnSaveNClose.TabIndex = 6
        Me.btnSaveNClose.Text = "Kaydet ve kapat"
        Me.btnSaveNClose.UseVisualStyleBackColor = True
        '
        'cbOnTop
        '
        Me.cbOnTop.AutoSize = True
        Me.cbOnTop.Location = New System.Drawing.Point(17, 177)
        Me.cbOnTop.Name = "cbOnTop"
        Me.cbOnTop.Size = New System.Drawing.Size(146, 24)
        Me.cbOnTop.TabIndex = 7
        Me.cbOnTop.Text = "Her zaman üstte"
        Me.cbOnTop.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbOnTop)
        Me.Controls.Add(Me.btnSaveNClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNdelim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRDlim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Settings"
        Me.Text = "Ayarlar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRDlim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNdelim As TextBox
    Friend WithEvents btnSaveNClose As Button
    Friend WithEvents cbOnTop As CheckBox
End Class

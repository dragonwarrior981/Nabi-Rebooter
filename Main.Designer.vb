<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.timerCursor = New System.Windows.Forms.Timer(Me.components)
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblPhoneConnect = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timerPhone = New System.Windows.Forms.Timer(Me.components)
        Me.btnGo = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBody
        '
        Me.txtBody.BackColor = System.Drawing.Color.Gray
        Me.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBody.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtBody.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBody.ForeColor = System.Drawing.Color.Lime
        Me.txtBody.Location = New System.Drawing.Point(95, 77)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ReadOnly = True
        Me.txtBody.Size = New System.Drawing.Size(318, 195)
        Me.txtBody.TabIndex = 3
        Me.txtBody.TabStop = False
        Me.txtBody.Text = "Nabi Jr" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">_"
        '
        'timerCursor
        '
        Me.timerCursor.Interval = 500
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPhoneConnect})
        Me.statusStrip.Location = New System.Drawing.Point(0, 347)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(513, 22)
        Me.statusStrip.SizingGrip = False
        Me.statusStrip.TabIndex = 5
        '
        'lblPhoneConnect
        '
        Me.lblPhoneConnect.BackColor = System.Drawing.SystemColors.Control
        Me.lblPhoneConnect.Name = "lblPhoneConnect"
        Me.lblPhoneConnect.Size = New System.Drawing.Size(0, 17)
        '
        'timerPhone
        '
        Me.timerPhone.Interval = 1000
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(169, 216)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(168, 45)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Reboot Nabi"
        Me.btnGo.UseVisualStyleBackColor = True
        Me.btnGo.Visible = False
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(513, 24)
        Me.MenuStrip.TabIndex = 7
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenuItem.Name = "FileMenuItem"
        Me.FileMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nabi_Rebooter.My.Resources.Resources.Nabi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(513, 369)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.txtBody)
        Me.Name = "Main"
        Me.Text = "Nabi Rebooter"
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtBody As System.Windows.Forms.TextBox
    Private WithEvents timerCursor As System.Windows.Forms.Timer
    Private WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Private WithEvents lblPhoneConnect As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents timerPhone As System.Windows.Forms.Timer
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

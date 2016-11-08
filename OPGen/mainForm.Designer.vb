<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.btGenerate = New System.Windows.Forms.Button()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.cpUsername = New System.Windows.Forms.Button()
        Me.cpPassword = New System.Windows.Forms.Button()
        Me.pbLoading = New System.Windows.Forms.PictureBox()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btGenerate
        '
        Me.btGenerate.Location = New System.Drawing.Point(377, 58)
        Me.btGenerate.Name = "btGenerate"
        Me.btGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btGenerate.TabIndex = 0
        Me.btGenerate.Text = "Generate"
        Me.btGenerate.UseVisualStyleBackColor = True
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.White
        Me.tbUsername.Location = New System.Drawing.Point(73, 6)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.ReadOnly = True
        Me.tbUsername.Size = New System.Drawing.Size(323, 20)
        Me.tbUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.White
        Me.tbPassword.Location = New System.Drawing.Point(73, 32)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.ReadOnly = True
        Me.tbPassword.Size = New System.Drawing.Size(323, 20)
        Me.tbPassword.TabIndex = 3
        '
        'cpUsername
        '
        Me.cpUsername.Location = New System.Drawing.Point(402, 4)
        Me.cpUsername.Name = "cpUsername"
        Me.cpUsername.Size = New System.Drawing.Size(50, 23)
        Me.cpUsername.TabIndex = 5
        Me.cpUsername.Text = "Copy"
        Me.cpUsername.UseVisualStyleBackColor = True
        '
        'cpPassword
        '
        Me.cpPassword.Location = New System.Drawing.Point(402, 30)
        Me.cpPassword.Name = "cpPassword"
        Me.cpPassword.Size = New System.Drawing.Size(50, 23)
        Me.cpPassword.TabIndex = 6
        Me.cpPassword.Text = "Copy"
        Me.cpPassword.UseVisualStyleBackColor = True
        '
        'pbLoading
        '
        Me.pbLoading.BackColor = System.Drawing.Color.White
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbLoading.Image = Global.OPGen.My.Resources.Resources.ring
        Me.pbLoading.Location = New System.Drawing.Point(200, 2)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(80, 80)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoading.TabIndex = 7
        Me.pbLoading.TabStop = False
        Me.pbLoading.Visible = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 86)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.cpPassword)
        Me.Controls.Add(Me.cpUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.btGenerate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainForm"
        Me.Text = "Opera Proxy Credential Generator"
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btGenerate As Button
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents cpUsername As Button
    Friend WithEvents cpPassword As Button
    Friend WithEvents pbLoading As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiseaseCombat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiseaseCombat))
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnActivity = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(12, 36)
        Me.btnProfile.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(100, 39)
        Me.btnProfile.TabIndex = 0
        Me.btnProfile.Text = "Create Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(117, 40)
        Me.txtDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(447, 255)
        Me.txtDisplay.TabIndex = 4
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 91)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(100, 39)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display Profile"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnActivity
        '
        Me.btnActivity.Location = New System.Drawing.Point(12, 201)
        Me.btnActivity.Name = "btnActivity"
        Me.btnActivity.Size = New System.Drawing.Size(100, 39)
        Me.btnActivity.TabIndex = 7
        Me.btnActivity.Text = "Disease"
        Me.btnActivity.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(12, 146)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(100, 39)
        Me.btnWrite.TabIndex = 8
        Me.btnWrite.Text = "Wrte File"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(12, 256)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(100, 39)
        Me.btnRead.TabIndex = 9
        Me.btnRead.Text = "Read File"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'frmDiseaseCombat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(730, 321)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnActivity)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnProfile)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDiseaseCombat"
        Me.Text = "Disease Combat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProfile As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnActivity As Button
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
End Class

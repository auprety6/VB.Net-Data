<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AUForm1
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
        Me.AULabel1 = New System.Windows.Forms.Label()
        Me.AUTextBox1 = New System.Windows.Forms.TextBox()
        Me.AUButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AULabel1
        '
        Me.AULabel1.AutoSize = True
        Me.AULabel1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.AULabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AULabel1.Location = New System.Drawing.Point(12, 273)
        Me.AULabel1.Name = "AULabel1"
        Me.AULabel1.Size = New System.Drawing.Size(213, 24)
        Me.AULabel1.TabIndex = 0
        Me.AULabel1.Text = "Enter Department Name"
        '
        'AUTextBox1
        '
        Me.AUTextBox1.Location = New System.Drawing.Point(243, 273)
        Me.AUTextBox1.Name = "AUTextBox1"
        Me.AUTextBox1.Size = New System.Drawing.Size(138, 24)
        Me.AUTextBox1.TabIndex = 1
        '
        'AUButton1
        '
        Me.AUButton1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.AUButton1.Location = New System.Drawing.Point(387, 271)
        Me.AUButton1.Name = "AUButton1"
        Me.AUButton1.Size = New System.Drawing.Size(186, 26)
        Me.AUButton1.TabIndex = 2
        Me.AUButton1.Text = "Find Jobs"
        Me.AUButton1.UseVisualStyleBackColor = False
        '
        'AUForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(615, 623)
        Me.Controls.Add(Me.AUButton1)
        Me.Controls.Add(Me.AUTextBox1)
        Me.Controls.Add(Me.AULabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AUForm1"
        Me.Text = "JobFinder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AULabel1 As Label
    Friend WithEvents AUTextBox1 As TextBox
    Friend WithEvents AUButton1 As Button
End Class

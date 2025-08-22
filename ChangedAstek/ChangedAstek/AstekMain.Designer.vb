<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AstekMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AstekMain))
        Me.ACTb01 = New System.Windows.Forms.TextBox()
        Me.ACTb02 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ACBtn01 = New Glass.GlassButton()
        Me.ACGrid01 = New System.Windows.Forms.DataGridView()
        Me.ACBtn02 = New Glass.GlassButton()
        CType(Me.ACGrid01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ACTb01
        '
        Me.ACTb01.Location = New System.Drawing.Point(90, 35)
        Me.ACTb01.Name = "ACTb01"
        Me.ACTb01.Size = New System.Drawing.Size(268, 20)
        Me.ACTb01.TabIndex = 0
        '
        'ACTb02
        '
        Me.ACTb02.Location = New System.Drawing.Point(90, 61)
        Me.ACTb02.Name = "ACTb02"
        Me.ACTb02.Size = New System.Drawing.Size(268, 20)
        Me.ACTb02.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Old Astek"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Astek"
        '
        'ACBtn01
        '
        Me.ACBtn01.BackColor = System.Drawing.Color.Gainsboro
        Me.ACBtn01.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACBtn01.ForeColor = System.Drawing.Color.Black
        Me.ACBtn01.GlowColor = System.Drawing.Color.LightSkyBlue
        Me.ACBtn01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ACBtn01.Location = New System.Drawing.Point(433, 33)
        Me.ACBtn01.Name = "ACBtn01"
        Me.ACBtn01.Size = New System.Drawing.Size(116, 22)
        Me.ACBtn01.TabIndex = 147
        Me.ACBtn01.Text = "Search"
        '
        'ACGrid01
        '
        Me.ACGrid01.AllowUserToAddRows = False
        Me.ACGrid01.AllowUserToDeleteRows = False
        Me.ACGrid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ACGrid01.Location = New System.Drawing.Point(5, 87)
        Me.ACGrid01.Name = "ACGrid01"
        Me.ACGrid01.ReadOnly = True
        Me.ACGrid01.Size = New System.Drawing.Size(544, 561)
        Me.ACGrid01.TabIndex = 148
        '
        'ACBtn02
        '
        Me.ACBtn02.BackColor = System.Drawing.Color.Gainsboro
        Me.ACBtn02.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACBtn02.ForeColor = System.Drawing.Color.Black
        Me.ACBtn02.GlowColor = System.Drawing.Color.LightSkyBlue
        Me.ACBtn02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ACBtn02.Location = New System.Drawing.Point(433, 56)
        Me.ACBtn02.Name = "ACBtn02"
        Me.ACBtn02.Size = New System.Drawing.Size(116, 22)
        Me.ACBtn02.TabIndex = 149
        Me.ACBtn02.Text = "Process"
        '
        'AstekMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 652)
        Me.Controls.Add(Me.ACBtn02)
        Me.Controls.Add(Me.ACGrid01)
        Me.Controls.Add(Me.ACBtn01)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ACTb02)
        Me.Controls.Add(Me.ACTb01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AstekMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Astek Change"
        CType(Me.ACGrid01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ACTb01 As System.Windows.Forms.TextBox
    Friend WithEvents ACTb02 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ACBtn01 As Glass.GlassButton
    Friend WithEvents ACGrid01 As System.Windows.Forms.DataGridView
    Friend WithEvents ACBtn02 As Glass.GlassButton

End Class

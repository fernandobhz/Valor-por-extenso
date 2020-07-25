<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConverter = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtextenso = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConverter
        '
        Me.btnConverter.Location = New System.Drawing.Point(338, 89)
        Me.btnConverter.Name = "btnConverter"
        Me.btnConverter.Size = New System.Drawing.Size(75, 23)
        Me.btnConverter.TabIndex = 0
        Me.btnConverter.Text = "Button1"
        Me.btnConverter.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(65, 89)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(232, 20)
        Me.txtValor.TabIndex = 1
        '
        'txtextenso
        '
        Me.txtextenso.Location = New System.Drawing.Point(65, 127)
        Me.txtextenso.Multiline = True
        Me.txtextenso.Name = "txtextenso"
        Me.txtextenso.Size = New System.Drawing.Size(232, 97)
        Me.txtextenso.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(402, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 343)
        Me.Controls.Add(Me.txtextenso)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnConverter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConverter As System.Windows.Forms.Button
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtextenso As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

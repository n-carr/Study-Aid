<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.txtPrompts = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswers = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtPrompts
        '
        Me.txtPrompts.Location = New System.Drawing.Point(12, 25)
        Me.txtPrompts.Name = "txtPrompts"
        Me.txtPrompts.Size = New System.Drawing.Size(223, 280)
        Me.txtPrompts.TabIndex = 0
        Me.txtPrompts.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtPrompts, "A ^^ denotes a new line in a single question.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Questions:"
        '
        'txtAnswers
        '
        Me.txtAnswers.Location = New System.Drawing.Point(372, 25)
        Me.txtAnswers.Name = "txtAnswers"
        Me.txtAnswers.Size = New System.Drawing.Size(223, 280)
        Me.txtAnswers.TabIndex = 1
        Me.txtAnswers.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtAnswers, "A ^^ denotes a new line in a single answer.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Answers:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(241, 25)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(125, 41)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Quiz"
        Me.ToolTip1.SetToolTip(Me.btnStart, "Start the quiz using the questions and answers you manually entered.")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(241, 72)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(125, 41)
        Me.btnFile.TabIndex = 3
        Me.btnFile.Text = "Start from File"
        Me.ToolTip1.SetToolTip(Me.btnFile, "Start the quiz using an already-created quiz file. See the README for more detail" & _
        "s on this process.")
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 317)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnswers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrompts)
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrompts As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswers As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnFile As System.Windows.Forms.Button
End Class

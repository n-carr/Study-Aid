<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAskWrong = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtPrompts
        '
        Me.txtPrompts.Location = New System.Drawing.Point(12, 25)
        Me.txtPrompts.Name = "txtPrompts"
        Me.txtPrompts.Size = New System.Drawing.Size(223, 280)
        Me.txtPrompts.TabIndex = 0
        Me.txtPrompts.Text = ""
        Me.ToolTip.SetToolTip(Me.txtPrompts, "A ^^ denotes a new line in a single question.")
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
        Me.txtAnswers.Location = New System.Drawing.Point(386, 25)
        Me.txtAnswers.Name = "txtAnswers"
        Me.txtAnswers.Size = New System.Drawing.Size(223, 280)
        Me.txtAnswers.TabIndex = 1
        Me.txtAnswers.Text = ""
        Me.ToolTip.SetToolTip(Me.txtAnswers, "A ^^ denotes a new line in a single answer.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Answers:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(241, 25)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(139, 41)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Quiz"
        Me.ToolTip.SetToolTip(Me.btnStart, "Start the quiz using the questions and answers you manually entered.")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'chkAskWrong
        '
        Me.chkAskWrong.Location = New System.Drawing.Point(241, 72)
        Me.chkAskWrong.Name = "chkAskWrong"
        Me.chkAskWrong.Size = New System.Drawing.Size(139, 18)
        Me.chkAskWrong.TabIndex = 6
        Me.chkAskWrong.Text = "Retest failed questions"
        Me.chkAskWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.chkAskWrong, "If checked, questions that have been previously answered incorrectly will be aske" & _
        "d in the next quiz.")
        Me.chkAskWrong.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 317)
        Me.Controls.Add(Me.chkAskWrong)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnswers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrompts)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrompts As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswers As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents chkAskWrong As System.Windows.Forms.CheckBox
End Class

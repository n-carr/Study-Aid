<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
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
        Me.txtMain = New System.Windows.Forms.RichTextBox()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnCont = New System.Windows.Forms.Button()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMain.Location = New System.Drawing.Point(12, 12)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ReadOnly = True
        Me.txtMain.Size = New System.Drawing.Size(482, 230)
        Me.txtMain.TabIndex = 3
        Me.txtMain.Text = ""
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(12, 270)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(158, 37)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(336, 270)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(158, 37)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnCont
        '
        Me.btnCont.Location = New System.Drawing.Point(176, 270)
        Me.btnCont.Name = "btnCont"
        Me.btnCont.Size = New System.Drawing.Size(154, 37)
        Me.btnCont.TabIndex = 0
        Me.btnCont.Text = "Show Answer"
        Me.btnCont.UseVisualStyleBackColor = True
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(9, 245)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(169, 20)
        Me.lblRemaining.TabIndex = 4
        Me.lblRemaining.Text = "Questions Remaining: "
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 319)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.btnCont)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.txtMain)
        Me.Name = "frmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMain As System.Windows.Forms.RichTextBox
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnCont As System.Windows.Forms.Button
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
End Class

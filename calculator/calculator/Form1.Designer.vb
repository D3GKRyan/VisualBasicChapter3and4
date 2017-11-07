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
        Me.lblNumberOne = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblNumberTwo = New System.Windows.Forms.Label()
        Me.lblnull = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtNumberOne = New System.Windows.Forms.TextBox()
        Me.txtNumberTwo = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnExponent = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumberOne
        '
        Me.lblNumberOne.AutoSize = True
        Me.lblNumberOne.Location = New System.Drawing.Point(77, 77)
        Me.lblNumberOne.Name = "lblNumberOne"
        Me.lblNumberOne.Size = New System.Drawing.Size(56, 13)
        Me.lblNumberOne.TabIndex = 0
        Me.lblNumberOne.Text = "Number 1:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(77, 108)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(56, 13)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Operation:"
        '
        'lblNumberTwo
        '
        Me.lblNumberTwo.AutoSize = True
        Me.lblNumberTwo.Location = New System.Drawing.Point(77, 211)
        Me.lblNumberTwo.Name = "lblNumberTwo"
        Me.lblNumberTwo.Size = New System.Drawing.Size(56, 13)
        Me.lblNumberTwo.TabIndex = 2
        Me.lblNumberTwo.Text = "Number 2:"
        '
        'lblnull
        '
        Me.lblnull.AutoSize = True
        Me.lblnull.Location = New System.Drawing.Point(93, 244)
        Me.lblnull.Name = "lblnull"
        Me.lblnull.Size = New System.Drawing.Size(40, 13)
        Me.lblnull.TabIndex = 3
        Me.lblnull.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(153, 232)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 25)
        Me.lblResult.TabIndex = 4
        '
        'txtNumberOne
        '
        Me.txtNumberOne.Location = New System.Drawing.Point(153, 77)
        Me.txtNumberOne.Name = "txtNumberOne"
        Me.txtNumberOne.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOne.TabIndex = 5
        '
        'txtNumberTwo
        '
        Me.txtNumberTwo.Location = New System.Drawing.Point(153, 204)
        Me.txtNumberTwo.Name = "txtNumberTwo"
        Me.txtNumberTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberTwo.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(153, 103)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(25, 25)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(184, 102)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(25, 25)
        Me.btnSubtract.TabIndex = 8
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(215, 103)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(25, 25)
        Me.btnMultiply.TabIndex = 9
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(184, 133)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(25, 25)
        Me.btnDivide.TabIndex = 10
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(215, 134)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(25, 25)
        Me.btnMod.TabIndex = 11
        Me.btnMod.Text = "\"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnExponent
        '
        Me.btnExponent.Location = New System.Drawing.Point(153, 133)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(25, 25)
        Me.btnExponent.TabIndex = 13
        Me.btnExponent.Text = "^"
        Me.btnExponent.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(123, 436)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(513, 436)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(616, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        '
        'lblOperation
        '
        Me.lblOperation.Location = New System.Drawing.Point(108, 158)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(25, 25)
        Me.lblOperation.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 536)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExponent)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNumberTwo)
        Me.Controls.Add(Me.txtNumberOne)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblnull)
        Me.Controls.Add(Me.lblNumberTwo)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblNumberOne)
        Me.Name = "Form1"
        Me.Text = "E&xit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumberOne As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lblNumberTwo As System.Windows.Forms.Label
    Friend WithEvents lblnull As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtNumberOne As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberTwo As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnExponent As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOperation As System.Windows.Forms.Label

End Class

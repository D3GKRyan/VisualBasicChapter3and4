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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.gboxList = New System.Windows.Forms.GroupBox()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.btnFixedPointFormat = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnExponentialFormat = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnCurrnecyFormat = New System.Windows.Forms.Button()
        Me.btnPercentFormat = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gboxList.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number or date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Formatted"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(283, 109)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(226, 27)
        Me.lblResult.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(283, 61)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(116, 20)
        Me.txtInput.TabIndex = 3
        '
        'gboxList
        '
        Me.gboxList.Controls.Add(Me.btnFullDateTime)
        Me.gboxList.Controls.Add(Me.btnShortTime)
        Me.gboxList.Controls.Add(Me.btnLongTime)
        Me.gboxList.Controls.Add(Me.btnNumberFormat)
        Me.gboxList.Controls.Add(Me.btnFixedPointFormat)
        Me.gboxList.Controls.Add(Me.btnLongDate)
        Me.gboxList.Controls.Add(Me.btnExponentialFormat)
        Me.gboxList.Controls.Add(Me.btnShortDate)
        Me.gboxList.Controls.Add(Me.btnCurrnecyFormat)
        Me.gboxList.Controls.Add(Me.btnPercentFormat)
        Me.gboxList.Location = New System.Drawing.Point(152, 208)
        Me.gboxList.Name = "gboxList"
        Me.gboxList.Size = New System.Drawing.Size(356, 228)
        Me.gboxList.TabIndex = 4
        Me.gboxList.TabStop = False
        Me.gboxList.Text = "Select a Format"
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(214, 164)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(103, 23)
        Me.btnFullDateTime.TabIndex = 14
        Me.btnFullDateTime.Text = "Full date/Time (&F)"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(214, 106)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(103, 23)
        Me.btnShortTime.TabIndex = 12
        Me.btnShortTime.Text = "Short time (&t)"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(214, 135)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(103, 23)
        Me.btnLongTime.TabIndex = 13
        Me.btnLongTime.Text = "Long time (&T)"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(32, 48)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(120, 23)
        Me.btnNumberFormat.TabIndex = 5
        Me.btnNumberFormat.Text = "Number format (&n)"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'btnFixedPointFormat
        '
        Me.btnFixedPointFormat.Location = New System.Drawing.Point(32, 77)
        Me.btnFixedPointFormat.Name = "btnFixedPointFormat"
        Me.btnFixedPointFormat.Size = New System.Drawing.Size(120, 23)
        Me.btnFixedPointFormat.TabIndex = 6
        Me.btnFixedPointFormat.Text = "Fixed-point format (&f)"
        Me.btnFixedPointFormat.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(214, 77)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(103, 23)
        Me.btnLongDate.TabIndex = 11
        Me.btnLongDate.Text = "Long date (&D)"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnExponentialFormat
        '
        Me.btnExponentialFormat.Location = New System.Drawing.Point(32, 106)
        Me.btnExponentialFormat.Name = "btnExponentialFormat"
        Me.btnExponentialFormat.Size = New System.Drawing.Size(120, 23)
        Me.btnExponentialFormat.TabIndex = 7
        Me.btnExponentialFormat.Text = "Exponential format (&e)"
        Me.btnExponentialFormat.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(214, 48)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(103, 23)
        Me.btnShortDate.TabIndex = 10
        Me.btnShortDate.Text = "Short date (&d)"
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnCurrnecyFormat
        '
        Me.btnCurrnecyFormat.Location = New System.Drawing.Point(32, 135)
        Me.btnCurrnecyFormat.Name = "btnCurrnecyFormat"
        Me.btnCurrnecyFormat.Size = New System.Drawing.Size(120, 23)
        Me.btnCurrnecyFormat.TabIndex = 8
        Me.btnCurrnecyFormat.Text = "Currency format (&c)"
        Me.btnCurrnecyFormat.UseVisualStyleBackColor = True
        '
        'btnPercentFormat
        '
        Me.btnPercentFormat.Location = New System.Drawing.Point(32, 164)
        Me.btnPercentFormat.Name = "btnPercentFormat"
        Me.btnPercentFormat.Size = New System.Drawing.Size(120, 23)
        Me.btnPercentFormat.TabIndex = 9
        Me.btnPercentFormat.Text = "Percent format (&p)"
        Me.btnPercentFormat.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(184, 460)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(394, 460)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(917, 552)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.gboxList)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Format Demo"
        Me.gboxList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents gboxList As System.Windows.Forms.GroupBox
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents btnFixedPointFormat As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnExponentialFormat As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnCurrnecyFormat As System.Windows.Forms.Button
    Friend WithEvents btnPercentFormat As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

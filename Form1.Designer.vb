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
        Me.TxtReg = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCAT1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCAT2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtExam = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblErrors = New System.Windows.Forms.Label()
        Me.LblExamHints = New System.Windows.Forms.Label()
        Me.MarkList = New System.Windows.Forms.DataGridView()
        CType(Me.MarkList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(709, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unit Grader"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Reg No:"
        '
        'TxtReg
        '
        Me.TxtReg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReg.Location = New System.Drawing.Point(105, 87)
        Me.TxtReg.Name = "TxtReg"
        Me.TxtReg.Size = New System.Drawing.Size(216, 22)
        Me.TxtReg.TabIndex = 2
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(444, 87)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(254, 22)
        Me.TxtName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Full Name:"
        '
        'TxtCAT1
        '
        Me.TxtCAT1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCAT1.Location = New System.Drawing.Point(105, 178)
        Me.TxtCAT1.Name = "TxtCAT1"
        Me.TxtCAT1.Size = New System.Drawing.Size(216, 22)
        Me.TxtCAT1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CAT 1:"
        '
        'TxtCAT2
        '
        Me.TxtCAT2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCAT2.Location = New System.Drawing.Point(105, 210)
        Me.TxtCAT2.Name = "TxtCAT2"
        Me.TxtCAT2.Size = New System.Drawing.Size(216, 22)
        Me.TxtCAT2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CAT 2:"
        '
        'TxtExam
        '
        Me.TxtExam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExam.Location = New System.Drawing.Point(444, 178)
        Me.TxtExam.Name = "TxtExam"
        Me.TxtExam.Size = New System.Drawing.Size(254, 22)
        Me.TxtExam.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Main Exam:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(709, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Student Details"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(702, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Student's Marks"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(260, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 28)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(372, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LblErrors
        '
        Me.LblErrors.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblErrors.ForeColor = System.Drawing.Color.Red
        Me.LblErrors.Location = New System.Drawing.Point(21, 151)
        Me.LblErrors.Name = "LblErrors"
        Me.LblErrors.Size = New System.Drawing.Size(702, 18)
        Me.LblErrors.TabIndex = 16
        Me.LblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblExamHints
        '
        Me.LblExamHints.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExamHints.ForeColor = System.Drawing.Color.Blue
        Me.LblExamHints.Location = New System.Drawing.Point(352, 212)
        Me.LblExamHints.Name = "LblExamHints"
        Me.LblExamHints.Size = New System.Drawing.Size(367, 19)
        Me.LblExamHints.TabIndex = 17
        Me.LblExamHints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MarkList
        '
        Me.MarkList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.MarkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarkList.GridColor = System.Drawing.SystemColors.Control
        Me.MarkList.Location = New System.Drawing.Point(41, 289)
        Me.MarkList.Name = "MarkList"
        Me.MarkList.Size = New System.Drawing.Size(657, 183)
        Me.MarkList.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 490)
        Me.Controls.Add(Me.MarkList)
        Me.Controls.Add(Me.LblExamHints)
        Me.Controls.Add(Me.LblErrors)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtExam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtCAT2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCAT1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtReg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Exam Grader"
        CType(Me.MarkList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtReg As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCAT1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCAT2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtExam As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LblErrors As Label
    Friend WithEvents LblExamHints As Label
    Friend WithEvents MarkList As DataGridView
End Class

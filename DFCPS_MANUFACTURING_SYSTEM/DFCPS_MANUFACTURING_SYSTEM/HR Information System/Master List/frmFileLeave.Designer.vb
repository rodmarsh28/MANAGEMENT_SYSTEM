<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileLeave
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtReason = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbWithpay = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNoOfDays = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbLeaveType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtLFN = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpDateFilled = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(10, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(868, 67)
        Me.Panel1.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Algerian", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(183, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(503, 45)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "EMPLOYEES LEAVE FILER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmployeeID)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtDivision)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDept)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 106)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employees Information"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Enabled = False
        Me.txtEmployeeID.Location = New System.Drawing.Point(106, 21)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(160, 20)
        Me.txtEmployeeID.TabIndex = 71
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 15)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Employee ID :"
        '
        'txtDivision
        '
        Me.txtDivision.Enabled = False
        Me.txtDivision.Location = New System.Drawing.Point(505, 67)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(307, 20)
        Me.txtDivision.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(448, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Division:"
        '
        'txtDept
        '
        Me.txtDept.Enabled = False
        Me.txtDept.Location = New System.Drawing.Point(106, 67)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(329, 20)
        Me.txtDept.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Department:"
        '
        'txtPos
        '
        Me.txtPos.Enabled = False
        Me.txtPos.Location = New System.Drawing.Point(505, 45)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Size = New System.Drawing.Size(307, 20)
        Me.txtPos.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(448, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Position:"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(106, 44)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(329, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtReason)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmbWithpay)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNoOfDays)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpTo)
        Me.GroupBox2.Controls.Add(Me.dtpFrom)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbLeaveType)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 182)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Requested Leave Information"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(489, 36)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(358, 114)
        Me.txtReason.TabIndex = 7
        Me.txtReason.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(381, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Reason of Leave:"
        '
        'cmbWithpay
        '
        Me.cmbWithpay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWithpay.FormattingEnabled = True
        Me.cmbWithpay.Items.AddRange(New Object() {"No", "Yes"})
        Me.cmbWithpay.Location = New System.Drawing.Point(156, 129)
        Me.cmbWithpay.Name = "cmbWithpay"
        Me.cmbWithpay.Size = New System.Drawing.Size(100, 21)
        Me.cmbWithpay.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "With Pay"
        '
        'txtNoOfDays
        '
        Me.txtNoOfDays.Enabled = False
        Me.txtNoOfDays.Location = New System.Drawing.Point(156, 105)
        Me.txtNoOfDays.Name = "txtNoOfDays"
        Me.txtNoOfDays.Size = New System.Drawing.Size(100, 20)
        Me.txtNoOfDays.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Total Days of Leave:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.113208!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(294, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.113208!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(182, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "From"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(262, 81)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(100, 20)
        Me.dtpTo.TabIndex = 4
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(156, 81)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(100, 20)
        Me.dtpFrom.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Date of Leave:"
        '
        'cmbLeaveType
        '
        Me.cmbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLeaveType.FormattingEnabled = True
        Me.cmbLeaveType.Items.AddRange(New Object() {"Sick Leave", "Vacation Leave", "Maternity Leave", "Paternity Leave", "Parental Leave for Solo Parents", "Others"})
        Me.cmbLeaveType.Location = New System.Drawing.Point(156, 39)
        Me.cmbLeaveType.Name = "cmbLeaveType"
        Me.cmbLeaveType.Size = New System.Drawing.Size(206, 21)
        Me.cmbLeaveType.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Requested Leave Type:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(458, 431)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 43)
        Me.btnCancel.TabIndex = 68
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(324, 431)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 43)
        Me.btnAdd.TabIndex = 67
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtLFN
        '
        Me.txtLFN.Enabled = False
        Me.txtLFN.Location = New System.Drawing.Point(118, 85)
        Me.txtLFN.Name = "txtLFN"
        Me.txtLFN.Size = New System.Drawing.Size(160, 20)
        Me.txtLFN.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Leave File No:"
        '
        'dtpDateFilled
        '
        Me.dtpDateFilled.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFilled.Location = New System.Drawing.Point(759, 88)
        Me.dtpDateFilled.Name = "dtpDateFilled"
        Me.dtpDateFilled.Size = New System.Drawing.Size(100, 20)
        Me.dtpDateFilled.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(686, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 15)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Date Filled:"
        '
        'frmFileLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(888, 491)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtpDateFilled)
        Me.Controls.Add(Me.txtLFN)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFileLeave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmFileLeave"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDivision As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbWithpay As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfDays As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbLeaveType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtLFN As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFilled As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class

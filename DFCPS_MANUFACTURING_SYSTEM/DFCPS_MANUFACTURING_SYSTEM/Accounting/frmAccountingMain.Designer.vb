<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountingMain
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthrawItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreparePurchaseInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrepareCheckvoucherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrepareCashRequisistionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreparePaymentRequisistionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrepareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseRequisitionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseOrderHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseInvoiceHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesInvoiceHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashvoucherHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashvoucherRequisitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashRequisitionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentRequisitionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.lblDate, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.lblTime, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel7, Me.lblUsername})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 728)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1173, 22)
        Me.StatusStrip.TabIndex = 14
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel3.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(65, 17)
        Me.lblDate.Text = "00/00/0000"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel6.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(34, 17)
        Me.lblTime.Text = "00:00"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "           "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusLabel7.Text = "User:"
        '
        'lblUsername
        '
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 17)
        Me.lblUsername.Text = "Unknown"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1173, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeesToolStripMenuItem, Me.WidthrawItemsToolStripMenuItem, Me.PreparePurchaseInvoiceToolStripMenuItem, Me.PrepareCheckvoucherToolStripMenuItem, Me.PrepareCashRequisistionToolStripMenuItem, Me.PreparePaymentRequisistionToolStripMenuItem, Me.PrepareToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddEmployeesToolStripMenuItem
        '
        Me.AddEmployeesToolStripMenuItem.Name = "AddEmployeesToolStripMenuItem"
        Me.AddEmployeesToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AddEmployeesToolStripMenuItem.Text = "Prepare Purchase Requisition"
        '
        'WidthrawItemsToolStripMenuItem
        '
        Me.WidthrawItemsToolStripMenuItem.Name = "WidthrawItemsToolStripMenuItem"
        Me.WidthrawItemsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.WidthrawItemsToolStripMenuItem.Text = "Prepare Purchase Order"
        '
        'PreparePurchaseInvoiceToolStripMenuItem
        '
        Me.PreparePurchaseInvoiceToolStripMenuItem.Name = "PreparePurchaseInvoiceToolStripMenuItem"
        Me.PreparePurchaseInvoiceToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PreparePurchaseInvoiceToolStripMenuItem.Text = "Prepare Purchase Invoice"
        '
        'PrepareCheckvoucherToolStripMenuItem
        '
        Me.PrepareCheckvoucherToolStripMenuItem.Name = "PrepareCheckvoucherToolStripMenuItem"
        Me.PrepareCheckvoucherToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PrepareCheckvoucherToolStripMenuItem.Text = "Prepare Checkvoucher"
        '
        'PrepareCashRequisistionToolStripMenuItem
        '
        Me.PrepareCashRequisistionToolStripMenuItem.Name = "PrepareCashRequisistionToolStripMenuItem"
        Me.PrepareCashRequisistionToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PrepareCashRequisistionToolStripMenuItem.Text = "Prepare Cash Requisistion"
        '
        'PreparePaymentRequisistionToolStripMenuItem
        '
        Me.PreparePaymentRequisistionToolStripMenuItem.Name = "PreparePaymentRequisistionToolStripMenuItem"
        Me.PreparePaymentRequisistionToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PreparePaymentRequisistionToolStripMenuItem.Text = "Prepare Payment Requisistion"
        '
        'PrepareToolStripMenuItem
        '
        Me.PrepareToolStripMenuItem.Name = "PrepareToolStripMenuItem"
        Me.PrepareToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PrepareToolStripMenuItem.Text = "Prepare Cashvoucher"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseRequisitionHistoryToolStripMenuItem, Me.PurchaseOrderHistoryToolStripMenuItem, Me.PurchaseInvoiceHistoryToolStripMenuItem, Me.SalesInvoiceHistoryToolStripMenuItem, Me.CashvoucherHistoryToolStripMenuItem, Me.CashvoucherRequisitionToolStripMenuItem, Me.CashRequisitionHistoryToolStripMenuItem, Me.PaymentRequisitionHistoryToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.TransactionToolStripMenuItem.Text = "View"
        '
        'PurchaseRequisitionHistoryToolStripMenuItem
        '
        Me.PurchaseRequisitionHistoryToolStripMenuItem.Name = "PurchaseRequisitionHistoryToolStripMenuItem"
        Me.PurchaseRequisitionHistoryToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.PurchaseRequisitionHistoryToolStripMenuItem.Text = "Purchase Requisition History"
        '
        'PurchaseOrderHistoryToolStripMenuItem
        '
        Me.PurchaseOrderHistoryToolStripMenuItem.Name = "PurchaseOrderHistoryToolStripMenuItem"
        Me.PurchaseOrderHistoryToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.PurchaseOrderHistoryToolStripMenuItem.Text = "Purchase Order History"
        '
        'PurchaseInvoiceHistoryToolStripMenuItem
        '
        Me.PurchaseInvoiceHistoryToolStripMenuItem.Name = "PurchaseInvoiceHistoryToolStripMenuItem"
        Me.PurchaseInvoiceHistoryToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.PurchaseInvoiceHistoryToolStripMenuItem.Text = "Purchase Receiving History"
        '
        'SalesInvoiceHistoryToolStripMenuItem
        '
        Me.SalesInvoiceHistoryToolStripMenuItem.Name = "SalesInvoiceHistoryToolStripMenuItem"
        Me.SalesInvoiceHistoryToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.SalesInvoiceHistoryToolStripMenuItem.Text = "Sales Invoice History"
        '
        'CashvoucherHistoryToolStripMenuItem
        '
        Me.CashvoucherHistoryToolStripMenuItem.Name = "CashvoucherHistoryToolStripMenuItem"
        Me.CashvoucherHistoryToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CashvoucherHistoryToolStripMenuItem.Text = "Checkvoucher History"
        '
        'CashvoucherRequisitionToolStripMenuItem
        '
        Me.CashvoucherRequisitionToolStripMenuItem.Name = "CashvoucherRequisitionToolStripMenuItem"
        Me.CashvoucherRequisitionToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CashvoucherRequisitionToolStripMenuItem.Text = "Cashvoucher Requisition"
        '
        'CashRequisitionHistoryToolStripMenuItem
        '
        Me.CashRequisitionHistoryToolStripMenuItem.Name = "CashRequisitionHistoryToolStripMenuItem"
        Me.CashRequisitionHistoryToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CashRequisitionHistoryToolStripMenuItem.Text = "Cash Requisition History"
        '
        'PaymentRequisitionHistoryToolStripMenuItem
        '
        Me.PaymentRequisitionHistoryToolStripMenuItem.Name = "PaymentRequisitionHistoryToolStripMenuItem"
        Me.PaymentRequisitionHistoryToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.PaymentRequisitionHistoryToolStripMenuItem.Text = "Payment Requisition List"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.PayrollToolStripMenuItem.Text = "Report"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmAccountingMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 750)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmAccountingMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounting "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WidthrawItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreparePurchaseInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseRequisitionHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseOrderHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseInvoiceHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesInvoiceHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrepareCheckvoucherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrepareCashRequisistionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreparePaymentRequisistionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrepareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashvoucherHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashvoucherRequisitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashRequisitionHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentRequisitionHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

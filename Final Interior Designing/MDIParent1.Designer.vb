<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InteriorTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InteriorObjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesignsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.DimGray
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 583)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1186, 25)
        Me.StatusStrip.TabIndex = 11
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.BackColor = System.Drawing.Color.Silver
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.HomeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'MasterEntriesToolStripMenuItem
        '
        Me.MasterEntriesToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.MasterEntriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InteriorTypesToolStripMenuItem, Me.InteriorObjectToolStripMenuItem})
        Me.MasterEntriesToolStripMenuItem.Name = "MasterEntriesToolStripMenuItem"
        Me.MasterEntriesToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.MasterEntriesToolStripMenuItem.Text = "Master Entries"
        '
        'InteriorTypesToolStripMenuItem
        '
        Me.InteriorTypesToolStripMenuItem.Name = "InteriorTypesToolStripMenuItem"
        Me.InteriorTypesToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.InteriorTypesToolStripMenuItem.Text = "Interior Types"
        '
        'InteriorObjectToolStripMenuItem
        '
        Me.InteriorObjectToolStripMenuItem.Name = "InteriorObjectToolStripMenuItem"
        Me.InteriorObjectToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.InteriorObjectToolStripMenuItem.Text = "Interior Object"
        '
        'EmployeeDetailsToolStripMenuItem
        '
        Me.EmployeeDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.EmployeeDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesignsToolStripMenuItem1, Me.ObjectsToolStripMenuItem})
        Me.EmployeeDetailsToolStripMenuItem.Name = "EmployeeDetailsToolStripMenuItem"
        Me.EmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.EmployeeDetailsToolStripMenuItem.Text = "Interior Ideas"
        '
        'DesignsToolStripMenuItem1
        '
        Me.DesignsToolStripMenuItem1.Name = "DesignsToolStripMenuItem1"
        Me.DesignsToolStripMenuItem1.Size = New System.Drawing.Size(130, 24)
        Me.DesignsToolStripMenuItem1.Text = "Designs"
        '
        'ObjectsToolStripMenuItem
        '
        Me.ObjectsToolStripMenuItem.Name = "ObjectsToolStripMenuItem"
        Me.ObjectsToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ObjectsToolStripMenuItem.Text = "Objects"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.CustomerDetailsToolStripMenuItem.Text = "Employee Details"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.BillingToolStripMenuItem.Text = "Customer Details"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuotationToolStripMenuItem, Me.BillingToolStripMenuItem1})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.ReportToolStripMenuItem.Text = "Billing"
        '
        'QuotationToolStripMenuItem
        '
        Me.QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        Me.QuotationToolStripMenuItem.Size = New System.Drawing.Size(145, 24)
        Me.QuotationToolStripMenuItem.Text = "Quotation"
        '
        'BillingToolStripMenuItem1
        '
        Me.BillingToolStripMenuItem1.Name = "BillingToolStripMenuItem1"
        Me.BillingToolStripMenuItem1.Size = New System.Drawing.Size(145, 24)
        Me.BillingToolStripMenuItem1.Text = "Billing"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.MasterEntriesToolStripMenuItem, Me.EmployeeDetailsToolStripMenuItem, Me.CustomerDetailsToolStripMenuItem, Me.BillingToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ReportToolStripMenuItem1, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1186, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(66, 24)
        Me.ReportToolStripMenuItem1.Text = "Report"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1186, 608)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterEntriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InteriorTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InteriorObjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReportToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

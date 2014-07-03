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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SqlTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GenerateGridToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ExportDirectoryToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ExportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DataTabPage = New System.Windows.Forms.TabPage()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.JavascriptTabPage = New System.Windows.Forms.TabPage()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.SaveGridScriptToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.JSONTabPage = New System.Windows.Forms.TabPage()
        Me.JSONTextBox = New System.Windows.Forms.TextBox()
        Me.HTMLTabPage = New System.Windows.Forms.TabPage()
        Me.HTMLTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenExportDirectoryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.FilenamesPrefixToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.DataTabPage.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JavascriptTabPage.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.JSONTabPage.SuspendLayout()
        Me.HTMLTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SqlTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1120, 626)
        Me.SplitContainer1.SplitterDistance = 148
        Me.SplitContainer1.TabIndex = 0
        '
        'SqlTextBox
        '
        Me.SqlTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SqlTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SqlTextBox.Location = New System.Drawing.Point(0, 25)
        Me.SqlTextBox.Multiline = True
        Me.SqlTextBox.Name = "SqlTextBox"
        Me.SqlTextBox.Size = New System.Drawing.Size(1120, 123)
        Me.SqlTextBox.TabIndex = 0
        Me.SqlTextBox.Text = "select * from tblvitalsigns"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateGridToolStripButton, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ExportDirectoryToolStripTextBox, Me.ToolStripLabel2, Me.FilenamesPrefixToolStripTextBox, Me.ExportToolStripButton, Me.ToolStripSeparator2, Me.OpenExportDirectoryToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1120, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GenerateGridToolStripButton
        '
        Me.GenerateGridToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GenerateGridToolStripButton.Image = CType(resources.GetObject("GenerateGridToolStripButton.Image"), System.Drawing.Image)
        Me.GenerateGridToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenerateGridToolStripButton.Name = "GenerateGridToolStripButton"
        Me.GenerateGridToolStripButton.Size = New System.Drawing.Size(87, 22)
        Me.GenerateGridToolStripButton.Text = "Generate code"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "Export directory:"
        '
        'ExportDirectoryToolStripTextBox
        '
        Me.ExportDirectoryToolStripTextBox.Name = "ExportDirectoryToolStripTextBox"
        Me.ExportDirectoryToolStripTextBox.Size = New System.Drawing.Size(500, 25)
        Me.ExportDirectoryToolStripTextBox.Text = "C:\ColdFusion10\cfusion\wwwroot\ztemp"
        '
        'ExportToolStripButton
        '
        Me.ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExportToolStripButton.Image = CType(resources.GetObject("ExportToolStripButton.Image"), System.Drawing.Image)
        Me.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportToolStripButton.Name = "ExportToolStripButton"
        Me.ExportToolStripButton.Size = New System.Drawing.Size(44, 22)
        Me.ExportToolStripButton.Text = "Export"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DataTabPage)
        Me.TabControl1.Controls.Add(Me.JavascriptTabPage)
        Me.TabControl1.Controls.Add(Me.JSONTabPage)
        Me.TabControl1.Controls.Add(Me.HTMLTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1120, 474)
        Me.TabControl1.TabIndex = 1
        '
        'DataTabPage
        '
        Me.DataTabPage.Controls.Add(Me.DataGridView)
        Me.DataTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DataTabPage.Name = "DataTabPage"
        Me.DataTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DataTabPage.Size = New System.Drawing.Size(1112, 448)
        Me.DataTabPage.TabIndex = 0
        Me.DataTabPage.Text = "Data"
        Me.DataTabPage.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToOrderColumns = True
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.Size = New System.Drawing.Size(1106, 442)
        Me.DataGridView.TabIndex = 0
        '
        'JavascriptTabPage
        '
        Me.JavascriptTabPage.Controls.Add(Me.OutputTextBox)
        Me.JavascriptTabPage.Controls.Add(Me.ToolStrip2)
        Me.JavascriptTabPage.Location = New System.Drawing.Point(4, 22)
        Me.JavascriptTabPage.Name = "JavascriptTabPage"
        Me.JavascriptTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.JavascriptTabPage.Size = New System.Drawing.Size(1112, 448)
        Me.JavascriptTabPage.TabIndex = 1
        Me.JavascriptTabPage.Text = "Javascript"
        Me.JavascriptTabPage.UseVisualStyleBackColor = True
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutputTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTextBox.Location = New System.Drawing.Point(3, 28)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputTextBox.Size = New System.Drawing.Size(1106, 417)
        Me.OutputTextBox.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveGridScriptToolStripButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1106, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'SaveGridScriptToolStripButton
        '
        Me.SaveGridScriptToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveGridScriptToolStripButton.Image = CType(resources.GetObject("SaveGridScriptToolStripButton.Image"), System.Drawing.Image)
        Me.SaveGridScriptToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveGridScriptToolStripButton.Name = "SaveGridScriptToolStripButton"
        Me.SaveGridScriptToolStripButton.Size = New System.Drawing.Size(44, 22)
        Me.SaveGridScriptToolStripButton.Text = "Save..."
        '
        'JSONTabPage
        '
        Me.JSONTabPage.Controls.Add(Me.JSONTextBox)
        Me.JSONTabPage.Location = New System.Drawing.Point(4, 22)
        Me.JSONTabPage.Name = "JSONTabPage"
        Me.JSONTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.JSONTabPage.Size = New System.Drawing.Size(1112, 448)
        Me.JSONTabPage.TabIndex = 2
        Me.JSONTabPage.Text = "JSON data source code"
        Me.JSONTabPage.UseVisualStyleBackColor = True
        '
        'JSONTextBox
        '
        Me.JSONTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JSONTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JSONTextBox.Location = New System.Drawing.Point(3, 3)
        Me.JSONTextBox.Multiline = True
        Me.JSONTextBox.Name = "JSONTextBox"
        Me.JSONTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.JSONTextBox.Size = New System.Drawing.Size(1106, 442)
        Me.JSONTextBox.TabIndex = 0
        '
        'HTMLTabPage
        '
        Me.HTMLTabPage.Controls.Add(Me.HTMLTextBox)
        Me.HTMLTabPage.Location = New System.Drawing.Point(4, 22)
        Me.HTMLTabPage.Name = "HTMLTabPage"
        Me.HTMLTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.HTMLTabPage.Size = New System.Drawing.Size(1112, 448)
        Me.HTMLTabPage.TabIndex = 3
        Me.HTMLTabPage.Text = "HTML"
        Me.HTMLTabPage.UseVisualStyleBackColor = True
        '
        'HTMLTextBox
        '
        Me.HTMLTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HTMLTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HTMLTextBox.Location = New System.Drawing.Point(3, 3)
        Me.HTMLTextBox.Multiline = True
        Me.HTMLTextBox.Name = "HTMLTextBox"
        Me.HTMLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HTMLTextBox.Size = New System.Drawing.Size(1106, 442)
        Me.HTMLTextBox.TabIndex = 1
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OpenExportDirectoryToolStripButton
        '
        Me.OpenExportDirectoryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OpenExportDirectoryToolStripButton.Image = CType(resources.GetObject("OpenExportDirectoryToolStripButton.Image"), System.Drawing.Image)
        Me.OpenExportDirectoryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenExportDirectoryToolStripButton.Name = "OpenExportDirectoryToolStripButton"
        Me.OpenExportDirectoryToolStripButton.Size = New System.Drawing.Size(40, 22)
        Me.OpenExportDirectoryToolStripButton.Text = "Open"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripLabel2.Text = "Filenames prefix:"
        '
        'FilenamesPrefixToolStripTextBox
        '
        Me.FilenamesPrefixToolStripTextBox.Name = "FilenamesPrefixToolStripTextBox"
        Me.FilenamesPrefixToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        Me.FilenamesPrefixToolStripTextBox.Text = "zMyData"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 626)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "ExtJS Grid from SQL"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.DataTabPage.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JavascriptTabPage.ResumeLayout(False)
        Me.JavascriptTabPage.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.JSONTabPage.ResumeLayout(False)
        Me.JSONTabPage.PerformLayout()
        Me.HTMLTabPage.ResumeLayout(False)
        Me.HTMLTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SqlTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GenerateGridToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents DataTabPage As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents JavascriptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents JSONTabPage As System.Windows.Forms.TabPage
    Friend WithEvents JSONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents SaveGridScriptToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ExportDirectoryToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ExportToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HTMLTabPage As System.Windows.Forms.TabPage
    Friend WithEvents HTMLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenExportDirectoryToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FilenamesPrefixToolStripTextBox As System.Windows.Forms.ToolStripTextBox

End Class

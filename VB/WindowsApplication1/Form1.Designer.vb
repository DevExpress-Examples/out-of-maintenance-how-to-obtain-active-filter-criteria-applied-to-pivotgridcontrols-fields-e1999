Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.listBoxControl2 = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.listBoxControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Prefilter.CriteriaString = "[pivotGridField2] <> 'test'"
			Me.pivotGridControl1.Size = New System.Drawing.Size(634, 523)
			Me.pivotGridControl1.TabIndex = 1
			' 
			' pivotGridField2
			' 
			Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField2.AreaIndex = 0
			Me.pivotGridField2.FieldName = "Name"
			Me.pivotGridField2.Name = "pivotGridField2"
			' 
			' pivotGridField3
			' 
			Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField3.AreaIndex = 0
			Me.pivotGridField3.FieldName = "Number"
			Me.pivotGridField3.Name = "pivotGridField3"
			' 
			' pivotGridField4
			' 
			Me.pivotGridField4.AreaIndex = 0
			Me.pivotGridField4.FieldName = "ID"
			Me.pivotGridField4.Name = "pivotGridField4"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.listBoxControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelControl1.Location = New System.Drawing.Point(634, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(235, 523)
			Me.panelControl1.TabIndex = 4
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxControl1.Items.AddRange(New Object() { "Detail filter:"})
			Me.listBoxControl1.Location = New System.Drawing.Point(2, 2)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(231, 519)
			Me.listBoxControl1.TabIndex = 1
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.pivotGridField1.AreaIndex = 0
			Me.pivotGridField1.Caption = "Date"
			Me.pivotGridField1.FieldName = "Date"
			Me.pivotGridField1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.pivotGridField1.Name = "pivotGridField1"
			Me.pivotGridField1.UnboundFieldName = "pivotGridField1"
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.listBoxControl2)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelControl2.Location = New System.Drawing.Point(399, 0)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(235, 523)
			Me.panelControl2.TabIndex = 5
			' 
			' listBoxControl2
			' 
			Me.listBoxControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxControl2.Items.AddRange(New Object() { "Active filter:"})
			Me.listBoxControl2.Location = New System.Drawing.Point(2, 2)
			Me.listBoxControl2.Name = "listBoxControl2"
			Me.listBoxControl2.Size = New System.Drawing.Size(231, 519)
			Me.listBoxControl2.TabIndex = 1
			' 
			' Form1
			' 
			Me.ClientSize = New System.Drawing.Size(869, 523)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			CType(Me.listBoxControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private listBoxControl2 As DevExpress.XtraEditors.ListBoxControl

	End Class
End Namespace


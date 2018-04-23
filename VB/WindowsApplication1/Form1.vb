Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
				Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i Mod 5), i Mod 4, i Mod 20, DateTime.Now.AddMonths(i Mod 12) })
			Next i
			Return tbl
				End Function


		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = CreateTable(150)
			Dim TempMyPivotGridFilterHelper As MyPivotGridFilterHelper = New MyPivotGridFilterHelper(pivotGridControl1, listBoxControl2.Items, listBoxControl1.Items)
		End Sub
	End Class
End Namespace
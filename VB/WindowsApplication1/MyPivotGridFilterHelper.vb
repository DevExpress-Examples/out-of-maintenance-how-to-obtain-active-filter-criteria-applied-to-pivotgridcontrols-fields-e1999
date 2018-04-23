Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports System.Collections
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1
	Public Class MyPivotGridFilterHelper
		Private pivotGrid As PivotGridControl
		Private output As ListBoxItemCollection
		Private outputDetail As ListBoxItemCollection


		Public Sub New(ByVal pivotGrid As PivotGridControl, ByVal output As ListBoxItemCollection, ByVal outputDetail As ListBoxItemCollection)
			Me.pivotGrid = pivotGrid
			Me.output = output
			Me.outputDetail = outputDetail
			AddHandler pivotGrid.FieldFilterChanged, AddressOf pivotGrid_FieldFilterChanged
		End Sub

		Private Sub WriteFieldFilter(ByVal field As PivotGridField)
			Dim values() As Object = field.FilterValues.Values
			If values.Length = 0 Then
				Return
			End If
			output.Add("==============")
			output.Add(String.Format("Field '{0}'. {1} values:", field.FieldName, field.FilterValues.FilterType))
			For Each value As Object In values
				output.Add(String.Format("[ {0} ]", value))
			Next value
		End Sub

		Private Sub WriteFieldFilterDetail(ByVal field As PivotGridField)
			outputDetail.Add("==============")
			outputDetail.Add(String.Format("Field '{0}'. Included values:", field.FieldName))
			For Each value As Object In field.FilterValues.ValuesIncluded
				outputDetail.Add(String.Format("[ {0} ]", value))
			Next value
			outputDetail.Add(String.Format("Field '{0}'. Excluded values:", field.FieldName))
			For Each value As Object In field.FilterValues.ValuesExcluded
				outputDetail.Add(String.Format("[ {0} ]", value))
			Next value
		End Sub


		Private Sub DiplayActiveFilter()
			output.Clear()
			output.Add("Active filter:")
			For Each field As PivotGridField In pivotGrid.Fields
				WriteFieldFilter(field)
			Next field
		End Sub

		Private Sub DiplayActiveDetailFilter()
			outputDetail.Clear()
			outputDetail.Add("Detail filter:")
			For Each field As PivotGridField In pivotGrid.Fields
				WriteFieldFilterDetail(field)
			Next field
		End Sub

		Private Sub pivotGrid_FieldFilterChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs)
			DiplayActiveFilter()
			DiplayActiveDetailFilter()
		End Sub
	End Class
End Namespace

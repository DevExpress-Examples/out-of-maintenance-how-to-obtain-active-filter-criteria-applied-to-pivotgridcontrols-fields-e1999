using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using System.Collections;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1
{
    public class MyPivotGridFilterHelper
    {
        private PivotGridControl pivotGrid;
        private ListBoxItemCollection output;
        private ListBoxItemCollection outputDetail;


        public MyPivotGridFilterHelper(PivotGridControl pivotGrid, ListBoxItemCollection output, ListBoxItemCollection outputDetail)
        {
            this.pivotGrid = pivotGrid;
            this.output = output;
            this.outputDetail = outputDetail;
            pivotGrid.FieldFilterChanged += pivotGrid_FieldFilterChanged;
        }

        void WriteFieldFilter(PivotGridField field)
        {
            object[] values = field.FilterValues.Values;
            if (values.Length == 0) return;
            output.Add("==============");
            output.Add(String.Format("Field '{0}'. {1} values:", field.FieldName, field.FilterValues.FilterType));
            foreach (object value in values) output.Add(String.Format("[ {0} ]", value));
        }

        void WriteFieldFilterDetail(PivotGridField field)
        {
            outputDetail.Add("==============");
            outputDetail.Add(String.Format("Field '{0}'. Included values:", field.FieldName));
            foreach (object value in field.FilterValues.ValuesIncluded) outputDetail.Add(String.Format("[ {0} ]", value));
            outputDetail.Add(String.Format("Field '{0}'. Excluded values:", field.FieldName));
            foreach (object value in field.FilterValues.ValuesExcluded) outputDetail.Add(String.Format("[ {0} ]", value));
        }


        void DiplayActiveFilter()
        {
            output.Clear();
            output.Add("Active filter:");
            foreach (PivotGridField field in pivotGrid.Fields)
            {
                WriteFieldFilter(field);
            }
        }

        void DiplayActiveDetailFilter()
        {
            outputDetail.Clear();
            outputDetail.Add("Detail filter:");
            foreach (PivotGridField field in pivotGrid.Fields)
            {
                WriteFieldFilterDetail(field);
            }
        }

        void pivotGrid_FieldFilterChanged(object sender, PivotFieldEventArgs e)
        {
            DiplayActiveFilter();
            DiplayActiveDetailFilter();
        }
    }
}

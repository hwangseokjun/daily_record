using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daily_record
{
    public partial class FormTableSizeDialog : Form
    {
        private int _rowCount;
        private int _columnCount;
        private int _Height = 100;
        private int _Width = 1000;

        public string Rtf { 
            get 
            {
                var sb = new StringBuilder();
                sb.Append(@"{\rtf1\ansi\deff0");

                for (int i = 0; i < _rowCount; i++)
                {
                    sb.Append($@"{{\trowd\trrh{_Height}");
                    for (int j = 0; j < _columnCount; j++)
                    {
                        sb.Append($@"\cellx{_Width * (j + 1)}");
                    }
                    sb.Append(@"\intbl ");
                    for (int j = 0; j < _columnCount; j++)
                    {
                        sb.Append(@"\cell ");
                    }
                    sb.Append(@"\intbl\row}");
                }
                return sb.ToString();
            } 
        }

        public FormTableSizeDialog()
        {
            InitializeComponent();
        }

        private void _btnConfirm_Click(object sender, EventArgs e)
        {
            _rowCount = (int)_numericRow.Value;
            _columnCount = (int)_numericColumn.Value;
            _Height = (int)_numericHeight.Value;
            _Width = (int)_numericWidth.Value;
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }
    }
}

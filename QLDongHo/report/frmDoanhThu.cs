using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDongHo.report
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetQLBDongHo.DataTable3' table. You can move, or remove it, as needed.
           
        }

        private void dtpngay_ValueChanged(object sender, EventArgs e)
        {
            this.DataTable3TableAdapter.Fill(this.DataSetQLBDongHo.DataTable3,dtpngay.Value,ngayKT.Value);

            this.reportViewer1.RefreshReport();
        }

       
    }
}

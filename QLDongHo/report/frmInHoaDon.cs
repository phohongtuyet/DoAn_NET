using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDongHo.BUS;
namespace QLDongHo.report
{
    public partial class frmInHoaDon : Form
    {
        HoaDon_BUS hdUS = new HoaDon_BUS();

        public frmInHoaDon()
        {
            InitializeComponent();
        }
        public string maHD;
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetQLBDongHo.DataTable2' table. You can move, or remove it, as needed.
            
            this.DataTable2TableAdapter.Fill(this.DataSetQLBDongHo.DataTable2, maHD);
            this.reportViewer1.RefreshReport();

        }
       
        private void cboDSHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

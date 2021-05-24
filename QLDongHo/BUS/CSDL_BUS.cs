using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDongHo.DAL;
namespace QLDongHo.BUS
{
    public class CSDL_BUS
    {
        CSDL_DAL data = new CSDL_DAL();

        public void  SaoLuu(string sDuongDan)
        {
            data.SaoLuuDuLieu(sDuongDan);
        }
        public void PhucHoi(string sDuongDan)
        {
            data.PhucHoiDuLieu(sDuongDan);
        }
        
    }
}

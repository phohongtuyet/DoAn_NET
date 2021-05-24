using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongHo.DTO
{
   public class TaiKhoan_DTO
    {
        private int ID;
        private int nhanVien_ID;
        private int quyen;
        private string taiKhoan;
        private string matKhau;

        public int ID1 { get => ID; set => ID = value; }
        public int NhanVien_ID { get => nhanVien_ID; set => nhanVien_ID = value; }
        public int Quyen { get => quyen; set => quyen = value; }
       
        public string MatKhau { get => matKhau; set => matKhau = value; }
      
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}

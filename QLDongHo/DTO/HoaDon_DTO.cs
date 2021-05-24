using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongHo.DTO
{
    public class HoaDon_DTO
    {
        private string maHD;
        private int nhanVien_ID;
        private int KhachHang_ID;
        DateTime ngayLap;

        public int NhanVien_ID { get => nhanVien_ID; set => nhanVien_ID = value; }
        public int KhachHang_ID1 { get => KhachHang_ID; set => KhachHang_ID = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaHD { get => maHD; set => maHD = value; }
    }
}

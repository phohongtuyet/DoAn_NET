using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongHo.DTO
{
   public class NhanVien_DTO
    {
        private int Id;
        private string hoVaTen;
        private string dienThoai;
        private string diaChi;
        DateTime ngaySinh;
        private string gioiTinh;

        public int Id1 { get => Id; set => Id = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLDongHo.DTO
{
   public class KhachHang_DTO
    {
        private int Id;
        private string hoVaTen;
        private string dienThoai;
        private string diaChi;

        public int Id1 { get => Id; set => Id = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
       
    }
}

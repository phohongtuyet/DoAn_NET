using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongHo.DTO
{
    public class HoaDonChiTiet_DTO
    {
        private int ID;
        private string hoaDon_ID;
        private int dongHo_ID;
        private int soLuong;
        private int DonGia;
        private int thanhTien;

        public int ID1 { get => ID; set => ID = value; }
        public int DongHo_ID { get => dongHo_ID; set => dongHo_ID = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia1 { get => DonGia; set => DonGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string HoaDon_ID1 { get => hoaDon_ID; set => hoaDon_ID = value; }
    }
}

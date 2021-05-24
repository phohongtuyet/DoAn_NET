using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongHo.DTO
{
   public class DongHo_DTO
    {
        private int ID;
        private int thuongHieu_ID;
        private int loai_ID;
        private int duongKinhMat_ID;
        private string gioiTinh;
        private string tenDongHo;
        private int donGia;
        private int giaBan;
        private int soLuong;

       
        public int ThuongHieu_ID { get => thuongHieu_ID; set => thuongHieu_ID = value; }
        public int Loai_ID { get => loai_ID; set => loai_ID = value; }
        public int DuongKinhMat_ID { get => duongKinhMat_ID; set => duongKinhMat_ID = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TenDongHo { get => tenDongHo; set => tenDongHo = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
       
        public int ID1 { get => ID; set => ID = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appquanlydanhba.ViewModel
{
    public enum Ketqua
    {
        TrungMa,
        ThanhCong,
    }

    public class SinhVienViewModel
    {
        public int MaSinhVien { get; set; }

        public string TenSinhVien { get; set; }

        public string Email { get; set; }

        public int? SDT { get; set; }

        public string DiaChi { get; set; }

        public int? ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appquanlydanhba.ViewModel
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong,
    }


    public class NhomViewModel
    {
        public int ID { get; set; }

        public string TenNhom { get; set; }
    }
}

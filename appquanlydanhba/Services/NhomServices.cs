using appquanlydanhba.Model;
using appquanlydanhba.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appquanlydanhba.Services
{
    class NhomServices
    {
        public static List<NhomViewModel> GetLists()
        {
            var db = new AppDBContext();
            var ls = db.nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom
            }).ToList();
            return ls;
        }
        public static Ketqua AddNhom(nhom lh)
        {
            var db = new AppDBContext();
            int count = db.nhoms.Where(e => e.ID == lh.ID).Count();
            if (count > 0)
            {
                return Ketqua.TrungMa;
            }
            else
            {
                db.nhoms.Add(lh);
                db.SaveChanges();
                return Ketqua.ThanhCong;
            }

        }
        //xóa 
        public static KetQua removeNhom(NhomViewModel lh)
        {
            var db = new AppDBContext();
            var nhoms = db.nhoms.Where(e => e.ID == lh.ID).FirstOrDefault();
            db.nhoms.Remove(nhoms);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
        
   }



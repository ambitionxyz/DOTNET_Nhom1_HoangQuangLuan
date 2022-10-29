using appquanlydanhba.Model;
using appquanlydanhba.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appquanlydanhba.Services
{
    class SinhVienServices
    {
        public static List<SinhVienViewModel> GetLists()
        {
            var db = new AppDBContext();
            var ls = db.SinhViens.Select(e => new SinhVienViewModel
            {
                MaSinhVien = e.MaSinhVien,
                TenSinhVien = e.TenSinhVien,
                Email = e.Email,
                DiaChi = e.DiaChi,
                SDT = e.SDT,
                ID=e.ID,
            }).ToList();
            return ls;
        }
        public static List<SinhVienViewModel> GetList(int ID)
        {
            var db = new AppDBContext();
            var rs = db.SinhViens.Where(e => e.ID == ID)
                .Select(e => new SinhVienViewModel
                {
                    MaSinhVien = e.MaSinhVien,
                    TenSinhVien=e.TenSinhVien,
                    DiaChi=e.DiaChi,
                    Email=e.Email,
                    SDT=e.SDT,
                    ID=e.ID,
                   
                }).ToList();
            return rs;
        }
        public static KetQua AddSinhVien(SinhVien sv)
        {
            var db = new AppDBContext();
            int count = db.SinhViens.Where(e => e.MaSinhVien == sv.MaSinhVien).Count();
            if (count > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }

        }
        public static KetQua removeSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhViens = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            db.SinhViens.Remove(sinhViens);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
        public static List<SinhVienViewModel> timkiem(int ID,String cantim)
        {
            var rs = GetList(ID);
            var db = rs.Where(e => e.TenSinhVien.ToLower().Contains(cantim.ToLower())).ToList();

            return db;
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appquanlydanhba.Model;
using appquanlydanhba.ViewModel;
using appquanlydanhba.Services;

namespace appquanlydanhba
{
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
            napdsnhom();
        }
        public void napdsnhom()
        {
            var ls = NhomServices.GetLists();
            cbbnhom.DataSource = ls;
            cbbnhom.DisplayMember = "TenNhom";
        }
        public NhomViewModel selecttedNhom
        {
            get
            {
                return cbbnhom.SelectedItem as NhomViewModel;
            }
        }
        private void btnboqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            var sinhvien = new SinhVien
            {
                MaSinhVien=int.Parse( txtmsv.Text),
                TenSinhVien=txttensinhvien.Text,
                Email=txtemail.Text,
                DiaChi=txtdiachi.Text,
                SDT= int.Parse(txtsdt.Text),
                ID=selecttedNhom.ID
            };
            var ls = SinhVienServices.AddSinhVien(sinhvien);
            if (ls == KetQua.ThanhCong) DialogResult = DialogResult.OK;
        }
    }
}

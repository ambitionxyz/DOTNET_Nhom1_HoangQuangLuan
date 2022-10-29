using appquanlydanhba.Services;
using appquanlydanhba.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appquanlydanhba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            napnhom();
            napdsSinhvien();
        }
        public void napnhom()
        {
            var ls = NhomServices.GetLists();
            nhomViewModelBindingSource.DataSource = ls;
            Gridnhom.DataSource = nhomViewModelBindingSource;
        }
        public void napdsSinhvien()
        {
            var ls = SinhVienServices.GetLists();
            sinhVienViewModelBindingSource.DataSource = ls;
            Gridsinhvien.DataSource = sinhVienViewModelBindingSource;
        }
        public NhomViewModel seletedNhom
        {
            get
            {
                return nhomViewModelBindingSource.Current as NhomViewModel;
            }
        }

        public SinhVienViewModel selectedSinhVien

        {
            get
            {
                return sinhVienViewModelBindingSource.Current as SinhVienViewModel;
            }

        }
        private void Gridnhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            napdsSinhvien();
        }

        private void btnthemnhom_Click(object sender, EventArgs e)
        {
            var f = new Frmnhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                napnhom();
            }
        }

        private void btnxoanhom_Click(object sender, EventArgs e)
        {
            if (seletedNhom != null)
            {
                var rs = MessageBox.Show("bạn có chắc là muốn xóa nhóm này và những sinh viên trong nhóm hay không ?", "chú ý", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomServices.removeNhom(seletedNhom);
                    napnhom();
                    napdsSinhvien();
                }
            }


        }

        private void btnthemlienlac_Click(object sender, EventArgs e)
        {
            var f = new FrmSinhVien();
            var rs = f.ShowDialog();

            if (rs == DialogResult.OK)
            {
                napdsSinhvien();
            }

        }

        private void btnxoalienlac_Click(object sender, EventArgs e)
        {
            if (selectedSinhVien != null)
            {
                var rs = MessageBox.Show("bạn có chắc là muốn xóa ?", "chú ý", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    SinhVienServices.removeSinhVien(selectedSinhVien);
                    napdsSinhvien();
                }



            }
        }

        private void Gridnhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(seletedNhom!=null)
            {
                var rs = SinhVienServices.GetList(seletedNhom.ID);
                sinhVienViewModelBindingSource.DataSource = rs;
                Gridsinhvien.DataSource = sinhVienViewModelBindingSource;
            }    
        }

        private void Gridsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(selectedSinhVien!=null)
            {
                txtdiachi.Text = selectedSinhVien.DiaChi;
                    txtten.Text = selectedSinhVien.TenSinhVien;
                txtemail.Text = selectedSinhVien.Email;
                txtsdt.Text = selectedSinhVien.SDT.ToString();
            }    
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(seletedNhom != null)
                {
                    var rs = SinhVienServices.timkiem(seletedNhom.ID, txttimkiem.Text);
                    sinhVienViewModelBindingSource.DataSource = rs;
                    Gridsinhvien.DataSource = sinhVienViewModelBindingSource;
                }    
                
            }    
        }
    }
}



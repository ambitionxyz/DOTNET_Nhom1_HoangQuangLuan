using System;
using appquanlydanhba.Model;
using appquanlydanhba.ViewModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appquanlydanhba.Services;

namespace appquanlydanhba
{
    public partial class Frmnhom : Form
    {
        public Frmnhom()
        {
            InitializeComponent();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            var nhom = new nhom
            {
                ID = int.Parse(txtmanhom.Text),
                TenNhom =txttennhom.Text
            };
            var ls = NhomServices.AddNhom(nhom);
            if (ls == Ketqua.ThanhCong) DialogResult = DialogResult.OK;

        }
    }
}

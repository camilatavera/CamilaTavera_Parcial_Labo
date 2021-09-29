using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FrmSelectStock : FrmBase
    {
        public FrmSelectStock()
        {
            InitializeComponent();
        }

        private void btn_farmacia_Click(object sender, EventArgs e)
        {
            FrmStockFarmacia frmFarmacia = new FrmStockFarmacia();
            frmFarmacia.Show();
            this.Close();
        }
    }
}

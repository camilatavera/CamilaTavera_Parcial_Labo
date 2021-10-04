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

        private void btn_limpieza_Click(object sender, EventArgs e)
        {
            FrmStockLimpieza frmLimpieza = new FrmStockLimpieza();
            frmLimpieza.Show();
            this.Close();

        }

        private void txt_alimentos_Click(object sender, EventArgs e)
        {
            FrmStockAlimento frmAlimentos = new FrmStockAlimento();
            frmAlimentos.Show();
            this.Close();
        }

        private void btn_juguetes_Click(object sender, EventArgs e)
        {
            FrmStockJuguete frmJuguetes = new FrmStockJuguete();
            frmJuguetes.Show();
            this.Close();

        }

        private void btn_camas_Click(object sender, EventArgs e)
        {
            FrmStockCama frmCamas= new FrmStockCama();
            frmCamas.Show();
            this.Close();
        }
    }
}

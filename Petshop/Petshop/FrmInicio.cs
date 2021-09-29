using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmInicio : FrmBase
    {

        static Empleado usuarioActual;
        static bool EsAdmin;
        public FrmInicio()
        {
            InitializeComponent();
        }

        public static Empleado UsuarioActual
        {
            set { usuarioActual = value; }
            get { return usuarioActual; }
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            FrmSelectStock frmSelect = new FrmSelectStock();
            frmSelect.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            FrmVender frmVender = new FrmVender();
            frmVender.Show();
        }
    }
}

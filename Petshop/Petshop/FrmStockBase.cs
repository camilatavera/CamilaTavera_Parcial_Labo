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
    public partial class FrmStockBase : FrmBase
    {

        protected static int indexRow;
        protected static int idActual;

        protected int IndexRow
        {
            get { return indexRow; }
            set { indexRow = value; }

        }

        protected int IdActual
        {
            get { return idActual; }
            set { idActual = value; }

        }

        public FrmStockBase()
        {
            InitializeComponent();
        }

      

        protected virtual void btn_agregar_Click(object sender, EventArgs e)
        {


            this.txt_producto.Text = "";
            this.num_precio.Value = 0;
            this.num_cantidad.Value = 0;
            this.cmb_mascota.SelectedIndex = -1;
            this.cmb_extra.SelectedIndex = -1;
            this.checkBox1.Checked = false;

        }

        


        
    }
}

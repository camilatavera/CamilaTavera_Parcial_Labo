using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmFacturacion : FrmBase
    {   
        static int idVenta;
        public FrmFacturacion(int id_venta)
        {
            InitializeComponent();
            IdVenta = id_venta;
        }

        public int IdVenta
        {
            set { idVenta = value; }
            get { return idVenta; }
        }


        /// <summary>
        /// Muestra los detalles de facturacion en un text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            
            Venta aux = IdVenta;
            this.txt_factura.Text = aux.mostrarDetalle();
        }

        /// <summary>
        /// Importa los detalles de la facturacion en un archivo txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter($"Factura{IdVenta}.txt");
            writer.WriteLine(this.txt_factura.Text);
            writer.Close();
            FrmInicio.playerBeep.Play();
            this.Close();

        }
    }
}

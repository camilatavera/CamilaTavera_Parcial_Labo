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
    public partial class FrmVentas : FrmBase
    {
        static int indexRow;
        static int idActual;

        public FrmVentas()
        {
            InitializeComponent();
        }



        public int IndexRow
        {
            get { return indexRow; }
            set { indexRow = value; }

        }

        public int IdActual
        {
            get { return idActual; }
            set { idActual = value; }
        }



        /// <summary>
        /// carga los datos de las ventas en el data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            Venta auxVenta;

            for (int i = 0; i < Negocio.cantidadVentas(); i++)
            {
                auxVenta = Negocio.ListVentas[i];
                this.dgv_ventas.Rows.Add(auxVenta.IdVenta, auxVenta.Fecha, auxVenta.PrecioTotal,
                    auxVenta.Vendedor.Nombre, auxVenta.IdComprador);
            }
        }


        /// <summary>
        /// si corresponde le da un nuevo valor al atributo estatico idActual con el id de la venta seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexRow = e.RowIndex;
           
            if (dgv_ventas[col_idVenta.Index, IndexRow].Value == null)
            {
                IdActual = 0;
            }
            else
            {
                IdActual=(int)dgv_ventas[col_idVenta.Index, IndexRow].Value;
            }

        }


        /// <summary>
        /// Abre un neuvo form pasandole como parametro el id de la venta seleccionada en el data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_verFactura_Click(object sender, EventArgs e)
        {
            if (IdActual != 0)
            {
                FrmFacturacion frmFactura = new FrmFacturacion(IdActual); ;
                frmFactura.Show();
            }
        }


    }
}


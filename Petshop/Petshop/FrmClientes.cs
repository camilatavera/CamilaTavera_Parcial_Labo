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
    public partial class FrmClientes : FrmBasePersona

    {

        static int indexRow;
        static int idActual;
        public FrmClientes()
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
        
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Cliente clienteAux;
            for (int i = 0; i < Negocio.ListClientes.Count(); i++)
            {
                clienteAux = Negocio.ListClientes[i];
                this.dgv_clientes.Rows.Add(clienteAux.Id, clienteAux.Nombre, clienteAux.Apellido,
                    clienteAux.CantidadCompras, clienteAux.PlataDisponible);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            list_pedidos.Clear();
            Cliente clienteActual;

            IndexRow = e.RowIndex;
            Venta auxVenta;
            ListViewItem lista;
            if (dgv_clientes[col_id.Index, indexRow].Value != null)
            {
                IdActual = (int)dgv_clientes[col_id.Index, indexRow].Value;

                clienteActual = Negocio.buscarCliente(IdActual);

                this.txt_nombre.Text = clienteActual.Nombre;
                this.txt_apellido.Text = clienteActual.Apellido;
                this.txt_telefono.Text = clienteActual.Telefono.ToString();
                this.box_fecha.Value = clienteActual.FechaNacimiento;
                this.num_plataDisponible.Value = (decimal)clienteActual.PlataDisponible;

                for(int i=0; i < Negocio.ListVentas.Count; i++)
                {
                    auxVenta = Negocio.ListVentas[i];
                    if (auxVenta.IdComprador == IdActual)
                    {
                        lista = new ListViewItem(auxVenta.IdVenta.ToString());
                        lista.SubItems.Add(auxVenta.Fecha.ToString());
                        lista.SubItems.Add(auxVenta.PrecioTotal.ToString());
                        list_pedidos.Items.Add(lista);
                    }

                }
                
            }

        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            IndexRow = dgv_clientes.Rows.Count - 1;

            this.txt_nombre.Text = "";
            this.txt_apellido.Text = "";
            this.txt_telefono.Text = "";
            //this.box_fecha.Value;
            this.num_plataDisponible.Value = 0;
            list_pedidos.Clear();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            long telefono;
            DateTime fecha = box_fecha.Value;
            int plataDisponible = (int)num_plataDisponible.Value;

            Cliente auxCliente;


            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(nombre) && 
                long.TryParse(txt_telefono.Text, out telefono) && plataDisponible > 0)
            {
                
                if (IndexRow == dgv_clientes.Rows.Count - 1)
                {
                    auxCliente = new Cliente(nombre, apellido, telefono, fecha, plataDisponible);
                    Negocio.agregarCliente(auxCliente);
                }
                else
                {
                    auxCliente = Negocio.buscarCliente(IdActual);
                    if (auxCliente != null)
                    {
                        auxCliente.EditarCliente(nombre, apellido, telefono, fecha, plataDisponible);
                    }
                }
            }

            

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if(IndexRow != dgv_productos.RowCount - 1)
            {
                
            }
        }
    }
}

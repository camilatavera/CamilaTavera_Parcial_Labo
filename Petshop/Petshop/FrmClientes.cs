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

        
        public FrmClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargo los clientes en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cargo los datos de la fila seleccionada en los text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            list_pedidos.Items.Clear();
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

        /// <summary>
        /// Permite agregar un nuevo cliente y vacia los text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            IndexRow = dgv_clientes.Rows.Count - 1;
            IdActual = 0;

            this.txt_nombre.Text = "";
            this.txt_apellido.Text = "";
            this.txt_telefono.Text = "";
            //this.box_fecha.Value;
            this.num_plataDisponible.Value = 0;
            list_pedidos.Items.Clear();
        }


        /// <summary>
        /// Si se apreto el boton agregar cliente, crea un nuevo cliente
        /// sino edita los valores del cliente seleccionado en el data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                
                if (IdActual==0)
                {
                    auxCliente = new Cliente(nombre, apellido, telefono, fecha, plataDisponible);
                    Negocio.agregarCliente(auxCliente);
                    dgv_clientes.Rows.Add(auxCliente.Id, auxCliente.Nombre, auxCliente.Apellido, auxCliente.CantidadCompras,
                        auxCliente.PlataDisponible);

                    FrmInicio.playerBeep.Play();
                }
                else
                {
                    auxCliente = Negocio.buscarCliente(IdActual);
                    if (auxCliente != null)
                    {
                        auxCliente.EditarCliente(nombre, apellido, telefono, fecha, plataDisponible);
                        dgv_clientes.Rows.Insert(IndexRow, auxCliente.Id, auxCliente.Nombre, auxCliente.Apellido, auxCliente.CantidadCompras,
                        auxCliente.PlataDisponible);

                        FrmInicio.playerBeep.Play();
                    }
                }
            }
            else
            {
                FrmInicio.playerError.Play();
            }

        }

      
    }
}

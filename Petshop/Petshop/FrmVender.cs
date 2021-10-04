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
using System.Media;

namespace PetShop
{
    public partial class FrmVender : FrmBase
    {
        static List<Producto> copyStock;
        static Stack<Pedido> pedidoActual;
        static List<Pedido> pedido_final;
        static int total;
        static int indexRow;

        SoundPlayer Player = new SoundPlayer();
        public FrmVender()
        {
            InitializeComponent();
            
        }

        static FrmVender()
        {
            copyStock = new List<Producto>(Negocio.ListProductos);
            pedidoActual = new Stack<Pedido>();
            pedido_final = new List<Pedido>();
            

        }


        public static Stack<Pedido> PedidoActual
        {
            get { return pedidoActual; }
        }

        public static int Total
        {
            get { return total; }
            set { total = value; }
        }

       

        public static List<Producto> CopyStock
        {
            get { return copyStock; }
        }

        public int IndexRow
        {
            get { return indexRow; }
            set { indexRow = value; }

        }

        /// <summary>
        /// Si se dan las condiciones, me abre un nuevo carrito para agregar un pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FrmInicio.playerError.Play();
            Pedido pedidoIngresado;
            

            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.ShowDialog();
            
            if (frmCarrito.DialogResult == DialogResult.OK)
            {
                
                pedidoIngresado = pedidoActual.Peek();

                this.dgv_carrito.Rows.Add(pedidoIngresado.ProductoComprado.Nombre, pedidoIngresado.Cantidad,
                    pedidoIngresado.Precio);

               //Total = pedidoIngresado.Precio; lo agrego a carrito
                txt_monto.Text = Total.ToString();
                IndexRow = dgv_carrito.CurrentRow.Index;
                

                frmCarrito.Close();
                


            }

            else if (frmCarrito.DialogResult == DialogResult.Cancel)
            {
                frmCarrito.Close();
                
            }
        }

        /// <summary>
        /// Borra un pedido del data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            
            Producto productoEnCopy;
           
            if (IndexRow != dgv_carrito.RowCount - 1)
            {

                for (int i = 0; i < FrmVender.CopyStock.Count; i++)
                {
                    productoEnCopy = FrmVender.CopyStock[i];
                    if (productoEnCopy.Nombre == dgv_carrito[col_producto.Index, IndexRow].Value.ToString())
                    {
                        productoEnCopy.Cantidad += (int)dgv_carrito[col_cantidad.Index, IndexRow].Value;
                    }
                }
                Total -= (int)dgv_carrito[col_precio.Index, IndexRow].Value;
                dgv_carrito.Rows.RemoveAt(IndexRow);
                this.txt_monto.Text = Total.ToString();

            }

            else if (dgv_carrito.CurrentRow.Index != dgv_carrito.RowCount - 1)
            {
                IndexRow = dgv_carrito.CurrentRow.Index;
            }
        }


        /// <summary>
        /// carga los clientes en el combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVender_Load(object sender, EventArgs e)
        {
            Cliente aux;
            for(int i=0; i<Negocio.ListClientes.Count; i++)
            {
                aux = Negocio.ListClientes[i];
                this.cmb_cliente.Items.Add(aux.Nombre);
            }
        }


        /// <summary>
        /// Cuando se selecciona un cliente, se evalua si le alcanza la plata y si es asi se habilita el
        /// boton "Vender"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente comprador = Negocio.buscarClientePorNombre(cmb_cliente.SelectedItem.ToString());
            if(comprador!=null && comprador.PlataDisponible >= Total)
            {
                btn_vender.Enabled = true;
            }


            
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {

            Pedido finalAux;
            Producto prodAux;
            int cantidad;
            Venta NuevaVenta;
            Cliente comprador = Negocio.buscarClientePorNombre(cmb_cliente.SelectedItem.ToString());

            if (comprador != null)
            {

                for (int i = 0; i < dgv_carrito.RowCount; i++)
                {
                    if (dgv_carrito[col_producto.Index, i].Value != null)
                    {
                        prodAux = Negocio.buscarProductoPorNombre(dgv_carrito[col_producto.Index, i].Value.ToString());
                        cantidad = (int)dgv_carrito[col_cantidad.Index, i].Value;
                        finalAux = new Pedido(prodAux, cantidad);
                        prodAux.Cantidad = prodAux - cantidad;
                        pedido_final.Add(finalAux);

                    }
                }
                NuevaVenta = pedido_final;
                NuevaVenta.agregarVendedorComprador(comprador.Id, FrmInicio.UsuarioActual);
                FrmInicio.playerBeep.Play();
                this.Close();

            }

        }

       
    }
}

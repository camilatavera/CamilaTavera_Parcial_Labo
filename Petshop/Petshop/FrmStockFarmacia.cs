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
    public partial class FrmStockFarmacia : FrmStockBase
    {
        public FrmStockFarmacia()
        {
            InitializeComponent();
        }

        static int indexRow;
        static int idActual;

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

        private void FrmStockFarmacia_Load(object sender, EventArgs e)
        {
            
            Producto prodAux;
            IdActual = 0;


            for (int i = 0; i < Negocio.ListProductos.Count(); i++)
            {
                prodAux = Negocio.ListProductos[i];
                if(prodAux is Farmacia)
                {
                this.dgv_productos.Rows.Add(prodAux.Id, prodAux.Nombre, prodAux.Cantidad,
                prodAux.Precio);
                }
            }

            this.cmb_mascota.DataSource = Enum.GetValues(typeof(Mascota));
            this.cmb_extra.DataSource = Enum.GetValues(typeof(TipoRemedio));
            
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Producto actualProducto;
        
            IndexRow = e.RowIndex;
            if (dgv_productos[col_id.Index, indexRow].Value != null)
            {
                IdActual = (int)dgv_productos[col_id.Index, indexRow].Value;

                actualProducto = Negocio.buscarProducto(IdActual);

                this.txt_producto.Text = actualProducto.Nombre;
                this.num_precio.Value = (decimal)actualProducto.Precio;
                this.num_cantidad.Value = (decimal)actualProducto.Cantidad;
                this.cmb_mascota.SelectedItem = actualProducto.ParaMascota;
                this.cmb_extra.SelectedItem = ((Farmacia)actualProducto).FormaRemedio;
                this.checkBox1.Checked = ((Farmacia)actualProducto).BajoReceta;
            }
            
            
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            
            if (IndexRow != dgv_productos.RowCount-1)
            {
                Negocio.borrarProductoDeStock(IdActual);
                dgv_productos.Rows.RemoveAt(IndexRow);
            }
            Producto actualProducto;
            if(dgv_productos.CurrentRow.Index != dgv_productos.RowCount - 1)
            {
                IdActual = (int)dgv_productos[col_id.Index, dgv_productos.CurrentRow.Index].Value;
                actualProducto = Negocio.buscarProducto(IdActual);

                this.txt_producto.Text = actualProducto.Nombre.ToString();
                this.num_precio.Value = (decimal)actualProducto.Precio;
                this.num_cantidad.Value = (decimal)actualProducto.Cantidad;
                this.cmb_mascota.SelectedItem = actualProducto.ParaMascota;
                this.cmb_extra.SelectedItem = ((Farmacia)actualProducto).FormaRemedio;
                this.checkBox1.Checked = ((Farmacia)actualProducto).BajoReceta;

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.txt_producto.Text = "";
            this.num_precio.Value = 0;
            this.num_cantidad.Value = 0;
            this.cmb_mascota.SelectedIndex = -1; 
            this.cmb_extra.SelectedIndex = -1;
            this.checkBox1.Checked = false;

            IndexRow = dgv_productos.RowCount - 1;

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {

            Farmacia nuevoProd;
            string nombre = txt_producto.Text;
            int precio = (int)num_precio.Value;
            int cantidad = (int)num_cantidad.Value;
            Mascota paraMascota = (Mascota)this.cmb_mascota.SelectedItem;
            TipoRemedio formaRemedio = (TipoRemedio)this.cmb_extra.SelectedItem;
            bool bajoReceta=checkBox1.Checked;

            Producto prodEditado;


            if(!string.IsNullOrEmpty(nombre) && precio>0 && cantidad > 0)
            {

                nuevoProd = new Farmacia(nombre, precio, cantidad, paraMascota, bajoReceta, formaRemedio);
                if (IndexRow == dgv_productos.RowCount - 1)
                {
                    
                    Negocio.agregarProducto(nuevoProd);
                    this.dgv_productos.Rows.Add(nuevoProd.Id, nuevoProd.Nombre, nuevoProd.Cantidad, nuevoProd.Precio);
                }
                else
                {

                    prodEditado = nuevoProd.editarProducto(IdActual);
                    this.dgv_productos.Rows.RemoveAt(IndexRow);
                    this.dgv_productos.Rows.Insert(IndexRow, prodEditado.Id, prodEditado.Nombre,
                        prodEditado.Cantidad, prodEditado.Precio);
                    
                }
            }
        }
    }
}

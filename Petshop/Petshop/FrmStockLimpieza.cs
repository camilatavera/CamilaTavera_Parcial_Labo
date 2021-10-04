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
    public partial class FrmStockLimpieza : FrmStockBase
    {

        public FrmStockLimpieza()
        {
            InitializeComponent();
        }

        
        

        private void FrmStockLimpieza_Load(object sender, EventArgs e)
        {
            Producto prodAux;
            IdActual = 0;


            for (int i = 0; i < Negocio.ListProductos.Count(); i++)
            {
                prodAux = Negocio.ListProductos[i];
                if (prodAux is Farmacia)
                {
                    this.dgv_productos.Rows.Add(prodAux.Id, prodAux.Nombre, prodAux.Cantidad,
                    prodAux.Precio);
                }
            }

            this.cmb_mascota.DataSource = Enum.GetValues(typeof(Mascota));
            this.cmb_extra.DataSource = Enum.GetValues(typeof(TipoLimpieza));

        }

        private void btn_stock_Click(object sender, EventArgs e)
        {

            Limpieza nuevoProd;
            string nombre = txt_producto.Text;
            int precio = (int)num_precio.Value;
            int cantidad = (int)num_cantidad.Value;
            Mascota paraMascota = (Mascota)this.cmb_mascota.SelectedItem;
            TipoLimpieza tipoLimpieza = (TipoLimpieza)this.cmb_extra.SelectedItem;
            bool EsHipoalergenico = checkBox1.Checked;

            Producto prodEditado;


            if (!string.IsNullOrEmpty(nombre) && precio > 0 && cantidad > 0)
            {

                nuevoProd = new Limpieza(nombre, precio, cantidad, paraMascota, EsHipoalergenico, tipoLimpieza);
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
                FrmInicio.playerBeep.Play();
            }
            else
            {
                FrmInicio.playerError.Play();
            }
        }
        

    

        protected override void btn_agregar_Click(object sender, EventArgs e)
        {
            base.btn_agregar_Click(sender, e);
            IndexRow = dgv_productos.RowCount - 1;

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

            Producto actualProducto;
            if (IdActual != 0)
            {
                Negocio.borrarProductoDeStock(IdActual);
                dgv_productos.Rows.RemoveAt(IndexRow);

                IndexRow = dgv_productos.CurrentRow.Index;

                if (dgv_productos[col_id.Index, IndexRow].Value == null)
                {
                    IdActual = 0;
                }
                else
                {
                    IdActual = (int)dgv_productos[col_id.Index, IndexRow].Value;
                    actualProducto = IdActual;
                    if (actualProducto != null)
                    {
                        this.txt_producto.Text = actualProducto.Nombre.ToString();
                        this.num_precio.Value = (decimal)actualProducto.Precio;
                        this.num_cantidad.Value = (decimal)actualProducto.Cantidad;
                        this.cmb_mascota.SelectedItem = actualProducto.ParaMascota;
                        this.cmb_extra.SelectedItem = ((Limpieza)actualProducto).TipoDeLimpieza;
                        this.checkBox1.Checked = ((Limpieza)actualProducto).EsHipoalergenico;
                    }
                }
            }

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
                this.cmb_extra.SelectedItem = ((Limpieza)actualProducto).TipoDeLimpieza;
                this.checkBox1.Checked = ((Limpieza)actualProducto).EsHipoalergenico;
            }
            else
            {
                IdActual = 0;
                this.txt_producto.Text = "";
                this.num_precio.Value = 0;
                this.num_cantidad.Value = 0;
                this.cmb_mascota.SelectedIndex = -1;
                this.cmb_extra.SelectedIndex = -1;
                this.checkBox1.Checked = false;
            }

        }
    }
}

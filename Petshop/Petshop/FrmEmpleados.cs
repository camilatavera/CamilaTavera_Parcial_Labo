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
    public partial class FrmEmpleados : FrmBasePersona
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// carga los datos de los empleados en el DataGridView e invisibiliza los campos que son para crear uno nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            lbl_pswd.Visible = false;
            txt_pswd.Visible = false;
            cbox_cargo.Visible = false;

            Empleado auxEmpelado;
            for (int i = 0; i < Negocio.ListEmpleados.Count(); i++)
            {
                auxEmpelado = Negocio.ListEmpleados[i];
                this.dgv_empleados.Rows.Add(auxEmpelado.Id, auxEmpelado.Apellido,
                    auxEmpelado.Cargo(), auxEmpelado.calcularCantidadVentas());
            }


        }


        /// <summary>
        /// Cargo los datos de la fila seleccionada en los text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_pswd.Visible = false;
            txt_pswd.Visible = false;
            cbox_cargo.Visible = true;


            list_ventas.Items.Clear();
            Empleado empleadoActual;

            IndexRow = e.RowIndex;
            Venta auxVenta;
            ListViewItem lista;
            if (dgv_empleados[col_id.Index, indexRow].Value != null)
            {
                IdActual = (int)dgv_empleados[col_id.Index, indexRow].Value;

                empleadoActual = Negocio.buscarEmpleado(IdActual);

                this.txt_nombre.Text = empleadoActual.Nombre;
                this.txt_apellido.Text = empleadoActual.Apellido;
                this.txt_telefono.Text = empleadoActual.Telefono.ToString();
                this.box_fecha.Value = empleadoActual.FechaNacimiento;
                this.txt_usuario.Text = empleadoActual.User;

                for (int i = 0; i < Negocio.ListVentas.Count; i++)
                {
                    auxVenta = Negocio.ListVentas[i];
                    if (auxVenta.Vendedor==empleadoActual)
                    {
                        lista = new ListViewItem(auxVenta.IdVenta.ToString());
                        lista.SubItems.Add(auxVenta.Fecha.ToString());
                        lista.SubItems.Add(auxVenta.PrecioTotal.ToString());
                        list_ventas.Items.Add(lista);
                    }

                }

            }
        }


        /// <summary>
        /// Permite agregar un nuevo empleado, vacia los text box y le da a visibilidad a algunos controles necesarios
        /// para la carga de datos correcta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            lbl_pswd.Visible = true;
            txt_pswd.Visible = true;
            cbox_cargo.Visible = true;


            IndexRow = dgv_empleados.Rows.Count - 1;
            IdActual = 0;

            this.txt_nombre.Text = "";
            this.txt_apellido.Text = "";
            this.txt_telefono.Text = "";
            this.txt_pswd.Text = "";
            this.txt_usuario.Text = "";
            
            list_ventas.Items.Clear();
        }


        /// <summary>
        /// Si se apreto el boton agregar , crea un nuevo empleado
        /// sino edita los valores del empleado seleccionado en el data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stock_Click(object sender, EventArgs e)
        {
            Empleado nuevo;
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string usuario = txt_usuario.Text;
            long telefono;
            DateTime fecha = box_fecha.Value;
            string pswd;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) &&
                long.TryParse(txt_telefono.Text, out telefono) && !string.IsNullOrEmpty(usuario))
            {
                pswd=txt_pswd.Text;
                if (IdActual != 0 && !string.IsNullOrEmpty(pswd))
                {
                    if (cbox_cargo.Checked)
                    {
                        nuevo = new Administrador(nombre, apellido, telefono, fecha, usuario, pswd);
                    }
                    else
                    {
                        nuevo = new Empleado(nombre, apellido, telefono, fecha, usuario, pswd);
                    }
                    dgv_empleados.Rows.Add(nuevo.Id, nuevo.Apellido, nuevo.Cargo(), nuevo.calcularCantidadVentas());
                    FrmInicio.playerBeep.Play();


                }
                else
                {
                    nuevo = Negocio.buscarEmpleado(IdActual);
                    nuevo = nuevo.editarEmpleado(nombre, apellido, telefono, fecha, usuario);
                    this.dgv_empleados.Rows.RemoveAt(IndexRow);
                    this.dgv_empleados.Rows.Insert(IndexRow, nuevo.Id, nuevo.Apellido,
                        nuevo.Cargo(), nuevo.calcularCantidadVentas());
                }
            }
            else
            {
                FrmInicio.playerError.Play();
            }
        }

        
        /// <summary>
        ///Borra el empleado seleccionado en el data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            IndexRow = dgv_empleados.CurrentRow.Index;
            IdActual = (int)dgv_empleados[col_id.Index, IndexRow].Value;
            Negocio.borrarEmpleado(IdActual);
            dgv_empleados.Rows.RemoveAt(IndexRow);

        }

       
    }
}

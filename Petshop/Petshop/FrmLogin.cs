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
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Empleado ingresante;
            FrmInicio paginaInicio;
            string user = txt_usuario.Text;
            string pswd = txt_pswd.Text;
            ingresante = Negocio.validarIngreso2(user, pswd);
            if(ingresante!=null)
            {
                paginaInicio = new FrmInicio(ingresante);
                paginaInicio.ShowDialog();
                paginaInicio.Close();
            }
          

        }

        /// <summary>
        /// Me permite iniciar sesion en modo Administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Empleado empleado in Negocio.ListEmpleados)
            {
                if(empleado is Administrador)
                {
                    txt_usuario.Text = empleado.User;
                    txt_pswd.Text = empleado.Password;
                    break;
                }
            }
        }

        /// <summary>
        /// Me permite iniciar sesion en modo Empleado (No administrador)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_empleado_Click(object sender, EventArgs e)
        {
            foreach (Empleado empleado in Negocio.ListEmpleados)
            {
                if (empleado is not Administrador)
                {
                    txt_usuario.Text = empleado.User;
                    txt_pswd.Text = empleado.Password;
                    break;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;

namespace PetShop
{
    public partial class FrmInicio : FrmBase
    {
        public static SoundPlayer playerError;
        public static SoundPlayer playerBeep;


        static Empleado usuarioActual;
        static bool esAdmin;
        public FrmInicio(Empleado empleadoLogin) //Empleado empleado)
        {
            InitializeComponent();
            playerError = new SoundPlayer();
            playerBeep = new SoundPlayer();
            playerBeep.SoundLocation = @"C:\PARCIAL_LABO_ii\parcial_labo_ii_CamilaTavera\PetShop\sounds\Boop.wav";
            playerError.SoundLocation = @"C:\PARCIAL_LABO_ii\parcial_labo_ii_CamilaTavera\PetShop\sounds\Windows_error.wav";

            usuario(empleadoLogin);

        }

        public static Empleado UsuarioActual
        {
            get { return usuarioActual; }
        }

        public static bool EsAdmin
        {
            get { return esAdmin; }
        }

        /// <summary>
        /// Le da valores a los atributos estaticos 
        /// </summary>
        /// <param name="empleado"></param>
        private static void usuario(Empleado empleado)
        {
            usuarioActual = empleado;
            if(empleado is Administrador)
            {
                esAdmin = true;
            }
            else
            {
                esAdmin = false;
            }
        }

        /// <summary>
        /// Evalua el atributo estatico esAdmin y dependiendo de eso, llena los campos, y le da visibilidad a los botones correspondientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInicio_Load(object sender, EventArgs e)
        {
           

            txt_user.Text = UsuarioActual.Nombre;

            txt_nombre.Text = Negocio.Nombre;
            txt_direc.Text = Negocio.Direccion;
            if (EsAdmin == true)
            {
                txt_tipoUser.Text = "ADMIN";
               
            }
            else
            {
                txt_tipoUser.Text = "NO ES ADMIN";
                btn_ventas.Visible = false;
                btn_empleados.Visible = false;
                this.BackColor = Color.Coral ;
                panel_barra.BackColor=Color.FromArgb(26, 32, 40);
                btn_vender.ForeColor= Color.FromArgb(26, 32, 40);
                btn_vender.BackColor = Color.Coral;
                btn_stock.ForeColor = Color.FromArgb(26, 32, 40);
                btn_clientes.ForeColor = Color.FromArgb(26, 32, 40);

                lbl_bienvenida.ForeColor = Color.FromArgb(26, 32, 40);
                txt_user.ForeColor = Color.FromArgb(26, 32, 40);
                txt_tipoUser.ForeColor = Color.FromArgb(26, 32, 40);
                txt_nombre.ForeColor = Color.FromArgb(26, 32, 40);
                txt_direc.ForeColor = Color.FromArgb(26, 32, 40);

                lbl_bienvenida.BackColor = Color.Coral;
                txt_user.BackColor = Color.Coral;
                txt_tipoUser.BackColor = Color.Coral;
                txt_nombre.BackColor = Color.Coral;
                txt_direc.BackColor = Color.Coral;






            }

  

        }


        private void btn_stock_Click(object sender, EventArgs e)
        {
            FrmSelectStock frmSelect = new FrmSelectStock();
            frmSelect.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            FrmVender frmVender = new FrmVender();
            frmVender.Show();
            
        }

       

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.Show();
        }

        protected override void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void time_hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void lbl_hora_Click(object sender, EventArgs e)
        {

        }
    }
}

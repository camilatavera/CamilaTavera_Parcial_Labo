using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        int id;
        string user;
        string password;
               

        static int idIncremental;


        /// <summary>
        /// Inicializacion del atributo static idIncremental en 0
        /// </summary>
        static Empleado()
        {
            idIncremental = 0;
        }


        /// <summary>
        /// get y set del atributo idIncremental
        /// </summary>
        protected override int IdIncremental
        {
            get { return idIncremental; }
            set { idIncremental = value; }
        }


        /// <summary>
        /// Incrementa un digito el atributo estatico idIncremental
        /// </summary>
        /// <returns>valor del atributo estatico IdIncremental</returns>
        protected override int getNuevoId()
        {
            IdIncremental += 1;
            return IdIncremental;
        }


        /// <summary>
        /// get del atributo id
        /// </summary>
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public Empleado(string nombre, string apellido, long telefono, DateTime fechaNacimiento,
            string user, string password)
             : base(nombre, apellido, telefono, fechaNacimiento)
        {
            this.Id = getNuevoId();
            this.User = user;
            this.Password = password;
           
        }

        #region get/set


        /// <summary>
        /// get y set del atributo user
        /// </summary>
        public string User
        {

            set
            {
                if (!value.Contains(" "))
                {
                    user = value;
                }
            }
            get { return user; }
        }


        /// <summary>
        /// get y set del atributo password
        /// </summary>
        public string Password
        {
            set
            {
                password = value.Trim();
            }
            get { return password; }

        }
        #endregion



        /// <summary>
        /// Muestra los detalles del empleado
        /// </summary>
        /// <returns>string con los detalles</returns>
        public override string mostrarDetalleFacturacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS VENDEDOR");
            sb.AppendLine("------------------------------------------ \n");
            sb.AppendLine(base.mostrarDetalleFacturacion());

            return sb.ToString();
        }


        /// <summary>
        /// Devuelve el cargo del objeto segun como se instancio
        /// </summary>
        /// <returns>string cargo</returns>
        public virtual string Cargo()
        {
            return "Empleado";
        }


        /// <summary>
        /// Calcula el sueldo del objeto segun como se instancio
        /// </summary>
        /// <returns>float sueldo</returns>
        public virtual float CalcularSueldo()
        {
            int cant = calcularCantidadVentas();
            float sueldo = 10000f;

            if (cant >= 2)
            {
                sueldo += 2000;
            }
            return sueldo;
        }


        /// <summary>
        /// Calcula la cantidad de ventas que realizo el vendedor
        /// </summary>
        /// <returns></returns>
        public int calcularCantidadVentas()
        {
            Venta ventaAux;
            int cont = 0;
            for (int i = 0; i < Negocio.ListVentas.Count; i++)
            {
                ventaAux = Negocio.ListVentas[i];
                if (ventaAux.Vendedor == this)
                {
                    cont++;
                }
            }
            return cont;
        }

      


        /// <summary>
        /// Agrega un cliente a la lista
        /// </summary>
        /// <param name="nuevoCliente"></param>
        /// <returns>La lista con todos los clientes</returns>
        public List<Cliente> agregarCliente(Cliente nuevoCliente)
        {
            if (nuevoCliente != null)
                Negocio.ListClientes.Add(nuevoCliente);

            return Negocio.ListClientes;
        }


        /// <summary>
        /// Instancia un nuevo cliente y lo agrega a la lista
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="plataDisponible"></param>
        /// <returns>El nuevo cliente</returns>
        public Cliente AltaCliente(string nombre, string apellido, long telefono, DateTime fechaNacimiento, float plataDisponible)
        {
            Cliente auxCliente = new Cliente(nombre, apellido, telefono, fechaNacimiento, plataDisponible);
            Negocio.agregarCliente(auxCliente);
            return auxCliente;
        }

        /// <summary>
        /// busca la lista estatica de clientes
        /// </summary>
        /// <returns>lista de clientes</returns>
        public List<Cliente> verClientes()
        {
            return Negocio.ListClientes;
        }


        /// <summary>
        /// edita los valores del empleado con los valores pasados como parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="plataDisponible"></param>
        public Empleado editarEmpleado(string nombre, string apellido, long telefono, DateTime fechaNacimiento, string user)
        {

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.FechaNacimiento = fechaNacimiento;
            this.User = user;

            return this;
                
            

        }


















    }
}

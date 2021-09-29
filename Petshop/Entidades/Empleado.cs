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
        bool esAdmin;

        static int idIncremental;

        static Empleado()
        {
            idIncremental = 0;
        }

        protected override int IdIncremental
        {
            get { return idIncremental; }
            set { idIncremental = value; }
        }

        protected override int getNuevoId()
        {
            IdIncremental += 1;
            return IdIncremental;
        }

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
            this.EsAdmin = false;

        }

        #region get/set


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

        public string Password
        {
            set
            {
                if (!value.Contains(" "))
                {
                    password = value;
                }
            }
            get { return password; }

        }
        public bool EsAdmin
        {
            set { esAdmin = value; }
            get { return esAdmin; }

        }








        #endregion

        public override string Mostrar()
        {
            return "Seguir";
        }

        public virtual string EsAdminStr()
        {
            return "No";
        }

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

        //NOOOOOOOOOOO, es del admin
        //public List<Empleado> agregarEmpleado(Empleado auxEmpleado)
        //{
        //    Negocio.agregarEmpleado(auxEmpleado);
        //    return Negocio.ListEmpleados;
        //}

        public bool validarPassword(string password)
        {

            if (this.password == password)
            {
                return true;
            }
            else
                return false;

        }





        public List<Cliente> agregarCliente(Cliente nuevoCliente)
        {
            if (nuevoCliente != null)
                Negocio.ListClientes.Add(nuevoCliente);

            return Negocio.ListClientes;
        }

        public Cliente AltaCliente(string nombre, string apellido, long telefono, DateTime fechaNacimiento, float plataDisponible)
        {
            Cliente auxCliente = new Cliente(nombre, apellido, telefono, fechaNacimiento, plataDisponible);
            Negocio.agregarCliente(auxCliente);
            return auxCliente;
        }

        public List<Cliente> verClientes()
        {
            return Negocio.ListClientes;
        }

        //public static bool operator ==(Empleado empleado1, Empleado empleado2)
        //{
        //    if (empleado1 == null || empleado2 == null)
        //        return false;
        //    if(empleado1.id == empleado2.id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool static operator !=(Empleado empleado1, Empleado empleado2)
        //{
        //    return !(empleado1 == empleado2);
        //}

      

















    }
}

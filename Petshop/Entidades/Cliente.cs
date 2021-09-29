using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        static int idIncremental;

        int id;
        float plataDisponible;
        int cantidadCompras;


        public Cliente(string nombre, string apellido, long telefono, DateTime fechaNacimiento, float plataDisponible) :
            base(nombre, apellido, telefono, fechaNacimiento)

        {
            this.id = getNuevoId();
            this.PlataDisponible = plataDisponible;
            //this.listCompras = null; ;
            this.cantidadCompras = 0;
        }


        static Cliente()
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
            get { return id; }
        }


        public override string Mostrar()
        {
            return "Cliente toy";
        }

        #region set, get


        public float PlataDisponible
        {
            set
            {
                if (value >= 0)
                {
                    plataDisponible = value;
                }
            }
            get { return plataDisponible; }
        }

        //public List<Venta> ListCompras
        //{
        //    set
        //    {
        //        if (value != null)
        //        { listCompras = value; }
        //    }
        //    get { return listCompras; }
        //}

        public int CantidadCompras
        {
            get { return cantidadCompras; }
            set { cantidadCompras = value; }
        }

        #endregion

        public int AgregarVenta()
        {
            this.CantidadCompras += 1;
            return this.CantidadCompras;
        }

        public void EditarCliente(string nombre, string apellido, long telefono, DateTime fechaNacimiento, float plataDisponible)
        {
            
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.FechaNacimiento = fechaNacimiento;
            this.PlataDisponible = plataDisponible;

        }

        
    }
}

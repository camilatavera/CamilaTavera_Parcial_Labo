using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected long telefono;
        protected DateTime fechaNacimiento;


        public Persona(string nombre, string apellido, long telefono, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.FechaNacimiento = fechaNacimiento;
        }

        protected abstract int IdIncremental { set; get; }
        protected abstract int getNuevoId();


        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }


        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public long Telefono
        {
            set { telefono = value; }
            get { return telefono; }

        }

        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public abstract string Mostrar();


    }
}

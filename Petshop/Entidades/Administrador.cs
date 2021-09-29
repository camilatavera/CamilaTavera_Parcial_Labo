using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {

        public Administrador(string nombre, string apellido, long telefono, DateTime fechaNacimiento,
            string user, string password)
             : base(nombre, apellido, telefono, fechaNacimiento, user, password)
        {
            this.EsAdmin = true;
        }


        public override string EsAdminStr()
        {
            return "Si";
        }

        public override float CalcularSueldo()
        {
            float sueldo = base.CalcularSueldo();
            float bonoAdmin = 1000;
            return sueldo + bonoAdmin;
        }



        public override string Mostrar()
        {
            return "jeje";
        }

        








    }
}

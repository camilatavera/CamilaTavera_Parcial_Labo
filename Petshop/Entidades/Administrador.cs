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
        { }


        /// <summary>
        /// Devuelve el cargo del objeto segun como se instancio
        /// </summary>
        /// <returns>string cargo</returns>
        public override string Cargo()
        {
            return "Administrador";
        }


        /// <summary>
        /// Calcula el sueldo del objeto segun como se instancio
        /// </summary>
        /// <returns>float sueldo</returns>
        public override float CalcularSueldo()
        {
            float sueldo = base.CalcularSueldo();
            float bonoAdmin = 1000;
            return sueldo + bonoAdmin;
        }



     
    }
}

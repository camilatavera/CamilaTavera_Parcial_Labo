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
            this.cantidadCompras = 0;
        }

        /// <summary>
        /// Inicializacion del atributo static idIncremental en 0
        /// </summary>
        static Cliente()
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
            get { return id; }
        }

        /// <summary>
        /// Muestra los detalles del cliente
        /// </summary>
        /// <returns>string con los detalles</returns>
        public override string mostrarDetalleFacturacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS CLIENTE");
            sb.AppendLine("---------------------------------------\n");
            sb.AppendLine(base.mostrarDetalleFacturacion());

            return sb.ToString();
   
        }

        #region set, get

        /// <summary>
        /// get y set del atributo plataDisponible
        /// </summary>
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

       
        /// <summary>
        /// get y set del atributo cantidadCompras
        /// </summary>
        public int CantidadCompras
        {
            get { return cantidadCompras; }
            set { cantidadCompras = value; }
        }

        #endregion

        /// <summary>
        /// Incrementa el atributo cantidadCompras del cliente
        /// </summary>
        /// <returns>int atributo cantidadCompras</returns>
        public int AgregarVenta()
        {
            this.CantidadCompras += 1;
            return this.CantidadCompras;
        }


        /// <summary>
        /// edita los valores del cliente con los valores pasados como parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="plataDisponible"></param>
        public void EditarCliente(string nombre, string apellido, long telefono, DateTime fechaNacimiento, float plataDisponible)
        {
            
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.FechaNacimiento = fechaNacimiento;
            this.PlataDisponible = plataDisponible;

        }


        /// <summary>
        /// Castea int (id del cliente) en un objeto del tipo Cliente
        /// </summary>
        /// <param name="id"></param>
        public static implicit operator Cliente(int id)
        {
            return Negocio.buscarCliente(id);
        }


        /// <summary>
        /// Castea un objeto del tipo Cliente en int(el id del cliente)
        /// </summary>
        /// <param name="cliente"></param>
        public static explicit operator int(Cliente cliente)
        {
            return cliente.id;
        }


    }
}

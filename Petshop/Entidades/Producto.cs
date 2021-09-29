using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        static int idIncremental;

        protected int id;
        protected string nombre;
        protected int precio;
        protected int cantidad;
        protected Mascota paraMascota;

        protected Producto(string nombre, int precio, int cantidad, Mascota paraMascota)
        {
            this.id = getNuevoId();
            this.Nombre = nombre;
            this.Precio = precio;
            this.ParaMascota = paraMascota;
            this.Cantidad = cantidad;

        }

        static Producto()
        {
            idIncremental = 0;
        }

        int IdIncremental
        {
            get { return idIncremental; }
            set { idIncremental = value; }
        }

        int getNuevoId()
        {
            IdIncremental += 1;
            return IdIncremental;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }




        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }


        public int Precio
        {
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
            }
            get
            { return precio; }
        }


        public Mascota ParaMascota
        {
            set { paraMascota = value; }
            get { return paraMascota; }
        }

        public string GetParaMascotaStr()
        {
            return this.ParaMascota.ToString();
        }

        public int Cantidad
        {
            set
            {
                if (value > 0)
                {
                    cantidad = value;
                }
            }
            get
            { return cantidad; }
        }

        public abstract Producto editarProducto(int idAEditar);

        public static int operator +(Producto prod, int cantidad)
        {
            return prod.Cantidad + cantidad;
        }

        public static int operator -(Producto prod, int cantidad)
        {
            return prod.Cantidad - cantidad;
        }

      
    }
}

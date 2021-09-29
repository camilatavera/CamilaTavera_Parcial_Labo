using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Limpieza : Producto
    {

        bool esHipoalergenico;
        TipoLimpieza tipoDeLimpieza;


        public Limpieza(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool esHipoalergenico, TipoLimpieza tipoDeLimpieza) : base(nombre, precio, cantidad, paraMascota)
        {
            this.EsHipoalergenico = esHipoalergenico;
            this.TipoDeLimpieza = tipoDeLimpieza;
        }

        public bool EsHipoalergenico
        {
            get { return esHipoalergenico; }
            set { esHipoalergenico = value; }
        }

        public TipoLimpieza TipoDeLimpieza
        {
            get { return tipoDeLimpieza; }
            set { tipoDeLimpieza = value; }
        }


        public override Producto editarProducto(int idAEditar)
        {
            Producto productoEdit = Negocio.buscarProducto(idAEditar);

            productoEdit.Nombre = this.Nombre;
            productoEdit.Precio = this.Precio;
            productoEdit.Cantidad = this.Cantidad;
            productoEdit.ParaMascota = this.ParaMascota;
            ((Limpieza)productoEdit).TipoDeLimpieza = this.TipoDeLimpieza;
            ((Limpieza)productoEdit).EsHipoalergenico = this.EsHipoalergenico;

            return (Producto)productoEdit;
        }


    }
}

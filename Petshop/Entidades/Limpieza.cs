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


        /// <summary>
        /// get y set del atributo esHipoalergenico
        /// </summary>
        public bool EsHipoalergenico
        {
            get { return esHipoalergenico; }
            set { esHipoalergenico = value; }
        }


        /// <summary>
        /// get y set del atributo tipoDeLimpieza
        /// </summary>
        public TipoLimpieza TipoDeLimpieza
        {
            get { return tipoDeLimpieza; }
            set { tipoDeLimpieza = value; }
        }



        /// <summary>
        /// Busca el producto por el id pasado por parametro y si lo encuentra lo edita con los 
        /// valores del producto con el que se llamo al metodo
        /// <param name="idAEditar"></param>
        /// <returns>el producto editado o null si no se pudo editar</returns>
        public override Producto editarProducto(int idAEditar)
        {
            Producto productoEdit = Negocio.buscarProducto(idAEditar);

            if (productoEdit != null)
            {
                productoEdit.Nombre = this.Nombre;
                productoEdit.Precio = this.Precio;
                productoEdit.Cantidad = this.Cantidad;
                productoEdit.ParaMascota = this.ParaMascota;
                ((Limpieza)productoEdit).TipoDeLimpieza = this.TipoDeLimpieza;
                ((Limpieza)productoEdit).EsHipoalergenico = this.EsHipoalergenico;

                return (Producto)productoEdit;
            }
            return null;
        }


        /// <summary>
        /// muestra los detalles del producto
        /// </summary>
        /// <returns> string con los detalles del producto</returns>
        public override string mostrarDetalleProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PRODUCTO DEL SECTOR LIMPIEZA");
            sb.AppendLine(base.mostrarDetalleProducto());
            return sb.ToString();
        }


    }
}

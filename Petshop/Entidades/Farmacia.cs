using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Farmacia : Producto
    {
        bool bajoReceta;
        TipoRemedio formaRemedio;

        public Farmacia(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool bajoReceta, TipoRemedio formaRemedio) : base(nombre, precio, cantidad, paraMascota)
        {
            this.BajoReceta = bajoReceta;
            this.FormaRemedio = formaRemedio;
        }

        public bool BajoReceta
        {
            get { return bajoReceta; }
            set { bajoReceta = value; }
        }

        public TipoRemedio FormaRemedio
        {
            get { return formaRemedio; }
            set { formaRemedio = value; }
        }

        public override Producto editarProducto(int idAEditar)
        {
            
            Producto productoEdit = Negocio.buscarProducto(idAEditar);

            productoEdit.Nombre = this.Nombre;
            productoEdit.Precio = this.Precio;
            productoEdit.Cantidad = this.Cantidad;
            productoEdit.ParaMascota = this.ParaMascota;
            ((Farmacia)productoEdit).BajoReceta = this.BajoReceta;
            ((Farmacia)productoEdit).BajoReceta = this.BajoReceta;

            

            return (Producto)productoEdit;
        }

    }
}

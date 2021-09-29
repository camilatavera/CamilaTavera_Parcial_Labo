using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cama : Producto
    {
        bool conBase;
        ETamanoCama tamanio;

        public Cama(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool conBase, ETamanoCama tamanio) : base(nombre, precio, cantidad, paraMascota)
        {
            this.ConBase = conBase;
            this.Tamanio = tamanio;
        }

        public bool ConBase
        {
            get { return conBase; }
            set { conBase = value; }
        }

        public ETamanoCama Tamanio
        {
            get { return tamanio; }
            set { tamanio = value; }
        }

        public override Producto editarProducto(int idAEditar)
        {
            Producto productoEdit = Negocio.buscarProducto(idAEditar);

            productoEdit.Nombre = this.Nombre;
            productoEdit.Precio = this.Precio;
            productoEdit.Cantidad = this.Cantidad;
            productoEdit.ParaMascota = this.ParaMascota;
            ((Cama)productoEdit).Tamanio = this.Tamanio;
            ((Cama)productoEdit).ConBase = this.ConBase;



            return (Producto)productoEdit;
        }
    }
}

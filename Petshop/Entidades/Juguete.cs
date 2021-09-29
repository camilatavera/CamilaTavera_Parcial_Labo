using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juguete : Producto
    {
        bool paraCachorro;
        EMaterial material;
        public Juguete(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool paraCachorro, EMaterial material) : base(nombre, precio, cantidad, paraMascota)
        {
            this.ParaCachorro = paraCachorro;
            this.Material = material;
        }

        public bool ParaCachorro
        {
            get { return paraCachorro; }
            set { paraCachorro = value; }
        }

        public EMaterial Material
        {
            get { return material; }
            set { material = value; }
        }


        public override Producto editarProducto(int idAEditar)
        {
            Producto productoEdit = Negocio.buscarProducto(idAEditar);

            productoEdit.Nombre = this.Nombre;
            productoEdit.Precio = this.Precio;
            productoEdit.Cantidad = this.Cantidad;
            productoEdit.ParaMascota = this.ParaMascota;
            ((Juguete)productoEdit).Material = this.Material;
            ((Juguete)productoEdit).ParaCachorro = this.ParaCachorro;



            return (Producto)productoEdit;
        }
    }
}

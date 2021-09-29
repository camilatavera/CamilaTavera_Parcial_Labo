using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimento : Producto
    {
        bool esBalanceado;
        TipoAlimento tipoDeAlimento;

        public Alimento(string nombre, int precio, int cantidad, Mascota paraMascota,
            bool esBalanceado, TipoAlimento tipoDeAlimento) : base(nombre, precio, cantidad, paraMascota)
        {
            this.EsBalanceado = esBalanceado;
            this.TipoDeAlimento = tipoDeAlimento;
        }

        public bool EsBalanceado
        {
            get { return esBalanceado; }
            set { esBalanceado = value; }
        }

        public TipoAlimento TipoDeAlimento
        {
            get { return tipoDeAlimento; }
            set { tipoDeAlimento = value; }
        }

        public override Producto editarProducto(int idAEditar)
        {
            Producto productoEdit = Negocio.buscarProducto(idAEditar);

            productoEdit.Nombre = this.Nombre;
            productoEdit.Precio = this.Precio;
            productoEdit.Cantidad = this.Cantidad;
            productoEdit.ParaMascota = this.ParaMascota;
            ((Alimento)productoEdit).TipoDeAlimento = this.tipoDeAlimento;
            ((Alimento)productoEdit).EsBalanceado = this.EsBalanceado;

            return (Producto)productoEdit;
        }
    }
}

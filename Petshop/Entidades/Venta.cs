using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        int idVenta;
        int idComprador;
        Empleado vendedor;
        DateTime fecha;
        List<Pedido> listPedidos;
        float precioTotal;

        static int idIncremental;

        static Venta()
        {
            idIncremental = 100;
        }

        public Venta(List<Pedido> listPedidos)
        {
            this.idVenta = getNuevoId();
            this.Fecha = DateTime.Now;
            this.ListPedidos = listPedidos;
            this.PrecioTotal = CalcularPrecioVenta(listPedidos);

        }

        public Venta(int idComprador, Empleado vendedor, List<Pedido> listPedidos):this(listPedidos)
        {                        
            this.IdComprador = idComprador;
            this.Vendedor = vendedor;

        }


        public Venta(int idComprador, Empleado vendedor, List<Pedido> listPedidos,
            float precioTotal):this(idComprador, vendedor, listPedidos)
        {
            
            this.PrecioTotal = precioTotal;

        }

        

        public Venta(int idComprador, Empleado vendedor, List<Pedido> listPedidos,
            float precioTotal, DateTime fecha) : this(idComprador, vendedor, listPedidos, precioTotal)
        {
            this.Fecha = fecha;
        }

        public Venta agregarVendedorComprador(int idComprador, Empleado vendedor)
        {
            this.IdComprador = idComprador;
            this.Vendedor = vendedor;
            return this;
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


        public int IdComprador
        {
            set { idComprador = value; }
            get { return idComprador; }

        }

        public int IdVenta
        {
            set { idVenta = value; }
            get { return idVenta; }


        }

        public Empleado Vendedor
        {
            set { vendedor = value; }
            get { return vendedor; }

        }


        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }

        }

        public List<Pedido> ListPedidos
        {
            set { listPedidos = new List<Pedido>(value); }
            get { return listPedidos; }
        }

        public float PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }



        private int CalcularPrecioVenta(List<Pedido> ListPedidos)
        {
            int ret = 0;
            foreach (Pedido pedidoAux in ListPedidos)
            {
                ret += pedidoAux.Precio;

            }
            return ret;
        }

       

        public string detallesVenta()
        {
            Pedido auxPedido;

            StringBuilder st = new StringBuilder();
            st.AppendLine($"Id Venta : {this.IdVenta}");
            st.AppendLine($"Fecha : {this.Fecha}");

            for (int i = 0; i < this.ListPedidos.Count; i++)
            {
                auxPedido = ListPedidos[i];
                st.AppendLine(auxPedido.detallePedido());
            }

            st.AppendLine($"Monto total abonado: {this.PrecioTotal}");

            return st.ToString();
        }

        private Venta agregarPedido(Pedido pedido)
        {
            this.ListPedidos.Add(pedido);
            return this;
        }

        public static Venta operator +(Venta venta, Pedido pedido)
        {
            return venta.agregarPedido(pedido);
        }




        public static implicit operator Venta(List<Pedido> pedidos)
        {
           return new Venta(pedidos);
        }

        //public static explicit operator 






        public static bool operator ==(Venta venta1, int idVenta2)
        {
            return venta1.IdVenta == idVenta2;
        }

        public static bool operator !=(Venta venta1, int idVenta2)
        {
            return venta1.IdVenta != idVenta2;
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }










    }
}

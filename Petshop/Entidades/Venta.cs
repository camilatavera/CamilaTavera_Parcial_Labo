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



        /// <summary>
        /// Inicializacion del atributo static idIncremental en 0
        /// </summary>
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


        /// <summary>
        /// Agrega valor a los atributos idComprador y vendedor a una venta
        /// </summary>
        /// <param name="idComprador"></param>
        /// <param name="vendedor"></param>
        /// <returns>la venta editada</returns>
        public Venta agregarVendedorComprador(int idComprador, Empleado vendedor)
        {
            this.IdComprador = idComprador;
            this.Vendedor = vendedor;
            return this;
        }


        /// <summary>
        /// get y set del atributo idIncremental
        /// </summary>
        int IdIncremental
        {
            get { return idIncremental; }
            set { idIncremental = value; }
        }



        /// <summary>
        /// Incrementa un digito el atributo estatico idIncremental
        /// </summary>
        /// <returns>valor del atributo estatico IdIncremental</returns>
        int getNuevoId()
        {
            IdIncremental += 1;
            return IdIncremental;
        }


        /// <summary>
        /// get y set  del atributo idComprador
        /// </summary>
        public int IdComprador
        {
            set { idComprador = value; }
            get { return idComprador; }

        }

        /// <summary>
        /// get y set  del atributo idVenta
        /// </summary>
        public int IdVenta
        {
            set { idVenta = value; }
            get { return idVenta; }


        }

        /// <summary>
        /// get y set del atributo vendedor
        /// </summary>
        public Empleado Vendedor
        {
            set { vendedor = value; }
            get { return vendedor; }

        }


        /// <summary>
        /// get y set del atributo fecha
        /// </summary>
        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }

        }



        /// <summary>
        /// get y set de la lista de objetos de tipo Pedido 
        /// </summary>
        public List<Pedido> ListPedidos
        {
            set { listPedidos = new List<Pedido>(value); }
            get { return listPedidos; }
        }


        /// <summary>
        /// get y set del atributo precioTotal
        /// </summary>
        public float PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }


       /// <summary>
       /// Calcula el precio de la venta sumando el precio de todos los pedidos
       /// </summary>
       /// <param name="ListPedidos"></param>
       /// <returns>int precio total de la venta</returns>
        private int CalcularPrecioVenta(List<Pedido> ListPedidos)
        {
            int ret = 0;
            foreach (Pedido pedidoAux in ListPedidos)
            {
                ret += pedidoAux.Precio;

            }
            return ret;
        }

       
        /// <summary>
        /// Detalles de la venta (id, fecha, pedidos, total abonado)
        /// </summary>
        /// <returns>string con los detalles</returns>
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

        /// <summary>
        /// agregar un pedido a la lista de pedidos de la venta
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns>La venta modificada</returns>
        private Venta agregarPedido(Pedido pedido)
        {
            this.ListPedidos.Add(pedido);
            return this;
        }

        /// <summary>
        /// Sobrecarga del operador + : agrega un pedido a la lista de pedidos de la venta
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static Venta operator +(Venta venta, Pedido pedido)
        {
            return venta.agregarPedido(pedido);
        }

        



        /// <summary>
        /// castea la lista de pedidos a una venta
        /// </summary>
        /// <param name="pedidos"></param>
        public static implicit operator Venta(List<Pedido> pedidos)
        {
           return new Venta(pedidos);
        }


        /// <summary>
        /// Me castea un int (el id de la venta) a una venta
        /// </summary>
        /// <param name="id"></param>
        public static implicit operator Venta(int id)
        {
            return Negocio.buscarVenta(id);
        }

       

        /// <summary>
        /// sobrecarga del operador ==. los evalua por su id
        /// </summary>
        /// <param name="venta1"></param>
        /// <param name="idVenta2"></param>
        /// <returns>true si tienen el mismo id, y sino false</returns>
        public static bool operator ==(Venta venta1, int idVenta2)
        {
            return venta1.IdVenta == idVenta2;
        }

        /// <summary>
        /// sobrecarga del operador != los evalua por su id
        /// </summary>
        /// <param name="venta1"></param>
        /// <param name="idVenta2"></param>
        /// <returns>true si tienen  distinto id, y sino false</returns>
        public static bool operator !=(Venta venta1, int idVenta2)
        {
            return venta1.IdVenta != idVenta2;
        }


        public override bool Equals(object obj)
        {
            Venta venta = obj as Venta;
            return venta != null && this == venta;
        }

        public override int GetHashCode()
        {
            return IdVenta.GetHashCode();
        }


        public string mostrarDetalle()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DETALLES DE LA VENTA");
            sb.AppendLine("---------------------------------------- \n");
            sb.AppendLine();
            sb.AppendLine($"Id venta: {this.idVenta} ");
            sb.AppendLine($"Fecha: {this.Fecha} ");
            sb.AppendFormat("" +
                "-----------------------------------------------------------------" +
                "");

            for (int i=0; i<this.ListPedidos.Count; i++)
            {
                sb.AppendLine(ListPedidos[i].mostrarDetallePedido());
            }
            sb.AppendFormat("" +
                 "-----------------------------------------------------------------" +
                 "");
            Cliente aux = this.IdComprador;
            sb.AppendLine(aux.mostrarDetalleFacturacion());
            sb.AppendFormat("" +
                "-----------------------------------------------------------------" +
                "");
            sb.AppendLine(this.Vendedor.mostrarDetalleFacturacion());

            return sb.ToString();


        }











    }
}

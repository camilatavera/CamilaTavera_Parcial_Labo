using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Negocio
    {
        static string nombre;
        static string calle;
        static int numero;
        static int codigoPostal;

        static List<Cliente> listClientes;
        static List<Venta> ventas;
        static List<Producto> listProductos;
        static List<Empleado> listEmpleados;

        static Negocio()
        {
            nombre = "Dogs PetShop";
            calle = "Av Rivadavia";
            numero = 5556;
            codigoPostal = 1212;

            Negocio.listEmpleados = new List<Empleado>(){
                new Empleado("Camila", "Emple", 112365896, new DateTime(2000, 04, 04), " ", " "),
                new Administrador("yosi", "Admin", 55522231, new DateTime(2000, 04, 04), "asd", "asd")
            };

            listProductos = new List<Producto>()
            {
                new Alimento("Pepitos", 200, 5, Mascota.Perro, true, TipoAlimento.Comestible),
                new Alimento("Juguin", 120, 2, Mascota.Gato, false, TipoAlimento.Bebible),
                new Cama("Cama redonda", 2000, 10, Mascota.Perro, false, ETamanoCama.Mediana),
                new Cama("Cama alta", 3500, 2, Mascota.Gato, true, ETamanoCama.Chica),
                new Farmacia("Suavecita", 500, 2, Mascota.Perro, false, TipoRemedio.Crema),
                new Farmacia("IbuGato", 1200, 3, Mascota.Gato, true, TipoRemedio.Pastilla),
                new Farmacia("Alagua", 200, 2, Mascota.Pez, true, TipoRemedio.Jarabe),
                new Juguete("Hueso", 250, 3, Mascota.Perro, true, EMaterial.Goma),
                new Juguete("Bola grande", 350, 8, Mascota.Gato, true, EMaterial.Felpa),
                new Juguete("Bolitas", 100, 1, Mascota.Pez, false, EMaterial.Plastico),
                new Limpieza("Limpiadin", 2000, 600, Mascota.Perro, true, TipoLimpieza.Jabon),
                new Limpieza("Clean fast", 500, 1, Mascota.Gato, false, TipoLimpieza.Liquido)
            };


            listClientes = new List<Cliente>(){
                new Cliente("Roberto", "Sanchez", 456328569, new DateTime(1995, 8, 5), 200),
                new Cliente("Maria", "Lopez", 11238373, new DateTime(2001, 2, 5), 5000)
            };
           

            List<Pedido> list1 = new List<Pedido>() { new Pedido(listProductos[1], 3), new Pedido(listProductos[3], 3) };
            List<Pedido> list2 = new List<Pedido>() { new Pedido(listProductos[5], 3), new Pedido(listProductos[4], 2), new Pedido(listProductos[6], 5) };
            List<Pedido> list3 = new List<Pedido>() { new Pedido(listProductos[1], 1) };
            List<Pedido> list4 = new List<Pedido>() { new Pedido(listProductos[8], 3),
            new Pedido(listProductos[11], 2), new Pedido(listProductos[7], 3) };

            ventas = new List<Venta>()
            {
                new Venta(1, listEmpleados[0], list1, list1[0].Precio + list1[1].Precio),
                new Venta(2, listEmpleados[1], list2, list2[0].Precio + list2[1].Precio + list2[2].Precio),
                new Venta(1, listEmpleados[0], list3, list3[0].Precio),
                new Venta(2, listEmpleados[1], list4, list1[0].Precio)
            };

        }












        public static List<Cliente> ListClientes
        {
            set { listClientes = value; }
            get { return listClientes; }

        }

        public static List<Producto> ListProductos
        {
            get { return Negocio.listProductos; }
        }

        public static List<Empleado> ListEmpleados
        {
            get { return Negocio.listEmpleados; }

        }

        public static List<Venta> ListVentas
        {
            get { return ventas; }

        }



        public static List<Cliente> agregarCliente(Cliente nuevoCliente)
        {
            if (nuevoCliente != null)
                Negocio.ListClientes.Add(nuevoCliente);

            return Negocio.ListClientes;
        }


        public static List<Venta> agregarVenta(Venta nuevaVenta)
        {
            Cliente comprador;
            if (nuevaVenta != null)
            {
                ventas.Add(nuevaVenta);
                comprador = buscarCliente(nuevaVenta.IdComprador);
                comprador.AgregarVenta();

            }
                

            return Negocio.ventas;
        }

        public static List<Empleado> agregarEmpleado(Empleado nuevoEmpleado)
        {
            if (nuevoEmpleado != null)
                listEmpleados.Add(nuevoEmpleado);
            return Negocio.listEmpleados;
        }

        //public static Cliente getUltimoCliente()
        //{
        //    if (clientes.Count() > 0)
        //        return clientes.Peek();
        //    else
        //        return null;
        //}



        public static Empleado validarIngreso(string user, string password)
        {

            Empleado empleadoAux;
            for (int i = 0; i < ListEmpleados.Count; i++)
            {
                empleadoAux = listEmpleados[i];
                if (empleadoAux.User == user)
                {
                    if (empleadoAux.validarPassword(password))
                    {
                        return empleadoAux;

                    }
                }
            }
            return null;
        }


        /// <summary>
        /// le paso el nombre y me devuelve la cantidad que queda en stock
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private static Producto validarStock(Producto producto, int cantidad)
        {
            foreach (Producto item in ListProductos)
            {
                if (item == producto && item.Cantidad >= cantidad)
                    return item;

            }
            return null;

        }

        private static bool validarCliente(Cliente cliente, float precio)
        {
            if (cliente.PlataDisponible >= precio)
            {
                return true;
            }
            return false;

        }

        //public static bool Vender(Producto producto, int cantidad)
        //{

        //    Producto prodAux = validarStock(producto, cantidad);
        //    if (prodAux != null)
        //    {
        //        prodAux.Cantidad=prodAux - 1;
        //        return true;
        //    }
        //    return false;

        //}


        //public static string getDescripcion(int id)
        //{

        //    foreach (Producto prod in Negocio.ListProductos)
        //    {
        //        if (prod.Id == id)
        //        {
        //            return prod.Detalle;
        //        }
        //    }
        //    return null;
        //}



        //public static Producto editarProductoDeStock(int id, string nombre, float precio, TipoProducto tipo, Mascota paraMascota,
        //    int cantidad, string detalle)
        //{
        //    Producto productoEdit = buscarProducto(id);
        //    if (productoEdit != null)
        //    {
        //        productoEdit.EditarProducto(nombre, precio, tipo, paraMascota, cantidad, detalle);

        //    }
        //    return productoEdit;

        //}

        public static Producto borrarProductoDeStock(int id)
        {
            Producto productoEdit = buscarProducto(id);


            if (productoEdit != null)
            {
                listProductos.Remove(productoEdit);

            }
            return productoEdit;

        }



        public static Producto buscarProducto(int id)
        {
            Producto prodAux;
            int idAux;
            for (int i = 0; i < listProductos.Count(); i++)
            {
                prodAux = ListProductos[i];
                idAux = prodAux.Id;
                if (idAux == id)
                {
                    return prodAux;
                }


            }
            return null;
        }


        public static Producto buscarProductoPorNombre(string nombre)
        {
            Producto prodAux;
            for (int i = 0; i < listProductos.Count(); i++)
            {
                prodAux = ListProductos[i];
                if (prodAux.Nombre == nombre)
                {
                    return prodAux;
                }


            }
            return null;
        }

        

 

        public static int getCantidadProductos()
        {
            int cant = Negocio.ListProductos.Count();
            return cant;
        }

        public static Cliente buscarCliente(int id)
        {
            Cliente clienteAux;

            for (int i = 0; i < ListClientes.Count(); i++)
            {
                clienteAux = ListClientes[i];
                if (clienteAux.Id == id)
                {
                    return clienteAux;
                }

            }
            return null;
        }

        public static Cliente buscarClientePorNombre(string nombre)
        {
            Cliente clienteAux;

            for (int i = 0; i < ListClientes.Count(); i++)
            {
                clienteAux = ListClientes[i];
                if (clienteAux.Nombre == nombre)
                {
                    return clienteAux;
                }

            }
            return null;
        }

        //public static void restarStock(Pedido pedido)
        //{
        //    Producto prodComprado = pedido.ProductoComprado;
        //    int cantidad = pedido.Cantidad;
        //    Producto prodAux;
        //    for(int i=0; i<ListProductos.Count(); i++)
        //    {
        //        prodAux = listProductos[i];
        //        if (prodComprado == prodAux)
        //        {
        //            prodAux.Cantidad=prodAux - cantidad;
        //        }
        //    }
        //}

        public static Empleado buscarEmpleado(int id)
        {
            Empleado auxEmpleado;
            for (int i = 0; i < ListEmpleados.Count; i++)
            {
                auxEmpleado = ListEmpleados[i];
                if (auxEmpleado.Id == id)
                {
                    return auxEmpleado;
                }
            }
            return null;
        }

        public static Empleado borrarEmpleado(int id)
        {
            Empleado auxEmpleado;
            for (int i = 0; i < ListEmpleados.Count; i++)
            {
                auxEmpleado = ListEmpleados[i];
                if (auxEmpleado.Id == id)
                {
                    ListEmpleados.Remove(auxEmpleado);
                }
            }
            return null;

        }

        public static Empleado editarEmpleado(int id, string nombre, string apellido, long telefono, DateTime fecha,
            string user)
        {
            Empleado editEmpleado = buscarEmpleado(id);
            editEmpleado.Nombre = nombre;
            editEmpleado.Apellido = apellido;
            editEmpleado.FechaNacimiento = fecha;
            editEmpleado.User = user;

            return editEmpleado;
        }

        public static Venta buscarVenta(int id)
        {
            Venta auxVenta;
            for (int i = 0; i < Negocio.ListVentas.Count; i++)
            {
                auxVenta = ListVentas[i];
                if (auxVenta == id)
                {
                    return auxVenta;
                }

            }
            return null;
        }

        public static void agregarProducto(Producto prod)
        {
            ListProductos.Add(prod);
        }
    }
}

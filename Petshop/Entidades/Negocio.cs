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
                new Empleado("Susana", "Suarez", 112365896, new DateTime(2000, 04, 04), "susana10", "susas"),
                new Administrador("Yenifer", "Parker", 55522231, new DateTime(2000, 04, 04), "yenifer10", "yenip"),
                new Administrador("Tomas", "Rodriguez", 55522231, new DateTime(1985, 04, 04), "tomas10", "tomr")
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

        /// <summary>
        /// get del atributo estatico del nombre del negocio
        /// </summary>
       public static string Nombre
        {
            get
            {
                return nombre;
            }
        }


        /// <summary>
        /// get los atributos estaticos del negocio relacionados a la direccion
        /// </summary>
        public static string Direccion
        {
            get
            {
                return Negocio.calle + Negocio.numero + Negocio.codigoPostal;
            }

        }









        /// <summary>
        /// get y set de la List de objetos de tipo Cliente 
        /// </summary>
        public static List<Cliente> ListClientes
        {
            set { listClientes = value; }
            get { return listClientes; }

        }

        /// <summary>
        /// get y set de la List de objetos de tipo Producto 
        /// </summary>
        public static List<Producto> ListProductos
        {
            get { return Negocio.listProductos; }
        }


        /// <summary>
        /// get y set de la List de objetos de tipo Empleado 
        /// </summary>
        public static List<Empleado> ListEmpleados
        {
            get { return Negocio.listEmpleados; }

        }


        /// <summary>
        /// get y set de la List de objetos de tipo Venta 
        /// </summary>
        public static List<Venta> ListVentas
        {
            get { return ventas; }

        }


        /// <summary>
        /// Agrega un nuevo cliente a la lista estatica de Clientes
        /// </summary>
        /// <param name="nuevoCliente"></param>
        /// <returns></returns>
        public static List<Cliente> agregarCliente(Cliente nuevoCliente)
        {
            if (nuevoCliente != null)
                Negocio.ListClientes.Add(nuevoCliente);

            return Negocio.ListClientes;
        }


        /// <summary>
        /// Agrega un nueva venta a la lista estatica de Ventas
        /// </summary>
        /// <param name="nuevaVenta"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Agrega un nuevo empleado a la lista estatica de empleados
        /// </summary>
        /// <param name="nuevoEmpleado"></param>
        /// <returns></returns>
        public static List<Empleado> agregarEmpleado(Empleado nuevoEmpleado)
        {
            if (nuevoEmpleado != null)
                listEmpleados.Add(nuevoEmpleado);
            return Negocio.listEmpleados;
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


        /// <summary>
        /// Valida que el cliente tenga la igual o mayor cantidad de plata disponible que el precio pasado por parametro
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="precio"></param>
        /// <returns>True si se cumple la condicion, False si no se cumple</returns>
        private static bool validarCliente(Cliente cliente, float precio)
        {
            if (cliente.PlataDisponible >= precio)
            {
                return true;
            }
            return false;

        }

      
        /// <summary>
        /// Busca en la lista estatica de productos un producto por su id y si lo encuentra, lo borra 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null si no lo encuentra o el producto editado</returns>
        public static Producto borrarProductoDeStock(int id)
        {
            Producto productoEdit = buscarProducto(id);


            if (productoEdit != null)
            {
                listProductos.Remove(productoEdit);

            }
            return productoEdit;

        }


        /// <summary>
        /// Busca en la lista estatica de productos un producto por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null si no lo encuentro o el producto </returns>
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


        /// <summary>
        /// Busca en la lista estatica de productos un producto por su nombre
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null si no lo encuentro o el producto </returns>
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

        

 
        /// <summary>
        /// Cuenta la cantidad de productos que hay en la lista estatica de objetos de tipo Producto
        /// </summary>
        /// <returns>int: la cantidad de productos</returns>
        public static int getCantidadProductos()
        {
            int cant = Negocio.ListProductos.Count();
            return cant;
        }


        /// <summary>
        /// Busca en la lista estatica de clientes un cliente por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null si no lo encuentro o el cliente </returns>
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


        /// <summary>
        /// Busca en la lista estatica de clientes un cliente por su nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>null si no lo encuentro o el cliente </returns>
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



        /// <summary>
        /// Busca en la lista estatica de empleados un empleado por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null si no lo encuentro o el empleado </returns>
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



        /// <summary>
        /// Busca en la lista estatica de empleados un empelado por su id y lo elimina
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null si no lo encuentra o el empleado eliminado </returns>
        public static Empleado borrarEmpleado(int id)
        {
            Empleado auxEmpleado;
            for (int i = 0; i < ListEmpleados.Count; i++)
            {
                auxEmpleado = ListEmpleados[i];
                if (auxEmpleado.Id == id)
                {
                    ListEmpleados.Remove(auxEmpleado);
                    return auxEmpleado;
                }
            }
            return null;

        }


        /// <summary>
        /// busca al empleado por su id (valor pasado por parametro) y edita sus atributos con los otros valores
        /// pasados por parametro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="fecha"></param>
        /// <param name="user"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Busca en la lista estatica de ventas una venta por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null si no lo encuentro o la venta </returns>
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


        /// <summary>
        /// Agrega un producto a la lista estatica de productos
        /// </summary>
        /// <param name="prod"></param>
        public static void agregarProducto(Producto prod)
        {
            ListProductos.Add(prod);
        }

        public static int cantidadVentas()
        {
            return ListVentas.Count;
        }


        /// <summary>
        /// Busca en la lista estatica de empleados un empleado por su nombre de usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns>null si no lo encuentro o el empleaedo </returns>
        public static Empleado buscarXusuario(string user)
        {
            Empleado aux = null;
            string contra;
            for (int i = 0; i < ListEmpleados.Count; i++)
            {
                aux = listEmpleados[i];
                contra = aux.User;
                if (contra == user)
                {
                    break;
                }



            }
            return aux;
        }

        /// <summary>
        /// Busca en la lista estatica de empleados un empleado por su nombre de usuario pasado por parametro y valida
        /// que la contrasena sea la misma
        /// </summary>
        /// <param name="user"></param>
        /// <param name="psw"></param>
        /// <returns>El empleado si cumplio la condiciones y sino null </returns>
        public static Empleado validarIngreso2(string user, string psw)
        {
            Empleado aux = buscarXusuario(user);
            if (aux != null && string.Compare(aux.Password, aux.Password)==0)
            {
                return aux;
            }
            else
            {
                return null;
            }

        }
    }
}

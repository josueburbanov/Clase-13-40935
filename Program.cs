using Clase_13_40935;

namespace Clase2_13_4095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*********** Escribir una funcion que me permita obtener todos los productos de la base
            //List<Producto> productos = ManejadorProducto.ObtenerProductos();

            //********* Escribir una funcion que me permita obtener un producto dado las descripciones
            //Producto producto = ManejadorProducto.ObtenerProducto("Pantalon Negro");

            //******* Escribir una funcion que me permita crear un producto
            Producto productoAInsertar = new Producto();
            productoAInsertar.Descripciones = "Pantalon Jean Negro";
            productoAInsertar.Costo = 9000;
            productoAInsertar.PrecioVenta = 12000;
            productoAInsertar.Stock = 99;
            productoAInsertar.IdUsuario = 2;

            if(ManejadorProducto.InsertarProducto(productoAInsertar) >= 1)
            {
                Console.WriteLine("Producto Insertado");
            }else
            {
                Console.WriteLine("No se pudo insertar el producto");
            }

        }
    }
}
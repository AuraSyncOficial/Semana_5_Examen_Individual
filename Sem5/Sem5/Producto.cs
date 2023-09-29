using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem5
{
    abstract class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public abstract string ObtenerCaracteristicas();
        public abstract decimal ObtenerPrecio();
    }

    class ProductoTela : Producto
    {
        public string Tamaño { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public override string ObtenerCaracteristicas()
        {
            return $"Nombre: {Nombre}, Tamaño: {Tamaño}, Material: {Material}, Color: {Color}";
        }

        public override decimal ObtenerPrecio()
        {
            return Precio;
        }
    }

    class ProductoArcilla : Producto
    {
        public double Peso { get; set; }
        public string Tamaño { get; set; }
        public string Color { get; set; }

        public override string ObtenerCaracteristicas()
        {
            return $"Nombre: {Nombre}, Peso: {Peso} gramos, Tamaño: {Tamaño}, Color: {Color}";
        }

        public override decimal ObtenerPrecio()
        {
            return Precio;
        }
    }

    class CarritoCompras
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public decimal CalcularPrecioTotal()
        {
            decimal total = 0;
            foreach (var producto in productos)
            {
                total += producto.ObtenerPrecio();
            }
            return total;
        }

        public void MostrarContenido()
        {
            Console.WriteLine("Contenido del carrito de compras:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.ObtenerCaracteristicas());
            }
            Console.WriteLine($"Precio total: {CalcularPrecioTotal()}");
        }
    }
}

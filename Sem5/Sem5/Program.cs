using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem5
{
    class Program
    {
        static void Main()
        {
            var carrito = new CarritoCompras();

            while (true)
            {
                Console.WriteLine("¿Qué deseas hacer?");
                Console.WriteLine("1. Añadir un producto al carrito");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar compra");
                Console.WriteLine("4. Salir");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida. Por favor, ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Lista de productos disponibles:");
                        Console.WriteLine("1. Banda Gucci");
                        Console.WriteLine("2. Camisa para programador");
                        Console.WriteLine("3. Jarron de Arcilla marca Nazca");
                        Console.WriteLine("4. Estatua pequeña de arcilla");

                        int seleccion;
                        if (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > 4)
                        {
                            Console.WriteLine("Selección no válida. Por favor, ingresa un número válido.");
                            continue;
                        }

                        Producto producto;
                        switch (seleccion)
                        {
                            case 1:
                                producto = new ProductoTela
                                {
                                    Nombre = "Banda Gucci",
                                    Tamaño = "Pequeño",
                                    Material = "Algodón",
                                    Color = "Blanco",
                                    Precio = 4000
                                };
                                break;
                            case 2:
                                producto = new ProductoTela
                                {
                                    Nombre = "Camisa para programador",
                                    Tamaño = "M",
                                    Material = "Seda",
                                    Color = "Azul",
                                    Precio = 50
                                };
                                break;
                            case 3:
                                producto = new ProductoArcilla
                                {
                                    Nombre = "Jarron de Arcilla marca Nazca",
                                    Peso = 50,
                                    Tamaño = "Grande",
                                    Color = "Verde jade",
                                    Precio = 25
                                };
                                break;
                            case 4:
                                producto = new ProductoArcilla
                                {
                                    Nombre = "Estatua pequeña de arcilla",
                                    Peso = 25,
                                    Tamaño = "Mediano",
                                    Color = "Blanco",
                                    Precio = 35
                                };
                                break;
                            default:
                                producto = null;
                                break;
                        }

                        if (producto != null)
                        {
                            Console.WriteLine("Características del producto:");
                            Console.WriteLine(producto.ObtenerCaracteristicas());
                            Console.WriteLine($"Precio: {producto.ObtenerPrecio()}");

                            Console.WriteLine("¿Deseas añadir este producto al carrito? (S/N)");
                            string respuesta = Console.ReadLine();
                            if (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase))
                            {
                                carrito.AgregarProducto(producto);
                                Console.WriteLine("Producto añadido al carrito.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Selección no válida.");
                        }
                        break;

                }
            }
        }
    }

}

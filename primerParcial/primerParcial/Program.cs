using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            int cantidadDeCamisas = 0;
            int desc;
            string entrada;
            float preciofinal=0;
            int opc2 = 0;
            do {
                
                Console.WriteLine("        Camisas PRADBIT – Ventas minoristas y mayoristas");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1. Añadir camisa al carro de compras");
                Console.WriteLine("2. Eliminar camisa del carro de compras");
                Console.WriteLine("3. SALIR");
                entrada = Console.ReadLine();
                opc = Convert.ToInt32(entrada);

                switch (opc)
                {
                    case 1:
                        cantidadDeCamisas = cantidadDeCamisas + 1; break;
                    case 2:
                        cantidadDeCamisas = cantidadDeCamisas - 1; break;
                    case 3:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("¿Estas seguro/a de que deseas salir del programa?");
                            Console.WriteLine("1. SI");
                            Console.WriteLine("2. NO");
                            entrada = Console.ReadLine();
                            opc2 = Convert.ToInt32(entrada);
                        } while (opc2 != 1 && opc2 != 2);
                        break;
                }

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Cantidad de camisas en el carro: " + cantidadDeCamisas);
                desc = descuentoAplicado(ref cantidadDeCamisas);
                Console.WriteLine("Precio unitario: $1000");
                Console.WriteLine("Precio total sin descuento: " + cantidadDeCamisas * 1000);
                Console.WriteLine("Tipo de descuento aplicado: " + desc + " % del total de la compra");
                preciofinal = precioFinal(ref cantidadDeCamisas, ref desc);
                Console.WriteLine("PRECIO FINAL CON DESCUENTO APLICADO: " + preciofinal);

            } while (opc2 != 1);


        }

        static int descuentoAplicado(ref int cantidadDeCamisas)
        {
            int porcentajedesc=0;

            if (cantidadDeCamisas < 3)
            {
                porcentajedesc = 0;
            }

            if (cantidadDeCamisas >= 3 && cantidadDeCamisas <= 5)
            {
                porcentajedesc = 10;
            }

            if (cantidadDeCamisas > 5)
            {
                porcentajedesc = 20;
            }
            return porcentajedesc;
        }

        static float precioFinal(ref int cantidadDeCamisas, ref int desc)
        {
            float preciofinal;
            float descuento;

            descuento = cantidadDeCamisas * 1000 * desc / 100;
            preciofinal = cantidadDeCamisas * 1000 - descuento;
            return preciofinal;
        }
    }

}



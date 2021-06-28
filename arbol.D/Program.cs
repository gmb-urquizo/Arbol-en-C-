using System;

namespace Arbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola arbol");

            var raiz = new Nodo
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "28"

                            },
                            new Nodo
                            {
                                Valor = "16"
                            }
                        }

                    },
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "99"

                            },
                            new Nodo
                            {
                                Valor = "43"
                            }
                        }
                    }
                }
            };

            //Resultado esperado
            // => (28 - 16) * (99 - 43) notacion infija
            // => * (- 28 16) (- 99 43) notacion prefija
            // => (28 16 +) (99 43 -) * notacion prefija

            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPostfijo(raiz));

            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Infijo));
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Prefijo));
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Postfijo));



            Console.WriteLine($"Numero de hojas: {manejadorArbol.NumeroHojas(raiz)}");
            Console.WriteLine($"Numero de nodos:{manejadorArbol.NumeroNodos(raiz)}");
            Console.WriteLine($"Numero de niveles:{manejadorArbol.NumeroNiveles(raiz, 0)}");
        }
    }
}

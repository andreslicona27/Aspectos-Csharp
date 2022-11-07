using System.Collections;

namespace Ejercicio1
{
    internal class Program
    {
        public static bool CompruebaIp(String ip)
        {
            bool aprobada = true;
            ip.Split(".");

            if (ip.Split(".").Length != 4)
            {
                return aprobada = false;
            }

            foreach (String ip2 in ip.Split("."))
            {
                if (ip2.Length > 3 || ip2.Length < 1 || int.Parse(ip2) < 0 || int.Parse(ip2) > 255)
                {
                    return aprobada = false;
                }
            }

            return aprobada;
        }



        static void Main(string[] args)
        {
            Hashtable computadoras = new Hashtable();

            computadoras.Add("123.234.241.123", 5);
            computadoras.Add("45.45.45.45", 16);
            computadoras.Add("1.1.1.1", 8);
            computadoras.Add("2.2.2.2", 128);


            int opcMenu;

            try
            {
                do
                {
                    Console.WriteLine("\n MENU DE OPCIONES\n" +
                        "1.- Introducir datos\n" +
                        "2.- Eliminar un dato\n" +
                        "3.- Mostrar la colección entera\n" +
                        "4.- Mostrar un elemento de la colección\n" +
                        "5.- Salir\n");
                    opcMenu = int.Parse(Console.ReadLine());

                    switch (opcMenu)
                    {
                        case 1:
                            string agregaIp;
                            int memoria;

                            try
                            {
                                Console.Write("Dame la dirección IP: ");
                                agregaIp = Console.ReadLine();

                                while (!CompruebaIp(agregaIp))
                                {
                                    Console.WriteLine("Ese número de IP no es correcto, intetalo de nuevo.");
                                    Console.Write("Dame la dirección IP: ");
                                    agregaIp = Console.ReadLine();
                                }

                                Console.Write("Dame la cantidad de memoria: ");
                                memoria = int.Parse(Console.ReadLine());

                                if (memoria < 0 || memoria % 1 != 0)
                                {
                                    Console.WriteLine("Solo se admiten números enteros.");
                                    Console.Write("Dame la cantidad de memoria: ");
                                    memoria = int.Parse(Console.ReadLine());
                                }

                                computadoras.Add(agregaIp, memoria);

                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("Esa IP ya esta agregada.\n");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("El valor introducido no es correcto.\n");
                            }
                            break;

                        case 2:
                            string eliminaIp;

                            try
                            {
                                Console.Write("Dame la IP que deseas eliminar: ");
                                eliminaIp = Console.ReadLine();

                                while (!CompruebaIp(eliminaIp))
                                {
                                    Console.WriteLine("Ese número de IP no es correcto, intentalo de nuevo.");
                                    Console.Write("Dame la dirección IP: ");
                                    eliminaIp = Console.ReadLine();
                                }

                                if (computadoras.Contains(eliminaIp))
                                {
                                    computadoras.Remove(eliminaIp);
                                    Console.WriteLine("La IP ha sido borrada.");
                                }
                                else
                                {
                                    Console.WriteLine("Esa IP no se encuentra en la lista.");

                                }
                            }
                            catch (NotSupportedException)
                            {
                                Console.WriteLine("Ha ocurrido un error, intentlo de nuevo.");
                            }

                            break;

                        case 3:
                            if (computadoras.Count != 0)
                            {
                                int contIp = 1;
                                Console.WriteLine("Lista de direcciones IP's");
                                foreach (DictionaryEntry item in computadoras)
                                {
                                    Console.WriteLine("{0} IP: {1,-20} Memoria: {2} GB", contIp, item.Key, item.Value);
                                    contIp++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Aún no hay elementos en la lista.");
                            }
                            break;

                        case 4:
                            string muestraIp;

                            try
                            {
                                Console.WriteLine("¿Qué IP deseas mostrar?");
                                muestraIp = Console.ReadLine();

                                while (!CompruebaIp(muestraIp))
                                {
                                    Console.WriteLine("Ese número de IP no es correcto, intentalo de nuevo.");
                                    Console.Write("Dame la dirección IP: ");
                                    muestraIp = Console.ReadLine();

                                }

                                if (computadoras.Contains(muestraIp))
                                {
                                    Console.WriteLine("Direccion IP: {0, -20} Cantidad de memoria: {1} GB", muestraIp, computadoras[muestraIp]);
                                }
                                else
                                {
                                    Console.WriteLine("Esa IP no se encunetra en la lista");
                                }

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Ha ocurrido un error, intentalo de nuevo");
                            }
                            break;

                        case 5:
                            break;
                    }
                } while (opcMenu != 5);

            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ocurrido un error, intentalo de nuevo");
            }
        }
    }
}
using System;

class Program
{
    static int[] numeroFactura = new int[15];
    static string[] numeroPlaca = new string[15];
    static string[] fecha = new string[15];
    static string[] hora = new string[15];
    static int[] tipoVehiculo = new int[15];
    static int[] numeroCaseta = new int[15];
    static int[] montoPagar = new int[15];
    static int[] pagaCon = new int[15];
    static int[] vuelto = new int[15];
    static int cantidadVehiculos = 0;

    static void Main()
    {
        try
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sistema de Vehiculos Murcia S.A:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Ingresar Paso Vehicular");
                Console.WriteLine("3. Consulta de vehículos x Número de Placa");
                Console.WriteLine("4. Modificar Datos Vehículos x número de Placa");
                Console.WriteLine("5. Reporte Todos los Datos de los vectores");
                Console.WriteLine("6. Salir");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        InicializarVectores();
                        break;
                    case 2:
                        IngresarPasoVehicular();
                        break;
                    case 3:
                        ConsultarPorPlaca();
                        break;
                    case 4:
                        ModificarPorPlaca();
                        break;
                    case 5:
                        ReporteTodosDatos();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

            } while (opcion != 6);


        }
        catch (Exception e)
        {
            Console.WriteLine("Error en el Sub Menú: " + e.Message);
            Console.ReadKey();
        }
    }

    static void InicializarVectores()
    {
        for (int i = 0; i < 15; i++)
        {
            numeroFactura[i] = 0;
            numeroPlaca[i] = " ";
            fecha[i] = " ";
            hora[i] = " ";
            tipoVehiculo[i] = 0;
            numeroCaseta[i] = 0;
            montoPagar[i] = 0;
            pagaCon[i] = 0;
            vuelto[i] = 0;
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Vectores inicializados correctamente.");
        Console.ReadKey();
        Console.Clear();
    }

    static void IngresarPasoVehicular()
    {
        char continuar;

        do
        {
            Console.Clear();
            Console.WriteLine("REGISTRAR FLUJO VEHICULAR\n");

            Console.Write("Numero Factura: ");
            numeroFactura[cantidadVehiculos] = int.Parse(Console.ReadLine());

            Console.Write("Numero PLACA: ");
            numeroPlaca[cantidadVehiculos] = Console.ReadLine();

            Console.Write("Fecha: ");
            fecha[cantidadVehiculos] = Console.ReadLine();

            Console.Write("Hora: ");
            hora[cantidadVehiculos] = Console.ReadLine();

            Console.WriteLine("Tipo de vehículo: ");
            Console.WriteLine("1. Moto");
            Console.WriteLine("2. Vehículo Liviano");
            Console.WriteLine("3. Vehiculo Pesado");
            Console.WriteLine("4. Autobús");
            Console.Write("Seleccione el tipo de vehículo: ");
            tipoVehiculo[cantidadVehiculos] = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero caseta: ");
            Console.WriteLine("1. Caseta 1");
            Console.WriteLine("2. Caseta 2");
            Console.WriteLine("3. Caseta 3");
            Console.Write("Seleccione el número de caseta: ");
            numeroCaseta[cantidadVehiculos] = int.Parse(Console.ReadLine());


            switch (tipoVehiculo[cantidadVehiculos])
            {
                case 1:
                    montoPagar[cantidadVehiculos] = 500;
                    break;
                case 2:
                    montoPagar[cantidadVehiculos] = 700;
                    break;
                case 3:
                    montoPagar[cantidadVehiculos] = 2700;
                    break;
                case 4:
                    montoPagar[cantidadVehiculos] = 3700;
                    break;
                default:
                    Console.WriteLine("Tipo de vehículo no válido.");
                    break;
            }

            Console.Write("Monto a pagar: {0}", montoPagar[cantidadVehiculos]);

            Console.Write("\nPaga con: ");
            pagaCon[cantidadVehiculos] = int.Parse(Console.ReadLine());

            // Calcular vuelto
            vuelto[cantidadVehiculos] = pagaCon[cantidadVehiculos] - montoPagar[cantidadVehiculos];
            Console.Write("Vuelto: {0}\n", vuelto[cantidadVehiculos]);

            cantidadVehiculos++;

            Console.Write("Desea continuar (S/N)? ");
            continuar = char.ToUpper(char.Parse(Console.ReadLine()));

        } while (continuar == 'S');

        Console.Clear();
    }

    static void ConsultarPorPlaca()
    {
        Console.Clear();
        Console.Write("Ingrese el número de placa a consultar: ");
        string placaConsulta = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < cantidadVehiculos; i++)
        {
            if (numeroPlaca[i].Equals(placaConsulta))
            {
                MostrarDatosVehiculo(i);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontraron vehículos con esta placa.");
        }

        Console.ReadKey();
    }

    static void ModificarPorPlaca()
    {
        Console.Clear();
        Console.Write("Ingrese el número de placa a modificar: ");
        string placaModificar = Console.ReadLine();

        bool encontrado = false;
        int indiceModificar = -1;

        for (int i = 0; i < cantidadVehiculos; i++)
        {
            if (numeroPlaca[i].Equals(placaModificar))
            {
                indiceModificar = i;
                MostrarDatosVehiculo(i);
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            int opcionModificar;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione el dato a modificar:");
                Console.WriteLine("1. Numero Factura");
                Console.WriteLine("2. Numero Placa");
                Console.WriteLine("3. Fecha");
                Console.WriteLine("4. Hora");
                Console.WriteLine("5. Tipo de Vehículo");
                Console.WriteLine("6. Numero Caseta");
                Console.WriteLine("7. Paga Con");
                Console.WriteLine("8. Regresar al menú principal");

                Console.Write("Opción: ");
                opcionModificar = int.Parse(Console.ReadLine());

                switch (opcionModificar)
                {
                    case 1:
                        Console.Write("Nuevo Numero Factura: ");
                        numeroFactura[indiceModificar] = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Nuevo Numero Placa: ");
                        numeroPlaca[indiceModificar] = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Nueva Fecha: ");
                        fecha[indiceModificar] = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Nueva Hora: ");
                        hora[indiceModificar] = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Nuevo Tipo de Vehículo: ");
                        Console.WriteLine("1. Moto");
                        Console.WriteLine("2. Vehículo Liviano");
                        Console.WriteLine("3. Camión o Pesado");
                        Console.WriteLine("4. Autobús");
                        Console.Write("Seleccione el nuevo tipo de vehículo: ");
                        tipoVehiculo[indiceModificar] = int.Parse(Console.ReadLine());
                        switch (tipoVehiculo[indiceModificar])
                        {
                            case 1:
                                montoPagar[indiceModificar] = 500;
                                break;
                            case 2:
                                montoPagar[indiceModificar] = 700;
                                break;
                            case 3:
                                montoPagar[indiceModificar] = 2700;
                                break;
                            case 4:
                                montoPagar[indiceModificar] = 3700;
                                break;
                            default:
                                Console.WriteLine("Tipo de vehículo no válido.");
                                break;
                        }

                        // Calcular nuevo vuelto
                        vuelto[indiceModificar] = pagaCon[indiceModificar] - montoPagar[indiceModificar];
                        Console.Write("Nuevo Vuelto: {0}\n", vuelto[indiceModificar]);

                        break;
                    case 6:
                        Console.WriteLine("Nuevo Numero Caseta: ");
                        Console.WriteLine("1. Caseta 1");
                        Console.WriteLine("2. Caseta 2");
                        Console.WriteLine("3. Caseta 3");
                        Console.Write("Seleccione el nuevo número de caseta: ");
                        numeroCaseta[indiceModificar] = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.Write("Nuevo Paga Con: ");
                        pagaCon[indiceModificar] = int.Parse(Console.ReadLine());
                        // Calcular nuevo vuelto
                        vuelto[indiceModificar] = pagaCon[indiceModificar] - montoPagar[indiceModificar];
                        Console.Write("Nuevo Vuelto: {0}\n", vuelto[indiceModificar]);
                        break;
                    case 8:
                        Console.WriteLine("Regresando al menú principal.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.ReadKey();
            } while (opcionModificar != 8);

        }
        else
        {
            Console.WriteLine("No se encontraron vehículos con esta placa.");
        }
    }

    static void ReporteTodosDatos()
    {
        Console.Clear();
        Console.WriteLine("  Título del Reporte");
        Console.WriteLine("N factura    Placa           tipo de vehículo          caseta        monto Pagar   paga con     vuelto");
        Console.WriteLine("=============================================================================");

        for (int i = 0; i < cantidadVehiculos; i++)
        {
            Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t{4}\t\t{5}\t{6}",
                numeroFactura[i], numeroPlaca[i], tipoVehiculo[i], numeroCaseta[i],
                montoPagar[i], pagaCon[i], vuelto[i]);
        }

        Console.WriteLine("=============================================================================");
        Console.WriteLine("Cantidad de vehículos: {0}\t\ttotal: {1}", cantidadVehiculos, CalcularTotal());
        Console.WriteLine("=============================================================================");
        Console.WriteLine("                       <<<Pulse tecla para regresar >>>");
        Console.ReadKey();
    }

    static void MostrarDatosVehiculo(int indice)
    {
        Console.Clear();
        Console.WriteLine("Número de Factura: {0}", numeroFactura[indice]);
        Console.WriteLine("Número de Placa: {0}", numeroPlaca[indice]);
        Console.WriteLine("Fecha: {0}", fecha[indice]);
        Console.WriteLine("Hora: {0}", hora[indice]);
        Console.WriteLine("Tipo de Vehículo: {0}", tipoVehiculo[indice]);
        Console.WriteLine("Número de Caseta: {0}", numeroCaseta[indice]);
        Console.WriteLine("Monto a Pagar: {0}", montoPagar[indice]);
        Console.WriteLine("Paga con: {0}", pagaCon[indice]);
        Console.WriteLine("Vuelto: {0}", vuelto[indice]);
        Console.ReadKey();
    }

    static int CalcularTotal()
    {
        int total = 0;

        for (int i = 0; i < cantidadVehiculos; i++)
        {
            total += montoPagar[i];
        }

        return total;
    }
}
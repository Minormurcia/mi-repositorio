using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int opcion;
        int contadorOperarios = 0;
        int contadorTecnicos = 0;
        int contadorProfesionales = 0;
        double acumuladoSalarioNetoOperarios = 0;
        double acumuladoSalarioNetoTecnicos = 0;
        double acumuladoSalarioNetoProfesionales = 0;

        do
        {
            Console.WriteLine("*****BIENVENIDO A LA CALCULADORA SALARIAL DE MURCIA S.A*****");

            Console.WriteLine("Ingrese los datos del empleado:");

            Console.Write("Digite Su Numero de Cedula: ");
            string cedula = Console.ReadLine();

            Console.Write("Digite su Nombre Empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Elija el Tipo Empleado (1: Operario, 2 :Técnico, 3 :Profesional): ");
            int tipoEmpleado = int.Parse(Console.ReadLine());


            Console.Write("Salario por Hora: ");
            double salarioPorHora = double.Parse(Console.ReadLine());

            Console.Write("Digite la Cantidad de Horas Laboradas: ");
            int horasLaboradas = int.Parse(Console.ReadLine());

            // Calcula el salario ordinario del trabajor
            double salarioOrdinario = salarioPorHora * horasLaboradas;

            // Calcula el  Aumento
            double aumento = 0;
            if (tipoEmpleado == 1)
            {
                aumento = salarioOrdinario * 0.15;
                contadorOperarios++;
                acumuladoSalarioNetoOperarios += salarioOrdinario + aumento;
            }
            else if (tipoEmpleado == 2)
            {
                aumento = salarioOrdinario * 0.10;
                contadorTecnicos++;
                acumuladoSalarioNetoTecnicos += salarioOrdinario + aumento;
            }
            else if (tipoEmpleado == 3)
            {
                aumento = salarioOrdinario * 0.05;
                contadorProfesionales++;
                acumuladoSalarioNetoProfesionales += salarioOrdinario + aumento;
            }

            // Calcula el  Salario Bruto
            double salarioBruto = salarioOrdinario + aumento;

            // Calcula las Deducción de la CCSS
            double deduccionCCSS = salarioBruto * 0.0917;

            // Calcula el Salario Neto
            double salarioNeto = salarioBruto - deduccionCCSS;

            // Mostrar resultados
            Console.WriteLine("\n*****Datos del empleado:*****");
            Console.WriteLine($"Cedula: {cedula}");
            Console.WriteLine($"Nombre Empleado: {nombre}");
            Console.WriteLine($"Tipo Empleado: {tipoEmpleado}");
            Console.WriteLine($"Salario por Hora: {salarioPorHora}");
            Console.WriteLine($"Cantidad de Horas: {horasLaboradas}");
            Console.WriteLine($"Salario Ordinario: {salarioOrdinario}");
            Console.WriteLine($"Aumento: {aumento}");
            Console.WriteLine($"Salario Bruto: {salarioBruto}");
            Console.WriteLine($"Deducción CCSS: {deduccionCCSS}");
            Console.WriteLine($"Salario Neto: {salarioNeto}");

            Console.WriteLine("\n¿Desea ingresar otro empleado? (1-Sí, 0-No): ");
            opcion = int.Parse(Console.ReadLine());

        } while (opcion != 0);

        // Muestra las estadisticas generales de los empleados
        Console.WriteLine("\n##### Estadísticas: ######");
        Console.WriteLine($"1) Cantidad Empleados Tipo Operarios: {contadorOperarios}");
        Console.WriteLine($"   Acumulado Salario Neto para Operarios: {acumuladoSalarioNetoOperarios}");
        Console.WriteLine($"   Promedio Salario Neto para Operarios: {(contadorOperarios == 0 ? 0 : acumuladoSalarioNetoOperarios / contadorOperarios)}");

        Console.WriteLine($"2) Cantidad Empleados Tipo Técnico: {contadorTecnicos}");
        Console.WriteLine($"   Acumulado Salario Neto para Técnicos: {acumuladoSalarioNetoTecnicos}");
        Console.WriteLine($"   Promedio Salario Neto para Técnicos: {(contadorTecnicos == 0 ? 0 : acumuladoSalarioNetoTecnicos / contadorTecnicos)}");

        Console.WriteLine($"3) Cantidad Empleados Tipo Profesional: {contadorProfesionales}");
        Console.WriteLine($"   Acumulado Salario Neto para Profesionales: {acumuladoSalarioNetoProfesionales}");
        Console.WriteLine($"   Promedio Salario Neto para Profesionales: {(contadorProfesionales == 0 ? 0 : acumuladoSalarioNetoProfesionales / contadorProfesionales)}");
    }
}
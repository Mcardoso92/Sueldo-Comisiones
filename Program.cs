using System;

namespace EJERCICIO_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULAR SUELDO MAS COMISIONES
            //PASO 0: DECLARAR VARIABLES
            float FACT, COM, SF, ST;

            //PASO 1: INGRESAR DATOS
            Console.WriteLine("Ingrese sueldo fijo actual: ");
            SF = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese facturacion total: ");
            FACT = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese comision: ");
            COM = int.Parse(Console.ReadLine());

            //PASO 2: CALCULAR
            ST = SF + ((FACT * COM) / 100);            

            //PASO 3: MOSTRAR SUELDO A COBRAR
            Console.WriteLine("Sueldo a cobrar: " + ST);
        }
    }
}

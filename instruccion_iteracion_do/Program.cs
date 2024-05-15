using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instruccion_iteracion_do
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;

            //do
            //{
            //    //codigo
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while ( i<=10);

            //INICIO
            //   1. mostrar el menu
            //    2. hacer qu el usuario escoja una opcion
            //    3. si la opcion no estra dentro de las mostradas, volver a ensenar en menu hasta que el usuario escoja una opcion valida
            //    4. pedir 2 numeros con los cuales realizar las operaciones
            //    5. sumar, restar, multiplicar o dividir segun sea el caso 
            //    6. mostrar el resultado

            //FIN

            //INICIO

            //variables 
            //    decimal: num1, num2, resultado
            //    byte: opcion

            //hacer

            //escribir("1. suma");
            //escribir("2. resta");
            //escribir("3. multiplicaion");
            //escribir("4. division");
            //escribir("5. escone una opcion: ");
            //leer (opcion)

            //mientras((opcion < 1) || (opcion > 4) )

            //escribir("dame el primer numero");
            //leer(num1)
            //escribir("dame el segungo numero");
            //leer(mun2)

            //segun sea (opcion)

            //en caso opcion: 1
            //    resultado = num1 + num2
            //    salir

            //en caso opcion: 2
            //    resultado = num1 - num2
            //    salir

            //en caso opcion: 3 
            //    resultado = num1 * num2
            //    salir

            //en caso opcion: 4 
            //    si num2 != 0 entoces 
            //    resultado = num1 / num2

            //    fin si

            //sino
            //    escribir("No es posible dividir entre cero")
            // fin sino
            //salir

            //    Escribir("El resultado es: ", resultado)
            //FIN



            //variables
            decimal num1, num2, resultado = 0M;
            byte opcion;
            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToByte(Console.ReadLine());

            }
            while ((opcion < 1) || (opcion > 4));
            
                Console.Write("Ingrese el primer numero: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Ingrese el segundo numero: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;

                case 2:
                    resultado = num1 - num2;
                    break;

                case 3:
                    resultado = num1 * num2;
                    break;

                case 4: 
                if(num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No es posible dividir entre cero");
                    }
                    break;

            }                 
            Console.WriteLine("El resultado es:{0}", resultado);

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA
{
    internal class Class_Miscelanea
    {
        static void Main(string[] args)
        {
            do
            {
                int menuprincipal = 0;
                try
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("\nMENU PRINCIPAL");
                    Console.WriteLine("Elija la opcion que desea: " +
                    "\n1 Operadores. " +
                    "\n2 Condicionales. " +
                    "\n3 Ciclos. " +
                    "\n9 Salir.");

                    menuprincipal = Convert.ToInt32(Console.ReadLine());

                    int num1;
                    int num2;
                    int num3;
                    switch (menuprincipal)
                    {
                        case 1:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Elija la opcion que desea: " +
                            "\n1 Área del triangulo. " +
                            "\n2 Suma de dos numeros. " +
                            "\n3 Numero elevado al cuadrado. " +
                            "\n4 Convertir euros a dolares. " +
                            "\n5 Area y perimetro de un cuadrado. " +
                            "\n6 Area y volumen de un cilindro. " +
                            "\n7 Longitud y area de una circunferencia. " +
                            "\n8 Promedio de tres numeros. " +
                            "\n9 Salir.");

                            int submenu1_operadores = Convert.ToInt32(Console.ReadLine());
                            #region"OPERADORES"
                            switch (submenu1_operadores)
                            {
                                case 1:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Área del triangulo");
                                    Console.WriteLine("Ingrese un numero para la base del triangulo: ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Ingrese un numero para la altura del triangulo: ");
                                    num2 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("el area del triangulo es : " + (num1 * num2) / 2);
                                    break;

                                case 2:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Suma de dos numeros");
                                    Console.WriteLine("Ingrese un numero: ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Ingrese otro numero: ");
                                    num2 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("el resultado de la suma es : " + (num1 + num2));
                                    break;
                                case 3:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Numero elevado al cuadrado");
                                    Console.WriteLine("Ingrese un numero: ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("el resultado del numero al cuadrado es : " + Math.Pow(num1, 2));
                                    break;
                                case 4:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Convertir euros a dolares");
                                    Console.WriteLine("Ingrese un monto: ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine(num1 + " euros a dolares es : " + (num1 * 1.06 + " USD"));
                                    break;
                                case 5:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Area y perimetro de un cuadrado");
                                    Console.WriteLine("Ingrese un numero para el lado del cuadrado: ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("el resultado del area del cuadrado es : " + (num1 * 2) + " y el perimetro es: " + (num1 + num1 + num1 + num1));
                                    break;
                                case 6:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Area y volumen de un cilindro");
                                    Console.WriteLine("Ingrese un numero para la altura del cilindro: ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Ingrese un numero para la base del cilindro: ");
                                    num2 = (int)Convert.ToDouble(Console.ReadLine());
                                    num3 = (num2 / 2);
                                    Console.WriteLine("el resultado del area del cilindro es : " + (2 * 3.1416 * num3 * num1) + " y el volumen es: " + ((3.1416 * Math.Pow(num3, 2)) * num1));
                                    break;
                                case 7:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Longitud y area de una circunferencia");
                                    Console.WriteLine("Ingrese un numero para el radio de la circunferencia: ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("la longitud de la circunferencia es : " + (2 * 3.1416) * num1 + " y el area es: " + (3.1416 * Math.Pow(num1, 2)));
                                    break;
                                case 8:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Promedio de tres numeros");
                                    Console.WriteLine("Ingrese un numero : ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Ingrese otro numero : ");
                                    num2 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Ingrese otro numero : ");
                                    num3 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("el promedio de los 3 numeros es : " + (num1 + num2 + num3));
                                    break;
                                case 9:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Salir");
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Dato invalido");
                                        break;
                                    }
                            }
                            break;
                        #endregion

                        #region"CONDICIONALES"
                        case 2:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Elija la opcion que desea: " +
                            "\n1 Numero positivo o negativo. " +
                            "\n2 Numero mayor y menor. " +
                            "\n3 Tres numeros mayor y menor. " +
                            "\n4 Dos numeros, sumar si A es menor que B, si no restar. " +
                            "\n5 Cociene entre A y B. " +
                            "\n6 Dos numeros, sumar si al menos uno es negativo, si no multiplicar. " +
                            "\n7 Año biciestro. " +
                            "\n9 Salir.");

                            int submenu2_condicionales = Convert.ToInt32(Console.ReadLine());
                            switch (submenu2_condicionales)
                            {
                                case 1:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Numero positivo o negativo");
                                    Console.WriteLine("Ingrese un numero: ");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    if (num1 > 0)
                                    {
                                        Console.WriteLine("Positivo");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Negativo");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Numero mayor y menor");
                                    Console.WriteLine("Ingrese un numero: ");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese otro numero: ");
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    if (num1 == num2)
                                    {
                                        Console.WriteLine("El numero " + num1 + " es igual al numero " + num2 + " por lo tanto, ninguno es mayor o menor que el otro");
                                    }
                                    else if (num1 > num2)
                                    {
                                        Console.WriteLine("El numero " + num1 + " es mayor, y el numero " + num2 + " es menor");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero " + num1 + " es menor, y el numero " + num2 + " es mayor");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Tres numeros mayor y menor");
                                    Console.WriteLine("Ingrese un numero: ");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese otro numero: ");
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese un numero: ");
                                    num3 = Convert.ToInt32(Console.ReadLine());
                                    if (num1 < num2 && num1 < num3)
                                    {
                                        Console.WriteLine("El numero menor es el: " + num1);
                                    }
                                    else if (num1 > num2 && num1 > num3)
                                    {
                                        Console.WriteLine("El numero mayor es el: " + num1);
                                    }
                                    else if (num2 < num1 && num2 < num3)
                                    {
                                        Console.WriteLine("El numero menor es el: " + num2);
                                    }
                                    else if (num2 > num1 && num2 > num3)
                                    {
                                        Console.WriteLine("El numero mayor es el: " + num2);
                                    }
                                    else if (num3 < num2 && num3 < num1)
                                    {
                                        Console.WriteLine("El numero menor es el: " + num3);
                                    }
                                    else if (num3 > num2 && num3 > num1)
                                    {
                                        Console.WriteLine("El numero mayor es el: " + num3);
                                    }
                                    else
                                    {
                                        Console.WriteLine("hay dos o tres numeros iguales, proceso invalido");
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Dos numeros, sumar si A es menor que B, si no restar");
                                    Console.WriteLine("Ingrese un numero: ");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese otro numero: ");
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    if (num1 == num2)
                                    {
                                        Console.WriteLine("No se tiene operacion");
                                    }
                                    else if (num1 < num2)
                                    {
                                        Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
                                    }
                                    else
                                    {
                                        Console.WriteLine("La resta de los dos numeros es: " + (num1 - num2));
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Cociene entre A y B");
                                    Console.WriteLine("Ingrese un numero para el dividendo: ");
                                    num1 = (int)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Ingrese otro numero para el divisor: ");
                                    num2 = (int)Convert.ToDouble(Console.ReadLine());
                                    if (num2 == 0)
                                    {
                                        Console.WriteLine("La division no es posible");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El cociente de la division es: " + (num1 / num2));
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Dos numeros, sumar si al menos uno es negativo, si no multilicar");
                                    Console.WriteLine("Ingrese un numero: ");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese otro numero: ");
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    if (num1 < 0)
                                    {
                                        Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
                                    }
                                    else if (num2 < 0)
                                    {
                                        Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
                                    }
                                    else
                                    {
                                        Console.WriteLine("La multiplicacion de los dos numeros es: " + (num1 * num2));
                                    }
                                    break;
                                case 7:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Año biciestro");
                                    Console.WriteLine("Ingrese el año que desee: ");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    if (num1 / 4 == 0)
                                    {
                                        if (num1 / 100 == 0)
                                        {
                                            if (num1 / 400 == 0)
                                            {
                                                Console.WriteLine("Si, el año" + num1 + " es un año biciestro");
                                            }
                                            else
                                            {
                                                Console.WriteLine("No, el año" + num1 + " no es un año biciestro");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Si, el año" + num1 + " es un año biciestro");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No, el año" + num1 + " no es un año biciestro");
                                    }
                                    break;
                                case 9:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Salir");
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Dato invalido.");
                                        break;
                                    }
                            }
                            break;
                        #endregion

                        #region"CICLOS"
                        case 3:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Elija la opcion que desea: " +
                            "\n1 Multiplos de 3 que hay entre 1 y 100. " +
                            "\n2 Numeros impares entre 0 y 100. " +
                            "\n3 Numeros pares del 1 al 100. " +
                            "\n4 Cuadrado de los numeros del 1 al 30. " +
                            "\n5 Sumar cuadrados de los cien primeros numeros naturales. " +
                            "\n6 Numeros comprendidos de manera ascendente, con dos numeros naturales. " +
                            "\n7 Suma de todos los numeros mientras no sea cero. " +
                            "\n9 Salir.");

                            int submenu3_Ciclos = Convert.ToInt32(Console.ReadLine());
                            switch (submenu3_Ciclos)
                            {
                                case 1:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Multiplos de 3 que hay entre 1 y 100");
                                    for (num1 = 3; num1 <= 100; num1 += 3)
                                    {
                                        Console.WriteLine("Primer multiplo de 3: " + num1);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Numeros impares entre 0 y 100");
                                    for (num1 = 1; num1 <= 100; num1 += 2)
                                    {
                                        Console.WriteLine("El numero impar es: " + num1);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Numeros pares del 1 al 100");
                                    for (num1 = 2; num1 <= 100; num1 += 2)
                                    {
                                        Console.WriteLine("El numero par es: " + num1);
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Cuadrado de los numeros del 1 al 30");
                                    for (num1 = 1; num1 <= 30; num1++)
                                    {
                                        Console.WriteLine("El cuadrado del numero " + num1 + " es: " + Math.Pow(num1, 2));
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Sumar cuadrados de los cien primeros numeros naturales");
                                    num2 = 0;
                                    num1 = 0;
                                    for (num1 = 0; num1 <= 100; num1++)
                                    {
                                        Console.WriteLine("El cuadrado del numero " + num1 + " es: " + Math.Pow(num1, 2));
                                        num2 = num2 + (int)Math.Pow(num1, 2);
                                    }
                                    Console.WriteLine("La suma de todos los numeros es: " + num2);
                                    break;
                                case 6:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Numeros comprendidos de manera ascendente, con dos numeros naturales");
                                    Console.WriteLine("Ingrese dos numeros, el primero menor que el segundo");
                                    Console.WriteLine("Ingrese un numero");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Ingrese el otro numero");
                                    num2 = Convert.ToInt32(Console.ReadLine());
                                    num3 = 0;
                                    for (num3 = num1; num3 <= num2; num3++)
                                    {
                                        Console.WriteLine("numero " + num3);
                                    }
                                    break;
                                case 7:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Suma de todos los numeros mientras no sea cero");
                                    num1 = 0;
                                    num2 = 0;
                                    do
                                    {
                                        Console.WriteLine("Ingrese un numero");
                                        num1 = Convert.ToInt32(Console.ReadLine());
                                        num2 = num2 + num1;
                                    } while (num1 != 0);
                                    Console.WriteLine("La suma de todos los numeros es: " + num2);
                                    break;
                                case 9:
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("Salir");
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Dato invalido.");
                                        break;
                                    }
                            }
                            break;
                            #endregion
                    }
                    Console.WriteLine("----------------------");
                    Console.WriteLine("\nPresione una tecla, para ir al MENU PRINCIPAL");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("No has introducido un valor numerico");
                }
            } while (true);
        }
    }
}

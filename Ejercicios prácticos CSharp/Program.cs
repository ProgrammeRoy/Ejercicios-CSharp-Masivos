using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_CSharp
{
  class Program
  {
    static void Main(string[] args)
    {

      Ejercicio17();




    }

    static void Ejercicio1()
    {
      //Ejercicio 1. Ingresar 5 números y mostrar su promedio

      Console.WriteLine("Ejercicio 1. Ingresar 5 números y mostrar su promedio");

      try
      {
        Console.WriteLine("Ingresa 5 números:");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float d = float.Parse(Console.ReadLine());
        float e = float.Parse(Console.ReadLine());

        float promedio = (a + b + c + d + e) / 5;
        Console.WriteLine("Promedio: {0}", promedio);
      }
      catch (FormatException fe)
      {
        Console.WriteLine(fe.Message);
        Console.WriteLine("Debes ingresar un número");
      }
      Console.WriteLine("");
    }

    static void Ejercicio2()
    {
      //Ejercicio 2. Ingresar un número y mostrar el cuadrado del mismo.El número debe ser mayor que cero, en caso de error que aparezca el mensaje "ERROR. Reingresar numero"

      Console.WriteLine("Ejercicio 2. Ingresar un número y mostrar el cuadrado del mismo.El número debe ser mayor que cero, en caso de error que aparezca el mensaje ERROR.Reingresar numero");

      Console.Write("Ingresa un número mayor a cero: ");


      float numero = 0;

      while (numero <= 0)
      {
        try
        {
          numero = float.Parse(Console.ReadLine());
          if (numero <= 0)
          {
            Console.WriteLine("ERROR.Ingresar un número mayor a 0");
          }
        }
        catch (FormatException e)
        {
          Console.WriteLine(e.Message);
          Console.WriteLine("ERROR.Reingresar numero");
        }

      }

      float AlCuadrado = numero * numero;
      Console.WriteLine("Número al cuadrado es: {0}", AlCuadrado);
    }

    static void Ejercicio3()
    {
      //Ejercicio 3. De 10 números ingresados indicar cuantos son mayores a cero y cuantos son menores a cero. 

      Console.WriteLine("Ejercicio 3. De 10 números ingresados indicar cuantos son mayores a cero y cuantos son menores a cero");
      Console.WriteLine("Ingresa 10 números");
     
      int positivos = 0;
      int negativos = 0;

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Número {0}: ", i+1);
        float numero = float.Parse(Console.ReadLine());
        if (numero > 0)
        {
          positivos++;
        }else if(numero < 0)
        {
          negativos++;
        }
      }
      Console.WriteLine("{0} números son mayores a cero", positivos);
      Console.WriteLine("{0} números son menores a cero", negativos);

    }

    static void Ejercicio4()
    {
      //Ejercicio 4. Diseñar un algoritmo que calcule la longitud de la circunferencia y el área del círculo de radio dado.
      Console.WriteLine("Ejercicio 4. Diseñar un algoritmo que calcule la longitud de la circunferencia y el área del círculo de radio dado");

      Console.WriteLine("Ingresa la distancia del Radio: ");
      float Radio = float.Parse(Console.ReadLine());
      float Longitud = 2f * Radio *3.14f;
      Console.WriteLine("Longitud circular: {0}", Longitud);
      float Area = 3.14f * Radio * Radio;
      Console.WriteLine("Area circular: {0}", Area);
    }

    static void Ejercicio5()
    {
      //Ejercicio 5. Diseñar un algoritmo que calcule la superficie de un triángulo a partir del ingreso de su base y altura y muestre el resultado
      Console.WriteLine("Ejercicio 5. Diseñar un algoritmo que calcule la superficie de un triángulo a partir del ingreso de su base y altura y muestre el resultado");

      Console.WriteLine("Ingresa Altura: ");
      float Altura = float.Parse(Console.ReadLine());
      Console.WriteLine("Ingresa Base: ");
      float Base = float.Parse(Console.ReadLine());
      float Area = Altura * Base / 2;
      Console.WriteLine("Area: {0}", Area);
    }


    static void Ejercicio6()
    {
      //Ejercicio 6. Ingresar un número e indicar si es positivo o negativo
      Console.WriteLine("Ejercicio 6. Ingresar un número e indicar si es positivo o negativo");
      Console.WriteLine("Ingresa un número cualquiera");
      float numero = float.Parse(Console.ReadLine());
      if (numero < 0)
      {
        Console.WriteLine("{0} es negativo", numero);
      }else if(numero > 0)
      {
        Console.WriteLine("{0} es positivo", numero);
      }
      else
      {
        Console.WriteLine("El número es Cero");
      }
    }

    static void Ejercicio7()
    {
      //Ejercicio 7. Ingresar un número y mostrar si es par o impar
      Console.WriteLine("Ejercicio 7. Ingresar un número y mostrar si es par o impar");

      Console.WriteLine("Ingresa un número entero: ");
      int numero = int.Parse(Console.ReadLine());
      if (numero % 2 == 0)
      {
        Console.WriteLine("{0} es un número par", numero);
      }
      else
      {
        Console.WriteLine("{0} es un número impar", numero);
      }
    }

    static void Ejercicio8()
    {
      //Ejercicio 8. Equivalencia de Grados Celsius con Grados Fahrenheit
      Console.WriteLine("Ejercicio 8. Equivalencia de Grados Celsius con Grados Fahrenheit");
      Console.WriteLine("Ingresa la cantidad de grados a convertir:");
      float grados = float.Parse(Console.ReadLine());
      float gradosCelsius;
      float gradosFarenheit = 0;
      Console.WriteLine("A que tipo de grado transformar?");
      Console.WriteLine("1. Celsius");
      Console.WriteLine("2. Fahrenheit");
      float opcion = float.Parse(Console.ReadLine());
      if(opcion == 1)
      {
        gradosCelsius = (grados-32) * 5/9;
        Console.WriteLine("Grados en Celsius: {0}", gradosCelsius);
      } else if(opcion == 2)
      {
        gradosFarenheit = (grados * 9 / 5) + 32;
        Console.WriteLine("Grados en Farenheit: {0}", gradosFarenheit);
      }
      else
      {
        Console.WriteLine("No ha ingresado uno de los valores propuestos");
      }
    }

    static void Ejercicio9()
    {
      //Ejercicio 9. Equivalencia de centimetros con pies y pulgadas
      Console.WriteLine("Ejercicio 9. Equivalencia de centimetros con pies y pulgadas");
      Console.WriteLine("Ingresa un número en centímetros");
      float numero = float.Parse(Console.ReadLine());
      Console.WriteLine("En que lo quieres convertir?");
      Console.WriteLine("1. Pies");
      Console.WriteLine("2. Pulgadas");
      int opcion = int.Parse(Console.ReadLine());

      if (opcion == 1)
      {
        float Pies = numero * 3280/100000;
        Console.WriteLine("Número en Pies: {0}", Pies);
      } else if(opcion == 2)
      {
        float Pulgadas = numero * 3937 / 10000;
        Console.WriteLine("Número en Pulgadas: {0}", Pulgadas);
      }
      else
      {
        Console.WriteLine("El número ingresado no se encuentra entre las alternativas");
      }
    }

    static void Ejercicio10() 
    {
      //Ejercicio 10. Ingresar una frase no mas de 20 caracteres y mostrar cuantas vocales tiene. PENDIENTEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
      Console.WriteLine("Ejercicio 10. Ingresar una frase no mas de 20 caracteres y mostrar cuantas vocales tiene.");

      Console.WriteLine("Ingresa una frase de no más de 20 caracteres");
      string frase = Console.ReadLine();
      if (frase.Length<=20)
      {
        
      }
      else
      {
        Console.WriteLine("La cadena de texto excedió el límite");
      }
      Console.WriteLine("Tamaño de la frase {0}", frase.Length);
    }

    static void Ejercicio11()
    {
      //Ejercicio 11. Mostrar en pantalla la opción que se eligio, teniendo en cuenta los dias de la semana y pregutnar si desea continuar.
      Console.WriteLine("Ejercicio 11. Mostrar en pantalla la opción que se eligio, teniendo en cuenta los dias de la semana y pregutnar si desea continuar.");

      Console.WriteLine("Elegir un día de la semana: ");
      Console.WriteLine("1.");
      Console.WriteLine("2.");
      Console.WriteLine("3.");
      Console.WriteLine("4.");
      Console.WriteLine("5.");
      Console.WriteLine("6.");
      Console.WriteLine("7.");
      string opcion = Console.ReadLine();

      switch (opcion)
      {
        case "1":
          Console.WriteLine("Elegiste el Lunes");
          break;
        case "2":
          Console.WriteLine("Elegiste el Martes");
          break;
        case "3":
          Console.WriteLine("Elegiste el Miercoles");
          break;
        case "4":
          Console.WriteLine("Elegiste el Jueves");
          break;
        case "5":
          Console.WriteLine("Elegiste el Viernes");
          break;
        case "6":
          Console.WriteLine("Elegiste el Sábado");
          break;
        case "7":
          Console.WriteLine("Elegiste el Domingo");
          break;
        default:
          Console.WriteLine("No elegiste la opción correcta");
          break;
      }
    }

    static void Ejercicio12()
    {
      //Ejercicio 12. Mostrar los nùmeros impares entre el 0 y el 100
      Console.WriteLine("Ejercicio 12. Mostrar los nùmeros impares entre el 0 y el 100");
      Console.WriteLine("Número impar: 1");

      for (int i = 2; i < 101; i++)
      {
        if (i % 2 != 0)
        {
          Console.WriteLine("Número impar: {0}", i);
        }
      }
    }

    static void Ejercicio13()
    {
      //Ejercicio 13. Mostrar los números pares entre el 0 y el 100
      Console.WriteLine("Ejercicio 13. Mostrar los números pares entre el 0 y el 100");

      for (int i = 1; i < 101; i++)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine("Número par: {0}", i);
        }
      }
    }

    static void Ejercicio14()
    {
      //Ejercicio 14. Mostrar los números del 0 al 100
      Console.WriteLine("Ejercicio 14. Mostrar los números del 0 al 100");
      for (int i = 0; i < 101; i++)
      {
        Console.WriteLine("Número: {0}", i);
      }
    }

    static void Ejercicio15()
    {
      //Ejercicio 15. Mostrar los números del 100 al 0
      Console.WriteLine("Ejercicio 15. Mostrar los números del 100 al 0");
      for (int i = 100; i >= 0; i--)
      {
        Console.WriteLine("Número: {0}",i);
      }
    }

    static void Ejercicio16()
    {
      //Ejercicio 16. Mostrar los multiplos de 3 del 0 al 100
      Console.WriteLine("Ejercicio 16. Mostrar los multiplos de 3 del 0 al 100");
      for (int i = 0; i < 101; i++)
      {
        if (i % 3 == 0)
        {
          Console.WriteLine("Número múltiplo de 3: {0}", i);
        }
      }
    }

    static void Ejercicio17()
    {
      //Ejercicio 17. Mostrar los multiplos de 3 y de 2 entre el 0 y 100
      Console.WriteLine("Ejercicio 17. Mostrar los multiplos de 3 y de 2 entre el 0 y 100");
      for (int i = 1; i < 101; i++)
      {
        if (i % 2 == 0 && i % 3 == 0)
        {
          Console.WriteLine("Números multiplo de 2 y 3: {0}",i);
        }
      }
    }

    //Ejercicio 18. Ingresar un número y mostrar la suma de los números que lo anteceden.

    //Ejercicio 19. Mostrar los números del 1 hasta el número ingresado.

    //Ejercicio 20. Contar los multiplos de 3 desde la unidad hasta un num que ingresamos

    //Ejercicio 21. Mostrar los números primos entre el 0 y 100.

    //Ejercicio 22. Ingresar 10 números sumar los + y multiplicar los - .

    //Ejercicio 23. Ingresar dos números e intercambiarlos .

    //Ejercicio 24. Ingresar un número y mostrar su cuadrado y cubo.

    //Ejercicio 25. Ingresar x cant de pesos y mostrar la cantidad de personas que pesan + de 80 y - de 80.

    //Ejercicio 26. Ingresar 3 datos y decir que clase de triangulo es. Para formar un triangulo hay que tener en cuenta que la suma de sus dos las inferiores tiene que ser mayor a el lado superior

    //Ejercicio 27. Dados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo

    //Ejercicio 28. Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado, la antiguedad y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar teniendo en cuenta que al total que resuelta de multiplicar el valor hora por la cantidad de horas trabajadas, hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas esas operaciones restarle el 13% en concepto de descuentos. Imprimir el recibo correspondiente con el nombre, la antiguedad, el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar.

    //Ejercicio 29. Realizar la tabla de multiplicar de un número entre 0 y 10 de forma que se visualice de la siguiente forma: 4x1=4 

    //Ejercicio 30. Ingresar 2 números, imprima los números naturales que hay entre ambos empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares.

    //Ejercicio 31. Se registran 10 empleados de una empresa Número de legajo, sueldo, sexo(1=femenino y 2=masculino).Mostrar cuantas mujeres ganan más de $500 pesos y cuantos hombres ganan menos de $400.

    //Ejercicio 32. Se ingresa por teclado la cantidad de agua caida, en mílimetros día a día durante un mes.Se pide determinar el día de mayor lluvia, el de menor y el promedio.

    //Ejercicio 33. Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números que vamos introduciendo por teclado.

    static void Ejercicio34()
    {
      //Ejercicio 34. Recibe un número e imprime solo números primos del cero hasta aquel número en orden ascendente
      Console.WriteLine("Ejercicio 34. Recibe un número e imprime solo números primos del cero hasta aquel número en orden ascendente");
      Console.WriteLine("Ingresa un número: ");
      int numero = int.Parse(Console.ReadLine());
      

      for (int i = 1; i <= numero; i++)
      {
        int contador = 0;
        for (int j = 1; j <= i; j++)
        {
          if(i % j == 0)
          {
            contador ++;
          }
        }
        if(contador == 2)
        {
          Console.WriteLine("Número primo: {0}",i);
        }
      }
    }

    //TODO: Pendiente 
    static void Ejercicio35()
    {
      //Ejericio35. Arrego de 5 variables que se ordene ascendentemente 
      Console.WriteLine("Ejericio35. Arreglo de 5 variables que se ordene ascendentemente");

      int[] arreglo = new int[] { 5, 4, 3, 2, 1 };

      for (int i = 0; i < arreglo.Length; i++)
      {
        for (int j = 0; j < arreglo.Length; j++)
        {
          if (arreglo[i] < arreglo[j])
          {

          }
        }
      }

      for (int i = 0; i < arreglo.Length; i++)
      {
        Console.WriteLine(arreglo[i]);
      }
    
    }

  }
}
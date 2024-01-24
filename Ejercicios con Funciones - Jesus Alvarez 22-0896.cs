using System;

class Program 
{
  
  public static void Main (string[] args) 
  {
    // Crear un programa en C# que utilice funciones para determinar si un año es bisiesto

    Console.WriteLine("Ingrese un año");
    string year = Console.ReadLine();

    if (!string_check(year) && !negativo(year))
    {
        leap(year);
    }
  }

  static void leap(string year) // Funcion para determinar si el año es bisiesto
  {
    int leap_year = Convert.ToInt32(year);
    
    if (leap_year % 4 == 0)
    {
      Console.WriteLine("El año " + leap_year + " es bisiesto");
    }
    else
    {
      Console.WriteLine("El año " + leap_year + " no es bisiesto");
    }  
  }

  static bool string_check(string year) // Funcion para verificar si el año ingresado es un numero 
  {
    try
    {
      int num = Convert.ToInt32(year);
      return false;
    }
    catch (FormatException)
    {
      Console.WriteLine("El valor ingresado no es un año válido");
      return true; 
    }
  }

  static bool negativo(string year) // Funcion para verificar si el año ingresado es negativo
  {
    try
    {
      int neg = Convert.ToInt32(year);
      if (neg < 0)
      {
        Console.WriteLine("El año no puede ser negativo");
        return true;
      }
    }
    catch (FormatException)
    {
      Console.WriteLine("El valor ingresado no es un año válido");
      return true;
    }
    return false; 
  }
  
}
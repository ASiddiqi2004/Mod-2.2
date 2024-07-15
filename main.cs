using System;

using System.Globalization;
class Program {
  public static void Main (string[] args) {
  
        const double startrate = 200;
        const double rateperhour = 150;
        const double ratepermile = 2;
    
        double hours, miles;
        double estimatedamount;

        Console.Write("Enter the # of hours: ");
        hours = Convert.ToDouble(Console.ReadLine());

  
        Console.Write("Enter the # of miles: ");
        miles = Convert.ToDouble(Console.ReadLine());

        estimatedamount = startrate + rateperhour*hours + ratepermile*miles;
    
        Console.WriteLine("Estimated Amount = $ {0}", estimatedamount);
      }
    }
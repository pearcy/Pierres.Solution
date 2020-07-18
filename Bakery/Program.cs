using System;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Each loaf of bread is $5 but we have a bread special - buy 2, get 1 free.");
      Console.WriteLine("Each pastry is $2 or get 3 for $5");

      Console.WriteLine("Enter the number of Bread loaves");
      int inputBread = int.Parse(Console.ReadLine());
      Bread newBread = new Bread();
      int priceBread = newBread.GetBreadPrice(inputBread);

       Console.WriteLine("Enter the number of Pastries");
       int inputPastry = int.Parse(Console.ReadLine());
       Pastry newPastry = new Pastry();
       int pricePastry = newPastry.GetPastryPrice(inputPastry);


      Console.WriteLine("Your total is: $ ");


      

    
       







    }


  }
}
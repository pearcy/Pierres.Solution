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
     
      int input = int.Parse(Console.ReadLine());
      Bread newInput = new Bread();

      int price = newInput.GetBreadPrice(input);
  

      //  Console.WriteLine ("Your total is " + (price.GetBreadPrice()));
       Console.WriteLine("Your total is: $ " + price);


      

    
       







    }


  }
}
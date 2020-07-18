using System;
using Bakery.Models;

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
       int breadOrder = int.Parse(Console.ReadLine());
       Console.WriteLine("Enter the number of Pastries");
       int pastryOrder = int.Parse(Console.ReadLine());
       Bread bread = new Bread(breadOrder);
       bread.GetBreadPrice = breadOrder;
       Pastry pastry = new Pastry(pastryOrder);

       Console.WriteLine ("Your total price is " + (bread.GetBreadPrice() + pastry.GetPastryPrice()));




  
      

    
       







    }


  }
}
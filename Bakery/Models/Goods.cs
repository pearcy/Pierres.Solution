using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    int price = 0;
    public int GetPrice(string qty)
    {
      
      // int price = 0; 
      
        if (qty == "one")
          {
            price = 5;
          }
          else 
          {
            price = 0;
          }


      return price;
  
    }
  }
}


using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    int price = 0;

    public int GetPrice(int qty)
    {
      
        if (qty == 1)
          {
            price = 5;
          }
          else if (qty == 2)
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


using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    int qty = 0;
    public int GetPrice(int qty)
    {
      
      int price = 0; 
      
        if (qty == 1)
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


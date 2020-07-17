using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    int price = 0;

    public int GetBreadPrice(int qty)
    {

      int baseBread = 5; 
      
        if (qty == 1)
          {
            price = 5;
          }
          else if (qty == 2)
          {
            price = 10;
          }
          else if (qty % 3 == 0)  // works for qty of 3 & 6
          {
            price = (baseBread * qty) - ((qty/3) * baseBread);
          }
           else if (qty % 3 != 0) // test for qty 4, 5, 7
          {
            price = (baseBread * (qty-1)) - ((qty/3) * baseBread) + baseBread;
          }
          else 
          {
            price = 0;
          }

      return price;
  
    }
  }

    public class Pastry
  {
    int price = 0;

    public int GetPastryPrice(int qty)
    {

      // int basePastry = 2; 
      
        if (qty == 1)
          {
            price = 2;
          }
          // else if (qty == 2)
          // {
          //   price = 4;
          // }
          // else if (qty % 3 == 0)  // works for qty of 3 & 6
          // {
          //   price = (basePastry * qty) - ((qty/3) * basePastry);
          // }
          //  else if (qty % 3 != 0) // test for qty 4, 5, 7
          // {
          //   price = (basePastry * (qty-1)) - ((qty/3) * basePastry) + basePastry;
          // }
          else 
          {
            price = 0;
          }

      return price;
  
    }
  }

}

// - Bread: Buy 2, get 1 free. A single loaf costs $5.
// - Pastry: Buy 1 for $2 or 3 for $5.


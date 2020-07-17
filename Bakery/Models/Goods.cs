using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    int price = 0;

    public int GetPrice(int qty)
    {

      int basePrice = 5; 
      
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
            price = (basePrice * qty) - ((qty/3) * basePrice);
          }
           else if (qty % 3 != 0) // test for qty 4, 5, 7
          {
            price = (basePrice * (qty-1)) - ((qty/3) * basePrice) + basePrice;
;
          }
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


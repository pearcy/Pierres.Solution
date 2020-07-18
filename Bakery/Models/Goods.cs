using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    int priceBread = 0;

    public int GetBreadPrice(int qty)
    {

      int baseBread = 5; 
      
        if (qty == 1)
          {
            priceBread = 5;
          }
          else if (qty == 2)
          {
            priceBread = 10;
          }
          else if (qty % 3 == 0)  
          {
            priceBread = (baseBread * qty) - ((qty/3) * baseBread);
          }
           else if (qty % 3 != 0) 
          {
            priceBread = (baseBread * (qty-1)) - ((qty/3) * baseBread) + baseBread;
          }
          else 
          {
            priceBread = 0;
          }

      return priceBread;
  
    }
  }

    public class Pastry
  {
    int pricePastry = 0;

    public int GetPastryPrice(int qty)
    {

      int basePastry = 2; 
      
        if (qty == 1)
          {
            pricePastry = 2;
          }
          else if (qty == 2)
          {
            pricePastry = 4;
          }
          else if (qty % 3 == 0)  
          {
            pricePastry = (qty/3) * 5;
          }
           else if (qty % 3 != 0) 
          {
            pricePastry = ((qty-1)/3)*5+basePastry;
          }
          else 
          {
            pricePastry = 0;
          }

      return pricePastry;
  
    }
  }

}




using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {

    public int qtyBread { get; set; }

    public Bread(int qty)
    {
      qtyBread = qty;
    }

    
    public int GetBreadPrice()
    {
      int priceBread = 0;
      int baseBread = 5; 
      
        if (qtyBread == 1)
          {
            priceBread = 5;
          }
          else if (qtyBread == 2)
          {
            priceBread = 10;
          }
          else if (qtyBread % 3 == 0)  
          {
            priceBread = (baseBread * qtyBread) - ((qtyBread/3) * baseBread);
          }
           else if (qtyBread % 3 != 0) 
          {
            priceBread = (baseBread * (qtyBread-1)) - ((qtyBread/3) * baseBread) + baseBread;
          }
          else 
          {
            priceBread = 0;
          }

      return priceBread;
  
    }
  }
}




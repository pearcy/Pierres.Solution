using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  
    public class Pastry
  {

     public int qtyPastry { get; set; }

     public Pastry(int qty)
    {
      qtyPastry = qty;
    }
    
    public int GetPastryPrice()
    {
      int pricePastry = 0;
      int basePastry = 2; 
      
        if (qtyPastry == 1)
          {
            pricePastry = 2;
          }
          else if (qtyPastry == 2)
          {
            pricePastry = 4;
          }
          else if (qtyPastry % 3 == 0)  
          {
            pricePastry = (qtyPastry/3) * 5;
          }
           else if (qtyPastry % 3 != 0) 
          {
            pricePastry = ((qtyPastry-1)/3)*5+basePastry;
          }
          else 
          {
            pricePastry = 0;
          }

      return pricePastry;
  
    }
  }

}




using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {

    [TestMethod]
    public void Bakery_GetPrice_BreadPrice()
    {
      Bread tester = new Bread();
      Assert.AreEqual(typeof(Bread), tester.GetType());
    }


    [TestMethod]
    public void Bakery_GetPrice_BreadPrice()
    {
    Bread tester = new Bread();
    int qty = tester.GetPrice(1);
    Assert.AreEqual(5, qty);
    }


  }
}


// There should be two classes: one for Bread and one for Pastry.

// A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

// The application will return the total cost of the order.

// Pierre offers the following deals:

// Bread: Buy 2, get 1 free. A single loaf costs $5.
// Pastry: Buy 1 for $2 or 3 for $5.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice()
    {
      Bread tester = new Bread();
      Assert.AreEqual(typeof(Bread), tester.GetType());
    }


    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice1()
    {
    Bread tester = new Bread();
    int price = tester.GetBreadPrice(1);
    Assert.AreEqual(5, price);
    }

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice2()
    {
    Bread tester = new Bread();
    int price = tester.GetBreadPrice(2);
    Assert.AreEqual(10, price);
    }

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice3()
    {
    Bread tester = new Bread();
    int price = tester.GetBreadPrice(3);
    Assert.AreEqual(10, price);
    }

   [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice4()
    {
    Bread tester = new Bread();
    int price = tester.GetBreadPrice(4);
    Assert.AreEqual(15, price);
    }

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice5()
    {
    Bread tester = new Bread();
    int price = tester.GetBreadPrice(5);
    Assert.AreEqual(20, price);
    }

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice6()
    {
    Bread tester = new Bread();
    int price = tester.GetBreadPrice(6);
    Assert.AreEqual(20, price);
    }

     [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice7()
    {
    Bread tester = new Bread();
    int price = tester.GetBreadPrice(7);
    Assert.AreEqual(25, price);
    }

    [TestMethod]
    public void Bakery_GetPastryPrice_PastryPrice1()
    {
    Pastry tester = new Pastry();
    int price = tester.GetPastryPrice(1);
    Assert.AreEqual(2, price);
    }

     [TestMethod]
    public void Bakery_GetPastryPrice_PastryPrice2()
    {
    Pastry tester = new Pastry();
    int price = tester.GetPastryPrice(2);
    Assert.AreEqual(4, price);
    }



  }
}


// - Pastry: Buy 1 for $2 or 3 for $5.
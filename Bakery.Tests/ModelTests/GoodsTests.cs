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
      Bread tester = new Bread(0);
      Assert.AreEqual(typeof(Bread), tester.GetType());
    }


    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice1()
    {
    Bread tester = new Bread(1);
    int price = tester.GetBreadPrice();
    Assert.AreEqual(5, price);
    }

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice2()
    {
    Bread tester = new Bread(2);
    int price = tester.GetBreadPrice();
    Assert.AreEqual(10, price);
    }

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice3()
    {
    Bread tester = new Bread(3);
    int price = tester.GetBreadPrice();
    Assert.AreEqual(10, price);
    }

   [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice4()
    {
    Bread tester = new Bread(4);
    int price = tester.GetBreadPrice();
    Assert.AreEqual(15, price);
    }

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice5()
    {
    Bread tester = new Bread(5);
    int price = tester.GetBreadPrice();
    Assert.AreEqual(20, price);
    }

    [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice6()
    {
    Bread tester = new Bread(6);
    int price = tester.GetBreadPrice();
    Assert.AreEqual(20, price);
    }

     [TestMethod]
    public void Bakery_GetBreadPrice_BreadPrice7()
    {
    Bread tester = new Bread(7);
    int price = tester.GetBreadPrice();
    Assert.AreEqual(25, price);
    }

    [TestMethod]
    public void Bakery_GetPastryPrice_PastryPrice1()
    {
    Pastry tester = new Pastry(1);
    int price = tester.GetPastryPrice();
    Assert.AreEqual(2, price);
    }

    [TestMethod]
    public void Bakery_GetPastryPrice_PastryPrice2()
    {
    Pastry tester = new Pastry(2);
    int price = tester.GetPastryPrice();
    Assert.AreEqual(4, price);
    }

    [TestMethod]
    public void Bakery_GetPastryPrice_PastryPrice3()
    {
    Pastry tester = new Pastry(3);
    int price = tester.GetPastryPrice();
    Assert.AreEqual(5, price);
    }

     [TestMethod]
    public void Bakery_GetPastryPrice_PastryPrice4()
    {
    Pastry tester = new Pastry(4);
    int price = tester.GetPastryPrice();
    Assert.AreEqual(7, price);
    }



  }
}


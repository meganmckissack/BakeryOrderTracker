using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryOrderTracker.Models;

namespace BakeryOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
      public void OrderConstructor_CreateInstanceOfOrder_Order()
      {
        Order newOrder = new Order("test");
        Assert.AreEqual(typeof(Order), newOrder.GetType());
      }

    [TestMethod]
    public void GetTitle_ReturnsInstanceTitle_String()
    {
      string title = "Coava coffee pastry order";
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_UpdatesInstanceTitle_String()
    {
      string title = "Coava coffee pastry order";
      Order newOrder = new Order(title);
      string updateTitle = "Coava coffe sandwich order";
      newOrder.Title = updateTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updateTitle, result);
    }
  }
}
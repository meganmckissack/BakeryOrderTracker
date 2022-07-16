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
        string description = "Coava's weekly order of scones";
        Order newOrder = new Order("test", description);
        Assert.AreEqual(typeof(Order), newOrder.GetType());
      }

    [TestMethod]
    public void GetTitle_ReturnsInstanceTitle_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      Order newOrder = new Order(title, description);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_UpdatesInstanceTitle_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      Order newOrder = new Order(title, description);
      string updateTitle = "Coava coffe sandwich order";
      newOrder.Title = updateTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updateTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsInstanceDescription_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      Order newOrder = new Order(title, description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_UpdatesInstanceDescription_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      Order newOrder = new Order(title, description);
      string updateDescription = "Coava's weekly sandwich order";
      newOrder.Description = updateDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updateDescription, result);
    }
  }
}
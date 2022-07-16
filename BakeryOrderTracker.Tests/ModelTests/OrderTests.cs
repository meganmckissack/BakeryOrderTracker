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
        int price = 50;
        Order newOrder = new Order("test", description, price);
        Assert.AreEqual(typeof(Order), newOrder.GetType());
      }

    [TestMethod]
    public void GetTitle_ReturnsInstanceTitle_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_UpdatesInstanceTitle_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      Order newOrder = new Order(title, description, price);
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
      int price = 50;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_UpdatesInstanceDescription_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      Order newOrder = new Order(title, description, price);
      string updateDescription = "Coava's weekly sandwich order";
      newOrder.Description = updateDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updateDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsInstancePrice_Int()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      Order newOrder = new Order(title, description, price);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_UpdatesInstancePrice_Int()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      Order newOrder = new Order(title, description, price);
      int updatePrice = 75;
      newOrder.Price = updatePrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatePrice, result);
    }

  }
}
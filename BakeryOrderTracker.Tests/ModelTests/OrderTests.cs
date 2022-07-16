using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryOrderTracker.Models;

namespace BakeryOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
      public void OrderConstructor_CreateInstanceOfOrder_Order()
      {
        string description = "Coava's weekly order of scones";
        int price = 50;
        string date =  "07-16-2020";
        Order newOrder = new Order("test", description, price, date);
        Assert.AreEqual(typeof(Order), newOrder.GetType());
      }

    [TestMethod]
    public void GetTitle_ReturnsInstanceTitle_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      string date =  "07-16-2020";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_UpdatesInstanceTitle_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      string date =  "07-16-2020";
      Order newOrder = new Order(title, description, price, date);
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
      string date =  "07-16-2020";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_UpdatesInstanceDescription_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      string date =  "07-16-2020";
      Order newOrder = new Order(title, description, price, date);
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
      string date =  "07-16-2020";
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_UpdatesInstancePrice_Int()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      string date =  "07-16-2020";
      Order newOrder = new Order(title, description, price, date);
      int updatePrice = 75;
      newOrder.Price = updatePrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatePrice, result);
    }
    
    [TestMethod]
    public void GetDate_ReturnsInstanceDate_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      string date =  "07-16-2020";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_UpdatesInstanceDate_String()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      string date =  "07-16-2020";;
      Order newOrder = new Order(title, description, price, date);
      string updateDate = "08-29-2020";
      newOrder.Date = updateDate;
      string result = newOrder.Date;
      Assert.AreEqual(updateDate, result);
    }

    [TestMethod]
    public void GetAllOrders_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order>{ };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAllOrders_ReturnsOrders_OrderLIst()
    {
      string title01 = "Coava coffee pastry order";
      string description01 = "Coava's weekly order of scones";
      int price01 = 50;
      string date01 =  "07-16-2020";
      string title02 = "Coava coffee sandwich order";
      string description02 = "Coava's weekly order of sandwiches";
      int price02 = 75;
      string date02 =  "08-29-2020";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newOrder = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetId_CreateOrdersWithIdAndReturnsId_Int()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      string date =  "07-16-2020";;
      Order newOrder = new Order(title, description, price, date);

      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindId_ResturnsOrderBasedOnId_Order()
    {
      string title01 = "Coava coffee pastry order";
      string description01 = "Coava's weekly order of scones";
      int price01 = 50;
      string date01 =  "07-16-2020";
      string title02 = "Coava coffee sandwich order";
      string description02 = "Coava's weekly order of sandwiches";
      int price02 = 75;
      string date02 =  "08-29-2020";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);

      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}
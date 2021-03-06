using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string vendorDescription = "Portland coffee shop with four locations";
      Vendor newVendor = new Vendor("test vendor", vendorDescription);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    } 

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string vendorName = "Coava Coffee";
      string vendorDescription = "Portland coffee shop with four locations";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetName_UpdatesVendorName_String()
    {
      string vendorName = "Coava Coffee";
      string vendorDescription = "Portland coffee shop with four locations";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string updateName = "St. Simon Coffee";
      newVendor.Name = updateName;
      string result = newVendor.Name;
      Assert.AreEqual(updateName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsVendorDescription_String()
    {
      string vendorName = "Coava Coffee";
      string vendorDescription = "Portland coffee shop with four locations";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string result = newVendor.Description;
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void SetDescription_UpdatesVendorDescription_String()
    {
      string vendorName = "Coava Coffee";
      string vendorDescription = "Portland coffee shop with four locations";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string updateDescription = "Portland coffee shop with four locations also gets gluten-free";
      newVendor.Description = updateDescription;
      string result = newVendor.Description;
      Assert.AreEqual(updateDescription, result);
    }

    [TestMethod]
    public void GetAllVendors_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newVendor = new List<Vendor>{ };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void GetAllVendors_ReturnsVendors_VendorLIst()
    {
      string vendorName01 = "Coava Coffee";
      string vendorDescription01 = "Portland coffee shop with four locations";
      string vendorName02 = "St. Simon Coffee";
      string vendorDescription02 = "Portland NE coffee shop with two nearby locations";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription02);
      List<Vendor> newVendor = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void GetId_CreateVendorsWithIdAndReturnsId_Int()
    {
      string vendorName = "Coava Coffee";
      string vendorDescription = "Portland coffee shop with four locations";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void FindId_ResturnsVendorBasedOnId_Vendor()
    {
      string vendorName01 = "Coava Coffee";
      string vendorDescription01 = "Portland coffee shop with four locations";
      string vendorName02 = "St. Simon Coffee";
      string vendorDescription02 = "Portland NE coffee shop with two nearby locations";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription02);
      List<Vendor> newVendor = new List<Vendor> { newVendor1, newVendor2 };

      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_ConntectsOrderWithVendor_OrderList()
    {
      string title = "Coava coffee pastry order";
      string description = "Coava's weekly order of scones";
      int price = 50;
      string date =  "07-16-2020";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };

      string vendorName = "Coava Coffee";
      string vendorDescription = "Portland coffee shop with four locations";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }

}
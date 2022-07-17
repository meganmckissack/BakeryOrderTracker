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
  }

}
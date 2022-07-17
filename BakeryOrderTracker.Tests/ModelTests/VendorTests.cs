using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    } 

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string vendorName = "Coava Coffee";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }
  }

}
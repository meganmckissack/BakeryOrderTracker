using System;
using System.Collections.Generic;  

namespace BakeryOrderTracker.Models
{
  public class Order 
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; }
    public static DateTime Today { get; set; }
    private static List<Order> _orders = new List<Order>{};

    public Order(string title)
    {
      Title = title;
    }
  }

}
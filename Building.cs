using System;
using System.Collections.Generic;

namespace Planner
{
  public class Building
  {
    private string _designer;
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }

    public Building(){}

    public string Designer(string designer)
    {
      return _designer = designer;
    }
    public DateTime Constructed()
    {
      return _dateConstructed = DateTime.Now;
    }
    public string Address(string address)
    {
      return _address = address;
    }
    public string Owner(string owner)
    {
      return _owner = owner;
    }

    public double Volume()
    {
      return Width * Depth * (3 * Stories);
    }

    // public string Description
    // {
    //   get
    //   {
    //     return $"Building: {Designer()} {Constructed()} {Owner()} {Volume()}";
    //   }
    // }

  }
}

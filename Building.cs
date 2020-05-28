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

    public string Designer()
    {
      return _designer;
    }
    public DateTime Constructed()
    {
      return _dateConstructed = DateTime.Now;
    }
    public string Address()
    {
      return _address;
    }
    public string Owner()
    {
      return _owner;
    }

    public double Volume()
    {
      return Width * Depth * (3 * Stories);
    }

    public string Description
    {
      get
      {
        return $"Building: {Designer()} {Constructed()} {Owner()} {Volume()}";
      }
    }

  }
}

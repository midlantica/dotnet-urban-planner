using System;
using System.Collections.Generic;

namespace Planner
{
  public class Building
  {
    private string _designer;
    // private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    public int Width { get; set; }
    public int Depth { get; set; }
    public int Stories { get; set; }

    public Building(){}

    public void Designer(string designer) => _designer += designer;
    public void Address(string address) => _address += address;
    public void Owner(string owner) => _owner += owner;

    public int SetVolume(int Width, int Depth, int Stories)
    {
      return Width * Depth * (3 * Stories);
    }

    public int GetVolume(int Width, int Depth, int Stories)
    {
      return Width * Depth * (3 * Stories);
    }
    // public double GetVolume(double Width, double Depth, int Stories)
    // {
    //   get
    //   {
    //     return $"{Width * Depth * (3 * Stories)}";
    //   }
    // }

    // DateTime
    // public DateTime Constructed() {
    //   DateTime dateConstructed = DateTime.Now;
    //   return _dateConstructed;
    // }

    public string GetDesigner() => _designer;
    public string GetAddress() => _address;
    public string GetOwner() => _owner;

    // public string GetConstructed() => _dateConstructed();

    public string GetDescription
    {
      get
      {
        return
        @$"
---------------------------------------------------
|  Address: {GetAddress()}
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
|  Designer:  | {GetDesigner()}
|  Date Time: | {DateTime.Now}
|  Owner:     | {GetOwner()}
|  Volume:    | {$"(Width * Depth * (3 * Stories))"}
---------------------------------------------------
        ";
      }
    }

  }
}

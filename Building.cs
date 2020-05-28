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

    public string Name { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public int Stories { get; set; }

    // 
    public Building(){}
    public void Designer(string designer) => _designer += designer;
    public void Address(string address) => _address += address;
    public void Owner(string owner) => _owner += owner;
    public int GetVolume() => Width * Depth * (3 * Stories);
    public void Constructed() => _dateConstructed = DateTime.Now;
    public string GetDesigner() => _designer;
    public string GetAddress() => _address;
    public string GetOwner() => _owner;
    public DateTime GetConstructed() => _dateConstructed;

    public string GetDescription
    {
      get
      {
        return
        @$"
---------------------------------------------------
|  Name:    {Name}
|  Address: {GetAddress()}
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
|  Designer:  | {GetDesigner()}
|  Date Time: | {GetConstructed()}
|  Owner:     | {GetOwner()}
|  Volume:    | {GetVolume()}
---------------------------------------------------
        ";
      }
    }

  }
}

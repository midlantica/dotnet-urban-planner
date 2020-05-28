using System;
using System.Collections.Generic;

namespace Planner
{
  public class City
  {
    public string Name { get; set; }
    public DateTime dateEstablished { get; set; }
    public string Mayor { get; set; }
    public int NumberOfBuildings { get;  set; }

    //
    public City(){}
    public void Established() => dateEstablished = DateTime.Now;
    public DateTime GetDateEstablished() => dateEstablished;

    public int GetBuildings() => NumberOfBuildings;
    public string GetDescription
    {
      get
      {
        return
        @$"
---------------------------------------------------
|  City:        | {Name}
|  Mayor:       | {Mayor}
|  Date & Time: | {GetDateEstablished()}
|  Buildings:   | {GetBuildings()} // ??
---------------------------------------------------
        ";
      }
    }

  }
}

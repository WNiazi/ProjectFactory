using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.EngineerMachineEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public Work IsWorking { get; set; }

    public DateTime DateOfHire { get; set; }

    public DateTime DateOfLicense { get; set; }
    public virtual ICollection<EngineerMachine> EngineerMachineEntities { get; set; }
  }

  public enum Work
  {
    Idle,
    Occupied
  }
}
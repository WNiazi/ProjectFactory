using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.EngineerMachineEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }
    public Operation IsOperational { get; set; }
    public DateTime DateOfInspection { get; set; }
    // public DateTime DateOfInstall { get; set; }

    public virtual ICollection<EngineerMachine> EngineerMachineEntities { get; }
  }

  public enum Operation
  {
    Functioning,
    Broken,

    Servicing
  }

}


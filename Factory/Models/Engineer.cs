using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>(); // navigation property. This is simply a property on Engineer class that includes a reference to Machine class.
    }

    public int EngineerId { get; set; }//two columns in our Engineer table
    public string Name { get; set; }//
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}
namespace Factory.Models
{
  public class EngineerMachine //join table
  {
    // no constructor because this class is just about storing data for the table

    public int EngineerMachineId { get; set; } // each of these are column in the EngineerMachine table
    public int MachineId { get; set; }
    public int EngineerId { get; set; }
    public virtual Machine Machine { get; set; }
    public virtual Engineer Engineer { get; set; }
  }
}
namespace Industrial_Fleet_Manager.Client.Models;

public class Machine
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsOnline { get; set; }
    public string LastData { get; set; }
    public DateTime LastUpdated { get; set; }
}

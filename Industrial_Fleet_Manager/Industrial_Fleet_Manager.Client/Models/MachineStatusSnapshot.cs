namespace Industrial_Fleet_Manager.Client.Models;

public class MachineStatusSnapshot
{
    public int Sequence { get; set; }
    public DateTime Timestamp { get; set; }
    public int OnlineCount { get; set; }
}

namespace Sprint.BL;

[Serializable]
public class XmlScheduleModel
{
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string TraineeName { get; set; }
    public string CourtName { get; set; }
}
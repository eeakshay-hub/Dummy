public class Incident
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime StartedAt    { get; set; }
}
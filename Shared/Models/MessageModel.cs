public class MessageModel
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }

    public MessageModel()
    {
        Id = Guid.NewGuid();
        Timestamp = DateTime.UtcNow;
    }
}
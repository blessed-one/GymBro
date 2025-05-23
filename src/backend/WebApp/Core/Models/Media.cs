namespace Core.Models;

public class Media
{
    public long Id { get; set; }
    public required string Uri { get; set; }
    
    public long PostId { get; set; }
    public required Post Post { get; set; }
}
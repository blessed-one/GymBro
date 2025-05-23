namespace Core.Models;

public class Like
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    
    public long PostId { get; set; }
    public required Post Post { get; set; }
    public long UserId { get; set; }
    public required User User { get; set; }
}
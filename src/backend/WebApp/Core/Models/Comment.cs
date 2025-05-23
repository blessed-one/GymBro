namespace Core.Models;

public class Comment
{
    public long Id { get; set; }
    public required string Content { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public long PostId { get; set; }
    public required Post Post { get; set; }
    public long UserId { get; set; }
    public required User User { get; set; }
}
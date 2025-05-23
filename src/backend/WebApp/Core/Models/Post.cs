namespace Core.Models;

public class Post
{
    public long Id { get; set; }
    public required string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public int CaloriesBurnt { get; set; }

    public long UserId { get; set; }
    public required User User { get; set; }
    
    public List<Like> Likes { get; set; } = [];
    public List<Comment> Comments { get; set; } = [];
    public List<Media> Media { get; set; } = [];
    public List<Workout> Workouts { get; set; } = [];
}
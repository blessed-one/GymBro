namespace Core.Models;

public class Follow
{
    public long Id { get; set; }
    public bool IsDeleted { get; set; }
    
    public long FollowerId { get; set; }
    public required User Follower { get; set; }
    public long FolloweeId { get; set; }
    public required User Followee { get; set; }
}
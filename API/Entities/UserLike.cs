namespace API.Entities
{
    public class UserLike
    {
     public appuser SourceUser { get; set; }  
     public int SourceUserId { get; set; }
     public appuser LikedUser { get; set; }
     public int LikedUserId { get; set; }
    }
}
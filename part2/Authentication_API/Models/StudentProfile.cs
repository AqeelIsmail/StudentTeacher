namespace Authentication_API.Models
{
    public class StudentProfile
    {
        public int StudentProfileId { get; set; } //PK
   
        public int UserId { get; set; } //FK
        public string StudentNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;       

        public string? ProfileImageUrl { get; set; }
        //navigation property
        public User User { get; set; } = null!;
    }
}

namespace Authentication_API.Models
{
    public class TeacherProfile
    {
        public int TeacherProfileId { get; set; }

        public int UserId { get; set; }

        public string EmployeeNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ProfileImageUrl { get; set; }

        //navigation property
        public User User { get; set; } = null!;
    }
}

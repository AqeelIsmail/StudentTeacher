using Authentication_API.Models;
namespace Authentication_API
{
    public class User
    {
        public int UserId { get; set; } //PK
        //account information
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // "Student" or "teacher"

        //navigation properties
        //--> allow EF Core to navigate from a User object to its related profile.
        //The ? indicates that the relationship may be absent. These are not additional columns in the Users table.
        public StudentProfile? StudentProfile { get; set; }
        public TeacherProfile? TeacherProfile { get; set; }
    }
}

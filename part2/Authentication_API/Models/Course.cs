
namespace Authentication_API.Models
{
    public class Course
    {

        public int CourseId { get; set; }//PK

        //FKs
        public int TeacherProfileId { get; set; }
        public int CourseCategoryId { get; set; }

        //Course info
        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? CourseImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }

        //Navigation properties
        public TeacherProfile TeacherProfile { get; set; } = null!;
        public CourseCategory CourseCategory { get; set; } = null!;
        public ICollection<Enrolment> Enrolments { get; set; } = new List<Enrolment>();
    }
}

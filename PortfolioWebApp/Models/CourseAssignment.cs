namespace ContosoUniversity.Models
{
    public class CourseAssignment
    {
        //foreign keys
        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
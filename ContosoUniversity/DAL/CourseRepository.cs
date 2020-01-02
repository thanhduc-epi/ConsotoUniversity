using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(SchoolContext context)
            : base(context)
        {
        }

        public int UpdateCourseCredits(double multiplier)
        {
            return _context.Database.ExecuteSqlCommand("UPDATE Course SET Credits = Credits * {0}", multiplier);
        }

    }
}
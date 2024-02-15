using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new CourseDal());

            List<Course> courses = courseManager.GetAll();

            foreach (var course in courses)
            {
                Console.WriteLine("Kurs adı: " + course.Name + " kurs eğitmeni: " + course.InstructorName);
            }


        }
    }
}

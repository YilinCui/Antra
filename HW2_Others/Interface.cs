using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Others
{
    public interface IPersonService
    {
        int CalculateAge(DateTime birthDate);
        decimal CalculateSalary(decimal baseSalary);
        List<Address> GetAddresses();
    }

    public interface IStudentService : IPersonService
    {
        List<Course> GetCourses();
        double CalculateGPA();
    }

    public interface IInstructorService : IPersonService
    {
        Department Department { get; set; }
        bool IsDepartmentHead();
        decimal CalculateBonusSalary();
        int CalculateExperience(DateTime joinDate);
    }

    public interface ICourseService
    {
        //List<Student> GetEnrolledStudents();
        char Grade { get; set; }
    }

    public interface IDepartmentService
    {
        IInstructorService DepartmentHead { get; set; }
        decimal Budget { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        List<Course> GetCourses();
    }

}

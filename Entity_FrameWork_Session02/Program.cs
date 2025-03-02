using Entity_FrameWork_Session02.Entities;
using Microsoft.EntityFrameworkCore;
namespace Entity_FrameWork_Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EnterPriceDBContext dBContext = new EnterPriceDBContext();
            Student student01 = new Student()
            {
                FName = "Sajeda",
                LName = "Mohamed",
                Address = "Cairo",
                Age = 20,
            };

            Student student02 = new Student()
            {
                FName = "Sara",
                LName = "Abdallah",
                Address = "Cairo",
                Age = 20,
            };

            #region Add
            //Console.WriteLine(dBContext.Entry(student01).State);

            //dBContext.Students.Add(student01);
            //dBContext.Students.Add(student02);

            //Console.WriteLine(dBContext.Entry(student01).State);

            //Console.WriteLine(dBContext.Entry(student02).State);
            //dBContext.SaveChanges();
            //Console.WriteLine(student01.Id);
            //Console.WriteLine(student02.Id);

            //dBContext.SaveChanges();
            #endregion

            #region Update
            //var Student = (from student in dBContext.Students
            //               where student.Id == 3
            //               select student).FirstOrDefault();
            //Console.WriteLine(dBContext.Entry(Student).State);

            //Student.FName = "Amal";

            //Console.WriteLine(dBContext.Entry(Student).State);
            //dBContext.SaveChanges(); 
            #endregion

            #region Remove
            //var Student = (from student in dBContext.Students
            //               where student.Id == 7
            //               select student).FirstOrDefault();

            //dBContext.Students.Remove(Student);

            //Console.WriteLine(dBContext.Entry(Student).State);
            //dBContext.SaveChanges();

            //Console.WriteLine(dBContext.Entry(Student).State); 
            #endregion

        }
    }
}

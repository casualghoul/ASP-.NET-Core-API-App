using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IS_460_Assignment_4_Andrew_Horton.Models;
using Microsoft.Extensions.DependencyInjection;

namespace IS_460_Assignment_4_Andrew_Horton.Data
{
    public class IS_460_Assignment_4_Andrew_HortonContext : DbContext
    {
        public IS_460_Assignment_4_Andrew_HortonContext (DbContextOptions<IS_460_Assignment_4_Andrew_HortonContext> options)
            : base(options)
        {
        }

        public DbSet<IS_460_Assignment_4_Andrew_Horton.Models.Student> Student { get; set; }

        public DbSet<IS_460_Assignment_4_Andrew_Horton.Models.Course> Course { get; set; }

        public class CreateSampleData
        {
            public static void Initialize(System.IServiceProvider serviceProvider)
            {
                var context = new
                    IS_460_Assignment_4_Andrew_HortonContext(serviceProvider.GetRequiredService<
                        DbContextOptions<IS_460_Assignment_4_Andrew_Horton.Data.IS_460_Assignment_4_Andrew_HortonContext>>());

                Models.Student s = new Models.Student();
                Models.Course c = new Models.Course();

                s.StudentID = 1;
                s.LastName = "Horton";
                s.FirstName = "Andrew";              
                context.Add(s);

                s = new Models.Student();
                s.StudentID = 2;
                s.LastName = "Baggins";
                s.FirstName = "Frodo";                
                context.Add(s);

                s = new Models.Student();
                s.StudentID = 3;
                s.LastName = "Gamgee";
                s.FirstName = "Sam";                
                context.Add(s);

                s = new Models.Student();
                s.StudentID = 4;
                s.LastName = "Oakenshield";
                s.FirstName = "Thorin";               
                context.Add(s);

                s = new Models.Student();
                s.StudentID = 5;
                s.LastName = "White";
                s.FirstName = "Gandalf";                
                context.Add(s);

                c = new Models.Course();
                c.CourseID = 1;
                c.Title = "Math";                
                context.Add(c);

                c = new Models.Course();
                c.CourseID = 2;
                c.Title = "Science";
                context.Add(c);

                c = new Models.Course();
                c.CourseID = 3;
                c.Title = "History";
                context.Add(c);

                context.SaveChanges();

            }

        }

        public DbSet<IS_460_Assignment_4_Andrew_Horton.Models.Enrollment> Enrollment { get; set; }
    }
}

using Election_System.Enumerations;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Configurations
{
    public static class SeedDatabase
    {
        public static void Seed(DataContext dataContext)
        {
            if (dataContext.Database.GetPendingMigrations().Count() == 0 && dataContext.students.Count() == 0)
            {
                dataContext.faculties.AddRange(faculties);
                dataContext.departments.AddRange(departments);
                dataContext.administrations.AddRange(administrations);
                dataContext.students.AddRange(students);
                dataContext.announcements.AddRange(announcements);
                dataContext.processes.AddRange(processes);

                dataContext.SaveChanges();
            }
        }

        private static Faculty[] faculties = new Faculty[]
        {
            new Faculty()
            {
                Name = "Engineering Faculty"
            }
        };

        private static Department[] departments = new Department[]
        {
            new Department()
            {
                Name = "Computer Engineering",
                Faculty = faculties[0]
            },
            new Department()
            {
                Name = "Electric-Electronic Engineering",
                Faculty = faculties[0]
            }
        };

        private static Administration[] administrations = new Administration[]
        {
            new Administration()
            {
                Username = "fatihyelboga@std.iyte.edu.tr",
                Password = "fatih123",
                FirstName = "Fatih",
                LastName = "YELBOGA",
                Gender = Gender.MALE,
                Role = Role.STUDENT_AFFAIR
            },
            new Administration()
            {
                Username = "enesdemirel@std.iyte.edu.tr",
                Password = "enes123",
                FirstName = "Enes",
                LastName = "DEMIREL",
                Gender = Gender.MALE,
                Role = Role.STUDENT_AFFAIR
            }
        };

        private static Student[] students = new Student[]
        {
            new Student()
            {
                Username = "osmanaltunay@std.iyte.edu.tr",
                Password = "osman123",
                FirstName = "Osman",
                LastName = "ALTUNAY",
                Gender = Gender.MALE,
                Role = Role.STUDENT,
                Department = departments[0],
                GPA = 3.1f
            },
            new Student()
            {
                Username = "mervenurozan@std.iyte.edu.tr",
                Password = "merve123",
                FirstName = "Merve",
                MiddleName = "Nur",
                LastName = "OZAN",
                Gender = Gender.FEMALE,
                Role = Role.STUDENT,
                Department = departments[1],
                GPA = 3.2f
            },
            new Student()
            {
                Username = "halilbugday@std.iyte.edu.tr",
                Password = "halil123",
                FirstName = "Halil",
                LastName = "BUGDAY",
                Gender = Gender.MALE,
                Role = Role.STUDENT,
                Department = departments[0],
                GPA = 3.3f
            },
            new Student()
            {
                Username = "gokaygulsoy@std.iyte.edu.tr",
                Password = "gokay123",
                FirstName = "Gokay",
                LastName = "GULSOY",
                Gender = Gender.MALE,
                Role = Role.STUDENT,
                Department = departments[1],
                GPA = 3.4f
            }
        };

        private static Announcement[] announcements = new Announcement[]
        {
            new Announcement()
            {
                Title = "DEPARTMAN ADAYLIGI SURECI BASLIYOR",
                Description = 
                "Departman adayligi icin basvuracak ogrenciler 2023-05-01'den 2023-05-30'e kadar gerekli basvuru dokumanlarini sistem uzerinden gondermelidir.\n" +
                "Ogrenci Isleri - Enes DEMIREL",
                StartDate = new DateTime(2023, 05, 01),
                EndDate = new DateTime(2023, 05, 30),
                Administration = administrations[0]
            }
        };

        private static Process[] processes = new Process[]
        {
            new Process()
            {
                ProcessType = ProcessType.DEPARTMENT_CANDIDACY,
                StartDate= new DateTime(2023, 05, 01),
                EndDate = new DateTime(2023, 05, 30),
                administration = administrations[1]
            },
            new Process()
            {
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE,
                StartDate= new DateTime(2023, 05, 30),
                EndDate = new DateTime(2022, 05, 31),
                administration = administrations[1]
            }
        };

    }

}

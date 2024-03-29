
using System.Diagnostics;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                Name = "Nicat",
                Surname = "Namazov",
                Faculty = "Komputer elmleri"
            };

            Student student2 = new Student
            {
                Name = "Vuqar",
                Surname = "Abilov",
                Faculty = "Texniki"
            };

            Student student3 = new Student
            {
                Name = "Ali",
                Surname = "Veliyev",
                Faculty = "Tibb"
            };

            Exam[] exams = new Exam[]
            {
            new Exam { Title = "Riyaziyyat", Grade = 85 },
            new Exam { Title = "Fizika", Grade = 75 },
            new Exam { Title = "Kimya", Grade = 65 },
            new Exam { Title = "Biologiya", Grade = 70 },
            new Exam { Title = "Ingilis", Grade = 80 }
            };

            foreach (var exam in exams)
            {
                student1.CheckExam(exam.Title, exam.Grade);
                student2.CheckExam(exam.Title, exam.Grade);
                student3.CheckExam(exam.Title, exam.Grade);
            }

            Console.WriteLine("\nTelebe 1 melumatlari:");
            student1.StudentInfo();

            Console.WriteLine("\nTelebe 2 melumatlari:");
            student2.StudentInfo();

            Console.WriteLine("\nTelebe 3 melumatlari:");
            student3.StudentInfo();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Faculty { get; set; }
        public Dictionary<string, int> Grades { get; set; } = new Dictionary<string, int>();

        public void CheckExam(string examTitle, int examGrade)
        {
            if (examGrade >= 17)
            {
                Grades[examTitle] = examGrade;

                int totalPoints = 0;
                foreach (var grade in Grades.Values)
                {
                    totalPoints += grade;
                }

                if (totalPoints >= 90)
                    Console.WriteLine("A-aldin.");
                else if (totalPoints >= 80)
                    Console.WriteLine("B-aldin.");
                else if (totalPoints >= 70)
                    Console.WriteLine("C-aldin.");
                else if (totalPoints >= 60)
                    Console.WriteLine("D-aldin.");
                else if (totalPoints >= 50)
                    Console.WriteLine("E-aldin.");
            }
            else
            {
                Console.WriteLine("Imtahani kecmek ucun 17 balda yuxari olmalidi.");
            }
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Soyad: {Surname}");
            Console.WriteLine($"Fakulte: {Faculty}");
            Console.WriteLine($"Netice:");
            foreach (var grade in Grades)
            {
                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }
        }
    }

    class Exam
    {
        public string Title { get; set; }
        public int Grade { get; set; }
    }
}
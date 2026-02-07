using Task4.Models;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School manager = new School();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find Student by ID");
                Console.WriteLine("9. Find Course by ID");
                Console.WriteLine("10. Exit");
                Console.Write("Choose: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Student ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name: ");
                        string? name = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        manager.AddStudent(new Student(id, name!, age));
                        Console.WriteLine("Student added");
                        break;

                    case 2:
                        Console.Write("Instructor ID: ");
                        int iid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name: ");
                        string? iname = Console.ReadLine();
                        Console.Write("Specialization: ");
                        string? spec = Console.ReadLine();

                        manager.AddInstructor(new Instructor(iid, iname!, spec!));
                        Console.WriteLine("Instructor added");
                        break;

                    case 3:
                        Console.Write("Course ID: ");
                        int cid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Title: ");
                        string? title = Console.ReadLine();

                        Console.Write("Instructor ID: ");
                        int instId = Convert.ToInt32(Console.ReadLine());
                        Instructor? inst = manager.FindInstructor(instId);

                        if (inst == null)
                        {
                            Console.WriteLine("Instructor not found");
                            break;
                        }

                        manager.AddCourse(new Course(cid, title!, inst));
                        Console.WriteLine("Course added");
                        break;

                    case 4:
                        Console.Write("Student ID: ");
                        int esid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Course ID: ");
                        int ecid = Convert.ToInt32(Console.ReadLine());

                        if (manager.EnrollStudentInCourse(esid, ecid))
                            Console.WriteLine("Student enrolled");
                        else
                            Console.WriteLine("Enrollment failed");
                        break;

                    case 5:
                        for (int i = 0; i < manager.Students.Count; i++)
                            Console.WriteLine(manager.Students[i].PrintDetails());
                        break;

                    case 6:
                        for (int i = 0; i < manager.Courses.Count; i++)
                            Console.WriteLine(manager.Courses[i].PrintDetails());
                        break;

                    case 7:
                        for (int i = 0; i < manager.Instructors.Count; i++)
                            Console.WriteLine(manager.Instructors[i].PrintDetails());
                        break;

                    case 8:
                        Console.Write("Student ID: ");
                        int fsid = Convert.ToInt32(Console.ReadLine());
                        var student = manager.FindStudent(fsid);
                        if (student != null)
                        {
                            Console.WriteLine(student.PrintDetails());
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }
                        break;

                    case 9:
                        Console.Write("Course ID: ");
                        int fcid = Convert.ToInt32(Console.ReadLine());
                        var course = manager.FindCourse(fcid);
                        if (course != null)
                        {
                            Console.WriteLine(course.PrintDetails());
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }
                        break;

                    case 10:
                        running = false;
                        break;
                }
            }
        }
    }
}


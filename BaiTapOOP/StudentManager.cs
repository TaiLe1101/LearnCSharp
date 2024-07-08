using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOOP
{
    public class StudentManager
    {
        private readonly List<Student> students = new();
        public void ShowMenu()
        {
            int choice = 0;
            bool isValidChoice = true;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("===== Student Manager =====");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Edit Student");
                    Console.WriteLine("3. Remove Student");
                    Console.WriteLine("4. Student List");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choice: ");
                    isValidChoice = int.TryParse(Console.ReadLine(), out choice);
                } while (!isValidChoice || choice <= 0 || choice > 5);
                this.HandleAction(choice);

            } while (choice != 5);
        }

        private void HandleAction(int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        string studentName = "";
                        int age = 0;
                        string className = "";

                        Console.Write("Enter student name: ");
                        studentName = Console.ReadLine();
                        Console.Write("Enter age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.Write("Enter class name: ");
                        className = Console.ReadLine();

                        Student student = new Student();
                        student.Name = studentName;
                        student.Age = age;
                        student.ClassName = className;
                        students.Add(student);
                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {
                        Console.Write("Please enter student id: ");
                        Guid studentId = Guid.Parse(Console.ReadLine());

                        for (int i = 0; i < students.Count; i++)
                        {
                            if (students[i].Id == studentId)
                            {
                                students.RemoveAt(i);
                            }
                        }

                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < students.Count; i++)
                        {
                            if (i != 0)
                                Console.WriteLine("=============================");
                            students[i].Display();
                        }

                        Console.WriteLine("Enter...");
                        Console.ReadKey();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Exited Application");
                        break;
                    }
                default:
                    Console.WriteLine("Choice is invalid");
                    break;
            }
        }
    }
}

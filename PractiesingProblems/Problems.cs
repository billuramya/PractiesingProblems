using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PractiesingProblems
{
    public class Problems
    { 
        public void FriendsName()
        {
            string[] strings = new string[5] { "siva", "Ganesh", "priya", "Prasanna", "Sravani" };
            for (int i = 0; i < strings.Length; i++) {
                //string s = strings[i];
                Console.WriteLine(strings[i]);
            }
            

        }
    }

    //Write a program which  prompts user to enter 2 numbers
    //(numbers can have decimal numbers). Program computes the square
    //of sum of these two numbers and square of difference between these 2 numbers . 
    public class SquareOfTwoNumbers
    {
        public void square()
        {
            Console.WriteLine("Enter the first decimal number");
            decimal num1= decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second decimal number");
            decimal num2= decimal.Parse(Console.ReadLine());
            decimal squeare = num1 * num1; 
            decimal squeare2= num2 * num2;
            Console.WriteLine("squeare of sum between two numbers");
            Console.WriteLine(squeare + squeare2);
            Console.WriteLine("squeare of difference between two numbers");
            Console.WriteLine(squeare - squeare2);
        }
    }

    //Write a program which takes input of a place name  where you would like to visit
    //most and displays that with place with  uppercase once and then all lower case once
    public class DifferentChangingOfLowerAndUpper
    {
        public void LowerAndUpperCases()
        {
            Console.WriteLine("enter the place Name");
            string strings= Console.ReadLine();
            Console.WriteLine("print the lowerCase");
            Console.WriteLine(strings.ToLower());
            Console.WriteLine("print the uppercase");
            Console.WriteLine(strings.ToUpper());   
        }
    }

    //Read a number from user as string and print 10 times of that number as string only 
    public class StringRepetition
    {
        public void repetition()
        {
            Console.WriteLine("enter the string"); 
            string s= Console.ReadLine();
            for (int i = 0;i<10;i++ )
            {
                Console.WriteLine(s);
            }
        }
    }

    //Write a program which takes  a command line arguments  of a person's full name
    //(First Name, Last Name, Middle name(s) if any) and prints how many parts  are
    //there in the name. Also puts different parts of arguments in one variable and
    //prints the same

    public class CombiningAllNames
    {
        public void FullName()
        {
            Console.WriteLine("enter the first Name");
            string firstName= Console.ReadLine();
            Console.WriteLine("enter the middle Name");
            string middleName= Console.ReadLine();
            Console.WriteLine("eneter the last Name");
            string lastName= Console.ReadLine();
            string Result = firstName + middleName + lastName;
            Console.WriteLine(Result);
        }
    }

    //Compute Average of numbers. Generate 5 random numbers between 10 to 50
    //and compute the average of these numbers . Print the numbers generated
    //in one line and in next line print the average.
      public class RandomNumbers
    {
        public void Random()
        {
            Console.WriteLine("generate the 5 dandom numbers between 10 to 50");
            Random b= new Random();
            
            int[] numbers=new int[5];
            for (int i = 0; i < 5; i++)
            {
                int val = b.Next(10, 50);
                numbers[i] = val;

            }
            Console.Write("Random numbers ;");
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
                Console.Write(num+" ");
                    
                
            }
            
            Console.WriteLine( "average numbers: {0}", (sum / numbers.Length));
            
        }
    }

   // Design an object-oriented system for a virtual classroom.Consider classes
   // like Student, Teacher, and Course.Implement features such as enrollment, grading,
   // and communication between students and teachers.Utilize concepts like inheritance,
   // encapsulation, and polymorphism to model the relationships and behaviors in this system..
  public class Student
    {
        public string Name {  get; set; }
        public Student(string name)
        {
            Name = name;
        }

        
    }

    class Teachers { 

        public string TeacherName;
        public Teachers(string teacherName)
        {
            TeacherName = teacherName;
           
        }
    }
    class Course
    {
        public string CorseName;
        public Course(string corseName)
        {
            CorseName = corseName;
        }
    }
    class Communication

    {
        public Communication()
        {
            
            Student student = new Student("Ramya");
            Teachers teachers= new Teachers("Proffissor Amith");
            Course course = new Course("Electrical Engineering");

            Console.WriteLine(student.Name + teachers.TeacherName);
        }
        
        
        
    }
}



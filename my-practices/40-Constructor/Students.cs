using System;

namespace _40_Constructor


{
    // ***********Make Objects with calling the constructor***********


    public class Students
    {


        // Constructor class 
        public Students(int studentsAge, int studentsLessons, string studentsFirstName, string studentsLastName)
        {
            age = studentsAge;
            lessons = studentsLessons;
            firstName = studentsFirstName;
            lastName = studentsLastName;
            // an empty constructor
        }
        public Students()
        {
        }


        public void SignUp()
        {
            Console.WriteLine("students should sign up in the school site ");
        }

        public int Count;
        public string firstName;
        public string lastName;
        public int age;
        public int lessons;
        public void PersonalInformations()
        {
            Console.WriteLine($"the student name is :  {firstName}: ");
        }

        public void ClassInformations()
        {
            Console.WriteLine($"the program for this student is : {age} years old and {lessons} lessons");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoviProjekat
{
    class Person
    {
        public string FirstName = "Sanel";
        public string LastName = "Ljuskovic";
        public int Age = 30;

        public string SayAge()
        {
            return $"Moja starost je {Age}";

        }

    }

    class Student : Person
    {

    }


    class Program
   
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("Ime: {0}\nPrezime: {1}\nStarost: {2}\n\n", st.FirstName, st.LastName, st.Age);
            Console.WriteLine(st.SayAge());
            
            Console.ReadKey();


        }
    }
}

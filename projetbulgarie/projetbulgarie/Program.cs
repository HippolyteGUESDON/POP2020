using System;
using System.Collections.Generic;

namespace projetbulgarie
{
    public class Person
    {
        private string firstname;
        private string lastname;

        public string Firstname
        {
            get { return firstname; }
        }

        public string Lastname
        {
            get { return lastname; }
        }

        public string Fullname(string first, string last)
        {
            string fullname = first + " " + last;
            return fullname;
        }

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
            
    }

    public class Address
    {
        private string number;
        private string street;
        private string city;
        private string country;

        public Address (string number, string street, string city, string country)
        {
            this.number = number;
            this.street = street;
            this.city = city;
            this.country = country;
        }

        public string Number
        {
            get { return number; }
        }
        public string Street
        {
            get { return street; }
        }
        public string City
        {
            get { return city; }
        }
        public string Country
        {
            get { return country; }
        }

        public override string ToString()
        
        {
            return " " + number + " " + street + " " + city + " " + country;
        }
    }


    public class Student : Person
    {

        public string studentnumber;
        public int age;
        public Address address;
        public string scores;
        public string fulladdress;
        public double averagescore;
        public string fullname;

        public int Age
        {
            get { return age; }
        }

        public string Studentnumber
        {
            get { return studentnumber; }
        }

        public Address GetAddress
        {
            get { return address; }
        }


        public Student(string firstname, string lastname, string studentnumber, int age, Address address, string scores) : base (firstname, lastname)
        {
            fullname = firstname + " " + lastname;
            this.age = age;
            this.studentnumber = studentnumber;
            this.scores = scores;
            this.address = address;
            this.fulladdress = address.ToString();
            averagescore = Averagescore(scores);
        }

        static double Averagescore(string scores)
        {
            string[] mark = scores.Split(" ");
            double averagescore = 0;
            int i = 0;
            foreach (var marks in mark)
            {
                averagescore = averagescore + Convert.ToDouble(marks);
                i++;
            }
            averagescore = averagescore / i;
            return averagescore;
        }

        public override string ToString()

        {
            return " " + fullname + " " + studentnumber + " " + age + " " + fulladdress + " " + scores + " " + averagescore + " ";
        }

    }
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is the firstname of the student? ");
            string firstname = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the lastname of the student? ");
            string lastname = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the student number of the student? ");
            string studentnumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the age of the student? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What are the score of the student? (put a space between different marks) ");
            string scores = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the number of the street of the student? ");
            string number = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the street of the student? ");
            string street = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the city of the student? ");
            string city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the country of the student? ");
            string country = Console.ReadLine();
            Console.WriteLine();

            Address address = new Address(number, street, city, country);


            Student mystudent = new Student(firstname, lastname, studentnumber, age, address, scores);
            mystudent.ToString();

            Console.WriteLine("Student " + mystudent.fullname + " his average score is " + mystudent.averagescore);
            Console.WriteLine("Student " + mystudent.fullname + " is living is " + address.City);
            Console.WriteLine("Student " + mystudent.fullname + " address is " + mystudent.fulladdress);
            Console.WriteLine("Student " + mystudent.fullname + " is living in " + address.Country);
            Console.WriteLine(mystudent.Firstname + "'s scores are " + mystudent.scores + " and the average is " + mystudent.averagescore);
        }
    }
}


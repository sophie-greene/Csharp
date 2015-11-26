using System;

namespace Module3HW
{
    class Program
    {
        class Address
        {
            string line1;
            string line2;
            string city;
            string state;
            string zipcode;
            string country;

            public void printToConsole()
            {
                Console.WriteLine("Address:");
                Console.WriteLine(line1);
                if (!string.IsNullOrWhiteSpace(line2))
                {
                    Console.WriteLine(line2);
                }
                Console.WriteLine("{0}, {1} {2}",
                city, state, zipcode);
                Console.WriteLine(country);
            }

            public void fillFromConsoleInput()
            {
                line1 = inputString("Enter the address line 1: ");
                line2 = inputString("Enter the address line 2: ");
                city = inputString("Enter the city: ");
                state = inputString("Enter the state or province: ");
                zipcode = inputString("Enter the zip of postal code: ");
                country = inputString("Enter the country: ");
            }

            public static Address makeInstanceFromConsoleInput()
            {
                Address address = new Address();
                address.fillFromConsoleInput();
                return address;
            }
        }

        class Person
        {
            string firstName;
            string lastName;
            DateTime birthday;
            Address address;

            public void printToConsole()
            {
                Console.WriteLine("{0} {1}, date of birth: {2}",
                firstName, lastName,
                birthday != DateTime.MinValue ?
                birthday.ToShortDateString() :
                "unknown");
                address.printToConsole();
            }

            public void fillFromConsoleInput()
            {
                firstName = inputString("Enter the first name: ");
                lastName = inputString("Enter the last name: ");
                birthday = inputDate("Enter the birthday: ");

                address = Address.makeInstanceFromConsoleInput();
            }

            public static Person makeInstanceFromConsoleInput()
            {
                Person person = new Person();
                person.fillFromConsoleInput();
                return person;
            }

            public bool validateBirthday()
            {
                throw new NotImplementedException();
            }
        }

        class Degree
        {
            string name;
            int reqCredits;

            public void printToConsole()
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Degree: \"{0}\", requires {1} credit(s)",
                    name, reqCredits);
                }
            }

            public void fillFromConsoleInput()
            {
                name = inputString("Enter the name of the degree: ");
                reqCredits = inputInt("Enter the number of credits required: ");
            }

            public static Degree makeInstanceFromConsoleInput()
            {
                Degree degree = new Degree();
                degree.fillFromConsoleInput();
                return degree;
            }

        }

        class Course
        {
            string name;
            int credits;
            int numOfWeeks;
            Person teacher;

            public void printToConsole()
            {
                Console.WriteLine("Course \"{0}\"", name);
                Console.WriteLine("Credits: {0}, duration: {1} weeks",
                credits, numOfWeeks);
                Console.WriteLine("Teacher: ");
                teacher.printToConsole();
            }

            public void fillFromConsoleInput()
            {
                name = inputString("Enter the name of the course: ");
                credits = inputInt("Enter the number of credits for the course: ");
                numOfWeeks = inputInt("Enter the course duration in weeks: ");

                Console.WriteLine("Enter the teacher information");
                teacher = Person.makeInstanceFromConsoleInput();
            }

            public static Course makeInstanceFromConsoleInput()
            {
                Course course = new Course();
                course.fillFromConsoleInput();
                return course;
            }
        }

        class UProgram
        {
            string name;
            Person depHead;
            Degree degrees;

            public void printToConsole()
            {
                Console.WriteLine("Program \"{0}\"", name);
                Console.WriteLine("Department head for the program:");
                depHead.printToConsole();
                degrees.printToConsole();
            }

            public void fillFromConsoleInput()
            {
                name = inputString("Enter the name of the programm: ");

                Console.WriteLine("Enter the department head information");
                depHead = Person.makeInstanceFromConsoleInput();

                degrees = Degree.makeInstanceFromConsoleInput();
            }

            public static UProgram makeInstanceFromConsoleInput()
            {
                UProgram program = new UProgram();
                program.fillFromConsoleInput();
                return program;
            }
        }

        static void Main(string[] args)
        {
            Person student = getStudentInformation();
            printStudentInformation(student);

            // Next line will throw an exception if uncommented (per assigment).
            //student.validateBirthday();

            Course course = Course.makeInstanceFromConsoleInput();
            Console.WriteLine();
            course.printToConsole();
            Console.WriteLine();

            UProgram uProgram = UProgram.makeInstanceFromConsoleInput();
            Console.WriteLine();
            uProgram.printToConsole();

            Console.WriteLine("Press Enter to finish...");
            Console.ReadLine();
        }

        private static Person getStudentInformation()
        {
            Console.WriteLine("Enter the student information ");
            return Person.makeInstanceFromConsoleInput();
        }

        private static void printStudentInformation(Person student)
        {
            Console.WriteLine();
            Console.WriteLine("Student:");
            student.printToConsole();
            Console.WriteLine();
        }

        private static string inputString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static DateTime inputDate(string prompt)
        {
            string line = inputString(prompt);
            while (!string.IsNullOrWhiteSpace(line))
            {
                DateTime date;
                if (DateTime.TryParse(line, out date))
                {
                    return date;
                }
                Console.WriteLine("Please enter the date in the MM/dd/yyyy format. Press Enter to skip: ");
                line = Console.ReadLine();
            }

            return DateTime.MinValue;
        }

        private static int inputInt(string prompt)
        {
            string line = inputString(prompt);
            while (!string.IsNullOrWhiteSpace(line))
            {
                int inputValue;
                if (int.TryParse(line, out inputValue))
                {
                    return inputValue;
                }
                Console.WriteLine("Please enter the whole number: ");
                line = Console.ReadLine();
            }

            return 0;
        }
    }
}
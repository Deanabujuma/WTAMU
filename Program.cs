namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Creating Professor objects
            Professor professor1 = new Professor("Alice", "Java", 9000);
            Professor professor2 = new Professor("Bob", "Math", 8000);

            // Q1: Creating Student objects
            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);

            // Q2: Printing details of professors
            Console.WriteLine("Professor Details:");
            PrintProfessorDetails(professor1);
            PrintProfessorDetails(professor2);

            // Q2: Printing details of students
            Console.WriteLine("\nStudent Details:");
            PrintStudentDetails(student1);
            PrintStudentDetails(student2);

            // Q2: Calculating and printing the salary difference between professors
            double salaryDifference = professor1.GetSalary() - professor2.GetSalary();
            Console.WriteLine($"\nSalary Difference between {professor1.profName} and {professor2.profName}: {salaryDifference}");

            // Q2: Calculating and printing the total grade of students
            double totalGrade = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"Total grade of students in Java and Math courses: {totalGrade}");
        }

        // Method to print professor details
        static void PrintProfessorDetails(Professor professor)
        {
            Console.WriteLine($"Name: {professor.profName}");
            Console.WriteLine($"Class they teach: {professor.classTeach}");
            Console.WriteLine($"Salary: {professor.GetSalary()}");
            Console.WriteLine();
        }

        // Method to print student details
        static void PrintStudentDetails(Student student)
        {
            Console.WriteLine($"Name: {student.studentName}");
            Console.WriteLine($"Class they're enrolled in: {student.classEnroll}");
            Console.WriteLine($"Grade: {student.GetGrade()}");
            Console.WriteLine();
        }
    }

    // Q1: Professor class implementation
    class Professor
    {
        public string profName { get; private set; }
        public string classTeach { get; private set; }
        private double salary;

        // Constructor to initialize professor details
        public Professor(string name, string className, double salaryAmount)
        {
            profName = name;
            classTeach = className;
            salary = salaryAmount;
        }

        // Method to set salary
        public void SetSalary(double salaryAmount)
        {
            salary = salaryAmount;
        }

        // Method to get salary
        public double GetSalary()
        {
            return salary;
        }
    }

    // Q1: Student class implementation
    class Student
    {
        public string studentName { get; private set; }
        public string classEnroll { get; private set; }
        private double studentGrade;

        // Constructor to initialize student details
        public Student(string name, string course, double grade)
        {
            studentName = name;
            classEnroll = course;
            studentGrade = grade;
        }

        // Method to set grade
        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        // Method to get grade
        public double GetGrade()
        {
            return studentGrade;
        }
    }
}
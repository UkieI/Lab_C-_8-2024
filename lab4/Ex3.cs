namespace Lab4
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

       
        public Student(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

 
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}";
        }
    }

    class Ex3
    {
        public static void run()
        {
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student(1, "Alice", 20),
                new Student(2, "Bob", 22),
                new Student(3, "Charlie", 21),
                new Student(4, "David", 19),
                new Student(5, "Eve", 23)
            };

            // Sort the list by Name
            List<Student> sortedStudents = students.OrderBy(s => s.Name).ToList();

            // Print the sorted list
            Console.WriteLine("Students sorted by Name:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }

}

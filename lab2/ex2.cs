namespace Lab2
{

    class Person{

        protected int age;
        protected string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Person()
        {
            age = 0;
            name = "Unknown";
        }


        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public virtual void Input()
        {   
            
            Console.Write("Enter name: ");
            name = Console.ReadLine() ?? "Unknow";

            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine() ?? "") ;
        }

        public virtual void DisplayPerson()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public override string ToString()
        {
            return $"Person [Name: {name}, Age: {age}]";
        }
    }

    class Student : Person
    {

        private double gpa;


        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }


        public Student() : base()
        {
            gpa = 0.0;
        }


        public Student(int age, string name, double gpa) : base(age, name)
        {
            this.gpa = gpa;
        }

 
        public override void Input()
        {
            base.Input(); 

            Console.Write("Enter GPA: ");
            gpa = double.Parse(Console.ReadLine() ?? "" );
        }

        public void DisplayStudent()
        {
            base.DisplayPerson();
            Console.WriteLine($"GPA: {gpa}");
        }

        public override string ToString()
        {
            return $"Student [Name: {name}, Age: {age}, GPA: {gpa}]";
        }
    }

    class Ex2 {
        public  void run(){
            Student student = new Student();
            student.Input();
            student.DisplayStudent();
            Console.WriteLine(student.ToString());
        }
    }

}
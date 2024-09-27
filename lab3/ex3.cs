// namespace Lab3 
// {
//     class Student
//     {
//         // Các thuộc tính của sinh viên
//         public string SID { get; set; }
//         public string Name { get; set; }
//         public string Department { get; set; }
//         public double GPA { get; set; }
//         // Constructor để khởi tạo đối tượng Student
//         public Student(string sid, string name, string department, double gpa)
//         {
//             SID = sid;
//             Name = name;
//             Department = department;
//             GPA = gpa;
//         }
//         // Phương thức hiển thị thông tin sinh viên
//         public void DisplayInfo()
//         {
//             Console.WriteLine($"Mã số sinh viên: {SID}");
//             Console.WriteLine($"Tên sinh viên: {Name}");
//             Console.WriteLine($"Khoa: {Department}");
//             Console.WriteLine($"Điểm TB: {GPA}");
//             Console.WriteLine("-------------------------");
//         }
//     }





//     class Ex3
//     {
//         public static void run()
//         {
       
//             Console.Write("Nhập số lượng sinh viên: ");
//             int n = int.Parse(Console.ReadLine() ?? "0");
           
//             List<Student> students = new List<Student>();
         
//             for (int i = 0; i < n; i++)
//             {
//                 Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
//                 Console.Write("SID: ");
//                 string sid = Console.ReadLine() ?? "";
//                 Console.Write("Tên sinh viên: ");
//                 string name = Console.ReadLine() ?? "Unknow";
//                 Console.Write("Khoa: ");
//                 string department = Console.ReadLine() ?? "Unknow";
//                 Console.Write("Điểm trung bình: ");
//                 double gpa = double.Parse(Console.ReadLine() ?? "0.0");
          
//                 Student student = new Student(sid, name, department, gpa);
//                 students.Add(student);
//             }
         
//             Console.WriteLine("\nDanh sách sinh viên:");
//             foreach (Student student in students)
//             {
//                 student.DisplayInfo();
//             }
//         }
//     }

// }
// namespace Lab3 
// {
//     public class Student
//     {
//         private string sid;
//         private string name;
//         private string department;
//         private double gpa;
//         // Constructor để khởi tạo đối tượng Student
//         public Student(string sid, string name, string department, double gpa)
//         {
//             this.sid = sid;
//             this.name = name;
//             this.department = department;
//             this.gpa = gpa;
//         }
//         // Getter và Setter cho SID
//         public string GetSID() => sid;
//         public void SetSID(string value) => sid = value;
//         // Getter và Setter cho Name
//         public string GetName() => name;
//         public void SetName(string value) => name = value;
//         // Getter và Setter cho Department
//         public string GetDepartment() => department;
//         public void SetDepartment(string value) => department = value;
//         // Getter và Setter cho GPA
//         public double GetGPA() => gpa;
//         public void SetGPA(double value) => gpa = value;
//         // Phương thức hiển thị thông tin sinh viên
//         public void DisplayInfo()
//         {
//             Console.WriteLine($"SID: {GetSID()}");
//             Console.WriteLine($"Tên sinh viên: {GetName()}");
//             Console.WriteLine($"Khoa: {GetDepartment()}");
//             Console.WriteLine($"Điểm trung bình: {GetGPA():F2}");
//             Console.WriteLine("-----------------------------------");
//         }
//     }
    

//     class Ex4
//     {
//         public static void run()
//         {   
//             List<Student> students = new List<Student>();
//             students = NhapDS();
//             XuatDS(students);
//         }
//         public static List<Student> NhapDS()
//         {
//             Console.Write("Nhập số lượng sinh viên: ");
//             int n = int.Parse(Console.ReadLine() ?? "0");

//             List<Student> students = new List<Student>();
//             for (int i = 0; i < n; i++)
//             {
//                 Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
//                 Student student = Nhap1SV();
//                 students.Add(student);
//             }
//             return students;
//         }
//         public static Student Nhap1SV()
//         {
//             Console.Write("SID: ");
//             string sid = Console.ReadLine();
//             Console.Write("Tên sinh viên: ");
//             string name = Console.ReadLine();
//             Console.Write("Khoa: ");
//             string department = Console.ReadLine();
//             Console.Write("Điểm trung bình: ");
//             double gpa = double.Parse(Console.ReadLine());
//             return new Student(sid, name, department, gpa);
//         }


//         // Hàm xuất danh sách sinh viên
//         static void  XuatDS(List<Student> students)
//         {
//             Console.WriteLine("\nDanh sách sinh viên:");
//             foreach (Student student in students)
//             {
//                 student.DisplayInfo();
//             }
//         }

//     }
         
 

// }
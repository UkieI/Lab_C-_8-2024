// using System.Collections.Generic;
// using System.Collections;

// namespace Lab3 
// {
//     public class People
//     {
//         private string name;
//         private string department;

//         // Constructor
//         public People(string name, string department)
//         {
//             this.name = name;
//             this.department = department;
//         }
//         // Getter và Setter cho Name
//         public string GetName() => name;
//         public void SetName(string value) => name = value;
//         // Getter và Setter cho Department
//         public string GetDepartment() => department;
//         public void SetDepartment(string value) => department = value;
//     }
//     public class Student : People
//     {
//         private string sid;
//         private double gpa;
//         // Constructor
//         public Student(string sid, string name, string department, double gpa)
//             : base(name, department)
//         {
//             this.sid = sid;
//             this.gpa = gpa;
//         }
//         // Getter và Setter cho SID
//         public string GetSID() => sid;
//         public void SetSID(string value) => sid = value;
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


//     class Ex5
//     {
//         public static void run()
//         {   
//             List<Student> studentList = NhapDS_List();
//             ArrayList studentArrayList = new ArrayList(studentList);
            
//             Console.WriteLine("Danh sách sinh viên từ List<Student>:");
//             XuatDS_List(studentList);
          
//             Console.WriteLine("Danh sách sinh viên từ ArrayList:");
//             XuatDS_ArrayList(studentArrayList);

//         }
//         static Student Nhap1SV()
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
   
//         static List<Student> NhapDS_List()
//         {
//             Console.Write("Nhập số lượng sinh viên: ");
//             int n = int.Parse(Console.ReadLine());
//             List<Student> students = new List<Student>();
//             for (int i = 0; i < n; i++)
//             {
//                 Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
//                 Student student = Nhap1SV();
//                 students.Add(student);
//             }
//             return students;
//         }
       
//         static void XuatDS_List(List<Student> students)
//         {
//             foreach (Student student in students)
//             {
//                 student.DisplayInfo();
//             }
//         }
    
//         static void XuatDS_ArrayList(ArrayList students)
//         {
//             foreach (Student student in students)
//             {
//                 student.DisplayInfo();
//             }
//         }


//     }

// }
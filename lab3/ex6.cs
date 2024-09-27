// namespace Lab3 
// {
//     public class Ex6
//     {
//         public static void run()
//         {
//             List<CanBo> danhSachCanBo = new List<CanBo>();
//             bool tiepTuc = true;

//             while (tiepTuc)
//             {
//                 Console.WriteLine("Chọn loại cán bộ: 1. Nhà khoa học 2. Nhà quản lý 3. Nhân viên phòng thí nghiệm 4. Thoát");
//                 int luaChon = int.Parse(Console.ReadLine());
//                 switch (luaChon)
//                 {
//                     case 1:
//                         NhaKhoaHoc nhaKhoaHoc = new NhaKhoaHoc();
//                         NhapThongTin(nhaKhoaHoc);
//                         Console.Write("Nhập số bài báo đã công bố: ");
//                         nhaKhoaHoc.SoBaiBao = int.Parse(Console.ReadLine());
//                         danhSachCanBo.Add(nhaKhoaHoc);
//                         break;
//                     case 2:
//                         NhaQuanLy nhaQuanLy = new NhaQuanLy();
//                         NhapThongTin(nhaQuanLy);
//                         danhSachCanBo.Add(nhaQuanLy);
//                         break;
//                     case 3:
//                         NhanVienPhongThiNghiem nhanVien = new NhanVienPhongThiNghiem();
//                         NhapThongTin(nhanVien);
//                         Console.Write("Nhập lương tháng: ");
//                         nhanVien.LuongThang = double.Parse(Console.ReadLine());
//                         danhSachCanBo.Add(nhanVien);
//                         break;
//                     case 4:
//                         tiepTuc = false;
//                         break;
//                     default:
//                         Console.WriteLine("Lựa chọn không hợp lệ!");
//                         break;
//                 }
//             }
//             XuatDanhSach(danhSachCanBo);
//             TinhTongLuong(danhSachCanBo);
//         }
//         public static void NhapThongTin(CanBo canBo)
//         {
//             Console.Write("Nhập họ tên: ");
//             canBo.HoTen = Console.ReadLine();
//             Console.Write("Nhập năm sinh: ");
//             canBo.NamSinh = int.Parse(Console.ReadLine());
//             Console.Write("Nhập bằng cấp: ");
//             canBo.BangCap = Console.ReadLine();
//             Console.Write("Nhập chức vụ: ");
//             canBo.ChucVu = Console.ReadLine();
//             Console.Write("Nhập số ngày công trong tháng: ");
//             canBo.SoNgayCong = int.Parse(Console.ReadLine());
//             Console.Write("Nhập bậc lương: ");
//             canBo.BacLuong = double.Parse(Console.ReadLine());
//         }
//         public static void XuatDanhSach(List<CanBo> danhSach)
//         {
//             Console.WriteLine("\nDanh sách cán bộ:");
//             foreach (var canBo in danhSach)
//             {
//                 Console.WriteLine(canBo);
//             }
//         }
//         public static void TinhTongLuong(List<CanBo> danhSach)
//         {
//             double tongLuongNhaKhoaHoc = 0;
//             double tongLuongNhaQuanLy = 0;
//             double tongLuongNhanVien = 0;
//             foreach (var canBo in danhSach)
//             {
//                 if (canBo is NhaKhoaHoc)
//                     tongLuongNhaKhoaHoc += canBo.TinhLuong();
//                 else if (canBo is NhaQuanLy)
//                     tongLuongNhaQuanLy += canBo.TinhLuong();
//                 else if (canBo is NhanVienPhongThiNghiem)
//                     tongLuongNhanVien += canBo.TinhLuong();
//             }
//             Console.WriteLine($"\nTổng lương nhà khoa học: {tongLuongNhaKhoaHoc}");
//             Console.WriteLine($"Tổng lương nhà quản lý: {tongLuongNhaQuanLy}");
//             Console.WriteLine($"Tổng lương nhân viên phòng thí nghiệm: {tongLuongNhanVien}");
//         }
//     }
// }

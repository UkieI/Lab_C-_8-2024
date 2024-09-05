
        Console.Write("Họ tên học sinh: ");
        string hoTen = Console.ReadLine();
        
        // Nhập điểm thi cuối kỳ
        Console.Write("Điểm thi cuối kỳ: ");
        double diem;
        
        // Kiểm tra nhập liệu đúng hay sai
        while (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
        {
            Console.WriteLine("Điểm không hợp lệ! Vui lòng nhập lại (0 - 10): ");
        }
        // Chuyển họ tên sang chữ IN HOA
        string hoTenInHoa = hoTen.ToUpper();
        // Xác định xếp loại học sinh
        string xepLoai;
        if (diem >= 8)
        {
            xepLoai = "Giỏi";
        }
        else if (diem >= 6.5)
        {
            xepLoai = "Khá";
        }
        else if (diem >= 5)
        {
            xepLoai = "Trung bình";
        }
        else
        {
            xepLoai = "Yếu";
        }
        // In kết quả
        Console.WriteLine($"\nHọ tên học sinh: {hoTenInHoa}");
        Console.WriteLine($"Xếp loại: {xepLoai}");

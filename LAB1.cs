using System;
using System.Text;


namespace LAB01
{
    class LAB1
    {
        static void Main(string[] args)
        {
            //Config Console Output được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            //0.1 Khai báo biến
            int x1, x2, y1, y2;
            //0.2 Nhập giá trị
            Console.WriteLine("Nhập điểm A(x1, y1):");
            Console.Write("- x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("- y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm B(x2, y2):");
            Console.Write("- x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("- y2: ");
            y2 = int.Parse(Console.ReadLine());
            //0.3 Tính khoảng cách
            double khoangCach = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //0.4 Hiển thị kết quả
            Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) với điểm B({x2}, {y2}) ={ khoangCach}");


            //bài 1: nhập tên và tuổi
            Console.WriteLine("\nBài 1: Nhập tên và tuổi");
            Console.Write("- Nhập tên: ");
            string ten = Console.ReadLine();
            Console.Write("- Nhập tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());     //int.Parse dùng để đổi chuỗi string sang số nguyên int
            Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");

            //bài 2: tính diện tích hcn
            Console.WriteLine("\nBài 2: Tính diện tích hình chữ nhật");
            Console.Write("- Nhập chiều dài: ");
            double dai = double.Parse(Console.ReadLine());
            Console.Write("- Nhập chiều rộng: ");
            double rong = double.Parse(Console.ReadLine());
            double dientich = dai * rong;
            Console.WriteLine($"Diện tích hình chữ nhật là: {dientich}");

            //bài 3: chuyển độ C thành độ F
            Console.WriteLine("\nBài 3: Chuyển độ C sang độ F");
            Console.Write("- Nhập nhiệt độ (°C): ");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"Nhiệt độ tương đương (°F): {f}");

            //bài 4: kiểm tra 1 số có phải chăn lẻ không
            Console.WriteLine("\nBài 4: Kiểm tra số chẵn hay lẻ");
            Console.Write("- Nhập một số nguyên: ");
            int soChan = int.Parse(Console.ReadLine());
            Console.WriteLine(soChan % 2 == 0 ? "Đây là số chẵn." : "Đây là số lẻ.");

            //bài 5: tính tồng và tích của 2 số
            Console.WriteLine("\nBài 5: Tính tổng và tích của 2 số");
            Console.Write("- Nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("- Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng: {a + b}, Tích: {a * b}");

            //bài 6: kiểm tra 1 số là dương hay âm
            Console.WriteLine("\nBài 6: Kiểm tra số là âm hay dương");
            Console.Write("- Nhập một số nguyên: ");
            int so = int.Parse(Console.ReadLine());
            if (so > 0) Console.WriteLine("Đây là số dương.");
            else if (so < 0) Console.WriteLine("Đây là số âm.");
            else Console.WriteLine("Đây là số không.");

            // Bài 7
            Console.WriteLine("\nBài 7: Kiểm tra năm nhuận");
            Console.Write("- Nhập năm: ");
            int nam = int.Parse(Console.ReadLine());
            bool laNhuan = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
            Console.WriteLine(laNhuan ? "Là năm nhuận." : "Không phải năm nhuận.");

            // Bài 8
            Console.WriteLine("\nBài 8: In bảng cửu chương từ 1 đến 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\nBảng cửu chương {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }

            //bài 9: tính giai thừa của số được nhập
            Console.WriteLine("\nBài 9: Tính giai thừa");
            Console.Write("- Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            long giaithua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaithua *= i;
            }
            Console.WriteLine($"{n}! = {giaithua}");

            //bài 10: kiểm tra số nguyên tố
            Console.WriteLine("\nBài 10: Kiểm tra số nguyên tố");
            Console.Write("- Nhập số cần kiểm tra: ");
            int soKT = int.Parse(Console.ReadLine());
            bool laNguyenTo = soKT > 1;
            for (int i = 2; i <= Math.Sqrt(soKT); i++)
            {
                if (soKT % i == 0)
                {
                    laNguyenTo = false;
                    break;
                }
            }
            Console.WriteLine(laNguyenTo ? "Là số nguyên tố." : "Không phải số nguyên tố.");

            Console.WriteLine("Yeah! Xong");
            Console.ReadKey();
        }
    }
}



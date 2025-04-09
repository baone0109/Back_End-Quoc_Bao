using System;
using System.Text;

namespace LAB1.2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Bài 1: Tính tổng các số chẵn trong mảng
            Console.WriteLine("Bài 1: Tính tổng các số chẵn trong mảng");
            Console.Write("- Nhập số phần tử của mảng: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] a1 = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write($"a[{i}]: ");
                a1[i] = int.Parse(Console.ReadLine());
            }

            int tongChan = 0;
            for (int i = 0; i < n1; i++)
            {
                if (a1[i] % 2 == 0)
                    tongChan += a1[i];
            }
            Console.WriteLine($"Tổng các số chẵn trong mảng là: {tongChan}");

            // Bài 2: Liệt kê số nguyên tố trong mảng
            Console.WriteLine("\nBài 2: Liệt kê số nguyên tố trong mảng");
            Console.Write("- Nhập số phần tử của mảng: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] a2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.Write($"a[{i}]: ");
                a2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Các phần tử là số nguyên tố:");
            for (int i = 0; i < n2; i++)
            {
                if (LaSoNguyenTo(a2[i]))
                    Console.WriteLine($"a[{i}] = {a2[i]}");
            }

            // Bài 3: Đếm số âm và dương
            Console.WriteLine("\nBài 3: Đếm số lượng số âm và dương");
            Console.Write("- Nhập số phần tử của mảng: ");
            int n3 = int.Parse(Console.ReadLine());
            int[] a3 = new int[n3];
            for (int i = 0; i < n3; i++)
            {
                Console.Write($"a[{i}]: ");
                a3[i] = int.Parse(Console.ReadLine());
            }

            int demAm = 0, demDuong = 0;
            foreach (int x in a3)
            {
                if (x < 0) demAm++;
                else if (x > 0) demDuong++;
            }
            Console.WriteLine($"Số phần tử âm: {demAm}, Số phần tử dương: {demDuong}");

            // Bài 4: Tìm số lớn thứ hai
            Console.WriteLine("\nBài 4: Tìm số lớn thứ hai trong mảng");
            Console.Write("- Nhập số phần tử của mảng: ");
            int n4 = int.Parse(Console.ReadLine());
            int[] a4 = new int[n4];
            for (int i = 0; i < n4; i++)
            {
                Console.Write($"a[{i}]: ");
                a4[i] = int.Parse(Console.ReadLine());
            }

            int max = int.MinValue, secondMax = int.MinValue;
            foreach (int x in a4)
            {
                if (x > max)
                {
                    secondMax = max;
                    max = x;
                }
                else if (x > secondMax && x != max)
                {
                    secondMax = x;
                }
            }

            Console.WriteLine($"Số lớn thứ hai là: {secondMax}");

            // Bài 5: Hoán vị 2 số nguyên
            Console.WriteLine("\nBài 5: Hoán vị 2 số nguyên");
            Console.Write("- Nhập số nguyên a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("- Nhập số nguyên b: ");
            int b = int.Parse(Console.ReadLine());
            HoanVi(ref a, ref b);
            Console.WriteLine($"Sau hoán vị: a = {a}, b = {b}");

            // Bài 6: Sắp xếp mảng số thực tăng dần
            Console.WriteLine("\nBài 6: Sắp xếp mảng số thực tăng dần");
            Console.Write("- Nhập số phần tử của mảng: ");
            int n6 = int.Parse(Console.ReadLine());
            double[] a6 = new double[n6];
            for (int i = 0; i < n6; i++)
            {
                Console.Write($"a[{i}]: ");
                a6[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(a6);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            foreach (double x in a6)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine("\n\nYeah! Xong LAB2 rồi nè!");
            Console.ReadKey();
        }

        // Hàm kiểm tra số nguyên tố
        static bool LaSoNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        // Hàm hoán vị
        static void HoanVi(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}

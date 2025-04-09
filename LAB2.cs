using System;
namespace LAB2
{
    class Program
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến n
            int n;
            //Nhập giá trị cho biến n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            //Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            //Gọi hàm nhập mảng
            NhapMang(a, n);
            //Gọi hàm Tính Tổng các phần tử trong mảng và hiển thị kết quả ra màn hình
            Console.WriteLine($"Tổng = {TinhTong(a, n)}");


            //bài 1: Tính tổng các số chẵn 
            Console.WriteLine("\nBài 1: Tính tổng các số chẵn trong mảng");
            int tongChan = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    tongChan += a[i];
            }
            Console.WriteLine($"Tổng các số chẵn trong mảng là: {tongChan}");

            //bài 2: Liệt kê số nguyên tố 
            Console.WriteLine("\nBài 2: Liệt kê số nguyên tố trong mảng");
            Console.WriteLine("Các phần tử là số nguyên tố:");
            for (int i = 0; i < n; i++)
            {
                bool laNguyenTo = true;
                if (a[i] < 2)
                {
                    laNguyenTo = false;
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(a[i]); j++)
                    {
                        if (a[i] % j == 0)
                        {
                            laNguyenTo = false;
                            break;
                        }
                    }
                }

                if (laNguyenTo)
                {
                    Console.WriteLine($"a[{i}] = {a[i]}");
                }
            }

            //bài 3: Đếm số âm và dương trong mảng
            Console.WriteLine("\nBài 3: Đếm số lượng số âm và dương");
            int demAm = 0, demDuong = 0;
            foreach (int x in a)
            {
                if (x < 0) demAm++;
                else if (x > 0) demDuong++;
            }
            Console.WriteLine($"Số phần tử âm: {demAm}, Số phần tử dương: {demDuong}");

            //bài 4: Tìm số lớn thứ hai
            Console.WriteLine("\nBài 4: Tìm số lớn thứ hai trong mảng");
            int max = int.MinValue, secondMax = int.MinValue;
            foreach (int x in a)
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

            //bài 5: Hoán vị 2 số nguyên
            Console.WriteLine("\nBài 5: Hoán vị 2 số nguyên");
            Console.Write("- Nhập số nguyên a: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("- Nhập số nguyên b: ");
            int so2 = int.Parse(Console.ReadLine());

            int temp = so1;
            so1 = so2;
            so2 = temp;

            Console.WriteLine($"Sau hoán vị: a = {so1}, b = {so2}");

            //bài 6: Sắp xếp mảng số thực tăng dần
            Console.WriteLine("\nBài 6: Sắp xếp mảng số thực tăng dần");
            Console.Write("- Nhập số phần tử của mảng số thực: ");
            int m = int.Parse(Console.ReadLine());
            double[] b = new double[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write($"b[{i}]: ");
                b[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(b);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            foreach (double x in b) //foreach lặp qua cái phần tử trong mảng
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine("\n\nYeah! Xonggg");
            Console.ReadKey();
        }
    }
}

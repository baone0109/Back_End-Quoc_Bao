using System;
using System.Collections.Generic;

public abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

public class HinhTron : Hinh
{
    public double BanKinh { get; set; }
    public HinhTron(double r) => BanKinh = r;

    public override double TinhChuVi() => 2 * Math.PI * BanKinh;
    public override double TinhDienTich() => Math.PI * BanKinh * BanKinh;
}

public class HinhVuong : Hinh
{
    public double Canh { get; set; }
    public HinhVuong(double a) => Canh = a;

    public override double TinhChuVi() => 4 * Canh;
    public override double TinhDienTich() => Canh * Canh;
}

public class HinhChuNhat : Hinh
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public HinhChuNhat(double dai, double rong)
    {
        Dai = dai;
        Rong = rong;
    }

    public override double TinhChuVi() => 2 * (Dai + Rong);
    public override double TinhDienTich() => Dai * Rong;
}

public class HinhTamGiac : Hinh
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public HinhTamGiac(double a, double b, double c)
    {
        A = a; B = b; C = c;
    }

    public override double TinhChuVi() => A + B + C;

    public override double TinhDienTich()
    {
        double p = TinhChuVi() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}

class ProgramBai2
{
    static void Main(string[] args)
    {
        List<Hinh> danhSachHinh = new List<Hinh>
        {
            new HinhTron(3),
            new HinhVuong(4),
            new HinhChuNhat(5, 2),
            new HinhTamGiac(3, 4, 5)
        };

        double tongChuVi = 0;
        double tongDienTich = 0;

        foreach (var h in danhSachHinh)
        {
            tongChuVi += h.TinhChuVi();
            tongDienTich += h.TinhDienTich();
        }

        Console.WriteLine($"Tổng chu vi các hình: {tongChuVi:F2}");
        Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
    }
}

/* Bai 1: Quan Ly Can Bo
 * 
using System;
using System.Collections.Generic;

class CanBo
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string GioiTinh { get; set; }
    public string DiaChi { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        NamSinh = int.Parse(Console.ReadLine());
        Console.Write("Nhap gioi tinh: ");
        GioiTinh = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine();
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Gioi tinh: {GioiTinh}, Dia chi: {DiaChi}");
    }
}

class CongNhan : CanBo
{
    public string Bac { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap bac cong nhan (VD: 3/7): ");
        Bac = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Bac cong nhan: {Bac}");
    }
}

class KySu : CanBo
{
    public string NganhDaoTao { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap nganh dao tao: ");
        NganhDaoTao = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Nganh dao tao: {NganhDaoTao}");
    }
}

class NhanVien : CanBo
{
    public string CongViec { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap cong viec: ");
        CongViec = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Cong viec: {CongViec}");
    }
}

class QLCB
{
    private List<CanBo> danhSachCanBo = new List<CanBo>();

    public void NhapCanBoMoi()
    {
        Console.WriteLine("Chon loai can bo muon nhap:");
        Console.WriteLine("1. Cong nhan");
        Console.WriteLine("2. Ky su");
        Console.WriteLine("3. Nhan vien");
        Console.Write("Lua chon cua ban: ");
        int luaChon = int.Parse(Console.ReadLine());

        CanBo canBo = null;
        switch (luaChon)
        {
            case 1:
                canBo = new CongNhan();
                break;
            case 2:
                canBo = new KySu();
                break;
            case 3:
                canBo = new NhanVien();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        canBo.Nhap();
        danhSachCanBo.Add(canBo);
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("\n--- Danh sach can bo ---");
        foreach (var cb in danhSachCanBo)
        {
            cb.HienThi();
            Console.WriteLine("----------------------");
        }
    }

    public void TimKiemTheoTen(string ten)
    {
        Console.WriteLine($"\nKet qua tim kiem voi ten chua: {ten}");
        foreach (var cb in danhSachCanBo)
        {
            if (cb.HoTen.ToLower().Contains(ten.ToLower()))
            {
                cb.HienThi();
                Console.WriteLine("----------------------");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        QLCB qlcb = new QLCB();
        int luaChon;

        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Nhap can bo moi");
            Console.WriteLine("2. Tim kiem can bo theo ho ten");
            Console.WriteLine("3. Hien thi danh sach can bo");
            Console.WriteLine("4. Thoat");
            Console.Write("Nhap lua chon: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    qlcb.NhapCanBoMoi();
                    break;
                case 2:
                    Console.Write("Nhap ten can bo muon tim: ");
                    string ten = Console.ReadLine();
                    qlcb.TimKiemTheoTen(ten);
                    break;
                case 3:
                    qlcb.HienThiDanhSach();
                    break;
                case 4:
                    Console.WriteLine("Dang thoat chuong trinh...");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        } while (luaChon != 4);
    }
}
*/



/*Bai 2: Quan Ly Tai Lieu

using System;
using System.Collections.Generic;

class TaiLieu
{
    public string MaTaiLieu { get; set; }
    public string NhaXuatBan { get; set; }
    public int SoBanPhatHanh { get; set; }

    public virtual void Nhap()
    {
        Console.Write("Nhap ma tai lieu: ");
        MaTaiLieu = Console.ReadLine();
        Console.Write("Nhap ten nha xuat ban: ");
        NhaXuatBan = Console.ReadLine();
        Console.Write("Nhap so ban phat hanh: ");
        SoBanPhatHanh = int.Parse(Console.ReadLine());
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Ma: {MaTaiLieu}, NXB: {NhaXuatBan}, So ban: {SoBanPhatHanh}");
    }

    public virtual string LoaiTaiLieu()
    {
        return "Tai lieu";
    }
}

class Sach : TaiLieu
{
    public string TenTacGia { get; set; }
    public int SoTrang { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ten tac gia: ");
        TenTacGia = Console.ReadLine();
        Console.Write("Nhap so trang: ");
        SoTrang = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Tac gia: {TenTacGia}, So trang: {SoTrang}");
    }

    public override string LoaiTaiLieu() => "Sach";
}

class TapChi : TaiLieu
{
    public int SoPhatHanh { get; set; }
    public int ThangPhatHanh { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so phat hanh: ");
        SoPhatHanh = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang phat hanh: ");
        ThangPhatHanh = int.Parse(Console.ReadLine());
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"So PH: {SoPhatHanh}, Thang PH: {ThangPhatHanh}");
    }

    public override string LoaiTaiLieu() => "Tap chi";
}

class Bao : TaiLieu
{
    public string NgayPhatHanh { get; set; }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ngay phat hanh (dd/mm/yyyy): ");
        NgayPhatHanh = Console.ReadLine();
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Ngay PH: {NgayPhatHanh}");
    }

    public override string LoaiTaiLieu() => "Bao";
}
class QuanLyTaiLieu
{
    private List<TaiLieu> danhSach = new List<TaiLieu>();

    public void NhapTaiLieu()
    {
        Console.WriteLine("Chon loai tai lieu:");
        Console.WriteLine("1. Sach");
        Console.WriteLine("2. Tap chi");
        Console.WriteLine("3. Bao");
        Console.Write("Nhap lua chon: ");
        int chon = int.Parse(Console.ReadLine());

        TaiLieu tl = null;
        switch (chon)
        {
            case 1: tl = new Sach(); break;
            case 2: tl = new TapChi(); break;
            case 3: tl = new Bao(); break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        tl.Nhap();
        danhSach.Add(tl);
    }

    public void HienThiTatCa()
    {
        Console.WriteLine("\n--- DANH SACH TAI LIEU ---");
        foreach (var tl in danhSach)
        {
            Console.WriteLine($"Loai: {tl.LoaiTaiLieu()}");
            tl.HienThi();
            Console.WriteLine("------------------------");
        }
    }

    public void TimKiemTheoLoai(string loai)
    {
        Console.WriteLine($"\n--- Tim tai lieu theo loai: {loai} ---");
        foreach (var tl in danhSach)
        {
            if (tl.LoaiTaiLieu().ToLower() == loai.ToLower())
            {
                tl.HienThi();
                Console.WriteLine("------------------------");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        QuanLyTaiLieu qltl = new QuanLyTaiLieu();
        int luaChon;

        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Nhap tai lieu moi");
            Console.WriteLine("2. Hien thi danh sach tai lieu");
            Console.WriteLine("3. Tim tai lieu theo loai (Sach, Tap chi, Bao)");
            Console.WriteLine("4. Thoat");
            Console.Write("Nhap lua chon: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    qltl.NhapTaiLieu();
                    break;
                case 2:
                    qltl.HienThiTatCa();
                    break;
                case 3:
                    Console.Write("Nhap loai tai lieu muon tim: ");
                    string loai = Console.ReadLine();
                    qltl.TimKiemTheoLoai(loai);
                    break;
                case 4:
                    Console.WriteLine("Dang thoat chuong trinh...");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        } while (luaChon != 4);
    }
}

/*Bai 3: 

using System;
using System.Collections.Generic;

abstract class ThiSinh
{
    public string SoBaoDanh { get; set; }
    public string HoTen { get; set; }
    public string DiaChi { get; set; }
    public double UuTien { get; set; }

    public ThiSinh(string sbd, string hoTen, string diaChi, double uuTien)
    {
        SoBaoDanh = sbd;
        HoTen = hoTen;
        DiaChi = diaChi;
        UuTien = uuTien;
    }

    public abstract double TongDiem();
    public abstract string KhoiThi();
    public virtual void HienThi()
    {
        Console.WriteLine($"SBD: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Ưu tiên: {UuTien}, Khối: {KhoiThi()}, Tổng điểm: {TongDiem()}");
    }
}

class ThiSinhKhoiA : ThiSinh
{
    public double Toan, Ly, Hoa;
    public ThiSinhKhoiA(string sbd, string hoTen, string diaChi, double uuTien, double toan, double ly, double hoa)
        : base(sbd, hoTen, diaChi, uuTien)
    {
        Toan = toan; Ly = ly; Hoa = hoa;
    }

    public override double TongDiem() => Toan + Ly + Hoa + UuTien;
    public override string KhoiThi() => "A";
}

class ThiSinhKhoiB : ThiSinh
{
    public double Toan, Hoa, Sinh;
    public ThiSinhKhoiB(string sbd, string hoTen, string diaChi, double uuTien, double toan, double hoa, double sinh)
        : base(sbd, hoTen, diaChi, uuTien)
    {
        Toan = toan; Hoa = hoa; Sinh = sinh;
    }

    public override double TongDiem() => Toan + Hoa + Sinh + UuTien;
    public override string KhoiThi() => "B";
}

class ThiSinhKhoiC : ThiSinh
{
    public double Van, Su, Dia;
    public ThiSinhKhoiC(string sbd, string hoTen, string diaChi, double uuTien, double van, double su, double dia)
        : base(sbd, hoTen, diaChi, uuTien)
    {
        Van = van; Su = su; Dia = dia;
    }

    public override double TongDiem() => Van + Su + Dia + UuTien;
    public override string KhoiThi() => "C";
}

class TuyenSinh
{
    private List<ThiSinh> danhSach = new List<ThiSinh>();

    public void NhapThiSinh()
    {
        Console.Write("Chọn khối thi (A/B/C): ");
        string khoi = Console.ReadLine().ToUpper();

        Console.Write("Số báo danh: "); string sbd = Console.ReadLine();
        Console.Write("Họ tên: "); string hoTen = Console.ReadLine();
        Console.Write("Địa chỉ: "); string diaChi = Console.ReadLine();
        Console.Write("Điểm ưu tiên: "); double uuTien = double.Parse(Console.ReadLine());

        switch (khoi)
        {
            case "A":
                Console.Write("Toán: "); double toanA = double.Parse(Console.ReadLine());
                Console.Write("Lý: "); double ly = double.Parse(Console.ReadLine());
                Console.Write("Hóa: "); double hoaA = double.Parse(Console.ReadLine());
                danhSach.Add(new ThiSinhKhoiA(sbd, hoTen, diaChi, uuTien, toanA, ly, hoaA));
                break;
            case "B":
                Console.Write("Toán: "); double toanB = double.Parse(Console.ReadLine());
                Console.Write("Hóa: "); double hoaB = double.Parse(Console.ReadLine());
                Console.Write("Sinh: "); double sinh = double.Parse(Console.ReadLine());
                danhSach.Add(new ThiSinhKhoiB(sbd, hoTen, diaChi, uuTien, toanB, hoaB, sinh));
                break;
            case "C":
                Console.Write("Văn: "); double van = double.Parse(Console.ReadLine());
                Console.Write("Sử: "); double su = double.Parse(Console.ReadLine());
                Console.Write("Địa: "); double dia = double.Parse(Console.ReadLine());
                danhSach.Add(new ThiSinhKhoiC(sbd, hoTen, diaChi, uuTien, van, su, dia));
                break;
            default:
                Console.WriteLine("Khối không hợp lệ!");
                break;
        }
    }

    public void HienThiTrungTuyen()
    {
        foreach (var ts in danhSach)
        {
            double diemChuan = ts.KhoiThi() switch
            {
                "A" => 15,
                "B" => 16,
                "C" => 13.5,
                _ => 0
            };

            if (ts.TongDiem() >= diemChuan)
            {
                ts.HienThi();
            }
        }
    }

    public void TimTheoSBD()
    {
        Console.Write("Nhập số báo danh cần tìm: ");
        string sbd = Console.ReadLine();
        var tim = danhSach.Find(ts => ts.SoBaoDanh == sbd);
        if (tim != null) tim.HienThi();
        else Console.WriteLine("Không tìm thấy thí sinh!");
    }
}

class Program
{
    static void Main()
    {
        TuyenSinh ts = new TuyenSinh();
        int chon;

        do
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1. Nhập thí sinh");
            Console.WriteLine("2. Hiển thị thí sinh trúng tuyển");
            Console.WriteLine("3. Tìm theo số báo danh");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1: ts.NhapThiSinh(); break;
                case 2: ts.HienThiTrungTuyen(); break;
                case 3: ts.TimTheoSBD(); break;
                case 0: Console.WriteLine("Thoát chương trình."); break;
                default: Console.WriteLine("Chọn sai!"); break;
            }

        } while (chon != 0);
    }
}


*/
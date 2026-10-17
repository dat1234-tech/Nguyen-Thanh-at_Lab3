//namespace Lab03_Bai1
//{
//    public class Nguoi
//    {
//        public string HoTen { get; set; }
//        public DateTime NgaySinh { get; set; }

//        public Nguoi(string hoTen, DateTime ngaySinh)
//        {
//            HoTen = hoTen;
//            NgaySinh = ngaySinh;
//        }
//    }

//    public class SinhVien : Nguoi
//    {
//        public string MaSV { get; set; }
//        public double DiemTB { get; set; }

//        public SinhVien(string ma, string ten, DateTime ngaySinh, double diem)
//            : base(ten, ngaySinh) 
//        {
//            MaSV = ma;
//            DiemTB = diem;
//        }

//        public void HienThi()
//        {
//            Console.WriteLine($"Mã: {MaSV} | Họ tên: {HoTen} | Ngày sinh: {NgaySinh:dd/MM/yyyy} | Điểm TB: {DiemTB}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            SinhVien sv = new SinhVien("24002929", "Nguyễn Thành Đạt", new DateTime(2006, 10, 13), 8.5);
//            sv.HienThi();

//            Console.ReadKey();
//        }
//    }
//}
// -------------------------------------------------------------------------------------

//namespace Lab03_Bai2
//{
//    public class Nguoi
//    {
//        public string HoTen { get; set; }
//        public DateTime NgaySinh { get; set; }

//        public Nguoi(string hoTen, DateTime ngaySinh)
//        {
//            HoTen = hoTen;
//            NgaySinh = ngaySinh;
//        }

//        public virtual string MoTa()
//        {
//            return HoTen + " - " + NgaySinh.ToString("dd/MM/yyyy");
//        }
//    }

//    public class SinhVien : Nguoi
//    {
//        public string MaSV { get; set; }
//        public double DiemTB { get; set; }

//        public SinhVien(string ma, string ten, DateTime ngaySinh, double diem)
//            : base(ten, ngaySinh)
//        {
//            MaSV = ma;
//            DiemTB = diem;
//        }

//        public override string MoTa()
//        {
//            return base.MoTa() + " - " + MaSV + " - Điểm: " + DiemTB.ToString("N2");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            SinhVien sv = new SinhVien("SV02", "Trần Bình", new DateTime(2005, 9, 3), 7.8);
//            Console.WriteLine(sv.MoTa());

//            Console.ReadKey();
//        }
//    }
//}
// ---------------------------------------------------------------------------------------

//namespace Lab03_Bai3
//{
//    public abstract class NguoiHoc
//    {
//        public string HoTen { get; set; }
//        public int SoTinChi { get; set; }
//        public abstract decimal TinhHocPhi();
//    }

//    public class SinhVienChinhQuy : NguoiHoc
//    {
//        public override decimal TinhHocPhi() => SoTinChi * 450000m;
//    }

//    public class SinhVienLienThong : NguoiHoc
//    {
//        public override decimal TinhHocPhi() => SoTinChi * 520000m;
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            NguoiHoc svcq = new SinhVienChinhQuy { HoTen = "Nguyễn Văn An", SoTinChi = 18 };
//            NguoiHoc svlt = new SinhVienLienThong { HoTen = "Trần Thị Bình", SoTinChi = 15 };

//            Console.WriteLine($"Chính quy: {svcq.HoTen} - Học phí: {svcq.TinhHocPhi():N0} VNĐ");
//            Console.WriteLine($"Liên thông: {svlt.HoTen} - Học phí: {svlt.TinhHocPhi():N0} VNĐ");

//            Console.ReadKey();
//        }
//    }
//}
// ----------------------------------------------------------------------------------------

//namespace Lab03_Bai4
//{
//    public interface IValidatable
//    {
//        bool IsValid(out string message);
//    }

//    public interface IPrintable
//    {
//        string ToDisplayText();
//    }

//    public class SinhVien : IValidatable, IPrintable
//    {
//        public string MaSV { get; set; }
//        public string HoTen { get; set; }
//        public double DiemTB { get; set; }

//        public SinhVien(string ma, string ten, double diem)
//        {
//            MaSV = ma;
//            HoTen = ten;
//            DiemTB = diem;
//        }

//        public bool IsValid(out string message)
//        {
//            if (string.IsNullOrWhiteSpace(MaSV)) { message = "Thiếu mã sinh viên"; return false; }
//            if (DiemTB < 0 || DiemTB > 10) { message = "Điểm TB không hợp lệ (0-10)"; return false; }
//            message = "Hợp lệ";
//            return true;
//        }

//        public string ToDisplayText()
//        {
//            return $"Mã: {MaSV} | Họ tên: {HoTen} | Điểm: {DiemTB:N2}";
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            SinhVien sv = new SinhVien("SV04", "Lê Thị C", 8.5);
//            if (sv.IsValid(out string msg))
//            {
//                Console.WriteLine("Dữ liệu hợp lệ: " + sv.ToDisplayText());
//            }
//            else
//            {
//                Console.WriteLine("Dữ liệu lỗi: " + msg);
//            }

//            Console.ReadKey();
//        }
//    }
//}
// ------------------------------------------------------------------------------------------

//namespace Lab03_Bai5
//{
//    public abstract class NguoiHoc
//    {
//        public string HoTen { get; set; }
//        public int SoTinChi { get; set; }
//        public abstract decimal TinhHocPhi();
//    }

//    public class SinhVienChinhQuy : NguoiHoc
//    {
//        public override decimal TinhHocPhi() => SoTinChi * 450000m;
//    }

//    public class SinhVienLienThong : NguoiHoc
//    {
//        public override decimal TinhHocPhi() => SoTinChi * 520000m;
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            List<NguoiHoc> ds = new List<NguoiHoc>();
//            ds.Add(new SinhVienChinhQuy { HoTen = "An", SoTinChi = 18 });
//            ds.Add(new SinhVienLienThong { HoTen = "Bình", SoTinChi = 15 });

//            decimal tong = 0;
//            foreach (NguoiHoc item in ds)
//            {
//                decimal hocPhi = item.TinhHocPhi();
//                tong += hocPhi;
//                Console.WriteLine($"Học viên: {item.HoTen,-10} | Học phí: {hocPhi,10:N0} VNĐ");
//            }
//            Console.WriteLine($"----------------------------------------");
//            Console.WriteLine($"Tổng học phí: {tong:N0} VNĐ");

//            Console.ReadKey();
//        }
//    }
//}
// --------------------------------------------------------------------------------
//namespace Lab03_Bai6
//{
//    public abstract class NhanVien
//    {
//        public string MaNV { get; set; }
//        public string HoTen { get; set; }
//        public abstract double TinhLuong();
//    }

//    public class NhanVienVanPhong : NhanVien
//    {
//        public double LuongCoBan { get; set; }
//        public int SoNgayLamViec { get; set; }
//        public override double TinhLuong() => LuongCoBan * (SoNgayLamViec / 22.0);
//    }

//    public class NhanVienKinhDoanh : NhanVien
//    {
//        public double LuongCung { get; set; }
//        public double DoanhSo { get; set; }
//        public override double TinhLuong() => LuongCung + (DoanhSo * 0.1);
//    }

//    public class GiangVien : NhanVien
//    {
//        public int SoTietDay { get; set; }
//        public double DonGiaTiet { get; set; }
//        public override double TinhLuong() => SoTietDay * DonGiaTiet;
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            List<NhanVien> ds = new List<NhanVien>
//            {
//                new NhanVienVanPhong { MaNV = "VP01", HoTen = "Nguyễn Văn A", LuongCoBan = 10000000, SoNgayLamViec = 22 },
//                new NhanVienKinhDoanh { MaNV = "KD01", HoTen = "Trần Thị B", LuongCung = 6000000, DoanhSo = 50000000 },
//                new GiangVien { MaNV = "GV01", HoTen = "Lê Hoàng C", SoTietDay = 45, DonGiaTiet = 120000 }
//            };

//            foreach (var nv in ds)
//            {
//                Console.WriteLine($"Mã: {nv.MaNV} | Tên: {nv.HoTen,-12} | Loại: {nv.GetType().Name,-18} | Lương: {nv.TinhLuong(),10:N0} VNĐ");
//            }

//            Console.ReadKey();
//        }
//    }
//}
// --------------------------------------------------------------------------------
//namespace Lab03_Bai7
//{
//    public interface IMove
//    {
//        void ChuyenDong();
//        double TinhChiPhiVanhHanh(double soKm);
//    }

//    public class XeMay : IMove
//    {
//        public string BienSo { get; set; }
//        public void ChuyenDong() => Console.WriteLine($"Xe máy {BienSo} chạy xăng, tốc độ 50 km/h.");
//        public double TinhChiPhiVanhHanh(double soKm) => (soKm / 40.0) * 22000;
//    }

//    public class OTo : IMove
//    {
//        public string BienSo { get; set; }
//        public void ChuyenDong() => Console.WriteLine($"Ô tô {BienSo} chạy xăng, tốc độ 80 km/h.");
//        public double TinhChiPhiVanhHanh(double soKm) => (soKm / 10.0) * 22000;
//    }

//    public class XeDap : IMove
//    {
//        public string TenXe { get; set; }
//        public void ChuyenDong() => Console.WriteLine($"Xe đạp {TenXe} chạy sức người, tốc độ 15 km/h.");
//        public double TinhChiPhiVanhHanh(double soKm) => 0;
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            List<IMove> ds = new List<IMove>
//            {
//                new XeMay { BienSo = "29-A1 123.45" },
//                new OTo { BienSo = "30-F2 999.99" },
//                new XeDap { TenXe = "Thống Nhất" }
//            };

//            foreach (var pt in ds)
//            {
//                pt.ChuyenDong();
//                Console.WriteLine($"-> Chi phí chạy 50km: {pt.TinhChiPhiVanhHanh(50):N0} VNĐ\n");
//            }

//            Console.ReadKey();
//        }
//    }
//}
// --------------------------------------------------------------------------------
//namespace Lab03_Bai8
//{
//    public abstract class TaiLieu
//    {
//        public string MaTL { get; set; }
//        public string TenTL { get; set; }
//        public int NamXubBan { get; set; }

//        public virtual void HienThi() => Console.WriteLine($"Mã: {MaTL} | Tên: {TenTL} | Năm: {NamXubBan}");
//    }

//    public class Sach : TaiLieu
//    {
//        public string TacGia { get; set; }
//        public override void HienThi() => Console.WriteLine($"[Sách] Mã: {MaTL} | Tên: {TenTL} | Tác giả: {TacGia} | Năm: {NamXubBan}");
//    }

//    public class TapChi : TaiLieu
//    {
//        public int SoPhatHanh { get; set; }
//        public override void HienThi() => Console.WriteLine($"[Tạp chí] Mã: {MaTL} | Tên: {TenTL} | Số PH: {SoPhatHanh} | Năm: {NamXubBan}");
//    }

//    public class LuanVan : TaiLieu
//    {
//        public string TacGia { get; set; }
//        public override void HienThi() => Console.WriteLine($"[Luận văn] Mã: {MaTL} | Tên: {TenTL} | Tác giả: {TacGia} | Năm: {NamXubBan}");
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8

//            List<TaiLieu> ds = new List<TaiLieu>
//            {
//                new Sach { MaTL = "S01", TenTL = "Lập trình C#", TacGia = "Microsoft", NamXubBan = 2024 },
//                new TapChi { MaTL = "TC01", TenTL = "CNTT & Đời sống", SoPhatHanh = 5, NamXubBan = 2025 },
//                new LuanVan { MaTL = "LV01", TenTL = "Odoo CRM System", TacGia = "Đạt", NamXubBan = 2026 }
//            };

//            foreach (var tl in ds) tl.HienThi();

//            Console.ReadKey();
//        }
//    }
//}
// --------------------------------------------------------------------------------
//namespace Lab03_Bai9
//{
//    public interface IPayment
//    {
//        bool KiemTraGiaoDich();
//        void ThucHienThanhToan(decimal soTien);
//    }

//    public class ThanhToanTienMat : IPayment
//    {
//        public bool KiemTraGiaoDich() => true;
//        public void ThucHienThanhToan(decimal soTien) => Console.WriteLine($"[Tiền mặt] Thanh toán thành công {soTien:N0} VNĐ.");
//    }

//    public class ChuyenKhoan : IPayment
//    {
//        public string SoTK { get; set; }
//        public bool KiemTraGiaoDich() => !string.IsNullOrEmpty(SoTK);
//        public void ThucHienThanhToan(decimal soTien)
//        {
//            if (KiemTraGiaoDich()) Console.WriteLine($"[Chuyển khoản] Đã chuyển {soTien:N0} VNĐ vào TK: {SoTK}.");
//        }
//    }

//    public class ViDienTu : IPayment
//    {
//        public decimal SoDu { get; set; }
//        public bool KiemTraGiaoDich() => SoDu >= 0;
//        public void ThucHienThanhToan(decimal soTien)
//        {
//            if (SoDu >= soTien) Console.WriteLine($"[Ví điện tử] Thanh toán thành công {soTien:N0} VNĐ qua ví.");
//            else Console.WriteLine("[Ví điện tử] Không đủ số dư!");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            IPayment tt1 = new ThanhToanTienMat();
//            tt1.ThucHienThanhToan(200000);

//            IPayment tt2 = new ChuyenKhoan { SoTK = "123456789" };
//            tt2.ThucHienThanhToan(1000000);

//            IPayment tt3 = new ViDienTu { SoDu = 5000000 };
//            tt3.ThucHienThanhToan(300000);

//            Console.ReadKey();
//        }
//    }
//}
// --------------------------------------------------------------------------------
using System.Linq;

namespace Lab03_Bai10
{
    public interface IPrintable
    {
        string ToDisplayText();
    }

    public abstract class NguoiHoc : IPrintable
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }

        public abstract decimal TinhHocPhi();
        public virtual string ToDisplayText() => $"Mã: {MaSV,-6} | Tên: {HoTen,-15} | Điểm TB: {DiemTB,-4} | Học phí: {TinhHocPhi(),10:N0}";
    }

    public class SinhVienChinhQuy : NguoiHoc
    {
        public int SoTinChi { get; set; }
        public override decimal TinhHocPhi() => SoTinChi * 450000m;
        public override string ToDisplayText() => "[Chính quy] " + base.ToDisplayText();
    }

    public class SinhVienLienThong : NguoiHoc
    {
        public int SoTinChi { get; set; }
        public override decimal TinhHocPhi() => SoTinChi * 520000m;
        public override string ToDisplayText() => "[Liên thông] " + base.ToDisplayText();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<NguoiHoc> ds = new List<NguoiHoc>
            {
                new SinhVienChinhQuy { MaSV = "SV01", HoTen = "Nguyễn An", DiemTB = 8.5, SoTinChi = 18 },
                new SinhVienLienThong { MaSV = "SV02", HoTen = "Trần Bình", DiemTB = 7.0, SoTinChi = 15 }
            };

            int chon;
            do
            {
                Console.WriteLine("\n======== QUẢN LÝ SINH VIÊN LAB 3 ========");
                Console.WriteLine("1. Hiển thị danh sách sinh viên");
                Console.WriteLine("2. Tính tổng học phí toàn danh sách");
                Console.WriteLine("3. Tìm kiếm sinh viên theo mã");
                Console.WriteLine("0. Thoát");
                Console.Write("Lựa chọn: ");

                if (!int.TryParse(Console.ReadLine(), out chon)) continue;

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("\n--- DANH SÁCH ---");
                        foreach (var sv in ds) Console.WriteLine(sv.ToDisplayText());
                        break;
                    case 2:
                        decimal tong = ds.Sum(s => s.TinhHocPhi());
                        Console.WriteLine($"-> Tổng học phí: {tong:N0} VNĐ");
                        break;
                    case 3:
                        Console.Write("Nhập mã cần tìm: "); string ma = Console.ReadLine();
                        var kq = ds.Find(s => s.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase));
                        if (kq != null) Console.WriteLine("-> Tìm thấy: " + kq.ToDisplayText());
                        else Console.WriteLine("-> Không tìm thấy!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
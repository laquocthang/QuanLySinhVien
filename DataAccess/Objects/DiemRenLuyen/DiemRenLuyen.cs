using System;

namespace DataAccess
{
	/// <summary>Xếp loại rèn luyện</summary>
	/// <remarks>
	/// Từ 90 đến 100 điểm – Xuất sắc
	/// Từ 80 đến 89 điểm – Tốt
	/// Từ 65 đến 79 điểm – Khá
	/// Từ 50 đến 64 điểm – Trung bình
	/// Từ 35 đến 49 điểm – Yếu
	/// Dưới 35 điểm – Kém
	/// </remarks>
	public enum XếpLoạiRL
	{
		XuấtSắc,
		Tốt,
		Khá,
		TrungBình,
		Yếu,
		Kém
	}

	public enum HọcKỳ
	{
		HKI,
		HKII
	}

	/// <summary>
	/// Điểm rèn luyện tương ứng với một học kỳ trong một năm học cụ thể
	/// </summary>
	public class DiemRenLuyen
	{
		public SinhVien SV { get; set; }
		public int TongDiem { get; set; }
		public XếpLoạiRL XepLoai { get; set; }
		public HọcKỳ HocKy { get; set; }
		public int NamHoc { get; set; }
		public ChiTietDiemRenLuyen ChiTiet { get; set; }
		public DateTime ThoiGianBD { get; set; }
		public DateTime ThoiGianKT { get; set; }

		public DiemRenLuyen()
		{

		}

		public DiemRenLuyen(SinhVien sV, int tongDiem, XếpLoạiRL xepLoai, HọcKỳ hocKy, int namHoc, ChiTietDiemRenLuyen chiTiet, DateTime thoiGianBD, DateTime thoiGianKT)
		{
			SV = sV;
			TongDiem = tongDiem;
			XepLoai = xepLoai;
			HocKy = hocKy;
			NamHoc = namHoc;
			ChiTiet = chiTiet;
			ThoiGianBD = thoiGianBD;
			ThoiGianKT = thoiGianKT;
		}
	}
}

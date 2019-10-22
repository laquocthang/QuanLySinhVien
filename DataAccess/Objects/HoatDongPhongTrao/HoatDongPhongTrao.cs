using System;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Hoạt động phong trào
	/// </summary>
	public class HoatDongPhongTrao
	{
		public string TenHD { get; set; }
		public string MoTa { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }
		public List<SinhVien> DanhSachSVThamGia { get; set; }

		public HoatDongPhongTrao()
		{

		}

		public HoatDongPhongTrao(string tenHD, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, List<SinhVien> danhSachSVThamGia)
		{
			TenHD = tenHD;
			MoTa = moTa;
			NgayBatDau = ngayBatDau;
			NgayKetThuc = ngayKetThuc;
			DanhSachSVThamGia = danhSachSVThamGia;
		}
	}
}

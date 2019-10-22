using System;

namespace DataAccess
{
	/// <summary>
	/// Tài nguyên học tập của một môn học
	/// </summary>
	public class TaiNguyen
	{
		public string MonHoc { get; set; }
		public GiangVien GiangVien { get; set; }
		public DateTime NgayDang { get; set; }
		public string MoTa { get; set; }

		public TaiNguyen()
		{

		}

		public TaiNguyen(string monHoc, GiangVien giangVien, DateTime ngayDang, string moTa)
		{
			MonHoc = monHoc;
			GiangVien = giangVien;
			NgayDang = ngayDang;
			MoTa = moTa;
		}
	}
}

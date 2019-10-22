using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Sinh viên
	/// </summary>
	public class SinhVien : ConNguoi
	{
		public string MSSV { get; set; }
		public LopHoc LopHoc { get; set; }
		public bool ConHoc { get; set; } //Tình trạng học tập của sinh viên: Còn học hay Nghỉ học
		public List<DiemRenLuyen> DanhSachDRL { get; set; } //Danh sách điểm rèn luyện theo từng học kỳ

		public SinhVien()
		{

		}

		public SinhVien(string mSSV, LopHoc lopHoc, bool conHoc, List<DiemRenLuyen> danhSachDRL)
		{
			MSSV = mSSV;
			LopHoc = lopHoc;
			ConHoc = conHoc;
			DanhSachDRL = danhSachDRL;
		}
	}
}

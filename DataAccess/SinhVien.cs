using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}

using System;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Bộ môn trực thuộc
	/// BộMôn.Khác nghĩa là giảng viên ngoài khoa, còn lại là GV trong khoa
	/// </summary>
	public enum BộMôn
	{
		MạngTruyềnThông,
		KỹThuậtPhầnMềm,
		Khác
	}

	/// <summary>Học vị</summary>
	/// <remarks>
	/// Là văn bằng do một cơ sở giáo dục hợp pháp trong hoặc ngoài nước cấp cho người tốt nghiệp 
	/// một cấp học nhất định.
	/// </summary>
	public enum HọcVị
	{
		CửNhân,
		KỹSư,
		ThạcSĩ,
		TiếnSĩ,
		TiếnSĩKhoaHọc
	}

	/// <summary>Học hàm</summary>
	/// <remarks> 
	/// Là các chức danh trong hệ thống giáo dục và đào tạo được Hội đồng Chức danh Giáo sư Việt Nam 
	/// hoặc cơ quan nước ngoài bổ nhiệm cho một người làm công tác giảng dạy hoặc nghiên cứu.
	/// </remarks>
	public enum HọcHàm
	{
		Không,
		PhóGiáoSư,
		GiáoSư
	}

	/// <summary>
	/// Giảng viên
	/// </summary>
	public abstract class GiangVien : ConNguoi
	{
		public string MaGV { get; set; }
		public BộMôn BoMon { get; set; }
		public HọcVị HocVi { get; set; }
		public HọcHàm HocHam { get; set; }
		public DateTime NgayBatDau { get; set; }
		public bool ConDay { get; set; } //Tình trạng giảng dạy của GV: Còn dạy hay Không còn dạy
	}
}

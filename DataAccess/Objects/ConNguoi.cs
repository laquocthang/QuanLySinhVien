using System;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Giới tính
	/// </summary>
	public enum GioiTinh
	{
		Nam,
		Nữ,
		Khác
	}

	/// <summary>
	/// Tôn giáo
	/// </summary>
	public enum TonGiao
	{
		Không,
		PhậtGiáo,
		CôngGiáo,
		CaoĐài,
		TinLành,
		HoàHảo,
		Khác
	}

	/// <summary>
	/// Con người
	/// </summary>
	public abstract class ConNguoi  
	{
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public string CMND { get; set; }
		public GioiTinh GioiTinh { get; set; }
		public DiaChi ThuongTru { get; set; }
		public DiaChi TamTru { get; set; }
		public List<String> SoDT { get; set; }
		public List<String> Email { get; set; }
		public List<ConNguoi> ThanNhan { get; set; }
		public TaiKhoan TaiKhoan { get; set; }
        
    }
}

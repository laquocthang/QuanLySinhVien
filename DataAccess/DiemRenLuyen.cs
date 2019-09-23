using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public int TongDiem { get; set; }
		public XếpLoạiRL XepLoai { get; set; }
		public HọcKỳ HocKy { get; set; }
		public int NamHoc { get; set; }
		public ChiTietDiemRenLuyen ChiTiet { get; set; }

        public static int Add(DiemRenLuyen data)
        {
            return 0;
        }
        public static bool Update(DiemRenLuyen data)
        {
            return false;
        }
        public static bool Delete(DiemRenLuyen data)
        {
            return false;
        }
        public static List<DiemRenLuyen> GetAll()
        {
            return null;
        }
        public static List<DiemRenLuyen> GetList(Condition condition)
        {
            return null;
        }
    }
}

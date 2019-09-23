using System;
using System.Collections.Generic;

namespace DataAccess
{
	/// <summary>
	/// Loại tài khoản
	/// </summary>
	public enum LoaiTaiKhoan
	{
		SinhViên,
		GiảngViên,
		GVCN,
		BíThưĐoàn,
		TrợLýGiáoVụ
	}

	/// <summary>
	/// Tài khoản
	/// </summary>
	public class TaiKhoan
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public LoaiTaiKhoan Loai { get; set; }


        public static bool Add(TaiKhoan data)
        {
            return false;
        }
        public static bool Update(TaiKhoan data)
        {
            return false;
        }
        public static bool Delete(TaiKhoan data)
        {
            return false;
        }
        public static List<TaiKhoan> GetAll()
        {
            return null;
        }
        public static List<TaiKhoan> GetList(Condition condition)
        {
            return null;
        }
    }
}

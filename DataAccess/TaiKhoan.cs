namespace DataAccess
{
	public enum LoaiTaiKhoan
	{
		SinhViên,
		GiảngViên,
		GVCN,
		BíThưĐoàn,
		TrợLýGiáoVụ
	}

	public class TaiKhoan
	{
		public string Username { get; set; }
		public string Password { get; set; }
		LoaiTaiKhoan loai { get; set; }
	}
}

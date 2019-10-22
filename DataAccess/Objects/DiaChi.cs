using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	/// <summary>
	/// Địa chỉ
	/// </summary>
	public class DiaChi
	{
		/// <summary>
		/// Tỉnh/ Thành phố trực thuộc Trung ương
		/// </summary>
		public string TinhThanh { get; set; }

		/// <summary>
		/// Huyện/ Thành phố/ Thị xã trực thuộc tỉnh, Quận trực thuộc Thành phố
		/// </summary>
		public string QuanHuyen { get; set; }

		/// <summary>
		/// Xã, Thị trấn trực thuộc Huyện, Phường trực thuộc Thành phố
		/// </summary>
		public string XaPhuong { get; set; }

		/// <summary>
		/// Địa chỉ chi tiết, bổ sung thêm bên cạnh các thông tin trên
		/// </summary>
		public string ChiTiet { get; set; }
    }
}

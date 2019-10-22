using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	/// <summary>
	/// Giáo viên chủ nhiệm
	/// </summary>
	public class GVCN : GiangVien
	{
		public List<LopHoc> LopCN { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
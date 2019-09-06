using System.Collections.Generic;

namespace QuanLySinhVien
{
	public class StaticVariable
	{
		public static List<TheUseCase> LIST_UC = new List<TheUseCase>() {
			new TheUseCase() {
				LinkPage = "#",
				TitlePage = "Quản lý sinh viên",
				TheID = 1
			},
			new TheUseCase() {
				LinkPage = "#",
				TitlePage = "Quản lý lớp học",
				TheID = 2
			},
			new TheUseCase() {
				LinkPage = "#",
				TitlePage = "Quản lý ý kiến - thảo luận",
				TheID = 3
			},
			new TheUseCase() {
				LinkPage = "#",
				TitlePage = "Quản lý khảo sát",
				TheID = 4
			},
			new TheUseCase() {
				LinkPage = "#",
				TitlePage = "Quản lý điểm rèn luyện",
				TheID = 5
			},
			new TheUseCase() {
				LinkPage = "#",
				TitlePage = "Quản lý tài nguyên học tập",
				TheID = 6
			},
			new TheUseCase() {
				LinkPage = "#",
				TitlePage = "Quản lý hoạt động phong trào",
				TheID = 7
			},
			new TheUseCase() {
				LinkPage = "#",
				TitlePage = "Quản lý thông báo",
				TheID = 8
			},
		};
	}
}
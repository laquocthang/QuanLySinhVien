using System.Collections.Generic;

namespace QuanLySinhVien
{
	public class UseCase
	{
		public string Link { get; set; }
		public string Title { get; set; }
		public int ID { get; set; }
	}

	public class UseCaseList
	{
		public static List<UseCase> listUseCase = new List<UseCase>() {
			new UseCase() {
				Link = "Student",
				Title = "Quản lý sinh viên",
				ID = 1
			},
			new UseCase() {
				Link = "Class",
				Title = "Quản lý lớp học",
				ID = 2
			},
			new UseCase() {
				Link = "Discussion",
				Title = "Quản lý ý kiến - thảo luận",
				ID = 3
			},
			new UseCase() {
				Link = "Survey",
				Title = "Quản lý khảo sát",
				ID = 4
			},
			new UseCase() {
				Link = "Conduct",
				Title = "Quản lý điểm rèn luyện",
				ID = 5
			},
			new UseCase() {
				Link = "Resource",
				Title = "Quản lý tài nguyên học tập",
				ID = 6
			},
			new UseCase() {
				Link = "Activity",
				Title = "Quản lý hoạt động phong trào",
				ID = 7
			},
			new UseCase() {
				Link = "News",
				Title = "Quản lý thông báo",
				ID = 8
			},
		};
	}
}
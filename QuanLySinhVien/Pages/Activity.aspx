<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="QuanLySinhVien.Pages.Activity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
	<ul class="nav nav-pills flex-column">
		<li class="nav-item">
			<a class="nav-link active" href="#">Xem danh sách phong trào</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Đăng ký tham gia phong trào</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Thêm hoạt động phong trào</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Xóa hoạt động phong trào</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Cập nhật thông tin phong trào</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Quản lý sinh viên tham dự</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Đánh dấu kết thúc</a>
		</li>
	</ul>
	<hr class="d-sm-none" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
</asp:Content>

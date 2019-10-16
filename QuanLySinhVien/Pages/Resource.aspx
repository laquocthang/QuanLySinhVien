<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Resource.aspx.cs" Inherits="QuanLySinhVien.Pages.Resource" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
	<ul class="nav nav-pills flex-column">
		<li class="nav-item">
			<a class="nav-link active" href="#">Xem tài nguyên môn học</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Đăng tải tài nguyên môn học</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Xóa thông tin môn học</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Cập nhật thông tin môn học</a>
		</li>
	</ul>
	<hr class="d-sm-none" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
</asp:Content>

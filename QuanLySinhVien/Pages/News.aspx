<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="QuanLySinhVien.Pages.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
	<ul class="nav nav-pills flex-column">
		<li class="nav-item">
			<a class="nav-link active" href="#">Xem danh sách thông báo</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Thêm thông báo</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Xóa thông báo</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Cập nhật thông báo</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Tìm kiếm thông báo</a>
		</li>
	</ul>
	<hr class="d-sm-none" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
</asp:Content>

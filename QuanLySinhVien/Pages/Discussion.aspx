<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Discussion.aspx.cs" Inherits="QuanLySinhVien.Pages.Discussion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
	<ul class="nav nav-pills flex-column">
		<li class="nav-item">
			<a class="nav-link active" href="#">Xem danh sách ý kiến</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Gửi ý kiến - thảo luận</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Kiểm duyệt ý kiến</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Bình chọn ý kiến</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Bình luận</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Tiếp nhận ý kiến</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Tìm kiếm</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Xóa ý kiến</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Xuất danh sách ra file</a>
		</li>
	</ul>
	<hr class="d-sm-none" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
</asp:Content>

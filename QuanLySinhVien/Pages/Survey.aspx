<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="QuanLySinhVien.Pages.Survey" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
	<ul class="nav nav-pills flex-column">
		<li class="nav-item">
			<a class="nav-link active" href="#">Thêm khảo sát</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Xóa khảo sát</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Thay đổi thông tin</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Thực hiện khảo sát</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Đánh dấu kết thúc</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Hiển thị kết quả khảo sát</a>
		</li>
	</ul>
	<hr class="d-sm-none" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
</asp:Content>

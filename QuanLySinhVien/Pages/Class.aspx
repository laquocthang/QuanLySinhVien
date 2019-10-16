<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Class.aspx.cs" Inherits="QuanLySinhVien.Pages.Class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
	<ul class="nav nav-pills flex-column">
		<li class="nav-item">
			<a class="nav-link active" href="#">Xem danh sách lớp học</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Thêm lớp học</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Xóa lớp học</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Thay đổi thông tin lớp học</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Tìm kiếm lớp học</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Xuất danh sách ra file</a>
		</li>
	</ul>
	<hr class="d-sm-none" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
	<asp:GridView runat="server" ID="grid_LopHoc" CssClass="table table-bordered table-striped" AutoGenerateColumns="false" AllowPaging="true" PageSize="10">
		<Columns>
			<asp:BoundField DataField="STT" HeaderText="Số thứ tự" />
			<asp:BoundField DataField="Lop" HeaderText="Tên lớp" />
			<asp:BoundField DataField="ThaoTac" HeaderText="Thao tác" />
		</Columns>
	</asp:GridView>
</asp:Content>

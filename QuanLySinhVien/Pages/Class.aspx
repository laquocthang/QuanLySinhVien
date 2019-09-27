<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Class.aspx.cs" Inherits="QuanLySinhVien.Pages.Class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
	<ul class="nav nav-pills flex-column">
		<li class="nav-item">
			<a class="nav-link active" href="#">Active</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Link</a>
		</li>
		<li class="nav-item">
			<a class="nav-link" href="#">Link</a>
		</li>
		<li class="nav-item">
			<a class="nav-link disabled" href="#">Disabled</a>
		</li>
	</ul>
	<hr class="d-sm-none" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
	<asp:GridView runat="server" ID="grid_LopHoc" CssClass="table table-bordered table-striped" AutoGenerateColumns="false">
		<Columns>
			<asp:BoundField DataField="STT" HeaderText="Số thứ tự" />
			<asp:BoundField DataField="Lop" HeaderText="Tên lớp"/>
			<asp:BoundField DataField="ThaoTac" HeaderText="Thao tác" />
		</Columns>
	</asp:GridView>
</asp:Content>

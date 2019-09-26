<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="QuanLySinhVien.Pages.Student" %>

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
	Đây là nội dung
    <asp:DataList ID="tbl_SinhVien" runat="server" RepeatColumns="5" Width="100%">
		<HeaderTemplate>
			<table>
				<tr>
					<th>STT</th>
					<th>MSSV</th>
					<th>Họ và tên</th>
					<th>Ngày sinh</th>
					<th>Chức năng</th>
				</tr>
		</HeaderTemplate>
		<ItemTemplate>
			<tr>
				<td><%#DataBinder.Eval(Container.DataItem, "STT") %></td>
				<td><%#DataBinder.Eval(Container.DataItem, "MSSV") %></td>
				<td><%#DataBinder.Eval(Container.DataItem, "HoVaTen") %></td>
				<td><%#DataBinder.Eval(Container.DataItem, "NgaySinh") %></td>
				<td><%#DataBinder.Eval(Container.DataItem, "ChucNang") %></td>
			</tr>
		</ItemTemplate>
		<FooterTemplate>
			</table>
		</FooterTemplate>
	</asp:DataList>
</asp:Content>

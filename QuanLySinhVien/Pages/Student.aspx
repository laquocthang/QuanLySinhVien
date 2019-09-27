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
	<%--	<asp:DataList ID="tbl_SinhVien" CellPadding="5" CellSpacing="5" RepeatDirection="Vertical" RepeatLayout="Table" RepeatColumns="6" Width="100%" CssClass="table" runat="server">
		<HeaderTemplate>
			<th>STT</th>
			<th>MSSV</th>
			<th>Họ và tên đệm</th>
			<th>Tên</th>
			<th>Ngày sinh</th>
			<th>Thao tác</th>
		</HeaderTemplate>
		<ItemTemplate>
			<td><%#DataBinder.Eval(Container.DataItem, "STT") %></td>
			<td><%#DataBinder.Eval(Container.DataItem, "MSSV") %></td>
			<td><%#DataBinder.Eval(Container.DataItem, "Ho") %></td>
			<td><%#DataBinder.Eval(Container.DataItem,"Ten") %></td>
			<td><%#DataBinder.Eval(Container.DataItem, "NgaySinh") %></td>
			<td><%#DataBinder.Eval(Container.DataItem, "ThaoTac") %></td>
		</ItemTemplate>
	</asp:DataList>--%>
	<asp:GridView ID="grid_SinhVien" runat="server" AllowSorting="True" AutoGenerateColumns="false" CssClass="table table-bordered table-striped" OnSorting="grid_SinhVien_Sorting" OnRowCreated="grid_SinhVien_RowCreated">
		<Columns>
			<asp:BoundField DataField="STT" HeaderText="Số thứ tự" SortExpression="STT" />
			<asp:BoundField DataField="MSSV" HeaderText="Mã số sinh viên" SortExpression="MSSV" />
			<asp:BoundField DataField="Ho" HeaderText="Họ và tên đệm" SortExpression="Ho" />
			<asp:BoundField DataField="Ten" HeaderText="Tên" SortExpression="Ten" />
			<asp:BoundField DataField="NgaySinh" HeaderText="Ngày sinh" />
			<asp:BoundField DataField="Lop" HeaderText="Lớp" />
			<asp:BoundField DataField="GioiTinh" HeaderText="Giới tính" />
			<asp:BoundField DataField="ThaoTac" HeaderText="Chức năng" />
		</Columns>
	</asp:GridView>
</asp:Content>

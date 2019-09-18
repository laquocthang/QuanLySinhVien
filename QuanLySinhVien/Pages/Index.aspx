<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="QuanLySinhVien.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%--<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
</asp:Content>--%>
<asp:Content ID="content_main" ContentPlaceHolderID="Content" runat="server">
	<div class="container">
		<h4 class="mb-3">Trường Đại học Đà Lạt</h4>
		<div id="myCarousel" class="carousel slide border" data-ride="carousel">
			<div class="carousel-inner">
				<%for (int i = 1; i <= 10; i++)
					{%>
				<div class="carousel-item <%=i==1?"active":""%>">
					<%string fileName = string.Format("../Images/dhdalat/dhdalat{0}.jpg", i);%>
					<img class="d-block w-100" src="<%=fileName%>" alt="" />
				</div>
				<%}%>
			</div>
			<a class="carousel-control-prev" href="#myCarousel" role="button" data-slide="prev">
				<span class="carousel-control-prev-icon" aria-hidden="true"></span>
				<span class="sr-only">Previous</span>
			</a>
			<a class="carousel-control-next" href="#myCarousel" role="button" data-slide="next">
				<span class="carousel-control-next-icon" aria-hidden="true"></span>
				<span class="sr-only">Next</span>
			</a>
		</div>
	</div>
</asp:Content>

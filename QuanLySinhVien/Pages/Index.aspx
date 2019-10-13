<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="QuanLySinhVien.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%--<asp:Content ID="content_nav" ContentPlaceHolderID="Navigation" runat="server">
</asp:Content>--%>
<asp:Content ID="content_main" ContentPlaceHolderID="Content" runat="server">
	<div class="container" style="text-align: center; display: block; margin: 0 auto;">
		<h4 class="mb-3">Trường Đại học Đà Lạt</h4>
		<p>Trường Đại học Đà Lạt là một trường công lập được thành lập theo Quyết định số 426/TTg ngày 27 tháng 10 năm 1976 của Thủ tướng Chính phủ nước Cộng hòa xã hội chủ nghĩa Việt Nam trên cơ sở Viện Đại học Đà Lạt, một trường tư thục thành lập trước 1975 và bắt đầu đào tạo đại học từ niên khóa 1958 – 1959.</p>
		<div id="myCarousel" class="carousel slide border" data-ride="carousel">
			<ol class="carousel-indicators">
				<%for (int i = 0; i < 10; i++)
					{ %>
				<li data-target="#myCarousel" data-slider-to="<%=i%>" class="<%=i == 0 ? "active" : ""%>"></li>
				<%}%>
			</ol>
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

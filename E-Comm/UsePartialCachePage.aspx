<%@ Page Title="" Language="C#" MasterPageFile="~/Common.Master" AutoEventWireup="true" CodeBehind="UsePartialCachePage.aspx.cs" Inherits="E_Comm.UsePartialCachePage" %>
<%@ Register src="PartialCachingDemo.ascx" tagname="PartialCachingDemo" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:PartialCachingDemo ID="PartialCachingDemo1" runat="server" />

</asp:Content>

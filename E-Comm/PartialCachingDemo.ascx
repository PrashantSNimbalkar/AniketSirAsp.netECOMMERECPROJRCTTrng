<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PartialCachingDemo.ascx.cs" Inherits="E_Comm.PartialCachingDemo" %>
<%@ OutputCache Duration="20" VaryByControl="DropDownList1" VaryByParam="none" %>
<style type="text/css">
    .auto-style1 {
        width: 127px;
    }
</style>
<div class="auto-style1">
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
</div>
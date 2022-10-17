<%@ Page Language="C#" MasterPageFile="~/Common.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="E_Comm.Home" %>
<%--<%@ Register TagPrefix="cc" Namespace="E_Comm.App_Code" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 229px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <asp:Label ID="lblVisitCount" runat="server"></asp:Label>
        </div>
        <div>

            <br />
            <table class="auto-style1">
                <tr>
                    <td aria-orientation="horizontal" class="auto-style2">
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/canon-camera.jpg" />
                        <asp:Label ID="Label1" runat="server" Text="Canon Camera 34500.00"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/hp-printer.jpg" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/lenovo-laptop.jpg" />
                    </td>
                    <td>
                        <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/canon-camera.jpg" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
       
</asp:Content>

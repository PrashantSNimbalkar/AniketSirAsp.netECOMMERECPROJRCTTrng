<%@Page Language="C#" MasterPageFile="~/Common.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="E_Comm.ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .fontColor{
            color:red;
            font-size:20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
            <div>

            &nbsp;<table class="auto-style1">
                <tr>
                    <td aria-orientation="horizontal" class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="15pt" Text="Your Cart Items"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                        </asp:CheckBoxList>
                        <br />
                        <br />
                        <asp:Label ID="lblMsg" runat="server" CssClass="fontColor"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnDeleteProducts" runat="server" Text="Delete Products " OnClick="btnDeleteProducts_Click" />
                    </td>
                </tr>
            </table>

        </div>

</asp:Content>
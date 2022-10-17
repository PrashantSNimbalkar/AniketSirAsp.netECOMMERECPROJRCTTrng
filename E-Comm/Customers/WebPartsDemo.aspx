<%@Page Language="C#" AutoEventWireup="true" CodeBehind="WebPartsDemo.aspx.cs" Inherits="E_Comm.Customers.WebPartsDemo" %>

<%@ Register Src="~/Customers/Calender.ascx" TagPrefix="uc1" TagName="Calender" %>
<%@ Register Src="~/Customers/Calculation.ascx" TagPrefix="uc1" TagName="Calculation" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="table">
                <tr>
                    <td>
                        <asp:WebPartManager ID="WebPartManager1" runat="server">
                        </asp:WebPartManager>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:LinkButton ID="lbCatalog" runat="server" OnClick="lbCatalog_Click">Catalog Mode</asp:LinkButton>
&nbsp;|
                        <asp:LinkButton ID="lbEditor" runat="server" OnClick="lbEditor_Click">Editor Mode</asp:LinkButton>
&nbsp;|
                        <asp:LinkButton ID="lbDesign" runat="server" OnClick="lbDesign_Click">Design Mode</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:EditorZone ID="EditorZone1" runat="server">
                           <ZoneTemplate>
                               <asp:AppearanceEditorPart ID="AppearanceEditorPart1" runat="server" />
                               <asp:LayoutEditorPart ID="LayoutEditorPart1" runat="server" />
                           </ZoneTemplate>
                        </asp:EditorZone>
                    </td>
                    <td>
                        <asp:CatalogZone ID="CatalogZone1" runat="server">
                            <ZoneTemplate>
                                <asp:PageCatalogPart ID="PageCatalogPart1" runat="server" />
                                <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server">
                                    <WebPartsTemplate>
                                        <uc1:Calender runat="server" id="Calender" title="Calender" />
                                        <uc1:Calculation runat="server" id="Calculation" title="Calculation" />
                                    </WebPartsTemplate>
                                </asp:DeclarativeCatalogPart>
                            </ZoneTemplate>
                        </asp:CatalogZone>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:WebPartZone ID="WebPartZone1" runat="server">
                        </asp:WebPartZone>
                    </td>
                    <td>
                        <asp:WebPartZone ID="WebPartZone2" runat="server">
                        </asp:WebPartZone>
                    </td>
                    <td>
                        <asp:WebPartZone ID="WebPartZone3" runat="server">
                        </asp:WebPartZone>
                    </td>
                </tr>
            </table>

        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.5/dist/umd/popper.min.js" integrity="sha384-Xe+8cL9oJa6tN/veChSP7q+mnSPaj5Bcu9mPX5F5xIGE0DVittaqT5lorf0EI7Vk" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.min.js" integrity="sha384-kjU+l4N0Yf4ZOJErLsIcvOU2qSb74wXpOhqTvwVx3OElZRweTnQ6d31fXEoRD1Jy" crossorigin="anonymous"></script>
</body>
</html>

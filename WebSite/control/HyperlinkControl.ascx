﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HyperlinkControl.ascx.cs" Inherits="HyperlinkControl" %>
<table cellpadding="0" cellspacing="0" style="height: 200px; width: 131px;">
    <tr>
        <td style="height: 21px; width: 125px;" align="center">
            <asp:DataList ID="DataList1" runat="server" Width="131px" Height="168px">
                <ItemTemplate>
                    &nbsp;
                    <div style="text-align: center">
                        <table style="width: 100%">
                            <tr>
                                <td align="center" style="width: 100px">
                                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="9pt" ForeColor="Red" NavigateUrl='<%#                                        DataBinder.Eval(Container.DataItem, "LinkAddress") %>' Font-Underline="False" ImageUrl='<%#                                        DataBinder.Eval(Container.DataItem, "LinkImage") %>'>[HyperLink1]</asp:HyperLink></td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:DataList></td>
    </tr>
</table>
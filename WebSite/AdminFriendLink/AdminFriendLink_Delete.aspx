﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminFriendLink_Delete.aspx.cs" Inherits="AdminFriendLink_Delete" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="background-image: url(../image/后台页.jpg); height: 340px; width: 534px;">
        <tr>
            <td colspan="1" style="width: 100px">
            </td>
            <td colspan="4" style="text-align: center; width: 411px;">
            </td>
            <td colspan="1" style="width: 100px">
            </td>
        </tr>
        <tr>
            <td colspan="1" style="height: 7px; text-align: left; width: 100px;">
            </td>
            <td align="center" colspan="4" style="height: 7px; text-align: center; width: 411px;">
                <span style="font-size: 9pt">删除友情链接&nbsp;</span></td>
            <td colspan="1" style="height: 7px; text-align: left; width: 100px;">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 214px; text-align: center; width: 100px;">
            </td>
            <td align="left" colspan="4" style="height: 214px; text-align: center; width: 411px;" valign="top">
                <table>
                    <tr>
                        <td style="height: 37px; width: 57px;">
                        </td>
                        <td style="height: 37px; width: 82px;">
                            <span style="font-size: 9pt">链接编号</span></td>
                        <td colspan="2" style="font-size: 12pt; height: 37px">
                            <asp:TextBox ID="TxtId" runat="server" ReadOnly="True" Width="166px"></asp:TextBox></td>
                        <td colspan="1" style="font-size: 12pt; height: 37px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 30px; width: 57px;">
                        </td>
                        <td style="height: 30px; width: 82px;">
                            <span style="font-size: 9pt">上传时间</span></td>
                        <td colspan="2" style="font-size: 12pt; height: 30px">
                            <asp:TextBox ID="TxtTime" runat="server"  ReadOnly="True"
                                         Width="166px"></asp:TextBox></td>
                        <td colspan="1" style="font-size: 12pt; height: 30px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 33px; width: 57px;">
                        </td>
                        <td style="height: 33px; width: 82px;">
                            <span style="font-size: 9pt">链接地址</span></td>
                        <td colspan="2" style="height: 33px">
                            <asp:TextBox ID="txtAddress" runat="server" Font-Size="9pt" ReadOnly="True" Width="166px"></asp:TextBox></td>
                        <td colspan="1" style="height: 33px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 55px; width: 57px;">
                        </td>
                        <td style="height: 55px; width: 82px;">
                            <span style="font-size: 9pt">链接图片</span></td>
                        <td colspan="2" style="height: 55px">
                            <asp:Image ID="imgPhoto" runat="server" Height="68px" Width="175px" /></td>
                        <td colspan="1" style="height: 55px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 49px; width: 57px;">
                        </td>
                        <td style="height: 49px; width: 82px;">
                        </td>
                        <td align="right" style="height: 49px; width: 78px;">
                            <asp:Button ID="btnDelete" runat="server" Font-Size="9pt" OnClick="btnupdate_Click"
                                        Text="删除" />
                        </td>
                        <td align="left" style="height: 49px; width: 45px;">
                            <asp:Button ID="Button1" runat="server" CausesValidation="False" Font-Size="9pt"
                                        OnClick="Button1_Click" Text="返回" />
                        </td>
                        <td align="left" style="height: 49px; width: 80px;">
                        </td>
                    </tr>
                </table>
                &nbsp;&nbsp;
            </td>
            <td align="left" colspan="1" style="height: 214px; text-align: center; width: 100px;">
            </td>
        </tr>
    </table>
</asp:Content>
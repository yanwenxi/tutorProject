﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminLeaveWord_Reply.aspx.cs" Inherits="AdminLeaveWord_Add" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table style="background-image: url(../image/LeaveWordB.jpg); height: 394px; width: 90%;">
        <tr>
            <td colspan="2" style="background-image: url(~/image/留言本1.jpg); height: 79px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/image/留言本1.jpg" /></td>
        </tr>
        <tr>
            <td colspan="2" style="height: 41px; text-align: center">
                <span style="font-size: 9pt">删除留言信息</span></td>
        </tr>
        <tr>
            <td style="height: 26px; text-align: center; width: 253px;">
                <span style="font-size: 9pt">留言主题</span></td>
            <td style="height: 26px; text-align: center; width: 109px;">
                <asp:Label ID="LblTitle" runat="server" Font-Size="9pt" Width="162px"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 24px; text-align: center; width: 253px;">
                <span style="font-size: 9pt">&nbsp;留言时间</span></td>
            <td style="height: 24px; text-align: center; width: 109px;">
                <asp:Label ID="LblTime" runat="server" Font-Size="9pt" Width="166px"　onClick="Fcalendar(this)"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 28px; text-align: center; width: 253px;">
                <span style="font-size: 9pt">&nbsp;留言人</span></td>
            <td style="height: 28px; text-align: center; width: 109px;">
                <asp:Label ID="LblPerson" runat="server" Font-Size="9pt" Width="164px"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 43px; text-align: center; width: 253px;">
                <span style="font-size: 9pt">&nbsp; 留言内容</span></td>
            <td style="height: 43px; text-align: center; width: 109px;">
                <asp:Label ID="LblContent" runat="server" Font-Size="9pt" Height="67px" Width="166px"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 51px; text-align: center; width: 253px;">
                <span style="font-size: 9pt">&nbsp; 回复留言</span></td>
            <td style="height: 51px; text-align: center; width: 109px;">
                <asp:TextBox ID="TxtReply" runat="server" Font-Size="9pt" Height="63px" TextMode="MultiLine"
                             Width="159px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 40px; width: 253px;">
            </td>
            <td style="height: 40px; width: 109px;">
                <asp:Button ID="Button1" runat="server" Text="删除留言" Width="81px" OnClick="Button1_Click" />
                <asp:LinkButton ID="LinBtnReturn" runat="server" Font-Size="9pt" OnClick="LinBtnReturn_Click">返  回</asp:LinkButton></td>
        </tr>
    </table>
</asp:Content>
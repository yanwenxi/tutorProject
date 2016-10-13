<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminLeaveWord.aspx.cs" Inherits="AdminLeaveWord1" Title="Untitled Page" StylesheetTheme="MRSOFTASPNET" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="background-image: url(image/LeaveWordB.jpg); height: 373px; width: 90%;">
            <tr>
                <td style="background-image: url(image/留言本1.jpg); height: 80px; width: 100px;">
                    <asp:Image ID="ImgT" runat="server" ImageUrl="~/image/留言本1.jpg" /></td>
            </tr>
            <tr>
                <td style="height: 250px; width: 100px;" align="right" valign="top">
                    <asp:GridView ID="GvLeaveWord" runat="server" AllowPaging="True" AutoGenerateColumns="False" Font-Size="9pt" OnPageIndexChanging="GvLeaveWord_PageIndexChanging"
                                  OnRowDataBound="GvLeaveWord_RowDataBound" Width="497px" SkinID="gvSkin" PageSize="8">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="留言编号" />
                            <asp:BoundField DataField="Title" HeaderText="留言主题" />
                            <asp:BoundField DataField="RevertContent" HeaderText="回复状态" />
                            <asp:HyperLinkField HeaderImageUrl="~/image/leaveWordReply.jpg" Text="回复/修改回复" DataNavigateUrlFields="id" DataNavigateUrlFormatString="AdminLeaveWord_Update.aspx?id={0}" />
                            <asp:HyperLinkField HeaderImageUrl="~/image/shanchu.jpg" Text="删除" DataNavigateUrlFields="id" DataNavigateUrlFormatString="AdminLeaveWord_Delete.aspx?id={0}" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
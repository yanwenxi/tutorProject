<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminDownloadAdd.aspx.cs" Inherits="AdminTools_AdminDownloadAdd" Title="Untitled Page" StylesheetTheme="MRSOFTASPNET"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="background-image: url(../image/后台页.jpg); height: 153px; width: 534px;">
        <tr>
            <td colspan="1" style="height: 14px; width: 100px;">
            </td>
            <td colspan="4" style="height: 14px; text-align: center; width: 411px;">
            </td>
            <td colspan="1" style="height: 14px; width: 100px;">
            </td>
        </tr>
        <tr>
            <td colspan="1" style="height: 31px; text-align: left; width: 100px;">
            </td>
            <td align="center" colspan="4" style="height: 31px; text-align: center; width: 411px;">
                <span style="font-size: 9pt">添加下载工具</span></td>
            <td colspan="1" style="height: 31px; text-align: left; width: 100px;">
            </td>
        </tr>
        <tr>
            <td align="left" colspan="1" style="height: 258px; text-align: center; width: 100px;">
            </td>
            <td align="left" colspan="4" style="height: 258px; text-align: center; width: 411px;">
                <table>
                    <tr>
                        <td style="height: 10px; width: 57px;">
                        </td>
                        <td style="height: 10px; width: 82px;">
                            <span style="font-size: 9pt">上传工具</span></td>
                        <td colspan="2" style="font-size: 12pt; height: 10px">
                            <table id="Tab_UpDownFile" runat="server" cellpadding="0" cellspacing="0" enableviewstate="true">
                                <tr>
                                    <td style="height: 30px; width: 100px;">
                                        <asp:FileUpload ID="FileUpload1" runat="server" Height="20px" Width="227px" /></td>
                                </tr>
                            </table>
                        </td>
                        <td colspan="1" style="font-size: 12pt; height: 10px">
                            <span style="font-size: 9pt">&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True"
                                                                          ForeColor="Red" Text="提示：上传的格式为.rar格式的压缩包"></asp:Label></span></td>
                    </tr>
                    <tr>
                        <td style="height: 17px; width: 57px;">
                        </td>
                        <td style="height: 17px; width: 82px;">
                            <span style="font-size: 9pt"></span>
                        </td>
                        <td colspan="2" style="height: 17px">
                        </td>
                        <td colspan="1" style="height: 17px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 29px; width: 57px;">
                        </td>
                        <td style="height: 29px; width: 82px;">
                            <span style="font-size: 9pt"></span>
                        </td>
                        <td colspan="2" style="height: 29px">
                            <asp:Label ID="LblSoft" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                            <asp:Label ID="LblMessage" runat="server" Font-Bold="True" ForeColor="#FF0033" Width="116px"></asp:Label></td>
                        <td colspan="1" style="height: 29px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 72px; width: 57px;">
                        </td>
                        <td style="height: 72px; width: 82px;">
                        </td>
                        <td colspan="2" style="height: 72px">
                        </td>
                        <td colspan="1" style="height: 72px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 23px; width: 57px;">
                        </td>
                        <td style="height: 23px; width: 82px;">
                        </td>
                        <td align="right" style="height: 23px; text-align: center;" colspan="2">
                            <asp:Button ID="btnAdd" runat="server" Font-Size="9pt" OnClick="btnAdd_Click"
                                        Text="添 加" SkinID="btnSkin" Width="64px" />
                            &nbsp;</td>
                        <td align="left" style="height: 23px; width: 80px;">
                        </td>
                    </tr>
                </table>
                &nbsp;&nbsp;
            </td>
            <td align="left" colspan="1" style="height: 258px; text-align: center; width: 100px;">
            </td>
        </tr>
        <tr>
            <td style="height: 20px; width: 100px;">
            </td>
            <td colspan="4" style="height: 20px; width: 55px;">
            </td>
            <td style="height: 20px; width: 100px;">
            </td>
        </tr>
    </table>
</asp:Content>
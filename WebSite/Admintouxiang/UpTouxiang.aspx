<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="UpTouxiang.aspx.cs" Inherits="Admintouxiang_Default" Title="Untitled Page" StylesheetTheme="MRSOFTASPNET" %>
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
                <span style="font-size: 9pt">添加新头像</span></td>
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
                        <td style="height: 10px; width: 112px;">
                        </td>
                        <td colspan="2" style="font-size: 12pt; height: 10px">
                            <span style="font-size: 9pt"><strong><span style="color: #ff6666">注意：只能上传"*.gif" 、"*.GIF"
                                                                     、"*.bmp"、"*.BMP"、<br />
                                                                     "*.jpg"和"*.JPG"格式的图片 </span></strong>&nbsp;</span></td>
                        <td colspan="1" style="font-size: 12pt; height: 10px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 10px; width: 57px;">
                        </td>
                        <td style="height: 10px; width: 112px;">
                            <span style="font-size: 9pt">上传新头像</span></td>
                        <td colspan="2" style="font-size: 12pt; height: 10px">
                            <table id="Tab_UpDownFile" runat="server" cellpadding="0" cellspacing="0" enableviewstate="true">
                                <tr>
                                    <td style="height: 30px; width: 100px;">
                                        <asp:FileUpload ID="FileUpload1" runat="server" Height="20px" Width="227px" /></td>
                                </tr>
                            </table>
                        </td>
                        <td colspan="1" style="font-size: 12pt; height: 10px">
                            <span style="font-size: 9pt"><strong><span style="color: #ff6666"></span></strong></span>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 17px; width: 57px;">
                        </td>
                        <td style="height: 17px; width: 112px;">
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
                        <td style="height: 29px; width: 112px;">
                            <span style="font-size: 9pt"></span>
                        </td>
                        <td colspan="2" style="height: 29px">
                            <asp:Label ID="LblImage" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                            <asp:Label ID="LblMessage" runat="server" Font-Bold="True" ForeColor="#FF0033" Width="116px"></asp:Label></td>
                        <td colspan="1" style="height: 29px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 58px; width: 57px;">
                        </td>
                        <td style="height: 58px; width: 112px;">
                        </td>
                        <td colspan="2" style="height: 58px">
                            <asp:Button ID="btnAdd" runat="server" Font-Size="9pt" OnClick="btnAdd_Click" SkinID="btnSkin"
                                        Text="添 加" Width="64px" /></td>
                        <td colspan="1" style="height: 58px">
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 23px; width: 57px;">
                        </td>
                        <td style="height: 23px; width: 112px;">
                        </td>
                        <td align="right" colspan="2" style="height: 23px; text-align: center">
                            &nbsp;&nbsp;</td>
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
            <td style="height: 12px; width: 100px;">
            </td>
            <td colspan="4" style="height: 12px; width: 55px;">
            </td>
            <td style="height: 12px; width: 100px;">
            </td>
        </tr>
    </table>
</asp:Content>
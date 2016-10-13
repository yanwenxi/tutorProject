<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminFriendLink_Update.aspx.cs" Inherits="AdminFriendLink_Update" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="0" cellspacing="0" style="height: 427px; width: 578px;">
        <tr>
            <td style="text-align: center; vertical-align: top; width: 100px;">
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
                            <span style="font-size: 9pt">友情链接修改</span></td>
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
                                        <span style="font-size: 9pt">上传时间</span></td>
                                    <td colspan="2" style="font-size: 12pt; height: 10px">
                                        <asp:TextBox ID="TxtTime" runat="server" Width="166px" ></asp:TextBox></td>
                                    <td colspan="1" style="font-size: 12pt; height: 10px">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtTime"
                                                                    Display="Dynamic" ErrorMessage="不能为空" Font-Size="9pt"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtTime"
                                                              Display="Dynamic" ErrorMessage="格式不正确，格式应为2008-08-08" Font-Size="9pt" Height="39px"
                                                              Operator="DataTypeCheck" Type="Date" Width="72px"></asp:CompareValidator></td>
                                </tr>
                                <tr>
                                    <td style="height: 17px; width: 57px;">
                                    </td>
                                    <td style="height: 17px; width: 82px;">
                                        <span style="font-size: 9pt">链接地址</span></td>
                                    <td colspan="2" style="height: 17px">
                                        <asp:TextBox ID="txtAddress" runat="server" Font-Size="9pt" Width="166px">http://www.mrbccd.com</asp:TextBox></td>
                                    <td colspan="1" style="height: 17px">
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAddress"
                                                                        ErrorMessage="格式不正确" Font-Size="9pt" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"></asp:RegularExpressionValidator></td>
                                </tr>
                                <tr>
                                    <td style="height: 29px; width: 57px;">
                                    </td>
                                    <td style="height: 29px; width: 82px;">
                                        <span style="font-size: 9pt">链接图片</span></td>
                                    <td colspan="2" style="height: 29px">
                                        <asp:DropDownList ID="ddlPhoto" runat="server" AutoPostBack="True" Font-Size="9pt"
                                                          OnSelectedIndexChanged="ddlPhoto_SelectedIndexChanged" Width="165px">
                                        </asp:DropDownList></td>
                                    <td colspan="1" style="height: 29px">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 72px; width: 57px;">
                                    </td>
                                    <td style="height: 72px; width: 82px;">
                                    </td>
                                    <td colspan="2" style="height: 72px">
                                        <asp:Image ID="imgPhoto" runat="server" Height="68px" Width="175px" /></td>
                                    <td colspan="1" style="height: 72px">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 23px; width: 57px;">
                                    </td>
                                    <td style="height: 23px; width: 82px;">
                                    </td>
                                    <td align="right" style="height: 23px; width: 65px;">
                                        <asp:Button ID="btnupdate" runat="server" Font-Size="9pt" OnClick="btnupdate_Click"
                                                    Text="修改" />
                                    </td>
                                    <td align="left" style="height: 23px; width: 45px;">
                                        <asp:Button ID="Button1" runat="server" CausesValidation="False" Font-Size="9pt"
                                                    OnClick="Button1_Click" Text="返回" />
                                    </td>
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
            </td>
        </tr>
    </table>
</asp:Content>
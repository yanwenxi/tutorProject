<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminLeibie_ADD.aspx.cs" Inherits="AdminLeibie_AdminLeibie_ADD" Title="Untitled Page" StylesheetTheme="MRSOFTASPNET" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
        <table style="background-image: url(../image/后台页.jpg); height: 339px; width: 90%;">
            <tr>
                <td colspan="3" style="height: 33px; text-align: center;">
                    <span style="font-size: 9pt">&nbsp;&nbsp; 添加产品类别</span></td>
            </tr>
            <tr>
                <td style="height: 12px; width: 154px;">
                    <span style="font-size: 9pt"></span>
                </td>
                <td style="height: 12px; width: 100px;">
                    &nbsp;</td>
                <td style="height: 12px; width: 100px;">
                </td>
            </tr>
            <tr>
                <td style="height: 25px; width: 154px;">
                    <span style="font-size: 9pt">类别名称：</span></td>
                <td align="left" style="font-size: 12pt; height: 25px; width: 100px;">
                    <asp:TextBox ID="TxtName" runat="server" Width="203px"></asp:TextBox>
                </td>
                <td align="left" style="font-size: 12pt; height: 25px; width: 100px;">
                </td>
            </tr>
            <tr style="font-size: 12pt">
                <td style="height: 32px; width: 154px;">
                    <span></span>
                </td>
                <td align="left" style="height: 32px; width: 100px;">
                </td>
                <td align="left" style="height: 32px; width: 100px;">
                </td>
            </tr>
            <tr style="font-size: 12pt">
                <td style="width: 154px;">
                    <span style="font-size: 9pt">添加时间：</span></td>
                <td style="width: 100px;">
                    <asp:TextBox ID="TxtTime" runat="server" Width="204px"></asp:TextBox>
                </td>
                <td style="width: 100px">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtTime"
                                          Display="Dynamic" ErrorMessage="时间格式不对，格式应该为2008-08-08" Font-Size="9pt" Operator="DataTypeCheck"
                                          Type="Date"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td align="center" colspan="3" style="height: 24px">
                    <asp:Button ID="BtnAdd" runat="server" Height="25px" OnClick="BtnAdd_Click" Text="添　加"
                                Width="52px" SkinID="btnSkin" />&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Button ID="BtnCZ" runat="server" Text="重 置" OnClick="BtnCZ_Click" Height="24px" SkinID="btnSkin" Width="52px" CausesValidation="False" /></td>
            </tr>
            <tr>
                <td align="center" colspan="3" style="height: 24px">
                </td>
            </tr>
        </table>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
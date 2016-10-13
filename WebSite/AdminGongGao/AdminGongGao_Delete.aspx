<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminGongGao_Delete.aspx.cs" Inherits="AdminDelete" Title="Untitled Page" StylesheetTheme="MRSOFTASPNET" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<table align="center" cellpadding="0" cellspacing="0" style="background-image: url(../image/后台页.jpg); font-size: 9pt; height: 334px; width: 529px;">
              <tr>
                  <td align="center" colspan="3" style="height: 27px; text-align: center">
                      公告详细信息删除</td>
              </tr>
              <tr>
                  <td align="left" colspan="3" style="text-align: center">
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<div
                                                                                                             style="text-align: center">
                                                                                                             <table style="width: 98%">
                                                                                                                 <tr>
                                                                                                                     <td style="text-align: right; width: 121px;">
                                                                                                                         公告编号：</td>
                                                                                                                     <td style="text-align: center; width: 100px;">
                                                                                                                         <asp:TextBox ID="Txtid" runat="server" Width="205px"></asp:TextBox></td>
                                                                                                                     <td style="text-align: center; width: 100px;">
                                                                                                                     </td>
                                                                                                                 </tr>
                                                                                                                 <tr>
                                                                                                                     <td style="text-align: right; width: 121px;">
                                                                                                                         公告标题：</td>
                                                                                                                     <td style="text-align: center; width: 100px;">
                                                                                                                         <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="205px"></asp:TextBox></td>
                                                                                                                     <td style="text-align: center; width: 100px;">
                                                                                                                     </td>
                                                                                                                 </tr>
                                                                                                                 <tr>
                                                                                                                     <td style="text-align: right; width: 121px;">
                                                                                                                         公告内容：</td>
                                                                                                                     <td style="text-align: center; width: 100px;">
                                                                                                                         <asp:TextBox ID="TextBox2" runat="server" Height="92px" TextMode="MultiLine" Width="204px"></asp:TextBox></td>
                                                                                                                     <td style="text-align: center; width: 100px;">
                                                                                                                     </td>
                                                                                                                 </tr>
                                                                                                                 <tr>
                                                                                                                     <td style="text-align: right; width: 121px;">
                                                                                                                         发表时间：</td>
                                                                                                                     <td style="text-align: center; width: 100px;">
                                                                                                                         <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="202px"></asp:TextBox></td>
                                                                                                                     <td style="text-align: center; width: 100px;">
                                                                                                                     </td>
                                                                                                                 </tr>
                                                                                                                 <tr>
                                                                                                                     <td colspan="3" style="text-align: center">
                                                                                                                         <asp:Button ID="Button2" runat="server" Height="22px" OnClick="Button2_Click" Text="删除"
                                                                                                                                     Width="54px" SkinID="btnSkin" />&nbsp;
                                                                                                                         <asp:LinkButton ID="linBtnReturn" runat="server" OnClick="linBtnReturn_Click">返 回</asp:LinkButton></td>
                                                                                                                 </tr>
                                                                                                             </table>
                                                                                                         </div>
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                  </td>
              </tr>
          </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
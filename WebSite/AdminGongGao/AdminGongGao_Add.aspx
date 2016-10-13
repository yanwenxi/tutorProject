<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminGongGao_Add.aspx.cs" Inherits="AdminGongGao_Add" Title="Untitled Page" StylesheetTheme="MRSOFTASPNET"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    &nbsp;<table align="center" cellpadding="0" cellspacing="0" style="background-image: url(../image/后台页.jpg); font-size: 9pt; height: 334px; width: 529px;">
              <tr>
                  <td align="center" colspan="3" style="height: 24px; text-align: center">
                      添加公告</td>
              </tr>
              <tr>
                  <td align="left" colspan="3" style="height: 273px; text-align: center;">
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<div style="text-align: center">
                                                                                               <table style="width: 100%">
                                                                                                   <tr>
                                                                                                       <td style="height: 26px; text-align: right; width: 136px;">
                                                                                                           公告编号：</td>
                                                                                                       <td style="height: 26px; text-align: center; width: 105px;">
                                                                                                           <asp:TextBox ID="Txtid" runat="server" Width="201px"></asp:TextBox></td>
                                                                                                       <td style="height: 26px; text-align: left; width: 100px;">
                                                                                                           <asp:Button ID="BtnCheck" runat="server" Text="审核编号" OnClick="BtnCheck_Click" SkinID="btnSkin" 
                                                                                                                       Width="79px" Height="29px" /></td>
                                                                                                   </tr>
                                                                                                   <tr>
                                                                                                       <td style="height: 26px; text-align: right; width: 136px;">
                                                                                                           公告标题：</td>
                                                                                                       <td style="height: 26px; text-align: center; width: 105px;">
                                                                                                           <asp:TextBox ID="TextBox1" runat="server" Width="201px"></asp:TextBox></td>
                                                                                                       <td style="height: 26px; width: 100px;">
                                                                                                       </td>
                                                                                                   </tr>
                                                                                                   <tr>
                                                                                                       <td style="text-align: right; width: 136px;">
                                                                                                           公告内容：</td>
                                                                                                       <td style="text-align: center; width: 105px;">
                                                                                                           <asp:TextBox ID="TextBox2" runat="server" Height="92px" TextMode="MultiLine" Width="201px"></asp:TextBox></td>
                                                                                                       <td style="width: 100px">
                                                                                                       </td>
                                                                                                   </tr>
                                                                                                   <tr>
                                                                                                       <td style="text-align: right; width: 136px;">
                                                                                                       </td>
                                                                                                       <td style="text-align: center; width: 105px;">
                                                                                                       </td>
                                                                                                       <td style="width: 100px">
                                                                                                       </td>
                                                                                                   </tr>
                                                                                                   <tr>
                                                                                                       <td colspan="3" style="height: 27px">
                                                                                                           <asp:Button ID="Button2" runat="server" Height="22px"  Text="添加"
                                                                                                                       Width="64px" OnClick="Button2_Click" SkinID="btnSkin" />
                                                                                                       </td>
                                                                                                   </tr>
                                                                                               </table>
                                                                                           </div>
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                  </td>
              </tr>
          </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
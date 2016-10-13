<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminNew_Update.aspx.cs" Inherits="AdminNew_Update" Title="Untitled Page" StylesheetTheme="MRSOFTASPNET" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    &nbsp;<table align="center" cellpadding="0" cellspacing="0" style="background-image: url(../image/后台页.jpg); font-size: 9pt; height: 334px; width: 529px;">
              <tr>
                  <td align="center" colspan="3" style="height: 24px; text-align: center">
                      新闻信息修改</td>
              </tr>
              <tr>
                  <td align="left" colspan="3" style="height: 295px; text-align: center;">
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<div style="text-align: center">
                                                                                       <table style="height: 118px; width: 92%;">
                                                                                           <tr>
                                                                                               <td style="width: 100px">
                                                                                                   新闻编号：</td>
                                                                                               <td style="width: 100px">
                                                                                                   <asp:TextBox ID="Txtid" runat="server" Width="199px"></asp:TextBox></td>
                                                                                               <td style="width: 100px">
                                                                                                   <asp:Button ID="BtnCheck" runat="server" Text="审核编号" OnClick="BtnCheck_Click" SkinID="btnSkin" /></td>
                                                                                           </tr>
                                                                                           <tr>
                                                                                               <td style="width: 100px">
                                                                                                   新闻标题：</td>
                                                                                               <td style="width: 100px">
                                                                                                   <asp:TextBox ID="TextBox2" runat="server" Width="199px"></asp:TextBox></td>
                                                                                               <td style="width: 100px">
                                                                                               </td>
                                                                                           </tr>
                                                                                           <tr>
                                                                                               <td style="width: 100px">
                                                                                                   新闻内容：</td>
                                                                                               <td style="width: 100px">
                                                                                                   <asp:TextBox ID="TxtContent" runat="server" Height="92px" TextMode="MultiLine" Width="203px"></asp:TextBox></td>
                                                                                               <td style="width: 100px">
                                                                                               </td>
                                                                                           </tr>
                                                                                           <tr>
                                                                                               <td style="height: 17px; width: 100px;">
                                                                                                   发布时间：</td>
                                                                                               <td style="height: 17px; width: 100px;">
                                                                                                   <asp:TextBox ID="TxtTime" runat="server"  Width="199px"></asp:TextBox></td>
                                                                                               <td style="height: 17px; width: 100px;">
                                                                                                   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtTime"
                                                                                                                         ErrorMessage="时间格式不正确，应为2008-08-08" Font-Size="9pt" Height="16px" Operator="DataTypeCheck"
                                                                                                                         Type="Date" Width="102px"></asp:CompareValidator></td>
                                                                                           </tr>
                                                                                           <tr>
                                                                                               <td style="width: 100px">
                                                                                                   发布人：</td>
                                                                                               <td style="width: 100px">
                                                                                                   <asp:TextBox ID="TxtPerson" runat="server" Width="199px"></asp:TextBox></td>
                                                                                               <td style="width: 100px">
                                                                                               </td>
                                                                                           </tr>
                                                                                           <tr>
                                                                                               <td style="height: 17px; width: 100px;">
                                                                                                   摘自：</td>
                                                                                               <td style="height: 17px; width: 100px;">
                                                                                                   <asp:TextBox ID="TxtComeFrom" runat="server" Width="198px"></asp:TextBox></td>
                                                                                               <td style="height: 17px; width: 100px;">
                                                                                               </td>
                                                                                           </tr>
                                                                                           <tr>
                                                                                               <td colspan="3">
                                                                                                   &nbsp;<asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" SkinID="btnSkin"
                                                                                                                     Text="修改" Width="68px" />
                                                                                                   &nbsp;&nbsp;
                                                                                                   <asp:LinkButton ID="linBtnReturn" runat="server" Font-Size="9pt" OnClick="linBtnReturn_Click"
                                                                                                                   Width="38px">返 回</asp:LinkButton></td>
                                                                                           </tr>
                                                                                       </table>
                                                                                   </div>
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                      &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                  </td>
              </tr>
          </table>
</asp:Content>
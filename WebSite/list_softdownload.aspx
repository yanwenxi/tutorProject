﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list_softdownload.aspx.cs" Inherits="list_softdownload" StylesheetTheme="MRSOFTASPNET"%>

<%@ Register Src="control/foot.ascx" TagName="foot" TagPrefix="uc2" %>

<%@ Register Src="control/header.ascx" TagName="header" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
        <title>企业门户网站</title>
 
    </head>
    <body style="background-image: url(image/bg.jpg)">
        <form id="form1" runat="server">
            <div>
                <div style="background-image: url(image/bg.jpg); text-align: center;">
                    <table style="background-image: url(image/bg4.jpg); width: 776px;">
                        <tr>
                            <td align="left" colspan="2" style="height: 37px">
                                <uc1:header ID="Header1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 16px" rowspan="2" valign="top">
                                <div style="text-align: center">
                                    <table style="border-bottom: 1px solid; border-left: 1px solid; border-right: 1px solid; border-top: 1px solid; width: 100%;">
                                        <tr>
                                            <td style="width: 100px">
                                                <asp:Image ID="ImgT" runat="server" ImageUrl="~/image/index_type.gif" Height="67px" Width="228px" /></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 100px">
                                                <asp:DataList ID="DlLeibie" runat="server" OnUpdateCommand="DlLeibie_UpdateCommand" Width="223px">
                                                    <ItemTemplate>
                                                        <div style="text-align: center">
                                                            <table style="width: 100%">
                                                                <tr>
                                                                    <td style="height: 21px; width: 100px;">
                                                                        <asp:Image ID="Image2" runat="server" ImageUrl="~/image/tb.jpg" /></td>
                                                                    <td style="height: 21px; width: 100px;">
                                                                        <asp:LinkButton ID="LinBtnLeibie" runat="server" CommandName="Update" Font-Size="9pt"
                                                                                        Text='<%#                                        Eval("name") %>'></asp:LinkButton></td>
                                                                </tr>
                                                            </table>
                                                        </div>
                                                    </ItemTemplate>
                                                </asp:DataList></td>
                                        </tr>
                                    </table>
                                </div>
                            </td>
                            <td style="width: 559px">
                                <div style="text-align: center">
                                    <table style="border-bottom: 1px solid; border-left: 1px solid; border-right: 1px solid; border-top: 1px solid; width: 100%;">
                                        <tr>
                                            <td colspan="3" style="background-color: #6699ff; height: 25px;">
                                                <span style="color: #ffffff; font-size: 9pt;">= 产品信息 =</span></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 24px; width: 100px;">
                                                <span style="font-size: 9pt">产品名称</span></td>
                                            <td style="height: 24px; width: 91px;">
                                                <asp:Label ID="lblName" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                            <td rowspan="9" style="width: 292px">
                                                <asp:Image ID="ImgSoft" runat="server" Height="188px" Width="252px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 18px; width: 100px;">
                                                <span style="font-size: 9pt">产品版本</span></td>
                                            <td style="height: 18px; width: 91px;">
                                                <asp:Label ID="lblEdition" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 24px; width: 100px;">
                                                <span style="font-size: 9pt">运行环境</span></td>
                                            <td style="height: 24px; width: 91px;">
                                                <asp:Label ID="lblCondition" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 23px; width: 100px;">
                                                <span style="font-size: 9pt">产品价格</span></td>
                                            <td style="height: 23px; width: 91px;">
                                                <asp:Label ID="lblPrice" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 26px; width: 100px;">
                                                <span style="font-size: 9pt">版本说明</span></td>
                                            <td style="height: 26px; width: 91px;">
                                                <asp:Label ID="lblIntroEdition" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 23px; width: 100px;">
                                                <span style="font-size: 9pt">产品类别</span></td>
                                            <td style="height: 23px; text-align: center; width: 91px;">
                                                <asp:DropDownList ID="DDlLeibie" runat="server" Font-Size="9pt" Width="74px" SkinID="ddlSkin">
                                                </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 23px; width: 100px;">
                                                <span style="font-size: 9pt">产品类型</span></td>
                                            <td style="height: 23px; width: 91px;">
                                                <asp:Label ID="LblType" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 23px; width: 100px;">
                                                <span style="font-size: 9pt">文件大小</span></td>
                                            <td style="height: 23px; width: 91px;">
                                                <asp:Label ID="lblSize" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 23px; width: 100px;">
                                                <span style="font-size: 9pt">下载次数</span></td>
                                            <td style="height: 23px; width: 91px;">
                                                <asp:Label ID="lblpoint" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 22px; width: 100px;">
                                                <span style="font-size: 9pt">上传时间</span></td>
                                            <td style="height: 22px; width: 91px;">
                                                <asp:Label ID="lblUpTime" runat="server" Font-Size="9pt" Width="128px"></asp:Label></td>
                                            <td style="height: 22px; width: 292px;">
                                                <asp:LinkButton ID="LinBtnShowBigImage" runat="server" Font-Size="9pt" Font-Underline="False" OnClick="LinBtnShowBigImage_Click">查看大图片</asp:LinkButton>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="height: 36px; width: 100px;">
                                                <span style="font-size: 9pt">其他说明</span></td>
                                            <td style="height: 36px; width: 91px;">
                                                <asp:Label ID="LblIntro" runat="server" Font-Size="9pt" Height="49px"
                                                           Width="128px"></asp:Label></td>
                                            <td style="height: 36px; width: 292px;">
                                                <asp:Label ID="LblID" runat="server" Font-Size="9pt" Text="该Label控件不能删不能删" Visible="False" Width="164px"></asp:Label>
                                                <asp:Label ID="LblProduct" runat="server" Font-Size="9pt" Height="1px" Visible="False"
                                                           Width="98px"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 53px; width: 100px;">
                                                <span style="font-size: 9pt">点击下载</span></td>
                                            <td style="height: 53px; text-align: center; width: 91px;">
                                                <asp:ImageButton ID="ImgBtndownLoad" runat="server" OnClick="ImgBtndownLoad_Click" ImageUrl="~/image/download.gif" /></td>
                                            <td style="height: 53px; width: 292px;">
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 559px" align="right">
                                <asp:LinkButton ID="LinBtnReturn" runat="server" Font-Size="9pt" OnClick="LinBtnReturn_Click">［返回］</asp:LinkButton></td>
                        </tr>
                        <tr>
                            <td align="left" colspan="2">
                                <uc2:foot ID="Foot1" runat="server" />
                            </td>
                        </tr>
                    </table>
                </div>
    
            </div>
        </form>
    </body>
</html>
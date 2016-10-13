<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default"  StylesheetTheme="MRSOFTASPNET"%>

<%@ Register Src="control/New.ascx" TagName="New" TagPrefix="uc3" %>
<%@ Register Src="control/Left.ascx" TagName="Left" TagPrefix="uc4" %>

<%@ Register Src="control/foot.ascx" TagName="foot" TagPrefix="uc2" %>

<%@ Register Src="control/header.ascx" TagName="header" TagPrefix="uc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
        <title>企业门户网站</title>
        <link href="css.css" rel="stylesheet" type="text/css">
        <style type="text/css">
            .style1 { width: 161px; }
        </style>
    </head>
    <body style="background-image: url(image/bg.jpg)">
        <form id="form1" runat="server">
            <div>
                <table style="background-image: url(image/bg4.jpg); width: 760px;" border="0">
                <tr>
                    <td style="height: 275px;" colspan="2" id="TD1">
                        <uc1:header ID="Header1" runat="server" />
                    </td>
                </tr>
                <tr>
                <td align="left" valign="top" rowspan="2" class="style1">
                <table style="height: 280px; width: 100%;">
                    <tr>
                        <td style="height: 129px; width: 100px;" valign="top">
                            <div style="text-align: center">
                            <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                                <table style="border-bottom: 1px solid; border-left: 1px solid; border-right: 1px solid; border-top: 1px solid; width: 109%;">
                                    <tr>
                                        <td colspan="2" style="height: 45px">
                                            <asp:Image ID="ImgT" runat="server" ImageUrl="~/image/LoginHead.jpg" /></td>
                                    </tr>
                                    <tr>
                                        <td style="height: 28px; width: 100px;">
                                                        
                                            <asp:Image ID="ImgUserName" runat="server" ImageUrl="~/image/用户名称.jpg" /></td>
                                        <td style="height: 28px; text-align: left; width: 100px;" valign="middle">
                                            <asp:TextBox ID="TxtUserName" runat="server" Width="100px"></asp:TextBox>
                                            &nbsp;&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="height: 29px; width: 100px;">
                                            <span style="font-size: 9pt">
                                                <asp:Image ID="ImgUserPwd" runat="server" ImageUrl="~/image/用户密码.jpg" /></span></td>
                                        <td style="height: 29px; text-align: left; width: 100px;">
                                            <asp:TextBox ID="TxtUserPwd" runat="server" Width="100px" TextMode="Password"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="height: 19px; width: 100px;">
                                            <span style="font-size: 9pt">
                                                <asp:Image ID="ImgYz" runat="server" ImageUrl="~/image/验证码.jpg" /></span></td>
                                        <td style="height: 19px; width: 100px;" valign="top">
                                                      
                                            <table style="width: 100%">
                                                <tr>
                                                    <td style="width: 100px">
                                                        <asp:TextBox ID="TxtCode" runat="server" Width="100px"></asp:TextBox></td>
                                                    <td style="width: 100px">
                                                        <img src="checkcode.aspx" alt="验证码" /></td>
                                                </tr>
                                            </table>
                                                        
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:ImageButton ID="ImgBtnLogin" runat="server" ImageUrl="~/image/dl1.jpg" OnClick="ImgBtnLogin_Click" /><asp:ImageButton ID="ImgBtnCancel" runat="server" ImageUrl="~/image/qx.jpg" OnClick="ImgBtnCancel_Click" />
                                            <asp:LinkButton ID="LinBtnforgetPwd" runat="server" Font-Size="9pt" Font-Underline="False" OnClick="LinBtnforgetPwd_Click"　>忘记密码?</asp:LinkButton>
                                            <asp:LinkButton ID="LinBtnReg" runat="server" Font-Size="9pt"　Font-Underline="False" OnClick="LinBtnReg_Click"
                                                            Width="52px">注　册</asp:LinkButton></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="text-align: center">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel ID="Panel2" runat="server" Height="50px" Width="125px">
                                <table style="border-bottom: 1px solid; border-left: 1px solid; border-right: 1px solid; border-top: 1px solid; width: 109%;">
                                    <tr>
                                        <td colspan="2" style="height: 45px">
                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/LoginHead.jpg" /></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: 28px; text-align: center" valign="middle">
                                            <asp:Label ID="LblInfo" runat="server" ForeColor="Red"></asp:Label>
                                            &nbsp;&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="height: 29px;" colspan="2">
                                            <span style="font-size: 9pt">
                                            </span></td>
                                    </tr>
                                    <tr>
                                        <td style="height: 19px; width: 100px;">
                                            <span style="font-size: 9pt"></span>
                                        </td>
                                        <td style="height: 19px; width: 104px;" valign="top">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="height: 19px">
                                            <asp:LinkButton ID="LinBtnExit" runat="server" Font-Size="9pt"　Font-Underline="False" OnClick="LinBtnExit_Click">【退出登录】</asp:LinkButton></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2" style="text-align: center">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <br />
                                        
                        </td>
                    </tr>
                                
                </table>
                <br />
                <uc4:Left ID="Left1" runat="server" />
            </div>
        </td>
            <td style="width: 80px">
                <div style="text-align: right">
                    <uc3:New ID="New1" runat="server" />
                    &nbsp;</div>
            </td>
        </tr>
            <tr>
                <td style="height: 45px; width: 96px;" valign="top">
                    <table style="height: 1159px; width: 90%;">
                        <tr>
                            <td style="height: 23px; width: 94px;">
                                <asp:Image ID="ImgSoftIntro" runat="server" ImageUrl="~/image/index_introduce.gif" /></td>
                        </tr>
                        <tr>
                            <td style="height: 93%; valign: top; width: 94px;" valign="top">
                                <asp:DataList ID="dlSoftIntro" runat="server" Height="602px" Width="517px" OnItemCommand="dlSoftIntro_ItemCommand">
                                    <ItemTemplate>
                                        <div style="text-align: center">
                                            <table style="border-bottom: 1px solid; border-left: 1px solid; border-right: 1px solid; border-top: 1px solid; width: 100%;">
                                                <tr>
                                                    <td style="border-bottom: 1px dashed; height: 27px; text-align: center; width: 198px;">
                                                        <span style="font-size: 9pt"><strong>软件名称：</strong></span></td>
                                                    <td style="border-bottom: 1px dashed; height: 27px; width: 198px;">
                                                        <asp:Label ID="LblName" runat="server" Font-Size="9pt" Text='<%#                                        DataBinder.Eval(Container.DataItem, "Name") %>'></asp:Label></td>
                                                    <td rowspan="5" style="width: 100px" align="center" valign="top">
                                                        <asp:Image ID="Image12" runat="server" Height="164px" Width="266px" ImageUrl='<%#                                        DataBinder.Eval(Container.DataItem, "Image") %>' /></td>
                                                </tr>
                                                <tr>
                                                    <td style="border-bottom: 1px dashed; height: 28px; text-align: center; width: 198px;">
                                                        <span style="font-size: 9pt"><strong>版本 号：</strong></span></td>
                                                    <td style="border-bottom: 1px dashed; height: 28px; text-align: center; width: 93px;">
                                                        <asp:Label ID="LblEdition" runat="server" Font-Size="9pt" Text='<%#                                        DataBinder.Eval(Container.DataItem, "Edition") %>'></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td style="border-bottom: 1px dashed; height: 28px; width: 198px;">
                                                        <span style="font-size: 9pt"><strong>运行平台：</strong></span></td>
                                                    <td style="border-bottom: 1px dashed; height: 28px; width: 198px;">
                                                        <asp:Label ID="LblCondition" runat="server" Font-Size="9pt" Text='<%#                                        DataBinder.Eval(Container.DataItem, "Condition") %>'></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td style="border-bottom: 1px dashed; height: 30px; width: 198px;">
                                                        <span style="font-size: 9pt"><strong>价 格：</strong></span></td>
                                                    <td style="border-bottom: 1px dashed; height: 30px; width: 198px;">
                                                        <asp:Label ID="LblPrice" runat="server" Font-Size="9pt" Text='<%#                                        DataBinder.Eval(Container.DataItem, "price") %>'></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td style="border-bottom: 1px dashed; height: 26px; width: 198px;">
                                                        <span style="font-size: 9pt"><strong>软件类别：</strong></span></td>
                                                    <td style="border-bottom: 1px dashed; height: 26px; width: 198px;">
                                                        <asp:Label ID="LblLeibie" runat="server" Font-Size="9pt" Text='<%#                DataBinder.Eval(Container.DataItem, "LeiBie") %>'></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 198px">
                                                        <strong><span style="font-size: 9pt">产品介绍：</span></strong></td>
                                                    <td colspan="2">
                                                        <asp:Label ID="LblIntro" runat="server"  Font-Size="9pt" Text='<%#                DataBinder.Eval(Container.DataItem, "Intro") %>' Height="27px" Width="325px"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td style="height: 45px; width: 198px;">
                                                        <a href='list_softdownload.aspx?ID=<%#Eval("id") %>' target=_parent><span style="color: #ff0000; font-size: 9pt;" >详细信息>></span></a></td>
                                                    <td style="height: 45px; width: 198px;">
                                                    </td>
                                                    <td align="center" rowspan="1" style="height: 45px; width: 100px;">
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </ItemTemplate>
                                    <SeparatorTemplate>
                                        _______________________________________________________________
                                    </SeparatorTemplate>
                                </asp:DataList>
                                    
                                <asp:LinkButton ID="LinBtnMoreSoft" runat="server" Font-Size="9pt"　Font-Underline="False" OnClick="LinBtnMoreSoft_Click">更多软件</asp:LinkButton></td>
                        </tr>
                        <tr>
                            <td style="height: 11px; width: 94px;" align="center">
                                &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 35px">
                    <uc2:foot ID="Foot1" runat="server" />
                    <asp:LinkButton ID="LinBtnAdmin" runat="server" OnClick="LinBtnAdmin_Click" Font-Size="9pt">进入后台</asp:LinkButton></td>
            </tr>
        </table>
        </div>
        </div>
        </form>
    </body>
</html>
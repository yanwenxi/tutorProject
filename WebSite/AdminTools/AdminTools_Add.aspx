﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="AdminTools_Add.aspx.cs" Inherits="AdminTools_AdminTools_Add" Title="Untitled Page" StylesheetTheme="MRSOFTASPNET"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td colspan="3" style="background-color: #99cccc; height: 25px; text-align: center">
                <span style="color: #ffffff; font-size: 9pt;">
                    = 添加产品信息 =</span></td>
        </tr>
        <tr>
            <td style="height: 24px; width: 100px;">
                <span style="font-size: 9pt">产品名称</span></td>
            <td style="height: 24px; width: 84px;">
                <asp:TextBox ID="TxtName" runat="server" Width="128px"></asp:TextBox></td>
            <td rowspan="9" style="width: 292px">
                <asp:Image ID="ImgSoft" runat="server" Height="259px" Width="284px" /><span style="font-size: 9pt">
                                                                                      </span>
            </td>
        </tr>
        <tr style="font-size: 9pt">
            <td style="height: 18px; width: 100px;">
                <span>产品版本</span></td>
            <td style="height: 18px; width: 84px;">
                <asp:TextBox ID="TxtEdition" runat="server" Font-Size="9pt" Width="128px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 24px; width: 100px;">
                <span style="font-size: 9pt">运行环境</span></td>
            <td style="height: 24px; width: 84px;">
                <asp:TextBox ID="TxtCondition" runat="server" Font-Size="9pt" Width="128px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 23px; width: 100px;">
                <span style="font-size: 9pt">产品价格</span></td>
            <td style="height: 23px; width: 84px;">
                <asp:TextBox ID="TxtPrice" runat="server" Font-Size="9pt" Width="128px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 26px; width: 100px;">
                <span style="font-size: 9pt">版本说明</span></td>
            <td style="height: 26px; width: 84px;">
                <asp:TextBox ID="TxtIntroEdition" runat="server" Font-Size="9pt" Width="128px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 23px; width: 100px;">
                <span style="font-size: 9pt">产品类别</span></td>
            <td style="height: 23px; width: 84px;">
                <asp:DropDownList ID="ddllb" runat="server" Font-Size="9pt" Width="128px"></asp:DropDownList></td>
        </tr>
        <tr>
            <td style="height: 23px; width: 100px;">
                <span style="font-size: 9pt">产品类型</span></td>
            <td style="height: 23px; width: 84px;">
                <asp:DropDownList ID="ddlType" runat="server" Width="128px">
                    <asp:ListItem>补丁</asp:ListItem>
                    <asp:ListItem>软件</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="height: 23px; width: 100px;">
                <span style="font-size: 9pt">文件大小</span></td>
            <td style="height: 23px; width: 84px;">
                <asp:TextBox ID="TxtSize" runat="server" Font-Size="9pt" Width="128px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 23px; width: 100px;">
                <span style="font-size: 9pt">下载次数</span></td>
            <td style="height: 23px; width: 84px;">
                <asp:TextBox ID="TxtPoint" runat="server" Font-Size="9pt" Width="128px" ForeColor="Red" ReadOnly="True">0</asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 15px; width: 100px;">
                <span style="font-size: 9pt">上传时间</span></td>
            <td style="height: 15px; width: 84px;">
                <asp:TextBox ID="TxtTime" runat="server" Font-Size="9pt" 
                             Width="128px" ReadOnly="True"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtTime"
                                      ErrorMessage="时间格式不正确，应为2008-08-08" Font-Size="9pt" Height="16px" Operator="DataTypeCheck"
                                      Type="Date" Width="102px"></asp:CompareValidator></td>
            <td style="height: 15px; width: 292px;">
                <span style="font-size: 9pt">&nbsp;</span><span><span style="font-size: 9pt"> &nbsp;
                                                                    &nbsp; &nbsp; &nbsp; </span>
                                                              <div style="text-align: center">
                                                                  <table style="font-size: 9pt; width: 100%">
                                                                      <tr>
                                                                          <td style="height: 17px; width: 52px;">
                                                                              <span>选择图片&nbsp;</span></td>
                                                                          <td style="height: 17px; width: 100px;">
                                                                              <asp:DropDownList ID="DDlToolsImage" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLTools_SelectedIndexChanged"
                                                                                                Width="128px">
                                                                              </asp:DropDownList></td>
                                                                      </tr>
                                                                  </table>
                                                              </div>
                                                          </span>
            </td>
        </tr>
        <tr>
            <td style="height: 52px; width: 100px;">
                <span style="font-size: 9pt">其他说明</span></td>
            <td style="height: 52px; width: 84px;">
                <asp:TextBox ID="TxtIntro" runat="server" Font-Size="9pt" Height="49px" TextMode="MultiLine"
                             Width="128px"></asp:TextBox></td>
            <td align="center" style="height: 52px; width: 292px;">
                <asp:Label ID="LblID" runat="server" Font-Size="9pt" Text="该Label控件不能删不能删" Visible="False"
                           Width="164px"></asp:Label></td>
        </tr>
        <tr>
            <td style="height: 53px; width: 100px;">
                <span style="font-size: 9pt">
                    <br />
                    下载工具</span></td>
            <td style="height: 53px; width: 84px;">
                <asp:DropDownList ID="DDLTools" runat="server" Width="128px">
                </asp:DropDownList></td>
            <td style="height: 53px; width: 292px;">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3" style="height: 21px">
                <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" SkinID="btnSkin"
                            Text="添加" Width="55px" />
                &nbsp;&nbsp;
                <asp:LinkButton ID="LinAddsoftMend" runat="server" Font-Size="9pt" OnClick="LinAddsoftMend_Click">添加下载工具</asp:LinkButton>
                <asp:LinkButton ID="LinBtnPhoto" runat="server" Font-Size="9pt" OnClick="LinBtnPhoto_Click">添加工具图片</asp:LinkButton></td>
        </tr>
    </table>
</asp:Content>
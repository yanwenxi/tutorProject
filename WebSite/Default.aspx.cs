﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间

public partial class _Default : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null || Session["UserPwd"] != null)
        {
            LblInfo.Text = "您好！ " + Session["UserName"] + " 欢迎您登录本网站！";
            Panel2.Visible = true;
            Panel1.Visible = false;
        }
        else
        {
            Panel2.Visible = false;
            Panel1.Visible = true;
        }
        ep.EXECDataList(dlSoftIntro, "select top 4 * from tb_Tools order by UPTime desc", "Id");
    }

    protected void ImgBtnLogin_Click(object sender, ImageClickEventArgs e)
    {
        if (TxtUserName.Text == string.Empty)
        {
            Response.Write("<script language=javascript>alert('用户名不能为空！');location='Default.aspx'</script>");
            return;
        }
        else
        {
            if (TxtCode.Text == Request.Cookies["CheckCode"].Value)
            {
                string SqlStr = "select count(*) from tb_UserLogin where UserName='" + TxtUserName.Text +
                                "'and UserPwd='" + TxtUserPwd.Text + "'";
                int a = ep.EXECuteScalar(SqlStr);
                if (a >= 1)
                {
                    Session["UserName"] = TxtUserName.Text;
                    Session["UserPwd"] = TxtUserPwd.Text;
                    Response.Write("<script lanuage='javaScript'>alert('恭喜您！！登录成功！');location='Default.aspx'</script>");
                    //弹出对话框显示“恭喜您！！登录成功！”
                    Panel2.Visible = true;
                    Panel1.Visible = false;
                }
                else
                {
                    Response.Write("<script lanuage='javaScript'>alert('很遗憾！！登录失败！');location='Default.aspx'</script>");
                    //弹出对话框显示“很遗憾！！登录失败！”
                }
            }
            else
            {
                Response.Write("<script language=javascript>alert('输入的验证码不正确！');location='Default.aspx'</script>");
            }
        }
    }

    protected void LinBtnReg_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Register/RegPro.aspx"); //跳转到注册协议页面
    }

    protected void LinBtnforgetPwd_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/FindPwd/Findpwd1.aspx"); //跳转到找回密码第一步的页面中
    }

    protected void LinBtnAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AdminLogin.aspx"); //跳转到管理员登录页面
    }

    protected void dlSoftIntro_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Xiangxi")
        {
            Response.Redirect("list_softdownload.aspx"); //将页面跳转到list_softdownload.aspx页面中
        }
    }

    protected void LinBtnMoreSoft_Click(object sender, EventArgs e)
    {
        Response.Redirect("More_Soft.aspx"); //跳转到More_Soft.aspx页面中
    }

    protected void ImgBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        /*清空文本框*/
        TxtUserName.Text = "";
        TxtUserPwd.Text = "";
        TxtCode.Text = "";
    }

    protected void LinBtnExit_Click(object sender, EventArgs e)
    {
        Session["UserName"] = null;
        Session["UserPwd"] = null;
        Panel1.Visible = true;
        Panel2.Visible = false;
    }
}
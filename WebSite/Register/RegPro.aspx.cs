using System;
using System.Web.UI;

public partial class Module_Admin_Register : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("User_Reg.aspx"); //跳转到登录页面
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("../Default.aspx"); //跳转到网站首页中
    }
}
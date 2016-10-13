using System;
using System.Web.UI;

public partial class Default1 : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断管理员是否已经登录过
        if (Session["AdminUserName"] != null || Session["AdminPassWord"] != null)
        {
            Session["AdminUserName"] = null;
            Session["AdminPassWord"] = null;
        }
        //判断用户是否已经登录过
        if (Session["UserName"] != null || Session["PassWord"] != null)
        {
            Session["UserName"] = null;
            Session["UserPwd"] = null;
        }
    }

    protected void LinbtnSy_Click(object sender, EventArgs e)
    {
        Response.Write("<script lanuage='javaScript'>;location='Default.aspx'</script>");
    }

    protected void LinBtnHT_Click(object sender, EventArgs e)
    {
        Response.Write("<script lanuage='javaScript'>;location='AdminLogin.aspx'</script>");
    }
}
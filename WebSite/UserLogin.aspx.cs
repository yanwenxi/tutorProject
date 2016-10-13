using System;
using System.Web.UI;

//引入命名空间
public partial class UserLogin : Page
{
    private readonly EP ep = new EP(); //引入命名空间

    protected void Page_Load(object sender, EventArgs e)
    {
        ////使用Session判断用户是否已经登录过，如果已经登录过不用再重新登录，直接跳转到网站前台首页中
        //if (Session["UserName"] != null && Session["PassWord"] != null)
        //{
        //    //Session["UserName"] =null;
        //    //Session["PassWord"] = null;
        //    Response.Redirect("Default.aspx");//跳转到首页
        //}
    }

    protected void ImgCZ_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Register/RegPro.aspx"); //跳转到注册协议页面
    }

    protected void ImgBtnLogin_Click(object sender, ImageClickEventArgs e)
    {
        if (TxtUserName.Text == string.Empty)
        {
            Response.Write("<script language=javascript>alert('用户名不能为空！');location='UserLogin.aspx'</script>");
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
                    //弹出对话框显示“恭喜您！！登录成功！”,并且跳转到网站首页中
                }
                else
                {
                    Response.Write("<script lanuage='javaScript'>alert('很遗憾！！登录失败！');location='UserLogin.aspx'</script>");
                    //弹出对话框显示“很遗憾！！登录失败！”
                }
            }
            else
            {
                Response.Write("<script language=javascript>alert('输入的验证码不正确！');location='UserLogin.aspx'</script>");
            }
        }
    }
}
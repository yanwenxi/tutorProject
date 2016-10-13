using System;
using System.Data;
using System.Web.UI;

//引入命名空间

public partial class AdminSelect_UserInfo : Page
{
    private readonly EP ep = new EP(); //实例化对象

    protected void Page_Load(object sender, EventArgs e)
    {
        //使用Session判断管理员是否已成功登录
        if (Session["AdminUserName"] == null && Session["AdminPassWord"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                if (Request["UserId"] != null)
                {
                    DataSet ds = ep.ReturnDataSet(
                        "select * from tb_UserLogin where UserId='" + Request["UserId"] + "'", "tb_UserLogin");
                    DataRowView rv = ds.Tables["tb_UserLogin"].DefaultView[0];
                    LblUserId.Text = rv["UserId"].ToString();
                    lblUserName.Text = rv["UserName"].ToString();
                    Lblrole.Text = rv["role"].ToString();
                    lblSex.Text = rv["Sex"].ToString();
                    LblAge.Text = rv["Age"].ToString();
                    lblphone.Text = rv["phone"].ToString();
                    lblEmail.Text = rv["Email"].ToString();
                    lblQQ.Text = rv["QQ"].ToString();
                    lblAddress.Text = rv["Address"].ToString();
                    lblhomepage.Text = rv["homepage"].ToString();
                    LblIntro.Text = rv["Intro"].ToString();
                    Img.ImageUrl = rv["Image"].ToString();
                }
            }
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSearch_User.aspx"); //跳转到AdminSearch_User.aspx页面中
    }
}
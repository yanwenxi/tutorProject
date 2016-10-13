using System;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class AdminFriendLink : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //使用Session判断管理员是否已成功登录
            if (Session["AdminUserName"] == null && Session["AdminPassWord"] == null)
            {
                Response.Redirect("~/AdminLogin.aspx");
            }
            else
            {
                bindGridView(); //调用用户自定义方法
            }
        }
    }

    public void bindGridView()
    {
        string SqlStr = "select * from tb_FriendLink";
        ep.EXECGridView(GridView1, SqlStr);
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bindGridView(); //调用自定义方法
    }

    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bindGridView();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminFriendLink_Add.aspx");
    }
}
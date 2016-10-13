using System;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class AdminUser_AdminUser : Page
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

    public void bindGridView() //定义一个自定义的方法
    {
        string SqlStr = "select * from tb_UserLogin";
        ep.EXECGridView(GridUser, SqlStr);
    }

    protected void LinBtnAdd_Click(object sender, EventArgs e)
    {
        //将页面跳转到添加用户信息的页面中
        Response.Redirect("~/AdminUser/AdminUser_Add.aspx");
    }


    protected void GridUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridUser.PageIndex = e.NewPageIndex;
        bindGridView(); //调用用户自定义方法
    }
}
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class SoftdownLoad : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        //判断用户是否登录，如果没登录跳转到登录页面中
        if (Session["UserName"] == null && Session["UserPwd"] == null)
        {
            //弹出对话框显示“对不起！您还没有登录”提示信息，并且将页面跳转到用户登录页面中
            Response.Write("<script lanuage='javaScript'>alert('对不起！您还没有登录！');location='UserLogin.aspx'</script>");
        }
        else
        {
            Lblsoft.Text = Request["soft"];
            bindGridView(); //调用用户自定义方法
        }
    }

    public void bindGridView() //用户自定义方法
    {
        string sqlstr = "select * from tb_tools where Type='" + Request["soft"] + "'";
        ep.EXECGridView(Gvtype, sqlstr);
    }

    protected void Gvtype_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Gvtype.PageIndex = e.NewPageIndex;
        bindGridView(); //用户自定义方法
    }
}
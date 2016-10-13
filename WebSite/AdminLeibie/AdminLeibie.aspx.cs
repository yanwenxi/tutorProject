using System;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class AdminLeibie_AdminLeibie : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

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
                bindGridView();
            }
        }
    }

    public void bindGridView()
    {
        string SqlStr = "select * from tb_Leibie";
        ep.EXECGridView(GridView1, SqlStr);
    }

    protected void LinBtnADD_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminLeibie_ADD.aspx"); //跳转到AdminLeibie_ADD.aspx页面中
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bindGridView(); //重新绑定一下GridView 控件
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[2].Text = Convert.ToDateTime(e.Row.Cells[2].Text).ToShortDateString(); //获取日期并将其转化为短日期格式
        }
    }
}
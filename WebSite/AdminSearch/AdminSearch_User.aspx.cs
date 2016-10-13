using System;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class AdminSearch : Page
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
                bindGridView(); //调用字定义绑定GridView控件方法  
            }
        }
    }

    public void bindGridView()
    {
        string SqlStr = "select * from tb_UserLogin";
        gvUserInfo.DataKeyNames = new[] {"UserId"};
        ep.EXECGridView(gvUserInfo, SqlStr);
    }

    protected void gvUserInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvUserInfo.PageIndex = e.NewPageIndex;
        string sqlstr = "select * from tb_UserLogin where " + ddlCondition.SelectedValue + " like '%" +
                        txtKey.Text.Trim() + "%'";
        ep.EXECGridView(gvUserInfo, sqlstr);
    }


    protected void btnSel_Click(object sender, EventArgs e)
    {
        if (txtKey.Text == "")
        {
            string sqlstr = "select * from tb_UserLogin";
            ep.EXECGridView(gvUserInfo, sqlstr);
        }
        else
        {
            string sqlstr = "select * from tb_UserLogin where " + ddlCondition.SelectedValue + " like '%" +
                            txtKey.Text.Trim() + "%'";
            ep.EXECGridView(gvUserInfo, sqlstr);
        }
    }
}
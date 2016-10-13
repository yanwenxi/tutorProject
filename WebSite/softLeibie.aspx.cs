using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class softLeibie : Page
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
            ep.EXECDataList(DlLeibie, "select top 10 * from tb_leibie ", "id"); //显示类别信息
            if (Request["id"] != null)
            {
                DataSet ds = null;
                ds = ep.ReturnDataSet("select * from tb_leibie where id='" + Request["id"] + "'", "tb_leibie");
                DataRowView rv = ds.Tables["tb_leibie"].DefaultView[0];
                LblLeiBie.Text = rv["name"].ToString();
            }
            bindGridView(); //调用绑定方法
        }
    }

    protected void DlLeibie_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        string id = DlLeibie.DataKeys[e.Item.ItemIndex].ToString();
        Response.Redirect("softleibie.aspx?id=" + id + "");
    }

    public void bindGridView()
    {
        string sqlstr = "select * from tb_tools where LeiBie='" + LblLeiBie.Text + "'";
        ep.EXECGridView(GridView1, sqlstr);
    }

    protected void LinBtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx"); //跳转到网站首页中
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bindGridView(); //调用用户自定义方法
    }
}
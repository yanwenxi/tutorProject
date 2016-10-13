using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class New_info : Page
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
            if (Request["id"] != null)
            {
                DataSet ds = ep.ReturnDataSet("select * from tb_New where id='" + Request["id"] + "'", "tb_New");
                DataRowView rv = ds.Tables["tb_New"].DefaultView[0];
                lblid.Text = rv["id"].ToString();
                lblTitle.Text = rv["title"].ToString();
                TxtContent.Text = rv["Content"].ToString();
                lblAddTime.Text = rv["PublishTime"].ToString();
                lblPerson.Text = rv["PublishPerson"].ToString();
                lblComeFrom.Text = rv["ComeFrom"].ToString();
            }
        }
    }

    protected void LinBtnreturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("MoreNew.aspx"); //将页面跳转到更多新闻页面＂MoreNew.aspx＂中
    }
}
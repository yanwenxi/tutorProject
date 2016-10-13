using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminDelete : Page
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
                if (Request["id"] != null)
                {
                    DataSet ds = ep.ReturnDataSet("select * from tb_GongGao where id='" + Request["id"] + "'",
                                                  "tb_gonggao");
                    DataRowView rv = ds.Tables["tb_GongGao"].DefaultView[0];
                    Txtid.Text = rv["id"].ToString();
                    TextBox1.Text = rv["title"].ToString();
                    TextBox2.Text = rv["content"].ToString();
                    TextBox3.Text = Convert.ToDateTime(rv["GTime"].ToString()).ToShortDateString();
                }
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlDelete = "delete from tb_GongGao where id='" + Txtid.Text + "'";
            EP.EXECCommand(SqlDelete);
            Response.Write("<script lanuage='javaScript'>alert('恭喜您！！公告信息删除成功！');location='AdminGongGao.aspx'</script>");
            //弹出对话框显示“恭喜您！！公告信息删除成功！”
        }
        catch
        {
            Response.Write("<script lanuage='javaScript'>alert('很遗憾！！公告信息删除失败！');location='AdminGongGao.aspx'</script>");
            //弹出对话框显示“很遗憾！！公告信息删除失败！”
        }
    }

    protected void linBtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminGongGao.aspx");
    }
}
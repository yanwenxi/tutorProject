using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminLeibie_AdminLeibie_Delete : Page
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
                    DataSet ds = ep.ReturnDataSet("select * from tb_leibie where id='" + Request["id"] + "'",
                                                  "tb_leibie");
                    DataRowView rv = ds.Tables["tb_leibie"].DefaultView[0];
                    TxtName.Text = rv["name"].ToString();
                    TxtTime.Text = rv["ADDTime"].ToString();
                }
            }
        }
    }

    protected void BtnCZ_Click(object sender, EventArgs e)
    {
        TxtName.Text = "";
        TxtTime.Text = "";
    }

    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlDelete = "Delete from tb_leibie where id='" + Request["id"] + "'";
            EP.EXECCommand(SqlDelete);
            Response.Write("<script lanuage='javaScript'>alert('恭喜您！！产品类别信息删除成功！');location='AdminLeibie.aspx'</script>");
            //弹出对话框显示“恭喜您！！产品类别信息删除成功！”
        }
        catch
        {
            Response.Write("<script lanuage='javaScript'>alert('很遗憾！！产品类别信息删除失败！');location='AdminLeibie.aspx'</script>");
            //弹出对话框显示“很遗憾！！产品类别信息删除失败！”
        }
    }

    protected void LinBtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminLeibie.aspx");
    }
}
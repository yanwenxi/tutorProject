using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminLeaveWord_Add : Page
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
                    DataSet ds = ep.ReturnDataSet("select * from tb_LeaveWord where id='" + Request["id"] + "'",
                                                  "tb_New");
                    DataRowView rv = ds.Tables["tb_LeaveWord"].DefaultView[0];
                    LblTitle.Text = rv["title"].ToString();
                    LblTime.Text = rv["lTime"].ToString();
                    LblPerson.Text = rv["person"].ToString();
                    LblContent.Text = rv["Content"].ToString();
                    TxtReply.Text = rv["RevertContent"].ToString();
                }
            }
        }
    }

    protected void LinBtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminLeaveWord.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlUpdate = "delete tb_LeaveWord set RevertContent='" + TxtReply.Text + "' where id='" +
                               Request["id"] + "'";
            EP.EXECCommand(SqlUpdate);
            Response.Write("<script lanuage='javaScript'>alert('恭喜您！！删除成功！');location='AdminLeaveWord.aspx'</script>");
            //弹出对话框显示“恭喜您！！删除成功！”
        }
        catch
        {
            Response.Write("<script lanuage='javaScript'>alert('很遗憾！！删除失败！');location='AdminLeaveWord.aspx'</script>");
            //弹出对话框显示“很遗憾！！删除失败！”
        }
    }
}
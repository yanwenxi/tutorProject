using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminLeaveWord_Delete : Page
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
                                                  "tb_LeaveWord");
                    DataRowView rv = ds.Tables["tb_LeaveWord"].DefaultView[0];
                    LblTitle.Text = rv["Title"].ToString();
                    LblTime.Text = Convert.ToDateTime(rv["lTime"].ToString()).ToShortDateString();
                    LblPerson.Text = rv["person"].ToString();
                    LblContent.Text = rv["Content"].ToString();
                    TxtReply.Text = rv["RevertContent"].ToString();
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlDelete = "Delete tb_LeaveWord where id='" + Request["id"] + "'";
            EP.EXECCommand(SqlDelete);
            Response.Write(
                "<script lanuage='javaScript'>alert('恭喜您！！留言信息删除成功！');location='AdminLeaveWord.aspx'</script>");
            //弹出对话框显示“恭喜您！！留言信息删除成功！”
        }
        catch
        {
            Response.Write(
                "<script lanuage='javaScript'>alert('很遗憾！！留言信息删除失败！');location='AdminLeaveWord.aspx'</script>");
            //弹出对话框显示“很遗憾！！留言信息删除失败！”
        }
    }

    protected void LinBtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminLeaveWord.aspx");
    }
}
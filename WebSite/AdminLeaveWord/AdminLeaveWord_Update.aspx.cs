using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminLeaveWord : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["id"] != null)
            {
                DataSet ds = ep.ReturnDataSet("select * from tb_LeaveWord where id='" + Request["id"] + "'",
                                              "tb_LeaveWord");
                DataRowView rv = ds.Tables["tb_LeaveWord"].DefaultView[0];
                TexTitle.Text = rv["Title"].ToString();
                TexTime.Text = Convert.ToDateTime(rv["lTime"].ToString()).ToShortDateString();
                TexPerson.Text = rv["person"].ToString();
                TexContent.Text = rv["Content"].ToString();
                TxtReply.Text = rv["RevertContent"].ToString();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlUpdate = "Update tb_LeaveWord set Title='" + TexTitle.Text + "',lTime='" + TexTime.Text +
                               "',person='" + TexPerson.Text + "',Content='" + TexContent.Text + "',RevertContent='" +
                               TxtReply.Text + "' where id='" + Request["id"] + "'";
            EP.EXECCommand(SqlUpdate);
            Response.Write(
                "<script lanuage='javaScript'>alert('恭喜您！！留言信息修改成功！');location='AdminLeaveWord.aspx'</script>");
            //弹出对话框显示“恭喜您！！留言信息修改成功！”
        }
        catch
        {
            Response.Write(
                "<script lanuage='javaScript'>alert('很遗憾！！留言信息修改失败！');location='AdminLeaveWord.aspx'</script>");
            //弹出对话框显示“很遗憾！！留言信息修改失败！”
        }
    }

    protected void LinBtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminLeaveWord.aspx");
    }
}
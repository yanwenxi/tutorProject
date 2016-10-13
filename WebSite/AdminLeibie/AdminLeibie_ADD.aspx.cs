using System;
using System.Web.UI;

//引入命名空间
public partial class AdminLeibie_AdminLeibie_ADD : Page
{
    private EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        //使用Session判断管理员是否已成功登录
        if (Session["AdminUserName"] == null && Session["AdminPassWord"] == null)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        if (TxtName.Text == "" && TxtTime.Text == "")
        {
            Response.Write("<script lanuage='javaScript'>alert('文本框不能为空！');location='Adminleibie_ADD.aspx'</script>");
        }
        else
        {
            try
            {
                String SqlInsert = "insert into tb_leibie values('" + TxtName.Text + "','" + TxtTime.Text + "')";
                EP.EXECCommand(SqlInsert);
                Response.Write(
                    "<script lanuage='javaScript'>alert('恭喜您！！类别信息添加成功！');location='Adminleibie.aspx'</script>");
                //弹出对话框显示“恭喜您！！类别信息添加成功！”
            }
            catch
            {
                Response.Write(
                    "<script lanuage='javaScript'>alert('很遗憾！！类别信息添加失败！');location='Adminleibie.aspx'</script>");
                //弹出对话框显示“很遗憾！！类别信息添加失败！”
            }
        }
    }

    protected void BtnCZ_Click(object sender, EventArgs e)
    {
        /*清空文本框*/
        TxtName.Text = "";
        TxtTime.Text = "";
    }
}
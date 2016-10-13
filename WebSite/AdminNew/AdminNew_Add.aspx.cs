using System;
using System.Web.UI;

//引入命名空间
public partial class AdminNew_Add : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

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
        if (Txtid.Text == "" && TxtTitle.Text == "" && TxtContent.Text == "" && TxtTime.Text == "" &&
            TxtPerson.Text == "" && TxtComeFrom.Text == "")
        {
            /*如果文本框为空，弹出提示对话框，显示“文本框不能为空”提示信息，并且将页面跳回到新闻信息添加页面“AdminNew_Add.aspx”中*/
            Response.Write("<script lanuage='javaScript'>alert('文本框不能为空！');location='AdminNew_Add.aspx'</script>");
        }
        else
        {
            try
            {
                String SqlInsert = "insert into tb_New values('" + Txtid.Text + "','" + TxtTitle.Text + "','" +
                                   TxtContent.Text + "','" + TxtTime.Text + "','" + TxtPerson.Text + "','" +
                                   TxtComeFrom.Text + "')";
                EP.EXECCommand(SqlInsert);
                Response.Write("<script lanuage='javaScript'>alert('恭喜您！！新闻信息添加成功！');location='AdminNew.aspx'</script>");
                //弹出对话框显示“恭喜您！！公告信息添加成功！”
            }
            catch
            {
                Response.Write("<script lanuage='javaScript'>alert('很遗憾！！新闻信息添加失败！');location='AdminNew.aspx'</script>");
                //弹出对话框显示“很遗憾！！公告信息添加失败！”
            }
        }
    }

    protected void BtnCheck_Click(object sender, EventArgs e)
    {
        if (Txtid.Text == "")
        {
            Response.Write("<script lanuage='javaScript'>alert('新闻编号不能为空！');location='AdminNew_Add.aspx'</script>");
        }
        else
        {
            string SqlStr = "select count(*) from tb_New where id='" + Txtid.Text + "'";
            int a = ep.EXECuteScalar(SqlStr);
            if (a >= 1)
            {
                //弹出对话框显示“新闻编号已存在，请在添加一个！”
                Response.Write(
                    "<script lanuage='javaScript'>alert('新闻编号已存在，请在添加一个！');location='AdminNew_Add.aspx'</script>");
            }
            else
            {
                //弹出对话框显示“新闻编号不存在，你可以继续添加其他信息！”
                Response.Write(
                    "<script lanuage='javaScript'>alert('新闻编号不存在，你可以继续添加其他信息！');location='AdminNew_Add.aspx'</script>");
            }
        }
    }
}
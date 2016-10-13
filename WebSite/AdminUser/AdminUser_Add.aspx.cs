using System;
using System.Web.UI;

//引入命名空间
public partial class AdminUser_AdminUser_Add : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //使用Session判断管理员是否已成功登录
            if (Session["AdminUserName"] == null && Session["AdminPassWord"] == null)
            {
                //将页面跳转到管理员登录页面中
                Response.Redirect("~/AdminLogin.aspx");
            }
            else
            {
                string SqlStr = "select * from tb_Image"; //查询头像信息表
                //调用EP类中的EXECDropDownList方法将字段ImagePhone中的内容绑定到ddlPhoto控件中
                ep.EXECDropDownList(ddlPhoto, SqlStr, "ImagePhone");
                imgPhoto.ImageUrl = ddlPhoto.SelectedValue;
            }
        }
    }

    protected void ddlPhoto_SelectedIndexChanged(object sender, EventArgs e)
    {
        imgPhoto.ImageUrl = ddlPhoto.SelectedValue;
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        /*清空文本框内容*/
        TxtUserName.Text = ""; //清空用户姓名文本框
        TxtUserPwd.Text = ""; //清空密码文本框
        TxtTruePwd.Text = ""; //清空确认密码文本框
        TxtTrueName.Text = ""; //清空真实姓名文本框
        TxtRetakePwd.Text = ""; //清空取回密码提示文本框
        txtAnswerPassWord.Text = ""; //清空取回密码回答文本框
        TxtAge.Text = ""; //清空年龄文本框
        TxtTel.Text = ""; //清空电话号码文本框
        TxtEmail.Text = ""; //清空Email文本框
        TxtQQ.Text = ""; //清空QQ号码文本框
        TxtAddress.Text = ""; //清空个人地址文本框
        Txthomepage.Text = ""; //清空个人主页文本框
        TxtIntro.Text = ""; //清空个人简介对话框
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        if (TxtUserName.Text == "" && TxtUserPwd.Text == "" && TxtTruePwd.Text == "" && TxtTrueName.Text == "" &&
            TxtRetakePwd.Text == "" && txtAnswerPassWord.Text == "" && TxtAge.Text == "" && TxtTel.Text == "" &&
            TxtEmail.Text == "" && TxtQQ.Text == "" && TxtAddress.Text == "" && Txthomepage.Text == "" &&
            TxtIntro.Text == "")
        {
            //弹出提示对话框,跳转到AdminUser_Add.aspx页面中
            Response.Write("<script lanuage='javaScript'>alert('文本框不能为空！');location='AdminUser_Add.aspx'</script>");
        }
        else
        {
            try
            {
                //使用Insert语句将用户信息插入到tb_UserLogin数据表中
                string InsertStr = "insert into tb_UserLogin values('" + TxtUserName.Text + "','" + TxtUserPwd.Text +
                                   "','" + TxtTruePwd.Text + "','" + DdlRole.SelectedItem.Text + "','" +
                                   TxtTrueName.Text + "','" + TxtRetakePwd.Text + "','" + txtAnswerPassWord.Text + "','" +
                                   ddlSex.SelectedItem.Text + "','" + TxtAge.Text + "','" + TxtTel.Text + "','" +
                                   TxtEmail.Text + "','" + TxtQQ.Text + "','" + TxtAddress.Text + "','" +
                                   Txthomepage.Text + "','" + TxtIntro.Text + "','" + ddlPhoto.SelectedItem.Text + "')";
                //调用EP类中的EXECCommand方法，执行Insert插入语句
                EP.EXECCommand(InsertStr);
                Response.Write(
                    "<script lanuage='javaScript'>alert('恭喜您！！用户添加成功！');location='AdminUser_Add.aspx'</script>");
                //弹出对话框显示“恭喜您！！用户添加成功！”
            }
            catch
            {
                Response.Write(
                    "<script lanuage='javaScript'>alert('很遗憾！！用户添加失败！');location='AdminUser_Add.aspx'</script>");
                //弹出对话框显示“很遗憾！！用户添加失败！”
            }
        }
    }
}
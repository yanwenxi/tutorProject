using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminUser_AdminUser_Delete : Page
{
    private readonly EP ep = new EP(); //实例化对象

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //使用Session判断管理员是否已成功登录
            if (Session["AdminUserName"] == null && Session["AdminPassWord"] == null)
            {
                Response.Redirect("~/AdminLogin.aspx");
            }
            else
            {
                string SqlStr = "select * from tb_image"; //查询头像
                ep.EXECDropDownList(ddlPhoto, SqlStr, "ImagePhone");
                if (Request["UserId"] != null)
                {
                    DataSet ds = ep.ReturnDataSet(
                        "select * from tb_UserLogin where UserId='" + Request["UserId"] + "'", "tb_UserLogin");
                    DataRowView rv = ds.Tables["tb_UserLogin"].DefaultView[0];
                    TxtUserName.Text = rv["UserName"].ToString();
                    DdlRole.SelectedItem.Text = rv["role"].ToString();
                    TxtTrueName.Text = rv["TrueName"].ToString();
                    TxtRetakePwd.Text = rv["RetakePassword"].ToString();
                    txtAnswerPassWord.Text = rv["AnswerPassWord"].ToString();

                    ddlSex.SelectedValue = rv["sex"].ToString();
                    TxtAge.Text = rv["Age"].ToString();
                    TxtTel.Text = rv["phone"].ToString();
                    TxtEmail.Text = rv["Email"].ToString();
                    TxtQQ.Text = rv["QQ"].ToString();
                    TxtAddress.Text = rv["Address"].ToString();
                    Txthomepage.Text = rv["homepage"].ToString();
                    TxtIntro.Text = rv["Intro"].ToString();
                    imgPhoto.ImageUrl = rv["image"].ToString();
                }
            }
        }
    }

    protected void ddlPhoto_SelectedIndexChanged(object sender, EventArgs e)
    {
        imgPhoto.ImageUrl = ddlPhoto.SelectedValue;
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlUpdate = "Delete from tb_UserLogin  where UserId='" + Request["UserId"] + "'";
            EP.EXECCommand(SqlUpdate);
            Response.Write("<script lanuage='javaScript'>alert('恭喜您！！用户信息修改成功！');location='AdminUser.aspx'</script>");
            //弹出对话框显示“恭喜您！！用户信息修改成功！”
        }
        catch
        {
            Response.Write("<script lanuage='javaScript'>alert('很遗憾！！用户信息修改失败！');location='AdminUser.aspx'</script>");
            //弹出对话框显示“很遗憾！！用户信息修改失败！”
        }
    }

    protected void BtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminUser.aspx");
    }
}
using System;
using System.Web.UI;

//引入命名空间
public partial class AdminTools_AdminTools_Add : Page
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
                string SqlStr = "select * from tb_uptools"; //查询下载工具
                ep.EXECDropDownList(DDLTools, SqlStr, "tools");
                string SqlLb = "select * from tb_leibie"; //查询类别信息表
                ep.EXECDropDownList(ddllb, SqlLb, "name");
                string Sql = "select * from tb_toolsimage"; //查询头像信息表
                ep.EXECDropDownList(DDlToolsImage, Sql, "image");
                ImgSoft.ImageUrl = DDlToolsImage.SelectedValue;
            }
        }
    }

    protected void DDLTools_SelectedIndexChanged(object sender, EventArgs e)
    {
        ImgSoft.ImageUrl = DDlToolsImage.SelectedValue;
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        if (TxtName.Text == "" || TxtEdition.Text == "" || TxtCondition.Text == "" || TxtPrice.Text == "" ||
            TxtIntroEdition.Text == "" || TxtPoint.Text == "" || TxtSize.Text == "" || TxtTime.Text == "" ||
            TxtIntro.Text == "")
        {
            Response.Write("<script lanuage='javaScript'>alert('文本框不能为空！');location='AdminTools_Add.aspx'</script>");
        }
        else
        {
            try
            {
                String SqlInsert = "Insert tb_tools values ('" + TxtName.Text + "','" + TxtEdition.Text + "','" +
                                   TxtCondition.Text + "','" + TxtPrice.Text + "','" + TxtIntroEdition.Text + "','" +
                                   ddllb.SelectedItem.Text + "' ,'" + ddlType.SelectedItem.Text + "','" + TxtPoint.Text +
                                   "','" + TxtSize.Text + "','" + TxtTime.Text + "','" + TxtIntro.Text + "' ,'" +
                                   DDlToolsImage.SelectedItem.Text + "','" + DDLTools.SelectedItem.Text + "')";
                EP.EXECCommand(SqlInsert);
                Response.Write(
                    "<script lanuage='javaScript'>alert('恭喜您！！工具软件添加成功！');location='AdminTools.aspx'</script>");
                //弹出对话框显示“恭喜您！！工具软件修改成功！”
            }
            catch
            {
                Response.Write(
                    "<script lanuage='javaScript'>alert('很遗憾！！工具软件添加失败！');location='AdminTools.aspx'</script>");
                //弹出对话框显示“很遗憾！！工具软件修改失败！”
            }
        }
    }

    protected void LinBtnPhoto_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javaScript'>location='AdminDownloadImage.aspx'</script>");
    }

    protected void LinAddsoftMend_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript'>location='AdminDownloadAdd.aspx'</script>");
    }
}
using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminTools : Page
{
    private readonly EP ep = new EP();

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
                string Sql = "select * from tb_toolsimage"; //查询头像信息表
                ep.EXECDropDownList(DDlToolsImage, Sql, "image");
                ImgSoft.ImageUrl = DDlToolsImage.SelectedValue;
                if (Request["id"] != null)
                {
                    DataSet ds = ep.ReturnDataSet("select * from tb_tools where id='" + Request["id"] + "'", "tb_tools");
                    DataRowView rv = ds.Tables["tb_tools"].DefaultView[0];
                    TxtName.Text = rv["Name"].ToString();
                    TxtEdition.Text = rv["Edition"].ToString();
                    TxtCondition.Text = rv["Condition"].ToString();
                    TxtPrice.Text = rv["Price"].ToString();
                    TxtIntroEdition.Text = rv["EditionIntro"].ToString();
                    Txtleibie.Text = rv["LeiBie"].ToString();
                    ddlType.SelectedItem.Text = rv["Type"].ToString();
                    TxtSize.Text = rv["ToolSize"].ToString();
                    TxtPoint.Text = rv["point"].ToString();
                    TxtTime.Text = Convert.ToDateTime(rv["UpTime"].ToString()).ToShortDateString();
                    TxtIntro.Text = rv["Intro"].ToString();
                    DDLTools.SelectedItem.Text = rv["download"].ToString();
                    ImgSoft.ImageUrl = rv["Image"].ToString();
                }
            }
        }
    }

    protected void DDLTools_SelectedIndexChanged(object sender, EventArgs e)
    {
        ImgSoft.ImageUrl = DDlToolsImage.SelectedValue;
    }

    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlUpdate = "Update tb_tools set Name='" + TxtName.Text + "',Edition='" + TxtEdition.Text +
                               "',Condition='" + TxtCondition.Text + "',Price='" + TxtPrice.Text + "',EditionIntro='" +
                               TxtIntroEdition.Text + "',LeiBie='" + Txtleibie.Text + "' ,type='" +
                               ddlType.SelectedItem.Text + "',Point='" + TxtPoint.Text + "',ToolSize='" + TxtSize.Text +
                               "',UpTime='" + TxtTime.Text + "', Intro='" + TxtIntro.Text + "' ,Image='" +
                               DDlToolsImage.SelectedItem.Text + "',download='" + DDLTools.SelectedItem.Text +
                               "' where id='" + Request["id"] + "'";
            EP.EXECCommand(SqlUpdate);
            Response.Write("<script lanuage='javaScript'>alert('恭喜您！！工具软件修改成功！');location='AdminTools.aspx'</script>");
            //弹出对话框显示“恭喜您！！工具软件修改成功！”
        }
        catch
        {
            Response.Write("<script lanuage='javaScript'>alert('很遗憾！！工具软件修改失败！');location='AdminTools.aspx'</script>");
            //弹出对话框显示“很遗憾！！工具软件修改失败！”
        }
    }
}
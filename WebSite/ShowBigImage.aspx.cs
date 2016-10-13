using System;
using System.Data;
using System.Web.UI;

public partial class Default2 : Page
{
    private readonly EP ep = new EP();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["id"] == null)
        {
            Response.Write("没有大图片");
        }
        else
        {
            string id = Request["id"]; //接收Default.aspx页面传递过来的“id”值
            DataSet ds1 = null;
            ds1 = ep.ReturnDataSet("select * from tb_tools where id='" + Request["id"] + "'", "tb_tools");
            DataRowView rv1 = ds1.Tables["tb_tools"].DefaultView[0];
            Image1.ImageUrl = rv1["Image"].ToString();
        }
    }

    protected void LinBtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx"); //跳转到网站首页面中
    }
}
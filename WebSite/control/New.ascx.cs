using System;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class control_New : UserControl
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        ep.EXECDataList(DlNew, "select top 5 * from tb_New order by PublishTime desc", "Id"); //显示网站新闻
    }

    protected void DlNew_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        string IdNew = DlNew.DataKeys[e.Item.ItemIndex].ToString();
        Response.Redirect("DefaultNewPage.aspx?newid=" + IdNew + "");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("MoreNew.aspx");
    }
}
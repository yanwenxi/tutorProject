using System;
using System.Data;
using System.Web.UI;

public partial class GameImage : UserControl
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = null;
        ds = ep.ReturnDataSet("select  * from tb_Tools order by UPTime desc", "tb_Tools");
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
}
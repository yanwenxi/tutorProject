using System;
using System.Web.UI;

public partial class HyperlinkControl : UserControl
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        string str = "select top 4 * from tb_FriendLink order by id desc";
        ep.EXECDataList1(DataList1, str);
    }
}
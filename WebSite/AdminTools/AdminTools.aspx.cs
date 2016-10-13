using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class AdminTools : Page
{
    private EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        //使用Session判断管理员是否已成功登录
        if (Session["AdminUserName"] == null && Session["AdminPassWord"] == null)
        {
            //如果没登录将页面跳转到＂AdminLogin.aspx＂页面中
            Response.Redirect("~/AdminLogin.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                bindDataList(); //调用自定义方法
            }
        }
    }

    protected void lnkbtnOne_Click(object sender, EventArgs e)
    {
        labPage.Text = "1"; //将“1”赋值给labPage控件当中
        bindDataList(); //调用用户自定义bindDataList方法
    }

    protected void lnkbtnUp_Click(object sender, EventArgs e)
    {
        labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) - 1);
        bindDataList(); //调用用户自定义bindDataList方法
    }

    protected void lnkbtnNext_Click(object sender, EventArgs e)
    {
        labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) + 1);
        bindDataList(); //调用用户自定义bindDataList方法
    }

    protected void lnkbtnBack_Click(object sender, EventArgs e)
    {
        labPage.Text = labBackPage.Text;
        bindDataList(); //调用用户自定义bindDataList方法
    }

    protected void dlContent_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string ID = dlContent.DataKeys[e.Item.ItemIndex].ToString();
        string sqlstr = "delete from tb_tools where ID='" + Convert.ToInt32(ID) + "'";
        EP.EXECCommand(sqlstr); //执行删除语句
        bindDataList();
    }

    protected void dlContent_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        ((LinkButton) e.Item.Controls[0].FindControl("LinkButton1")).Attributes.Add("onclick",
                                                                                    "return confirm('确定要删除吗？')");
    }

    protected void dlContent_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "update")
        {
            string id = dlContent.DataKeys[e.Item.ItemIndex].ToString().Trim();

            Response.Redirect("AdminTools_update.aspx?id=" + id + ""); //跳转到AdminTools_update.aspx页面当中
        }
    }

    protected void LinBtnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminTools_Add.aspx"); //跳转到AdminTools_Add.aspx页面中
    }

    #region 用户自定义bindDataList方法

    /// <summary>
    ///   该方法在DataList控件中实现分页功能
    /// </summary>
    public void bindDataList()
    {
        //将labPage控件显示的页数赋值给整型变量curpage中
        int curpage = Convert.ToInt32(labPage.Text);
        PagedDataSource ps = new PagedDataSource(); //实例化一个PagedDataSource类对象
        SqlConnection con = new SqlConnection(EP.GetConStr()); //连接数据库
        con.Open(); //打开数据库连接
        string sqlstr = "select * from tb_tools";
        SqlDataAdapter MyAdapter = new SqlDataAdapter(sqlstr, con);
        DataSet ds = new DataSet(); //实例化一个对象
        MyAdapter.Fill(ds, "tb_tools");
        ps.DataSource = ds.Tables["tb_tools"].DefaultView;
        ps.AllowPaging = true; //是否可以分页
        ps.PageSize = 2; //显示的数量
        ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
        lnkbtnUp.Enabled = true; //显示上一页按钮
        lnkbtnNext.Enabled = true; //显示下一页按钮
        lnkbtnBack.Enabled = true; //显示最后一页按钮
        lnkbtnOne.Enabled = true; //显示第一页按钮
        if (curpage == 1)
        {
            lnkbtnOne.Enabled = false; //不显示第一页按钮
            lnkbtnUp.Enabled = false; //不显示上一页按钮
        }
        if (curpage == ps.PageCount)
        {
            lnkbtnNext.Enabled = false; //不显示下一页按钮
            lnkbtnBack.Enabled = false; //不显示最后一页按钮
        }
        labBackPage.Text = Convert.ToString(ps.PageCount); //将分页的总页数赋值给labBackPage控件中
        dlContent.DataSource = ps; //在dlContent控件中绑定ps分页数据源
        dlContent.DataKeyField = "ID"; //将主键传递给dlContent控件中
        dlContent.DataBind(); //将数据源绑定到dbContent控件中
        con.Close(); //关闭数据库连接
    }

    #endregion
}
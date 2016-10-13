using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class Admintouxiang : Page
{
    private EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        //使用Session判断管理员是否已成功登录
        if (!IsPostBack)
        {
            if (Session["AdminUserName"] == null && Session["AdminPassWord"] == null)
            {
                Response.Redirect("~/AdminLogin.aspx");
            }
            else
            {
                bindDataList(); //调用用户自定义方法
            }
        }
    }

    public void bindDataList() //用户自定义方法实现分页
    {
        int curpage = Convert.ToInt32(labPage.Text);
        PagedDataSource ps = new PagedDataSource();
        SqlConnection con = new SqlConnection(EP.GetConStr());
        con.Open();
        string sqlstr = "select * from tb_image";
        SqlDataAdapter MyAdapter = new SqlDataAdapter(sqlstr, con);
        DataSet ds = new DataSet();
        MyAdapter.Fill(ds, "tb_image");
        ps.DataSource = ds.Tables["tb_image"].DefaultView;
        ps.AllowPaging = true; //是否可以分页
        ps.PageSize = 8; //显示的数量
        ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
        lnkbtnUp.Enabled = true;
        lnkbtnNext.Enabled = true;
        lnkbtnBack.Enabled = true;
        lnkbtnOne.Enabled = true;
        if (curpage == 1)
        {
            lnkbtnOne.Enabled = false; //不显示第一页按钮
            lnkbtnUp.Enabled = false; //不显示上一页按钮
        }
        if (curpage == ps.PageCount)
        {
            lnkbtnNext.Enabled = false; //不显示下一页
            lnkbtnBack.Enabled = false; //不显示最后一页
        }
        labBackPage.Text = Convert.ToString(ps.PageCount);
        dlTouxiang.DataSource = ps;
        dlTouxiang.DataKeyField = "ID";
        dlTouxiang.DataBind();
        con.Close();
    }

    protected void lnkbtnOne_Click(object sender, EventArgs e)
    {
        labPage.Text = "1"; //将“1”赋值给labPage控件当中
        bindDataList(); //调用用户自定义bindDataList方法
    }

    protected void lnkbtnUp_Click(object sender, EventArgs e)
    {
        labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) - 1);
        bindDataList();
    }

    protected void lnkbtnNext_Click(object sender, EventArgs e)
    {
        labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) + 1);
        bindDataList();
    }

    protected void lnkbtnBack_Click(object sender, EventArgs e)
    {
        labPage.Text = labBackPage.Text;
        bindDataList();
    }

    protected void dlTouxiang_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        //获取主键字段的字段值，并且将获取的字段的值赋值给变量ID中
        string ID = dlTouxiang.DataKeys[e.Item.ItemIndex].ToString();
        string sqlstr = "delete from tb_image where id='" + Convert.ToInt32(ID) + "'";
        EP.EXECCommand(sqlstr); //调用EP类的EXECCommand方法执行删除语句
        bindDataList(); //调用用户自定义bindDataList方法
    }

    protected void dlTouxiang_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        ((LinkButton) e.Item.Controls[0].FindControl("LinBtnDelete")).Attributes.Add("onclick",
                                                                                     "return confirm('确定要删除吗？')");
    }
}
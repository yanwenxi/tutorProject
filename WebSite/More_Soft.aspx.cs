using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

//引入命名空间
public partial class MoreSoft : Page
{
    private EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //判断用户是否登录，如果没登录跳转到登录页面中
            if (Session["UserName"] == null && Session["UserPwd"] == null)
            {
                //弹出对话框显示“对不起！您还没有登录”提示信息，并且将页面跳转到用户登录页面中
                Response.Write("<script lanuage='javaScript'>alert('对不起！您还没有登录！');location='UserLogin.aspx'</script>");
            }
            else
            {
                bindDataList(); //调用自定义方法
            }
        }
    }

    public void bindDataList()
    {
        int curpage = Convert.ToInt32(labPage.Text);
        PagedDataSource ps = new PagedDataSource();
        SqlConnection con = new SqlConnection(EP.GetConStr());
        con.Open();
        string sqlstr = "select * from tb_tools";
        SqlDataAdapter MyAdapter = new SqlDataAdapter(sqlstr, con);
        DataSet ds = new DataSet();
        MyAdapter.Fill(ds, "tb_tools");
        ps.DataSource = ds.Tables["tb_tools"].DefaultView;
        ps.AllowPaging = true; //是否可以分页
        ps.PageSize = 2; //显示的数量
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
        dlContent.DataSource = ps;
        dlContent.DataKeyField = "ID";
        dlContent.DataBind();
        con.Close();
    }

    protected void lnkbtnOne_Click(object sender, EventArgs e)
    {
        labPage.Text = "1";
        bindDataList();
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

    protected void dlContent_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string ID = dlContent.DataKeys[e.Item.ItemIndex].ToString(); //获取当前DataList控件列
        string sqlstr = "delete from tb_tools where ID='" + Convert.ToInt32(ID) + "'";
        SqlConnection con = new SqlConnection(EP.GetConStr());
        SqlCommand com = new SqlCommand(sqlstr, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        bindDataList();
    }

    protected void dlContent_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //((LinkButton)e.Item.Controls[0].FindControl("LinkButton1")).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
    }

    //protected void dlContent_UpdateCommand(object source, DataListCommandEventArgs e)
    //{

    //}
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminTools_Add.aspx"); //跳转到AdminTools_Add.aspx页面中
    }

    protected void dlContent_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "SoftXiangxi")
        {
            string SoftXiangxi = dlContent.DataKeys[e.Item.ItemIndex].ToString().Trim();

            Response.Redirect("aa.aspx?SoftXiangxi=" + SoftXiangxi + ""); //跳转到List_softdownload.aspx页面当中
        }
    }
}
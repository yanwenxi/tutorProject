using System;
using System.Web.UI;

public partial class Module_Admin_Findpwd : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Random ran = new Random();
            labVial.Text = ran.Next(1000, 9999).ToString();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtVali.Text = "";
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (txtVali.Text == labVial.Text)
        {
            Session["UserName"] = txtName.Text;
            Page.Response.Redirect("Findpwd.aspx");
        }
        else
        {
            Response.Write(
                "<script language=javascript>alert('您输入的信息不正确，请重新输入！');location='javascript:history.go(-1)'</script>");
        }
    }
}
﻿using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminFriendLink_Delete : Page
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
            if (Request["id"] != null)
            {
                DataSet ds = ep.ReturnDataSet("select * from tb_FriendLink where id='" + Request["id"] + "'",
                                              "tb_FriendLink");
                DataRowView rv = ds.Tables["tb_FriendLink"].DefaultView[0];
                TxtId.Text = rv["id"].ToString();
                TxtTime.Text = Convert.ToDateTime(rv["AddTime"].ToString()).ToShortDateString();
                txtAddress.Text = rv["LinkAddress"].ToString();
                imgPhoto.ImageUrl = rv["LinkImage"].ToString();
            }
        }
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlDelete = "Delete from tb_FriendLink where id='" + TxtId.Text + "'";
            EP.EXECCommand(SqlDelete);
            Response.Write(
                "<script lanuage='javaScript'>alert('恭喜您！！友情链接信息删除成功！');location='AdminFriendLink.aspx'</script>");
            //弹出对话框显示“恭喜您！！友情链接信息删除成功！”
        }
        catch
        {
            Response.Write(
                "<script lanuage='javaScript'>alert('很遗憾！！友情链接信息删除失败！');location='AdminFriendLink.aspx'</script>");
            //弹出对话框显示“很遗憾！！友情链接信息删除失败！”
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminFriendLink.aspx");
    }
}
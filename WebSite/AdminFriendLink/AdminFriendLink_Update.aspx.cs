﻿using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminFriendLink_Update : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //使用Session判断管理员是否已成功登录
            if (Session["AdminUserName"] == null && Session["AdminPassWord"] == null)
            {
                Response.Redirect("~/AdminLogin.aspx");
            }
            else
            {
                string SqlStr = "select * from tb_FriendLink"; //查询头像信息表
                ep.EXECDropDownList(ddlPhoto, SqlStr, "LinkImage");
                imgPhoto.ImageUrl = ddlPhoto.SelectedValue;

                if (Request["id"] != null)
                {
                    DataSet ds = ep.ReturnDataSet("select * from tb_FriendLink where id='" + Request["id"] + "'",
                                                  "tb_FriendLink");
                    DataRowView rv = ds.Tables["tb_FriendLink"].DefaultView[0];
                    TxtTime.Text = Convert.ToDateTime(rv["AddTime"].ToString()).ToShortDateString();
                    txtAddress.Text = rv["LinkAddress"].ToString();
                    imgPhoto.ImageUrl = rv["LinkImage"].ToString();
                }
            }
        }
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlUpdate = "Update tb_FriendLink set AddTime='" + TxtTime.Text + "',LinkAddress='" + txtAddress.Text +
                               "',LinkImage='" + ddlPhoto.Text + "' where id='" + Request["id"] + "'";
            EP.EXECCommand(SqlUpdate);
            Response.Write(
                "<script lanuage='javaScript'>alert('恭喜您！！友情链接信息修改成功！');location='AdminFriendLink.aspx'</script>");
            //弹出对话框显示“恭喜您！！友情链接信息修改成功！”
        }
        catch
        {
            Response.Write(
                "<script lanuage='javaScript'>alert('很遗憾！！友情链接信息修改失败！');location='AdminFriendLink.aspx'</script>");
            //弹出对话框显示“很遗憾！！友情链接信息修改失败！”
        }
    }

    protected void ddlPhoto_SelectedIndexChanged(object sender, EventArgs e)
    {
        imgPhoto.ImageUrl = ddlPhoto.SelectedValue;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminFriendLink.aspx");
    }
}
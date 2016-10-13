﻿using System;
using System.Data;
using System.Web.UI;

//引入命名空间
public partial class AdminOpration_AdminGongGao_Update : Page
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
            if (!IsPostBack)
            {
                if (Request["id"] != null)
                {
                    DataSet ds = ep.ReturnDataSet("select * from tb_GongGao where id='" + Request["id"] + "'",
                                                  "tb_gonggao");
                    DataRowView rv = ds.Tables["tb_GongGao"].DefaultView[0];
                    Txtid.Text = rv["id"].ToString();
                    TextBox1.Text = rv["title"].ToString();
                    TextBox2.Text = rv["content"].ToString();
                    TextBox3.Text = Convert.ToDateTime(rv["GTime"].ToString()).ToShortDateString();
                }
            }
        }
    }

    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            String SqlUpdate = "Update tb_GongGao set title='" + TextBox1.Text + "',content='" + TextBox2.Text +
                               "'where id='" + Txtid.Text + "'";
            EP.EXECCommand(SqlUpdate);
            Response.Write("<script lanuage='javaScript'>alert('恭喜您！！公告信息修改成功！');location='AdminGongGao.aspx'</script>");
            //弹出对话框显示“恭喜您！！公告信息修改成功！”
        }
        catch
        {
            Response.Write("<script lanuage='javaScript'>alert('很遗憾！！公告信息修改失败！');location='AdminGongGao.aspx'</script>");
            //弹出对话框显示“很遗憾！！公告信息修改失败！”
        }
    }

    protected void BtnCheck_Click(object sender, EventArgs e)
    {
        if (Txtid.Text == "")
        {
            Response.Write("<script lanuage='javaScript'>alert('公告编号不能为空！');location='AdminGongGao_Add.aspx'</script>");
        }
        else
        {
            string SqlStr = "select count(*) from tb_GongGao where id='" + Txtid.Text + "'";
            int a = ep.EXECuteScalar(SqlStr);
            if (a >= 1)
            {
                //弹出对话框显示“公告编号已存在，请在添加一个！”
                Response.Write(
                    "<script lanuage='javaScript'>alert('公告编号已存在，请在添加一个！');location='AdminGongGao_Add.aspx'</script>");
            }
            else
            {
                //弹出对话框显示“公告编号不存在，你可以继续添加其他信息！”
                Response.Write(
                    "<script lanuage='javaScript'>alert('公告编号不存在，你可以继续添加其他信息！');location='AdminGongGao_Add.aspx'</script>");
            }
        }
    }

    protected void LinBtnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminGongGao.aspx");
    }
}
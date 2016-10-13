﻿using System;
using System.Web.UI;

//引入命名空间
public partial class User_Reg : Page
{
    private readonly EP ep = new EP(); //实例化一个对象

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string SqlStr = "select * from tb_Image"; //查询头像信息表
            //调用ep类对象的EXECDropDownList方法,将ImagePhone字段绑定到DropDownList控件中
            ep.EXECDropDownList(ddlPhoto, SqlStr, "ImagePhone");
            //将从DropDownList控件中选择的图片路径显示在Image控件中
            imgPhoto.ImageUrl = ddlPhoto.SelectedValue;
        }
    }

    protected void ddlPhoto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //将从DropDownList控件中选择的图片路径显示在Image控件中
        imgPhoto.ImageUrl = ddlPhoto.SelectedValue;
    }

    protected void ImgBtnReg_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //将信息插入到注册登录信息表中
            string InsertStr = "insert into tb_UserLogin values('" + TxtUserName.Text + "','" + TxtUserPwd.Text + "','" +
                               TxtTruePwd.Text + "','" + DdlRole.SelectedItem.Text + "','" + TxtTrueName.Text + "','" +
                               TxtRetakePwd.Text + "','" + txtAnswerPassWord.Text + "','" + ddlSex.SelectedItem.Text +
                               "','" + TxtAge.Text + "','" + TxtTel.Text + "','" + TxtEmail.Text + "','" + TxtQQ.Text +
                               "','" + TxtAddress.Text + "','" + Txthomepage.Text + "','" + TxtIntro.Text + "','" +
                               ddlPhoto.SelectedItem.Text + "')";
            EP.EXECCommand(InsertStr); //调用EP类中的静态EXECCommand方法,执行SQL语句
            //注册成功后弹出对话框,显示"恭喜您！！注册成功！"
            Response.Write("<script lanuage='javaScript'>alert('恭喜您！！注册成功！');location='../Default.aspx'</script>");
            //弹出对话框显示“恭喜您！！注册成功！”
        }
        catch
        {
            //注册失败后弹出对话框,显示"很遗憾！！注册失败！"
            Response.Write("<script lanuage='javaScript'>alert('很遗憾！！注册失败！');location='../Default.aspx'</script>");
            //弹出对话框显示“很遗憾！！注册失败！”
        }
    }

    protected void ImgCz_Click(object sender, ImageClickEventArgs e)
    {
        TxtUserName.Text = "";
        TxtUserPwd.Text = "";
        TxtTruePwd.Text = "";

        TxtTrueName.Text = "";
        TxtRetakePwd.Text = "";
        txtAnswerPassWord.Text = "";

        TxtAge.Text = "";
        TxtTel.Text = "";
        TxtEmail.Text = "";
        TxtQQ.Text = "";
        TxtAddress.Text = "";
        Txthomepage.Text = "";
        TxtIntro.Text = "";
    }
}
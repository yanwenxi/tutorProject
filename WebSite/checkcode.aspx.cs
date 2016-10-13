﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using System.Web.UI;

//引入命名空间

public partial class checkcode : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateCheckCodeImage(GenerateCheckCode()); //输出图片验证码
    }

    private string GenerateCheckCode()
    {
        int number; //定义一个整数类型的变量number
        char code; //定义一个字符类型的变量code
        string checkCode = String.Empty; //定义一个变量，存储验证码字符串
        Random random = new Random(); //实例化Random类对象

        for (int i = 0; i < 4; i++)
        {
            number = random.Next(); //调用Next方法返回一个随机数
            //通过判断生成的随机数的奇偶性确定验证码字符串中的某一位是数字还是字母
            if (number%2 == 0)
                code = (char) ('0' + (char) (number%10));
            else
                code = (char) ('A' + (char) (number%26));

            checkCode += code.ToString(); //组合新的验证码字符串
        }
        //使用Cookie记录生成的验证码字符串
        Response.Cookies.Add(new HttpCookie("CheckCode", checkCode));
        return checkCode;
    }

    private void CreateCheckCodeImage(string checkCode)
    {
        if (checkCode == null || checkCode.Trim() == String.Empty) //判断验证码是否为空
            return;
        Bitmap image = new Bitmap((int) Math.Ceiling((checkCode.Length*12.5)), 22);
        Graphics g = Graphics.FromImage(image);
        try
        {
            //生成随机生成器
            Random random = new Random();
            //清空图片背景色
            g.Clear(Color.White);
            //画图片的背景噪音线
            for (int i = 0; i < 2; i++)
            {
                int x1 = random.Next(image.Width);
                int x2 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int y2 = random.Next(image.Height);
                g.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
            }
            Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height),
                                                                Color.Blue, Color.DarkRed, 1.2f, true);
            g.DrawString(checkCode, font, brush, 2, 2);
            //画图片的前景噪音点
            for (int i = 0; i < 100; i++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);
                image.SetPixel(x, y, Color.FromArgb(random.Next()));
            }
            //画图片的边框线
            g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Gif);
            Response.ClearContent();
            Response.ContentType = "image/Gif";
            Response.BinaryWrite(ms.ToArray());
        }
        finally
        {
            g.Dispose();
            image.Dispose();
        }
    }
}
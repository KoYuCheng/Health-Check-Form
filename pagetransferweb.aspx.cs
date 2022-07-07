using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagetransferweb : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Name = Request.QueryString["Name"];
        string Age = Request.QueryString["Age"];
        string Sex = Request.QueryString["Sex"];
        string Datetime = Request.QueryString["Datetime"];

        string heigh = Request.QueryString["heigh"];
        string weigh = Request.QueryString["weigh"];
        double bmi=0.0,h=0.0,w=0.0; //BMI = 體重(公斤) / 身高2(公尺2)
        string standard;
        if (heigh == "")
        {
            h = 0.0;
        }
        else
        {
            h = double.Parse(heigh) / 100.00;
        }
        if (weigh == "")
        {
            w = 0.0;
        }
        else
        {
            w = double.Parse(weigh);
        }
        bmi = w / (h*h) ;
        string seatstand = Request.QueryString["30s"];
        string seatleft = Request.QueryString["seatleft"];
        string seatright = Request.QueryString["seatright"];
        string bihandleft = Request.QueryString["bihandleft"];
        string bihandright = Request.QueryString["bihandright"];
        string singleleft = Request.QueryString["singleleft"];
        string singleright = Request.QueryString["singleright"];
        string seatwalk = Request.QueryString["seatwalk"];
        //正常: 18.5≦BMI＜24
        if (bmi >= 24) { standard = "(過重)"; }
        else if (bmi < 24 && bmi >= 18.5) { standard = "(正常)"; }
        else { standard = "(過輕)"; }
        Label1.Text = "姓名: " + Name +"<br/>"+
            "年齡: " + Age + "<br/>" +
            "性別: " + Sex + "<br/>" +
            "檢測日期: " + Datetime + "<br/>" +
            "身高: " + heigh + "公分" + "<br/>" +
            "體重: " + weigh + "公斤" + "<br/>" +
            "BMI: " + bmi.ToString("#0.00") + standard + "<br/>" +
            "30秒坐站: " + seatstand + "次" + "<br/>" +
            "坐姿體前彎: 左:" + seatleft + "公分 右:" + seatright + "公分" + "<br/>" +
            "雙手背後相扣: 左:" + bihandleft + "公分 右:" + bihandright + "公分" + "<br/>" +
            "單腳站立: 左:" + singleleft + "秒 右:" + singleright +"秒"+ "<br/>" +
            "2.44M坐走: " + seatwalk + "秒";

    }
}
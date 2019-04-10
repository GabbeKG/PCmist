using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AboutUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlLanguage_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLanguage.SelectedValue == "English")
        {
            lAboutUs.Text = "This site was built by us four students Gabriel, Marcus, Fangkai and Bing, for an assignment given to us by our teacher Petter Dessne." +
    "The websites purpose is to give some minor heads up about games, game reviews and where to get them cheap.";


        }
        if (ddlLanguage.SelectedValue == "Chinese")
        {
            lAboutUs.Text = "本网站由Gabriel, Marcus, Fangkai and Bing四人合力打造，作为Petter Dessne老师布置的作业。" +
"本网站的目的是提供些许关于游戏的建议，评论以及指导玩家低成本玩游戏的方法。";

        }
    }
}
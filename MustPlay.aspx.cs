using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MustPlay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlLanguage_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLanguage.SelectedValue == "English")
        { 
        lContent.Text=
"<br /><h1>Shadow of Mordor</h1><br />"+
"Middle-earth: Shadow of Mordor is an action-packed adventure-RPG inspired by J.R.R. Tolkien's The Hobbit and The Lord of the Rings.<br /> "+
"Exploring an original story of vengeance and redemption, the game puts players in the role of Talion, <br />" +
"a valiant ranger whose family is slain in front of him the night Sauron and his army return to Mordor -- moments before his own life is taken.<br />" +
"Resurrected by a Spirit of vengeance and empowered with Wraith abilities,<br />" +
"Talion ventures into Mordor and vows to destroy those who have wronged him.<br />" +
"Through the course of his personal vendetta, Talion uncovers the truth of the Spirit that compels him,<br />" +
"learns the origins of the Rings of Power and ultimately confronts his true nemesis.<br /><br />" +

"Dota 2<br /><br />" +

"Dota 2 is a MOBA(Multiplayer online battle arena) game that was develop by the company Valve <br />" +
"and is based on the Warcraft 3 mod Dota(Defenders of the ancient).<br />" +
"You play in a team with 4 other people and everyone got to choose a hero to play.<br />" +
"The main objective is to take down the opponents throne(the ancient),<br />" +
"to do that your team needs to take down all the outer towers to get to the throne.<br /><br />" +

"World of Warcraft<br /><br />" +
"Wow(world of Warcraft) is a mmorpg(massive multiplayer online role playing game) that is develop by the company Blizzard.<br />" +
"You start out as a level 1 character that you make, you will have to choose which class you want to play as,<br />" +
"and there are a few different classes like Warrior, Druid or Paladin.<br />" +
"You kill monsters and complete quests to gain experience points to gain levels.<br />" +
"At max level you can choose to play against other players in PvP(Player versus Player) battlegrounds <br />" +
"or you can play against the computer with other people in PvE (Player versus environment).<br />" +
"The main goal is to get the best equipment and earn all the achievements in the game.  <br />";
        }
        if (ddlLanguage.SelectedValue == "Chinese")
        {
            lContent.Text = "Shadow of Mordor <br />" +
                "《中土世界：暗影魔多》 是一款充满激情的冒险性角色扮演游戏，灵感源于J.R.R 托尔金的 <br />" +
                "《霍比特人》和《指环王》。本游戏的玩家将 通过主角塔里昂（Talion）的视角来探寻复仇和 <br />" +
                "救赎的起源。主角塔里昂是一名游侠，在索伦和他的军队回归魔多之夜，塔里昂一家被杀害。<br />" +
                "然而强大的精灵王复活了塔里昂并且赋予他亡灵之力，塔里昂冒险进入魔多，发誓要毁灭所有 <br />" +
                "伤害他的人。在为他家族复仇的同时，塔里昂也解开了精灵王的身世之谜，学会了魔戒之力并 <br />" +
                "最终实现了复仇。<br /><br />"+

                "《刀塔2》是一款多人在线竞技游戏，脱离了其上一代作品《刀塔（守卫传承者）》所依赖的<br />"+
                "《魔兽争霸Ⅲ》的引擎，由美国Valve公司开发。<br />"+
                "玩家将会和另外四位玩家组队，并且每个人都要选择一个英雄去游戏。<br />" +
                "游戏的主要目的是摧毁对手的王座，在此之前玩家团队必须要先摧毁所有的外塔才能接近王 <br />" +
                "座。<br /><br />"+

                "《魔兽世界》是一款大型多人在线角色扮演游戏，由游戏公司暴雪娱乐制作。<br />"+
                "玩家以一个1级人物开始游戏， 游戏里有不同的职业可以选择，比如：战士，祭司或者骑士。<br />"+
                "玩家以杀死怪兽完成任务的形式获得经验并升级。<br />"+
                "满级之后玩家可以选择进行玩家之间的对决或者人机对决。<br />"+
                "游戏的主要目的是获得最好装备和完成所有成就 <br /><br />"
                
                ;

                
                
        }
    }
}
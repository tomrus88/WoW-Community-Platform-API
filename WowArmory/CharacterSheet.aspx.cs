using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCPAPI;

public partial class character_sheet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void PrintData()
    {
        var realm = Request.QueryString["r"];
        var name = Request.QueryString["c"];

        if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(realm))
        {
            Response.Write("Unknown realm or character name!");
            return;
        }

        var character = CharacterInfo.Get("eu", realm, name);

        Response.Write("<table style=\"width:100%;\">");

        Response.Write(
            "<tr>" +
                "<th>Instance</th>" +
                "<th>Boss</th>" +
                "<th>Kills (N/H)</th>" +
            "</tr>");

        for (var i = 0; i < character.Progression.Count; ++i)
        {
            for (var j = 0; j < character.Progression.Raids[i].bosses.Count; ++j)
            {
                Response.Write(
                "<tr>" +
                    "<td>" + character.Progression.Raids[i].name + "</td>" +
                    "<td>" + character.Progression.Raids[i].bosses[j].name + "</td>" +
                    "<td>" + character.Progression.Raids[i].bosses[j].normalKills + "/" + character.Progression.Raids[i].bosses[j].heroicKills + "</td>" +
                "</tr>"
                );
            }
        }

        Response.Write("</table");
    }
}

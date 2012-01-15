using System;
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

        var character = new ApiClient("eu").GetCharacter(realm, name, CharacterFields.Progression);

        Response.Write("<table style=\"width:100%;\">");

        Response.Write(
            "<tr>" +
                "<th>Instance</th>" +
                "<th>Boss</th>" +
                "<th>Kills (N/H)</th>" +
            "</tr>");

        for (var i = 0; i < character.Progression.Raids.Length; ++i)
        {
            for (var j = 0; j < character.Progression.Raids[i].Bosses.Length; ++j)
            {
                Response.Write(
                "<tr>" +
                    "<td>" + character.Progression.Raids[i].Name + "</td>" +
                    "<td>" + character.Progression.Raids[i].Bosses[j].Name + "</td>" +
                    "<td>" + character.Progression.Raids[i].Bosses[j].NormalKills + "/" + character.Progression.Raids[i].Bosses[j].HeroicKills + "</td>" +
                "</tr>"
                );
            }
        }

        Response.Write("</table");
    }
}

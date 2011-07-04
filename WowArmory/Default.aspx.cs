using System;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var realm = TextBox1.Text;
        var name = TextBox2.Text;

        if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(realm))
            return;

        Response.Redirect("CharacterSheet.aspx?c=" + name + "&r=" + realm);
    }
}

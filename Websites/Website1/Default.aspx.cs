using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        notALabel.Text = "Give up on your hopes and aspirations, sleeping is better";
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        notALabel.Text = "Hello, " + TextBoxName.Text + "!";
    }

    protected void ButtonToUpper_Click(object sender, EventArgs e)
    {
        string buf = TextBoxEnter.Text;
        changed_text.InnerHtml = buf.ToUpper();
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        string str = "";

        str += TextBoxPerson.Text + "<br />";
        str += TextBoxStreet.Text + "<br />";
        str += TextBoxCity.Text + "<br />";
        str += TextBoxState.Text + "<br />";
        displayRow.InnerHtml = str;
    }
}
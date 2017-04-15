using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Initial Label prompting the user to enter their name
        Label.Text = "Please Enter Your Name";
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        //On the click of the submition button, the text is pushed to the blank label box where their name will be stored
        UpdateLabel.Text = "Hello, " + textName.Text;
        //Clears the text box to make things look better
        textName.Text = string.Empty;
    }
}
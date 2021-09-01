using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wba.Querystrings.Web
{
    public partial class Welkom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString.ToString()))
            {
                string naam = Request.QueryString["naam"].ToString();
                string geslacht = Request.QueryString["geslacht"].ToString().ToUpper();
                string taalcode = Request.QueryString["taal"].ToString().ToUpper();

                // alternatief
                //string naam = Request.QueryString[0].ToString();
                //string geslacht = Request.QueryString[1].ToString();
                //string taalcode = Request.QueryString[2].ToString();

                if(geslacht == "MAN")
                {

                    if (taalcode == "FR")
                        lblWelkom.Text = "Bonjour Monsieur ";
                    else if (taalcode == "EN")
                        lblWelkom.Text = "Good day Mr ";
                    else if (taalcode == "DU")
                        lblWelkom.Text = "Guten Tag Herr ";
                    else if (taalcode == "IT")
                        lblWelkom.Text = "Buongiorno signor ";
                    else if (taalcode == "SP")
                        lblWelkom.Text = "Buen día señor ";
                    else
                        lblWelkom.Text = "Goeiedag mijnheer ";
                }
                else
                {
                    if (taalcode == "FR")
                        lblWelkom.Text = "Bonjour Mme ";
                    else if (taalcode == "EN")
                        lblWelkom.Text = "Good day Mrs ";
                    else if (taalcode == "DU")
                        lblWelkom.Text = "Guten Tag Frau ";
                    else if (taalcode == "IT")
                        lblWelkom.Text = "Buongiorno signora ";
                    else if (taalcode == "SP")
                        lblWelkom.Text = "Buen día Sra ";
                    else
                        lblWelkom.Text = "Goeiedag mevrouw ";
                }
                lblWelkom.Text += naam;

            }

        }
    }
}
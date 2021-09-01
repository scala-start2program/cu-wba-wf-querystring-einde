using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wba.Querystrings.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerder_Click(object sender, EventArgs e)
        {
            string naam = txtNaam.Text.Trim();
            string geslacht = cmbGeslacht.SelectedValue;
            string taal = cmbTaal.SelectedValue;

            string parameter = $"?naam={naam}&geslacht={geslacht}&taal={taal}";
            Response.Redirect("welkom.aspx" + parameter);
        }
    }
}
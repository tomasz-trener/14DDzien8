﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AplikacjaWebowa
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPolicz_Click(object sender, EventArgs e)
        {
            int wynik= Convert.ToInt32(txtLiczba1.Text) + Convert.ToInt32(txtLiczba2.Text);
            lblWynik.Text = Convert.ToString(wynik);
        }
    }
}
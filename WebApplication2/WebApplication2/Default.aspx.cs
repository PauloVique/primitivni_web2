﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal1.Text = "Verze webu1: "+System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
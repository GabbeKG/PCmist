using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lwelcome.Text = "<h1>Welcome</h1><br />" +

"<p>To PC Mist! Here you will find some brief information about different games <br />" +

" and where to get the best information for cheap games and from reviewers!</p>";
    }
}
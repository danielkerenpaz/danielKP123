using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    public string stResult = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string email = Request.Form["email2"]; //form:name 
            string pass = Request.Form["pass"];


            // בדיקת משתמש רגיל
            string sqlSelect =
                "SELECT * FROM tUsers " +
                "WHERE Email = N'" + email + "' " +
                "AND UserPassword = N'" + pass + "'";

            bool userExists = MyAdoHelper.IsExist(sqlSelect);

            if (!userExists)
                stResult = "אימייל או סיסמה שגויים";
            else
                stResult = "משתמש רשום";

        }
    }
}
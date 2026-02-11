using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    public string stResult = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string FirstName = Request.Form["FirstName"];
            string LastName = Request.Form["LastName"];
            string Email = Request.Form["Email"];
            string Password = Request.Form["Password"];
            string Age = Request.Form["Age"];


            /*
            //האם המשתמש קיים?
            //לפי אימייל
            //אם לא קיים
            //עושים ISERTR
            //ובמקום לכתוב נרשמת בהצלחה
            //Response.Redirect("login.aspx");
            //אם קיים
            //stResult="המשתמש קיים"
            */

            string sqlInsert =
                "INSERT INTO tUsers  " +
                "VALUES (" +
                "N'" + FirstName + "', " +
                "N'" + LastName + "', " +
                "N'" + Email + "', " +
                "N'" + Password + "', " +
                Age +
                ")";


            MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);

            stResult = "נרשמת בהצלחה!";
        }
    }
}
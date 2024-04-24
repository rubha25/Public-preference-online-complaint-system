using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class asdf : System.Web.UI.Page
{
    SqlCommand cmd; // cmd for sqlcommand declaration
    SqlConnection con; // con for sqlconnection declaration
    SqlDataReader rd;// rd for sqlreader declaration
    string query;
    SqlDataAdapter adap;// adap for sqldataadaper declaration
    DataTable dt; // dt for datatable declaration


    public void dbconn()
    { // Backend connection coding
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ToString();
        con = new SqlConnection(conn);
        con.Open();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {// login checking with database
        dbconn();
        query = "select username ,password from login where username='" + txtuser.Text.ToLower() + "' and password ='" + txtpwd.Text.ToLower() + "' and role ='" + DropDownList1.Text + "' ";
        cmd = new SqlCommand(query, con);
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.HasRows.Equals(true))
        {

            Session["username"] = txtuser.Text.ToString();
            txtpwd.Text = "";


            // if we select student means it go to student page
            if (DropDownList1.Text.Equals("Citizen"))
            {
                Session["pwd"] = txtuser.Text;
               
                Response.Redirect("studenthome.aspx");


            } // if we select staff means it go to staff page
            if (DropDownList1.Text.Equals("Admin"))
            {
                Session["pwd"] = txtuser.Text;
                Response.Redirect("adminhome.aspx");


            }

            else
            {
                Response.Write("<script> alert ('Please enter correct username & password')</script>");

            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    { //  go to student registration page
        Response.Redirect("reg.aspx");

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;


public partial class emergency : System.Web.UI.Page
{
    SqlCommand cmd; // cmd for sqlcommand declaration
    SqlConnection con; // con for sqlconnection declaration
    SqlDataReader rd;// rd for sqlreader declaration
    string query;
    SqlDataAdapter adap;// adap for sqldataadaper declaration
    DataTable dt; // dt for datatable declaration

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ToString();
        con = new SqlConnection(conn);
        con.Open();
        query = "insert into emergency(name,id,totquestion,timer,reason)values('" + Session["b"].ToString() + "','" + Session["a"].ToString() + "','" + Session["d"].ToString() + "','" + Session["c"].ToString() + "','"+txtreson .Text +"')";
        cmd = new SqlCommand(query ,con );
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect ("login.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
    private static DataTable GetData(string query)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand(query);
        String constr = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(dt);
        return dt;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        dbconn();
        query = "select * from emergency";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

       
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");

    }
}

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

   

    
    protected void LinkButton7_Click(object sender, EventArgs e)
    {// retrieve all question details to report
        GridView2.Visible = true;

        dbconn();
        query = " select username, password from login ";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        dbconn();
        query = " select option1, option2, option3, option4, option5 from question1 ";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView2.DataSource = dt;
        GridView2.DataBind();

    }
   
    protected void LinkButton8_Click(object sender, EventArgs e)
    {// retrieve all login details to report
        GridView2.Visible = false;

        dbconn();
        query = " select * from comp ";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {// retrieve all student details to report
        GridView2.Visible = false;

        dbconn();
        query = " select student_name,  father_name  from registration ";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {// return to admin page
        Response.Redirect("adminhome.aspx");
    }
}

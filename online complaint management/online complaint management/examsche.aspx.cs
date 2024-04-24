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
    {
        dbconn();
        query = " select student_name, reg_no, year from registration where dept ='" + txtdept.Text + "'";

        cmd = new SqlCommand(query, con);
        rd = cmd.ExecuteReader();
        while  (rd.Read())
        {
            txtstudentname .Text = rd[0].ToString();
            txtregno.Text = rd[1].ToString();
            txtyear.Text = rd[2].ToString();
           
            dbconn();
            query = "insert into exam(examid, time, studentregno, studentname, dept, year, questioncount, subject) values ('" + txtexam.Text + "','" + txttime.Text + "', '" + txtregno.Text + "','" + txtstudentname.Text + "','" + txtdept.Text + "','" + txtyear.Text + "','" + txtquestioncount.Text + "','" + txtsubject.Text + "')";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert ('Data Inserted Successfully') </script>");



        }
       

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");

    }
}

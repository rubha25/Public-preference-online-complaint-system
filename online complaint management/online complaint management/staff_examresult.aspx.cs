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
        dbconn();

        query = " select examid from exam ";

        cmd = new SqlCommand(query, con);
        rd = cmd.ExecuteReader();
        while  (rd.Read())
        {
            DropDownList1.Items.Add(rd[0].ToString());

            



        }
    }


   
    protected void Button2_Click(object sender, EventArgs e)
    {
        dbconn();

        query = " select questionid, question, answ, correctans from ans where examid ='"+ DropDownList1.Text +"' and studentname ='"+ TextBox1.Text +"' ";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

       
    }
}

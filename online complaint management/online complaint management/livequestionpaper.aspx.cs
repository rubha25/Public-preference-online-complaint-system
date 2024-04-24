using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;



public partial class _Default : System.Web.UI.Page
{
    SqlCommand cmd1; // cmd for sqlcommand declaration
    SqlConnection con; // con for sqlconnection declaration
    SqlDataReader rd;// rd for sqlreader declaration
    string query;
    SqlDataAdapter adap;// adap for sqldataadaper declaration
   // dt for datatable declaration
    protected void Page_Load(object sender, EventArgs e)
    {

    }
     public void dbconn()
    { // Backend connection coding
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ToString();
        con = new SqlConnection(conn);
        con.Open();
        con.Close();

    }
    
    protected void btnSend_Click(object sender, EventArgs e)
     {//Reference: http://www.aspnetsuresh.com & http://stackoverflow.com/
        
         string path = fileuploadExcel.PostedFile.FileName;
         OleDbConnection oconn = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;" + @"data source=E:\" + path +";" + "Extended Properties=Excel 8.0;");
         try

        {
           
            OleDbCommand ocmd = new OleDbCommand("select * from [Sheet1$]", oconn);
            oconn.Open();
            OleDbDataReader odr = ocmd.ExecuteReader();
            string questionid = "";
            string dept = "";
            string year = "";
            string subject = "";
            string questiontype  = "";
            string question = "";
            string correctans = "";
            string optioncount = "";
            string option1 = "";
            string option2 = "";
            string option3 = "";
            string option4 = "";
            string option5 = "";

            while (odr.Read())
            {
                questionid  = valid(odr, 0);
                dept = valid(odr, 1);
                year = valid(odr, 2);
                subject = valid(odr, 3);
                questiontype = valid(odr, 4);
                question = valid(odr, 5);
                correctans = valid(odr, 6);
                optioncount = valid(odr, 7);
                option1 = valid(odr, 8);
                option2 = valid(odr, 9);
                option3 = valid(odr, 10);
                option4 = valid(odr, 11);
                option5 = valid(odr, 12);


                insertdataintosql(questionid, dept, year, subject, questiontype, question, correctans, optioncount, option1, option2, option3, option4, option5 );
            }
            oconn.Close();
        }
        catch (DataException ee)
        {
            Label1 .Text = ee.Message;
            Label1.ForeColor = System.Drawing.Color.Red;
        }
        finally
        {
            Label1.Text = "Data Inserted Sucessfully";
         
        }
      
    }
    protected string valid(OleDbDataReader myreader, int stval)//if any columns are found null then they are replaced by zero
    {
        object val = myreader[stval];
        if (val != DBNull.Value)
            return val.ToString();
        else
            return Convert.ToString(0);
    }
    public void insertdataintosql(string questionid, string dept, string year, string subject, string questiontype, string question, string correctans, string optioncount, string option1, string option2, string option3, string option4, string option5)
    {// insert query 

        dbconn();

       

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "insert into liveexamquestion ( questionid, dept, year, subject, questiontype, question, correctans, optioncount, option1, option2, option3, option4, option5 ) values(@questionid, @dept, @year, @subject, @questiontype, @question, @correctans, @optioncount, @option1, @option2, @option3, @option4, @option5)";
        cmd.Parameters.Add("@questionid", SqlDbType.VarChar).Value = questionid;
        cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = dept;
        cmd.Parameters.Add("@year", SqlDbType.VarChar).Value = year;
        cmd.Parameters.Add("@subject", SqlDbType.VarChar).Value = subject;
        cmd.Parameters.Add("@questiontype", SqlDbType.VarChar).Value = questiontype;
        cmd.Parameters.Add("@question", SqlDbType.VarChar).Value = question;
        cmd.Parameters.Add("@correctans", SqlDbType.VarChar).Value = correctans;
        cmd.Parameters.Add("@optioncount", SqlDbType.VarChar).Value = optioncount;
        cmd.Parameters.Add("@option1", SqlDbType.VarChar).Value = option1;
        cmd.Parameters.Add("@option2", SqlDbType.VarChar).Value = option2;
        cmd.Parameters.Add("@option3", SqlDbType.VarChar).Value = option3;
        cmd.Parameters.Add("@option4", SqlDbType.VarChar).Value = option4;
        cmd.Parameters.Add("@option5", SqlDbType.VarChar).Value = option5;


        cmd.CommandType = CommandType.Text;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");

    }
}

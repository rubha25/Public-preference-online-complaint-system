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
using System.Net.Mail;
public partial class reg : System.Web.UI.Page
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
    {// student registration  coding
 dbconn();
 query = "insert into registration ( student_name, reg_no, father_name, age, dept, year, password ) values ('" + txtname.Text + "','" + txtregno.Text + "','" + txtfname.Text + "','" + txtage.Text + "','" + txtdept.Text + "','" + txtyear.Text + "','" + txtpwd.Text + "')";
 cmd = new SqlCommand (query, con);
 cmd.ExecuteNonQuery();
 dbconn();
 query = " insert into login (role, username, password) values( '" + txtrole.Text + "','" + txtname.Text + "','" + txtpwd.Text + "')";
 cmd = new SqlCommand(query, con);
 cmd.ExecuteNonQuery();
 // student password send via mail 
 //MailMessage mail = new MailMessage();

 //mail.To.Add(txtemail.Text);




 //mail.From = new MailAddress("erode.litztech@gmail.com");
 //mail.Subject = "Your Registration Details ";

 //string Body = "UserName '" + txtname.Text + "', Password '" + txtpwd.Text + "'";
 //mail.Body = Body;
 //mail.IsBodyHtml = true;
 //SmtpClient smtp = new SmtpClient();
 //smtp.Host = "smtp.gmail.com";
 //smtp.Port = 587;
 //smtp.UseDefaultCredentials = false;
 //smtp.Credentials = new System.Net.NetworkCredential
 //("erode.litztech@gmail.com", "erode!5050");
 //smtp.EnableSsl = true;
 //smtp.Send(mail);
 txtage.Text = "";
 txtdept.Text = "";
 txtemail.Text = "";
 txtfname.Text = "";
 txtname.Text = "";
 txtpwd.Text = "";
 txtregno.Text = "";
 txtrole.Text = "";
 txtyear.Text = "";

 Response.Write("<script> alert ('Registration Successfull')</script>");


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");

    }
}

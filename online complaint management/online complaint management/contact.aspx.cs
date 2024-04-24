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
    protected void Button1_Click(object sender, EventArgs e)
    {
        MailMessage mail = new MailMessage();

        mail.To.Add("kvrs66@gmail.com");




        mail.From = new MailAddress("kvrs66@gmail.com");
        mail.Subject = "Your Registration Details ";

        string Body = "Name '" + TextBox1 .Text + "', email '" + TextBox2 .Text + "', message '"+ TextBox3.Text +"'";



        mail.Body = Body;

        mail.IsBodyHtml = true;



        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.UseDefaultCredentials = false;
        smtp.Credentials = new System.Net.NetworkCredential
        ("kvrs66@gmail.com", "3448925284");
        smtp.EnableSsl = true;
        smtp.Send(mail);
        Response.Write("<script> alert ('Message Sent ')</script>");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";

    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    
}

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

    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false ;

        dbconn();
        query = " select student_name from registration";


        cmd = new SqlCommand(query, con);
        rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            string a = rd[0].ToString();

            DropDownList1.Items.Add(a);



        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {// Password Changing coding

       

       
         dbconn();
         query = "select password from login where  role ='" + txtrole.Text + "'and password ='" + txtold.Text + "'";
         cmd = new SqlCommand(query, con);
         rd = cmd.ExecuteReader();
         if (rd.Read( ))
         {

             TextBox1.Text = rd[0].ToString();
            
    


         }
         if (TextBox1.Text == txtold.Text)
         {
             dbconn();
             query = " update login set password ='" + txtnew.Text + "' where role ='" + txtrole.Text + "' and password ='" + txtold.Text + "'";
             cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();
             MailMessage mail = new MailMessage();

             //mail.To.Add("kvrs66@gmail.com");




             //mail.From = new MailAddress("kvrs66@gmail.com");
             //mail.Subject = "Your Registration Details ";

             //string Body = "New Password '" + txtnew.Text + "'";



             //mail.Body = Body;

             //mail.IsBodyHtml = true;



             //SmtpClient smtp = new SmtpClient();
             //smtp.Host = "smtp.gmail.com";
             //smtp.Port = 587;
             //smtp.UseDefaultCredentials = false;
             //smtp.Credentials = new System.Net.NetworkCredential
             //("kvrs66@gmail.com", "3448925284");
             //smtp.EnableSsl = true;
             //smtp.Send(mail);
             //Response.Write("<script> alert ('Message Sent ')</script>");
             //Response.Write("<script> alert ('Changed')</script>");

         }
         else
         {
             Response.Write("<script> alert ('Check your Password')</script>");


         }
        
         
         }
      
   

    protected void LinkButton11_Click(object sender, EventArgs e)
    {// return to home page of the project
       Response.Redirect("login.aspx");

    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {// go to question add page
        Response.Redirect("questionpaper.aspx");

    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {// open the password changing panel
        MultiView1.ActiveViewIndex = 0; 
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {// go to report page
        Response.Redirect("report.aspx");

    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("examsche.aspx");

    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton14_Click1(object sender, EventArgs e)
    {
        Panel1.Visible = true;

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {


        System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=&text=HI%20Road%20issue.");
    }
}

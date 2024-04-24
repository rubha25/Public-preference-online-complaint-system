using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
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
    {// retrieve the student name from login page
       lblname.Text = " Welcome " + Session["pwd"].ToString() + "";
       Panel1.Visible = false ;
       dbconn();
       query = " select * from exam where studentname ='" + Session["pwd"].ToString() + "'";
       cmd = new SqlCommand(query, con);
       adap = new SqlDataAdapter(cmd);
       dt = new DataTable();
       adap.Fill(dt);
       GridView2.DataSource = dt;
       GridView2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {// retrieve the student details from database
        GridView1.Visible = true ;
        dbconn();
        query = " select student_name, age, father_name from registration where student_name ='" + Session["pwd"].ToString() + "'";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();


    }
    protected void Button3_Click(object sender, EventArgs e)
    {// go to login page
        Response.Redirect("login.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {// view the password change coding

        GridView1.Visible = false;
        GridView2.Visible = false ;
        Panel1.Visible = true;

        Panel2.Visible = false;



    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //change password coding
        TextBox3.Text = Session["pwd"].ToString();
        dbconn();
        query = "select password from login where  username ='" + TextBox3.Text + "' and password ='" + TextBox1.Text + "'";
        cmd = new SqlCommand(query, con);
        rd = cmd.ExecuteReader();
        if (rd.Read())
        {

            TextBox4.Text = rd[0].ToString();

        }
        if (TextBox4.Text == TextBox1.Text)
        {
            dbconn();
            query = " update login set password ='" + TextBox2.Text + "' where username ='" + TextBox3.Text + "' and password ='" + TextBox1.Text + "'";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            //MailMessage mail = new MailMessage();

            //mail.To.Add("kvrs66@gmail.com");




            //mail.From = new MailAddress("kvrs66@gmail.com");
            //mail.Subject = "Your Registration Details ";

            //string Body = "New Password '" + TextBox2 .Text + "'";



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
            Response.Write("<script> alert ('Password Changed')</script>");
        }
        else
        {
            Response.Write("<script> alert ('Check your Password')</script>");


        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        LinkButton Lnk = (LinkButton)sender;
        Session ["Examid"] = Lnk.Text;
        Response.Redirect("examscreen.aspx");



    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lnk = e.Row.FindControl("LinkButton1") as LinkButton;
            lnk.Click += new EventHandler(LinkButton1_Click);

        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        GridView2.Visible = false;
        


    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        dbconn();
        GridView3.Visible = true;

        query = " select complaintcate, state, district, taluk, area, address, complaintdetails from comp where citizenname ='" + lblname.Text + "'";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        Panel1.Visible = false;
        Panel2.Visible = false;
        GridView2.Visible = true;


    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        dbconn();
        query = "insert into comp( complaintcate, state, district, taluk, area, address, complaintdetails, citizenname ) values ('" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','"+ lblname.Text +"')";
        cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script> alert ('Complaint Registration Successfull')</script>");
    }
}
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
using System.IO;


public partial class examscreen : System.Web.UI.Page
{
    SqlCommand cmd; // cmd for sqlcommand declaration
    SqlConnection con; // con for sqlconnection declaration
    SqlDataReader rd;// rd for sqlreader declaration
    string query;
    SqlDataAdapter adap;// adap for sqldataadaper declaration
    DataTable dt; // dt for datatable declaration
   
    protected void Page_Load(object sender, EventArgs e)
    {//get total question

        
        lblexamid.Text = Session["Examid"].ToString();
        lblname.Text = Session["pwd"].ToString();
        dbconn();
        query = " select questioncount from exam where examid ='" + lblexamid .Text + "'";

        cmd = new SqlCommand(query, con);
        rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            lbltotalquestion .Text = rd[0].ToString();

        }

       //get question type
        dbconn();
        query = " select questiontype from question1 where questionid ='" + txtquestionid.Text + "'";

        cmd = new SqlCommand(query, con);
        rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            txttypeofquestion.Text = rd[0].ToString();



        }
       

    }
  //  http://www.codeproject.com/Tips/429419/Create-Count-Down-Timer-using-ASP-NET-Timer-Contro
    protected void timer1_tick(object sender, EventArgs e)
    {
        if (0 > DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timeout"].ToString())))
        {
            lblTimer.Text = string.Format("Time Left: 00:{0}:{1}", ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString(), ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Seconds).ToString());
        }
        else
        {
            timer1.Enabled = true;
            Response.Redirect("studenthome.aspx");

        }
    }
    public void dbconn()
    { // Backend connection coding
        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ToString();
        con = new SqlConnection(conn);
        con.Open();
    }

    

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        txtquestionid.Text = "";

        
        foreach (GridViewRow row in gvDetails.Rows)
        {
            //CheckBox chk = (CheckBox)row.Cells[0].FindControl("CheckBox1");
            //if (chk.Checked.Equals(true))
            //{//color changing coding
            CheckBox Lnk = (CheckBox)sender;
        if (Lnk.Checked.Equals(true))
        {
            
        
                
                txtquestionid.Text = Lnk .Text;
                dbconn();
                query = " select question, correctans from question1 where questionid ='" + txtquestionid.Text + "'";

                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txttestquestion .Text = rd[0].ToString();
                    txttestcorrect.Text = rd[1].ToString();



                }
                dbconn();

                query = " select questiontype from question1 where questionid ='" + txtquestionid.Text + "'";

                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    txttypeofquestion.Text = rd[0].ToString();



                }//get choose the best answer question type
                if (txttypeofquestion.Text == "Textbox")
                {
                    MultiView1.ActiveViewIndex = 0;
                    questionget();



                }//get Radiobutton question type
                else if (txttypeofquestion.Text == "Radiobutton")
                {
                    MultiView1.ActiveViewIndex = 2;
                    questionget();
                }//get Checkbox question type
                else if (txttypeofquestion.Text == "Checkbox")
                {
                    MultiView1.ActiveViewIndex = 1;
                    questionget();

                }


            }
          
        }


    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox Lnk = (CheckBox)sender;
        if (Lnk.Checked.Equals(true))
        {
            txttestselected.Text = Lnk.Text;
        }

      
       
    }
    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox Lnk = (CheckBox)sender;
        if (Lnk.Checked.Equals(true))
        {
            txttestselected.Text = Lnk.Text;
        }


     
    }
    protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox Lnk = (CheckBox)sender;
        if (Lnk.Checked.Equals(true))
        {
            txttestselected.Text = Lnk.Text;
        }



    }
    protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox Lnk = (CheckBox)sender;
        if (Lnk.Checked.Equals(true))
        {
            txttestselected.Text = Lnk.Text;
        }



    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (txttestcorrect.Text == txttestselected.Text)
        {
            TextBox2.Text =Convert.ToString(( Convert.ToInt32 ( TextBox2.Text)  )+ (Convert.ToInt32 ( TextBox3.Text)));
        }
        //foreach (GridViewRow row in gvDetails.Rows)
        //{
        //    CheckBox chk = (CheckBox)row.Cells[0].FindControl("CheckBox1");
        //    if (chk.Checked)
        //        row.BackColor = System.Drawing.ColorTranslator.FromHtml("#f40829");

        //    else
        //        row.BackColor = System.Drawing.ColorTranslator.FromHtml("#03a407");
        //}

        dbconn();
        query = " insert into ans( examid, questionid, studentname, totalquestion, question,  answ, correctans) values ('" + lblexamid.Text + "','" + txtquestionid.Text + "','" + lblname.Text + "','" + lbltotalquestion.Text + "','" + txttestquestion.Text + "','" + txttestselected.Text + "','" + txttestcorrect.Text + "')";
        cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();
       

        
    }
    public void questionget()
    {
        dbconn();

        query = " select * from question1 where questiontype ='" + txttypeofquestion.Text + "' and questionid ='" + txtquestionid.Text + "'";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        txtgrid.DataSource = dt;
        txtgrid.DataBind();
        dbconn();

        query = " select * from question1 where questiontype ='" + txttypeofquestion.Text + "' and questionid ='" + txtquestionid.Text + "'";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        rdogrid.DataSource = dt;
        rdogrid.DataBind();
        dbconn();

        query = " select * from question1 where questiontype ='" + txttypeofquestion.Text + "' and questionid ='" + txtquestionid.Text + "'";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        chkgrid.DataSource = dt;
        chkgrid.DataBind();
    }
    //ORDER BY 1{NEWID()
    //protected void gvDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    gvDetails.PageIndex = e.NewPageIndex;
    //    gvDetails.DataBind();
    //}
    protected void Button3_Click(object sender, EventArgs e)
    {
    if (!SM1.IsInAsyncPostBack)

    Session["timeout"] = DateTime.Now.AddMinutes(30).ToString();
        // select question no
        timer1.Enabled = true;

        dbconn();
        query = " SELECT TOP " + lbltotalquestion.Text + " questionid FROM [question1]  ";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        gvDetails.DataSource = dt;
        gvDetails.DataBind();
        //get choose the best anwer question type
        if (txttypeofquestion.Text == "Textbox")
        {
            MultiView1.ActiveViewIndex = 0;
            questionget();



        }//get Radiobutton question type
        else if (txttypeofquestion.Text == "Radiobutton")
        {
            MultiView1.ActiveViewIndex = 2;
            questionget();
        }//get Checkbox question type
        else if (txttypeofquestion.Text == "Checkbox")
        {
            MultiView1.ActiveViewIndex = 1;
            questionget();

        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script> alert ('Exam paused')</script> ");
        timer1.Enabled = false;

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Write("<script> alert ('Exam Stopped')</script> ");
        Response.Redirect("studenthome.aspx");

    }
    protected void Button5_Click(object sender, EventArgs e)
    {

        //http://www.codeproject.com/Questions/289663/How-to-redirect-to-prevoius-page-after-javascript
        Response.Write("<script> alert('your score is "+ TextBox2.Text +"');window.location='studenthome.aspx'; </script>");

    }
    
    protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
    {
        RadioButton  Lnk = (RadioButton )sender;
        if (Lnk.Checked.Equals(true))
        {
            txttestselected.Text = Lnk.Text;
        }
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton Lnk = (RadioButton)sender;
        if (Lnk.Checked.Equals(true))
        {
            txttestselected.Text = Lnk.Text;
        }
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton Lnk = (RadioButton)sender;
        if (Lnk.Checked.Equals(true))
        {
            txttestselected.Text = Lnk.Text;
        }
    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton Lnk = (RadioButton)sender;
        if (Lnk.Checked.Equals(true))
        {
            txttestselected.Text = Lnk.Text;
        }
    }
}

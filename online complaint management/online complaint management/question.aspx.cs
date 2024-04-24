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
        lbloption1.Visible = false;
        lbloption2.Visible = false;
        lbloption3.Visible = false;
        lbloption4.Visible = false;
        lbloption5.Visible = false;
        lbloption6.Visible = false;
        lbloption7.Visible = false;
        lbloption8.Visible = false;
        lbloption9.Visible = false;
        lbloption10.Visible = false;
        txtoption1 .Visible = false;
        txtoption2.Visible = false;
        txtoption3.Visible = false;
        txtoption4.Visible = false;
        txtoption5.Visible = false;
        txtoption6.Visible = false;
        txtoption7.Visible = false;
        txtoption8.Visible = false;
        txtoption9.Visible = false;
        txtoption10.Visible = false;


    }

    protected void Button2_Click(object sender, EventArgs e)
    {// return to admin page
        Response.Redirect("adminhome.aspx");
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {// add the question to questiondb
        string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
        FileUpload1.SaveAs(Server.MapPath("files/" + FileName));
        dbconn();
        string a = "files" + FileName + "";


        query = "insert into question ( dept, year, subject, questiontype, image, correctans, optioncount, option1, option2, option3, option4, option5, option6, option7, option8, option9, option10) values ('" + txtdept.Text + "','" + txtyear.Text + "','" + txtsubject.Text + "','" + DropDownList1.Text + "','" + "files/" + FileName + "', '" + txtanswer.Text + "','"+ DropDownList2.Text +"','" + txtoption1.Text + "','" + txtoption2.Text + "','" + txtoption3.Text + "','" + txtoption4.Text + "','"+ txtoption5.Text +"','"+ txtoption6.Text +"','"+ txtoption7.Text +"','"+ txtoption8.Text +"','"+ txtoption9.Text +"','"+ txtoption10.Text +"')";
        cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();

            Response.Write("<script> alert ('Question Add')</script>");
            txtanswer.Text = "";
            txtdept.Text = "";
           
            txtoption1.Text = "";
            txtoption2.Text = "";
            txtoption3.Text = "";
            txtoption4.Text = "";
            txtquestion.Text = "";
            txtsubject.Text = "";
            txtyear.Text = "";

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (DropDownList2.Text == "1")
        {
            lbloption1.Visible =true ;
            
            txtoption1.Visible = true;
          
        }
        else  if (DropDownList2.Text == "2")
        {
            lbloption1.Visible =true ;
            lbloption2.Visible = true ;
          
            txtoption1.Visible = true;
            txtoption2.Visible = true;
           
            
        }
        else  if (DropDownList2.Text == "3")
        {
            lbloption1.Visible =true ;
            lbloption2.Visible = true ;
            lbloption3.Visible = true ;
            
            txtoption1.Visible = true;
            txtoption2.Visible = true;
            txtoption3.Visible = true;
           
            
        }
      
       else  if (DropDownList2.Text == "4")
        {
            lbloption1.Visible =true ;
            lbloption2.Visible = true ;
            lbloption3.Visible = true ;
            lbloption4.Visible = true;
            txtoption1.Visible = true;
            txtoption2.Visible = true;
            txtoption3.Visible = true;
            txtoption4.Visible = true;
            
        }
       else  if (DropDownList2.Text == "5")
        {
            lbloption1.Visible = true;
            lbloption2.Visible = true;
            lbloption3.Visible = true;
            lbloption4.Visible = true;
            txtoption1.Visible = true;
            txtoption2.Visible = true;
            txtoption3.Visible = true;
            txtoption4.Visible = true;
            lbloption5.Visible = true;
            txtoption5.Visible = true;


        }
        else if (DropDownList2.Text == "6")
        {
            lbloption1.Visible = true;
            lbloption2.Visible = true;
            lbloption3.Visible = true;
            lbloption4.Visible = true;
            txtoption1.Visible = true;
            txtoption2.Visible = true;
            txtoption3.Visible = true;
            txtoption4.Visible = true;
            lbloption5.Visible = true;
            txtoption5.Visible = true;

            lbloption6.Visible = true;
            txtoption6.Visible = true;


        }
        else if (DropDownList2.Text == "7")
        {
            lbloption1.Visible = true;
            lbloption2.Visible = true;
            lbloption3.Visible = true;
            lbloption4.Visible = true;
            txtoption1.Visible = true;
            txtoption2.Visible = true;
            txtoption3.Visible = true;
            txtoption4.Visible = true;
            lbloption5.Visible = true;
            txtoption5.Visible = true;
            lbloption6.Visible = true;
            txtoption6.Visible = true;
            lbloption7.Visible = true;
            txtoption7.Visible = true;


        }
        else if (DropDownList2.Text == "8")
        {
            lbloption1.Visible = true;
            lbloption2.Visible = true;
            lbloption3.Visible = true;
            lbloption4.Visible = true;
            txtoption1.Visible = true;
            txtoption2.Visible = true;
            txtoption3.Visible = true;
            txtoption4.Visible = true;
            lbloption5.Visible = true;
            txtoption5.Visible = true;
            lbloption6.Visible = true;
            txtoption6.Visible = true;
            lbloption7.Visible = true;
            txtoption7.Visible = true;
            lbloption8.Visible = true;
            txtoption8.Visible = true;



        }
        else if (DropDownList2.Text == "9")
        {
            lbloption1.Visible = true;
            lbloption2.Visible = true;
            lbloption3.Visible = true;
            lbloption4.Visible = true;
            txtoption1.Visible = true;
            txtoption2.Visible = true;
            txtoption3.Visible = true;
            txtoption4.Visible = true;
            lbloption5.Visible = true;
            txtoption5.Visible = true;
            lbloption6.Visible = true;
            txtoption6.Visible = true;
            lbloption7.Visible = true;
            txtoption7.Visible = true;
            lbloption8.Visible = true;
            txtoption8.Visible = true;
            lbloption9.Visible = true;
            txtoption9.Visible = true;


        }
        else if (DropDownList2.Text == "10")
        {
            lbloption1.Visible = true;
            lbloption2.Visible = true;
            lbloption3.Visible = true;
            lbloption4.Visible = true;
            txtoption1.Visible = true;
            txtoption2.Visible = true;
            txtoption3.Visible = true;
            txtoption4.Visible = true;
            lbloption5.Visible = true;
            txtoption5.Visible = true;
            lbloption6.Visible = true;
            txtoption6.Visible = true;
            lbloption7.Visible = true;
            txtoption7.Visible = true;
            lbloption8.Visible = true;
            txtoption8.Visible = true;
            lbloption9.Visible = true;
            txtoption9.Visible = true;
            lbloption10.Visible = true;
            txtoption10.Visible = true;


        }
    }
}

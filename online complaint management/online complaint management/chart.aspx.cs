using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
        Panel1.Visible = false;

        string conn = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ToString();
        con = new SqlConnection(conn);
        con.Open();
    }
    private static DataTable GetData(string query)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand(query);
        String constr = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(dt);
        return dt;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        string query = "select examid  from exam";
        DataTable dt = GetData(query);
        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = "examid";
        DropDownList1.DataValueField = "examid";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, new ListItem("Select", ""));
        for (int i = 0; i < DropDownList1.Items.Count; i++)
        {
            DropDownList1.SelectedIndex = i;
            string str = DropDownList1.SelectedItem.ToString();
            for (int counter = i + 1; counter < DropDownList1.Items.Count; counter++)
            {
                DropDownList1.SelectedIndex = counter;
                string compareStr = DropDownList1.SelectedItem.ToString();
                if (str == compareStr)
                {
                    DropDownList1.Items.RemoveAt(counter);
                    counter = counter - 1;
                }
            }
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Chart1.Visible = DropDownList1.SelectedValue != "";
        //string query = string.Format("select studentname, answ from ans  where examid ='"+  DropDownList1.SelectedValue +"'");
        //DataTable dt = GetData(query);
        //string[] x = new string[dt.Rows.Count];
        //int[] y = new int[dt.Rows.Count];
        //for (int i = 0; i < dt.Rows.Count; i++)
        //{
        //    x[i] = dt.Rows[i][0].ToString();
        //    y[i] = Convert.ToInt32(dt.Rows[i][1]);
        //}
        //Chart1.Series[0].Points.DataBindXY(x, y);
        //Chart1.Series[0].ChartType = SeriesChartType.Pie;
        //Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        //Chart1.Legends[0].Enabled = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
      

        Chart1.Visible = DropDownList1.SelectedValue != "";
        string query = string.Format("select studentname, mark from mark  where examid ='" + DropDownList1.Text  + "'");
        DataTable dt = GetData(query);
        string[] x = new string[dt.Rows.Count];
        int[] y = new int[dt.Rows.Count];
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            x[i] = dt.Rows[i][0].ToString();
            y[i] = Convert.ToInt32(dt.Rows[i][1]);
        }
        Chart1.Series[0].Points.DataBindXY(x, y);
        Chart1.Series[0].ChartType = SeriesChartType.Column  ;
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        Chart1.Legends[0].Enabled = true;
        dbconn();
        query = " select studentname, mark from mark  where examid ='" + DropDownList1.Text + "'";
        cmd = new SqlCommand(query, con);
        adap = new SqlDataAdapter(cmd);
        dt = new DataTable();
        adap.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        Panel1.Visible = true;

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string query = "select examid  from exam";
        DataTable dt = GetData(query);
        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = "examid";
        DropDownList1.DataValueField = "examid";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, new ListItem("Select", ""));
        for (int i = 0; i < DropDownList1.Items.Count; i++)
        {
            DropDownList1.SelectedIndex = i;
            string str = DropDownList1.SelectedItem.ToString();
            for (int counter = i + 1; counter < DropDownList1.Items.Count; counter++)
            {
                DropDownList1.SelectedIndex = counter;
                string compareStr = DropDownList1.SelectedItem.ToString();
                if (str == compareStr)
                {
                    DropDownList1.Items.RemoveAt(counter);
                    counter = counter - 1;
                }
            }
        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");

    }
}

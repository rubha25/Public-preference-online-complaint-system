<%@ Page Language="C#" AutoEventWireup="true" CodeFile="report.aspx.cs" Inherits="asdf" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Welcome to University of Leicester</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="imagetoolbar" content="no" />
<link rel="stylesheet" href="styles/layout.css" type="text/css" />

</head>
<body  id="top">
    <form id="form1" runat="server">
   <div class="wrapper row1">
  <div id="header" class="clear">
    <div class="fl_left">
      <center>  <h1><a href="">ONLINE COMPLAINT MANAGEMENT</a></h1></center>
    </div>
  </div>
</div>
<!-- ####################################################################################################### -->

<div class="wrapper row3">
  <div class="rnd">
    <div id="container" class="clear">
      <!-- ####################################################################################################### -->
      <div id="homepage" class="clear">
        <!-- ###### -->
       
        <!-- ###### -->
        <div id="latestnews">
         <h1>Admin Home </h1>
                           <p>&nbsp;</p>
                           <p>
                               <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click">Login details</asp:LinkButton>
&nbsp;&nbsp;
                               <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">All Complaint Report</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
                               <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">All user Details</asp:LinkButton>
&nbsp;&nbsp;
                               <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">Home</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
                                </p>
                          
        <h2> </h2>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <RowStyle ForeColor="#000066" />
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <PagerStyle ForeColor="#000066" HorizontalAlign="Left" BackColor="White" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView2" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <RowStyle ForeColor="#000066" />
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <PagerStyle ForeColor="#000066" HorizontalAlign="Left" BackColor="White" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
        </div></div>
        <!-- ###### -->
        <div id="right_column">
         <h1>Displays the Reports</h1>
         
          </div>
        <!-- ###### -->
      </div>
      </div>
  </div>
</div>
<!-- ####################################################################################################### -->
<div class="wrapper row4">
  <div class="rnd">
    <div id="footer" class="clear">
      <!-- ####################################################################################################### -->
      <div class="fl_left clear">
        <div class="fl_left center"><img src="images/demo/worldmap.gif" alt="" /><br />
          <%--<a href="https://www.google.co.uk/maps/place/University+of+Leicester/@52.6216354,-1.1252691,15z/data=!3m1!4b1!4m2!3m1!1s0x4877612fa55d947f:0xf8da17fed74e0044">Find Us With Google Maps &raquo;</a></div>
        <address>
        University of Leicester<br />
        University Road<br />
        Leicester<br />
        LE1 7RH<br />
        <br />
        Tel: 0116-22002200<br />
        Email: <a href="#">help@le.ac.uk</a>
        </address>--%>
      </div>
      <div class="fl_right">
        <div id="social" class="clear">
          
        </div>
      </div>
      <!-- ####################################################################################################### -->
    </div>
  </div>
</div>
<!-- ####################################################################################################### -->
<div class="wrapper">
  <div id="copyright" class="clear">
 
     </div>
</div>
    </form>
</body>
</html>

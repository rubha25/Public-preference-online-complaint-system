<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studenthome.aspx.cs" Inherits="asdf" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Welcome to University of Leicester</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="imagetoolbar" content="no" />
<link rel="stylesheet" href="styles/layout.css" type="text/css" />
<!-- Homepage Specific Elements -->
<script type="text/javascript" src="scripts/jquery-1.4.1.min.js"></script>
<script type="text/javascript" src="scripts/jquery-ui-1.7.2.custom.min.js"></script>
<script type="text/javascript" src="scripts/jquery.tabs.setup.js"></script>
<!-- End Homepage Specific Elements -->
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

    <!-- ###### -->
  </div>
</div>
<!-- ####################################################################################################### -->
<div class="wrapper">
  <div id="featured_slide" class="clear">
    <!-- ###### -->
   <div class="overlay_left"></div>
   <marquee direction = "left" behavior="alternate"> 
    <img src="images/demo/slider/2.jpg" alt="" />
    <img src="images/demo/slider/1.jpg" alt="" />
        <img src="images/demo/slider/3.jpg" alt="" />
    </marquee>
     <ul id="featured_tabs">
<li><a href="login.aspx">Home</a></li>
      <li><a href="aboutus.aspx">About Us</a></li>
      <%--<li><a href="gallery.aspx">Gallery</a></li>
      <li><a href="department.aspx">Department</a></li>
      <li class="last"><a href="contact.aspx">Contact Us</a></li>--%>
    </ul>
    <div class="overlay_right"></div>
    <!-- ###### -->
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
          
         <h2>
           <b>  <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label></b> </h2> <div>
   <h2>Menu </h2>
        </div>
        
            <asp:Button ID="Button1" runat="server" Text="My Profile" BackColor="#33CCFF" 
                onclick="Button1_Click" Width="120px" />
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="Button2" runat="server" BackColor="#00CCFF" 
                Text="Change Password" Width="120px" onclick="Button2_Click" />
            
            &nbsp;&nbsp;&nbsp;&nbsp;
            
                           <asp:Button ID="Button5" runat="server" Width="120px" BackColor="#00CCFF"   onclick="Button5_Click" Text="My Exam" />
            
                           &nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="Button7" runat="server" BackColor="#00CCFF" 
                Text="View My Complaint" Width="204px" OnClick="Button7_Click"  />
            &nbsp;
            
            <asp:Button ID="Button3" runat="server" BackColor="#00CCFF" 
                Text="Logout" Width="120px" onclick="Button3_Click" />
            <br />
          </div>
        <!-- ###### -->
        <h2>Welcome to Your Home </h2>
        <div id="right_column"><br /><br />
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Old password"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="New password"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Change" />
                <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
            </asp:Panel>
            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" 
                BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                CellSpacing="2">
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            
            
        
            <br />
            <asp:Panel ID="Panel2" runat="server" Visible="False">
              
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" CellSpacing="2" Visible="False">
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <Columns>
                <asp:TemplateField HeaderText ="My Exams">
                <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" Text='<%# Bind("examid") %>'></asp:LinkButton>
                
                </ItemTemplate>
                </asp:TemplateField>
                </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
                <asp:GridView ID="GridView3" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
              <table> 
                  <tr>
                      <td colspan ="2"> 
                         
                        
                      </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="Label4" runat="server" Text="Complaint Category"></asp:Label> </td>
                      <td>
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                      </td>
                  </tr>
                     <tr>
                      <td> <asp:Label ID="Label5" runat="server" Text="State"></asp:Label> </td>
                      <td>
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                      </td>
                  </tr>
                     <tr>
                      <td> <asp:Label ID="Label6" runat="server" Text="District"></asp:Label> </td>
                      <td>
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                      </td>
                  </tr>
                     <tr>
                      <td> <asp:Label ID="Label7" runat="server" Text="Taluk"></asp:Label> </td>
                      <td>
                            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                      </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="Label8" runat="server" Text="Area"></asp:Label> </td>
                      <td>
                            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                      </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="Label9" runat="server" Text="Address"></asp:Label> </td>
                      <td>
                            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                      </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="Label10" runat="server" Text="Complaint Details"></asp:Label> </td>
                      <td>
                            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                      </td>
                  </tr>
                   <tr>
                      <td colspan ="2"> <center> <asp:Button ID="Button6" runat="server" Text="Submit" OnClick="Button6_Click" /></center> </td>
                      
                  </tr>

                 
              </table>
                <asp:Label ID="Label3" runat="server" Text="Old password" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
                <br />
            </asp:Panel>
        
          </div>
        <!-- ###### -->
      </div>
      <!-- ####################################################################################################### -->
      <!-- ####################################################################################################### -->
      <!-- ####################################################################################################### -->
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

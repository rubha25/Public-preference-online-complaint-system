<%@ Page Language="C#" AutoEventWireup="true" CodeFile="emergency.aspx.cs" Inherits="emergency" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Welcome to University of Leicester</title>

<link rel="stylesheet" href="styles/layout.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
   
   <div class="wrapper row1">
  <div id="header" class="clear">
    <div class="fl_left">
       <center>  <h1><a href="">ONLINE COMPLAINT MANAGEMENT</a></h1></center>
    </div>
  </div>
</div>
<!-- ####################################################################################################### -->
<div class="wrapper row2">
 
</div>
<!-- ############################# ########################################################################## -->

<!-- ####################################################################################################### -->
<div class="wrapper row3">
  <div class="rnd">
    <div id="container" class="clear">
      <!-- ####################################################################################################### -->
   <div id="homepage" class="clear">
        <div id="latestnews"> <div style="height: 107px">
    
        <asp:Label ID="Label1" runat="server" Text="Reason"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtreson" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
        <br />
    

         
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
          <a href="https://www.google.co.uk/maps/place/University+of+Leicester/@52.6216354,-1.1252691,15z/data=!3m1!4b1!4m2!3m1!1s0x4877612fa55d947f:0xf8da17fed74e0044">Find Us With Google Maps &raquo;</a></div>
        <address>
        University of Leicester<br />
        University Road<br />
        Leicester<br />
        LE1 7RH<br />
        <br />
        Tel: 0116-22002200<br />
        Email: <a href="#">help@le.ac.uk</a>
        </address>
      </div>
      <div class="fl_right">
        <div id="social" class="clear">
          <ul>
            <li><a style="background-position:0 0;" href="https://twitter.com/uniofleicester" target="_blank">Twitter</a></li>
            <li><a style="background-position:-72px 0;" href="http://www.linkedin.com/edu/university-of-leicester-12707" target="_blank">LinkedIn</a></li>
            <li><a style="background-position:-142px 0;" href="https://www.facebook.com/UniofLeicester" target="_blank">Facebook</a></li>
<%--            <li><a style="background-position:-212px 0;" href="#">Flickr</a></li>--%>
            <li><a style="background-position:-282px 0;" href="http://www2.le.ac.uk/ebulletin-feeds" target="_blank">RSS</a></li>
          </ul>
        </div>
      </div>
      <!-- ####################################################################################################### -->
    </div>
  </div>
</div>
<!-- ####################################################################################################### -->
<div class="wrapper">
  <div id="copyright" class="clear">
    <p class="fl_left">Designed by Kavi<a href="#"></a></p>
     </div>
</div>
    
    </div>
    
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="liveexamhome.aspx.cs" Inherits="asdf" %>

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
      <li><a href="aboutus.aspx">ALL Section</a></li>
     <%-- <li><a href="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </a></li>
      <li><a href="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </a></li>
      <li class="last"><a href="">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </a></li>--%>
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
         <h1>Live Exam</h1>
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Add Question</asp:LinkButton>
               &nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Set Exam</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">Back</asp:LinkButton>
               <br />
          <br /> <br />
        
                          
        </div></div>
        <!-- ###### -->
        <div id="right_column">
       
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

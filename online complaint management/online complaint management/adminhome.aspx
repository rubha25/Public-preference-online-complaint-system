<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminhome.aspx.cs" Inherits="asdf" %>

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
                               <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click" Visible="False">Upload Question</asp:LinkButton>
&nbsp;&nbsp;
                               <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click" Visible="False">Set 
                               Exam</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
                               &nbsp;&nbsp;&nbsp;&nbsp;
                               <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">see all complaints</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
                               <asp:LinkButton ID="LinkButton12" runat="server" onclick="LinkButton12_Click">Change Password</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                               <asp:LinkButton ID="LinkButton13" runat="server" OnClick="LinkButton13_Click">Add Section</asp:LinkButton>
                               &nbsp;&nbsp;&nbsp;
                               <a href ="https://api.whatsapp.com/send?phone=+919345591511&text=HI%20Road%20issue.">Send Whatsapp </a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                               
                               <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Visible="False">send whatsapp</asp:LinkButton>
                                <asp:LinkButton ID="LinkButton14" runat="server" OnClick="LinkButton14_Click1">chart</asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton11_Click">Logout</asp:LinkButton>
                           </p>
                          
        <h2> 


            Customer name <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>


            <asp:Panel ID="Panel1" runat="server">
                           <asp:Image ID="Image1" runat="server" ImageUrl="~/image.jpg" />
            </asp:Panel>
 
            </h2>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        <br />
            <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID ="a"  runat="server">
            <table>
            <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Role" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtrole" runat="server" Text="Staff" Visible="False"></asp:TextBox>
            </td>
            </tr>
             <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Old Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtold" runat="server"></asp:TextBox>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            </td>
            </tr>
             <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="New Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnew" runat="server"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td colspan="2"> 
                <asp:Button ID="Button1" runat="server" Text="Change" onclick="Button1_Click" /></td>
            </tr>
            </table>
            
            </asp:View>
            </asp:MultiView>
        </div></div>
        <!-- ###### -->
        <div id="right_column">
         <h1>Welcome to Admin Page</h1>
         
		Manage Students ,Questions and schedule the Exams.

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

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="question.aspx.cs" Inherits="asdf" %>

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
         <h1>Question </h1>
         <table>
        <%-- <tr>
         <td>
             <asp:Label ID="Label1" runat="server" Text="Question ID"></asp:Label> </td>
         <td>
             <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
          </td>
         </tr>--%>
          <tr>
         <td>
             <asp:Label ID="Label2" runat="server" Text="Dept"></asp:Label> </td>
         <td>
             <asp:TextBox ID="txtdept" runat="server"></asp:TextBox>
          </td>
         </tr>
          <tr>
         <td>
             <asp:Label ID="Label3" runat="server" Text="year"></asp:Label> </td>
         <td>
             <asp:TextBox ID="txtyear" runat="server"></asp:TextBox>
          </td>
         </tr>
          <tr>
         <td>
             <asp:Label ID="Label4" runat="server" Text="Subject"></asp:Label> </td>
         <td>
             <asp:TextBox ID="txtsubject" runat="server"></asp:TextBox>
          </td>
         </tr>
          <tr>
         <td><asp:Label ID="Label5" runat="server" Text="Question Type"></asp:Label> 
            
             </td>
             <td>
                 <asp:DropDownList ID="DropDownList1" runat="server">
                     <asp:ListItem>Check box</asp:ListItem>
                     <asp:ListItem>Radio Button</asp:ListItem>
                     <asp:ListItem>Texbox</asp:ListItem>
                 </asp:DropDownList>
             </td>
         
         </tr>
         
         <tr>
         <td>
             <asp:Label ID="Label6" runat="server" Text="Question"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtquestion" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="Label7" runat="server" Text="Correct Answer"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtanswer" runat="server"></asp:TextBox>
         </td>
         </tr>
          <tr>
         <td>
             <asp:Label ID="Label13" runat="server" Text="Option count"></asp:Label>
         </td>
         <td>
             <asp:DropDownList ID="DropDownList2" runat="server">
                 <asp:ListItem>1</asp:ListItem>
                  <asp:ListItem>2</asp:ListItem>
                   <asp:ListItem>3</asp:ListItem>
                   
                 <asp:ListItem>4</asp:ListItem>
                 <asp:ListItem>5</asp:ListItem>
                 <asp:ListItem>6</asp:ListItem>
                 <asp:ListItem>7</asp:ListItem>
                 <asp:ListItem>8</asp:ListItem>
             <asp:ListItem>9</asp:ListItem>
             <asp:ListItem>10</asp:ListItem>
             
             
             </asp:DropDownList>
             <asp:Button ID="Button3" runat="server" Text="Set" onclick="Button3_Click" />
         </td>
         </tr>
          <tr>
         <td>
             <asp:Label ID="Label12" runat="server" Text="Image"></asp:Label>
         </td>
         <td>
             <asp:FileUpload ID="FileUpload1" runat="server" />
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption1" runat="server" Text="Option1"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption1" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption2" runat="server" Text="Option 2"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption2" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption3" runat="server" Text="Option 3"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption3" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption4" runat="server" Text="Option 4"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption4" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption5" runat="server" Text="Option 5"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption5" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption6" runat="server" Text="Option 6"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption6" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption7" runat="server" Text="Option 7"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption7" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption8" runat="server" Text="Option 8"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption8" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption9" runat="server" Text="Option 9"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption9" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td>
             <asp:Label ID="lbloption10" runat="server" Text="Option 10"></asp:Label>
         </td>
         <td>
             <asp:TextBox ID="txtoption10" runat="server"></asp:TextBox>
         </td>
         </tr>
         <tr>
         <td colspan="2">
           <asp:Button ID="Button1" runat="server" Text="ADD" onclick="Button1_Click" />
             <asp:Button ID="Button2" runat="server" Text="Home" onclick="Button2_Click" />
         </td>
         </tr>
         
          </table>
       
                          
        <h2> </h2>
        </div></div>
        <!-- ###### -->
        
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

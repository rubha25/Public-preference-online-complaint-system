<%@ Page Language="C#" AutoEventWireup="true" CodeFile="questionpaper.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to University of Leicester</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="imagetoolbar" content="no" />
<link rel="stylesheet" href="styles/layout.css" type="text/css" />

</head>
<body id="top">
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
    <table>
<tr>
<td>
<span style="color: Red">*</span>Attach Excel file
</td>
<td>
<asp:FileUpload ID="fileuploadExcel" runat="server" Visible="False" />
</td>
</tr>
<tr>
<td></td>
<td>
<asp:Button ID="btnSend" runat="server" Text="Export" onclick="btnSend_Click" Visible="False"  />
&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </td>
</tr>
</table>
<asp:GridView ID="GridView1" runat="server" Visible="False">
</asp:GridView>
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Section Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Section  Details"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan ="2"> <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" /> 
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                    </td>
                </tr>
            </table>
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

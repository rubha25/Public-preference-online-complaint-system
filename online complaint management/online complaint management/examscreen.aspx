<%@ Page Language="C#" AutoEventWireup="true" CodeFile="examscreen.aspx.cs" Inherits="examscreen" %>

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
        <div id="latestnews">
        
        Welcome&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        :
        <asp:Label ID="lblname" runat="server" Text="lblname"></asp:Label>
       <br />
        Exam ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        :
        <asp:Label ID="lblexamid" runat="server" Text="Label"></asp:Label>
      <br />
        Total No Of Question :&nbsp;
        <asp:Label ID="lbltotalquestion" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:ScriptManager ID= "SM1" runat="server"></asp:ScriptManager>
<asp:Timer ID="timer1" runat="server"
Interval="1000" OnTick="timer1_tick"></asp:Timer>
</div>
 
<div>
<asp:UpdatePanel id="updPnl"
runat="server" UpdateMode="Conditional">
<ContentTemplate>
<asp:Label ID="lblTimer" runat="server" Font-Bold="True" Font-Names="Arial"
        Font-Size="X-Large" ForeColor="#072746"></asp:Label>
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>
</asp:UpdatePanel>
           
           
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="Start Exam" />
        <br />
       
        &nbsp;<asp:TextBox ID="txttypeofquestion" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="txtquestionid" runat="server" Visible="False">1</asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <div style="width: 100%;">
    <div style="float:left; width: 20%">
       
     
     <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False" 
                BorderStyle="None" 
                >
      <Columns>
      <asp:TemplateField HeaderText="All Question No">
      <ItemTemplate> 
      <table>
      <tr>
      <td>
          
      </td>
      <td>
          <asp:CheckBox ID="CheckBox1" runat="server" 
            oncheckedchanged="CheckBox1_CheckedChanged" AutoPostBack="true"  Text = '<%# Bind("questionid") %>'  />
       <asp:Label ID="Label1" runat="server" Text ="question" ></asp:Label>
        
      </td>
      </tr>
      </table>
      </ItemTemplate>
      </asp:TemplateField>
      </Columns>
        </asp:GridView>
   <%-- </div>--%>
    <div style="float:right;">
     
    </div>
    
       
        </div></div>
        <!-- ###### --><br />
        
        
        <div id="right_column">
        <asp:MultiView ID="MultiView1" runat="server">
          <asp:View ID ="textbox" runat="server" >
          
              <asp:GridView ID="txtgrid" runat="server" AutoGenerateColumns="False" 
                  BorderStyle="None" GridLines="None">
              <Columns>
              <asp:TemplateField HeaderText ="">
              <ItemTemplate>
              <table>
              <tr>
              <td>
                  <asp:Label ID="Label2" runat="server" Text='<%# Bind("question") %>'></asp:Label>
              </td></tr>
              <tr>
              </td>
                  <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
              </tr>
              </table>
              
              </ItemTemplate>
              </asp:TemplateField>
              </Columns>
              </asp:GridView>
          
          
          </asp:View>
          
          <asp:View ID ="checkbox" runat="server"  >
              <asp:GridView ID="rdogrid" runat="server" AutoGenerateColumns="False" 
                  BorderStyle="None" GridLines="None">
              <Columns>
              <asp:TemplateField HeaderText ="">
              <ItemTemplate>
              
              <table>
              <tr>
              <td>
              <asp:Label ID="Label2" runat="server" Text='<%# Bind("question") %>'></asp:Label>
             
                  <br /> 
              </td>
              
              
              </tr>
              <tr>
              <td>
                <br /> 
                  Option 1: <asp:CheckBox ID="CheckBox2"  oncheckedchanged="CheckBox2_CheckedChanged"  AutoPostBack="true"  runat="server" Text='<%# Bind("option1") %>' />
                  <br />  <br /> Option 2: <asp:CheckBox ID="CheckBox3" oncheckedchanged="CheckBox3_CheckedChanged" AutoPostBack="true" runat="server"  Text='<%# Bind("option2") %>'/>
                  <br />  <br />  Option 3:  <asp:CheckBox ID="CheckBox4" oncheckedchanged="CheckBox4_CheckedChanged" AutoPostBack="true" runat="server"  Text='<%# Bind("option3") %>'/>
                    <br />   <br /> Option 4:<asp:CheckBox ID="CheckBox5" oncheckedchanged="CheckBox5_CheckedChanged" AutoPostBack="true" runat="server"  Text='<%# Bind("option4") %>'/>
              </td>
              </tr>
              </table>
              
              </ItemTemplate>
              </asp:TemplateField>
              </Columns>
              </asp:GridView>
          
          </asp:View>
        
        <asp:View ID ="radio"  runat="server" >
              <asp:GridView ID="chkgrid" runat="server" AutoGenerateColumns="False" 
                  BorderStyle="None" GridLines="None" 
                  >
              <Columns>
              <asp:TemplateField HeaderText ="">
              <ItemTemplate>
              
              <table>
              <tr>
              <td>
              <asp:Label ID="Label2" runat="server" Text='<%# Bind("question") %>'></asp:Label>
             
                <br /> 
              </td>
                <br /> 
              
              </tr>
              <tr>
              <td>
                 Option 1:<asp:RadioButton ID="RadioButton1"  runat="server" Text='<%# Bind("option1") %>' 
                GroupName="1" oncheckedchanged="RadioButton1_CheckedChanged1" AutoPostBack="true" />  
                 <br />  <br /> Option 2: <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="true" Text='<%# Bind("option2") %>' 
                GroupName="1" oncheckedchanged="RadioButton2_CheckedChanged" />
                  <br /> <br /> Option 3: <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="true" Text='<%# Bind("option3") %>' 
                GroupName="1" oncheckedchanged="RadioButton3_CheckedChanged"/>
                  <br /> <br /> Option 4: <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="true"  Text='<%# Bind("option4") %>' 
                GroupName="1" oncheckedchanged="RadioButton4_CheckedChanged" />
                  
                 
              </td>
              </tr>
              </table>
              
              </ItemTemplate>
              </asp:TemplateField>
              </Columns>
              </asp:GridView>
         
          </asp:View>
        
        </asp:MultiView>
         <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="SAVE IT" />
 <asp:Button ID="Button1" runat="server" Text="PAUSE" onclick="Button1_Click" />

 <asp:Button ID="Button4" runat="server"  Text="BACK TO HOME" onclick="Button4_Click" />

<asp:Button ID="Button5" runat="server"  Text="FINISH EXAM" onclick="Button5_Click" />




         
            <br />
            <br />
            <asp:TextBox ID="txttestquestion" runat="server" Visible="False"></asp:TextBox>
            <br />
        
            <asp:TextBox ID="txttestselected" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:TextBox ID="txttestcorrect" runat="server" Visible="False">0</asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Visible="False">0</asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" Visible="False">5</asp:TextBox>
            <br />
            <br />
            <br />
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

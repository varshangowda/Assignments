<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPCODE7.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validator form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Validator Form</h1>
            <label for ="Textname">Name:</label><br />
              <asp:TextBox ID="Textname" runat="server" /><br />
             <label for ="Textfamilyname">FamilyName:</label> <br />
              <asp:TextBox ID="Textfamilyname" runat="server" /><br />
             <label for ="Textaddress">Address:</label>
            <asp:TextBox ID="Textaddress" runat="server" /><br />
             <label for ="Textcity">City:</label>
            <asp:TextBox ID="Textcity" runat="server" /><br />
             <label for ="Textzipcode">ZipCode:</label>
            <asp:TextBox ID="Textzipcode" runat="server" /><br />
             <label for ="Textphoneno">Phone no:</label>
            <asp:TextBox ID="Textphoneno" runat="server" /><br />
             <label for ="Textemail">Email:</label>
            <asp:TextBox ID="Textemail" runat="server" /><br />
             <asp:Button ID="buttonCheck" runat="server" Text="Check" OnClick="buttonCheck_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
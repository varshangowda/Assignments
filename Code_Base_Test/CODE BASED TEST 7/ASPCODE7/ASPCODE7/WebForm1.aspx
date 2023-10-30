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
            <label for ="textname">Name:</label><br />
              <asp:TextBox ID="Textname" runat="server" /><br />
             <label for ="textfamilyname">FamilyName:</label> <br />
              <asp:TextBox ID="Textfamilyname" runat="server" /><br />
             <label for ="textaddress">Address:</label>
            <asp:TextBox ID="Textaddress" runat="server" /><br />
             <label for ="textcity">City:</label>
            <asp:TextBox ID="Textcity" runat="server" /><br />
             <label for ="textzipcode">ZipCode:</label>
            <asp:TextBox ID="Textzipcode" runat="server" /><br />
             <label for ="textphoneno">Phone no:</label>
            <asp:TextBox ID="Textphoneno" runat="server" /><br />
             <label for ="textlabel">Email:</label>
            <asp:TextBox ID="Textlabel" runat="server" /><br />
             <asp:Button ID="buttonCheck" runat="server" Text="Check" OnClick="buttonCheck_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz page.aspx.cs" Inherits="WebApplication1.Quiz_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="radio" name="q1" value="1" />
            <input type="radio" name="q1" value="2" />
            <input type="radio" name="q1" value="3" />
            <input type="radio" name="q1" value="4" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RnD.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Image ID="imgAdmin" ImageUrl="~/Images/admin.png" runat="server" />&nbsp;&nbsp;&nbsp;
            <asp:Image ID="imgAircraft" ImageUrl="~/Images/aircraft.png" runat="server"/>&nbsp;&nbsp;&nbsp;
            <textarea id="txtIP" runat="server"></textarea>
        </div>
    </form>
</body>
</html>

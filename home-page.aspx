<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home-page.aspx.cs" Inherits="WebApplication1.home_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="home.css" rel="stylesheet" type="text/css"/>
    <title></title>
</head>
<body style="background-image:url('/images/backgroung.png');">
    <form id="form1" runat="server">
         <div id="nav">
          <div id="logo"> <img src="images/company.png" /></div>
            <div id="nav1"> 
              <%--  <span>HOME</span>--%>
               <a href="WWWW.aspx"> <span style="color:white; font-weight:bold;" > LogIn</span></a>
            </div>   
      </div>

        <div id="main2" style="display:flex;">
            <div id="homeTxt">
                <h1>Welcome On <br />Online Survey</h1>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
                    <br />Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    <br />when an unknow</p>
                <asp:Button ID="Button1" runat="server" Text="Start Survey" CssClass="butt" OnClick="Button1_Click" />
<%--<button action="WWWW.aspx" runat="server"  id="butt">Start Survey </button>--%>

              
                
                <div id="foote">
                   <a href="https://www.facebook.com/"> <img src="/img/facebook.png" /> </a>
                   <a href="https://www.linkedin.com/">  <img src="/img/linked.png" /></a>
                    <a href="https://www.instagram.com/"> <img src="/img/inst.png" /></a>
                   <a href="https://twitter.com/">  <img src="/img/twitter.png" /></a>
                </div>
            </div>
            <div id="homeTxt2">
                <img id="home" src="images/dsdshgfhf.png" />
            </div>
        </div>
     <div  id="copy"> <span>All rights reserved © 2022</span></div> 
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result-page.aspx.cs" Inherits="WebApplication1.result_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="result.css" rel="stylesheet" />
</head>
<body  style="background-image:url('/images/k.png'); background-size:cover ; background-repeat:no-repeat;">
    <form id="form1" runat="server">
        <div id="nav">
          <div id="logo"> <img src="/images/company.png" /></div>
            <div id="nav1"> 
                <span > LogOut</span>
            </div>   
      </div>
        <div id="main">
            <div id="main2">
                <h1 id="name" runat="server"></h1>
                <h2 id="date"  runat="server"></h2>
                <div class="Quastion">
                    <p id="q1"  runat="server">Q1)</p>
                    <p id="s1"  runat="server"></p>
                </div>
                 <div class="Quastion">
                    <p id="q2"  runat="server">Q2)</p>
                    <p id="s2"  runat="server"></p>
                </div>
                 <div class="Quastion">
                    <p id="q3"  runat="server">Q3)</p>
                    <p id="s3"  runat="server"></p>
                </div>
                 <div class="Quastion">
                    <p id="q4"  runat="server">Q4)</p>
                    <p id="s4"  runat="server"></p>
                </div>
                 <div class="Quastion">
                    <p id="q5"  runat="server">Q5)</p>
                    <p id="s5"  runat="server"></p>
                </div>
                 <div class="Quastion">
                    <p id="q6"  runat="server">Q6)</p>
                    <p id="s6"  runat="server"></p>
                </div>
                <div class="Quastion">
                    <p id="q7"  runat="server">Q7)</p>
                    <p id="s7"  runat="server"></p>
                </div>
                <div class="Quastion">
                    <p id="q8"  runat="server">Q8)</p>
                    <p id="s8"  runat="server"></p>
                </div>
                <div class="Quastion">
                    <p id="q9"  runat="server">Q9)</p>
                    <p id="s9"  runat="server"></p>
                </div>
                <div class="Quastion">
                    <p id="q10"  runat="server">Q10)</p>
                    <p id="s10"  runat="server"></p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

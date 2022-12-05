<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quizpage.aspx.cs" Inherits="WebApplication1.quizpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="quizpage.css" />
</head>
<body>
    <form id="form1" runat="server">
         <div id="header">
            <div id="inner-header">
                <img id="header-img" src="images/company.png" />
            </div>
        </div>
        <div id="big-container">
            <div id="inner-container">
                <div id="l-side">
                    <span id="wellcom" runat="server"> Wellcom <br /> Nsreen <br /> to our <br /> survey  </span> 
                </div>
                <div id="r-side">
                    <p id="questionText" runat="server"> Q1 :How was your experience   Online Survey?  </p>
                    <div id="answers">
                    <div> <input type="radio" name="answer" id="a" value="Excellent"/>
                        <label for="a" id="ansa">Excellent </label></div>
                        <div> <input type="radio" name="answer" id="b"  value="Very good"/>
                        <label for="b" id="ansb">Very good </label></div>
                         <div><input type="radio" name="answer" id="c" value="Good"/>
                        <label for="c" id="ansc">Good </label></div>
                        <div> <input type="radio" name="answer" id="d" value="Poor"/>
                        <label for="d" id="ansd">Poor</label>
                        </div>

                    </div>
                    <div id="button-question">
                        <asp:Label ID="Label1" CssClass="labelNext"  runat="server" Text="Label">Please Choose Answer</asp:Label>
                        <asp:Button ID="Button1" CssClass="btnNext" runat="server" Text="Next" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

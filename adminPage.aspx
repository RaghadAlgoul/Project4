<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="WebApplication1.adminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css"/>
    <style type="text/css">
        
    </style>
</head>
<body style="background-image:url('pg.png');">
    <form id="form1" runat="server">


        <header>
            <div>
                <img src="images/company.png" alt="logo"/>
                <nav>
                    <a href="home-page.aspx">Home</a>
                    <a href="WWWW.aspx">Log Out</a>
                </nav>
            </div>
        </header>

       





        <div class="addQuestion-main">
            <div class="addQuestion-inner">
            
            <asp:TextBox ID="Quesstion" runat="server" placeholder="Add Question ..." ></asp:TextBox><br />
            <asp:Button CssClass="btnAdd" ID="Button1" runat="server" OnClick="Button1_Click" Text="Add new question" />
            </div>
        </div>



    <div class="main-div">
        <div class="inner-div">
            <div class="question-row" id="rowQ1" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q1</div>
                    
                    <asp:Label CssClass="labeltxt" ID="Label16" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox  ID="TextBox2" runat="server" CssClass="txtQuesstion" EnableViewState="true"  ></asp:TextBox>
                    
                </div>
                <div class="question-edit">
                    <asp:Button ID="Button5" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button5_Click" />
                    <asp:Button ID="Button6" runat="server" Text="Update" CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button6_Click" />
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button25" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button25_Click" />
                </div>
            </div>


            <div class="question-row" id="rowQ2" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q2</div>
                    <asp:Label CssClass="labeltxt" ID="Label17" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button7" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button7_Click1" />
                    <asp:Button ID="Button8" runat="server" Text="Update"  CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button8_Click"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button26" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button26_Click" />
                </div>
            </div>
            <div class="question-row" id="rowQ3" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q3</div>
                    <asp:Label CssClass="labeltxt" ID="Label18" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button9" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button9_Click1" />
                    <asp:Button ID="Button10" runat="server" Text="Update"  CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button10_Click"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button27" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button27_Click" />
                </div>
            </div>
            <div class="question-row" id="rowQ4" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q4</div>
                    <asp:Label CssClass="labeltxt" ID="Label19" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button11" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button11_Click1" />
                    <asp:Button ID="Button12" runat="server" Text="Update"  CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button12_Click" style="width: 16px"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button28" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button28_Click" />
                </div>
            </div>
            <div class="question-row" id="rowQ5" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q5</div>
                    <asp:Label CssClass="labeltxt" ID="Label20" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button13" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button13_Click1" />
                    <asp:Button ID="Button14" runat="server" Text="Update"  CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button14_Click"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button29" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button29_Click" />
                </div>
            </div>
            <div class="question-row" id="rowQ6" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q6</div>
                    <asp:Label CssClass="labeltxt" ID="Label21" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button15" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button15_Click1" />
                    <asp:Button ID="Button16" runat="server" Text="Update"  CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button16_Click"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button30" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button30_Click" />
                </div>
            </div>
            <div class="question-row" id="rowQ7" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q7</div>
                    <asp:Label CssClass="labeltxt" ID="Label22" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button17" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button17_Click1" />
                    <asp:Button ID="Button18" runat="server" Text="Update"  CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button18_Click"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button31" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button31_Click" />
                </div>
            </div>
            <div class="question-row" id="rowQ8" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q8</div>
                    <asp:Label CssClass="labeltxt" ID="Label23" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button19" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button19_Click1" />
                    <asp:Button ID="Button20" runat="server" Text="Update" CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button20_Click"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button32" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button32_Click" />
                </div>
            </div>
            <div class="question-row" id="rowQ9" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q9</div>
                    <asp:Label CssClass="labeltxt" ID="Label24" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button21" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button21_Click1" />
                    <asp:Button ID="Button22" runat="server" Text="Update"  CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button22_Click"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button33" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button33_Click" />
                </div>
            </div>
            <div class="question-row" id="rowQ10" runat="server">
                <div class="question-text" >
                    <div class="qNumber">Q10</div>
                    <asp:Label CssClass="labeltxt" ID="Label25" runat="server" Text="Label"></asp:Label>
                    <asp:TextBox ID="TextBox11" runat="server" CssClass="txtQuesstion"></asp:TextBox>
                </div>
                <div class="question-edit">
                     <asp:Button ID="Button23" runat="server" Text="Edit"  CssClass="quesstions-buttons quesstions-buttons-purpil" OnClick="Button23_Click1" />
                    <asp:Button ID="Button24" runat="server" Text="Update"  CssClass="quesstions-buttons quesstions-buttons-purpil btn-update" OnClick="Button24_Click"/>
                </div>
                <div class="question-delete">
                    <asp:Button ID="Button34" runat="server" Text="Delete" CssClass="quesstions-buttons quesstions-buttons-red" OnClick="Button34_Click" />
                </div>
            </div>

        </div>
    </div>
        <div id="data-btn">
            <asp:Button CssClass="btnAdd" ID="Button2" runat="server" Text="Show Users Data" OnClick="Button2_Click" />
        </div> 

  
    </form>
   

</body>
</html>

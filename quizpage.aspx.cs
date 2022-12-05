using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public class count
    {
        public static int index = 0;
        public static string[] answers = new string[10];
    }

    public partial class quizpage : System.Web.UI.Page
    {

        static string name = "hassan";
        static string date = DateTime.Now.ToString("M-d-yyyy");
        string fileName = name + date + ".txt";

        protected void Page_Load(object sender, EventArgs e)
        {
            wellcom.InnerHtml = $" Wellcom <br /> {Request.QueryString["userName"]} <br /> to our <br /> survey";

            if (!IsPostBack)
            {

                string[] questions = File.ReadAllLines("/project4/questions/test.txt");
                questionText.InnerHtml = questions[0];

                //string pathCreat = "/project4/users/user/" + fileName;
                //File.Create(pathCreat);
                //using (StreamWriter sw = File.AppendText("/project4/users/users.txt"))
                //{
                //    sw.WriteLine(name);
                //    sw.WriteLine(date);
                //    sw.WriteLine(fileName);
                //}
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Form["answer"] == null)
            {
                Label1.Attributes.Add("style", "display:inline-block");
                return;
            }
            else
            {
                Label1.Attributes.Add("style", "display:none");
            }
            string[] questions = File.ReadAllLines("/project4/questions/test.txt");
            try
            {
                count.answers[count.index] = Request.Form["answer"];
            }
            catch
            {
                Label1.Text = Convert.ToString(count.index);
            }

            count.index++;

            if (count.index == 9)
            {
                Button1.Text = "Finish";
            }
             string name = Request.QueryString["username"];
             string date = DateTime.Now.ToString("M-d-yyyy");
             fileName = name + date + ".txt";
            if (count.index > 9)
            {
                using (StreamWriter sw = File.AppendText("/project4/users/user/" + fileName))
                {
                    sw.WriteLine(name);
                    sw.WriteLine(date);
                    for (int i = 0; i < 10; i++)
                    {
                        sw.WriteLine(questions[i]);
                        sw.WriteLine(count.answers[i]);
                    }

                }

                using (StreamWriter sw = File.AppendText("/project4/users/users.txt"))
                {
                    sw.WriteLine(name);
                    sw.WriteLine(date);
                    sw.WriteLine(fileName);
                }
                Response.Redirect("thanksPage.aspx");
                return;
            }
            questionText.InnerHtml = questions[count.index];


            //using (StreamWriter sw = File.AppendText("/project4/users/user/nsreen12-4-2022.txt" ))
            //{
            //    sw.WriteLine(questionText.InnerHtml);
            //    sw.WriteLine(Request.Form["answer"]);

            //}

        }
    }
}
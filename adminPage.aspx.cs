using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


namespace WebApplication1
{

    
    public partial class adminPage : System.Web.UI.Page
    {
        public string path = "C:\\Users\\dell\\Desktop\\project\\WebApplication1\\WebApplication1\\test.txt";




        //public void updateQuesstion()
        //{ 
        //    string path = "C:\\Users\\dell\\Desktop\\project\\WebApplication1\\WebApplication1\\test.txt";
        //    string[] quession = File.ReadAllLines(path);
        //    string[] quesstinsFiltered = new string[quession.Length];
        //    try
        //    {
        //        quession[0] = TextBox2.Text;
        //        quession[1] = TextBox3.Text;
        //        quession[2] = TextBox4.Text;
        //        quession[3] = TextBox5.Text;
        //        quession[4] = TextBox6.Text;
        //        quession[5] = TextBox7.Text;
        //        quession[6] = TextBox8.Text;
        //        quession[7] = TextBox9.Text;
        //        quession[8] = TextBox10.Text;
        //        quession[9] = TextBox11.Text;
        //    }
        //    catch
        //    {

        //    }
        //    quession = quession.Where(x => !string.IsNullOrEmpty(x)).ToArray();


        //    File.WriteAllLines(path, quession);//write array to file
        //    //roww5.Attributes.Add("style", "display:none");
        //    loadQuesstion();
        //}

        public void loadQuesstion()
        {
            rowQ1.Style.Add("display", "none");
            rowQ2.Style.Add("display", "none");
            rowQ3.Style.Add("display", "none");
            rowQ4.Style.Add("display", "none");
            rowQ5.Style.Add("display", "none");
            rowQ6.Style.Add("display", "none");
            rowQ7.Style.Add("display", "none");
            rowQ8.Style.Add("display", "none");
            rowQ9.Style.Add("display", "none");
            rowQ10.Style.Add("display", "none");


            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);

            try 
            {
                if (quession[0] != null)
                {
                    rowQ1.Style.Add("display", "flex");
                    Label16.Text = quession[0];
                    TextBox2.Text = quession[0];
                }
                if (quession[1] != null)
                {
                    rowQ2.Style.Add("display", "flex");
                    Label17.Text = quession[1];
                    TextBox3.Text = quession[1];
                }
                if (quession[2] != null)
                {
                    rowQ3.Style.Add("display", "flex");
                    Label18.Text = quession[2];
                    TextBox4.Text = quession[2];
                }
                if (quession[3] != null)
                {
                    rowQ4.Style.Add("display", "flex");
                    Label19.Text = quession[3];
                    TextBox5.Text = quession[3];
                }
                if (quession[4] != null)
                {
                    rowQ5.Style.Add("display", "flex");
                    Label20.Text = quession[4];
                    TextBox6.Text = quession[4];
                }
                if (quession[5] != null)
                {
                    rowQ6.Style.Add("display", "flex");
                    Label21.Text = quession[5];
                    TextBox7.Text = quession[5];
                }
                if (quession[6] != null)
                {
                    rowQ7.Style.Add("display", "flex");
                    Label22.Text = quession[6];
                    TextBox8.Text = quession[6];
                }
                if (quession[7] != null)
                {
                    rowQ8.Style.Add("display", "flex");
                    Label23.Text = quession[7];
                    TextBox9.Text = quession[7];
                }
                if (quession[8] != null)
                {
                    rowQ9.Style.Add("display", "flex");
                    Label24.Text = quession[8];
                    TextBox10.Text = quession[8];
                }
                if (quession[9] != null)
                {
                    rowQ10.Style.Add("display", "flex");
                    Label25.Text = quession[9];
                    TextBox11.Text = quession[9];
                }
            }
            catch
            {
                
            }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (!IsPostBack)
                {
                    loadQuesstion();
                }
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string path = Path.Combine(@"C:\Users\dell\Desktop\project\WebApplication1\WebApplication1\test.txt");
            string path = "/project4/questions/test.txt";
            //string path = Path.Combine(Directory.GetCurrentDirectory(), "\\test.txt");
            if (Quesstion.Text == "")
            {
                return;
            }
            string[] quession = File.ReadAllLines("/project4/questions/test.txt");
            
            if (quession.Length >= 10)
            {
                return;
            }
            else
            {
                string question = Quesstion.Text;
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(question);

                }

                
                Quesstion.Text = "";

            }

            loadQuesstion();
        }

       

      

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           

            
            string[] quession = File.ReadAllLines("/project4/questions/test.txt");
            string[] quesstinsFiltered = new string[quession.Length];
            for(int i = 0;i< quession.Length;i++)
            {
                if (i == 5)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            string path = "/project4/questions/test.txt";
            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();



            Quesstion.Text = "";

        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            
            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 6)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 8)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 9)
                {
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            loadQuesstion();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label16.Attributes.Add("style", "display:none");
            TextBox2.Attributes.Add("style", "display:inline-block");
            Button5.Attributes.Add("style", "display:none");
            Button6.Attributes.Add("style", "display:inline-block");
        }
      

        protected void Button7_Click1(object sender, EventArgs e)
        {
            Label17.Attributes.Add("style", "display:none");
            TextBox3.Attributes.Add("style", "display:inline-block");
            Button7.Attributes.Add("style", "display:none");
            Button8.Attributes.Add("style", "display:inline-block");
        }

        protected void Button9_Click1(object sender, EventArgs e)
        {
            Label18.Attributes.Add("style", "display:none");
            TextBox4.Attributes.Add("style", "display:inline-block");
            Button9.Attributes.Add("style", "display:none");
            Button10.Attributes.Add("style", "display:inline-block");
        }

        protected void Button11_Click1(object sender, EventArgs e)
        {
            Label19.Attributes.Add("style", "display:none");
            TextBox5.Attributes.Add("style", "display:inline-block");
            Button11.Attributes.Add("style", "display:none");
            Button12.Attributes.Add("style", "display:inline-block");
        }

        protected void Button13_Click1(object sender, EventArgs e)
        {
            Label20.Attributes.Add("style", "display:none");
            TextBox6.Attributes.Add("style", "display:inline-block");
            Button13.Attributes.Add("style", "display:none");
            Button14.Attributes.Add("style", "display:inline-block");
        }

        protected void Button15_Click1(object sender, EventArgs e)
        {
            Label21.Attributes.Add("style", "display:none");
            TextBox7.Attributes.Add("style", "display:inline-block");
            Button15.Attributes.Add("style", "display:none");
            Button16.Attributes.Add("style", "display:inline-block");
        }

        protected void Button17_Click1(object sender, EventArgs e)
        {
            Label22.Attributes.Add("style", "display:none");
            TextBox8.Attributes.Add("style", "display:inline-block");
            Button17.Attributes.Add("style", "display:none");
            Button18.Attributes.Add("style", "display:inline-block");
        }

        protected void Button19_Click1(object sender, EventArgs e)
        {
            Label23.Attributes.Add("style", "display:none");
            TextBox9.Attributes.Add("style", "display:inline-block");
            Button19.Attributes.Add("style", "display:none");
            Button20.Attributes.Add("style", "display:inline-block");
        }

        protected void Button21_Click1(object sender, EventArgs e)
        {
            Label24.Attributes.Add("style", "display:none");
            TextBox10.Attributes.Add("style", "display:inline-block");
            Button21.Attributes.Add("style", "display:none");
            Button22.Attributes.Add("style", "display:inline-block");
        }

        protected void Button23_Click1(object sender, EventArgs e)
        {
            Label25.Attributes.Add("style", "display:none");
            TextBox11.Attributes.Add("style", "display:inline-block");
            Button23.Attributes.Add("style", "display:none");
            Button24.Attributes.Add("style", "display:inline-block");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox2.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox2.Text;   
            }
            
            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 0)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label16.Text = newQuesstion;

            Label16.Attributes.Add("style", "display:block");
            TextBox2.Attributes.Add("style", "display:none");
            Button5.Attributes.Add("style", "display:inline-block");
            Button6.Attributes.Add("style", "display:none");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox3.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox3.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 1)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label17.Text = newQuesstion;
            Label17.Attributes.Add("style", "display:inline-block");
            TextBox3.Attributes.Add("style", "display:none");
            Button7.Attributes.Add("style", "display:inline-block");
            Button8.Attributes.Add("style", "display:none");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox4.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox4.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 2)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label18.Text = newQuesstion;
            Label18.Attributes.Add("style", "display:inline-block");
            TextBox4.Attributes.Add("style", "display:none");
            Button9.Attributes.Add("style", "display:inline-block");
            Button10.Attributes.Add("style", "display:none");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox5.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox5.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 3)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label19.Text = newQuesstion;
            Label19.Attributes.Add("style", "display:inline-block");
            TextBox5.Attributes.Add("style", "display:none");
            Button11.Attributes.Add("style", "display:inline-block");
            Button12.Attributes.Add("style", "display:none");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox6.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox6.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 4)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label20.Text = newQuesstion;
            Label20.Attributes.Add("style", "display:inline-block");
            TextBox6.Attributes.Add("style", "display:none");
            Button13.Attributes.Add("style", "display:inline-block");
            Button14.Attributes.Add("style", "display:none");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox7.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox7.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 5)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label21.Text = newQuesstion;
            Label21.Attributes.Add("style", "display:inline-block");
            TextBox7.Attributes.Add("style", "display:none");
            Button15.Attributes.Add("style", "display:inline-block");
            Button16.Attributes.Add("style", "display:none");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox8.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox8.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 6)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label22.Text = newQuesstion;
            Label22.Attributes.Add("style", "display:inline-block");
            TextBox8.Attributes.Add("style", "display:none");
            Button17.Attributes.Add("style", "display:inline-block");
            Button18.Attributes.Add("style", "display:none");
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox9.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox9.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 7)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label23.Text = newQuesstion;
            Label23.Attributes.Add("style", "display:inline-block");
            TextBox9.Attributes.Add("style", "display:none");
            Button19.Attributes.Add("style", "display:inline-block");
            Button20.Attributes.Add("style", "display:none");
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox10.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox10.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 8)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label24.Text = newQuesstion;
            Label24.Attributes.Add("style", "display:inline-block");
            TextBox10.Attributes.Add("style", "display:none");
            Button21.Attributes.Add("style", "display:inline-block");
            Button22.Attributes.Add("style", "display:none");
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            string newQuesstion = string.Empty;
            if (TextBox11.Text == "")
            {
                return;
            }
            else
            {
                newQuesstion = TextBox11.Text;
            }

            string path = "/project4/questions/test.txt";
            string[] quession = File.ReadAllLines(path);
            string[] quesstinsFiltered = new string[quession.Length];
            for (int i = 0; i < quession.Length; i++)
            {
                if (i == 9)
                {
                    quesstinsFiltered[i] = newQuesstion;
                    continue;
                }
                quesstinsFiltered[i] = quession[i];
            }
            quesstinsFiltered = quesstinsFiltered.Where(x => !string.IsNullOrEmpty(x)).ToArray();


            File.WriteAllLines(path, quesstinsFiltered);//write array to file
            //roww5.Attributes.Add("style", "display:none");
            Label25.Text = newQuesstion;
            Label25.Attributes.Add("style", "display:inline-block");
            TextBox11.Attributes.Add("style", "display:none");
            Button23.Attributes.Add("style", "display:inline-block");
            Button24.Attributes.Add("style", "display:none");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}
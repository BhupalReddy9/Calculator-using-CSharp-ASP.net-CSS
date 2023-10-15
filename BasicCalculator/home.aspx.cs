using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicCalculator
{
    public partial class home : System.Web.UI.Page
    {
        string ip = "", ans;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void equalto_Click(object sender, EventArgs e)
        {
            ip += Input.Text.ToString();
            try
            {
                ans = new DataTable().Compute(ip, null).ToString();
                Output.Text = ans.ToString();
            }
            catch (Exception ex)
            {
                Output.Text = "Wrong Expression";
            }
            

        }

        protected void Delete_Click(object sender, EventArgs e)
        {

            ip += Input.Text.ToString();
            ans = ip.Remove(ip.Length -1);
            Input.Text = ans.ToString();
        }


            protected void Divide_Click(object sender, EventArgs e)
        {
            ip += Input.Text.ToString();
            ip += "/";
            Input.Text = ip.ToString();
        }
        protected void multiple_Click(object sender, EventArgs e)
        {
            ip += Input.Text.ToString();
            ip += "*";
            Input.Text = ip.ToString();
        }
        protected void plus_Click(object sender, EventArgs e)
        {
            ip += Input.Text.ToString();
            ip += "+";
            Input.Text = ip.ToString();
        }

        protected void minus_Click(object sender, EventArgs e)
        {
            ip += Input.Text.ToString();
            ip += "-";
            Input.Text = ip.ToString();
        }


        protected void getinput(char a)
        {
            ip += Input.Text.ToString();
            ip += a;
            Input.Text = ip.ToString();
        }
        protected void seven_Click(object sender, EventArgs e)
        {
            getinput('7');
        }

        protected void eight_Click(object sender, EventArgs e)
        {
            getinput('8');
            
        }

        protected void nine_Click(object sender, EventArgs e)
        {
            getinput('9');
        }

        
        protected void four_Click(object sender, EventArgs e)
        {
            getinput('4');
        }

        protected void five_Click(object sender, EventArgs e)
        {
            getinput('5');
        }

        protected void six_Click(object sender, EventArgs e)
        {
            getinput('6');
        }

      
        protected void one_Click(object sender, EventArgs e)
        {
            getinput('1');
        }

        protected void two_Click(object sender, EventArgs e)
        {
            getinput('2');
        }

        protected void three_Click(object sender, EventArgs e)
        {
            getinput('3');
        }

       
        protected void zero_Click(object sender, EventArgs e)
        {
            getinput('0');
        }

        protected void dot_Click(object sender, EventArgs e)
        {
            getinput('.');
        }

    

        protected void AllClear_Click(object sender, EventArgs e)
        {
            Input.Text = String.Empty;
            Output.Text = String.Empty;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            Input.Text = String.Empty;

        }
    }
}
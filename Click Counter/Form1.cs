using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Counter
{
    public partial class ClickCounterForm : Form
    {
        Random ran;
        Timer time;
        int count = 0;
        Color red = Color.Red;
        Color green = Color.Green;
        int scoreint = 0;
        public ClickCounterForm()
        {
            InitializeComponent();

            ran = new Random();

            time = new Timer();
            time.Enabled = true;
            time.Interval = 1200;
            time.Tick += Time_Tick;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            int x = ran.Next(1, 11);
            if (x.ToString() == Button1.Text)
            {
                Button1.BackColor = green;  Button2.BackColor = red; Button3.BackColor = red;
                Button4.BackColor = red;    Button5.BackColor = red; Button6.BackColor = red;
                Button7.BackColor = red;    Button8.BackColor = red; Button9.BackColor = red;
                Button10.BackColor = red;
            }
            else if(x.ToString()==Button2.Text)
            {
                Button1.BackColor = red; Button2.BackColor = green; Button3.BackColor = red;
                Button4.BackColor = red; Button5.BackColor = red; Button6.BackColor = red;
                Button7.BackColor = red; Button8.BackColor = red; Button9.BackColor = red;
                Button10.BackColor = red;
            }
            else if (x.ToString() == Button3.Text)
            {
                Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = green;
                Button4.BackColor = red; Button5.BackColor = red; Button6.BackColor = red;
                Button7.BackColor = red; Button8.BackColor = red; Button9.BackColor = red;
                Button10.BackColor = red;
            }
            else if (x.ToString() == Button4.Text)
            {
                Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = red;
                Button4.BackColor = green; Button5.BackColor = red; Button6.BackColor = red;
                Button7.BackColor = red; Button8.BackColor = red; Button9.BackColor = red;
                Button10.BackColor = red;
            }
            else if (x.ToString() == Button5.Text)
            {
                Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = red;
                Button4.BackColor = red; Button5.BackColor = green; Button6.BackColor = red;
                Button7.BackColor = red; Button8.BackColor = red; Button9.BackColor = red;
                Button10.BackColor = red;
            }
            else if (x.ToString() == Button6.Text)
            {
                Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = red;
                Button4.BackColor = red; Button5.BackColor = red; Button6.BackColor = green;
                Button7.BackColor = red; Button8.BackColor = red; Button9.BackColor = red;
                Button10.BackColor = red;
            }
            else if (x.ToString() == Button7.Text)
            {
                Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = red;
                Button4.BackColor = red; Button5.BackColor = red; Button6.BackColor = red;
                Button7.BackColor = green; Button8.BackColor = red; Button9.BackColor = red;
                Button10.BackColor = red;
            }
            else if (x.ToString() == Button8.Text)
            {
                Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = red;
                Button4.BackColor = red; Button5.BackColor = red; Button6.BackColor = red;
                Button7.BackColor = red; Button8.BackColor = green; Button9.BackColor = red;
                Button10.BackColor = red;
            }
            else if (x.ToString() == Button9.Text)
            {
                Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = red;
                Button4.BackColor = red; Button5.BackColor = red; Button6.BackColor = red;
                Button7.BackColor = red; Button8.BackColor = red; Button9.BackColor = green;
                Button10.BackColor = red;
            }
            else if (x.ToString() == Button10.Text)
            {
                Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = red;
                Button4.BackColor = red; Button5.BackColor = red; Button6.BackColor = red;
                Button7.BackColor = red; Button8.BackColor = red; Button9.BackColor = red;
                Button10.BackColor = green;
            }

            count++;
            if(count==15)
            {
                time.Enabled = false;
                DisableAll();
            }
            if((Convert.ToInt32(Score.Text))>100)
            {
                time.Interval = 900;
            }
            else if ((Convert.ToInt32(Score.Text)) > 200)
            {
                time.Interval = 500;
            }

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            if (buttonText==Button1.Text)
            {
                if (Button1.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if(Button1.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button2.Text)
            {
                if (Button2.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button2.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button3.Text)
            {
                if (Button3.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button3.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button4.Text)
            {
                if (Button4.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button4.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button5.Text)
            {
                if (Button5.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button5.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button6.Text)
            {
                if (Button6.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button6.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button7.Text)
            {
                if (Button7.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button7.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button8.Text)
            {
                if (Button8.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button8.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button9.Text)
            {
                if (Button9.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button9.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if (buttonText == Button10.Text)
            {
                if (Button10.BackColor == red)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint - 5;
                    Score.Text = scoreint.ToString();
                }
                else if (Button10.BackColor == green)
                {
                    scoreint = Convert.ToInt32(Score.Text);
                    scoreint = scoreint + 15;
                    Score.Text = scoreint.ToString();
                }
            }
            if(buttonText==ExitButton.Text)
            {
                Application.Exit();
            }
            else if(buttonText==ReplayButton.Text)
            {
                count = 0;
                Reset();
                time.Enabled = true;
                time.Interval = 1200;
                Score.Text = scoreint.ToString();
            }
        }
        public void DisableAll()
        {
            Button1.BackColor = red; Button2.BackColor = red; Button3.BackColor = red;
            Button4.BackColor = red; Button5.BackColor = red; Button6.BackColor = red;
            Button7.BackColor = red; Button8.BackColor = red; Button9.BackColor = red;
            Button10.BackColor = red;

            Button1.Enabled = false; Button2.Enabled = false;
            Button3.Enabled = false; Button4.Enabled = false;
            Button5.Enabled = false; Button6.Enabled = false;
            Button7.Enabled = false; Button8.Enabled = false;
            Button9.Enabled = false; Button10.Enabled = false;
            ReplayButton.Enabled = true; ExitButton.Enabled = true;

            scoreint = 0;
        }
        public void Reset()
        {
            Button1.Enabled = true; Button2.Enabled = true;
            Button3.Enabled = true; Button4.Enabled = true;
            Button5.Enabled = true; Button6.Enabled = true;
            Button7.Enabled = true; Button8.Enabled = true;
            Button9.Enabled = true; Button10.Enabled = true;
            ReplayButton.Enabled = false; ExitButton.Enabled = false;

            scoreint = 0;
        }
    }
}

using System;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Windows.Forms;

namespace SharpReview
{
    public partial class NotificationForm : Form
    {
        public String SubjectText;
        public String QuestionText;
        public String AnswerText;
        
        Timer t1 = new Timer();
        
        public NotificationForm()
        {
            InitializeComponent();
            Opacity = 0;
        }


        private void NotificationForm_Load(object sender, EventArgs e)
        {
            SubjectLabel.Text = SubjectText;
            QuestionLabel.Text = QuestionText;
            AnswerLabel.Text = AnswerText;
            
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - 50);
            this.StartPosition = FormStartPosition.Manual;
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }
        
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Interval = 120;
                t1.Tick += new EventHandler(waitForABit); //this stops the timer if the form is completely displayed
            }
            else
                Opacity += 0.005;
        }

        void waitForABit(object sender, EventArgs e)
        {
            t1.Interval = 8400;
            t1.Tick += new EventHandler(fadeOut);
        }

        void fadeOut(object sender, EventArgs e)
        {
            t1.Interval = 120;
            if (Opacity <= 0)
            {
                t1.Stop();
                this.Close();
            }
            else
                Opacity -= 0.05;
        }
        
    }
}
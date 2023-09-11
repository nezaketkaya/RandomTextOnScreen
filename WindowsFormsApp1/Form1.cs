using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }
        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the coordinates of where you click.
            int x = e.X;
            int y = e.Y;
            Random random = new Random();
            
            // Generate a random color.
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            // Generate a random size.
            int randomSize = random.Next(10, 20); // A random size between 10 and 20. 

            // Generate random text.
            string[] texts = {"Dream big, work hard.", "Believe in yourself.", "Your hard work will pay off.",
            "Success starts with a single step.","Every day is a new opportunity.", "Embrace the challenges, they make you stronger.",
            "The only limit is your mind.", "Success is not final, failure is not fatal: It is the courage to continue that counts.",
             "You are the author of your own story.", "Failure is a stepping stone to success.", "Don't watch the clock; do what it does. Keep going.",
             "The future depends on what you do today.", "You are never too old to set another goal or to dream a new dream.",
             "You are never alone in your struggles."};
            Random random1 = new Random();
            string randomText = texts[random1.Next(texts.Length)];


            // Set the position and text of the Label or TextBox control.
            Label newLabel = new Label();
            newLabel.Text = randomText;
            newLabel.AutoSize = true; // Set the Label size automatically according to the text size.
            newLabel.Location = new Point(x, y);
            


            // Set random text color
            newLabel.ForeColor = randomColor; 

            // Set random text size
            newLabel.Font = new Font("Arial", randomSize); 

            // Add the control to the form's Controls collection.
            this.Controls.Add(newLabel);
        }

        
    }
}

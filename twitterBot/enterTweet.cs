using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace twitterBot
{
    public partial class enterTweet : Form
    {
        public enterTweet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("retweetmessage.txt", textBox1.Text);
            this.Close();
        }

        private void enterTweet_Load(object sender, EventArgs e)
        {
            if (File.Exists("retweetmessage.txt"))
            {
                textBox1.Text = File.ReadAllText("retweetmessage.txt");
            }
        }
    }
}

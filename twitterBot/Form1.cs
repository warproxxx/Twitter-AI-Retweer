using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace twitterBot
{
    public partial class Form1 : Form
    {
        static String appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static String currLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        static String apiArgs = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void pythonCheck()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("python.exe");

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.StartInfo.CreateNoWindow = true;


            if (!process.Start())
            {
                MessageBox.Show("Python is not installed! This program will not work");
                Application.Exit();
            }
            else
            {
                process.Kill();
            }
        }

        private void runPython(String scriptname, String arguments="", Boolean wait=true)
        {
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("python.exe");
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            myProcessStartInfo.Arguments = currLocation + "\\" + scriptname + ".py " + arguments;
            //MessageBox.Show(arguments);

            Process myProcess = new Process();
            myProcess.StartInfo = myProcessStartInfo;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();

            //StreamReader myStreamReader = myProcess.StandardOutput;
            //string myString = myStreamReader.ReadLine();

            if (wait == true)
            {
                myProcess.WaitForExit();
                myProcess.Close();
            }
        }

        public static void updateListView(String location, ListView lv)
        {
            using (TextFieldParser parser = new TextFieldParser(location))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {

                    string[] fields = parser.ReadFields();
                    String[] arr = new String[2];

                    arr[0] = fields[1];
                    arr[1] = fields[2];

                    ListViewItem items = new ListViewItem(arr);
                    lv.Items.Add(items);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete("all.csv");
            File.Delete("a.csv");
            File.Delete("high.csv");
            File.Delete("low.csv");
            File.Delete("medium.csv");

            pythonCheck();
            //temporarily commenting as they run in background

            runPython("groupSentiment", "", false);
            runPython("getTweets");


            //update the list view
            updateListView(appData + "\\tweets.csv", listView1);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String input = Microsoft.VisualBasic.Interaction.InputBox("Enter Keyword", "Add Keyword", "");
            keywordsList.Items.Add(input);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in keywordsList.SelectedItems)
            {
                keywordsList.Items.Remove(eachItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enterTweet et = new enterTweet();
            et.ShowDialog();

            String radio_time = "all";

            if (radio_high.Checked)
                radio_time = "high";
            else if (radio_medium.Checked)
                radio_time = "medium";
            else if (radio_low.Checked)
                radio_time = "low";

            String sett = apiArgs + " --file=\"" + radio_time + "\"";

            runPython("performRetweet", sett);
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_location.Checked)
            {
                cityBox.Enabled = true;
                countryBox.Enabled = true;
                radiusBox.Enabled = true;
            }
            else
            {
                cityBox.Enabled = false;
                countryBox.Enabled = false;
                radiusBox.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save the selected to tweet.txt
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                String text = selectedItem.SubItems[1].Text;
                File.WriteAllText("tweet.txt", text);
            }
            else
            {
                MessageBox.Show("You must select a tweet!");
                return;
            }



            listViewHigh.Items.Clear();
            listViewMedium.Items.Clear();
            listViewLow.Items.Clear();
            listViewAll.Items.Clear();

            String settings = "";

            settings = settings + "--consumerkey=\"" + consumerKey.Text + "\" ";
            settings = settings + "--consumersecret=\"" + consumerSecret.Text + "\" ";
            settings = settings + "--accesstoken=\"" + accessToken.Text + "\" ";
            settings = settings + "--accesssecret=\"" + accessSecret.Text + "\" ";

            apiArgs = settings;

            var myList = new List<string>();

            foreach (ListViewItem Item in keywordsList.Items)
            {
                myList.Add(Item.Text.ToString());
            }

            String keywords = String.Join(" OR ", myList);

            settings = settings + "--keywords=\"" + keywords + "\" ";

            if (keywords == "")
            {
                MessageBox.Show("You forgot to add keywords!");
                return;
            }

            if (checkBox_location.Checked)
            {
                settings = settings + "--location=\"1\" ";
                settings = settings + "--city=\"" + cityBox.Text + "\" ";
                settings = settings + "--country=\"" + countryBox.Text + "\" ";
                settings = settings + "--radius=\"" + radiusBox.Text + "\" ";
            }
            else
            {
                settings = settings + "--location=\"0\" ";
                settings = settings + "--city=\" \" ";
                settings = settings + "--country=\" \" ";
                settings = settings + "--radius=\" \" ";
            }

            String radio_time = "all";

            if (radio_1day.Checked)
                radio_time = "1day";
            else if (radio_2day.Checked)
                radio_time = "2day";
            else if (radio_7day.Checked)
                radio_time = "7day";

            settings = settings + "--timeframe=\"" + radio_time + "\" ";
            settings = settings + "--resultcount=\"" + totalResult.Text + "\" ";

            String relevency = "all";

            if (radio_high.Checked)
                relevency = "high";
            else if (radio_medium.Checked)
                relevency = "medium";
            else if (radio_low.Checked)
                relevency = "low";

            settings = settings + "--relevency=\"" + relevency + "\" ";

            //MessageBox.Show(settings);
            
            runPython("searchTweets", settings);

            while (true)
            {
                if (File.Exists("high.csv"))
                {
                    break;
                }
                else
                {
                    Thread.Sleep(500);
                }
            }

            updateListView("high.csv", listViewHigh);
            updateListView("medium.csv", listViewMedium);
            updateListView("low.csv", listViewLow);
            updateListView("all.csv", listViewAll);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enterTweet et = new enterTweet();
            et.ShowDialog();

           
        }
    }
}

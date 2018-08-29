namespace twitterBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tweet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radio_7day = new System.Windows.Forms.RadioButton();
            this.totalResult = new System.Windows.Forms.TextBox();
            this.radio_2day = new System.Windows.Forms.RadioButton();
            this.radio_1day = new System.Windows.Forms.RadioButton();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.radio_allTime = new System.Windows.Forms.RadioButton();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_location = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.keywordsList = new System.Windows.Forms.ListView();
            this.Keyword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accessSecret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accessToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.consumerSecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.consumerKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewAll = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewHigh = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listViewMedium = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listViewLow = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.radio_high = new System.Windows.Forms.RadioButton();
            this.radio_medium = new System.Windows.Forms.RadioButton();
            this.radio_low = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Tweet});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(11, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(557, 232);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 118;
            // 
            // Tweet
            // 
            this.Tweet.Text = "Tweets";
            this.Tweet.Width = 438;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tweets";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radio_7day);
            this.groupBox9.Controls.Add(this.totalResult);
            this.groupBox9.Controls.Add(this.radio_2day);
            this.groupBox9.Controls.Add(this.radio_1day);
            this.groupBox9.Controls.Add(this.radiusBox);
            this.groupBox9.Controls.Add(this.countryBox);
            this.groupBox9.Controls.Add(this.radio_allTime);
            this.groupBox9.Controls.Add(this.cityBox);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.checkBox_location);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Location = new System.Drawing.Point(229, 257);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(339, 134);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Customize Results";
            // 
            // radio_7day
            // 
            this.radio_7day.AutoSize = true;
            this.radio_7day.Location = new System.Drawing.Point(241, 83);
            this.radio_7day.Name = "radio_7day";
            this.radio_7day.Size = new System.Drawing.Size(79, 17);
            this.radio_7day.TabIndex = 21;
            this.radio_7day.Text = "Last 7 days";
            this.radio_7day.UseVisualStyleBackColor = true;
            // 
            // totalResult
            // 
            this.totalResult.Location = new System.Drawing.Point(200, 108);
            this.totalResult.Name = "totalResult";
            this.totalResult.Size = new System.Drawing.Size(26, 20);
            this.totalResult.TabIndex = 18;
            this.totalResult.Text = "100";
            // 
            // radio_2day
            // 
            this.radio_2day.AutoSize = true;
            this.radio_2day.Location = new System.Drawing.Point(155, 83);
            this.radio_2day.Name = "radio_2day";
            this.radio_2day.Size = new System.Drawing.Size(79, 17);
            this.radio_2day.TabIndex = 20;
            this.radio_2day.Text = "Last 2 days";
            this.radio_2day.UseVisualStyleBackColor = true;
            // 
            // radio_1day
            // 
            this.radio_1day.AutoSize = true;
            this.radio_1day.Location = new System.Drawing.Point(80, 83);
            this.radio_1day.Name = "radio_1day";
            this.radio_1day.Size = new System.Drawing.Size(65, 17);
            this.radio_1day.TabIndex = 22;
            this.radio_1day.Text = "Last day";
            this.radio_1day.UseVisualStyleBackColor = true;
            // 
            // radiusBox
            // 
            this.radiusBox.Enabled = false;
            this.radiusBox.Location = new System.Drawing.Point(294, 49);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(36, 20);
            this.radiusBox.TabIndex = 17;
            // 
            // countryBox
            // 
            this.countryBox.Enabled = false;
            this.countryBox.Location = new System.Drawing.Point(155, 49);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(128, 20);
            this.countryBox.TabIndex = 16;
            // 
            // radio_allTime
            // 
            this.radio_allTime.AutoSize = true;
            this.radio_allTime.Checked = true;
            this.radio_allTime.Location = new System.Drawing.Point(9, 83);
            this.radio_allTime.Name = "radio_allTime";
            this.radio_allTime.Size = new System.Drawing.Size(62, 17);
            this.radio_allTime.TabIndex = 19;
            this.radio_allTime.TabStop = true;
            this.radio_allTime.Text = "All Time";
            this.radio_allTime.UseVisualStyleBackColor = true;
            // 
            // cityBox
            // 
            this.cityBox.Enabled = false;
            this.cityBox.Location = new System.Drawing.Point(9, 49);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(140, 20);
            this.cityBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Radius (mi)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Longitude";
            // 
            // checkBox_location
            // 
            this.checkBox_location.AutoSize = true;
            this.checkBox_location.Location = new System.Drawing.Point(9, 15);
            this.checkBox_location.Name = "checkBox_location";
            this.checkBox_location.Size = new System.Drawing.Size(118, 17);
            this.checkBox_location.TabIndex = 10;
            this.checkBox_location.Text = "Customize Location";
            this.checkBox_location.UseVisualStyleBackColor = true;
            this.checkBox_location.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Results:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.keywordsList);
            this.groupBox8.Controls.Add(this.removeButton);
            this.groupBox8.Controls.Add(this.addButton);
            this.groupBox8.Location = new System.Drawing.Point(11, 257);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 134);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Keywords";
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(179, 131);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 22);
            this.groupBox10.TabIndex = 23;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // keywordsList
            // 
            this.keywordsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Keyword});
            this.keywordsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.keywordsList.Location = new System.Drawing.Point(6, 16);
            this.keywordsList.Name = "keywordsList";
            this.keywordsList.Size = new System.Drawing.Size(188, 84);
            this.keywordsList.TabIndex = 5;
            this.keywordsList.UseCompatibleStateImageBehavior = false;
            this.keywordsList.View = System.Windows.Forms.View.Details;
            // 
            // Keyword
            // 
            this.Keyword.Text = "Keyword";
            this.Keyword.Width = 115;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(135, 102);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(59, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 102);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.accessSecret);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.accessToken);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.consumerSecret);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.consumerKey);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Twitter API";
            // 
            // accessSecret
            // 
            this.accessSecret.Location = new System.Drawing.Point(103, 86);
            this.accessSecret.Name = "accessSecret";
            this.accessSecret.Size = new System.Drawing.Size(100, 20);
            this.accessSecret.TabIndex = 7;
            this.accessSecret.Text = "t9hfklwg22UWXe7Cpqf1CLj7t1NOgYbWP5VL0HMlSNJHt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Access Secret:";
            // 
            // accessToken
            // 
            this.accessToken.Location = new System.Drawing.Point(103, 63);
            this.accessToken.Name = "accessToken";
            this.accessToken.Size = new System.Drawing.Size(100, 20);
            this.accessToken.TabIndex = 5;
            this.accessToken.Text = "852009551876431872-vLH3HnR07RewycyCHgheMVWKNC26yr4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Access Token:";
            // 
            // consumerSecret
            // 
            this.consumerSecret.Location = new System.Drawing.Point(103, 40);
            this.consumerSecret.Name = "consumerSecret";
            this.consumerSecret.Size = new System.Drawing.Size(100, 20);
            this.consumerSecret.TabIndex = 3;
            this.consumerSecret.Text = "u2PuEHOuo4XOVSNgzViqAbq4QvpVAVPgXZRFjs1u7CLpjvcx7I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consumer Secret:";
            // 
            // consumerKey
            // 
            this.consumerKey.Location = new System.Drawing.Point(103, 16);
            this.consumerKey.Name = "consumerKey";
            this.consumerKey.Size = new System.Drawing.Size(100, 20);
            this.consumerKey.TabIndex = 1;
            this.consumerKey.Text = "4xOkrmqdMNh07gpi9dZwBu9Mh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumer Key:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewAll);
            this.groupBox3.Location = new System.Drawing.Point(653, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Relevent Tweets";
            // 
            // listViewAll
            // 
            this.listViewAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewAll.GridLines = true;
            this.listViewAll.Location = new System.Drawing.Point(6, 19);
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(315, 102);
            this.listViewAll.TabIndex = 0;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            this.listViewAll.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tweets";
            this.columnHeader2.Width = 438;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listViewHigh);
            this.groupBox4.Location = new System.Drawing.Point(653, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 127);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Highly Relevent Tweets";
            // 
            // listViewHigh
            // 
            this.listViewHigh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewHigh.GridLines = true;
            this.listViewHigh.Location = new System.Drawing.Point(6, 19);
            this.listViewHigh.Name = "listViewHigh";
            this.listViewHigh.Size = new System.Drawing.Size(315, 99);
            this.listViewHigh.TabIndex = 0;
            this.listViewHigh.UseCompatibleStateImageBehavior = false;
            this.listViewHigh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tweets";
            this.columnHeader4.Width = 438;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listViewMedium);
            this.groupBox5.Location = new System.Drawing.Point(653, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(327, 127);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "From Medium Relevance";
            // 
            // listViewMedium
            // 
            this.listViewMedium.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMedium.GridLines = true;
            this.listViewMedium.Location = new System.Drawing.Point(6, 19);
            this.listViewMedium.Name = "listViewMedium";
            this.listViewMedium.Size = new System.Drawing.Size(315, 99);
            this.listViewMedium.TabIndex = 0;
            this.listViewMedium.UseCompatibleStateImageBehavior = false;
            this.listViewMedium.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tweets";
            this.columnHeader6.Width = 438;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listViewLow);
            this.groupBox6.Location = new System.Drawing.Point(653, 411);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 127);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "From Low Relevence";
            // 
            // listViewLow
            // 
            this.listViewLow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listViewLow.GridLines = true;
            this.listViewLow.Location = new System.Drawing.Point(6, 19);
            this.listViewLow.Name = "listViewLow";
            this.listViewLow.Size = new System.Drawing.Size(315, 99);
            this.listViewLow.TabIndex = 0;
            this.listViewLow.UseCompatibleStateImageBehavior = false;
            this.listViewLow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Time";
            this.columnHeader7.Width = 118;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tweets";
            this.columnHeader8.Width = 438;
            // 
            // radio_all
            // 
            this.radio_all.AutoSize = true;
            this.radio_all.Checked = true;
            this.radio_all.Location = new System.Drawing.Point(6, 19);
            this.radio_all.Name = "radio_all";
            this.radio_all.Size = new System.Drawing.Size(74, 17);
            this.radio_all.TabIndex = 0;
            this.radio_all.TabStop = true;
            this.radio_all.Text = "All Tweets";
            this.radio_all.UseVisualStyleBackColor = true;
            // 
            // radio_high
            // 
            this.radio_high.AutoSize = true;
            this.radio_high.Location = new System.Drawing.Point(102, 20);
            this.radio_high.Name = "radio_high";
            this.radio_high.Size = new System.Drawing.Size(47, 17);
            this.radio_high.TabIndex = 1;
            this.radio_high.Text = "High";
            this.radio_high.UseVisualStyleBackColor = true;
            // 
            // radio_medium
            // 
            this.radio_medium.AutoSize = true;
            this.radio_medium.Location = new System.Drawing.Point(196, 20);
            this.radio_medium.Name = "radio_medium";
            this.radio_medium.Size = new System.Drawing.Size(62, 17);
            this.radio_medium.TabIndex = 2;
            this.radio_medium.Text = "Medium";
            this.radio_medium.UseVisualStyleBackColor = true;
            // 
            // radio_low
            // 
            this.radio_low.AutoSize = true;
            this.radio_low.Location = new System.Drawing.Point(294, 20);
            this.radio_low.Name = "radio_low";
            this.radio_low.Size = new System.Drawing.Size(45, 17);
            this.radio_low.TabIndex = 3;
            this.radio_low.Text = "Low";
            this.radio_low.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(337, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "Perform Retweets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.radio_low);
            this.groupBox7.Controls.Add(this.radio_medium);
            this.groupBox7.Controls.Add(this.radio_high);
            this.groupBox7.Controls.Add(this.radio_all);
            this.groupBox7.Location = new System.Drawing.Point(241, 415);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(350, 118);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Relevency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 545);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ReTwitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Tweet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox accessSecret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accessToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox consumerSecret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox consumerKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewAll;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listViewHigh;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listViewMedium;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listViewLow;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView keywordsList;
        private System.Windows.Forms.ColumnHeader Keyword;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalResult;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_location;
        private System.Windows.Forms.RadioButton radio_1day;
        private System.Windows.Forms.RadioButton radio_7day;
        private System.Windows.Forms.RadioButton radio_2day;
        private System.Windows.Forms.RadioButton radio_allTime;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.RadioButton radio_all;
        private System.Windows.Forms.RadioButton radio_high;
        private System.Windows.Forms.RadioButton radio_medium;
        private System.Windows.Forms.RadioButton radio_low;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}


namespace Coursemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBoxRegitered = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxWait = new System.Windows.Forms.ListBox();
            this.textBoxNETID = new System.Windows.Forms.TextBox();
            this.listBoxAvailableCourses = new System.Windows.Forms.ListBox();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxCurrentEnrolment = new System.Windows.Forms.TextBox();
            this.textBoxWaitList = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxEnrolment = new System.Windows.Forms.ListBox();
            this.listBoxWaitList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimeInMS = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(17, 799);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load All Students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(17, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 642);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxRegitered
            // 
            this.listBoxRegitered.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBoxRegitered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.listBoxRegitered.FormattingEnabled = true;
            this.listBoxRegitered.ItemHeight = 25;
            this.listBoxRegitered.Location = new System.Drawing.Point(362, 98);
            this.listBoxRegitered.Name = "listBoxRegitered";
            this.listBoxRegitered.Size = new System.Drawing.Size(271, 254);
            this.listBoxRegitered.TabIndex = 2;
            this.listBoxRegitered.SelectedIndexChanged += new System.EventHandler(this.listBoxRegitered_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(365, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registered Classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(365, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wait List Classes";
            // 
            // listBoxWait
            // 
            this.listBoxWait.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBoxWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.listBoxWait.FormattingEnabled = true;
            this.listBoxWait.ItemHeight = 25;
            this.listBoxWait.Location = new System.Drawing.Point(362, 481);
            this.listBoxWait.Name = "listBoxWait";
            this.listBoxWait.Size = new System.Drawing.Size(271, 254);
            this.listBoxWait.TabIndex = 5;
            this.listBoxWait.SelectedIndexChanged += new System.EventHandler(this.listBoxWait_SelectedIndexChanged);
            // 
            // textBoxNETID
            // 
            this.textBoxNETID.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxNETID.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxNETID.ForeColor = System.Drawing.Color.Red;
            this.textBoxNETID.Location = new System.Drawing.Point(131, 744);
            this.textBoxNETID.Name = "textBoxNETID";
            this.textBoxNETID.ReadOnly = true;
            this.textBoxNETID.Size = new System.Drawing.Size(225, 45);
            this.textBoxNETID.TabIndex = 6;
            this.textBoxNETID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxAvailableCourses
            // 
            this.listBoxAvailableCourses.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBoxAvailableCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listBoxAvailableCourses.FormattingEnabled = true;
            this.listBoxAvailableCourses.ItemHeight = 25;
            this.listBoxAvailableCourses.Location = new System.Drawing.Point(868, 97);
            this.listBoxAvailableCourses.Name = "listBoxAvailableCourses";
            this.listBoxAvailableCourses.Size = new System.Drawing.Size(316, 704);
            this.listBoxAvailableCourses.TabIndex = 7;
            this.listBoxAvailableCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxAvailableCourses_SelectedIndexChanged);
            // 
            // buttonCourses
            // 
            this.buttonCourses.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonCourses.ForeColor = System.Drawing.Color.Blue;
            this.buttonCourses.Location = new System.Drawing.Point(868, 806);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(316, 66);
            this.buttonCourses.TabIndex = 8;
            this.buttonCourses.Text = "Display All Courses";
            this.buttonCourses.UseVisualStyleBackColor = true;
            this.buttonCourses.Click += new System.EventHandler(this.buttonCourses_Click);
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxSemester.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxSemester.ForeColor = System.Drawing.Color.Red;
            this.textBoxSemester.Location = new System.Drawing.Point(639, 92);
            this.textBoxSemester.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(204, 45);
            this.textBoxSemester.TabIndex = 9;
            this.textBoxSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxYear.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxYear.ForeColor = System.Drawing.Color.Red;
            this.textBoxYear.Location = new System.Drawing.Point(639, 191);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(204, 45);
            this.textBoxYear.TabIndex = 10;
            this.textBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxType
            // 
            this.textBoxType.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxType.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxType.ForeColor = System.Drawing.Color.Red;
            this.textBoxType.Location = new System.Drawing.Point(639, 296);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(204, 45);
            this.textBoxType.TabIndex = 11;
            this.textBoxType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDay
            // 
            this.textBoxDay.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxDay.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxDay.ForeColor = System.Drawing.Color.Red;
            this.textBoxDay.Location = new System.Drawing.Point(639, 401);
            this.textBoxDay.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(204, 45);
            this.textBoxDay.TabIndex = 12;
            this.textBoxDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxTime.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxTime.ForeColor = System.Drawing.Color.Red;
            this.textBoxTime.Location = new System.Drawing.Point(639, 506);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(204, 45);
            this.textBoxTime.TabIndex = 13;
            this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSize
            // 
            this.textBoxSize.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxSize.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxSize.ForeColor = System.Drawing.Color.Red;
            this.textBoxSize.Location = new System.Drawing.Point(639, 611);
            this.textBoxSize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(204, 45);
            this.textBoxSize.TabIndex = 14;
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurrentEnrolment
            // 
            this.textBoxCurrentEnrolment.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxCurrentEnrolment.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxCurrentEnrolment.ForeColor = System.Drawing.Color.Red;
            this.textBoxCurrentEnrolment.Location = new System.Drawing.Point(639, 716);
            this.textBoxCurrentEnrolment.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxCurrentEnrolment.Name = "textBoxCurrentEnrolment";
            this.textBoxCurrentEnrolment.Size = new System.Drawing.Size(204, 45);
            this.textBoxCurrentEnrolment.TabIndex = 15;
            this.textBoxCurrentEnrolment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWaitList
            // 
            this.textBoxWaitList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBoxWaitList.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxWaitList.ForeColor = System.Drawing.Color.Red;
            this.textBoxWaitList.Location = new System.Drawing.Point(639, 821);
            this.textBoxWaitList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBoxWaitList.Name = "textBoxWaitList";
            this.textBoxWaitList.Size = new System.Drawing.Size(204, 45);
            this.textBoxWaitList.TabIndex = 16;
            this.textBoxWaitList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(1190, 806);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(392, 66);
            this.button2.TabIndex = 17;
            this.button2.Text = "REGISTER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxEnrolment
            // 
            this.listBoxEnrolment.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBoxEnrolment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listBoxEnrolment.FormattingEnabled = true;
            this.listBoxEnrolment.ItemHeight = 29;
            this.listBoxEnrolment.Location = new System.Drawing.Point(1190, 126);
            this.listBoxEnrolment.Name = "listBoxEnrolment";
            this.listBoxEnrolment.Size = new System.Drawing.Size(193, 439);
            this.listBoxEnrolment.TabIndex = 18;
            // 
            // listBoxWaitList
            // 
            this.listBoxWaitList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBoxWaitList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listBoxWaitList.FormattingEnabled = true;
            this.listBoxWaitList.ItemHeight = 29;
            this.listBoxWaitList.Location = new System.Drawing.Point(1389, 126);
            this.listBoxWaitList.Name = "listBoxWaitList";
            this.listBoxWaitList.Size = new System.Drawing.Size(193, 439);
            this.listBoxWaitList.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(1183, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "Regitered";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(1382, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 38);
            this.label4.TabIndex = 21;
            this.label4.Text = "Wait List";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(362, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 65);
            this.button3.TabIndex = 22;
            this.button3.Text = "DROP CLASS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(362, 744);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 128);
            this.button4.TabIndex = 23;
            this.button4.Text = "DROP FROM WAIT LIST";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1602, 46);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fILEToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(281, 42);
            this.fILEToolStripMenuItem.Text = "RESET DATABASE";
            this.fILEToolStripMenuItem.Click += new System.EventHandler(this.fILEToolStripMenuItem_Click);
            // 
            // txtTimeInMS
            // 
            this.txtTimeInMS.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTimeInMS.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTimeInMS.Location = new System.Drawing.Point(1291, 662);
            this.txtTimeInMS.Name = "txtTimeInMS";
            this.txtTimeInMS.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtTimeInMS.Size = new System.Drawing.Size(204, 45);
            this.txtTimeInMS.TabIndex = 25;
            this.txtTimeInMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(1190, 719);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(392, 66);
            this.button5.TabIndex = 26;
            this.button5.Text = "SWAP CLASSES";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 38);
            this.label5.TabIndex = 27;
            this.label5.Text = "STUDENTS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(12, 751);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 38);
            this.label6.TabIndex = 28;
            this.label6.Text = "NetID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(861, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 38);
            this.label7.TabIndex = 29;
            this.label7.Text = "Available Classes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(639, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 38);
            this.label8.TabIndex = 30;
            this.label8.Text = "Semester";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(639, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 38);
            this.label9.TabIndex = 31;
            this.label9.Text = "Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(639, 247);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 38);
            this.label10.TabIndex = 32;
            this.label10.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(639, 352);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 38);
            this.label11.TabIndex = 33;
            this.label11.Text = "Day";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(639, 457);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 38);
            this.label12.TabIndex = 34;
            this.label12.Text = "Hours";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.Location = new System.Drawing.Point(639, 562);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 38);
            this.label13.TabIndex = 35;
            this.label13.Text = "Class Size";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.Location = new System.Drawing.Point(639, 667);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 38);
            this.label14.TabIndex = 36;
            this.label14.Text = "Total enrolled";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label15.Location = new System.Drawing.Point(639, 772);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 38);
            this.label15.TabIndex = 37;
            this.label15.Text = "Total wait list";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label16.Location = new System.Drawing.Point(1190, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 38);
            this.label16.TabIndex = 38;
            this.label16.Text = "In Class";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label17.Location = new System.Drawing.Point(1382, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 38);
            this.label17.TabIndex = 39;
            this.label17.Text = "FIFO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label18.Location = new System.Drawing.Point(1190, 578);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(317, 38);
            this.label18.TabIndex = 41;
            this.label18.Text = "Enter Time to delay in";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label19.Location = new System.Drawing.Point(1190, 616);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(383, 38);
            this.label19.TabIndex = 42;
            this.label19.Text = "MIlliseconds (1000 = 1 sec)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1602, 888);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtTimeInMS);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxWaitList);
            this.Controls.Add(this.listBoxEnrolment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxWaitList);
            this.Controls.Add(this.textBoxCurrentEnrolment);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.buttonCourses);
            this.Controls.Add(this.listBoxAvailableCourses);
            this.Controls.Add(this.textBoxNETID);
            this.Controls.Add(this.listBoxWait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRegitered);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Coursemo CS480 Project #4    -> awojci5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBoxRegitered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxWait;
        private System.Windows.Forms.TextBox textBoxNETID;
        private System.Windows.Forms.ListBox listBoxAvailableCourses;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxCurrentEnrolment;
        private System.Windows.Forms.TextBox textBoxWaitList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxEnrolment;
        private System.Windows.Forms.ListBox listBoxWaitList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTimeInMS;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}


namespace Coursemo
{
    partial class SwapOperation
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
            this.listBoxStudentX = new System.Windows.Forms.ListBox();
            this.listBoxCoursesX = new System.Windows.Forms.ListBox();
            this.listBoxStudentY = new System.Windows.Forms.ListBox();
            this.listBoxCoursesY = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudentX
            // 
            this.listBoxStudentX.BackColor = System.Drawing.Color.Wheat;
            this.listBoxStudentX.FormattingEnabled = true;
            this.listBoxStudentX.ItemHeight = 25;
            this.listBoxStudentX.Location = new System.Drawing.Point(21, 106);
            this.listBoxStudentX.Name = "listBoxStudentX";
            this.listBoxStudentX.Size = new System.Drawing.Size(269, 279);
            this.listBoxStudentX.TabIndex = 0;
            this.listBoxStudentX.SelectedIndexChanged += new System.EventHandler(this.listBoxStudentX_SelectedIndexChanged);
            // 
            // listBoxCoursesX
            // 
            this.listBoxCoursesX.BackColor = System.Drawing.Color.Wheat;
            this.listBoxCoursesX.FormattingEnabled = true;
            this.listBoxCoursesX.ItemHeight = 25;
            this.listBoxCoursesX.Location = new System.Drawing.Point(314, 106);
            this.listBoxCoursesX.Name = "listBoxCoursesX";
            this.listBoxCoursesX.Size = new System.Drawing.Size(269, 279);
            this.listBoxCoursesX.TabIndex = 1;
            this.listBoxCoursesX.SelectedIndexChanged += new System.EventHandler(this.listBoxCoursesX_SelectedIndexChanged);
            // 
            // listBoxStudentY
            // 
            this.listBoxStudentY.BackColor = System.Drawing.Color.LightBlue;
            this.listBoxStudentY.FormattingEnabled = true;
            this.listBoxStudentY.ItemHeight = 25;
            this.listBoxStudentY.Location = new System.Drawing.Point(607, 106);
            this.listBoxStudentY.Name = "listBoxStudentY";
            this.listBoxStudentY.Size = new System.Drawing.Size(269, 279);
            this.listBoxStudentY.TabIndex = 2;
            this.listBoxStudentY.SelectedIndexChanged += new System.EventHandler(this.listBoxStudentY_SelectedIndexChanged);
            // 
            // listBoxCoursesY
            // 
            this.listBoxCoursesY.BackColor = System.Drawing.Color.LightBlue;
            this.listBoxCoursesY.FormattingEnabled = true;
            this.listBoxCoursesY.ItemHeight = 25;
            this.listBoxCoursesY.Location = new System.Drawing.Point(900, 106);
            this.listBoxCoursesY.Name = "listBoxCoursesY";
            this.listBoxCoursesY.Size = new System.Drawing.Size(269, 279);
            this.listBoxCoursesY.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(721, 92);
            this.button1.TabIndex = 4;
            this.button1.Text = "SWAP CLASSES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Student X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Student Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(882, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Classes for Student Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Classes for Student X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1085, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "SELECT BOTH STUDENTS AND CHOOSE CLASSES YOU WANT TO SWAP";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(772, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(397, 92);
            this.button2.TabIndex = 11;
            this.button2.Text = "EXIT FROM SWAP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SwapOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1190, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxCoursesY);
            this.Controls.Add(this.listBoxStudentY);
            this.Controls.Add(this.listBoxCoursesX);
            this.Controls.Add(this.listBoxStudentX);
            this.Name = "SwapOperation";
            this.Text = "SwapOperation";
            this.Load += new System.EventHandler(this.SwapOperation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudentX;
        private System.Windows.Forms.ListBox listBoxCoursesX;
        private System.Windows.Forms.ListBox listBoxStudentY;
        private System.Windows.Forms.ListBox listBoxCoursesY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}
namespace Student_Information
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Iblname = new Label();
            Iblstudentid = new Label();
            Ibldepartment = new Label();
            Iblsemester = new Label();
            btnshowinfo = new Button();
            bntclear = new Button();
            btnexit = new Button();
            textname = new TextBox();
            textstudentid = new TextBox();
            textdepartment = new TextBox();
            textsemester = new TextBox();
            Lbloutput = new Label();
            SuspendLayout();
            // 
            // Iblname
            // 
            Iblname.AutoSize = true;
            Iblname.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Iblname.Location = new Point(25, 35);
            Iblname.Name = "Iblname";
            Iblname.Size = new Size(265, 30);
            Iblname.TabIndex = 0;
            Iblname.Text = "Enter the student name";
            // 
            // Iblstudentid
            // 
            Iblstudentid.AutoSize = true;
            Iblstudentid.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Iblstudentid.Location = new Point(25, 87);
            Iblstudentid.Name = "Iblstudentid";
            Iblstudentid.Size = new Size(231, 30);
            Iblstudentid.TabIndex = 1;
            Iblstudentid.Text = "Enter the student ID";
            // 
            // Ibldepartment
            // 
            Ibldepartment.AutoSize = true;
            Ibldepartment.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ibldepartment.Location = new Point(25, 142);
            Ibldepartment.Name = "Ibldepartment";
            Ibldepartment.Size = new Size(244, 30);
            Ibldepartment.TabIndex = 2;
            Ibldepartment.Text = "Enter the department";
            // 
            // Iblsemester
            // 
            Iblsemester.AutoSize = true;
            Iblsemester.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Iblsemester.Location = new Point(25, 195);
            Iblsemester.Name = "Iblsemester";
            Iblsemester.Size = new Size(215, 30);
            Iblsemester.TabIndex = 3;
            Iblsemester.Text = "Enter the semester";
            Iblsemester.Click += label4_Click;
            // 
            // btnshowinfo
            // 
            btnshowinfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnshowinfo.Location = new Point(121, 437);
            btnshowinfo.Name = "btnshowinfo";
            btnshowinfo.Size = new Size(170, 63);
            btnshowinfo.TabIndex = 4;
            btnshowinfo.Text = "show information";
            btnshowinfo.UseVisualStyleBackColor = true;
            btnshowinfo.Click += btnshowinfo_Click;
            // 
            // bntclear
            // 
            bntclear.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntclear.Location = new Point(351, 437);
            bntclear.Name = "bntclear";
            bntclear.Size = new Size(170, 63);
            bntclear.TabIndex = 5;
            bntclear.Text = "Clear";
            bntclear.UseVisualStyleBackColor = true;
            bntclear.Click += bntclear_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.Location = new Point(565, 437);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(170, 63);
            btnexit.TabIndex = 6;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // textname
            // 
            textname.Location = new Point(310, 34);
            textname.Name = "textname";
            textname.Size = new Size(456, 31);
            textname.TabIndex = 7;
            // 
            // textstudentid
            // 
            textstudentid.Location = new Point(310, 86);
            textstudentid.Name = "textstudentid";
            textstudentid.Size = new Size(456, 31);
            textstudentid.TabIndex = 8;
            // 
            // textdepartment
            // 
            textdepartment.Location = new Point(310, 141);
            textdepartment.Name = "textdepartment";
            textdepartment.Size = new Size(456, 31);
            textdepartment.TabIndex = 9;
            // 
            // textsemester
            // 
            textsemester.Location = new Point(310, 196);
            textsemester.Name = "textsemester";
            textsemester.Size = new Size(456, 31);
            textsemester.TabIndex = 10;
            // 
            // Lbloutput
            // 
            Lbloutput.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbloutput.Location = new Point(121, 273);
            Lbloutput.Name = "Lbloutput";
            Lbloutput.Size = new Size(675, 120);
            Lbloutput.TabIndex = 11;
            Lbloutput.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 557);
            Controls.Add(Lbloutput);
            Controls.Add(textsemester);
            Controls.Add(textdepartment);
            Controls.Add(textstudentid);
            Controls.Add(textname);
            Controls.Add(btnexit);
            Controls.Add(bntclear);
            Controls.Add(btnshowinfo);
            Controls.Add(Iblsemester);
            Controls.Add(Ibldepartment);
            Controls.Add(Iblstudentid);
            Controls.Add(Iblname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Iblname;
        private Label Iblstudentid;
        private Label Ibldepartment;
        private Label Iblsemester;
        private Button btnshowinfo;
        private Button bntclear;
        private Button btnexit;
        private TextBox textname;
        private TextBox textstudentid;
        private TextBox textdepartment;
        private TextBox textsemester;
        private Label Lbloutput;
    }
}

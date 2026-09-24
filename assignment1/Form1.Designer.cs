namespace BirthDateString
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
            dayofWeekpromtLable = new Label();
            monthPromtLabel = new Label();
            dayOfMonthPromptLabel = new Label();
            yearPromptLabel = new Label();
            dayOfWeekTextBox = new TextBox();
            monthTextBox = new TextBox();
            dayOfMonthTextBox = new TextBox();
            yearTextBox = new TextBox();
            dateOutputLabel = new Label();
            sowDateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // dayofWeekpromtLable
            // 
            dayofWeekpromtLable.AutoSize = true;
            dayofWeekpromtLable.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dayofWeekpromtLable.Location = new Point(12, 36);
            dayofWeekpromtLable.Name = "dayofWeekpromtLable";
            dayofWeekpromtLable.Size = new Size(270, 30);
            dayofWeekpromtLable.TabIndex = 0;
            dayofWeekpromtLable.Text = "Enter the day of the week";
            // 
            // monthPromtLabel
            // 
            monthPromtLabel.AutoSize = true;
            monthPromtLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            monthPromtLabel.Location = new Point(12, 82);
            monthPromtLabel.Name = "monthPromtLabel";
            monthPromtLabel.Size = new Size(305, 30);
            monthPromtLabel.TabIndex = 1;
            monthPromtLabel.Text = "Enter the name of the month";
            // 
            // dayOfMonthPromptLabel
            // 
            dayOfMonthPromptLabel.AutoSize = true;
            dayOfMonthPromptLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dayOfMonthPromptLabel.Location = new Point(12, 128);
            dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            dayOfMonthPromptLabel.Size = new Size(375, 30);
            dayOfMonthPromptLabel.TabIndex = 2;
            dayOfMonthPromptLabel.Text = "Enter the numeric day of the month";
            // 
            // yearPromptLabel
            // 
            yearPromptLabel.AutoSize = true;
            yearPromptLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            yearPromptLabel.Location = new Point(12, 170);
            yearPromptLabel.Name = "yearPromptLabel";
            yearPromptLabel.Size = new Size(155, 30);
            yearPromptLabel.TabIndex = 3;
            yearPromptLabel.Text = "Enter the year";
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Location = new Point(293, 36);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(352, 31);
            dayOfWeekTextBox.TabIndex = 4;
            dayOfWeekTextBox.TextChanged += textBox1_TextChanged;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(323, 83);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(352, 31);
            monthTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.Location = new Point(393, 129);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(352, 31);
            dayOfMonthTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(293, 180);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(352, 31);
            yearTextBox.TabIndex = 7;
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            dateOutputLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateOutputLabel.Location = new Point(89, 279);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(654, 134);
            dateOutputLabel.TabIndex = 8;
            dateOutputLabel.Text = "label1";
            // 
            // sowDateButton
            // 
            sowDateButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sowDateButton.Location = new Point(140, 498);
            sowDateButton.Name = "sowDateButton";
            sowDateButton.Size = new Size(139, 61);
            sowDateButton.TabIndex = 9;
            sowDateButton.Text = "show date";
            sowDateButton.UseVisualStyleBackColor = true;
            sowDateButton.Click += sowDateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(349, 498);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(139, 61);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(553, 498);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(139, 61);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 619);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(sowDateButton);
            Controls.Add(dateOutputLabel);
            Controls.Add(yearTextBox);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(yearPromptLabel);
            Controls.Add(dayOfMonthPromptLabel);
            Controls.Add(monthPromtLabel);
            Controls.Add(dayofWeekpromtLable);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dayofWeekpromtLable;
        private Label monthPromtLabel;
        private Label dayOfMonthPromptLabel;
        private Label yearPromptLabel;
        private TextBox dayOfWeekTextBox;
        private TextBox monthTextBox;
        private TextBox dayOfMonthTextBox;
        private TextBox yearTextBox;
        private Label dateOutputLabel;
        private Button sowDateButton;
        private Button clearButton;
        private Button exitButton;
    }
}

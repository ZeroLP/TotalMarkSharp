namespace TotalMarkSharp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TotalOneMarkBox = new System.Windows.Forms.TextBox();
            this.TotalOneMarkAnswerdBox = new System.Windows.Forms.TextBox();
            this.TotalTwoMarksAnsweredBox = new System.Windows.Forms.TextBox();
            this.TotalTwoMarksBox = new System.Windows.Forms.TextBox();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.TotalMarkSharpLabel = new System.Windows.Forms.Label();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TotalOneMarkLabel = new System.Windows.Forms.Label();
            this.TotalOneMarkAnsweredLabel = new System.Windows.Forms.Label();
            this.TotalTwoMarkQuestionsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TotalMarkText = new System.Windows.Forms.Label();
            this.TotalMarksAvailText = new System.Windows.Forms.Label();
            this.MarkPercentageText = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalOneMarkBox
            // 
            this.TotalOneMarkBox.Location = new System.Drawing.Point(355, 118);
            this.TotalOneMarkBox.Name = "TotalOneMarkBox";
            this.TotalOneMarkBox.Size = new System.Drawing.Size(100, 20);
            this.TotalOneMarkBox.TabIndex = 0;
            // 
            // TotalOneMarkAnswerdBox
            // 
            this.TotalOneMarkAnswerdBox.Location = new System.Drawing.Point(355, 144);
            this.TotalOneMarkAnswerdBox.Name = "TotalOneMarkAnswerdBox";
            this.TotalOneMarkAnswerdBox.Size = new System.Drawing.Size(100, 20);
            this.TotalOneMarkAnswerdBox.TabIndex = 1;
            // 
            // TotalTwoMarksAnsweredBox
            // 
            this.TotalTwoMarksAnsweredBox.Location = new System.Drawing.Point(355, 213);
            this.TotalTwoMarksAnsweredBox.Name = "TotalTwoMarksAnsweredBox";
            this.TotalTwoMarksAnsweredBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTwoMarksAnsweredBox.TabIndex = 3;
            // 
            // TotalTwoMarksBox
            // 
            this.TotalTwoMarksBox.Location = new System.Drawing.Point(355, 187);
            this.TotalTwoMarksBox.Name = "TotalTwoMarksBox";
            this.TotalTwoMarksBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTwoMarksBox.TabIndex = 2;
            // 
            // MenuBar
            // 
            this.MenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(97)))));
            this.MenuBar.Controls.Add(this.TotalMarkSharpLabel);
            this.MenuBar.Controls.Add(this.MinimiseButton);
            this.MenuBar.Controls.Add(this.CloseButton);
            this.MenuBar.Location = new System.Drawing.Point(-1, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(592, 41);
            this.MenuBar.TabIndex = 7;
            this.MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuBar_MouseDown);
            // 
            // TotalMarkSharpLabel
            // 
            this.TotalMarkSharpLabel.AutoSize = true;
            this.TotalMarkSharpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarkSharpLabel.ForeColor = System.Drawing.Color.White;
            this.TotalMarkSharpLabel.Location = new System.Drawing.Point(12, 9);
            this.TotalMarkSharpLabel.Name = "TotalMarkSharpLabel";
            this.TotalMarkSharpLabel.Size = new System.Drawing.Size(142, 24);
            this.TotalMarkSharpLabel.TabIndex = 6;
            this.TotalMarkSharpLabel.Text = "TotalMarkSharp";
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimiseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimiseButton.BackgroundImage")));
            this.MinimiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimiseButton.Location = new System.Drawing.Point(445, 0);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Size = new System.Drawing.Size(69, 38);
            this.MinimiseButton.TabIndex = 5;
            this.MinimiseButton.UseVisualStyleBackColor = true;
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(520, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(69, 41);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TotalOneMarkLabel
            // 
            this.TotalOneMarkLabel.AutoSize = true;
            this.TotalOneMarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOneMarkLabel.ForeColor = System.Drawing.Color.White;
            this.TotalOneMarkLabel.Location = new System.Drawing.Point(180, 118);
            this.TotalOneMarkLabel.Name = "TotalOneMarkLabel";
            this.TotalOneMarkLabel.Size = new System.Drawing.Size(171, 18);
            this.TotalOneMarkLabel.TabIndex = 7;
            this.TotalOneMarkLabel.Text = "Total 1 Mark Questions: ";
            // 
            // TotalOneMarkAnsweredLabel
            // 
            this.TotalOneMarkAnsweredLabel.AutoSize = true;
            this.TotalOneMarkAnsweredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOneMarkAnsweredLabel.ForeColor = System.Drawing.Color.White;
            this.TotalOneMarkAnsweredLabel.Location = new System.Drawing.Point(127, 143);
            this.TotalOneMarkAnsweredLabel.Name = "TotalOneMarkAnsweredLabel";
            this.TotalOneMarkAnsweredLabel.Size = new System.Drawing.Size(225, 18);
            this.TotalOneMarkAnsweredLabel.TabIndex = 8;
            this.TotalOneMarkAnsweredLabel.Text = "Total Correct 1 Mark Questions: ";
            // 
            // TotalTwoMarkQuestionsLabel
            // 
            this.TotalTwoMarkQuestionsLabel.AutoSize = true;
            this.TotalTwoMarkQuestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTwoMarkQuestionsLabel.ForeColor = System.Drawing.Color.White;
            this.TotalTwoMarkQuestionsLabel.Location = new System.Drawing.Point(181, 187);
            this.TotalTwoMarkQuestionsLabel.Name = "TotalTwoMarkQuestionsLabel";
            this.TotalTwoMarkQuestionsLabel.Size = new System.Drawing.Size(171, 18);
            this.TotalTwoMarkQuestionsLabel.TabIndex = 9;
            this.TotalTwoMarkQuestionsLabel.Text = "Total 2 Mark Questions: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Correct 2 Mark Questions: ";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(231, 266);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(121, 36);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TotalMarkText
            // 
            this.TotalMarkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarkText.ForeColor = System.Drawing.Color.White;
            this.TotalMarkText.Location = new System.Drawing.Point(12, 62);
            this.TotalMarkText.Name = "TotalMarkText";
            this.TotalMarkText.Size = new System.Drawing.Size(171, 18);
            this.TotalMarkText.TabIndex = 12;
            this.TotalMarkText.Text = "Total Marks: 0";
            this.TotalMarkText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalMarksAvailText
            // 
            this.TotalMarksAvailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarksAvailText.ForeColor = System.Drawing.Color.White;
            this.TotalMarksAvailText.Location = new System.Drawing.Point(180, 62);
            this.TotalMarksAvailText.Name = "TotalMarksAvailText";
            this.TotalMarksAvailText.Size = new System.Drawing.Size(227, 18);
            this.TotalMarksAvailText.TabIndex = 13;
            this.TotalMarksAvailText.Text = "Total Marks Available: 0";
            this.TotalMarksAvailText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarkPercentageText
            // 
            this.MarkPercentageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkPercentageText.ForeColor = System.Drawing.Color.White;
            this.MarkPercentageText.Location = new System.Drawing.Point(413, 62);
            this.MarkPercentageText.Name = "MarkPercentageText";
            this.MarkPercentageText.Size = new System.Drawing.Size(164, 18);
            this.MarkPercentageText.TabIndex = 14;
            this.MarkPercentageText.Text = "Percentage: 0%";
            this.MarkPercentageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorText
            // 
            this.ErrorText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(115, 90);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(354, 18);
            this.ErrorText.TabIndex = 15;
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(590, 324);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.MarkPercentageText);
            this.Controls.Add(this.TotalMarksAvailText);
            this.Controls.Add(this.TotalMarkText);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalTwoMarkQuestionsLabel);
            this.Controls.Add(this.TotalOneMarkAnsweredLabel);
            this.Controls.Add(this.TotalOneMarkLabel);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.TotalTwoMarksAnsweredBox);
            this.Controls.Add(this.TotalTwoMarksBox);
            this.Controls.Add(this.TotalOneMarkAnswerdBox);
            this.Controls.Add(this.TotalOneMarkBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "TotalMarkSharp";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalOneMarkBox;
        private System.Windows.Forms.TextBox TotalOneMarkAnswerdBox;
        private System.Windows.Forms.TextBox TotalTwoMarksAnsweredBox;
        private System.Windows.Forms.TextBox TotalTwoMarksBox;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Label TotalMarkSharpLabel;
        private System.Windows.Forms.Button MinimiseButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TotalOneMarkLabel;
        private System.Windows.Forms.Label TotalOneMarkAnsweredLabel;
        private System.Windows.Forms.Label TotalTwoMarkQuestionsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label TotalMarkText;
        private System.Windows.Forms.Label TotalMarksAvailText;
        private System.Windows.Forms.Label MarkPercentageText;
        private System.Windows.Forms.Label ErrorText;
    }
}


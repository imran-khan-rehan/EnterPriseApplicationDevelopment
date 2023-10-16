namespace assignment1
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.message = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Button();
            this.listOfSubjects = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "first Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(65, 53);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(364, 31);
            this.firstName.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.submit.Location = new System.Drawing.Point(65, 262);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(69, 27);
            this.submit.TabIndex = 2;
            this.submit.Text = "submit";
            this.submit.Click += new System.EventHandler(this.output_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(65, 143);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(364, 31);
            this.lastName.TabIndex = 4;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(225, 193);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 25);
            this.output.TabIndex = 5;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(65, 203);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(172, 29);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "prerequisite clear";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.message.Location = new System.Drawing.Point(65, 372);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 25);
            this.message.TabIndex = 8;
            this.message.Click += new System.EventHandler(this.label3_Click);
            // 
            // heading
            // 
            this.heading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heading.Location = new System.Drawing.Point(65, 336);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(112, 34);
            this.heading.TabIndex = 9;
            this.heading.Text = "Output";
            this.heading.UseVisualStyleBackColor = true;
            this.heading.Visible = false;
            // 
            // listOfSubjects
            // 
            this.listOfSubjects.FormattingEnabled = true;
            this.listOfSubjects.HorizontalScrollbar = true;
            this.listOfSubjects.Items.AddRange(new object[] {
            "urdu",
            "english",
            "pakstudy",
            "islam",
            "chem",
            "phy"});
            this.listOfSubjects.Location = new System.Drawing.Point(459, 53);
            this.listOfSubjects.Name = "listOfSubjects";
            this.listOfSubjects.Size = new System.Drawing.Size(180, 144);
            this.listOfSubjects.TabIndex = 10;
            this.listOfSubjects.SelectedIndexChanged += new System.EventHandler(this.listOfSubjects_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(749, 544);
            this.Controls.Add(this.listOfSubjects);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.message);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.output);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(771, 600);
            this.MinimumSize = new System.Drawing.Size(771, 475);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox firstName;
        private Label submit;
        private Label label2;
        private TextBox lastName;
        private Label output;
        private CheckBox checkBox;
        private Label message;
        private Button heading;
        private CheckedListBox listOfSubjects;
    }
}
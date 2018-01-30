namespace RHG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.schoolcombo = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.Statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisplayTextBox = new System.Windows.Forms.RichTextBox();
            this.InputLabel1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoolcombo
            // 
            this.schoolcombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schoolcombo.FormattingEnabled = true;
            this.schoolcombo.Location = new System.Drawing.Point(219, 43);
            this.schoolcombo.Name = "schoolcombo";
            this.schoolcombo.Size = new System.Drawing.Size(247, 21);
            this.schoolcombo.TabIndex = 1;
            this.schoolcombo.Text = "Select a campus..";
            this.schoolcombo.SelectedIndexChanged += new System.EventHandler(this.schoolcombo_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.Statuslabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // Statuslabel
            // 
            this.Statuslabel.BackColor = System.Drawing.Color.Transparent;
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(39, 17);
            this.Statuslabel.Text = "Ready";
            this.Statuslabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Statuslabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextBox.Location = new System.Drawing.Point(146, 326);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(422, 174);
            this.DisplayTextBox.TabIndex = 3;
            this.DisplayTextBox.Text = "Your codes will be displayed here..";
            this.DisplayTextBox.TextChanged += new System.EventHandler(this.DisplayTextBox_TextChanged);
            // 
            // InputLabel1
            // 
            this.InputLabel1.AutoSize = true;
            this.InputLabel1.Location = new System.Drawing.Point(243, 148);
            this.InputLabel1.Name = "InputLabel1";
            this.InputLabel1.Size = new System.Drawing.Size(208, 13);
            this.InputLabel1.TabIndex = 4;
            this.InputLabel1.Text = "Please enter the number of codes needed:";
            this.InputLabel1.Click += new System.EventHandler(this.InputLabel1_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(268, 180);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(104, 20);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "E&nter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(697, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLabel1);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.schoolcombo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(730, 600);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "RHG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox schoolcombo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel Statuslabel;
        private System.Windows.Forms.RichTextBox DisplayTextBox;
        private System.Windows.Forms.Label InputLabel1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button button1;
    }
}


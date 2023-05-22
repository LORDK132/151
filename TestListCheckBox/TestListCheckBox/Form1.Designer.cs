namespace TestListCheckBox
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
            this.chList = new System.Windows.Forms.CheckedListBox();
            this.butshow = new System.Windows.Forms.Button();
            this.addtolist = new System.Windows.Forms.Button();
            this.city = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chList
            // 
            this.chList.CheckOnClick = true;
            this.chList.Items.AddRange(new object[] {
            "kamal",
            "salasin",
            "70",
            "@",
            "gmail",
            ".",
            "com"});
            this.chList.Location = new System.Drawing.Point(221, 15);
            this.chList.Name = "chList";
            this.chList.Size = new System.Drawing.Size(227, 172);
            this.chList.TabIndex = 0;
            this.chList.TabStop = false;
            this.chList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // butshow
            // 
            this.butshow.Location = new System.Drawing.Point(221, 225);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(227, 31);
            this.butshow.TabIndex = 1;
            this.butshow.Text = "Show";
            this.butshow.UseVisualStyleBackColor = true;
            this.butshow.Click += new System.EventHandler(this.butshow_Click);
            // 
            // addtolist
            // 
            this.addtolist.Location = new System.Drawing.Point(16, 59);
            this.addtolist.Name = "addtolist";
            this.addtolist.Size = new System.Drawing.Size(171, 38);
            this.addtolist.TabIndex = 2;
            this.addtolist.Text = "add";
            this.addtolist.UseVisualStyleBackColor = true;
            this.addtolist.Click += new System.EventHandler(this.addtolist_Click);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(12, 18);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(46, 20);
            this.city.TabIndex = 3;
            this.city.Text = "city :";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(64, 18);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(140, 26);
            this.text.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 269);
            this.Controls.Add(this.text);
            this.Controls.Add(this.city);
            this.Controls.Add(this.addtolist);
            this.Controls.Add(this.butshow);
            this.Controls.Add(this.chList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(300, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chList;
        private System.Windows.Forms.Button butshow;
        private System.Windows.Forms.Button addtolist;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox text;
    }
}


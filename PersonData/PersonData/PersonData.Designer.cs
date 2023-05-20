namespace PersonData
{
    partial class PersonData
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
            this.components = new System.ComponentModel.Container();
            this.Exit = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DimGray;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.ForeColor = System.Drawing.Color.LimeGreen;
            this.Exit.Location = new System.Drawing.Point(427, 284);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(129, 38);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.toolTip1.SetToolTip(this.Exit, "Exit From Progict");
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.DimGray;
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show.ForeColor = System.Drawing.Color.LimeGreen;
            this.Show.Location = new System.Drawing.Point(293, 284);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(128, 38);
            this.Show.TabIndex = 1;
            this.Show.Text = "Show All";
            this.toolTip1.SetToolTip(this.Show, "All Person ID");
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.button2_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.DimGray;
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Find.ForeColor = System.Drawing.Color.LimeGreen;
            this.Find.Location = new System.Drawing.Point(155, 284);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(132, 38);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.toolTip1.SetToolTip(this.Find, "Find Person Informision");
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DimGray;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.ForeColor = System.Drawing.Color.LimeGreen;
            this.Add.Location = new System.Drawing.Point(12, 284);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(137, 38);
            this.Add.TabIndex = 3;
            this.Add.Text = "New Person";
            this.toolTip1.SetToolTip(this.Add, "Add New Person Data");
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID :  ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textAdres
            // 
            this.textAdres.BackColor = System.Drawing.Color.Black;
            this.textAdres.ForeColor = System.Drawing.Color.Cyan;
            this.textAdres.Location = new System.Drawing.Point(195, 201);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(304, 29);
            this.textAdres.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textAdres, "Person Adres");
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.Black;
            this.textName.ForeColor = System.Drawing.Color.Cyan;
            this.textName.Location = new System.Drawing.Point(195, 134);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(304, 29);
            this.textName.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textName, "Enter Person Name");
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.Black;
            this.textId.ForeColor = System.Drawing.Color.Cyan;
            this.textId.Location = new System.Drawing.Point(195, 68);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(304, 29);
            this.textId.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textId, "Person ID");
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Note :";
            // 
            // PersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 331);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PersonData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person ID";
            this.Load += new System.EventHandler(this.PersonData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


namespace TestNumUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 20;
            this.numericUpDown1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(80, 48);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(336, 31);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(80, 201);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2000000000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(336, 31);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(80, 147);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(336, 31);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(80, 91);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(336, 31);
            this.numericUpDown4.TabIndex = 3;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // add
            // 
            this.add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.add.Location = new System.Drawing.Point(80, 428);
            this.add.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(336, 43);
            this.add.TabIndex = 4;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(498, 511);
            this.Controls.Add(this.add);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button add;
    }
}


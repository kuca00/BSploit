namespace BSploit
{
    partial class Options
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
            this.ExitBTN = new System.Windows.Forms.Button();
            this.logInCheckBox1 = new System.Windows.Forms.CheckBox();
            this.logInCheckBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.FlatAppearance.BorderSize = 0;
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitBTN.ForeColor = System.Drawing.Color.White;
            this.ExitBTN.Location = new System.Drawing.Point(145, 0);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(30, 30);
            this.ExitBTN.TabIndex = 5;
            this.ExitBTN.Text = "X";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // logInCheckBox1
            // 
            this.logInCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInCheckBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logInCheckBox1.Location = new System.Drawing.Point(12, 39);
            this.logInCheckBox1.Name = "logInCheckBox1";
            this.logInCheckBox1.Size = new System.Drawing.Size(110, 22);
            this.logInCheckBox1.TabIndex = 6;
            this.logInCheckBox1.Text = "AutoInject";
            this.logInCheckBox1.CheckedChanged += new System.EventHandler(this.logInCheckBox1_CheckedChanged);
            // 
            // logInCheckBox2
            // 
            this.logInCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInCheckBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logInCheckBox2.Location = new System.Drawing.Point(12, 67);
            this.logInCheckBox2.Name = "logInCheckBox2";
            this.logInCheckBox2.Size = new System.Drawing.Size(125, 22);
            this.logInCheckBox2.TabIndex = 7;
            this.logInCheckBox2.Text = "In Game GUI";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(174, 336);
            this.Controls.Add(this.logInCheckBox2);
            this.Controls.Add(this.logInCheckBox1);
            this.Controls.Add(this.ExitBTN);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.CheckBox logInCheckBox1;
        private System.Windows.Forms.CheckBox logInCheckBox2;
    }
}
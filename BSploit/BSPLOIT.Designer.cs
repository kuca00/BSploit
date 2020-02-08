namespace BSploit
{
    partial class BSploit
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.TopMostBTN = new System.Windows.Forms.Button();
            this.TopMostBTN1 = new System.Windows.Forms.Button();
            this.minimalizeBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AttachBTN = new System.Windows.Forms.Button();
            this.TabControl = new LogIn.LogInTabControl();
            this.BTNS = new System.Windows.Forms.TabPage();
            this.Scripting = new System.Windows.Forms.TabPage();
            this.ScriptBX = new System.Windows.Forms.ListBox();
            this.ScriptTXT = new ScintillaNET.Scintilla();
            this.ExecFileBTN = new System.Windows.Forms.Button();
            this.ReSCRHub = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.CLRBTN = new System.Windows.Forms.Button();
            this.EXLUA = new System.Windows.Forms.Button();
            this.CMDS = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CommandBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FixRobloxBTN = new System.Windows.Forms.Button();
            this.OptionsBTN = new System.Windows.Forms.Button();
            this.DiscordBTN = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.Scripting.SuspendLayout();
            this.CMDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.FlatAppearance.BorderSize = 0;
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitBTN.ForeColor = System.Drawing.Color.White;
            this.ExitBTN.Location = new System.Drawing.Point(1003, -2);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(58, 56);
            this.ExitBTN.TabIndex = 4;
            this.ExitBTN.Text = "X";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // TopMostBTN
            // 
            this.TopMostBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMostBTN.BackColor = System.Drawing.Color.Red;
            this.TopMostBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopMostBTN.FlatAppearance.BorderSize = 0;
            this.TopMostBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMostBTN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TopMostBTN.Location = new System.Drawing.Point(877, -2);
            this.TopMostBTN.Name = "TopMostBTN";
            this.TopMostBTN.Size = new System.Drawing.Size(77, 32);
            this.TopMostBTN.TabIndex = 8;
            this.TopMostBTN.Text = "TopMost";
            this.TopMostBTN.UseVisualStyleBackColor = false;
            this.TopMostBTN.Click += new System.EventHandler(this.TopMostBTN_Click);
            // 
            // TopMostBTN1
            // 
            this.TopMostBTN1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMostBTN1.BackColor = System.Drawing.Color.Green;
            this.TopMostBTN1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TopMostBTN1.FlatAppearance.BorderSize = 0;
            this.TopMostBTN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMostBTN1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TopMostBTN1.Location = new System.Drawing.Point(877, -2);
            this.TopMostBTN1.Name = "TopMostBTN1";
            this.TopMostBTN1.Size = new System.Drawing.Size(77, 32);
            this.TopMostBTN1.TabIndex = 9;
            this.TopMostBTN1.Text = "TopMost";
            this.TopMostBTN1.UseVisualStyleBackColor = false;
            this.TopMostBTN1.Click += new System.EventHandler(this.TopMostBTN1_Click);
            // 
            // minimalizeBTN
            // 
            this.minimalizeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimalizeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimalizeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimalizeBTN.FlatAppearance.BorderSize = 0;
            this.minimalizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizeBTN.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimalizeBTN.ForeColor = System.Drawing.Color.White;
            this.minimalizeBTN.Location = new System.Drawing.Point(949, -2);
            this.minimalizeBTN.Name = "minimalizeBTN";
            this.minimalizeBTN.Size = new System.Drawing.Size(58, 56);
            this.minimalizeBTN.TabIndex = 10;
            this.minimalizeBTN.Text = "_";
            this.minimalizeBTN.UseVisualStyleBackColor = false;
            this.minimalizeBTN.Click += new System.EventHandler(this.minimalizeBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "B Sploit";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // AttachBTN
            // 
            this.AttachBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AttachBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttachBTN.FlatAppearance.BorderSize = 0;
            this.AttachBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachBTN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AttachBTN.ForeColor = System.Drawing.Color.White;
            this.AttachBTN.Location = new System.Drawing.Point(199, 4);
            this.AttachBTN.Name = "AttachBTN";
            this.AttachBTN.Size = new System.Drawing.Size(98, 48);
            this.AttachBTN.TabIndex = 13;
            this.AttachBTN.Text = "Attach";
            this.AttachBTN.UseVisualStyleBackColor = false;
            this.AttachBTN.Click += new System.EventHandler(this.AttachBTN_Click);
            // 
            // TabControl
            // 
            this.TabControl.ActiveColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.BackTabColour = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.TabControl.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TabControl.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TabControl.Controls.Add(this.BTNS);
            this.TabControl.Controls.Add(this.Scripting);
            this.TabControl.Controls.Add(this.CMDS);
            this.TabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TabControl.HorizontalLineColour = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(119)))), ((int)(((byte)(151)))));
            this.TabControl.ItemSize = new System.Drawing.Size(240, 32);
            this.TabControl.Location = new System.Drawing.Point(0, 57);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1061, 603);
            this.TabControl.TabIndex = 14;
            this.TabControl.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabControl.UpLineColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            // 
            // BTNS
            // 
            this.BTNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BTNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BTNS.Location = new System.Drawing.Point(4, 36);
            this.BTNS.Name = "BTNS";
            this.BTNS.Padding = new System.Windows.Forms.Padding(3);
            this.BTNS.Size = new System.Drawing.Size(1053, 563);
            this.BTNS.TabIndex = 0;
            this.BTNS.Text = "Buttons";
            // 
            // Scripting
            // 
            this.Scripting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Scripting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scripting.Controls.Add(this.ScriptBX);
            this.Scripting.Controls.Add(this.ScriptTXT);
            this.Scripting.Controls.Add(this.ExecFileBTN);
            this.Scripting.Controls.Add(this.ReSCRHub);
            this.Scripting.Controls.Add(this.OpenFile);
            this.Scripting.Controls.Add(this.CLRBTN);
            this.Scripting.Controls.Add(this.EXLUA);
            this.Scripting.Location = new System.Drawing.Point(4, 36);
            this.Scripting.Name = "Scripting";
            this.Scripting.Padding = new System.Windows.Forms.Padding(3);
            this.Scripting.Size = new System.Drawing.Size(1053, 563);
            this.Scripting.TabIndex = 1;
            this.Scripting.Text = "Scripting";
            // 
            // ScriptBX
            // 
            this.ScriptBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScriptBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScriptBX.ForeColor = System.Drawing.Color.White;
            this.ScriptBX.FormattingEnabled = true;
            this.ScriptBX.ItemHeight = 17;
            this.ScriptBX.Location = new System.Drawing.Point(915, 2);
            this.ScriptBX.Name = "ScriptBX";
            this.ScriptBX.Size = new System.Drawing.Size(130, 495);
            this.ScriptBX.TabIndex = 11;
            this.ScriptBX.SelectedIndexChanged += new System.EventHandler(this.ScriptBX_SelectedIndexChanged);
            // 
            // ScriptTXT
            // 
            this.ScriptTXT.AdditionalCaretForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ScriptTXT.AllowDrop = true;
            this.ScriptTXT.Location = new System.Drawing.Point(2, 2);
            this.ScriptTXT.Name = "ScriptTXT";
            this.ScriptTXT.Size = new System.Drawing.Size(907, 507);
            this.ScriptTXT.TabIndex = 10;
            // 
            // ExecFileBTN
            // 
            this.ExecFileBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecFileBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExecFileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecFileBTN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExecFileBTN.ForeColor = System.Drawing.Color.White;
            this.ExecFileBTN.Location = new System.Drawing.Point(344, 516);
            this.ExecFileBTN.Name = "ExecFileBTN";
            this.ExecFileBTN.Size = new System.Drawing.Size(106, 38);
            this.ExecFileBTN.TabIndex = 9;
            this.ExecFileBTN.Text = "Execute File";
            this.ExecFileBTN.UseVisualStyleBackColor = true;
            this.ExecFileBTN.Click += new System.EventHandler(this.ExecFileBTN_Click);
            // 
            // ReSCRHub
            // 
            this.ReSCRHub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReSCRHub.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReSCRHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReSCRHub.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReSCRHub.ForeColor = System.Drawing.Color.White;
            this.ReSCRHub.Location = new System.Drawing.Point(915, 515);
            this.ReSCRHub.Name = "ReSCRHub";
            this.ReSCRHub.Size = new System.Drawing.Size(128, 38);
            this.ReSCRHub.TabIndex = 7;
            this.ReSCRHub.Text = "Refresh";
            this.ReSCRHub.UseVisualStyleBackColor = true;
            this.ReSCRHub.Click += new System.EventHandler(this.ReSCRHub_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Location = new System.Drawing.Point(232, 515);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(106, 38);
            this.OpenFile.TabIndex = 5;
            this.OpenFile.Text = "Load File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // CLRBTN
            // 
            this.CLRBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CLRBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CLRBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLRBTN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CLRBTN.ForeColor = System.Drawing.Color.White;
            this.CLRBTN.Location = new System.Drawing.Point(120, 515);
            this.CLRBTN.Name = "CLRBTN";
            this.CLRBTN.Size = new System.Drawing.Size(106, 38);
            this.CLRBTN.TabIndex = 4;
            this.CLRBTN.Text = "Clear";
            this.CLRBTN.UseVisualStyleBackColor = true;
            this.CLRBTN.Click += new System.EventHandler(this.CLRBTN_Click);
            // 
            // EXLUA
            // 
            this.EXLUA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EXLUA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EXLUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXLUA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EXLUA.ForeColor = System.Drawing.Color.White;
            this.EXLUA.Location = new System.Drawing.Point(8, 516);
            this.EXLUA.Name = "EXLUA";
            this.EXLUA.Size = new System.Drawing.Size(106, 38);
            this.EXLUA.TabIndex = 2;
            this.EXLUA.Text = "Execute Lua";
            this.EXLUA.UseVisualStyleBackColor = true;
            this.EXLUA.Click += new System.EventHandler(this.EXLUA_Click);
            // 
            // CMDS
            // 
            this.CMDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CMDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMDS.Controls.Add(this.textBox1);
            this.CMDS.Controls.Add(this.CommandBox);
            this.CMDS.Location = new System.Drawing.Point(4, 36);
            this.CMDS.Name = "CMDS";
            this.CMDS.Padding = new System.Windows.Forms.Padding(3);
            this.CMDS.Size = new System.Drawing.Size(1053, 563);
            this.CMDS.TabIndex = 2;
            this.CMDS.Text = "Commands";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(2, 534);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1047, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // CommandBox
            // 
            this.CommandBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandBox.BackColor = System.Drawing.Color.Gray;
            this.CommandBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CommandBox.Location = new System.Drawing.Point(-1, -1);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.ReadOnly = true;
            this.CommandBox.Size = new System.Drawing.Size(1050, 531);
            this.CommandBox.TabIndex = 0;
            this.CommandBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FixRobloxBTN
            // 
            this.FixRobloxBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FixRobloxBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FixRobloxBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FixRobloxBTN.FlatAppearance.BorderSize = 0;
            this.FixRobloxBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FixRobloxBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FixRobloxBTN.ForeColor = System.Drawing.Color.White;
            this.FixRobloxBTN.Location = new System.Drawing.Point(402, 3);
            this.FixRobloxBTN.Name = "FixRobloxBTN";
            this.FixRobloxBTN.Size = new System.Drawing.Size(75, 48);
            this.FixRobloxBTN.TabIndex = 15;
            this.FixRobloxBTN.Text = "Kill Roblox";
            this.FixRobloxBTN.UseVisualStyleBackColor = false;
            this.FixRobloxBTN.Click += new System.EventHandler(this.FixRobloxBTN_Click);
            // 
            // OptionsBTN
            // 
            this.OptionsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OptionsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsBTN.FlatAppearance.BorderSize = 0;
            this.OptionsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OptionsBTN.ForeColor = System.Drawing.Color.White;
            this.OptionsBTN.Location = new System.Drawing.Point(303, 3);
            this.OptionsBTN.Name = "OptionsBTN";
            this.OptionsBTN.Size = new System.Drawing.Size(93, 48);
            this.OptionsBTN.TabIndex = 17;
            this.OptionsBTN.Text = "Options";
            this.OptionsBTN.UseVisualStyleBackColor = false;
            this.OptionsBTN.Click += new System.EventHandler(this.OptionsBTN_Click);
            // 
            // DiscordBTN
            // 
            this.DiscordBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscordBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DiscordBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordBTN.FlatAppearance.BorderSize = 0;
            this.DiscordBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscordBTN.Image = global::BSploit.Properties.Resources.ggg;
            this.DiscordBTN.Location = new System.Drawing.Point(483, 4);
            this.DiscordBTN.Name = "DiscordBTN";
            this.DiscordBTN.Size = new System.Drawing.Size(54, 50);
            this.DiscordBTN.TabIndex = 16;
            this.DiscordBTN.UseVisualStyleBackColor = true;
            this.DiscordBTN.Click += new System.EventHandler(this.DiscordBTN_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // BSploit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.OptionsBTN);
            this.Controls.Add(this.DiscordBTN);
            this.Controls.Add(this.FixRobloxBTN);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.AttachBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimalizeBTN);
            this.Controls.Add(this.TopMostBTN1);
            this.Controls.Add(this.TopMostBTN);
            this.Controls.Add(this.ExitBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BSploit";
            this.Text = "BSploit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.TabControl.ResumeLayout(false);
            this.Scripting.ResumeLayout(false);
            this.CMDS.ResumeLayout(false);
            this.CMDS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button TopMostBTN;
        private System.Windows.Forms.Button TopMostBTN1;
        private System.Windows.Forms.Button minimalizeBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AttachBTN;
        private LogIn.LogInTabControl TabControl;
        private System.Windows.Forms.TabPage BTNS;
        private System.Windows.Forms.TabPage Scripting;
        private System.Windows.Forms.TabPage CMDS;
        private System.Windows.Forms.Button EXLUA;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button CLRBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FixRobloxBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox CommandBox;
        private System.Windows.Forms.Button DiscordBTN;
        private System.Windows.Forms.Button ReSCRHub;
        private System.Windows.Forms.Button OptionsBTN;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button ExecFileBTN;
        private ScintillaNET.Scintilla ScriptTXT;
        private System.Windows.Forms.ListBox ScriptBX;
    }
}


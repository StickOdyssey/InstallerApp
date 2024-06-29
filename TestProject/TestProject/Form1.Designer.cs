namespace TestProject
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            folderDialog = new FolderBrowserDialog();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            install = new Button();
            browser = new CheckBox();
            page1 = new Panel();
            steam = new CheckBox();
            browserDropdown = new ComboBox();
            discord = new CheckBox();
            closeApp = new Button();
            pictureBox1 = new PictureBox();
            title = new Label();
            page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(21, 21, 21);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.DetectUrls = false;
            richTextBox1.Font = new Font("Ubuntu", 12F);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(8, 510);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ShortcutsEnabled = false;
            richTextBox1.Size = new Size(496, 32);
            richTextBox1.TabIndex = 1;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "Logs";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(21, 21, 21);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(256, 478);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(248, 32);
            button1.TabIndex = 5;
            button1.Text = "Choose Directory";
            button1.UseVisualStyleBackColor = false;
            button1.Click += chdir_Click;
            // 
            // install
            // 
            install.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            install.BackColor = Color.FromArgb(21, 21, 21);
            install.FlatAppearance.BorderColor = Color.White;
            install.FlatStyle = FlatStyle.Flat;
            install.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Bold);
            install.ForeColor = Color.White;
            install.Location = new Point(8, 478);
            install.Margin = new Padding(0);
            install.Name = "install";
            install.Size = new Size(249, 32);
            install.TabIndex = 4;
            install.Text = "Install";
            install.UseVisualStyleBackColor = false;
            install.Click += install_Click;
            // 
            // browser
            // 
            browser.AutoSize = true;
            browser.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Bold);
            browser.ForeColor = Color.White;
            browser.Location = new Point(8, 4);
            browser.Margin = new Padding(4);
            browser.MaximumSize = new Size(512, 512);
            browser.Name = "browser";
            browser.Size = new Size(90, 25);
            browser.TabIndex = 0;
            browser.Text = "Browser";
            browser.UseVisualStyleBackColor = true;
            browser.CheckedChanged += browser_CheckedChanged;
            // 
            // page1
            // 
            page1.BackColor = Color.FromArgb(21, 21, 21);
            page1.Controls.Add(steam);
            page1.Controls.Add(browserDropdown);
            page1.Controls.Add(discord);
            page1.Controls.Add(browser);
            page1.Font = new Font("Share Tech Mono", 12F);
            page1.Location = new Point(8, 49);
            page1.Margin = new Padding(0);
            page1.Name = "page1";
            page1.Size = new Size(496, 429);
            page1.TabIndex = 3;
            // 
            // steam
            // 
            steam.AutoSize = true;
            steam.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Bold);
            steam.ForeColor = Color.White;
            steam.Location = new Point(8, 70);
            steam.Margin = new Padding(4);
            steam.MaximumSize = new Size(512, 512);
            steam.Name = "steam";
            steam.Size = new Size(77, 25);
            steam.TabIndex = 3;
            steam.Text = "Steam";
            steam.UseVisualStyleBackColor = true;
            steam.CheckedChanged += steam_CheckedChanged;
            // 
            // browserDropdown
            // 
            browserDropdown.BackColor = Color.White;
            browserDropdown.DropDownHeight = 126;
            browserDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            browserDropdown.Enabled = false;
            browserDropdown.Font = new Font("Share Tech Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browserDropdown.FormattingEnabled = true;
            browserDropdown.IntegralHeight = false;
            browserDropdown.ItemHeight = 18;
            browserDropdown.Items.AddRange(new object[] { "Firefox", "Chrome" });
            browserDropdown.Location = new Point(110, 4);
            browserDropdown.Margin = new Padding(0);
            browserDropdown.MaximumSize = new Size(1000, 0);
            browserDropdown.MinimumSize = new Size(108, 0);
            browserDropdown.Name = "browserDropdown";
            browserDropdown.Size = new Size(108, 26);
            browserDropdown.TabIndex = 2;
            browserDropdown.TabStop = false;
            browserDropdown.SelectedIndexChanged += browserDropdown_SelectedIndexChanged;
            // 
            // discord
            // 
            discord.AutoSize = true;
            discord.Font = new Font("Ubuntu", 11.9999981F, FontStyle.Bold);
            discord.ForeColor = Color.White;
            discord.Location = new Point(8, 37);
            discord.Margin = new Padding(4);
            discord.MaximumSize = new Size(512, 512);
            discord.Name = "discord";
            discord.Size = new Size(86, 25);
            discord.TabIndex = 1;
            discord.Text = "Discord";
            discord.UseVisualStyleBackColor = true;
            discord.CheckedChanged += discord_CheckedChanged;
            // 
            // closeApp
            // 
            closeApp.BackColor = Color.Transparent;
            closeApp.FlatAppearance.BorderSize = 0;
            closeApp.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            closeApp.FlatStyle = FlatStyle.Flat;
            closeApp.Font = new Font("Share Tech Mono", 8F);
            closeApp.ForeColor = Color.Transparent;
            closeApp.Image = Properties.Resources.X_LowRes;
            closeApp.Location = new Point(472, 8);
            closeApp.Margin = new Padding(0);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(32, 32);
            closeApp.TabIndex = 6;
            closeApp.UseVisualStyleBackColor = false;
            closeApp.Click += closeApp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.ShellSharpLogo_LowRes;
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 34);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // title
            // 
            title.Enabled = false;
            title.Font = new Font("Ubuntu", 16F, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Location = new Point(45, 8);
            title.Name = "title";
            title.Size = new Size(290, 34);
            title.TabIndex = 8;
            title.Text = "ShellSharp Install Script";
            title.TextAlign = ContentAlignment.MiddleLeft;
            title.EnabledChanged += title_EnabledChanged;
            title.Paint += title_Paint;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(11, 43, 85);
            ClientSize = new Size(512, 550);
            Controls.Add(title);
            Controls.Add(pictureBox1);
            Controls.Add(closeApp);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(install);
            Controls.Add(page1);
            Font = new Font("Share Tech Mono", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            MaximumSize = new Size(512, 550);
            MinimumSize = new Size(512, 550);
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdysseyDev Install Script";
            TopMost = true;
            Load += Form_Load;
            MouseDown += form1_MouseDown;
            MouseMove += form1_MouseMove;
            page1.ResumeLayout(false);
            page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderDialog;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button install;
        private CheckBox browser;
        private Panel page1;
        private Button closeApp;
        private CheckBox discord;
        private PictureBox pictureBox1;
        private Label title;
        private ComboBox browserDropdown;
        private CheckBox steam;
    }
}

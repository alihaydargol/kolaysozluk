using System;

namespace kolaysozluk
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.savedWords = new System.Windows.Forms.Button();
            this.chromWebBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.sytemTrayNI = new System.Windows.Forms.NotifyIcon(this.components);
            this.cambridgeButton = new System.Windows.Forms.Button();
            this.merriamButton = new System.Windows.Forms.Button();
            this.turengButton = new System.Windows.Forms.Button();
            this.dictionarySelectorPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.textBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.wordsTable = new kolaysozluk.CustomControls.WordsTable();
            this.searchPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Location = new System.Drawing.Point(12, 30);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(477, 54);
            this.searchPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.searchButton.BackgroundImage = global::kolaysozluk.Properties.Resources.search_circle_outline;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.Location = new System.Drawing.Point(421, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(41, 41);
            this.searchButton.TabIndex = 4;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Roboto Thin", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchBox.Location = new System.Drawing.Point(17, 6);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(440, 41);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(501, 30);
            this.topPanel.TabIndex = 3;
            this.topPanel.DoubleClick += new System.EventHandler(this.TopPanel_DoubleClick);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(491, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 30);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 30);
            this.panel1.TabIndex = 6;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackgroundImage = global::kolaysozluk.Properties.Resources.minimize;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(433, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackgroundImage = global::kolaysozluk.Properties.Resources.exiticon;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(465, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            // 
            // savedWords
            // 
            this.savedWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savedWords.BackgroundImage = global::kolaysozluk.Properties.Resources.list_circle_outline2;
            this.savedWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savedWords.FlatAppearance.BorderSize = 0;
            this.savedWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedWords.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savedWords.Location = new System.Drawing.Point(433, 90);
            this.savedWords.Name = "savedWords";
            this.savedWords.Size = new System.Drawing.Size(56, 56);
            this.savedWords.TabIndex = 5;
            this.savedWords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.savedWords.UseVisualStyleBackColor = true;
            this.savedWords.Click += new System.EventHandler(this.SavedWords_Click);
            // 
            // chromWebBrowser
            // 
            this.chromWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.chromWebBrowser.Name = "chromWebBrowser";
            this.chromWebBrowser.Size = new System.Drawing.Size(476, 368);
            this.chromWebBrowser.TabIndex = 2;
            // 
            // sytemTrayNI
            // 
            this.sytemTrayNI.Icon = ((System.Drawing.Icon)(resources.GetObject("sytemTrayNI.Icon")));
            this.sytemTrayNI.Text = "Sözlük";
            this.sytemTrayNI.Visible = true;
            // 
            // cambridgeButton
            // 
            this.cambridgeButton.BackgroundImage = global::kolaysozluk.Properties.Resources.new_logo1;
            this.cambridgeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cambridgeButton.FlatAppearance.BorderSize = 0;
            this.cambridgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambridgeButton.Location = new System.Drawing.Point(150, 90);
            this.cambridgeButton.Name = "cambridgeButton";
            this.cambridgeButton.Size = new System.Drawing.Size(50, 50);
            this.cambridgeButton.TabIndex = 7;
            this.cambridgeButton.UseVisualStyleBackColor = true;
            this.cambridgeButton.Click += new System.EventHandler(this.CambridgeButton_Click);
            // 
            // merriamButton
            // 
            this.merriamButton.BackgroundImage = global::kolaysozluk.Properties.Resources._1200px_Merriam_Webster_logo_svg;
            this.merriamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.merriamButton.FlatAppearance.BorderSize = 0;
            this.merriamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.merriamButton.Location = new System.Drawing.Point(94, 90);
            this.merriamButton.Name = "merriamButton";
            this.merriamButton.Size = new System.Drawing.Size(50, 50);
            this.merriamButton.TabIndex = 8;
            this.merriamButton.UseVisualStyleBackColor = true;
            this.merriamButton.Click += new System.EventHandler(this.MerriamButton_Click);
            // 
            // turengButton
            // 
            this.turengButton.BackgroundImage = global::kolaysozluk.Properties.Resources._1433279304_tureng_sozluk_ico;
            this.turengButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turengButton.FlatAppearance.BorderSize = 0;
            this.turengButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turengButton.Location = new System.Drawing.Point(39, 90);
            this.turengButton.Name = "turengButton";
            this.turengButton.Size = new System.Drawing.Size(50, 50);
            this.turengButton.TabIndex = 9;
            this.turengButton.UseVisualStyleBackColor = true;
            this.turengButton.Click += new System.EventHandler(this.TurengButton_Click);
            // 
            // dictionarySelectorPanel
            // 
            this.dictionarySelectorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.dictionarySelectorPanel.Location = new System.Drawing.Point(39, 90);
            this.dictionarySelectorPanel.Name = "dictionarySelectorPanel";
            this.dictionarySelectorPanel.Size = new System.Drawing.Size(5, 50);
            this.dictionarySelectorPanel.TabIndex = 10;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Controls.Add(this.wordsTable);
            this.contentPanel.Controls.Add(this.chromWebBrowser);
            this.contentPanel.Location = new System.Drawing.Point(12, 152);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(476, 368);
            this.contentPanel.TabIndex = 13;
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Interval = 200;
            this.textBoxTimer.Tick += new System.EventHandler(this.textBoxTimer_Tick);
            // 
            // wordsTable
            // 
            this.wordsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.wordsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordsTable.Location = new System.Drawing.Point(0, 0);
            this.wordsTable.Margin = new System.Windows.Forms.Padding(2);
            this.wordsTable.Name = "wordsTable";
            this.wordsTable.Size = new System.Drawing.Size(476, 368);
            this.wordsTable.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(501, 532);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.dictionarySelectorPanel);
            this.Controls.Add(this.savedWords);
            this.Controls.Add(this.cambridgeButton);
            this.Controls.Add(this.merriamButton);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.turengButton);
            this.Controls.Add(this.searchPanel);
            this.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button exitButton;
        private CefSharp.WinForms.ChromiumWebBrowser chromWebBrowser;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.NotifyIcon sytemTrayNI;
        private System.Windows.Forms.Button savedWords;
        private System.Windows.Forms.Button cambridgeButton;
        private System.Windows.Forms.Button merriamButton;
        private System.Windows.Forms.Button turengButton;
        private System.Windows.Forms.Panel dictionarySelectorPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.WordsTable wordsTable;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Timer textBoxTimer;
    }
}


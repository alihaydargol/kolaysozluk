namespace kolaysozluk.CustomControls
{
    partial class WordsTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.nextPage = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.tableContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.word1 = new System.Windows.Forms.TextBox();
            this.word2 = new System.Windows.Forms.TextBox();
            this.word3 = new System.Windows.Forms.TextBox();
            this.word4 = new System.Windows.Forms.TextBox();
            this.meaning1 = new System.Windows.Forms.TextBox();
            this.meaning2 = new System.Windows.Forms.TextBox();
            this.meaning3 = new System.Windows.Forms.TextBox();
            this.meaning4 = new System.Windows.Forms.TextBox();
            this.search1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.tableContextMenuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.topPanel.Controls.Add(this.nextPage);
            this.topPanel.Controls.Add(this.listLabel);
            this.topPanel.Location = new System.Drawing.Point(6, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(592, 50);
            this.topPanel.TabIndex = 0;
            // 
            // nextPage
            // 
            this.nextPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextPage.FlatAppearance.BorderSize = 0;
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPage.Location = new System.Drawing.Point(517, 0);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(75, 50);
            this.nextPage.TabIndex = 1;
            this.nextPage.Text = "Sonraki Sayfa";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // listLabel
            // 
            this.listLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLabel.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.listLabel.Location = new System.Drawing.Point(0, 0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(592, 50);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "Kayıtlı Kelimeler";
            this.listLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableContextMenuStrip
            // 
            this.tableContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.tableContextMenuStrip.Name = "tableContextMenuStrip";
            this.tableContextMenuStrip.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.11111F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.11111F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel.Controls.Add(this.word1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.word2, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.word3, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.word4, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.meaning1, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.meaning2, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.meaning3, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.meaning4, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.search1, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.button2, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.button4, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(4, -2);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(594, 457);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // word1
            // 
            this.word1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.word1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.word1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.word1.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.word1.Location = new System.Drawing.Point(4, 54);
            this.word1.Margin = new System.Windows.Forms.Padding(4);
            this.word1.Multiline = true;
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(206, 93);
            this.word1.TabIndex = 1;
            this.word1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // word2
            // 
            this.word2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.word2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.word2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.word2.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.word2.Location = new System.Drawing.Point(4, 155);
            this.word2.Margin = new System.Windows.Forms.Padding(4);
            this.word2.Multiline = true;
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(206, 93);
            this.word2.TabIndex = 1;
            this.word2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // word3
            // 
            this.word3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.word3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.word3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.word3.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.word3.Location = new System.Drawing.Point(4, 256);
            this.word3.Margin = new System.Windows.Forms.Padding(4);
            this.word3.Multiline = true;
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(206, 93);
            this.word3.TabIndex = 1;
            this.word3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // word4
            // 
            this.word4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.word4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.word4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.word4.Font = new System.Drawing.Font("Roboto", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.word4.Location = new System.Drawing.Point(4, 357);
            this.word4.Margin = new System.Windows.Forms.Padding(4);
            this.word4.Multiline = true;
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(206, 96);
            this.word4.TabIndex = 1;
            this.word4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meaning1
            // 
            this.meaning1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.meaning1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meaning1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning1.Location = new System.Drawing.Point(218, 54);
            this.meaning1.Margin = new System.Windows.Forms.Padding(4);
            this.meaning1.Multiline = true;
            this.meaning1.Name = "meaning1";
            this.meaning1.Size = new System.Drawing.Size(206, 93);
            this.meaning1.TabIndex = 1;
            this.meaning1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meaning2
            // 
            this.meaning2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.meaning2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meaning2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning2.Location = new System.Drawing.Point(218, 155);
            this.meaning2.Margin = new System.Windows.Forms.Padding(4);
            this.meaning2.Multiline = true;
            this.meaning2.Name = "meaning2";
            this.meaning2.Size = new System.Drawing.Size(206, 93);
            this.meaning2.TabIndex = 1;
            this.meaning2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meaning3
            // 
            this.meaning3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.meaning3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meaning3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning3.Location = new System.Drawing.Point(218, 256);
            this.meaning3.Margin = new System.Windows.Forms.Padding(4);
            this.meaning3.Multiline = true;
            this.meaning3.Name = "meaning3";
            this.meaning3.Size = new System.Drawing.Size(206, 93);
            this.meaning3.TabIndex = 1;
            this.meaning3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // meaning4
            // 
            this.meaning4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.meaning4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meaning4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning4.Location = new System.Drawing.Point(218, 357);
            this.meaning4.Margin = new System.Windows.Forms.Padding(4);
            this.meaning4.Multiline = true;
            this.meaning4.Name = "meaning4";
            this.meaning4.Size = new System.Drawing.Size(206, 96);
            this.meaning4.TabIndex = 1;
            this.meaning4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.search1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search1.FlatAppearance.BorderSize = 0;
            this.search1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search1.Location = new System.Drawing.Point(432, 54);
            this.search1.Margin = new System.Windows.Forms.Padding(4);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(158, 93);
            this.search1.TabIndex = 2;
            this.search1.Text = "ARA";
            this.search1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(432, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 93);
            this.button2.TabIndex = 2;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(432, 256);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 93);
            this.button3.TabIndex = 2;
            this.button3.Text = "ARA";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(432, 357);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 96);
            this.button4.TabIndex = 2;
            this.button4.Text = "ARA";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(432, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(218, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anlam";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelime";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 459);
            this.panel1.TabIndex = 5;
            // 
            // WordsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordsTable";
            this.Size = new System.Drawing.Size(602, 517);
            this.topPanel.ResumeLayout(false);
            this.tableContextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.ContextMenuStrip tableContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox word1;
        private System.Windows.Forms.TextBox word2;
        private System.Windows.Forms.TextBox word3;
        private System.Windows.Forms.TextBox word4;
        private System.Windows.Forms.TextBox meaning1;
        private System.Windows.Forms.TextBox meaning2;
        private System.Windows.Forms.TextBox meaning3;
        private System.Windows.Forms.TextBox meaning4;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextPage;
    }
}

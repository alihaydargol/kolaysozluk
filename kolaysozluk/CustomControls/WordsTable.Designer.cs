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
            this.previousPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.tableContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.meaning3 = new System.Windows.Forms.Label();
            this.meaning4 = new System.Windows.Forms.Label();
            this.word4 = new System.Windows.Forms.Label();
            this.word3 = new System.Windows.Forms.Label();
            this.word2 = new System.Windows.Forms.Label();
            this.word1 = new System.Windows.Forms.Label();
            this.meaning1 = new System.Windows.Forms.Label();
            this.meaning2 = new System.Windows.Forms.Label();
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
            this.topPanel.Controls.Add(this.previousPage);
            this.topPanel.Controls.Add(this.nextPage);
            this.topPanel.Controls.Add(this.listLabel);
            this.topPanel.Location = new System.Drawing.Point(6, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(584, 50);
            this.topPanel.TabIndex = 0;
            // 
            // previousPage
            // 
            this.previousPage.BackgroundImage = global::kolaysozluk.Properties.Resources.arrow_back_circle;
            this.previousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.previousPage.FlatAppearance.BorderSize = 0;
            this.previousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPage.Location = new System.Drawing.Point(0, 0);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(75, 50);
            this.previousPage.TabIndex = 2;
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.BackgroundImage = global::kolaysozluk.Properties.Resources.arrow_forward_circle;
            this.nextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextPage.FlatAppearance.BorderSize = 0;
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPage.Location = new System.Drawing.Point(509, 0);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(75, 50);
            this.nextPage.TabIndex = 1;
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
            this.listLabel.Size = new System.Drawing.Size(584, 50);
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
            this.tableLayoutPanel.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.date1, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.date2, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.date3, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.date4, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.meaning3, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.meaning4, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.word4, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.word3, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.word2, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.word1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.meaning1, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.meaning2, 1, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(4, -2);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(586, 504);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(426, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarih";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(215, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 55);
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
            this.label3.Size = new System.Drawing.Size(203, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelime";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date1.Location = new System.Drawing.Point(425, 55);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(158, 111);
            this.date1.TabIndex = 5;
            this.date1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date2.Location = new System.Drawing.Point(425, 166);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(158, 111);
            this.date2.TabIndex = 5;
            this.date2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date3.Location = new System.Drawing.Point(425, 277);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(158, 111);
            this.date3.TabIndex = 5;
            this.date3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date4
            // 
            this.date4.AutoSize = true;
            this.date4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date4.Location = new System.Drawing.Point(425, 388);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(158, 116);
            this.date4.TabIndex = 5;
            this.date4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meaning3
            // 
            this.meaning3.AutoSize = true;
            this.meaning3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning3.Location = new System.Drawing.Point(214, 277);
            this.meaning3.Name = "meaning3";
            this.meaning3.Size = new System.Drawing.Size(205, 111);
            this.meaning3.TabIndex = 5;
            this.meaning3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meaning4
            // 
            this.meaning4.AutoSize = true;
            this.meaning4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning4.Location = new System.Drawing.Point(214, 388);
            this.meaning4.Name = "meaning4";
            this.meaning4.Size = new System.Drawing.Size(205, 116);
            this.meaning4.TabIndex = 5;
            this.meaning4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word4
            // 
            this.word4.AutoSize = true;
            this.word4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.word4.Location = new System.Drawing.Point(3, 388);
            this.word4.Name = "word4";
            this.word4.Size = new System.Drawing.Size(205, 116);
            this.word4.TabIndex = 5;
            this.word4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word3
            // 
            this.word3.AutoSize = true;
            this.word3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.word3.Location = new System.Drawing.Point(3, 277);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(205, 111);
            this.word3.TabIndex = 5;
            this.word3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word2
            // 
            this.word2.AutoSize = true;
            this.word2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.word2.Location = new System.Drawing.Point(3, 166);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(205, 111);
            this.word2.TabIndex = 5;
            this.word2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word1
            // 
            this.word1.AutoSize = true;
            this.word1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.word1.Location = new System.Drawing.Point(3, 55);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(205, 111);
            this.word1.TabIndex = 5;
            this.word1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meaning1
            // 
            this.meaning1.AutoSize = true;
            this.meaning1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning1.Location = new System.Drawing.Point(214, 55);
            this.meaning1.Name = "meaning1";
            this.meaning1.Size = new System.Drawing.Size(205, 111);
            this.meaning1.TabIndex = 5;
            this.meaning1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meaning2
            // 
            this.meaning2.AutoSize = true;
            this.meaning2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meaning2.Location = new System.Drawing.Point(214, 166);
            this.meaning2.Name = "meaning2";
            this.meaning2.Size = new System.Drawing.Size(205, 111);
            this.meaning2.TabIndex = 5;
            this.meaning2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 514);
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
            this.Size = new System.Drawing.Size(594, 560);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button previousPage;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label meaning3;
        private System.Windows.Forms.Label meaning4;
        private System.Windows.Forms.Label word4;
        private System.Windows.Forms.Label word3;
        private System.Windows.Forms.Label word2;
        private System.Windows.Forms.Label word1;
        private System.Windows.Forms.Label meaning1;
        private System.Windows.Forms.Label meaning2;
    }
}

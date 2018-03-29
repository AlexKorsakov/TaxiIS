namespace Kursovik_UD
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьИнтерфейсОператораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интерфейсМедикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интерфейсТехникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интерфейсАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.интерфейсАдминистратораToolStripMenuItem,
            this.открытьИнтерфейсОператораToolStripMenuItem,
            this.интерфейсМедикаToolStripMenuItem,
            this.интерфейсТехникаToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // открытьИнтерфейсОператораToolStripMenuItem
            // 
            this.открытьИнтерфейсОператораToolStripMenuItem.Name = "открытьИнтерфейсОператораToolStripMenuItem";
            this.открытьИнтерфейсОператораToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.открытьИнтерфейсОператораToolStripMenuItem.Text = "&Интерфейс оператора";
            this.открытьИнтерфейсОператораToolStripMenuItem.Click += new System.EventHandler(this.открытьИнтерфейсОператораToolStripMenuItem_Click);
            // 
            // интерфейсМедикаToolStripMenuItem
            // 
            this.интерфейсМедикаToolStripMenuItem.Name = "интерфейсМедикаToolStripMenuItem";
            this.интерфейсМедикаToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.интерфейсМедикаToolStripMenuItem.Text = "&Интерфейс медика";
            this.интерфейсМедикаToolStripMenuItem.Click += new System.EventHandler(this.интерфейсМедикаToolStripMenuItem_Click);
            // 
            // интерфейсТехникаToolStripMenuItem
            // 
            this.интерфейсТехникаToolStripMenuItem.Name = "интерфейсТехникаToolStripMenuItem";
            this.интерфейсТехникаToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.интерфейсТехникаToolStripMenuItem.Text = "Интерфейс техника";
            this.интерфейсТехникаToolStripMenuItem.Click += new System.EventHandler(this.интерфейсТехникаToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // интерфейсАдминистратораToolStripMenuItem
            // 
            this.интерфейсАдминистратораToolStripMenuItem.Name = "интерфейсАдминистратораToolStripMenuItem";
            this.интерфейсАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.интерфейсАдминистратораToolStripMenuItem.Text = "Интерфейс администратора";
            this.интерфейсАдминистратораToolStripMenuItem.Click += new System.EventHandler(this.интерфейсАдминистратораToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 484);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 450);
            this.Name = "Main";
            this.Text = "ИС Такси";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИнтерфейсОператораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интерфейсМедикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интерфейсТехникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интерфейсАдминистратораToolStripMenuItem;
    }
}
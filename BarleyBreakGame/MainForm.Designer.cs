namespace BarleyBreakGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notation10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notation16MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameMenuItem,
            this.loadGameMenuItem,
            this.saveGameMenuItem,
            this.notationMenuItem,
            this.recordsMenuItem,
            this.descriptionMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // startGameMenuItem
            // 
            this.startGameMenuItem.Name = "startGameMenuItem";
            this.startGameMenuItem.Size = new System.Drawing.Size(86, 20);
            this.startGameMenuItem.Text = "Начать игру";
            this.startGameMenuItem.Click += new System.EventHandler(this.startGameMenuItem_Click);
            // 
            // loadGameMenuItem
            // 
            this.loadGameMenuItem.Name = "loadGameMenuItem";
            this.loadGameMenuItem.Size = new System.Drawing.Size(101, 20);
            this.loadGameMenuItem.Text = "Загрузить игру";
            this.loadGameMenuItem.Click += new System.EventHandler(this.loadGameMenuItem_Click);
            // 
            // saveGameMenuItem
            // 
            this.saveGameMenuItem.Name = "saveGameMenuItem";
            this.saveGameMenuItem.Size = new System.Drawing.Size(105, 20);
            this.saveGameMenuItem.Text = "Сохранить игру";
            this.saveGameMenuItem.Click += new System.EventHandler(this.saveGameMenuItem_Click);
            // 
            // notationMenuItem
            // 
            this.notationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notation10MenuItem,
            this.notation16MenuItem});
            this.notationMenuItem.Name = "notationMenuItem";
            this.notationMenuItem.Size = new System.Drawing.Size(128, 20);
            this.notationMenuItem.Text = "Система счисления";
            // 
            // notation10MenuItem
            // 
            this.notation10MenuItem.Name = "notation10MenuItem";
            this.notation10MenuItem.Size = new System.Drawing.Size(99, 22);
            this.notation10MenuItem.Text = "10 ✔";
            this.notation10MenuItem.Click += new System.EventHandler(this.notation10MenuItem_Click);
            // 
            // notation16MenuItem
            // 
            this.notation16MenuItem.Name = "notation16MenuItem";
            this.notation16MenuItem.Size = new System.Drawing.Size(99, 22);
            this.notation16MenuItem.Text = "16";
            this.notation16MenuItem.Click += new System.EventHandler(this.notation16MenuItem_Click);
            // 
            // recordsMenuItem
            // 
            this.recordsMenuItem.Name = "recordsMenuItem";
            this.recordsMenuItem.Size = new System.Drawing.Size(121, 20);
            this.recordsMenuItem.Text = "Таблица рекордов";
            this.recordsMenuItem.Click += new System.EventHandler(this.recordsMenuItem_Click);
            // 
            // descriptionMenuItem
            // 
            this.descriptionMenuItem.Name = "descriptionMenuItem";
            this.descriptionMenuItem.Size = new System.Drawing.Size(65, 20);
            this.descriptionMenuItem.Text = "Справка";
            this.descriptionMenuItem.Click += new System.EventHandler(this.descriptionMenuItem_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.button15, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.button14, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.button13, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.button12, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.button11, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.button10, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.button9, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.button8, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.button7, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.button0, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(603, 321);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(191, 99);
            this.button15.TabIndex = 15;
            this.button15.Tag = "15";
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button0_Click);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(404, 321);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(190, 99);
            this.button14.TabIndex = 14;
            this.button14.Tag = "14";
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button0_Click);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(205, 321);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(190, 99);
            this.button13.TabIndex = 13;
            this.button13.Tag = "13";
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button0_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(6, 321);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(190, 99);
            this.button12.TabIndex = 12;
            this.button12.Tag = "12";
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button0_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(603, 216);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(191, 96);
            this.button11.TabIndex = 11;
            this.button11.Tag = "11";
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button0_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(404, 216);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(190, 96);
            this.button10.TabIndex = 10;
            this.button10.Tag = "10";
            this.button10.Text = "*";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(205, 216);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(190, 96);
            this.button9.TabIndex = 9;
            this.button9.Tag = "9";
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button0_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(6, 216);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 96);
            this.button8.TabIndex = 8;
            this.button8.Tag = "8";
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button0_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(603, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(191, 96);
            this.button7.TabIndex = 7;
            this.button7.Tag = "7";
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button0_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(404, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 96);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.Text = "*";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button0_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(205, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 96);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button0_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(6, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 96);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(603, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 96);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(404, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 96);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(205, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 96);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button0_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(6, 6);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(190, 96);
            this.button0.TabIndex = 0;
            this.button0.Tag = "0";
            this.button0.Text = "*";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startGameMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.ToolStripMenuItem descriptionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notation10MenuItem;
        private System.Windows.Forms.ToolStripMenuItem notation16MenuItem;
    }
}


namespace Sea_battle_ships.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepareFleetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeaOwnPanel = new System.Windows.Forms.Panel();
            this.SeaEnemyPanel = new System.Windows.Forms.Panel();
            this.SeaOwnGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FourShipRadioButton = new System.Windows.Forms.RadioButton();
            this.ThreeShipRadioButton = new System.Windows.Forms.RadioButton();
            this.TwoShipRadioButton = new System.Windows.Forms.RadioButton();
            this.OneShipRadioButton = new System.Windows.Forms.RadioButton();
            this.SeaEnemyGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SeaOwnGroupBox.SuspendLayout();
            this.SeaEnemyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.prepareFleetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGAMEToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "menu";
            // 
            // newGAMEToolStripMenuItem
            // 
            this.newGAMEToolStripMenuItem.Name = "newGAMEToolStripMenuItem";
            this.newGAMEToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newGAMEToolStripMenuItem.Text = "New GAME";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // prepareFleetToolStripMenuItem
            // 
            this.prepareFleetToolStripMenuItem.Name = "prepareFleetToolStripMenuItem";
            this.prepareFleetToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.prepareFleetToolStripMenuItem.Text = "Prepare Fleet";
            // 
            // SeaOwnPanel
            // 
            this.SeaOwnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeaOwnPanel.Location = new System.Drawing.Point(20, 50);
            this.SeaOwnPanel.Name = "SeaOwnPanel";
            this.SeaOwnPanel.Size = new System.Drawing.Size(230, 230);
            this.SeaOwnPanel.TabIndex = 1;

            // 
            // SeaEnemyPanel
            // 
            this.SeaEnemyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeaEnemyPanel.Location = new System.Drawing.Point(260, 50);
            this.SeaEnemyPanel.Name = "SeaEnemyPanel";
            this.SeaEnemyPanel.Size = new System.Drawing.Size(230, 230);
            this.SeaEnemyPanel.TabIndex = 2;
            // 
            // SeaOwnGroupBox
            // 
            this.SeaOwnGroupBox.Controls.Add(this.textBox4);
            this.SeaOwnGroupBox.Controls.Add(this.textBox3);
            this.SeaOwnGroupBox.Controls.Add(this.textBox2);
            this.SeaOwnGroupBox.Controls.Add(this.textBox1);
            this.SeaOwnGroupBox.Controls.Add(this.FourShipRadioButton);
            this.SeaOwnGroupBox.Controls.Add(this.ThreeShipRadioButton);
            this.SeaOwnGroupBox.Controls.Add(this.TwoShipRadioButton);
            this.SeaOwnGroupBox.Controls.Add(this.OneShipRadioButton);
            this.SeaOwnGroupBox.Location = new System.Drawing.Point(20, 290);
            this.SeaOwnGroupBox.Name = "SeaOwnGroupBox";
            this.SeaOwnGroupBox.Size = new System.Drawing.Size(230, 139);
            this.SeaOwnGroupBox.TabIndex = 3;
            this.SeaOwnGroupBox.TabStop = false;
            this.SeaOwnGroupBox.Text = "Наш флот";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // FourShipRadioButton
            // 
            this.FourShipRadioButton.AutoSize = true;
            this.FourShipRadioButton.Location = new System.Drawing.Point(7, 91);
            this.FourShipRadioButton.Name = "FourShipRadioButton";
            this.FourShipRadioButton.Size = new System.Drawing.Size(71, 17);
            this.FourShipRadioButton.TabIndex = 3;
            this.FourShipRadioButton.TabStop = true;
            this.FourShipRadioButton.Text = "4 палубы";
            this.FourShipRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThreeShipRadioButton
            // 
            this.ThreeShipRadioButton.AutoSize = true;
            this.ThreeShipRadioButton.Location = new System.Drawing.Point(7, 68);
            this.ThreeShipRadioButton.Name = "ThreeShipRadioButton";
            this.ThreeShipRadioButton.Size = new System.Drawing.Size(71, 17);
            this.ThreeShipRadioButton.TabIndex = 2;
            this.ThreeShipRadioButton.TabStop = true;
            this.ThreeShipRadioButton.Text = "3 палубы";
            this.ThreeShipRadioButton.UseVisualStyleBackColor = true;
            // 
            // TwoShipRadioButton
            // 
            this.TwoShipRadioButton.AutoSize = true;
            this.TwoShipRadioButton.Location = new System.Drawing.Point(7, 44);
            this.TwoShipRadioButton.Name = "TwoShipRadioButton";
            this.TwoShipRadioButton.Size = new System.Drawing.Size(71, 17);
            this.TwoShipRadioButton.TabIndex = 1;
            this.TwoShipRadioButton.TabStop = true;
            this.TwoShipRadioButton.Text = "2 палубы";
            this.TwoShipRadioButton.UseVisualStyleBackColor = true;
            // 
            // OneShipRadioButton
            // 
            this.OneShipRadioButton.AutoSize = true;
            this.OneShipRadioButton.Location = new System.Drawing.Point(7, 20);
            this.OneShipRadioButton.Name = "OneShipRadioButton";
            this.OneShipRadioButton.Size = new System.Drawing.Size(69, 17);
            this.OneShipRadioButton.TabIndex = 0;
            this.OneShipRadioButton.TabStop = true;
            this.OneShipRadioButton.Text = "1 палуба";
            this.OneShipRadioButton.UseVisualStyleBackColor = true;
            // 
            // SeaEnemyGroupBox
            // 
            this.SeaEnemyGroupBox.Controls.Add(this.label4);
            this.SeaEnemyGroupBox.Controls.Add(this.label3);
            this.SeaEnemyGroupBox.Controls.Add(this.label2);
            this.SeaEnemyGroupBox.Controls.Add(this.label1);
            this.SeaEnemyGroupBox.Controls.Add(this.textBox8);
            this.SeaEnemyGroupBox.Controls.Add(this.textBox7);
            this.SeaEnemyGroupBox.Controls.Add(this.textBox6);
            this.SeaEnemyGroupBox.Controls.Add(this.textBox5);
            this.SeaEnemyGroupBox.Location = new System.Drawing.Point(260, 290);
            this.SeaEnemyGroupBox.Name = "SeaEnemyGroupBox";
            this.SeaEnemyGroupBox.Size = new System.Drawing.Size(230, 139);
            this.SeaEnemyGroupBox.TabIndex = 4;
            this.SeaEnemyGroupBox.TabStop = false;
            this.SeaEnemyGroupBox.Text = "Вражеский флот";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "4 палубы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "3 палубы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2 палубы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1 палуба";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(111, 91);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(111, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(111, 42);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 451);
            this.Controls.Add(this.SeaEnemyGroupBox);
            this.Controls.Add(this.SeaOwnGroupBox);
            this.Controls.Add(this.SeaEnemyPanel);
            this.Controls.Add(this.SeaOwnPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeaBattleShips";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SeaOwnGroupBox.ResumeLayout(false);
            this.SeaOwnGroupBox.PerformLayout();
            this.SeaEnemyGroupBox.ResumeLayout(false);
            this.SeaEnemyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prepareFleetToolStripMenuItem;
        private System.Windows.Forms.Panel SeaOwnPanel;
        private System.Windows.Forms.Panel SeaEnemyPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox SeaOwnGroupBox;
        private System.Windows.Forms.RadioButton FourShipRadioButton;
        private System.Windows.Forms.RadioButton ThreeShipRadioButton;
        private System.Windows.Forms.RadioButton TwoShipRadioButton;
        private System.Windows.Forms.RadioButton OneShipRadioButton;
        private System.Windows.Forms.GroupBox SeaEnemyGroupBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
    }
}


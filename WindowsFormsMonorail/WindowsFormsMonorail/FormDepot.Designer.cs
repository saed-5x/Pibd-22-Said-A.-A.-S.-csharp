namespace lab_1
{
    partial class FormDepot
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
            this.PicBoxStation = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.Take = new System.Windows.Forms.Button();
            this.MaskTexBoxTrainStation = new System.Windows.Forms.TextBox();
            this.buttonAddStation = new System.Windows.Forms.Button();
            this.ListBoxStation = new System.Windows.Forms.ListBox();
            this.TextBoxStationName = new System.Windows.Forms.TextBox();
            this.buttonDelStation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetMonorail = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxStation)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBoxStation
            // 
            this.PicBoxStation.Location = new System.Drawing.Point(4, 27);
            this.PicBoxStation.Name = "PicBoxStation";
            this.PicBoxStation.Size = new System.Drawing.Size(1339, 1002);
            this.PicBoxStation.TabIndex = 0;
            this.PicBoxStation.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Место";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.Take);
            this.groupBox1.Controls.Add(this.MaskTexBoxTrainStation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1349, 711);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 318);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Take Train";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(6, 136);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(531, 160);
            this.pictureBoxTake.TabIndex = 8;
            this.pictureBoxTake.TabStop = false;
            // 
            // Take
            // 
            this.Take.Location = new System.Drawing.Point(48, 54);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(232, 45);
            this.Take.TabIndex = 7;
            this.Take.Text = "Take";
            this.Take.UseVisualStyleBackColor = true;
            this.Take.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // MaskTexBoxTrainStation
            // 
            this.MaskTexBoxTrainStation.Location = new System.Drawing.Point(330, 59);
            this.MaskTexBoxTrainStation.Multiline = true;
            this.MaskTexBoxTrainStation.Name = "MaskTexBoxTrainStation";
            this.MaskTexBoxTrainStation.Size = new System.Drawing.Size(43, 40);
            this.MaskTexBoxTrainStation.TabIndex = 6;
            // 
            // buttonAddStation
            // 
            this.buttonAddStation.Location = new System.Drawing.Point(1349, 158);
            this.buttonAddStation.Name = "buttonAddStation";
            this.buttonAddStation.Size = new System.Drawing.Size(545, 62);
            this.buttonAddStation.TabIndex = 7;
            this.buttonAddStation.Text = "AddStation";
            this.buttonAddStation.UseVisualStyleBackColor = true;
            this.buttonAddStation.Click += new System.EventHandler(this.buttonAddStation_Click);
            // 
            // ListBoxStation
            // 
            this.ListBoxStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxStation.FormattingEnabled = true;
            this.ListBoxStation.ItemHeight = 25;
            this.ListBoxStation.Location = new System.Drawing.Point(1349, 249);
            this.ListBoxStation.Name = "ListBoxStation";
            this.ListBoxStation.Size = new System.Drawing.Size(541, 179);
            this.ListBoxStation.TabIndex = 8;
            this.ListBoxStation.SelectedIndexChanged += new System.EventHandler(this.ListBoxStation_SelectedIndexChanged);
            // 
            // TextBoxStationName
            // 
            this.TextBoxStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxStationName.Location = new System.Drawing.Point(1350, 74);
            this.TextBoxStationName.Multiline = true;
            this.TextBoxStationName.Name = "TextBoxStationName";
            this.TextBoxStationName.Size = new System.Drawing.Size(544, 61);
            this.TextBoxStationName.TabIndex = 9;
            // 
            // buttonDelStation
            // 
            this.buttonDelStation.Location = new System.Drawing.Point(1349, 476);
            this.buttonDelStation.Name = "buttonDelStation";
            this.buttonDelStation.Size = new System.Drawing.Size(543, 64);
            this.buttonDelStation.TabIndex = 10;
            this.buttonDelStation.Text = "Delete Station";
            this.buttonDelStation.UseVisualStyleBackColor = true;
            this.buttonDelStation.Click += new System.EventHandler(this.buttonDelStation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1594, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Station Name";
            // 
            // buttonSetMonorail
            // 
            this.buttonSetMonorail.Location = new System.Drawing.Point(1349, 634);
            this.buttonSetMonorail.Name = "buttonSetMonorail";
            this.buttonSetMonorail.Size = new System.Drawing.Size(543, 70);
            this.buttonSetMonorail.TabIndex = 12;
            this.buttonSetMonorail.Text = "Add Train";
            this.buttonSetMonorail.UseVisualStyleBackColor = true;
            this.buttonSetMonorail.Click += new System.EventHandler(this.buttonSetTrain_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1904, 24);
            this.MenuStrip.TabIndex = 13;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(1350, 547);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(542, 69);
            this.buttonSort.TabIndex = 14;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSetMonorail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelStation);
            this.Controls.Add(this.TextBoxStationName);
            this.Controls.Add(this.ListBoxStation);
            this.Controls.Add(this.buttonAddStation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicBoxStation);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FormDepot";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxStation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MaskTexBoxTrainStation;
        private System.Windows.Forms.Button Take;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonAddStation;
        private System.Windows.Forms.ListBox ListBoxStation;
        private System.Windows.Forms.TextBox TextBoxStationName;
        private System.Windows.Forms.Button buttonDelStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetMonorail;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSort;
    }
}
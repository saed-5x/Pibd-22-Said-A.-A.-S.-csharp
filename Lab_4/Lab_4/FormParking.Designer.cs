namespace lab_1
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.ParkingLocomotive = new System.Windows.Forms.Button();
            this.ParkingMonorail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxParking = new System.Windows.Forms.TextBox();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddParkin_Click = new System.Windows.Forms.Button();
            this.buttonDelParkin_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(4, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1339, 1027);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // ParkingLocomotive
            // 
            this.ParkingLocomotive.Location = new System.Drawing.Point(1349, 498);
            this.ParkingLocomotive.Name = "ParkingLocomotive";
            this.ParkingLocomotive.Size = new System.Drawing.Size(543, 56);
            this.ParkingLocomotive.TabIndex = 1;
            this.ParkingLocomotive.Text = "ParkingLocomotive";
            this.ParkingLocomotive.UseVisualStyleBackColor = true;
            this.ParkingLocomotive.Click += new System.EventHandler(this.ParkingLocomotive_Click);
            // 
            // ParkingMonorail
            // 
            this.ParkingMonorail.Location = new System.Drawing.Point(1349, 570);
            this.ParkingMonorail.Name = "ParkingMonorail";
            this.ParkingMonorail.Size = new System.Drawing.Size(544, 63);
            this.ParkingMonorail.TabIndex = 2;
            this.ParkingMonorail.Text = "ParkingMonorail";
            this.ParkingMonorail.UseVisualStyleBackColor = true;
            this.ParkingMonorail.Click += new System.EventHandler(this.ParkingMonorail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Место";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBoxParking);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1349, 649);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 367);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Забрать машину";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(6, 186);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(531, 128);
            this.pictureBoxTake.TabIndex = 8;
            this.pictureBoxTake.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Забрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxParking
            // 
            this.maskedTextBoxParking.Location = new System.Drawing.Point(330, 81);
            this.maskedTextBoxParking.Multiline = true;
            this.maskedTextBoxParking.Name = "maskedTextBoxParking";
            this.maskedTextBoxParking.Size = new System.Drawing.Size(43, 40);
            this.maskedTextBoxParking.TabIndex = 6;
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(1349, 193);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(544, 199);
            this.listBoxParkings.TabIndex = 7;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged_1);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(1350, 25);
            this.textBoxNewLevelName.Multiline = true;
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(537, 64);
            this.textBoxNewLevelName.TabIndex = 9;
            this.textBoxNewLevelName.TextChanged += new System.EventHandler(this.textBoxNewLevelName_TextChanged);
            // 
            // buttonAddParkin_Click
            // 
            this.buttonAddParkin_Click.Location = new System.Drawing.Point(1350, 103);
            this.buttonAddParkin_Click.Name = "buttonAddParkin_Click";
            this.buttonAddParkin_Click.Size = new System.Drawing.Size(539, 73);
            this.buttonAddParkin_Click.TabIndex = 10;
            this.buttonAddParkin_Click.Text = "button2";
            this.buttonAddParkin_Click.UseVisualStyleBackColor = true;
            this.buttonAddParkin_Click.Click += new System.EventHandler(this.buttonAddParkin_Click_Click);
            // 
            // buttonDelParkin_Click
            // 
            this.buttonDelParkin_Click.Location = new System.Drawing.Point(1350, 408);
            this.buttonDelParkin_Click.Name = "buttonDelParkin_Click";
            this.buttonDelParkin_Click.Size = new System.Drawing.Size(538, 78);
            this.buttonDelParkin_Click.TabIndex = 11;
            this.buttonDelParkin_Click.Text = "button3";
            this.buttonDelParkin_Click.UseVisualStyleBackColor = true;
            this.buttonDelParkin_Click.Click += new System.EventHandler(this.buttonDelParkin_Click_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonDelParkin_Click);
            this.Controls.Add(this.buttonAddParkin_Click);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ParkingMonorail);
            this.Controls.Add(this.ParkingLocomotive);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button ParkingLocomotive;
        private System.Windows.Forms.Button ParkingMonorail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maskedTextBoxParking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.ListBox listBoxParkings;
      
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddParkin_Click;
        private System.Windows.Forms.Button buttonDelParkin_Click;
    }
}
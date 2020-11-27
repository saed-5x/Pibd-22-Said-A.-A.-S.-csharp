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
            this.pictureBoxParking.Click += new System.EventHandler(this.pictureBoxParking_Click);
            // 
            // ParkingLocomotive
            // 
            this.ParkingLocomotive.Location = new System.Drawing.Point(1349, 12);
            this.ParkingLocomotive.Name = "ParkingLocomotive";
            this.ParkingLocomotive.Size = new System.Drawing.Size(543, 56);
            this.ParkingLocomotive.TabIndex = 1;
            this.ParkingLocomotive.Text = "ParkingLocomotive";
            this.ParkingLocomotive.UseVisualStyleBackColor = true;
            this.ParkingLocomotive.Click += new System.EventHandler(this.ParkingLocomotive_Click);
            // 
            // ParkingMonorail
            // 
            this.ParkingMonorail.Location = new System.Drawing.Point(1349, 84);
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBoxParking);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1349, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 282);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Забрать машину";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(6, 136);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(531, 128);
            this.pictureBoxTake.TabIndex = 8;
            this.pictureBoxTake.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Забрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxParking
            // 
            this.maskedTextBoxParking.Location = new System.Drawing.Point(330, 59);
            this.maskedTextBoxParking.Multiline = true;
            this.maskedTextBoxParking.Name = "maskedTextBoxParking";
            this.maskedTextBoxParking.Size = new System.Drawing.Size(43, 40);
            this.maskedTextBoxParking.TabIndex = 6;
            this.maskedTextBoxParking.TextChanged += new System.EventHandler(this.maskedTextBoxParking_TextChanged);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
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
    }
}
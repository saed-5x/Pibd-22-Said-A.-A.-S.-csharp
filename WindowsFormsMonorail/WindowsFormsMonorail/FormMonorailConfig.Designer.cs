namespace lab_1
{
    partial class FormMonorailConfig
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Sub_Color = new System.Windows.Forms.Label();
            this.label_Main_Color = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Locomotive = new System.Windows.Forms.Label();
            this.label_Monorail = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Max_speed = new System.Windows.Forms.Label();
            this.checkBoxRailway = new System.Windows.Forms.CheckBox();
            this.checkBoxDoors = new System.Windows.Forms.CheckBox();
            this.checkBoxWindows = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.button_Add_Train = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.PicBoxMonorail = new System.Windows.Forms.PictureBox();
            this.panelMonorail = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMonorail)).BeginInit();
            this.panelMonorail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Sub_Color);
            this.groupBox1.Controls.Add(this.label_Main_Color);
            this.groupBox1.Controls.Add(this.panelGreen);
            this.groupBox1.Controls.Add(this.panelWhite);
            this.groupBox1.Controls.Add(this.panelBlue);
            this.groupBox1.Controls.Add(this.panelBlack);
            this.groupBox1.Controls.Add(this.panelOrange);
            this.groupBox1.Controls.Add(this.panelGray);
            this.groupBox1.Controls.Add(this.panelYellow);
            this.groupBox1.Controls.Add(this.panelRed);
            this.groupBox1.Location = new System.Drawing.Point(978, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // label_Sub_Color
            // 
            this.label_Sub_Color.AllowDrop = true;
            this.label_Sub_Color.AutoSize = true;
            this.label_Sub_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Sub_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sub_Color.Location = new System.Drawing.Point(203, 57);
            this.label_Sub_Color.Name = "label_Sub_Color";
            this.label_Sub_Color.Size = new System.Drawing.Size(81, 22);
            this.label_Sub_Color.TabIndex = 2;
            this.label_Sub_Color.Text = "Sub Color";
            this.label_Sub_Color.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label_Sub_Color.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            this.label_Sub_Color.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // label_Main_Color
            // 
            this.label_Main_Color.AllowDrop = true;
            this.label_Main_Color.AutoSize = true;
            this.label_Main_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Main_Color.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.label_Main_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Main_Color.Location = new System.Drawing.Point(51, 57);
            this.label_Main_Color.Name = "label_Main_Color";
            this.label_Main_Color.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Main_Color.Size = new System.Drawing.Size(86, 22);
            this.label_Main_Color.TabIndex = 1;
            this.label_Main_Color.Text = "Main Color";
            this.label_Main_Color.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.label_Main_Color.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(253, 169);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(50, 50);
            this.panelGreen.TabIndex = 0;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(253, 103);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(50, 50);
            this.panelWhite.TabIndex = 0;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(176, 169);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(50, 50);
            this.panelBlue.TabIndex = 0;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(176, 103);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(50, 50);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(99, 169);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(50, 50);
            this.panelOrange.TabIndex = 0;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(26, 169);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(50, 50);
            this.panelGray.TabIndex = 0;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(99, 103);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(50, 50);
            this.panelYellow.TabIndex = 0;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(26, 103);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(50, 50);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Locomotive);
            this.groupBox3.Controls.Add(this.label_Monorail);
            this.groupBox3.Location = new System.Drawing.Point(12, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 242);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type train";
            // 
            // label_Locomotive
            // 
            this.label_Locomotive.AutoSize = true;
            this.label_Locomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Locomotive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Locomotive.Location = new System.Drawing.Point(33, 139);
            this.label_Locomotive.Name = "label_Locomotive";
            this.label_Locomotive.Size = new System.Drawing.Size(92, 22);
            this.label_Locomotive.TabIndex = 1;
            this.label_Locomotive.Text = "Locomotive";
            this.label_Locomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLocomotive_MouseDown);
            // 
            // label_Monorail
            // 
            this.label_Monorail.AutoSize = true;
            this.label_Monorail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Monorail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Monorail.Location = new System.Drawing.Point(30, 57);
            this.label_Monorail.Name = "label_Monorail";
            this.label_Monorail.Size = new System.Drawing.Size(71, 22);
            this.label_Monorail.TabIndex = 0;
            this.label_Monorail.Text = "Monorail";
            this.label_Monorail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMonorail_MouseDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Max_speed);
            this.groupBox4.Controls.Add(this.checkBoxRailway);
            this.groupBox4.Controls.Add(this.checkBoxDoors);
            this.groupBox4.Controls.Add(this.checkBoxWindows);
            this.groupBox4.Controls.Add(this.numericUpDownWeight);
            this.groupBox4.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBox4.Location = new System.Drawing.Point(12, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(941, 75);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(228, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "All train";
            // 
            // Max_speed
            // 
            this.Max_speed.AutoSize = true;
            this.Max_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Max_speed.Location = new System.Drawing.Point(28, 38);
            this.Max_speed.Name = "Max_speed";
            this.Max_speed.Size = new System.Drawing.Size(76, 17);
            this.Max_speed.TabIndex = 6;
            this.Max_speed.Text = "Max speed";
            // 
            // checkBoxRailway
            // 
            this.checkBoxRailway.AutoSize = true;
            this.checkBoxRailway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRailway.Location = new System.Drawing.Point(701, 34);
            this.checkBoxRailway.Name = "checkBoxRailway";
            this.checkBoxRailway.Size = new System.Drawing.Size(82, 24);
            this.checkBoxRailway.TabIndex = 4;
            this.checkBoxRailway.Text = "Railway";
            this.checkBoxRailway.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoors
            // 
            this.checkBoxDoors.AutoSize = true;
            this.checkBoxDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDoors.Location = new System.Drawing.Point(628, 34);
            this.checkBoxDoors.Name = "checkBoxDoors";
            this.checkBoxDoors.Size = new System.Drawing.Size(71, 24);
            this.checkBoxDoors.TabIndex = 3;
            this.checkBoxDoors.Text = "Doors";
            this.checkBoxDoors.UseVisualStyleBackColor = true;
            // 
            // checkBoxWindows
            // 
            this.checkBoxWindows.AutoSize = true;
            this.checkBoxWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWindows.Location = new System.Drawing.Point(529, 34);
            this.checkBoxWindows.Name = "checkBoxWindows";
            this.checkBoxWindows.Size = new System.Drawing.Size(92, 24);
            this.checkBoxWindows.TabIndex = 2;
            this.checkBoxWindows.Text = "Windows";
            this.checkBoxWindows.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(296, 34);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownWeight.TabIndex = 1;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(124, 34);
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(88, 23);
            this.numericUpDownMaxSpeed.TabIndex = 0;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button_Add_Train
            // 
            this.button_Add_Train.Location = new System.Drawing.Point(970, 319);
            this.button_Add_Train.Name = "button_Add_Train";
            this.button_Add_Train.Size = new System.Drawing.Size(184, 54);
            this.button_Add_Train.TabIndex = 4;
            this.button_Add_Train.Text = "Add";
            this.button_Add_Train.UseVisualStyleBackColor = true;
            this.button_Add_Train.Click += new System.EventHandler(this.button_Add_Train_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1166, 319);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(182, 55);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // PicBoxMonorail
            // 
            this.PicBoxMonorail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBoxMonorail.Location = new System.Drawing.Point(31, 48);
            this.PicBoxMonorail.Name = "PicBoxMonorail";
            this.PicBoxMonorail.Size = new System.Drawing.Size(631, 148);
            this.PicBoxMonorail.TabIndex = 0;
            this.PicBoxMonorail.TabStop = false;
            // 
            // panelMonorail
            // 
            this.panelMonorail.AllowDrop = true;
            this.panelMonorail.Controls.Add(this.PicBoxMonorail);
            this.panelMonorail.Location = new System.Drawing.Point(259, 60);
            this.panelMonorail.Name = "panelMonorail";
            this.panelMonorail.Size = new System.Drawing.Size(694, 233);
            this.panelMonorail.TabIndex = 6;
            this.panelMonorail.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelMonorail_DragDrop);
            this.panelMonorail.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelMonorail_DragEnter);
            // 
            // FormMonorailConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 392);
            this.Controls.Add(this.button_Add_Train);
            this.Controls.Add(this.panelMonorail);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMonorailConfig";
            this.Text = "FormMonorailConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMonorail)).EndInit();
            this.panelMonorail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Sub_Color;
        private System.Windows.Forms.Label label_Main_Color;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_Locomotive;
        private System.Windows.Forms.Label label_Monorail;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Max_speed;
        private System.Windows.Forms.CheckBox checkBoxRailway;
        private System.Windows.Forms.CheckBox checkBoxDoors;
        private System.Windows.Forms.CheckBox checkBoxWindows;
        private System.Windows.Forms.Button button_Add_Train;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox PicBoxMonorail;
        private System.Windows.Forms.Panel panelMonorail;
    }
}
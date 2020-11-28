namespace lab_1
{
    partial class FormMonorail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonorail));
            this.button_Create_Monorail = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Create_Monorail
            // 
            this.button_Create_Monorail.Location = new System.Drawing.Point(36, 21);
            this.button_Create_Monorail.Name = "button_Create_Monorail";
            this.button_Create_Monorail.Size = new System.Drawing.Size(195, 43);
            this.button_Create_Monorail.TabIndex = 0;
            this.button_Create_Monorail.Text = "Monorail";
            this.button_Create_Monorail.UseVisualStyleBackColor = true;
            this.button_Create_Monorail.Click += new System.EventHandler(this.buttonCreateMonorail_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRight.FlatAppearance.BorderSize = 0;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(1696, 882);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(64, 64);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Location = new System.Drawing.Point(1626, 882);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(64, 64);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLeft.FlatAppearance.BorderSize = 0;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(1556, 882);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(64, 64);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Location = new System.Drawing.Point(1626, 812);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(64, 64);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(1, 0);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(1920, 1080);
            this.PicBox.TabIndex = 1;
            this.PicBox.TabStop = false;
            // 
            // FormMonorail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.button_Create_Monorail);
            this.Controls.Add(this.PicBox);
            this.Name = "FormMonorail";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button button_Create_Monorail;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
       
    }
}


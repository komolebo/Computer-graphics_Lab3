namespace CG_lab3
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
            this.label1 = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.BtnFill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnAlgourithm3 = new System.Windows.Forms.RadioButton();
            this.BtnClear = new System.Windows.Forms.Button();
            this.btnAlgourithm2 = new System.Windows.Forms.RadioButton();
            this.btnAlgourithm1 = new System.Windows.Forms.RadioButton();
            this.TimeTakenLbl = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowNoDelaysBtn = new System.Windows.Forms.RadioButton();
            this.ShowDelayBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(506, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area for filling";
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Black;
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(2, 70);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(1094, 546);
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            this.pBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMoving);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.BackColor = System.Drawing.Color.Transparent;
            this.testLabel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.testLabel.Location = new System.Drawing.Point(3, 710);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(51, 15);
            this.testLabel.TabIndex = 2;
            this.testLabel.Text = "Nothing";
            this.testLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnFill
            // 
            this.BtnFill.BackColor = System.Drawing.Color.Transparent;
            this.BtnFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFill.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFill.Location = new System.Drawing.Point(215, 3);
            this.BtnFill.Name = "BtnFill";
            this.BtnFill.Size = new System.Drawing.Size(101, 23);
            this.BtnFill.TabIndex = 3;
            this.BtnFill.Text = "Fill";
            this.BtnFill.UseVisualStyleBackColor = false;
            this.BtnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.btnAlgourithm3);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnFill);
            this.panel1.Controls.Add(this.btnAlgourithm2);
            this.panel1.Controls.Add(this.btnAlgourithm1);
            this.panel1.Location = new System.Drawing.Point(389, 627);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 95);
            this.panel1.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSave.Location = new System.Drawing.Point(109, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnAlgourithm3
            // 
            this.btnAlgourithm3.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAlgourithm3.AutoSize = true;
            this.btnAlgourithm3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAlgourithm3.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAlgourithm3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAlgourithm3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAlgourithm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlgourithm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAlgourithm3.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlgourithm3.Location = new System.Drawing.Point(215, 62);
            this.btnAlgourithm3.Name = "btnAlgourithm3";
            this.btnAlgourithm3.Size = new System.Drawing.Size(100, 28);
            this.btnAlgourithm3.TabIndex = 7;
            this.btnAlgourithm3.TabStop = true;
            this.btnAlgourithm3.Text = "Algourithm #3";
            this.btnAlgourithm3.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnClear.Location = new System.Drawing.Point(3, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(100, 23);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnAlgourithm2
            // 
            this.btnAlgourithm2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAlgourithm2.AutoSize = true;
            this.btnAlgourithm2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAlgourithm2.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAlgourithm2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAlgourithm2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAlgourithm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlgourithm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAlgourithm2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlgourithm2.Location = new System.Drawing.Point(109, 62);
            this.btnAlgourithm2.Name = "btnAlgourithm2";
            this.btnAlgourithm2.Size = new System.Drawing.Size(100, 28);
            this.btnAlgourithm2.TabIndex = 6;
            this.btnAlgourithm2.TabStop = true;
            this.btnAlgourithm2.Text = "Algourithm #2";
            this.btnAlgourithm2.UseVisualStyleBackColor = true;
            // 
            // btnAlgourithm1
            // 
            this.btnAlgourithm1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAlgourithm1.AutoSize = true;
            this.btnAlgourithm1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAlgourithm1.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAlgourithm1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAlgourithm1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAlgourithm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlgourithm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAlgourithm1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlgourithm1.Location = new System.Drawing.Point(3, 62);
            this.btnAlgourithm1.Name = "btnAlgourithm1";
            this.btnAlgourithm1.Size = new System.Drawing.Size(100, 28);
            this.btnAlgourithm1.TabIndex = 5;
            this.btnAlgourithm1.TabStop = true;
            this.btnAlgourithm1.Text = "Algourithm #1";
            this.btnAlgourithm1.UseVisualStyleBackColor = true;
            // 
            // TimeTakenLbl
            // 
            this.TimeTakenLbl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TimeTakenLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeTakenLbl.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.TimeTakenLbl.Location = new System.Drawing.Point(954, 620);
            this.TimeTakenLbl.Name = "TimeTakenLbl";
            this.TimeTakenLbl.Size = new System.Drawing.Size(131, 20);
            this.TimeTakenLbl.TabIndex = 5;
            this.TimeTakenLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TimeTakenLbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.testLabel);
            this.panel2.Controls.Add(this.ShowNoDelaysBtn);
            this.panel2.Controls.Add(this.ShowDelayBtn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 731);
            this.panel2.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(1062, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(876, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time taken:";
            // 
            // ShowNoDelaysBtn
            // 
            this.ShowNoDelaysBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowNoDelaysBtn.AutoSize = true;
            this.ShowNoDelaysBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ShowNoDelaysBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.ShowNoDelaysBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ShowNoDelaysBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ShowNoDelaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowNoDelaysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ShowNoDelaysBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShowNoDelaysBtn.Location = new System.Drawing.Point(90, 622);
            this.ShowNoDelaysBtn.Name = "ShowNoDelaysBtn";
            this.ShowNoDelaysBtn.Size = new System.Drawing.Size(96, 28);
            this.ShowNoDelaysBtn.TabIndex = 6;
            this.ShowNoDelaysBtn.TabStop = true;
            this.ShowNoDelaysBtn.Text = "Simple show";
            this.ShowNoDelaysBtn.UseVisualStyleBackColor = true;
            // 
            // ShowDelayBtn
            // 
            this.ShowDelayBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowDelayBtn.AutoSize = true;
            this.ShowDelayBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ShowDelayBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.MidnightBlue;
            this.ShowDelayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ShowDelayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ShowDelayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDelayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ShowDelayBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShowDelayBtn.Location = new System.Drawing.Point(1, 622);
            this.ShowDelayBtn.Name = "ShowDelayBtn";
            this.ShowDelayBtn.Size = new System.Drawing.Size(90, 28);
            this.ShowDelayBtn.TabIndex = 5;
            this.ShowDelayBtn.TabStop = true;
            this.ShowDelayBtn.Text = "Delay show";
            this.ShowDelayBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 736);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button BtnFill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnAlgourithm2;
        private System.Windows.Forms.RadioButton btnAlgourithm1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.RadioButton btnAlgourithm3;
        private System.Windows.Forms.TextBox TimeTakenLbl;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton ShowNoDelaysBtn;
        private System.Windows.Forms.RadioButton ShowDelayBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
    }
}


namespace Image_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.greenvalue = new System.Windows.Forms.Label();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1113, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Красный";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // redbar
            // 
            this.redbar.Location = new System.Drawing.Point(71, 644);
            this.redbar.Name = "redbar";
            this.redbar.Size = new System.Drawing.Size(868, 45);
            this.redbar.TabIndex = 9;
            this.redbar.ValueChanged += new System.EventHandler(this.redbar_ValueChanged);
            // 
            // greenbar
            // 
            this.greenbar.Location = new System.Drawing.Point(71, 695);
            this.greenbar.Name = "greenbar";
            this.greenbar.Size = new System.Drawing.Size(868, 45);
            this.greenbar.TabIndex = 11;
            this.greenbar.ValueChanged += new System.EventHandler(this.greenbar_ValueChanged);
            // 
            // greenvalue
            // 
            this.greenvalue.AutoSize = true;
            this.greenvalue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greenvalue.Location = new System.Drawing.Point(3, 695);
            this.greenvalue.Name = "greenvalue";
            this.greenvalue.Size = new System.Drawing.Size(72, 21);
            this.greenvalue.TabIndex = 10;
            this.greenvalue.Text = "Зелёный";
            this.greenvalue.Click += new System.EventHandler(this.label2_Click);
            // 
            // bluebar
            // 
            this.bluebar.Location = new System.Drawing.Point(71, 746);
            this.bluebar.Name = "bluebar";
            this.bluebar.Size = new System.Drawing.Size(868, 45);
            this.bluebar.TabIndex = 13;
            this.bluebar.ValueChanged += new System.EventHandler(this.bluebar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 746);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Голубой";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(940, 644);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(176, 45);
            this.button8.TabIndex = 14;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(940, 695);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(176, 45);
            this.button9.TabIndex = 15;
            this.button9.Text = "Открыть";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Отменить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 795);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.greenvalue);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TrackBar redbar;
        private TrackBar greenbar;
        private Label greenvalue;
        private TrackBar bluebar;
        private Label label3;
        private Button button8;
        private Button button9;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
    }
}
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.CaptureThisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CaptureDesktopButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBoxButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureThisButton
            // 
            this.CaptureThisButton.Location = new System.Drawing.Point(25, 39);
            this.CaptureThisButton.Name = "CaptureThisButton";
            this.CaptureThisButton.Size = new System.Drawing.Size(169, 23);
            this.CaptureThisButton.TabIndex = 0;
            this.CaptureThisButton.Text = "Capture this button";
            this.CaptureThisButton.UseVisualStyleBackColor = true;
            this.CaptureThisButton.Click += new System.EventHandler(this.CaptureThisButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.CaptureThisButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIngle control capture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(212, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // CaptureDesktopButton
            // 
            this.CaptureDesktopButton.Location = new System.Drawing.Point(37, 110);
            this.CaptureDesktopButton.Name = "CaptureDesktopButton";
            this.CaptureDesktopButton.Size = new System.Drawing.Size(169, 23);
            this.CaptureDesktopButton.TabIndex = 2;
            this.CaptureDesktopButton.Text = "Capture current desktop";
            this.CaptureDesktopButton.UseVisualStyleBackColor = true;
            this.CaptureDesktopButton.Click += new System.EventHandler(this.CaptureDesktopButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // PictureBoxButton
            // 
            this.PictureBoxButton.Location = new System.Drawing.Point(37, 277);
            this.PictureBoxButton.Name = "PictureBoxButton";
            this.PictureBoxButton.Size = new System.Drawing.Size(158, 23);
            this.PictureBoxButton.TabIndex = 5;
            this.PictureBoxButton.Text = "PictureBox";
            this.PictureBoxButton.UseVisualStyleBackColor = true;
            this.PictureBoxButton.Click += new System.EventHandler(this.PictureBoxButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(37, 306);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(158, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 341);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PictureBoxButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CaptureDesktopButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen capture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CaptureThisButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CaptureDesktopButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button PictureBoxButton;
        private System.Windows.Forms.Button ClearButton;
    }
}


namespace att.CapaPresentacion
{
    partial class CaptureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.StatusLine = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Prompt = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureHuella = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLine
            // 
            this.StatusLine.AutoSize = true;
            this.StatusLine.Location = new System.Drawing.Point(99, 418);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(46, 13);
            this.StatusLine.TabIndex = 12;
            this.StatusLine.Text = "Status : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estado : ";
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Location = new System.Drawing.Point(405, 13);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(63, 13);
            this.Prompt.TabIndex = 10;
            this.Prompt.Text = "Condicion : ";
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(405, 94);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(296, 306);
            this.StatusText.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 20);
            this.textBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureHuella
            // 
            this.pictureHuella.BackColor = System.Drawing.SystemColors.Window;
            this.pictureHuella.Location = new System.Drawing.Point(102, 12);
            this.pictureHuella.Name = "pictureHuella";
            this.pictureHuella.Size = new System.Drawing.Size(279, 388);
            this.pictureHuella.TabIndex = 7;
            this.pictureHuella.TabStop = false;
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureHuella);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureForm";
            this.Text = "CaptureForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureForm_FormClosed_1);
            this.Load += new System.EventHandler(this.CaptureForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureHuella;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
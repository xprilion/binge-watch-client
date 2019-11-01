namespace WindowsFormsApp3
{
    partial class ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.movieList = new System.Windows.Forms.FlowLayoutPanel();
            this.moviePanel = new System.Windows.Forms.Panel();
            this.watchBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.movieName = new System.Windows.Forms.Label();
            this.moviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieList
            // 
            this.movieList.AutoScroll = true;
            this.movieList.Location = new System.Drawing.Point(10, 278);
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(700, 160);
            this.movieList.TabIndex = 3;
            // 
            // moviePanel
            // 
            this.moviePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.moviePanel.Controls.Add(this.watchBtn);
            this.moviePanel.Controls.Add(this.pictureBox1);
            this.moviePanel.Controls.Add(this.movieName);
            this.moviePanel.Location = new System.Drawing.Point(10, 12);
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Size = new System.Drawing.Size(700, 260);
            this.moviePanel.TabIndex = 2;
            // 
            // watchBtn
            // 
            this.watchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchBtn.Location = new System.Drawing.Point(432, 206);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(257, 41);
            this.watchBtn.TabIndex = 3;
            this.watchBtn.Text = "Watch Now";
            this.watchBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieName.Location = new System.Drawing.Point(427, 15);
            this.movieName.MaximumSize = new System.Drawing.Size(265, 0);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(197, 74);
            this.movieName.TabIndex = 1;
            this.movieName.Text = "A Very Cool Movie Name";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.movieList);
            this.Controls.Add(this.moviePanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Movie";
            this.moviePanel.ResumeLayout(false);
            this.moviePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel movieList;
        private System.Windows.Forms.Panel moviePanel;
        private System.Windows.Forms.Button watchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label movieName;
    }
}
namespace WindowsFormsApp3
{
    partial class ListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RomanceMoviesBtn = new System.Windows.Forms.Button();
            this.ComedyMoviesBtn = new System.Windows.Forms.Button();
            this.HorrorMoviesBtn = new System.Windows.Forms.Button();
            this.ActionMoviesBtn = new System.Windows.Forms.Button();
            this.movieList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.RomanceMoviesBtn);
            this.panel1.Controls.Add(this.ComedyMoviesBtn);
            this.panel1.Controls.Add(this.HorrorMoviesBtn);
            this.panel1.Controls.Add(this.ActionMoviesBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 67);
            this.panel1.TabIndex = 0;
            // 
            // RomanceMoviesBtn
            // 
            this.RomanceMoviesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomanceMoviesBtn.Location = new System.Drawing.Point(587, 14);
            this.RomanceMoviesBtn.Name = "RomanceMoviesBtn";
            this.RomanceMoviesBtn.Size = new System.Drawing.Size(101, 39);
            this.RomanceMoviesBtn.TabIndex = 3;
            this.RomanceMoviesBtn.Text = "Romance";
            this.RomanceMoviesBtn.UseVisualStyleBackColor = true;
            // 
            // ComedyMoviesBtn
            // 
            this.ComedyMoviesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComedyMoviesBtn.Location = new System.Drawing.Point(480, 14);
            this.ComedyMoviesBtn.Name = "ComedyMoviesBtn";
            this.ComedyMoviesBtn.Size = new System.Drawing.Size(101, 39);
            this.ComedyMoviesBtn.TabIndex = 2;
            this.ComedyMoviesBtn.Text = "Comedy";
            this.ComedyMoviesBtn.UseVisualStyleBackColor = true;
            // 
            // HorrorMoviesBtn
            // 
            this.HorrorMoviesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorrorMoviesBtn.Location = new System.Drawing.Point(373, 14);
            this.HorrorMoviesBtn.Name = "HorrorMoviesBtn";
            this.HorrorMoviesBtn.Size = new System.Drawing.Size(101, 39);
            this.HorrorMoviesBtn.TabIndex = 1;
            this.HorrorMoviesBtn.Text = "Horror";
            this.HorrorMoviesBtn.UseVisualStyleBackColor = true;
            // 
            // ActionMoviesBtn
            // 
            this.ActionMoviesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionMoviesBtn.Location = new System.Drawing.Point(266, 14);
            this.ActionMoviesBtn.Name = "ActionMoviesBtn";
            this.ActionMoviesBtn.Size = new System.Drawing.Size(101, 39);
            this.ActionMoviesBtn.TabIndex = 0;
            this.ActionMoviesBtn.Text = "Action";
            this.ActionMoviesBtn.UseVisualStyleBackColor = true;
            // 
            // movieList
            // 
            this.movieList.AutoScroll = true;
            this.movieList.Location = new System.Drawing.Point(12, 85);
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(700, 353);
            this.movieList.TabIndex = 1;
            this.movieList.Paint += new System.Windows.Forms.PaintEventHandler(this.movieList_Paint);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.movieList);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watch List";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RomanceMoviesBtn;
        private System.Windows.Forms.Button ComedyMoviesBtn;
        private System.Windows.Forms.Button HorrorMoviesBtn;
        private System.Windows.Forms.Button ActionMoviesBtn;
        public System.Windows.Forms.FlowLayoutPanel movieList;
    }
}
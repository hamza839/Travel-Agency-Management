namespace ahru
{
    partial class admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.pkgBtn = new System.Windows.Forms.Button();
            this.custBtn = new System.Windows.Forms.Button();
            this.agBtn = new System.Windows.Forms.Button();
            this.adBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 130);
            this.panel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin Panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(757, 26);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(96, 66);
            this.logoutBtn.TabIndex = 15;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.White;
            this.bookBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookBtn.Image")));
            this.bookBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bookBtn.Location = new System.Drawing.Point(566, 339);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(186, 76);
            this.bookBtn.TabIndex = 23;
            this.bookBtn.Text = "Customer\'s Booking";
            this.bookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bookBtn.UseVisualStyleBackColor = false;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // pkgBtn
            // 
            this.pkgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.pkgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pkgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgBtn.ForeColor = System.Drawing.Color.White;
            this.pkgBtn.Image = ((System.Drawing.Image)(resources.GetObject("pkgBtn.Image")));
            this.pkgBtn.Location = new System.Drawing.Point(351, 286);
            this.pkgBtn.Name = "pkgBtn";
            this.pkgBtn.Size = new System.Drawing.Size(186, 76);
            this.pkgBtn.TabIndex = 24;
            this.pkgBtn.Text = "Packages";
            this.pkgBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pkgBtn.UseVisualStyleBackColor = false;
            this.pkgBtn.Click += new System.EventHandler(this.pkgBtn_Click);
            // 
            // custBtn
            // 
            this.custBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.custBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custBtn.ForeColor = System.Drawing.Color.White;
            this.custBtn.Image = ((System.Drawing.Image)(resources.GetObject("custBtn.Image")));
            this.custBtn.Location = new System.Drawing.Point(566, 227);
            this.custBtn.Name = "custBtn";
            this.custBtn.Size = new System.Drawing.Size(186, 76);
            this.custBtn.TabIndex = 35;
            this.custBtn.Text = "Customer\'s Record";
            this.custBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.custBtn.UseVisualStyleBackColor = false;
            this.custBtn.Click += new System.EventHandler(this.custBtn_Click_1);
            // 
            // agBtn
            // 
            this.agBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.agBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agBtn.ForeColor = System.Drawing.Color.White;
            this.agBtn.Image = ((System.Drawing.Image)(resources.GetObject("agBtn.Image")));
            this.agBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.agBtn.Location = new System.Drawing.Point(131, 227);
            this.agBtn.Name = "agBtn";
            this.agBtn.Size = new System.Drawing.Size(186, 76);
            this.agBtn.TabIndex = 36;
            this.agBtn.Text = "Agent\'s Record";
            this.agBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.agBtn.UseVisualStyleBackColor = false;
            this.agBtn.Click += new System.EventHandler(this.agBtn_Click_1);
            // 
            // adBtn
            // 
            this.adBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.adBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adBtn.ForeColor = System.Drawing.Color.White;
            this.adBtn.Image = ((System.Drawing.Image)(resources.GetObject("adBtn.Image")));
            this.adBtn.Location = new System.Drawing.Point(131, 339);
            this.adBtn.Name = "adBtn";
            this.adBtn.Size = new System.Drawing.Size(186, 76);
            this.adBtn.TabIndex = 37;
            this.adBtn.Text = "Admin\'s Record";
            this.adBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.adBtn.UseVisualStyleBackColor = false;
            this.adBtn.Click += new System.EventHandler(this.adBtn_Click);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(841, 543);
            this.Controls.Add(this.adBtn);
            this.Controls.Add(this.agBtn);
            this.Controls.Add(this.custBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.pkgBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.admin_panel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button pkgBtn;
        private System.Windows.Forms.Button custBtn;
        private System.Windows.Forms.Button agBtn;
        private System.Windows.Forms.Button adBtn;
    }
}
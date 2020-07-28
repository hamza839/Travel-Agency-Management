namespace ahru
{
    partial class admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.userla = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pinla = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.passShow = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 543);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Admin\'s Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(104, 27);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 58);
            this.back.TabIndex = 16;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // userla
            // 
            this.userla.AutoSize = true;
            this.userla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.userla.ForeColor = System.Drawing.Color.White;
            this.userla.Location = new System.Drawing.Point(422, 223);
            this.userla.Name = "userla";
            this.userla.Size = new System.Drawing.Size(81, 18);
            this.userla.TabIndex = 21;
            this.userla.Text = "Username:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(509, 224);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(204, 20);
            this.usernameTxt.TabIndex = 22;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            this.usernameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTxt_KeyPress);
            // 
            // pinla
            // 
            this.pinla.AutoSize = true;
            this.pinla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pinla.ForeColor = System.Drawing.Color.White;
            this.pinla.Location = new System.Drawing.Point(424, 288);
            this.pinla.Name = "pinla";
            this.pinla.Size = new System.Drawing.Size(79, 18);
            this.pinla.TabIndex = 23;
            this.pinla.Text = "Password:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(496, 391);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(204, 40);
            this.LoginBtn.TabIndex = 25;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(509, 289);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(204, 20);
            this.passTxt.TabIndex = 26;
            this.passTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTxt_KeyPress);
            // 
            // passShow
            // 
            this.passShow.AutoSize = true;
            this.passShow.ForeColor = System.Drawing.SystemColors.Info;
            this.passShow.Location = new System.Drawing.Point(729, 291);
            this.passShow.Name = "passShow";
            this.passShow.Size = new System.Drawing.Size(53, 17);
            this.passShow.TabIndex = 27;
            this.passShow.Text = "Show";
            this.passShow.UseVisualStyleBackColor = true;
            this.passShow.CheckedChanged += new System.EventHandler(this.passShow_CheckedChanged);
            // 
            // admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(841, 543);
            this.Controls.Add(this.passShow);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.pinla);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.userla);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "admin_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label userla;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label pinla;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.CheckBox passShow;
    }
}
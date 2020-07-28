namespace ahru
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toTxt = new System.Windows.Forms.TextBox();
            this.hoTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flightTxt = new System.Windows.Forms.TextBox();
            this.fli = new System.Windows.Forms.Label();
            this.packNameBox = new System.Windows.Forms.ComboBox();
            this.dtTxt = new System.Windows.Forms.TextBox();
            this.atTxt = new System.Windows.Forms.TextBox();
            this.deTxt = new System.Windows.Forms.DateTimePicker();
            this.arTxt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.custNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custCnicTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(415, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "Arrival:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(390, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "Departure:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 543);
            this.panel1.TabIndex = 77;
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(27, 164);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(251, 189);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 77;
            this.picBox.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(116, 23);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 58);
            this.backBtn.TabIndex = 16;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(96, 105);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 31);
            this.login.TabIndex = 76;
            this.login.Text = "Booking";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(498, 420);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(176, 46);
            this.confirmBtn.TabIndex = 73;
            this.confirmBtn.Text = "Generate Ticket";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(361, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "Pakage Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(384, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 88;
            this.label4.Text = "Total Price:";
            // 
            // toTxt
            // 
            this.toTxt.Location = new System.Drawing.Point(473, 333);
            this.toTxt.Name = "toTxt";
            this.toTxt.ReadOnly = true;
            this.toTxt.Size = new System.Drawing.Size(272, 20);
            this.toTxt.TabIndex = 95;
            // 
            // hoTxt
            // 
            this.hoTxt.Location = new System.Drawing.Point(473, 307);
            this.hoTxt.Name = "hoTxt";
            this.hoTxt.ReadOnly = true;
            this.hoTxt.Size = new System.Drawing.Size(272, 20);
            this.hoTxt.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(420, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 98;
            this.label8.Text = "Hotel:";
            // 
            // flightTxt
            // 
            this.flightTxt.Location = new System.Drawing.Point(473, 228);
            this.flightTxt.Name = "flightTxt";
            this.flightTxt.ReadOnly = true;
            this.flightTxt.Size = new System.Drawing.Size(272, 20);
            this.flightTxt.TabIndex = 101;
            // 
            // fli
            // 
            this.fli.AutoSize = true;
            this.fli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fli.ForeColor = System.Drawing.Color.White;
            this.fli.Location = new System.Drawing.Point(376, 227);
            this.fli.Name = "fli";
            this.fli.Size = new System.Drawing.Size(91, 18);
            this.fli.TabIndex = 102;
            this.fli.Text = "Flight Name:";
            // 
            // packNameBox
            // 
            this.packNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packNameBox.FormattingEnabled = true;
            this.packNameBox.Location = new System.Drawing.Point(473, 201);
            this.packNameBox.Name = "packNameBox";
            this.packNameBox.Size = new System.Drawing.Size(272, 21);
            this.packNameBox.TabIndex = 96;
            this.packNameBox.SelectedIndexChanged += new System.EventHandler(this.packIdBox_SelectedIndexChanged);
            this.packNameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.packNameBox_MouseClick);
            // 
            // dtTxt
            // 
            this.dtTxt.Location = new System.Drawing.Point(676, 255);
            this.dtTxt.Name = "dtTxt";
            this.dtTxt.ReadOnly = true;
            this.dtTxt.Size = new System.Drawing.Size(69, 20);
            this.dtTxt.TabIndex = 114;
            // 
            // atTxt
            // 
            this.atTxt.Location = new System.Drawing.Point(676, 281);
            this.atTxt.Name = "atTxt";
            this.atTxt.ReadOnly = true;
            this.atTxt.Size = new System.Drawing.Size(69, 20);
            this.atTxt.TabIndex = 115;
            // 
            // deTxt
            // 
            this.deTxt.Enabled = false;
            this.deTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deTxt.Location = new System.Drawing.Point(473, 254);
            this.deTxt.Name = "deTxt";
            this.deTxt.Size = new System.Drawing.Size(197, 18);
            this.deTxt.TabIndex = 116;
            // 
            // arTxt
            // 
            this.arTxt.Enabled = false;
            this.arTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arTxt.Location = new System.Drawing.Point(473, 280);
            this.arTxt.Name = "arTxt";
            this.arTxt.Size = new System.Drawing.Size(197, 18);
            this.arTxt.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 119;
            this.label1.Text = "Customer Name:";
            // 
            // custNameTxt
            // 
            this.custNameTxt.Location = new System.Drawing.Point(473, 175);
            this.custNameTxt.Name = "custNameTxt";
            this.custNameTxt.ReadOnly = true;
            this.custNameTxt.Size = new System.Drawing.Size(272, 20);
            this.custNameTxt.TabIndex = 118;
            this.custNameTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.custNameTxt_MouseClick);
            this.custNameTxt.TextChanged += new System.EventHandler(this.custNameTxt_TextChanged);
            this.custNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custNameTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(349, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 121;
            this.label2.Text = "Customer CNIC:";
            // 
            // custCnicTxt
            // 
            this.custCnicTxt.Location = new System.Drawing.Point(473, 149);
            this.custCnicTxt.Name = "custCnicTxt";
            this.custCnicTxt.Size = new System.Drawing.Size(272, 20);
            this.custCnicTxt.TabIndex = 120;
            this.custCnicTxt.CursorChanged += new System.EventHandler(this.custCnicTxt_CursorChanged);
            this.custCnicTxt.TextChanged += new System.EventHandler(this.custCnicTxt_TextChanged);
            this.custCnicTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custCnicTxt_KeyPress);
            this.custCnicTxt.Leave += new System.EventHandler(this.custCnicTxt_Leave);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(841, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custCnicTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custNameTxt);
            this.Controls.Add(this.arTxt);
            this.Controls.Add(this.deTxt);
            this.Controls.Add(this.atTxt);
            this.Controls.Add(this.dtTxt);
            this.Controls.Add(this.fli);
            this.Controls.Add(this.flightTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hoTxt);
            this.Controls.Add(this.packNameBox);
            this.Controls.Add(this.toTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Booking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.TextBox hoTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox flightTxt;
        private System.Windows.Forms.Label fli;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ComboBox packNameBox;
        private System.Windows.Forms.TextBox dtTxt;
        private System.Windows.Forms.TextBox atTxt;
        private System.Windows.Forms.DateTimePicker deTxt;
        private System.Windows.Forms.DateTimePicker arTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custCnicTxt;
    }
}
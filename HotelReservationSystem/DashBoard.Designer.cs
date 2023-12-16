namespace HotelReservationSystem
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.costumerDetails1 = new HotelReservationSystem.AllControl.CostumerDetails();
            this.costumerR1 = new HotelReservationSystem.AllControl.CostumerR();
            this.addRoom1 = new HotelReservationSystem.AllControl.AddRoom();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.addroom_btn = new System.Windows.Forms.Button();
            this.costumerR_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.costumerD_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.costumerDetails1);
            this.panel1.Controls.Add(this.costumerR1);
            this.panel1.Controls.Add(this.addRoom1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(216, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 606);
            this.panel1.TabIndex = 0;
            // 
            // costumerDetails1
            // 
            this.costumerDetails1.BackColor = System.Drawing.Color.White;
            this.costumerDetails1.Location = new System.Drawing.Point(0, 0);
            this.costumerDetails1.Name = "costumerDetails1";
            this.costumerDetails1.Size = new System.Drawing.Size(1294, 692);
            this.costumerDetails1.TabIndex = 2;
            // 
            // costumerR1
            // 
            this.costumerR1.BackColor = System.Drawing.Color.White;
            this.costumerR1.Location = new System.Drawing.Point(0, 3);
            this.costumerR1.Name = "costumerR1";
            this.costumerR1.Size = new System.Drawing.Size(1294, 692);
            this.costumerR1.TabIndex = 1;
            this.costumerR1.Visible = false;
            // 
            // addRoom1
            // 
            this.addRoom1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.addRoom1.BackColor = System.Drawing.Color.White;
            this.addRoom1.Location = new System.Drawing.Point(1, 3);
            this.addRoom1.Name = "addRoom1";
            this.addRoom1.Size = new System.Drawing.Size(1389, 692);
            this.addRoom1.TabIndex = 0;
            this.addRoom1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(524, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Reservation System";
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(1206, 7);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(34, 34);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.close_btn.TabIndex = 2;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // addroom_btn
            // 
            this.addroom_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.addroom_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addroom_btn.FlatAppearance.BorderSize = 0;
            this.addroom_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addroom_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.addroom_btn.ForeColor = System.Drawing.Color.White;
            this.addroom_btn.Location = new System.Drawing.Point(1, 243);
            this.addroom_btn.Name = "addroom_btn";
            this.addroom_btn.Size = new System.Drawing.Size(215, 73);
            this.addroom_btn.TabIndex = 3;
            this.addroom_btn.Text = "Add Room";
            this.addroom_btn.UseVisualStyleBackColor = false;
            this.addroom_btn.Click += new System.EventHandler(this.addroom_btn_Click);
            // 
            // costumerR_button
            // 
            this.costumerR_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.costumerR_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.costumerR_button.FlatAppearance.BorderSize = 0;
            this.costumerR_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costumerR_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.costumerR_button.ForeColor = System.Drawing.Color.White;
            this.costumerR_button.Location = new System.Drawing.Point(1, 322);
            this.costumerR_button.Name = "costumerR_button";
            this.costumerR_button.Size = new System.Drawing.Size(215, 73);
            this.costumerR_button.TabIndex = 5;
            this.costumerR_button.Text = "Costumer Registration";
            this.costumerR_button.UseVisualStyleBackColor = false;
            this.costumerR_button.Click += new System.EventHandler(this.costumerR_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // costumerD_button
            // 
            this.costumerD_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.costumerD_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.costumerD_button.FlatAppearance.BorderSize = 0;
            this.costumerD_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costumerD_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.costumerD_button.ForeColor = System.Drawing.Color.White;
            this.costumerD_button.Location = new System.Drawing.Point(1, 401);
            this.costumerD_button.Name = "costumerD_button";
            this.costumerD_button.Size = new System.Drawing.Size(215, 73);
            this.costumerD_button.TabIndex = 7;
            this.costumerD_button.Text = "Costumer Details";
            this.costumerD_button.UseVisualStyleBackColor = false;
            this.costumerD_button.Click += new System.EventHandler(this.costumerD_button_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1252, 672);
            this.Controls.Add(this.costumerD_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.costumerR_button);
            this.Controls.Add(this.addroom_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Button addroom_btn;
        private System.Windows.Forms.Button costumerR_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AllControl.AddRoom addRoom1;
        private AllControl.CostumerR costumerR1;
        private System.Windows.Forms.Button costumerD_button;
        private AllControl.CostumerDetails costumerDetails1;
    }
}
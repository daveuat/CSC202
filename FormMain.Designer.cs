﻿namespace CSC202
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.InformationBoxJunction1 = new System.Windows.Forms.GroupBox();
            this.RoomDesccriptionBox1 = new System.Windows.Forms.TextBox();
            this.RoomNameBox1 = new System.Windows.Forms.TextBox();
            this.RoomDescriptionLabel1 = new System.Windows.Forms.Label();
            this.RoomNameLabel1 = new System.Windows.Forms.Label();
            this.navBox1 = new System.Windows.Forms.GroupBox();
            this.navButtonMJ = new System.Windows.Forms.Button();
            this.navButtonME = new System.Windows.Forms.Button();
            this.navButtonCD = new System.Windows.Forms.Button();
            this.navButtonMB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navButtonMH = new System.Windows.Forms.Button();
            this.InformationBoxJunction1.SuspendLayout();
            this.navBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationBoxJunction1
            // 
            this.InformationBoxJunction1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.InformationBoxJunction1.Controls.Add(this.RoomDesccriptionBox1);
            this.InformationBoxJunction1.Controls.Add(this.RoomNameBox1);
            this.InformationBoxJunction1.Controls.Add(this.RoomDescriptionLabel1);
            this.InformationBoxJunction1.Controls.Add(this.RoomNameLabel1);
            this.InformationBoxJunction1.Location = new System.Drawing.Point(1606, 534);
            this.InformationBoxJunction1.Name = "InformationBoxJunction1";
            this.InformationBoxJunction1.Size = new System.Drawing.Size(286, 233);
            this.InformationBoxJunction1.TabIndex = 0;
            this.InformationBoxJunction1.TabStop = false;
            this.InformationBoxJunction1.Text = "Location Information";
            // 
            // RoomDesccriptionBox1
            // 
            this.RoomDesccriptionBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RoomDesccriptionBox1.Location = new System.Drawing.Point(18, 81);
            this.RoomDesccriptionBox1.Multiline = true;
            this.RoomDesccriptionBox1.Name = "RoomDesccriptionBox1";
            this.RoomDesccriptionBox1.ReadOnly = true;
            this.RoomDesccriptionBox1.Size = new System.Drawing.Size(243, 146);
            this.RoomDesccriptionBox1.TabIndex = 3;
            this.RoomDesccriptionBox1.Text = resources.GetString("RoomDesccriptionBox1.Text");
            // 
            // RoomNameBox1
            // 
            this.RoomNameBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RoomNameBox1.Location = new System.Drawing.Point(18, 37);
            this.RoomNameBox1.Name = "RoomNameBox1";
            this.RoomNameBox1.ReadOnly = true;
            this.RoomNameBox1.Size = new System.Drawing.Size(243, 23);
            this.RoomNameBox1.TabIndex = 2;
            this.RoomNameBox1.Text = "Main Junction";
            // 
            // RoomDescriptionLabel1
            // 
            this.RoomDescriptionLabel1.AutoSize = true;
            this.RoomDescriptionLabel1.Location = new System.Drawing.Point(6, 63);
            this.RoomDescriptionLabel1.Name = "RoomDescriptionLabel1";
            this.RoomDescriptionLabel1.Size = new System.Drawing.Size(102, 15);
            this.RoomDescriptionLabel1.TabIndex = 1;
            this.RoomDescriptionLabel1.Text = "Room Description";
            // 
            // RoomNameLabel1
            // 
            this.RoomNameLabel1.AutoSize = true;
            this.RoomNameLabel1.Location = new System.Drawing.Point(6, 19);
            this.RoomNameLabel1.Name = "RoomNameLabel1";
            this.RoomNameLabel1.Size = new System.Drawing.Size(74, 15);
            this.RoomNameLabel1.TabIndex = 0;
            this.RoomNameLabel1.Text = "Room Name";
            this.RoomNameLabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // navBox1
            // 
            this.navBox1.BackColor = System.Drawing.Color.Crimson;
            this.navBox1.Controls.Add(this.navButtonMH);
            this.navBox1.Controls.Add(this.navButtonMJ);
            this.navBox1.Controls.Add(this.navButtonME);
            this.navBox1.Controls.Add(this.navButtonCD);
            this.navBox1.Controls.Add(this.navButtonMB);
            this.navBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.navBox1.Location = new System.Drawing.Point(1674, 773);
            this.navBox1.Name = "navBox1";
            this.navBox1.Size = new System.Drawing.Size(218, 256);
            this.navBox1.TabIndex = 6;
            this.navBox1.TabStop = false;
            this.navBox1.Text = "Personal Nav Device";
            this.navBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // navButtonMJ
            // 
            this.navButtonMJ.Image = ((System.Drawing.Image)(resources.GetObject("navButtonMJ.Image")));
            this.navButtonMJ.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.navButtonMJ.Location = new System.Drawing.Point(17, 22);
            this.navButtonMJ.Name = "navButtonMJ";
            this.navButtonMJ.Size = new System.Drawing.Size(186, 39);
            this.navButtonMJ.TabIndex = 4;
            this.navButtonMJ.UseVisualStyleBackColor = true;
            this.navButtonMJ.Click += new System.EventHandler(this.navButtonMJ_Click);
            // 
            // navButtonME
            // 
            this.navButtonME.Image = ((System.Drawing.Image)(resources.GetObject("navButtonME.Image")));
            this.navButtonME.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.navButtonME.Location = new System.Drawing.Point(44, 110);
            this.navButtonME.Name = "navButtonME";
            this.navButtonME.Size = new System.Drawing.Size(131, 39);
            this.navButtonME.TabIndex = 3;
            this.navButtonME.UseVisualStyleBackColor = true;
            this.navButtonME.Click += new System.EventHandler(this.navButtonME_Click);
            // 
            // navButtonCD
            // 
            this.navButtonCD.Image = ((System.Drawing.Image)(resources.GetObject("navButtonCD.Image")));
            this.navButtonCD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.navButtonCD.Location = new System.Drawing.Point(17, 67);
            this.navButtonCD.Name = "navButtonCD";
            this.navButtonCD.Size = new System.Drawing.Size(186, 39);
            this.navButtonCD.TabIndex = 2;
            this.navButtonCD.UseVisualStyleBackColor = true;
            this.navButtonCD.Click += new System.EventHandler(this.navButtonCD_Click);
            // 
            // navButtonMB
            // 
            this.navButtonMB.Image = ((System.Drawing.Image)(resources.GetObject("navButtonMB.Image")));
            this.navButtonMB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.navButtonMB.Location = new System.Drawing.Point(44, 155);
            this.navButtonMB.Name = "navButtonMB";
            this.navButtonMB.Size = new System.Drawing.Size(131, 39);
            this.navButtonMB.TabIndex = 1;
            this.navButtonMB.UseVisualStyleBackColor = true;
            this.navButtonMB.Click += new System.EventHandler(this.navButtonMB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CSC202.Properties.Resources.mainjunction;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1903, 1039);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // navButtonMH
            // 
            this.navButtonMH.Image = ((System.Drawing.Image)(resources.GetObject("navButtonMH.Image")));
            this.navButtonMH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.navButtonMH.Location = new System.Drawing.Point(44, 200);
            this.navButtonMH.Name = "navButtonMH";
            this.navButtonMH.Size = new System.Drawing.Size(131, 39);
            this.navButtonMH.TabIndex = 5;
            this.navButtonMH.UseVisualStyleBackColor = true;
            this.navButtonMH.Click += new System.EventHandler(this.navButtonMH_click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.navBox1);
            this.Controls.Add(this.InformationBoxJunction1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMain";
            this.Text = "Moonbase Frontier";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.InformationBoxJunction1.ResumeLayout(false);
            this.InformationBoxJunction1.PerformLayout();
            this.navBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox InformationBoxJunction1;
        private Label RoomNameLabel1;
        private TextBox RoomDesccriptionBox1;
        private TextBox RoomNameBox1;
        private Label RoomDescriptionLabel1;
        private GroupBox navBox1;
        private Button navButtonME;
        private Button navButtonCD;
        private Button navButtonMB;
        private PictureBox pictureBox1;
        private Button navButtonMJ;
        private Button navButtonMH;
    }
}
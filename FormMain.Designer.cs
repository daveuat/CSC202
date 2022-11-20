namespace CSC202
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
            this.PathwayBox1 = new System.Windows.Forms.GroupBox();
            this.pathlabel1 = new System.Windows.Forms.Label();
            this.PathwayBox3 = new System.Windows.Forms.GroupBox();
            this.pathlabel3 = new System.Windows.Forms.Label();
            this.PathwayBox2 = new System.Windows.Forms.GroupBox();
            this.pathlabel2 = new System.Windows.Forms.Label();
            this.PathwayBox4 = new System.Windows.Forms.GroupBox();
            this.pathlabel4 = new System.Windows.Forms.Label();
            this.InformationBoxJunction1.SuspendLayout();
            this.PathwayBox1.SuspendLayout();
            this.PathwayBox3.SuspendLayout();
            this.PathwayBox2.SuspendLayout();
            this.PathwayBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationBoxJunction1
            // 
            this.InformationBoxJunction1.Controls.Add(this.RoomDesccriptionBox1);
            this.InformationBoxJunction1.Controls.Add(this.RoomNameBox1);
            this.InformationBoxJunction1.Controls.Add(this.RoomDescriptionLabel1);
            this.InformationBoxJunction1.Controls.Add(this.RoomNameLabel1);
            this.InformationBoxJunction1.Location = new System.Drawing.Point(1475, 290);
            this.InformationBoxJunction1.Name = "InformationBoxJunction1";
            this.InformationBoxJunction1.Size = new System.Drawing.Size(286, 233);
            this.InformationBoxJunction1.TabIndex = 0;
            this.InformationBoxJunction1.TabStop = false;
            this.InformationBoxJunction1.Text = "Location Information";
            // 
            // RoomDesccriptionBox1
            // 
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
            this.RoomNameBox1.Location = new System.Drawing.Point(18, 37);
            this.RoomNameBox1.Name = "RoomNameBox1";
            this.RoomNameBox1.ReadOnly = true;
            this.RoomNameBox1.Size = new System.Drawing.Size(243, 23);
            this.RoomNameBox1.TabIndex = 2;
            this.RoomNameBox1.Text = "Moonbase Junction 1";
            this.RoomNameBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // PathwayBox1
            // 
            this.PathwayBox1.Controls.Add(this.pathlabel1);
            this.PathwayBox1.Location = new System.Drawing.Point(458, 319);
            this.PathwayBox1.Name = "PathwayBox1";
            this.PathwayBox1.Size = new System.Drawing.Size(121, 49);
            this.PathwayBox1.TabIndex = 1;
            this.PathwayBox1.TabStop = false;
            this.PathwayBox1.Text = "Route Information";
            // 
            // pathlabel1
            // 
            this.pathlabel1.AutoSize = true;
            this.pathlabel1.Location = new System.Drawing.Point(6, 19);
            this.pathlabel1.Name = "pathlabel1";
            this.pathlabel1.Size = new System.Drawing.Size(104, 15);
            this.pathlabel1.TabIndex = 4;
            this.pathlabel1.Text = "Towards Mess Hall";
            this.pathlabel1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PathwayBox3
            // 
            this.PathwayBox3.Controls.Add(this.pathlabel3);
            this.PathwayBox3.Location = new System.Drawing.Point(705, 80);
            this.PathwayBox3.Name = "PathwayBox3";
            this.PathwayBox3.Size = new System.Drawing.Size(148, 49);
            this.PathwayBox3.TabIndex = 5;
            this.PathwayBox3.TabStop = false;
            this.PathwayBox3.Text = "Route Information";
            // 
            // pathlabel3
            // 
            this.pathlabel3.AutoSize = true;
            this.pathlabel3.Location = new System.Drawing.Point(6, 19);
            this.pathlabel3.Name = "pathlabel3";
            this.pathlabel3.Size = new System.Drawing.Size(143, 15);
            this.pathlabel3.TabIndex = 4;
            this.pathlabel3.Text = "Up To Oberservation Deck";
            // 
            // PathwayBox2
            // 
            this.PathwayBox2.Controls.Add(this.pathlabel2);
            this.PathwayBox2.Location = new System.Drawing.Point(694, 784);
            this.PathwayBox2.Name = "PathwayBox2";
            this.PathwayBox2.Size = new System.Drawing.Size(159, 49);
            this.PathwayBox2.TabIndex = 5;
            this.PathwayBox2.TabStop = false;
            this.PathwayBox2.Text = "Route Information";
            // 
            // pathlabel2
            // 
            this.pathlabel2.AutoSize = true;
            this.pathlabel2.Location = new System.Drawing.Point(6, 19);
            this.pathlabel2.Name = "pathlabel2";
            this.pathlabel2.Size = new System.Drawing.Size(146, 15);
            this.pathlabel2.TabIndex = 4;
            this.pathlabel2.Text = "Towards Main Engineering";
            // 
            // PathwayBox4
            // 
            this.PathwayBox4.Controls.Add(this.pathlabel4);
            this.PathwayBox4.Location = new System.Drawing.Point(1177, 275);
            this.PathwayBox4.Name = "PathwayBox4";
            this.PathwayBox4.Size = new System.Drawing.Size(141, 49);
            this.PathwayBox4.TabIndex = 5;
            this.PathwayBox4.TabStop = false;
            this.PathwayBox4.Text = "Route Information";
            // 
            // pathlabel4
            // 
            this.pathlabel4.AutoSize = true;
            this.pathlabel4.Location = new System.Drawing.Point(6, 19);
            this.pathlabel4.Name = "pathlabel4";
            this.pathlabel4.Size = new System.Drawing.Size(127, 15);
            this.pathlabel4.TabIndex = 4;
            this.pathlabel4.Text = "Towards Main Barracks";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSC202.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PathwayBox4);
            this.Controls.Add(this.PathwayBox2);
            this.Controls.Add(this.PathwayBox3);
            this.Controls.Add(this.PathwayBox1);
            this.Controls.Add(this.InformationBoxJunction1);
            this.Name = "FormMain";
            this.Text = "Moonbase Frontier";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.InformationBoxJunction1.ResumeLayout(false);
            this.InformationBoxJunction1.PerformLayout();
            this.PathwayBox1.ResumeLayout(false);
            this.PathwayBox1.PerformLayout();
            this.PathwayBox3.ResumeLayout(false);
            this.PathwayBox3.PerformLayout();
            this.PathwayBox2.ResumeLayout(false);
            this.PathwayBox2.PerformLayout();
            this.PathwayBox4.ResumeLayout(false);
            this.PathwayBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox InformationBoxJunction1;
        private Label RoomNameLabel1;
        private TextBox RoomDesccriptionBox1;
        private TextBox RoomNameBox1;
        private Label RoomDescriptionLabel1;
        private GroupBox PathwayBox1;
        private Label pathlabel1;
        private GroupBox PathwayBox3;
        private Label pathlabel3;
        private GroupBox PathwayBox2;
        private Label pathlabel2;
        private GroupBox PathwayBox4;
        private Label pathlabel4;
    }
}
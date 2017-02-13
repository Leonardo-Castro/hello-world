namespace VideoGameMuseum
{
   partial class VideoGameMuseum
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
         this.btnNorth = new System.Windows.Forms.Button();
         this.btnRight = new System.Windows.Forms.Button();
         this.btnSouth = new System.Windows.Forms.Button();
         this.btnLeft = new System.Windows.Forms.Button();
         this.rtbLocation = new System.Windows.Forms.RichTextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.btnIndustryPersonality = new System.Windows.Forms.Button();
         this.btnCompanyTable = new System.Windows.Forms.Button();
         this.btnGameTable = new System.Windows.Forms.Button();
         this.btnConsoleTable = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnNorth
         // 
         this.btnNorth.BackColor = System.Drawing.Color.Yellow;
         this.btnNorth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnNorth.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnNorth.Location = new System.Drawing.Point(687, 561);
         this.btnNorth.Name = "btnNorth";
         this.btnNorth.Size = new System.Drawing.Size(114, 40);
         this.btnNorth.TabIndex = 5;
         this.btnNorth.Text = "North";
         this.btnNorth.UseVisualStyleBackColor = false;
         this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
         // 
         // btnRight
         // 
         this.btnRight.BackColor = System.Drawing.Color.Red;
         this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnRight.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRight.Location = new System.Drawing.Point(801, 601);
         this.btnRight.Name = "btnRight";
         this.btnRight.Size = new System.Drawing.Size(114, 40);
         this.btnRight.TabIndex = 6;
         this.btnRight.Text = "Right";
         this.btnRight.UseVisualStyleBackColor = false;
         this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
         // 
         // btnSouth
         // 
         this.btnSouth.BackColor = System.Drawing.Color.Lime;
         this.btnSouth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnSouth.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSouth.Location = new System.Drawing.Point(687, 641);
         this.btnSouth.Name = "btnSouth";
         this.btnSouth.Size = new System.Drawing.Size(114, 40);
         this.btnSouth.TabIndex = 7;
         this.btnSouth.Text = "South";
         this.btnSouth.UseVisualStyleBackColor = false;
         this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
         // 
         // btnLeft
         // 
         this.btnLeft.BackColor = System.Drawing.SystemColors.Highlight;
         this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnLeft.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLeft.Location = new System.Drawing.Point(573, 601);
         this.btnLeft.Name = "btnLeft";
         this.btnLeft.Size = new System.Drawing.Size(114, 40);
         this.btnLeft.TabIndex = 8;
         this.btnLeft.Text = "Left";
         this.btnLeft.UseVisualStyleBackColor = false;
         this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
         // 
         // rtbLocation
         // 
         this.rtbLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.rtbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rtbLocation.Location = new System.Drawing.Point(16, 321);
         this.rtbLocation.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
         this.rtbLocation.Name = "rtbLocation";
         this.rtbLocation.ReadOnly = true;
         this.rtbLocation.Size = new System.Drawing.Size(480, 379);
         this.rtbLocation.TabIndex = 9;
         this.rtbLocation.Text = "";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("OCR A Extended", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(153, 295);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(201, 20);
         this.label6.TabIndex = 13;
         this.label6.Text = "Current Location";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::VideoGameMuseum.Properties.Resources.FIRoQlt;
         this.pictureBox1.Location = new System.Drawing.Point(193, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(571, 226);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 14;
         this.pictureBox1.TabStop = false;
         // 
         // btnIndustryPersonality
         // 
         this.btnIndustryPersonality.BackColor = System.Drawing.Color.LightBlue;
         this.btnIndustryPersonality.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnIndustryPersonality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnIndustryPersonality.Location = new System.Drawing.Point(616, 450);
         this.btnIndustryPersonality.Name = "btnIndustryPersonality";
         this.btnIndustryPersonality.Size = new System.Drawing.Size(263, 36);
         this.btnIndustryPersonality.TabIndex = 15;
         this.btnIndustryPersonality.Text = "Industry Personality Table";
         this.btnIndustryPersonality.UseVisualStyleBackColor = false;
         this.btnIndustryPersonality.Click += new System.EventHandler(this.btnIndustryPersonality_Click);
         // 
         // btnCompanyTable
         // 
         this.btnCompanyTable.BackColor = System.Drawing.Color.LightBlue;
         this.btnCompanyTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnCompanyTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCompanyTable.Location = new System.Drawing.Point(616, 321);
         this.btnCompanyTable.Name = "btnCompanyTable";
         this.btnCompanyTable.Size = new System.Drawing.Size(263, 36);
         this.btnCompanyTable.TabIndex = 15;
         this.btnCompanyTable.Text = "Company Table";
         this.btnCompanyTable.UseVisualStyleBackColor = false;
         this.btnCompanyTable.Click += new System.EventHandler(this.btnCompanyTable_Click);
         // 
         // btnGameTable
         // 
         this.btnGameTable.BackColor = System.Drawing.Color.LightBlue;
         this.btnGameTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnGameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnGameTable.Location = new System.Drawing.Point(616, 406);
         this.btnGameTable.Name = "btnGameTable";
         this.btnGameTable.Size = new System.Drawing.Size(263, 38);
         this.btnGameTable.TabIndex = 18;
         this.btnGameTable.Text = "Game Table";
         this.btnGameTable.UseVisualStyleBackColor = false;
         this.btnGameTable.Click += new System.EventHandler(this.btnGameTable_Click);
         // 
         // btnConsoleTable
         // 
         this.btnConsoleTable.BackColor = System.Drawing.Color.LightBlue;
         this.btnConsoleTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnConsoleTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnConsoleTable.Location = new System.Drawing.Point(616, 364);
         this.btnConsoleTable.Name = "btnConsoleTable";
         this.btnConsoleTable.Size = new System.Drawing.Size(263, 36);
         this.btnConsoleTable.TabIndex = 20;
         this.btnConsoleTable.Text = "Console Table";
         this.btnConsoleTable.UseVisualStyleBackColor = false;
         this.btnConsoleTable.Click += new System.EventHandler(this.btnConsoleTable_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(630, 274);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(237, 44);
         this.label1.TabIndex = 21;
         this.label1.Text = "Database Tables";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(669, 514);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(151, 44);
         this.label2.TabIndex = 22;
         this.label2.Text = "Navigation";
         // 
         // VideoGameMuseum
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.CornflowerBlue;
         this.ClientSize = new System.Drawing.Size(983, 726);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnConsoleTable);
         this.Controls.Add(this.btnGameTable);
         this.Controls.Add(this.btnCompanyTable);
         this.Controls.Add(this.btnIndustryPersonality);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.rtbLocation);
         this.Controls.Add(this.btnLeft);
         this.Controls.Add(this.btnSouth);
         this.Controls.Add(this.btnRight);
         this.Controls.Add(this.btnNorth);
         this.Controls.Add(this.pictureBox1);
         this.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "VideoGameMuseum";
         this.Text = "The Citadel";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnNorth;
      private System.Windows.Forms.Button btnRight;
      private System.Windows.Forms.Button btnSouth;
      private System.Windows.Forms.Button btnLeft;
      private System.Windows.Forms.RichTextBox rtbLocation;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button btnIndustryPersonality;
      private System.Windows.Forms.Button btnCompanyTable;
      private System.Windows.Forms.Button btnGameTable;
      private System.Windows.Forms.Button btnConsoleTable;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
   }
}


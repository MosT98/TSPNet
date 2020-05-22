namespace MyPhotosGUI
{
    partial class ViewPhotos
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.previewPhoto = new System.Windows.Forms.PictureBox();
            this.photosCombo = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(326, 20);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 44);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(641, 20);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 44);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 20);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 44);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // previewPhoto
            // 
            this.previewPhoto.Location = new System.Drawing.Point(449, 12);
            this.previewPhoto.Name = "previewPhoto";
            this.previewPhoto.Size = new System.Drawing.Size(339, 332);
            this.previewPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPhoto.TabIndex = 3;
            this.previewPhoto.TabStop = false;
            // 
            // photosCombo
            // 
            this.photosCombo.FormattingEnabled = true;
            this.photosCombo.Location = new System.Drawing.Point(12, 161);
            this.photosCombo.Name = "photosCombo";
            this.photosCombo.Size = new System.Drawing.Size(431, 21);
            this.photosCombo.TabIndex = 4;
            this.photosCombo.SelectedIndexChanged += new System.EventHandler(this.photosCombo_SelectedIndexChanged);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(23, 85);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(410, 63);
            this.text.TabIndex = 5;
            this.text.Text = "Select a photo";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text);
            this.Controls.Add(this.photosCombo);
            this.Controls.Add(this.previewPhoto);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPhotos";
            this.Text = "View Photos";
            this.Load += new System.EventHandler(this.ViewPhotos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox previewPhoto;
        private System.Windows.Forms.ComboBox photosCombo;
        private System.Windows.Forms.Label text;
    }
}
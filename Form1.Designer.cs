namespace Random_File_Picker
{
    partial class Form1
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
            this.folderSelect = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderSelect
            // 
            this.folderSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.folderSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.folderSelect.Location = new System.Drawing.Point(0, 662);
            this.folderSelect.MinimumSize = new System.Drawing.Size(101, 50);
            this.folderSelect.Name = "folderSelect";
            this.folderSelect.Size = new System.Drawing.Size(1113, 50);
            this.folderSelect.TabIndex = 4;
            this.folderSelect.TabStop = false;
            this.folderSelect.Text = "Select Folder";
            this.folderSelect.UseVisualStyleBackColor = true;
            this.folderSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.Location = new System.Drawing.Point(0, 558);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(1113, 44);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randomizeButton
            // 
            this.randomizeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randomizeButton.Enabled = false;
            this.randomizeButton.Location = new System.Drawing.Point(0, 632);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(1113, 30);
            this.randomizeButton.TabIndex = 1;
            this.randomizeButton.TabStop = false;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1113, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(0, 602);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(1113, 30);
            this.openButton.TabIndex = 3;
            this.openButton.TabStop = false;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 712);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.folderSelect);
            this.Name = "Form1";
            this.Text = "Random File Picker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button folderSelect;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openButton;
    }
}


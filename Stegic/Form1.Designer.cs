namespace Stegic
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
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.PathTextbox = new System.Windows.Forms.TextBox();
            this.SecretMessageTextbox = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileButton.Location = new System.Drawing.Point(11, 683);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(232, 90);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // PathTextbox
            // 
            this.PathTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathTextbox.Location = new System.Drawing.Point(11, 621);
            this.PathTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PathTextbox.Multiline = true;
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.Size = new System.Drawing.Size(962, 38);
            this.PathTextbox.TabIndex = 1;
            // 
            // SecretMessageTextbox
            // 
            this.SecretMessageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecretMessageTextbox.Location = new System.Drawing.Point(422, 683);
            this.SecretMessageTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SecretMessageTextbox.Multiline = true;
            this.SecretMessageTextbox.Name = "SecretMessageTextbox";
            this.SecretMessageTextbox.Size = new System.Drawing.Size(551, 128);
            this.SecretMessageTextbox.TabIndex = 2;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodeButton.Location = new System.Drawing.Point(422, 838);
            this.EncodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(252, 83);
            this.EncodeButton.TabIndex = 3;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecodeButton.Location = new System.Drawing.Point(750, 838);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(223, 83);
            this.DecodeButton.TabIndex = 4;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 596);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.SecretMessageTextbox);
            this.Controls.Add(this.PathTextbox);
            this.Controls.Add(this.OpenFileButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button DecodeButton;

        private System.Windows.Forms.Button EncodeButton;

        private System.Windows.Forms.TextBox SecretMessageTextbox;

        private System.Windows.Forms.TextBox PathTextbox;

        private System.Windows.Forms.Button OpenFileButton;

        #endregion
    }
}
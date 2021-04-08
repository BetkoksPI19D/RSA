namespace RSAAlgorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.PrimaryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DecryptedResultBox = new System.Windows.Forms.TextBox();
            this.EncryptedResultBox = new System.Windows.Forms.TextBox();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearKeyFile = new System.Windows.Forms.Button();
            this.ClearTextFile = new System.Windows.Forms.Button();
            this.eLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.FiLabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "p=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "q=";
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(62, 41);
            this.pTextBox.MaxLength = 3276764;
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(70, 22);
            this.pTextBox.TabIndex = 2;
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(168, 41);
            this.qTextBox.MaxLength = 3276765;
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(75, 22);
            this.qTextBox.TabIndex = 3;
            // 
            // PrimaryTextBox
            // 
            this.PrimaryTextBox.Location = new System.Drawing.Point(120, 184);
            this.PrimaryTextBox.MaxLength = 3276765;
            this.PrimaryTextBox.Name = "PrimaryTextBox";
            this.PrimaryTextBox.Size = new System.Drawing.Size(202, 22);
            this.PrimaryTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primary text:";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(247, 212);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 28);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encrypted text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Encrypted text:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(654, 90);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 28);
            this.DecryptButton.TabIndex = 12;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Result text:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "e=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "n=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fi=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "D=";
            // 
            // DecryptedResultBox
            // 
            this.DecryptedResultBox.Location = new System.Drawing.Point(514, 152);
            this.DecryptedResultBox.MaxLength = 3276765;
            this.DecryptedResultBox.Name = "DecryptedResultBox";
            this.DecryptedResultBox.Size = new System.Drawing.Size(215, 22);
            this.DecryptedResultBox.TabIndex = 11;
            // 
            // EncryptedResultBox
            // 
            this.EncryptedResultBox.Location = new System.Drawing.Point(120, 254);
            this.EncryptedResultBox.Name = "EncryptedResultBox";
            this.EncryptedResultBox.Size = new System.Drawing.Size(202, 22);
            this.EncryptedResultBox.TabIndex = 24;
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Location = new System.Drawing.Point(539, 62);
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(190, 22);
            this.EncryptedTextBox.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Paste from file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearKeyFile
            // 
            this.ClearKeyFile.Location = new System.Drawing.Point(433, 234);
            this.ClearKeyFile.Name = "ClearKeyFile";
            this.ClearKeyFile.Size = new System.Drawing.Size(112, 42);
            this.ClearKeyFile.TabIndex = 27;
            this.ClearKeyFile.Text = "Clear key file";
            this.ClearKeyFile.UseVisualStyleBackColor = true;
            this.ClearKeyFile.Click += new System.EventHandler(this.ClearKeyFile_Click);
            // 
            // ClearTextFile
            // 
            this.ClearTextFile.Location = new System.Drawing.Point(551, 234);
            this.ClearTextFile.Name = "ClearTextFile";
            this.ClearTextFile.Size = new System.Drawing.Size(112, 42);
            this.ClearTextFile.TabIndex = 28;
            this.ClearTextFile.Text = "Clear text file";
            this.ClearTextFile.UseVisualStyleBackColor = true;
            this.ClearTextFile.Click += new System.EventHandler(this.ClearTextFile_Click);
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(59, 101);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(0, 17);
            this.eLabel.TabIndex = 29;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(59, 129);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(0, 17);
            this.nLabel.TabIndex = 30;
            // 
            // FiLabel
            // 
            this.FiLabel.AutoSize = true;
            this.FiLabel.Location = new System.Drawing.Point(59, 157);
            this.FiLabel.Name = "FiLabel";
            this.FiLabel.Size = new System.Drawing.Size(0, 17);
            this.FiLabel.TabIndex = 31;
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(244, 103);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(0, 17);
            this.DLabel.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 302);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.FiLabel);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.ClearTextFile);
            this.Controls.Add(this.ClearKeyFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.EncryptedResultBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.DecryptedResultBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrimaryTextBox);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.TextBox PrimaryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DecryptedResultBox;
        private System.Windows.Forms.TextBox EncryptedResultBox;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearKeyFile;
        private System.Windows.Forms.Button ClearTextFile;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label FiLabel;
        private System.Windows.Forms.Label DLabel;
    }
}


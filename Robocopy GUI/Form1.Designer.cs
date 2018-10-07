namespace Robocopy_GUI
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_button_Mirror = new System.Windows.Forms.RadioButton();
            this.radio_button_CopyOverNewFiles = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button_StartBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(436, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Directory:";
            // 
            // radio_button_Mirror
            // 
            this.radio_button_Mirror.AutoSize = true;
            this.radio_button_Mirror.Location = new System.Drawing.Point(51, 128);
            this.radio_button_Mirror.Name = "radio_button_Mirror";
            this.radio_button_Mirror.Size = new System.Drawing.Size(51, 17);
            this.radio_button_Mirror.TabIndex = 5;
            this.radio_button_Mirror.TabStop = true;
            this.radio_button_Mirror.Text = "Mirror";
            this.radio_button_Mirror.UseVisualStyleBackColor = true;
            // 
            // radio_button_CopyOverNewFiles
            // 
            this.radio_button_CopyOverNewFiles.AutoSize = true;
            this.radio_button_CopyOverNewFiles.Location = new System.Drawing.Point(51, 151);
            this.radio_button_CopyOverNewFiles.Name = "radio_button_CopyOverNewFiles";
            this.radio_button_CopyOverNewFiles.Size = new System.Drawing.Size(124, 17);
            this.radio_button_CopyOverNewFiles.TabIndex = 6;
            this.radio_button_CopyOverNewFiles.TabStop = true;
            this.radio_button_CopyOverNewFiles.Text = "Copy Over New Files";
            this.radio_button_CopyOverNewFiles.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose Your Backup Type";
            // 
            // button_StartBackup
            // 
            this.button_StartBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_StartBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartBackup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_StartBackup.Location = new System.Drawing.Point(621, 377);
            this.button_StartBackup.Name = "button_StartBackup";
            this.button_StartBackup.Size = new System.Drawing.Size(167, 61);
            this.button_StartBackup.TabIndex = 8;
            this.button_StartBackup.Text = "Start Backup!";
            this.button_StartBackup.UseVisualStyleBackColor = false;
            this.button_StartBackup.Click += new System.EventHandler(this.button_StartBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_StartBackup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radio_button_CopyOverNewFiles);
            this.Controls.Add(this.radio_button_Mirror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_button_Mirror;
        private System.Windows.Forms.RadioButton radio_button_CopyOverNewFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_StartBackup;
    }
}


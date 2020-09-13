﻿namespace FormUI
{
    partial class ApplicationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.addFilesButton = new System.Windows.Forms.Button();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.clearAllFilesButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.unlockFilesButton = new System.Windows.Forms.Button();
            this.fileListLabel = new System.Windows.Forms.Label();
            this.changeOutputFolder = new System.Windows.Forms.Button();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fileListBox.ItemHeight = 21;
            this.fileListBox.Location = new System.Drawing.Point(9, 74);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fileListBox.Size = new System.Drawing.Size(606, 277);
            this.fileListBox.TabIndex = 0;
            // 
            // addFilesButton
            // 
            this.addFilesButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addFilesButton.ForeColor = System.Drawing.Color.White;
            this.addFilesButton.Location = new System.Drawing.Point(9, 12);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(150, 30);
            this.addFilesButton.TabIndex = 1;
            this.addFilesButton.Text = "Add Files";
            this.addFilesButton.UseVisualStyleBackColor = false;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeSelectedButton.ForeColor = System.Drawing.Color.White;
            this.removeSelectedButton.Location = new System.Drawing.Point(240, 12);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(150, 30);
            this.removeSelectedButton.TabIndex = 1;
            this.removeSelectedButton.Text = "Remove Selected";
            this.removeSelectedButton.UseVisualStyleBackColor = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // clearAllFilesButton
            // 
            this.clearAllFilesButton.BackColor = System.Drawing.Color.Maroon;
            this.clearAllFilesButton.ForeColor = System.Drawing.Color.White;
            this.clearAllFilesButton.Location = new System.Drawing.Point(465, 12);
            this.clearAllFilesButton.Name = "clearAllFilesButton";
            this.clearAllFilesButton.Size = new System.Drawing.Size(150, 30);
            this.clearAllFilesButton.TabIndex = 1;
            this.clearAllFilesButton.Text = "Clear All Files";
            this.clearAllFilesButton.UseVisualStyleBackColor = false;
            this.clearAllFilesButton.Click += new System.EventHandler(this.clearAllFilesButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 400);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(450, 29);
            this.progressBar.TabIndex = 2;
            this.progressBar.Tag = "";
            // 
            // unlockFilesButton
            // 
            this.unlockFilesButton.BackColor = System.Drawing.Color.Green;
            this.unlockFilesButton.ForeColor = System.Drawing.Color.White;
            this.unlockFilesButton.Location = new System.Drawing.Point(465, 400);
            this.unlockFilesButton.Name = "unlockFilesButton";
            this.unlockFilesButton.Size = new System.Drawing.Size(150, 29);
            this.unlockFilesButton.TabIndex = 1;
            this.unlockFilesButton.Text = "Unlock!";
            this.unlockFilesButton.UseVisualStyleBackColor = false;
            this.unlockFilesButton.Click += new System.EventHandler(this.unlockFilesButton_Click);
            // 
            // fileListLabel
            // 
            this.fileListLabel.AutoSize = true;
            this.fileListLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileListLabel.Location = new System.Drawing.Point(9, 54);
            this.fileListLabel.Name = "fileListLabel";
            this.fileListLabel.Size = new System.Drawing.Size(36, 17);
            this.fileListLabel.TabIndex = 3;
            this.fileListLabel.Text = "Files:";
            // 
            // changeOutputFolder
            // 
            this.changeOutputFolder.BackColor = System.Drawing.Color.DarkGray;
            this.changeOutputFolder.ForeColor = System.Drawing.Color.White;
            this.changeOutputFolder.Location = new System.Drawing.Point(9, 364);
            this.changeOutputFolder.Name = "changeOutputFolder";
            this.changeOutputFolder.Size = new System.Drawing.Size(150, 30);
            this.changeOutputFolder.TabIndex = 1;
            this.changeOutputFolder.Text = "Output Folder";
            this.changeOutputFolder.UseVisualStyleBackColor = false;
            this.changeOutputFolder.Click += new System.EventHandler(this.changeOutputFolder_Click);
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.outputFolderLabel.Location = new System.Drawing.Point(165, 369);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(19, 21);
            this.outputFolderLabel.TabIndex = 4;
            this.outputFolderLabel.Text = "...";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.outputFolderLabel);
            this.Controls.Add(this.changeOutputFolder);
            this.Controls.Add(this.fileListLabel);
            this.Controls.Add(this.unlockFilesButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.clearAllFilesButton);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.addFilesButton);
            this.Controls.Add(this.fileListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplicationForm";
            this.Text = "craXcel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.Button clearAllFilesButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button unlockFilesButton;
        private System.Windows.Forms.Label fileListLabel;
        private System.Windows.Forms.Button changeOutputFolder;
        private System.Windows.Forms.Label outputFolderLabel;
    }
}

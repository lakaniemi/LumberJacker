﻿namespace LumberJacker
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.headPositionSelectButton = new System.Windows.Forms.Button();
            this.headPos = new System.Windows.Forms.Label();
            this.sideButton = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headPositionSelectButton
            // 
            this.headPositionSelectButton.Location = new System.Drawing.Point(13, 13);
            this.headPositionSelectButton.Name = "headPositionSelectButton";
            this.headPositionSelectButton.Size = new System.Drawing.Size(128, 36);
            this.headPositionSelectButton.TabIndex = 0;
            this.headPositionSelectButton.Text = "Select head position";
            this.headPositionSelectButton.UseVisualStyleBackColor = true;
            this.headPositionSelectButton.Click += new System.EventHandler(this.headPositionSelector_Click);
            // 
            // headPos
            // 
            this.headPos.AutoSize = true;
            this.headPos.Location = new System.Drawing.Point(13, 56);
            this.headPos.Name = "headPos";
            this.headPos.Size = new System.Drawing.Size(59, 13);
            this.headPos.TabIndex = 1;
            this.headPos.Text = "Head pos: ";
            // 
            // sideButton
            // 
            this.sideButton.Location = new System.Drawing.Point(147, 13);
            this.sideButton.Name = "sideButton";
            this.sideButton.Size = new System.Drawing.Size(125, 36);
            this.sideButton.TabIndex = 2;
            this.sideButton.Text = "Character side: Left";
            this.sideButton.UseVisualStyleBackColor = true;
            this.sideButton.Click += new System.EventHandler(this.sideButton_Click);
            // 
            // infoText
            // 
            this.infoText.Location = new System.Drawing.Point(13, 152);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(259, 62);
            this.infoText.TabIndex = 3;
            this.infoText.Text = resources.GetString("infoText.Text");
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.startButton.Location = new System.Drawing.Point(0, 217);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(284, 44);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.sideButton);
            this.Controls.Add(this.headPos);
            this.Controls.Add(this.headPositionSelectButton);
            this.Name = "GUI";
            this.Text = "LumberJacker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button headPositionSelectButton;
        private System.Windows.Forms.Label headPos;
        private System.Windows.Forms.Button sideButton;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button startButton;
    }
}

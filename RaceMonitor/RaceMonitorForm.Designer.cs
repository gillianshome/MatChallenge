namespace RaceMonitor
{
    partial class RaceMonitorForm
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.UpdateDisplayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DataTextBox
            // 
            this.DataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTextBox.Location = new System.Drawing.Point(94, 13);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(421, 20);
            this.DataTextBox.TabIndex = 1;
            // 
            // UpdateDisplayButton
            // 
            this.UpdateDisplayButton.Location = new System.Drawing.Point(13, 42);
            this.UpdateDisplayButton.Name = "UpdateDisplayButton";
            this.UpdateDisplayButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateDisplayButton.TabIndex = 2;
            this.UpdateDisplayButton.Text = "Update Display";
            this.UpdateDisplayButton.UseVisualStyleBackColor = true;
            this.UpdateDisplayButton.Click += new System.EventHandler(this.UpdateDisplayButton_Click);
            // 
            // RaceMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.UpdateDisplayButton);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Name = "RaceMonitorForm";
            this.Text = "Race Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Button UpdateDisplayButton;
    }
}


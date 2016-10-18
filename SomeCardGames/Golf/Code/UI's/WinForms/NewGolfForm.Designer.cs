namespace Golf.Code.UI_s.WinForms
{
    partial class NewGolfForm
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
			this.MainPanel = new System.Windows.Forms.Panel();
			this.AICountTBox = new System.Windows.Forms.TextBox();
			this.NumberOfAIsDescription = new System.Windows.Forms.TextBox();
			this.GameNameDescription = new System.Windows.Forms.TextBox();
			this.GameNameTextBox = new System.Windows.Forms.TextBox();
			this.MainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add(this.GameNameTextBox);
			this.MainPanel.Controls.Add(this.GameNameDescription);
			this.MainPanel.Controls.Add(this.AICountTBox);
			this.MainPanel.Controls.Add(this.NumberOfAIsDescription);
			this.MainPanel.Location = new System.Drawing.Point(13, 13);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(259, 236);
			this.MainPanel.TabIndex = 0;
			this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// AICountTBox
			// 
			this.AICountTBox.Location = new System.Drawing.Point(92, 42);
			this.AICountTBox.Name = "AICountTBox";
			this.AICountTBox.Size = new System.Drawing.Size(164, 20);
			this.AICountTBox.TabIndex = 1;
			this.AICountTBox.TextChanged += new System.EventHandler(this.AICountTBox_TextChanged);
			// 
			// NumberOfAIsDescription
			// 
			this.NumberOfAIsDescription.Location = new System.Drawing.Point(3, 42);
			this.NumberOfAIsDescription.Name = "NumberOfAIsDescription";
			this.NumberOfAIsDescription.ReadOnly = true;
			this.NumberOfAIsDescription.Size = new System.Drawing.Size(81, 20);
			this.NumberOfAIsDescription.TabIndex = 0;
			this.NumberOfAIsDescription.Text = "Number Of AI\'s:";
			// 
			// GameNameDescription
			// 
			this.GameNameDescription.Location = new System.Drawing.Point(3, 16);
			this.GameNameDescription.Name = "GameNameDescription";
			this.GameNameDescription.Size = new System.Drawing.Size(81, 20);
			this.GameNameDescription.TabIndex = 2;
			this.GameNameDescription.Text = "Game Name:";
			// 
			// GameNameTextBox
			// 
			this.GameNameTextBox.Location = new System.Drawing.Point(92, 16);
			this.GameNameTextBox.Name = "GameNameTextBox";
			this.GameNameTextBox.Size = new System.Drawing.Size(164, 20);
			this.GameNameTextBox.TabIndex = 3;
			this.GameNameTextBox.TextChanged += new System.EventHandler(this.GameNameTextBox_TextChanged);
			// 
			// NewGolfForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.MainPanel);
			this.Name = "NewGolfForm";
			this.Text = "NewGolfForm";
			this.Load += new System.EventHandler(this.NewGolfForm_Load);
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel MainPanel;
		private System.Windows.Forms.TextBox NumberOfAIsDescription;
		private System.Windows.Forms.TextBox AICountTBox;
		private System.Windows.Forms.TextBox GameNameDescription;
		private System.Windows.Forms.TextBox GameNameTextBox;
	}
}
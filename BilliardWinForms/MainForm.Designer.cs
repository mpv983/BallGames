namespace BilliardWinForms
{
    partial class MainForm
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
            leftLabel = new Label();
            rightLabel = new Label();
            topLabel = new Label();
            downLabel = new Label();
            SuspendLayout();
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Location = new Point(12, 195);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(13, 15);
            leftLabel.TabIndex = 0;
            leftLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Location = new Point(750, 195);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(13, 15);
            rightLabel.TabIndex = 0;
            rightLabel.Text = "0";
            rightLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Location = new Point(375, 9);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(13, 15);
            topLabel.TabIndex = 0;
            topLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Location = new Point(375, 426);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(13, 15);
            downLabel.TabIndex = 0;
            downLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downLabel);
            Controls.Add(topLabel);
            Controls.Add(rightLabel);
            Controls.Add(leftLabel);
            Name = "MainForm";
            Text = "Billiard";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel;
        private Label rightLabel;
        private Label topLabel;
        private Label downLabel;
    }
}

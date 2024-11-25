namespace CatchBallsWinForms
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
            startButton = new Button();
            ballsLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(407, 268);
            startButton.Margin = new Padding(4);
            startButton.Name = "startButton";
            startButton.Size = new Size(208, 92);
            startButton.TabIndex = 0;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // ballsLabel
            // 
            ballsLabel.AutoSize = true;
            ballsLabel.Location = new Point(21, 23);
            ballsLabel.Name = "ballsLabel";
            ballsLabel.Size = new Size(0, 21);
            ballsLabel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1029, 630);
            Controls.Add(ballsLabel);
            Controls.Add(startButton);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Form1";
            MouseClick += MainForm_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label ballsLabel;
    }
}

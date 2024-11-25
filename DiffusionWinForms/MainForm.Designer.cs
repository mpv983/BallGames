namespace DiffusionWinForms
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
            leftLabel_1 = new Label();
            rightLabel_1 = new Label();
            topLabel_1 = new Label();
            downLabel_1 = new Label();
            startButton = new Button();
            leftLabel_2 = new Label();
            topLabel_2 = new Label();
            downLabel_2 = new Label();
            rightLabel_2 = new Label();
            countLeftLabel_ball1 = new Label();
            countLeftLabel_ball2 = new Label();
            countRightLabel_ball1 = new Label();
            countRightLabel_ball2 = new Label();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // leftLabel_1
            // 
            leftLabel_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftLabel_1.AutoSize = true;
            leftLabel_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            leftLabel_1.Location = new Point(12, 195);
            leftLabel_1.Name = "leftLabel_1";
            leftLabel_1.Size = new Size(14, 15);
            leftLabel_1.TabIndex = 0;
            leftLabel_1.Text = "0";
            // 
            // rightLabel_1
            // 
            rightLabel_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightLabel_1.AutoSize = true;
            rightLabel_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rightLabel_1.Location = new Point(766, 195);
            rightLabel_1.Name = "rightLabel_1";
            rightLabel_1.Size = new Size(14, 15);
            rightLabel_1.TabIndex = 0;
            rightLabel_1.Text = "0";
            rightLabel_1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // topLabel_1
            // 
            topLabel_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topLabel_1.AutoSize = true;
            topLabel_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            topLabel_1.Location = new Point(332, 9);
            topLabel_1.Name = "topLabel_1";
            topLabel_1.Size = new Size(14, 15);
            topLabel_1.TabIndex = 0;
            topLabel_1.Text = "0";
            topLabel_1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // downLabel_1
            // 
            downLabel_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downLabel_1.AutoSize = true;
            downLabel_1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            downLabel_1.Location = new Point(418, 426);
            downLabel_1.Name = "downLabel_1";
            downLabel_1.Size = new Size(14, 15);
            downLabel_1.TabIndex = 0;
            downLabel_1.Text = "0";
            downLabel_1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(156, 28);
            startButton.TabIndex = 1;
            startButton.Text = "Запустить газ";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // leftLabel_2
            // 
            leftLabel_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftLabel_2.AutoSize = true;
            leftLabel_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            leftLabel_2.Location = new Point(12, 220);
            leftLabel_2.Name = "leftLabel_2";
            leftLabel_2.Size = new Size(14, 15);
            leftLabel_2.TabIndex = 0;
            leftLabel_2.Text = "0";
            // 
            // topLabel_2
            // 
            topLabel_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topLabel_2.AutoSize = true;
            topLabel_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            topLabel_2.Location = new Point(362, 9);
            topLabel_2.Name = "topLabel_2";
            topLabel_2.Size = new Size(14, 15);
            topLabel_2.TabIndex = 0;
            topLabel_2.Text = "0";
            // 
            // downLabel_2
            // 
            downLabel_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downLabel_2.AutoSize = true;
            downLabel_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            downLabel_2.Location = new Point(449, 426);
            downLabel_2.Name = "downLabel_2";
            downLabel_2.Size = new Size(14, 15);
            downLabel_2.TabIndex = 0;
            downLabel_2.Text = "0";
            // 
            // rightLabel_2
            // 
            rightLabel_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightLabel_2.AutoSize = true;
            rightLabel_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rightLabel_2.Location = new Point(766, 220);
            rightLabel_2.Name = "rightLabel_2";
            rightLabel_2.Size = new Size(14, 15);
            rightLabel_2.TabIndex = 0;
            rightLabel_2.Text = "0";
            rightLabel_2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // countLeftLabel_ball1
            // 
            countLeftLabel_ball1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            countLeftLabel_ball1.AutoSize = true;
            countLeftLabel_ball1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countLeftLabel_ball1.Location = new Point(329, 215);
            countLeftLabel_ball1.Name = "countLeftLabel_ball1";
            countLeftLabel_ball1.Size = new Size(14, 15);
            countLeftLabel_ball1.TabIndex = 0;
            countLeftLabel_ball1.Text = "0";
            countLeftLabel_ball1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // countLeftLabel_ball2
            // 
            countLeftLabel_ball2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            countLeftLabel_ball2.AutoSize = true;
            countLeftLabel_ball2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countLeftLabel_ball2.Location = new Point(359, 215);
            countLeftLabel_ball2.Name = "countLeftLabel_ball2";
            countLeftLabel_ball2.Size = new Size(14, 15);
            countLeftLabel_ball2.TabIndex = 0;
            countLeftLabel_ball2.Text = "0";
            // 
            // countRightLabel_ball1
            // 
            countRightLabel_ball1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            countRightLabel_ball1.AutoSize = true;
            countRightLabel_ball1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countRightLabel_ball1.Location = new Point(418, 215);
            countRightLabel_ball1.Name = "countRightLabel_ball1";
            countRightLabel_ball1.Size = new Size(14, 15);
            countRightLabel_ball1.TabIndex = 0;
            countRightLabel_ball1.Text = "0";
            countRightLabel_ball1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // countRightLabel_ball2
            // 
            countRightLabel_ball2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            countRightLabel_ball2.AutoSize = true;
            countRightLabel_ball2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countRightLabel_ball2.Location = new Point(448, 215);
            countRightLabel_ball2.Name = "countRightLabel_ball2";
            countRightLabel_ball2.Size = new Size(14, 15);
            countRightLabel_ball2.TabIndex = 0;
            countRightLabel_ball2.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(417, 195);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 0;
            label5.Text = "Кол-во:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(329, 195);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Кол-во:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startButton);
            Controls.Add(downLabel_2);
            Controls.Add(downLabel_1);
            Controls.Add(countRightLabel_ball2);
            Controls.Add(countLeftLabel_ball2);
            Controls.Add(topLabel_2);
            Controls.Add(countRightLabel_ball1);
            Controls.Add(countLeftLabel_ball1);
            Controls.Add(topLabel_1);
            Controls.Add(rightLabel_2);
            Controls.Add(rightLabel_1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(leftLabel_2);
            Controls.Add(leftLabel_1);
            Name = "MainForm";
            Text = "Billiard";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel_1;
        private Label rightLabel_1;
        private Label topLabel_1;
        private Label downLabel_1;
        private Button startButton;
        private Label leftLabel_2;
        private Label topLabel_2;
        private Label downLabel_2;
        private Label rightLabel_2;
        private Label countLeftLabel_ball1;
        private Label countLeftLabel_ball2;
        private Label countRightLabel_ball1;
        private Label countRightLabel_ball2;
        private Label label5;
        private Label label1;
    }
}

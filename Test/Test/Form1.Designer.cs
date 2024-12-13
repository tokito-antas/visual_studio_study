namespace Test
{
    partial class Form1
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
            input1TextBox = new TextBox();
            plusLabel = new Label();
            input2TextBox = new TextBox();
            equalLabel = new Label();
            answerTextBox = new TextBox();
            CalcButton = new Button();
            SuspendLayout();
            // 
            // input1TextBox
            // 
            input1TextBox.Location = new Point(12, 12);
            input1TextBox.Name = "input1TextBox";
            input1TextBox.Size = new Size(125, 27);
            input1TextBox.TabIndex = 0;
            // 
            // plusLabel
            // 
            plusLabel.AutoSize = true;
            plusLabel.Location = new Point(143, 15);
            plusLabel.Name = "plusLabel";
            plusLabel.Size = new Size(19, 20);
            plusLabel.TabIndex = 1;
            plusLabel.Text = "+";
            // 
            // input2TextBox
            // 
            input2TextBox.Location = new Point(168, 12);
            input2TextBox.Name = "input2TextBox";
            input2TextBox.Size = new Size(125, 27);
            input2TextBox.TabIndex = 2;
            // 
            // equalLabel
            // 
            equalLabel.AutoSize = true;
            equalLabel.Location = new Point(299, 15);
            equalLabel.Name = "equalLabel";
            equalLabel.Size = new Size(19, 20);
            equalLabel.TabIndex = 3;
            equalLabel.Text = "=";
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(324, 12);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(125, 27);
            answerTextBox.TabIndex = 4;
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(12, 45);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(437, 29);
            CalcButton.TabIndex = 5;
            CalcButton.Text = "計算する";
            CalcButton.UseVisualStyleBackColor = true;
            CalcButton.Click += CalcButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 90);
            Controls.Add(CalcButton);
            Controls.Add(answerTextBox);
            Controls.Add(equalLabel);
            Controls.Add(input2TextBox);
            Controls.Add(plusLabel);
            Controls.Add(input1TextBox);
            Name = "Form1";
            Text = "簡単計算プログラム";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input1TextBox;
        private Label plusLabel;
        private TextBox input2TextBox;
        private Label equalLabel;
        private TextBox answerTextBox;
        private Button CalcButton;
    }
}

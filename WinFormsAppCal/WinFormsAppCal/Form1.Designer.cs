namespace WinFormsAppCal
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
            label1 = new Label();
            label2 = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            label3 = new Label();
            txtResult = new TextBox();
            radioPlus = new RadioButton();
            radioMinus = new RadioButton();
            radioTimes = new RadioButton();
            radioDiv = new RadioButton();
            btnCal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(137, 166);
            label1.Name = "label1";
            label1.Size = new Size(68, 50);
            label1.TabIndex = 0;
            label1.Text = "X :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(137, 275);
            label2.Name = "label2";
            label2.Size = new Size(67, 50);
            label2.TabIndex = 1;
            label2.Text = "Y :";
            // 
            // txtX
            // 
            txtX.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtX.Location = new Point(227, 163);
            txtX.Name = "txtX";
            txtX.Size = new Size(287, 58);
            txtX.TabIndex = 2;
            // 
            // txtY
            // 
            txtY.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtY.Location = new Point(227, 272);
            txtY.Name = "txtY";
            txtY.Size = new Size(287, 58);
            txtY.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(43, 427);
            label3.Name = "label3";
            label3.Size = new Size(162, 50);
            label3.TabIndex = 4;
            label3.Text = "Result :";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtResult.Location = new Point(227, 424);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(287, 58);
            txtResult.TabIndex = 5;
            // 
            // radioPlus
            // 
            radioPlus.AutoSize = true;
            radioPlus.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            radioPlus.Location = new Point(573, 166);
            radioPlus.Name = "radioPlus";
            radioPlus.Size = new Size(104, 45);
            radioPlus.TabIndex = 6;
            radioPlus.TabStop = true;
            radioPlus.Text = "Plus";
            radioPlus.UseVisualStyleBackColor = true;
            // 
            // radioMinus
            // 
            radioMinus.AutoSize = true;
            radioMinus.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            radioMinus.Location = new Point(573, 217);
            radioMinus.Name = "radioMinus";
            radioMinus.Size = new Size(135, 45);
            radioMinus.TabIndex = 7;
            radioMinus.TabStop = true;
            radioMinus.Text = "Minus";
            radioMinus.UseVisualStyleBackColor = true;
            // 
            // radioTimes
            // 
            radioTimes.AutoSize = true;
            radioTimes.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            radioTimes.Location = new Point(573, 268);
            radioTimes.Name = "radioTimes";
            radioTimes.Size = new Size(132, 45);
            radioTimes.TabIndex = 8;
            radioTimes.TabStop = true;
            radioTimes.Text = "Times";
            radioTimes.UseVisualStyleBackColor = true;
            // 
            // radioDiv
            // 
            radioDiv.AutoSize = true;
            radioDiv.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            radioDiv.Location = new Point(573, 319);
            radioDiv.Name = "radioDiv";
            radioDiv.Size = new Size(157, 45);
            radioDiv.TabIndex = 9;
            radioDiv.TabStop = true;
            radioDiv.Text = "Divided";
            radioDiv.UseVisualStyleBackColor = true;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnCal.Location = new Point(573, 578);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(165, 62);
            btnCal.TabIndex = 10;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 679);
            Controls.Add(btnCal);
            Controls.Add(radioDiv);
            Controls.Add(radioTimes);
            Controls.Add(radioMinus);
            Controls.Add(radioPlus);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtX;
        private TextBox txtY;
        private Label label3;
        private TextBox txtResult;
        private RadioButton radioPlus;
        private RadioButton radioMinus;
        private RadioButton radioTimes;
        private RadioButton radioDiv;
        private Button btnCal;
    }
}

namespace WinFormsDBTest1
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
            btnCnState = new Button();
            rtbShow = new RichTextBox();
            SuspendLayout();
            // 
            // btnCnState
            // 
            btnCnState.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnCnState.Location = new Point(12, 23);
            btnCnState.Name = "btnCnState";
            btnCnState.Size = new Size(219, 77);
            btnCnState.TabIndex = 0;
            btnCnState.Text = "連線";
            btnCnState.UseVisualStyleBackColor = true;
            btnCnState.Click += btnCnState_Click;
            // 
            // rtbShow
            // 
            rtbShow.Location = new Point(12, 132);
            rtbShow.Name = "rtbShow";
            rtbShow.Size = new Size(877, 363);
            rtbShow.TabIndex = 1;
            rtbShow.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 507);
            Controls.Add(rtbShow);
            Controls.Add(btnCnState);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCnState;
        private RichTextBox rtbShow;
    }
}

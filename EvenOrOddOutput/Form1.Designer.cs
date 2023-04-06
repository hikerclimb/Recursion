namespace EvenOrOddOutput
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
            BtnEvenOrOdd = new Button();
            SuspendLayout();
            // 
            // BtnEvenOrOdd
            // 
            BtnEvenOrOdd.Location = new Point(70, 82);
            BtnEvenOrOdd.Name = "BtnEvenOrOdd";
            BtnEvenOrOdd.Size = new Size(142, 29);
            BtnEvenOrOdd.TabIndex = 0;
            BtnEvenOrOdd.Text = "EvenOrOdd";
            BtnEvenOrOdd.UseVisualStyleBackColor = true;
            BtnEvenOrOdd.Click += BtnEvenOrOdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEvenOrOdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnEvenOrOdd;
    }
}
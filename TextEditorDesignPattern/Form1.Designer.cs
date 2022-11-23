
namespace TextEditorDesignPattern
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
            this.convertAsciiButton = new System.Windows.Forms.Button();
            this.convertTeXButton = new System.Windows.Forms.Button();
            this.convertHTMLButton = new System.Windows.Forms.Button();
            this.textDisplay = new System.Windows.Forms.Label();
            this.boldButton = new System.Windows.Forms.CheckBox();
            this.italicButton = new System.Windows.Forms.CheckBox();
            this.fontText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertAsciiButton
            // 
            this.convertAsciiButton.Location = new System.Drawing.Point(51, 384);
            this.convertAsciiButton.Name = "convertAsciiButton";
            this.convertAsciiButton.Size = new System.Drawing.Size(152, 29);
            this.convertAsciiButton.TabIndex = 0;
            this.convertAsciiButton.Text = "Convert ascii";
            this.convertAsciiButton.UseVisualStyleBackColor = true;
            this.convertAsciiButton.Click += new System.EventHandler(this.convertAsciiButton_Click);
            // 
            // convertTeXButton
            // 
            this.convertTeXButton.Location = new System.Drawing.Point(331, 384);
            this.convertTeXButton.Name = "convertTeXButton";
            this.convertTeXButton.Size = new System.Drawing.Size(149, 29);
            this.convertTeXButton.TabIndex = 1;
            this.convertTeXButton.Text = "Convert TeX";
            this.convertTeXButton.UseVisualStyleBackColor = true;
            this.convertTeXButton.Click += new System.EventHandler(this.convertTeXButton_Click);
            // 
            // convertHTMLButton
            // 
            this.convertHTMLButton.Location = new System.Drawing.Point(587, 384);
            this.convertHTMLButton.Name = "convertHTMLButton";
            this.convertHTMLButton.Size = new System.Drawing.Size(167, 29);
            this.convertHTMLButton.TabIndex = 2;
            this.convertHTMLButton.Text = "Convert HTML \r\n";
            this.convertHTMLButton.UseVisualStyleBackColor = true;
            this.convertHTMLButton.Click += new System.EventHandler(this.convertHTMLButton_Click);
            // 
            // textDisplay
            // 
            this.textDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDisplay.Location = new System.Drawing.Point(0, 0);
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(800, 135);
            this.textDisplay.TabIndex = 3;
            this.textDisplay.Text = "Test design pattern";
            this.textDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boldButton
            // 
            this.boldButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.boldButton.AutoSize = true;
            this.boldButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boldButton.Location = new System.Drawing.Point(331, 312);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(29, 30);
            this.boldButton.TabIndex = 6;
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = true;
            // 
            // italicButton
            // 
            this.italicButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.italicButton.AutoSize = true;
            this.italicButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italicButton.Location = new System.Drawing.Point(457, 312);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(23, 30);
            this.italicButton.TabIndex = 7;
            this.italicButton.Text = "I";
            this.italicButton.UseVisualStyleBackColor = true;
            // 
            // fontText
            // 
            this.fontText.Location = new System.Drawing.Point(485, 233);
            this.fontText.Name = "fontText";
            this.fontText.Size = new System.Drawing.Size(269, 27);
            this.fontText.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Font";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Text";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(117, 233);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(269, 27);
            this.inputText.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fontText);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.textDisplay);
            this.Controls.Add(this.convertHTMLButton);
            this.Controls.Add(this.convertTeXButton);
            this.Controls.Add(this.convertAsciiButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertAsciiButton;
        private System.Windows.Forms.Button convertTeXButton;
        private System.Windows.Forms.Button convertHTMLButton;
        private System.Windows.Forms.Label textDisplay;
        private System.Windows.Forms.CheckBox boldButton;
        private System.Windows.Forms.CheckBox italicButton;
        private System.Windows.Forms.TextBox fontText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button backButton;
    }
}


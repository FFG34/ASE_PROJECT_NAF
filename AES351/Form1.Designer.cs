﻿namespace AES351
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
            runButton = new Button();
            syntaxButton = new Button();
            codeTextBox = new TextBox();
            commandTextBox = new TextBox();
            displayArea = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)displayArea).BeginInit();
            SuspendLayout();
            // 
            // runButton
            // 
            runButton.Location = new Point(273, 587);
            runButton.Name = "runButton";
            runButton.Size = new Size(75, 39);
            runButton.TabIndex = 0;
            runButton.Text = "Run";
            runButton.Click += click_RunButton;
            // 
            // syntaxButton
            // 
            syntaxButton.Location = new Point(685, 587);
            syntaxButton.Name = "syntaxButton";
            syntaxButton.Size = new Size(75, 39);
            syntaxButton.TabIndex = 1;
            syntaxButton.Text = "Syntax";
            syntaxButton.Click += click_SyntaxButton;
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(10, 10);
            codeTextBox.Multiline = true;
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(481, 439);
            codeTextBox.TabIndex = 2;
            // 
            // commandTextBox
            // 
            commandTextBox.Location = new Point(10, 503);
            commandTextBox.Multiline = true;
            commandTextBox.Name = "commandTextBox";
            commandTextBox.Size = new Size(980, 30);
            commandTextBox.TabIndex = 3;
            commandTextBox.TextChanged += text_CommandTextBox;
            // 
            // displayArea
            // 
            displayArea.BackColor = Color.Gray;
            displayArea.BorderStyle = BorderStyle.FixedSingle;
            displayArea.Location = new Point(497, 10);
            displayArea.Name = "displayArea";
            displayArea.Size = new Size(495, 439);
            displayArea.TabIndex = 4;
            displayArea.TabStop = false;
            displayArea.Click += click_Display;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 638);
            Controls.Add(runButton);
            Controls.Add(syntaxButton);
            Controls.Add(codeTextBox);
            Controls.Add(commandTextBox);
            Controls.Add(displayArea);
            Name = "Form1";
            Text = "Simple Coding Language";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)displayArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button syntaxButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.PictureBox displayArea;

        #endregion
    }
}

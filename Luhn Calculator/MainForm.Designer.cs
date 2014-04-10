namespace Luhn_Calculator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.checkDigitLabel = new System.Windows.Forms.Label();
            this.clipboardButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(39, 110);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(96, 36);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(328, 110);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 36);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(193, 162);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(87, 33);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(198, 69);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(76, 25);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTextbox
            // 
            this.inputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.Location = new System.Drawing.Point(120, 22);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(219, 29);
            this.inputTextbox.TabIndex = 6;
            this.inputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextbox_KeyPress);
            // 
            // testLabel
            // 
            this.testLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.Location = new System.Drawing.Point(440, 78);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(54, 25);
            this.testLabel.TabIndex = 5;
            this.testLabel.Text = "Test";
            this.testLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(153, 110);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(159, 36);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next Check Digit";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // checkDigitLabel
            // 
            this.checkDigitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkDigitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.checkDigitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDigitLabel.Location = new System.Drawing.Point(358, 22);
            this.checkDigitLabel.Name = "checkDigitLabel";
            this.checkDigitLabel.Size = new System.Drawing.Size(43, 29);
            this.checkDigitLabel.TabIndex = 8;
            this.checkDigitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkDigitLabel.UseMnemonic = false;
            // 
            // clipboardButton
            // 
            this.clipboardButton.Image = global::Luhn_Calculator.Properties.Resources.Clipboard;
            this.clipboardButton.Location = new System.Drawing.Point(436, 22);
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.Size = new System.Drawing.Size(37, 29);
            this.clipboardButton.TabIndex = 9;
            this.toolTip.SetToolTip(this.clipboardButton, "Copy the current number to the clipboard");
            this.clipboardButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(542, 210);
            this.Controls.Add(this.clipboardButton);
            this.Controls.Add(this.checkDigitLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.checkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luhn Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label checkDigitLabel;
        private System.Windows.Forms.Button clipboardButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}


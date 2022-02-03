
namespace Calculator
{
    partial class Calculator
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.squareRootButton = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.percentageButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.closedParentheses = new System.Windows.Forms.Button();
            this.openParentheses = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.equalTo = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultBox.Location = new System.Drawing.Point(13, 13);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultBox.Size = new System.Drawing.Size(266, 33);
            this.resultBox.TabIndex = 0;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // squareRootButton
            // 
            this.squareRootButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.squareRootButton.Location = new System.Drawing.Point(13, 52);
            this.squareRootButton.Name = "squareRootButton";
            this.squareRootButton.Size = new System.Drawing.Size(62, 45);
            this.squareRootButton.TabIndex = 1;
            this.squareRootButton.Text = "sqr()";
            this.squareRootButton.UseVisualStyleBackColor = true;
            this.squareRootButton.Click += new System.EventHandler(this.squareRootButton_Click);
            // 
            // exponent
            // 
            this.exponent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exponent.Location = new System.Drawing.Point(81, 52);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(62, 45);
            this.exponent.TabIndex = 2;
            this.exponent.Text = "x^2";
            this.exponent.UseVisualStyleBackColor = true;
            this.exponent.Click += new System.EventHandler(this.exponent_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(81, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 45);
            this.button8.TabIndex = 3;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplyButton.Location = new System.Drawing.Point(217, 157);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(62, 45);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divideButton.Location = new System.Drawing.Point(217, 106);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(62, 45);
            this.divideButton.TabIndex = 5;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // percentageButton
            // 
            this.percentageButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentageButton.Location = new System.Drawing.Point(149, 106);
            this.percentageButton.Name = "percentageButton";
            this.percentageButton.Size = new System.Drawing.Size(62, 45);
            this.percentageButton.TabIndex = 6;
            this.percentageButton.Text = "%";
            this.percentageButton.UseVisualStyleBackColor = true;
            this.percentageButton.Click += new System.EventHandler(this.percentageButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(13, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // closedParentheses
            // 
            this.closedParentheses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closedParentheses.Location = new System.Drawing.Point(81, 106);
            this.closedParentheses.Name = "closedParentheses";
            this.closedParentheses.Size = new System.Drawing.Size(62, 45);
            this.closedParentheses.TabIndex = 8;
            this.closedParentheses.Text = ")";
            this.closedParentheses.UseVisualStyleBackColor = true;
            this.closedParentheses.Click += new System.EventHandler(this.closedParentheses_Click);
            // 
            // openParentheses
            // 
            this.openParentheses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openParentheses.Location = new System.Drawing.Point(13, 106);
            this.openParentheses.Name = "openParentheses";
            this.openParentheses.Size = new System.Drawing.Size(62, 45);
            this.openParentheses.TabIndex = 9;
            this.openParentheses.Text = "(";
            this.openParentheses.UseVisualStyleBackColor = true;
            this.openParentheses.Click += new System.EventHandler(this.openParentheses_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(217, 52);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(62, 45);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "D";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cleanButton.Location = new System.Drawing.Point(149, 52);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(62, 45);
            this.cleanButton.TabIndex = 11;
            this.cleanButton.Text = "C";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(149, 157);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 45);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtractButton.Location = new System.Drawing.Point(217, 208);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(62, 45);
            this.subtractButton.TabIndex = 13;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(149, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 45);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(13, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 45);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(13, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(217, 259);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 45);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(149, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 45);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(81, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 45);
            this.button2.TabIndex = 20;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(13, 310);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(130, 45);
            this.button0.TabIndex = 21;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // equalTo
            // 
            this.equalTo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalTo.Location = new System.Drawing.Point(217, 310);
            this.equalTo.Name = "equalTo";
            this.equalTo.Size = new System.Drawing.Size(62, 45);
            this.equalTo.TabIndex = 22;
            this.equalTo.Text = "=";
            this.equalTo.UseVisualStyleBackColor = true;
            this.equalTo.Click += new System.EventHandler(this.equalTo_Click);
            // 
            // dotButton
            // 
            this.dotButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dotButton.Location = new System.Drawing.Point(149, 312);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(62, 45);
            this.dotButton.TabIndex = 23;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(81, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 45);
            this.button5.TabIndex = 24;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 369);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.equalTo);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openParentheses);
            this.Controls.Add(this.closedParentheses);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.percentageButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.squareRootButton);
            this.Controls.Add(this.resultBox);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button squareRootButton;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button percentageButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button closedParentheses;
        private System.Windows.Forms.Button openParentheses;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button equalTo;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button button5;
    }
}



namespace StringCalculator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.concatStringClipboardLabel = new System.Windows.Forms.Label();
            this.clearConcatButton = new System.Windows.Forms.Button();
            this.concatButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.string2TextBox = new System.Windows.Forms.TextBox();
            this.string1TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.compareButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Controls.Add(this.concatStringClipboardLabel);
            this.groupBox1.Controls.Add(this.clearConcatButton);
            this.groupBox1.Controls.Add(this.concatButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.string2TextBox);
            this.groupBox1.Controls.Add(this.string1TextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // compareButton
            // 
            this.compareButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.compareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareButton.Location = new System.Drawing.Point(226, 223);
            this.compareButton.Margin = new System.Windows.Forms.Padding(4);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(121, 33);
            this.compareButton.TabIndex = 3;
            this.compareButton.Text = "Compare (F6)";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "*String REVERSE and PALLINDROE CHECK will be carried on String1 input box";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result :";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultTextBox.Location = new System.Drawing.Point(106, 161);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(233, 24);
            this.resultTextBox.TabIndex = 7;
            // 
            // concatStringClipboardLabel
            // 
            this.concatStringClipboardLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.concatStringClipboardLabel.AutoSize = true;
            this.concatStringClipboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concatStringClipboardLabel.ForeColor = System.Drawing.Color.Navy;
            this.concatStringClipboardLabel.Location = new System.Drawing.Point(103, 191);
            this.concatStringClipboardLabel.Name = "concatStringClipboardLabel";
            this.concatStringClipboardLabel.Size = new System.Drawing.Size(228, 15);
            this.concatStringClipboardLabel.TabIndex = 6;
            this.concatStringClipboardLabel.Text = "*Concatenated string copied to clipboard";
            this.concatStringClipboardLabel.Visible = false;
            this.concatStringClipboardLabel.Click += new System.EventHandler(this.concatStringClipboardLabel_Click);
            // 
            // clearConcatButton
            // 
            this.clearConcatButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearConcatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearConcatButton.Location = new System.Drawing.Point(160, 305);
            this.clearConcatButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearConcatButton.Name = "clearConcatButton";
            this.clearConcatButton.Size = new System.Drawing.Size(123, 33);
            this.clearConcatButton.TabIndex = 6;
            this.clearConcatButton.Text = "Clear (F10)";
            this.clearConcatButton.UseVisualStyleBackColor = true;
            this.clearConcatButton.Click += new System.EventHandler(this.clearConcatButton_Click);
            // 
            // concatButton
            // 
            this.concatButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.concatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concatButton.Location = new System.Drawing.Point(95, 223);
            this.concatButton.Margin = new System.Windows.Forms.Padding(4);
            this.concatButton.Name = "concatButton";
            this.concatButton.Size = new System.Drawing.Size(121, 33);
            this.concatButton.TabIndex = 2;
            this.concatButton.Text = "Concat  (F5)";
            this.concatButton.UseVisualStyleBackColor = true;
            this.concatButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "String 2 :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "String 1 :";
            // 
            // string2TextBox
            // 
            this.string2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.string2TextBox.Location = new System.Drawing.Point(106, 109);
            this.string2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.string2TextBox.Name = "string2TextBox";
            this.string2TextBox.Size = new System.Drawing.Size(233, 24);
            this.string2TextBox.TabIndex = 1;
            // 
            // string1TextBox
            // 
            this.string1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.string1TextBox.Location = new System.Drawing.Point(106, 51);
            this.string1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.string1TextBox.Name = "string1TextBox";
            this.string1TextBox.Size = new System.Drawing.Size(233, 24);
            this.string1TextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(226, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reverse (F8)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(95, 264);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pallindrome? (F7)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(476, 488);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label concatStringClipboardLabel;
        private System.Windows.Forms.Button clearConcatButton;
        private System.Windows.Forms.Button concatButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox string2TextBox;
        private System.Windows.Forms.TextBox string1TextBox;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


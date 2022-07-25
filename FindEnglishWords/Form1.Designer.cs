namespace FindEnglishWords
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.textTurkish = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "English :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turkish :";
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(87, 21);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(153, 26);
            this.textEnglish.TabIndex = 10;
            // 
            // textTurkish
            // 
            this.textTurkish.Location = new System.Drawing.Point(87, 67);
            this.textTurkish.Name = "textTurkish";
            this.textTurkish.Size = new System.Drawing.Size(153, 26);
            this.textTurkish.TabIndex = 1;
            this.textTurkish.TextChanged += new System.EventHandler(this.textTurkish_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(285, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 18);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time :";
            // 
            // timer1
            // 
            this.timer1.AutoSize = true;
            this.timer1.Location = new System.Drawing.Point(345, 24);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(27, 18);
            this.timer1.TabIndex = 5;
            this.timer1.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(285, 70);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(56, 18);
            this.lblWord.TabIndex = 6;
            this.lblWord.Text = "Word :";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(214, 125);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(71, 18);
            this.lblAnswer.TabIndex = 8;
            this.lblAnswer.Text = "Answer :";
            this.lblAnswer.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 152);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.textTurkish);
            this.Controls.Add(this.textEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEnglish;
        private System.Windows.Forms.TextBox textTurkish;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Timer timer2;
    }
}


namespace Viktorina
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
            this.Answer1 = new System.Windows.Forms.TextBox();
            this.Answer2 = new System.Windows.Forms.TextBox();
            this.Answer3 = new System.Windows.Forms.TextBox();
            this.Answer4 = new System.Windows.Forms.TextBox();
            this.Answer5 = new System.Windows.Forms.TextBox();
            this.quiz1 = new System.Windows.Forms.Label();
            this.quiz2 = new System.Windows.Forms.Label();
            this.quiz3 = new System.Windows.Forms.Label();
            this.quiz4 = new System.Windows.Forms.Label();
            this.quiz5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AllAnswer = new System.Windows.Forms.Button();
            this.AnswerLay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Answer1
            // 
            this.Answer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Answer1.Location = new System.Drawing.Point(595, 40);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(100, 22);
            this.Answer1.TabIndex = 0;
            this.Answer1.TextChanged += new System.EventHandler(this.Answer1_TextChanged);
            // 
            // Answer2
            // 
            this.Answer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Answer2.Location = new System.Drawing.Point(595, 74);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(100, 22);
            this.Answer2.TabIndex = 0;
            this.Answer2.TextChanged += new System.EventHandler(this.Answer2_TextChanged);
            // 
            // Answer3
            // 
            this.Answer3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Answer3.Location = new System.Drawing.Point(595, 111);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(100, 22);
            this.Answer3.TabIndex = 0;
            this.Answer3.TextChanged += new System.EventHandler(this.Answer3_TextChanged);
            // 
            // Answer4
            // 
            this.Answer4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Answer4.Location = new System.Drawing.Point(595, 150);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(100, 22);
            this.Answer4.TabIndex = 0;
            this.Answer4.TextChanged += new System.EventHandler(this.Answer4_TextChanged);
            // 
            // Answer5
            // 
            this.Answer5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Answer5.Location = new System.Drawing.Point(595, 186);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(100, 22);
            this.Answer5.TabIndex = 0;
            this.Answer5.TextChanged += new System.EventHandler(this.Answer5_TextChanged);
            // 
            // quiz1
            // 
            this.quiz1.AutoSize = true;
            this.quiz1.Location = new System.Drawing.Point(12, 40);
            this.quiz1.Name = "quiz1";
            this.quiz1.Size = new System.Drawing.Size(163, 16);
            this.quiz1.TabIndex = 1;
            this.quiz1.Text = "Сколько месцев в году?";
            // 
            // quiz2
            // 
            this.quiz2.AutoSize = true;
            this.quiz2.Location = new System.Drawing.Point(14, 74);
            this.quiz2.Name = "quiz2";
            this.quiz2.Size = new System.Drawing.Size(241, 16);
            this.quiz2.TabIndex = 1;
            this.quiz2.Text = "Где находится Эйфейелева башня? ";
            // 
            // quiz3
            // 
            this.quiz3.AutoSize = true;
            this.quiz3.Location = new System.Drawing.Point(12, 114);
            this.quiz3.Name = "quiz3";
            this.quiz3.Size = new System.Drawing.Size(407, 16);
            this.quiz3.TabIndex = 1;
            this.quiz3.Text = "Название самой известной металл-группы? (На английском)";
            // 
            // quiz4
            // 
            this.quiz4.AutoSize = true;
            this.quiz4.Location = new System.Drawing.Point(12, 192);
            this.quiz4.Name = "quiz4";
            this.quiz4.Size = new System.Drawing.Size(556, 16);
            this.quiz4.TabIndex = 1;
            this.quiz4.Text = "Утренний популярный тонизирующийся напиток делающийся из листьев растения?";
            this.quiz4.Click += new System.EventHandler(this.quiz4_Click);
            // 
            // quiz5
            // 
            this.quiz5.AutoSize = true;
            this.quiz5.Location = new System.Drawing.Point(12, 153);
            this.quiz5.Name = "quiz5";
            this.quiz5.Size = new System.Drawing.Size(185, 16);
            this.quiz5.TabIndex = 1;
            this.quiz5.Text = "Известный электромобиль";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(700, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(701, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Проверить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(701, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Проверить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(700, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Проверить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(701, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 31);
            this.button5.TabIndex = 2;
            this.button5.Text = "Проверить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AllAnswer
            // 
            this.AllAnswer.Location = new System.Drawing.Point(17, 229);
            this.AllAnswer.Name = "AllAnswer";
            this.AllAnswer.Size = new System.Drawing.Size(158, 23);
            this.AllAnswer.TabIndex = 3;
            this.AllAnswer.Text = "Подсчет очков";
            this.AllAnswer.UseVisualStyleBackColor = true;
            this.AllAnswer.Click += new System.EventHandler(this.AllAnswer_Click);
            // 
            // AnswerLay
            // 
            this.AnswerLay.AutoSize = true;
            this.AnswerLay.Location = new System.Drawing.Point(193, 229);
            this.AnswerLay.Name = "AnswerLay";
            this.AnswerLay.Size = new System.Drawing.Size(0, 16);
            this.AnswerLay.TabIndex = 4;
            this.AnswerLay.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 264);
            this.Controls.Add(this.AnswerLay);
            this.Controls.Add(this.AllAnswer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quiz5);
            this.Controls.Add(this.quiz4);
            this.Controls.Add(this.quiz3);
            this.Controls.Add(this.quiz2);
            this.Controls.Add(this.quiz1);
            this.Controls.Add(this.Answer5);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.MinimumSize = new System.Drawing.Size(820, 311);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Answer1;
        private System.Windows.Forms.TextBox Answer2;
        private System.Windows.Forms.TextBox Answer3;
        private System.Windows.Forms.TextBox Answer4;
        private System.Windows.Forms.TextBox Answer5;
        private System.Windows.Forms.Label quiz1;
        private System.Windows.Forms.Label quiz2;
        private System.Windows.Forms.Label quiz3;
        private System.Windows.Forms.Label quiz4;
        private System.Windows.Forms.Label quiz5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AllAnswer;
        private System.Windows.Forms.Label AnswerLay;
    }
}


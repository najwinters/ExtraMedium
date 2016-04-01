namespace DiatonicOctopotato
{
    partial class MultiplyChoice
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuestion.Location = new System.Drawing.Point(74, 176);
            this.lblQuestion.MinimumSize = new System.Drawing.Size(150, 100);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(150, 100);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(364, 73);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(161, 67);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "Answer1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(364, 154);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(161, 67);
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Text = "Answer2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(364, 241);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(161, 67);
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Text = "Answer3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(364, 327);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(161, 67);
            this.btnAnswer4.TabIndex = 4;
            this.btnAnswer4.Text = "Answer4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(187, 440);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(79, 22);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Answers";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(12, 30);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(134, 56);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // MultiplyChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 513);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "MultiplyChoice";
            this.Text = "MultiplyChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnStartGame;
    }
}

namespace NumberGuess
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
            this.labelRange = new System.Windows.Forms.Label();
            this.labelClose1 = new System.Windows.Forms.Label();
            this.textNumberGuess1 = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCloser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(65, 65);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(92, 13);
            this.labelRange.TabIndex = 0;
            this.labelRange.Text = "Guessed Number:";
            // 
            // labelClose1
            // 
            this.labelClose1.AutoSize = true;
            this.labelClose1.Location = new System.Drawing.Point(157, 19);
            this.labelClose1.Name = "labelClose1";
            this.labelClose1.Size = new System.Drawing.Size(0, 13);
            this.labelClose1.TabIndex = 1;
            // 
            // textNumberGuess1
            // 
            this.textNumberGuess1.Location = new System.Drawing.Point(175, 58);
            this.textNumberGuess1.Name = "textNumberGuess1";
            this.textNumberGuess1.Size = new System.Drawing.Size(100, 20);
            this.textNumberGuess1.TabIndex = 2;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(126, 103);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(89, 22);
            this.buttonGuess.TabIndex = 3;
            this.buttonGuess.Text = "Submit Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(126, 149);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(87, 23);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "How to Play:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "1: Enter a number from 1-1000 in the text box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "2: If you\'re wrong, the text box will turn red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "3: If you\'re getting closer the text box will turn blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "4: If you\'re correct the text box will turn green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "5: To get a new number press New Game";
            // 
            // labelCloser
            // 
            this.labelCloser.AutoSize = true;
            this.labelCloser.Location = new System.Drawing.Point(213, 19);
            this.labelCloser.Name = "labelCloser";
            this.labelCloser.Size = new System.Drawing.Size(0, 13);
            this.labelCloser.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 369);
            this.Controls.Add(this.labelCloser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textNumberGuess1);
            this.Controls.Add(this.labelClose1);
            this.Controls.Add(this.labelRange);
            this.Name = "Form1";
            this.Text = "Number Guessing Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelClose1;
        private System.Windows.Forms.TextBox textNumberGuess1;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCloser;
    }
}


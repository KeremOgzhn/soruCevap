﻿namespace soruCevapPro
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(148, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sınav Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(148, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kişi Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(148, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Soru Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(148, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kişiler";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(148, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sorular";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(148, 464);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "Sonuçlar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 581);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORU-CEVAP UYGULAMASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}


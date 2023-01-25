using System;

namespace Flappy
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
            this.P_3 = new System.Windows.Forms.PictureBox();
            this.P_2 = new System.Windows.Forms.PictureBox();
            this.P_1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_1)).BeginInit();
            this.SuspendLayout();
            // 
            // P_3
            // 
            this.P_3.Image = global::Flappy.Properties.Resources.Bird__1_;
            this.P_3.Location = new System.Drawing.Point(569, 209);
            this.P_3.Name = "P_3";
            this.P_3.Size = new System.Drawing.Size(112, 112);
            this.P_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.P_3.TabIndex = 2;
            this.P_3.TabStop = false;
            this.P_3.Click += new System.EventHandler(this.P_3_Click);
            // 
            // P_2
            // 
            this.P_2.Image = global::Flappy.Properties.Resources.Bird__1_;
            this.P_2.Location = new System.Drawing.Point(327, 66);
            this.P_2.Name = "P_2";
            this.P_2.Size = new System.Drawing.Size(112, 112);
            this.P_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.P_2.TabIndex = 1;
            this.P_2.TabStop = false;
            this.P_2.Click += new System.EventHandler(this.P_2_Click);
            // 
            // P_1
            // 
            this.P_1.Image = global::Flappy.Properties.Resources.Bird__1_;
            this.P_1.Location = new System.Drawing.Point(87, 329);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(112, 112);
            this.P_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.P_1.TabIndex = 0;
            this.P_1.TabStop = false;
            this.P_1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Killed: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_3);
            this.Controls.Add(this.P_2);
            this.Controls.Add(this.P_1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.PictureBox P_1;
        private System.Windows.Forms.PictureBox P_2;
        private System.Windows.Forms.PictureBox P_3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}


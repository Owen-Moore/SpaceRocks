
namespace SpaceRocks
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.youloseText = new System.Windows.Forms.Label();
            this.waveTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // youloseText
            // 
            this.youloseText.BackColor = System.Drawing.Color.Transparent;
            this.youloseText.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youloseText.ForeColor = System.Drawing.Color.White;
            this.youloseText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.youloseText.Location = new System.Drawing.Point(2, 0);
            this.youloseText.Name = "youloseText";
            this.youloseText.Size = new System.Drawing.Size(1255, 588);
            this.youloseText.TabIndex = 0;
            this.youloseText.Text = "Best played with biggest window possible";
            this.youloseText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // waveTimer
            // 
            this.waveTimer.Enabled = true;
            this.waveTimer.Interval = 1000;
            this.waveTimer.Tick += new System.EventHandler(this.waveTimer_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1730, 910);
            this.Controls.Add(this.youloseText);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label youloseText;
        private System.Windows.Forms.Timer waveTimer;
    }
}


using System;

namespace ping_pong_app_solution
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.plate2 = new System.Windows.Forms.PictureBox();
            this.plate1 = new System.Windows.Forms.PictureBox();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate1)).BeginInit();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Location = new System.Drawing.Point(10, 10);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(16, 17);
            this.score1.TabIndex = 0;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Location = new System.Drawing.Point(360, 10);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(16, 17);
            this.score2.TabIndex = 1;
            this.score2.Text = "0";
            // 
            // ball
            // 
            this.ball.Image = global::ping_pong_app_solution.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(178, 101);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            // 
            // plate2
            // 
            this.plate2.Image = global::ping_pong_app_solution.Properties.Resources.plate;
            this.plate2.Location = new System.Drawing.Point(360, 40);
            this.plate2.Name = "plate2";
            this.plate2.Size = new System.Drawing.Size(11, 45);
            this.plate2.TabIndex = 3;
            this.plate2.TabStop = false;
            this.plate2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plate2_MouseMove);
            // 
            // plate1
            // 
            this.plate1.Image = global::ping_pong_app_solution.Properties.Resources.plate;
            this.plate1.Location = new System.Drawing.Point(10, 40);
            this.plate1.Name = "plate1";
            this.plate1.Size = new System.Drawing.Size(11, 45);
            this.plate1.TabIndex = 2;
            this.plate1.TabStop = false;
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Interval = 10;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.plate2);
            this.Controls.Add(this.plate1);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.PictureBox plate1;
        private System.Windows.Forms.PictureBox plate2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer tickTimer;
    }
}


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
        private void InitializeComponent()
        {
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Location = new System.Drawing.Point(298, 9);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(16, 17);
            this.score1.TabIndex = 0;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Location = new System.Drawing.Point(399, 9);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(16, 17);
            this.score2.TabIndex = 1;
            this.score2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
    }
}


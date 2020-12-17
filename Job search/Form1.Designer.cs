
namespace Job_search
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
            this.AbortButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.VacancyTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericStart = new System.Windows.Forms.NumericUpDown();
            this.NumericEnd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AbortButton.Location = new System.Drawing.Point(404, 241);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(120, 23);
            this.AbortButton.TabIndex = 9;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StartButton.Location = new System.Drawing.Point(404, 212);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ListTitles
            // 
            this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(12, 12);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(359, 420);
            this.ListTitles.TabIndex = 7;
            this.ListTitles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListTitles_KeyDown);
            // 
            // VacancyTB
            // 
            this.VacancyTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VacancyTB.Location = new System.Drawing.Point(404, 152);
            this.VacancyTB.Name = "VacancyTB";
            this.VacancyTB.Size = new System.Drawing.Size(120, 20);
            this.VacancyTB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Первая страница";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Вакансия";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumericStart
            // 
            this.NumericStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericStart.Location = new System.Drawing.Point(404, 30);
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(120, 20);
            this.NumericStart.TabIndex = 13;
            // 
            // NumericEnd
            // 
            this.NumericEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericEnd.Location = new System.Drawing.Point(404, 81);
            this.NumericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericEnd.Name = "NumericEnd";
            this.NumericEnd.Size = new System.Drawing.Size(120, 20);
            this.NumericEnd.TabIndex = 15;
            this.NumericEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Последняя страница";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.NumericEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumericStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VacancyTB);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ListTitles);
            this.Name = "Form1";
            this.Text = "Детоубийца";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.TextBox VacancyTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.Label label3;
    }
}


namespace ImageFlip
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
            this.buttonChoice = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonParallel = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChoice
            // 
            this.buttonChoice.Location = new System.Drawing.Point(11, 11);
            this.buttonChoice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChoice.Name = "buttonChoice";
            this.buttonChoice.Size = new System.Drawing.Size(582, 31);
            this.buttonChoice.TabIndex = 0;
            this.buttonChoice.Text = "Выбрать папку";
            this.buttonChoice.UseVisualStyleBackColor = true;
            this.buttonChoice.Click += new System.EventHandler(this.buttonChoice_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 56);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(583, 271);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonParallel
            // 
            this.buttonParallel.Location = new System.Drawing.Point(11, 344);
            this.buttonParallel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParallel.Name = "buttonParallel";
            this.buttonParallel.Size = new System.Drawing.Size(153, 31);
            this.buttonParallel.TabIndex = 2;
            this.buttonParallel.Text = "Parallel";
            this.buttonParallel.UseVisualStyleBackColor = true;
            this.buttonParallel.Click += new System.EventHandler(this.buttonParallel_Click);
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(228, 345);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(153, 30);
            this.buttonTask.TabIndex = 3;
            this.buttonTask.Text = "Task";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // buttonThread
            // 
            this.buttonThread.Location = new System.Drawing.Point(440, 345);
            this.buttonThread.Name = "buttonThread";
            this.buttonThread.Size = new System.Drawing.Size(153, 30);
            this.buttonThread.TabIndex = 4;
            this.buttonThread.Text = "Thread";
            this.buttonThread.UseVisualStyleBackColor = true;
            this.buttonThread.Click += new System.EventHandler(this.buttonThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 387);
            this.Controls.Add(this.buttonThread);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.buttonParallel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonChoice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(620, 426);
            this.MinimumSize = new System.Drawing.Size(620, 426);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChoice;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonParallel;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Button buttonThread;
    }
}


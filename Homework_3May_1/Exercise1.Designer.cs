namespace Homework_3May_1
{
    partial class Exercise1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise1));
            this.GoToTurn = new System.Windows.Forms.Label();
            this.GoToExit = new System.Windows.Forms.Label();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.NameTask = new System.Windows.Forms.Label();
            this.GoToSortArray = new System.Windows.Forms.Button();
            this.GoToReadFile = new System.Windows.Forms.Button();
            this.GoToFillFile = new System.Windows.Forms.Button();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoToTurn
            // 
            this.GoToTurn.AutoSize = true;
            this.GoToTurn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GoToTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToTurn.Location = new System.Drawing.Point(538, -12);
            this.GoToTurn.Name = "GoToTurn";
            this.GoToTurn.Size = new System.Drawing.Size(38, 42);
            this.GoToTurn.TabIndex = 7;
            this.GoToTurn.Text = "_";
            this.GoToTurn.Click += new System.EventHandler(this.GoToTurn_Click);
            // 
            // GoToExit
            // 
            this.GoToExit.AutoSize = true;
            this.GoToExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GoToExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToExit.Location = new System.Drawing.Point(575, 0);
            this.GoToExit.Name = "GoToExit";
            this.GoToExit.Size = new System.Drawing.Size(40, 42);
            this.GoToExit.TabIndex = 6;
            this.GoToExit.Text = "×";
            this.GoToExit.Click += new System.EventHandler(this.GoToExit_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UpperPanel.Controls.Add(this.NameTask);
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(615, 42);
            this.UpperPanel.TabIndex = 8;
            // 
            // NameTask
            // 
            this.NameTask.AutoSize = true;
            this.NameTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTask.Location = new System.Drawing.Point(18, 10);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(503, 20);
            this.NameTask.TabIndex = 0;
            this.NameTask.Text = "Первое задание. Чтение, сортировка и запись чисел в документ";
            // 
            // GoToSortArray
            // 
            this.GoToSortArray.Enabled = false;
            this.GoToSortArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToSortArray.Location = new System.Drawing.Point(159, 125);
            this.GoToSortArray.Name = "GoToSortArray";
            this.GoToSortArray.Size = new System.Drawing.Size(300, 50);
            this.GoToSortArray.TabIndex = 10;
            this.GoToSortArray.Text = "Отсортировать по убыванию";
            this.GoToSortArray.UseVisualStyleBackColor = true;
            this.GoToSortArray.Click += new System.EventHandler(this.GoToSortArray_Click);
            // 
            // GoToReadFile
            // 
            this.GoToReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToReadFile.Location = new System.Drawing.Point(12, 69);
            this.GoToReadFile.Name = "GoToReadFile";
            this.GoToReadFile.Size = new System.Drawing.Size(300, 50);
            this.GoToReadFile.TabIndex = 9;
            this.GoToReadFile.Text = "Прочитать из файла числа";
            this.GoToReadFile.UseVisualStyleBackColor = true;
            this.GoToReadFile.Click += new System.EventHandler(this.GoToReadFile_Click);
            // 
            // GoToFillFile
            // 
            this.GoToFillFile.Enabled = false;
            this.GoToFillFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToFillFile.Location = new System.Drawing.Point(300, 181);
            this.GoToFillFile.Name = "GoToFillFile";
            this.GoToFillFile.Size = new System.Drawing.Size(300, 50);
            this.GoToFillFile.TabIndex = 11;
            this.GoToFillFile.Text = "Записать в файл числа";
            this.GoToFillFile.UseVisualStyleBackColor = true;
            this.GoToFillFile.Click += new System.EventHandler(this.GoToFillFile_Click);
            // 
            // Exercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 257);
            this.Controls.Add(this.GoToFillFile);
            this.Controls.Add(this.GoToSortArray);
            this.Controls.Add(this.GoToReadFile);
            this.Controls.Add(this.GoToTurn);
            this.Controls.Add(this.GoToExit);
            this.Controls.Add(this.UpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Exercise1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoToTurn;
        private System.Windows.Forms.Label GoToExit;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label NameTask;
        private System.Windows.Forms.Button GoToSortArray;
        private System.Windows.Forms.Button GoToReadFile;
        private System.Windows.Forms.Button GoToFillFile;
    }
}


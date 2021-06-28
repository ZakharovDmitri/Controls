namespace TestControlsApplication
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorPicker1 = new LabControls.ColorPicker();
            this.filePathSelect1 = new LabControls.FilePathSelect();
            this.numberBox1 = new LabControls.NumberBox(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь файла:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет";
            // 
            // colorPicker1
            // 
            this.colorPicker1.Location = new System.Drawing.Point(18, 168);
            this.colorPicker1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(361, 166);
            this.colorPicker1.TabIndex = 4;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "D:\\OneDrive - НИУ Высшая школа экономики";
            this.filePathSelect1.Location = new System.Drawing.Point(18, 98);
            this.filePathSelect1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(361, 40);
            this.filePathSelect1.TabIndex = 1;
            this.filePathSelect1.Load += new System.EventHandler(this.filePathSelect1_Load);
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(231, 14);
            this.numberBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(148, 26);
            this.numberBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorPicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Мое приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabControls.NumberBox numberBox1;
        private LabControls.FilePathSelect filePathSelect1;
        private System.Windows.Forms.Label label2;
        private LabControls.ColorPicker colorPicker1;
        private System.Windows.Forms.Label label3;
    }
}


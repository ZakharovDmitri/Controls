namespace LabControls
{
    partial class ColorPicker
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decRadioButton = new System.Windows.Forms.RadioButton();
            this.hexRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.blueColorTextBox = new LabControls.ColorTextBox(this.components);
            this.greenColorTextBox = new LabControls.ColorTextBox(this.components);
            this.redColorTextBox = new LabControls.ColorTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Синий";
            // 
            // decRadioButton
            // 
            this.decRadioButton.AutoSize = true;
            this.decRadioButton.Checked = true;
            this.decRadioButton.Enabled = false;
            this.decRadioButton.Location = new System.Drawing.Point(4, 125);
            this.decRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decRadioButton.Name = "decRadioButton";
            this.decRadioButton.Size = new System.Drawing.Size(63, 24);
            this.decRadioButton.TabIndex = 6;
            this.decRadioButton.TabStop = true;
            this.decRadioButton.Text = "Dec";
            this.decRadioButton.UseVisualStyleBackColor = true;
            this.decRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.AutoSize = true;
            this.hexRadioButton.Location = new System.Drawing.Point(81, 125);
            this.hexRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(62, 24);
            this.hexRadioButton.TabIndex = 7;
            this.hexRadioButton.TabStop = true;
            this.hexRadioButton.Text = "Hex";
            this.hexRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Location = new System.Drawing.Point(198, 7);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 154);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // blueColorTextBox
            // 
            this.blueColorTextBox.Location = new System.Drawing.Point(92, 85);
            this.blueColorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueColorTextBox.Name = "blueColorTextBox";
            this.blueColorTextBox.Size = new System.Drawing.Size(73, 26);
            this.blueColorTextBox.TabIndex = 11;
            this.blueColorTextBox.Text = "0";
            this.blueColorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.blueColorTextBox.TextChanged += new System.EventHandler(this.сolorTextBox_TextChanged);
            // 
            // greenColorTextBox
            // 
            this.greenColorTextBox.Location = new System.Drawing.Point(92, 45);
            this.greenColorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greenColorTextBox.Name = "greenColorTextBox";
            this.greenColorTextBox.Size = new System.Drawing.Size(73, 26);
            this.greenColorTextBox.TabIndex = 10;
            this.greenColorTextBox.Text = "0";
            this.greenColorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.greenColorTextBox.TextChanged += new System.EventHandler(this.сolorTextBox_TextChanged);
            // 
            // redColorTextBox
            // 
            this.redColorTextBox.Location = new System.Drawing.Point(92, 5);
            this.redColorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redColorTextBox.Name = "redColorTextBox";
            this.redColorTextBox.Size = new System.Drawing.Size(73, 26);
            this.redColorTextBox.TabIndex = 9;
            this.redColorTextBox.Text = "0";
            this.redColorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.redColorTextBox.TextChanged += new System.EventHandler(this.сolorTextBox_TextChanged);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.blueColorTextBox);
            this.Controls.Add(this.greenColorTextBox);
            this.Controls.Add(this.redColorTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.hexRadioButton);
            this.Controls.Add(this.decRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(352, 166);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton decRadioButton;
        private System.Windows.Forms.RadioButton hexRadioButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private ColorTextBox redColorTextBox;
        private ColorTextBox greenColorTextBox;
        private ColorTextBox blueColorTextBox;
    }
}

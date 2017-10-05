namespace MakePaintGreatAgain.Controls
{
    partial class PText
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
            this.setText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarRotate = new System.Windows.Forms.TrackBar();
            this.btnColorTxt = new System.Windows.Forms.Button();
            this.cboxAlignTxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxSizeTxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxFontTxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotate)).BeginInit();
            this.SuspendLayout();
            // 
            // setText
            // 
            this.setText.Location = new System.Drawing.Point(6, 19);
            this.setText.Name = "setText";
            this.setText.Size = new System.Drawing.Size(131, 20);
            this.setText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBarRotate);
            this.groupBox1.Controls.Add(this.btnColorTxt);
            this.groupBox1.Controls.Add(this.cboxAlignTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxSizeTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxFontTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.setText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rotate";
            // 
            // trackBarRotate
            // 
            this.trackBarRotate.Location = new System.Drawing.Point(14, 188);
            this.trackBarRotate.Name = "trackBarRotate";
            this.trackBarRotate.Size = new System.Drawing.Size(119, 45);
            this.trackBarRotate.TabIndex = 8;
            // 
            // btnColorTxt
            // 
            this.btnColorTxt.Location = new System.Drawing.Point(45, 139);
            this.btnColorTxt.Name = "btnColorTxt";
            this.btnColorTxt.Size = new System.Drawing.Size(50, 23);
            this.btnColorTxt.TabIndex = 7;
            this.btnColorTxt.Text = "Color";
            this.btnColorTxt.UseVisualStyleBackColor = true;
            // 
            // cboxAlignTxt
            // 
            this.cboxAlignTxt.FormattingEnabled = true;
            this.cboxAlignTxt.Location = new System.Drawing.Point(45, 112);
            this.cboxAlignTxt.Name = "cboxAlignTxt";
            this.cboxAlignTxt.Size = new System.Drawing.Size(92, 21);
            this.cboxAlignTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Align";
            // 
            // cboxSizeTxt
            // 
            this.cboxSizeTxt.FormattingEnabled = true;
            this.cboxSizeTxt.Location = new System.Drawing.Point(45, 85);
            this.cboxSizeTxt.Name = "cboxSizeTxt";
            this.cboxSizeTxt.Size = new System.Drawing.Size(92, 21);
            this.cboxSizeTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // cboxFontTxt
            // 
            this.cboxFontTxt.FormattingEnabled = true;
            this.cboxFontTxt.Location = new System.Drawing.Point(45, 58);
            this.cboxFontTxt.Name = "cboxFontTxt";
            this.cboxFontTxt.Size = new System.Drawing.Size(92, 21);
            this.cboxFontTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            // 
            // PText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PText";
            this.Size = new System.Drawing.Size(145, 218);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox setText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColorTxt;
        private System.Windows.Forms.ComboBox cboxAlignTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxSizeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxFontTxt;
        private System.Windows.Forms.TrackBar trackBarRotate;
        private System.Windows.Forms.Label label4;
    }
}

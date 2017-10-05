namespace PluginTextFigure
{
    partial class PProperty
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
            this.propertyBox = new System.Windows.Forms.GroupBox();
            this.pWidth1 = new PluginTextFigure.PWidth();
            this.pColor1 = new PluginTextFigure.PColor();
            this.pType1 = new PluginTextFigure.PType();
            this.pText1 = new PluginTextFigure.PText();
            this.propertyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyBox
            // 
            this.propertyBox.Controls.Add(this.pText1);
            this.propertyBox.Controls.Add(this.pType1);
            this.propertyBox.Controls.Add(this.pColor1);
            this.propertyBox.Controls.Add(this.pWidth1);
            this.propertyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyBox.Location = new System.Drawing.Point(0, 0);
            this.propertyBox.Name = "propertyBox";
            this.propertyBox.Size = new System.Drawing.Size(194, 375);
            this.propertyBox.TabIndex = 0;
            this.propertyBox.TabStop = false;
            this.propertyBox.Text = "Property";
            // 
            // pWidth1
            // 
            this.pWidth1.Location = new System.Drawing.Point(13, 158);
            this.pWidth1.Name = "pWidth1";
            this.pWidth1.Size = new System.Drawing.Size(172, 42);
            this.pWidth1.TabIndex = 1;
            // 
            // pColor1
            // 
            this.pColor1.Location = new System.Drawing.Point(13, 111);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(172, 41);
            this.pColor1.TabIndex = 2;
            // 
            // pType1
            // 
            this.pType1.Location = new System.Drawing.Point(13, 19);
            this.pType1.Name = "pType1";
            this.pType1.Size = new System.Drawing.Size(172, 86);
            this.pType1.TabIndex = 3;
            // 
            // pText1
            // 
            this.pText1.Location = new System.Drawing.Point(13, 206);
            this.pText1.Name = "pText1";
            this.pText1.Size = new System.Drawing.Size(172, 162);
            this.pText1.TabIndex = 4;
            // 
            // PProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.propertyBox);
            this.Name = "PProperty";
            this.Size = new System.Drawing.Size(194, 375);
            this.propertyBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox propertyBox;
        private PColor pColor1;
        private PWidth pWidth1;
        private PType pType1;
        private PText pText1;
    }
}

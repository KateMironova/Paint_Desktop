namespace PluginPictureFigure.Controls
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
            this.groupBoxProperty = new System.Windows.Forms.GroupBox();
            this.pType1 = new PluginPictureFigure.Controls.PType();
            this.pColor1 = new PluginPictureFigure.Controls.PColor();
            this.pWidth1 = new PluginPictureFigure.Controls.PWidth();
            this.pPicture1 = new PluginPictureFigure.Controls.PPicture();
            this.groupBoxProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProperty
            // 
            this.groupBoxProperty.Controls.Add(this.pPicture1);
            this.groupBoxProperty.Controls.Add(this.pWidth1);
            this.groupBoxProperty.Controls.Add(this.pColor1);
            this.groupBoxProperty.Controls.Add(this.pType1);
            this.groupBoxProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProperty.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProperty.Name = "groupBoxProperty";
            this.groupBoxProperty.Size = new System.Drawing.Size(197, 383);
            this.groupBoxProperty.TabIndex = 0;
            this.groupBoxProperty.TabStop = false;
            this.groupBoxProperty.Text = "Property";
            // 
            // pType1
            // 
            this.pType1.Location = new System.Drawing.Point(16, 19);
            this.pType1.Name = "pType1";
            this.pType1.Size = new System.Drawing.Size(165, 86);
            this.pType1.TabIndex = 0;
            // 
            // pColor1
            // 
            this.pColor1.Location = new System.Drawing.Point(16, 111);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(165, 42);
            this.pColor1.TabIndex = 1;
            // 
            // pWidth1
            // 
            this.pWidth1.Location = new System.Drawing.Point(16, 159);
            this.pWidth1.Name = "pWidth1";
            this.pWidth1.Size = new System.Drawing.Size(165, 44);
            this.pWidth1.TabIndex = 2;
            // 
            // pPicture1
            // 
            this.pPicture1.Location = new System.Drawing.Point(16, 209);
            this.pPicture1.Name = "pPicture1";
            this.pPicture1.Size = new System.Drawing.Size(165, 84);
            this.pPicture1.TabIndex = 3;
            // 
            // PProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxProperty);
            this.Name = "PProperty";
            this.Size = new System.Drawing.Size(197, 383);
            this.groupBoxProperty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProperty;
        private PWidth pWidth1;
        private PColor pColor1;
        private PType pType1;
        private PPicture pPicture1;
    }
}

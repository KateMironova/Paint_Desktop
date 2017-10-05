namespace PluginEmptyFigure.Controls
{
    partial class pProperty
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pColor1 = new PluginEmptyFigure.Controls.PColor();
            this.pType1 = new PluginEmptyFigure.Controls.PType();
            this.pWidth1 = new PluginEmptyFigure.Controls.PWidth();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pWidth1);
            this.groupBox2.Controls.Add(this.pType1);
            this.groupBox2.Controls.Add(this.pColor1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 414);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property";
            // 
            // pColor1
            // 
            this.pColor1.Location = new System.Drawing.Point(15, 117);
            this.pColor1.Name = "pColor1";
            this.pColor1.Size = new System.Drawing.Size(172, 42);
            this.pColor1.TabIndex = 0;
            // 
            // pType1
            // 
            this.pType1.Location = new System.Drawing.Point(15, 19);
            this.pType1.Name = "pType1";
            this.pType1.Size = new System.Drawing.Size(172, 92);
            this.pType1.TabIndex = 1;
            // 
            // pWidth1
            // 
            this.pWidth1.Location = new System.Drawing.Point(15, 165);
            this.pWidth1.Name = "pWidth1";
            this.pWidth1.Size = new System.Drawing.Size(172, 44);
            this.pWidth1.TabIndex = 2;
            // 
            // pProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "pProperty";
            this.Size = new System.Drawing.Size(197, 414);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PWidth pWidth1;
        private PColor pColor1;
        public System.Windows.Forms.GroupBox groupBox2;
        public PType pType1;
    }
}

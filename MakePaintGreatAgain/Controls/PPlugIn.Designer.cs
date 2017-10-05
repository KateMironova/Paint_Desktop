namespace MakePaintGreatAgain.Controls
{
    partial class PPlugIn
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
            this.groupBoxPlugin = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxPlugin
            // 
            this.groupBoxPlugin.Location = new System.Drawing.Point(16, 22);
            this.groupBoxPlugin.Name = "groupBoxPlugin";
            this.groupBoxPlugin.Size = new System.Drawing.Size(174, 205);
            this.groupBoxPlugin.TabIndex = 0;
            this.groupBoxPlugin.TabStop = false;
            this.groupBoxPlugin.Text = "Figure Plug-In";
            // 
            // PPlugIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPlugin);
            this.Name = "PPlugIn";
            this.Size = new System.Drawing.Size(205, 241);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBoxPlugin;
    }
}

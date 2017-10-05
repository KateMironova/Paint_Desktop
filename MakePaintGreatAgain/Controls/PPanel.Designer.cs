namespace MakePaintGreatAgain.Controls
{
    partial class PPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pMenu1 = new MakePaintGreatAgain.Controls.PMenu();
            this.pStatusTrip1 = new MakePaintGreatAgain.Controls.PStatusTrip();
            this.pToolStrip1 = new MakePaintGreatAgain.Controls.PToolStrip();
            this.pPlugIn1 = new MakePaintGreatAgain.Controls.PPlugIn();
            this.pProperty1 = new MakePaintGreatAgain.Controls.PProperty();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(204, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // pMenu1
            // 
            this.pMenu1.Location = new System.Drawing.Point(0, 0);
            this.pMenu1.Name = "pMenu1";
            this.pMenu1.Size = new System.Drawing.Size(881, 28);
            this.pMenu1.TabIndex = 1;
            this.pMenu1.xcom = null;
            // 
            // pStatusTrip1
            // 
            this.pStatusTrip1.Location = new System.Drawing.Point(0, 523);
            this.pStatusTrip1.Name = "pStatusTrip1";
            this.pStatusTrip1.Size = new System.Drawing.Size(881, 24);
            this.pStatusTrip1.TabIndex = 2;
            // 
            // pToolStrip1
            // 
            this.pToolStrip1.Location = new System.Drawing.Point(0, 22);
            this.pToolStrip1.Name = "pToolStrip1";
            this.pToolStrip1.Size = new System.Drawing.Size(881, 28);
            this.pToolStrip1.TabIndex = 3;
            this.pToolStrip1.xcom = null;
            // 
            // pPlugIn1
            // 
            this.pPlugIn1.Location = new System.Drawing.Point(0, 50);
            this.pPlugIn1.Name = "pPlugIn1";
            this.pPlugIn1.Size = new System.Drawing.Size(198, 235);
            this.pPlugIn1.TabIndex = 4;
            this.pPlugIn1.xcom = null;
            // 
            // pProperty1
            // 
            this.pProperty1.Location = new System.Drawing.Point(683, 73);
            this.pProperty1.Name = "pProperty1";
            this.pProperty1.Size = new System.Drawing.Size(195, 444);
            this.pProperty1.TabIndex = 5;
            // 
            // PPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pProperty1);
            this.Controls.Add(this.pPlugIn1);
            this.Controls.Add(this.pToolStrip1);
            this.Controls.Add(this.pStatusTrip1);
            this.Controls.Add(this.pMenu1);
            this.Controls.Add(this.tabControl1);
            this.Name = "PPanel";
            this.Size = new System.Drawing.Size(881, 547);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private PMenu pMenu1;
        private PStatusTrip pStatusTrip1;
        private PToolStrip pToolStrip1;
        private PPlugIn pPlugIn1;
        private PProperty pProperty1;
    }
}

namespace WindowsFormsComponentTest
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
            this.buttonChange = new System.Windows.Forms.Button();
            this.enterFieldControl1 = new WindowsFormsControlLibraryComponentSansiel.EnterFieldControl();
            this.selectComponentControl = new WindowsFormsControlLibraryComponentSansiel.SelectComponentControl();
            this.outputComponentControl1 = new WindowsFormsControlLibraryComponentSansiel.OutputComponentControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(67, 117);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(120, 36);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click_1);
            // 
            // enterFieldControl1
            // 
            this.enterFieldControl1.AcceptColor = System.Drawing.Color.Green;
            this.enterFieldControl1.DangerColor = System.Drawing.Color.Red;
            this.enterFieldControl1.Location = new System.Drawing.Point(213, 60);
            this.enterFieldControl1.Name = "enterFieldControl1";
            this.enterFieldControl1.Size = new System.Drawing.Size(219, 93);
            this.enterFieldControl1.TabIndex = 1;
            this.enterFieldControl1.TemplateMail = "";
            // 
            // selectComponentControl
            // 
            this.selectComponentControl.Location = new System.Drawing.Point(33, 25);
            this.selectComponentControl.Name = "selectComponentControl";
            this.selectComponentControl.SelectedIndex = 0;
            this.selectComponentControl.Size = new System.Drawing.Size(582, 80);
            this.selectComponentControl.TabIndex = 0;
            this.selectComponentControl.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected_ComboBoxSelectedElementChange);
            // 
            // outputComponentControl1
            // 
            this.outputComponentControl1.ListElement = null;
            this.outputComponentControl1.Location = new System.Drawing.Point(286, 137);
            this.outputComponentControl1.Name = "outputComponentControl1";
            this.outputComponentControl1.Size = new System.Drawing.Size(347, 135);
            this.outputComponentControl1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputComponentControl1);
            this.Controls.Add(this.enterFieldControl1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.selectComponentControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibraryComponentSansiel.SelectComponentControl selectComponentControl;
        private System.Windows.Forms.Button buttonChange;
        private WindowsFormsControlLibraryComponentSansiel.EnterFieldControl enterFieldControl1;
        private WindowsFormsControlLibraryComponentSansiel.OutputComponentControl outputComponentControl1;
        private System.Windows.Forms.Button button1;
    }
}


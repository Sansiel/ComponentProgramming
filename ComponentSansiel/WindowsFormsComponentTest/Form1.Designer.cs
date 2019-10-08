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
            this.components = new System.ComponentModel.Container();
            this.buttonChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.outputComponentControl = new WindowsFormsControlLibraryComponentSansiel.OutputComponentControl();
            this.enterFieldControl1 = new WindowsFormsControlLibraryComponentSansiel.EnterFieldControl();
            this.selectComponentControl = new WindowsFormsControlLibraryComponentSansiel.SelectComponentControl();
            this.pdfDiagramComponent1 = new WindowsFormsControlLibraryComponentSansiel.PDFDiagramComponent(this.components);
            this.excelReporterComponent1 = new WindowsFormsControlLibraryComponentSansiel.ExcelReporterComponent(this.components);
            this.createBackUpComponent1 = new WindowsFormsControlLibraryComponentSansiel.CreateBackUpComponent(this.components);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(314, 111);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // outputComponentControl
            // 
            this.outputComponentControl.FieldType = "Name Age";
            this.outputComponentControl.ListElement = "";
            this.outputComponentControl.Location = new System.Drawing.Point(286, 137);
            this.outputComponentControl.Name = "outputComponentControl";
            this.outputComponentControl.Size = new System.Drawing.Size(347, 135);
            this.outputComponentControl.TabIndex = 2;
            // 
            // enterFieldControl1
            // 
            this.enterFieldControl1.AcceptColor = System.Drawing.Color.Green;
            this.enterFieldControl1.DangerColor = System.Drawing.Color.Red;
            this.enterFieldControl1.Location = new System.Drawing.Point(213, 60);
            this.enterFieldControl1.Name = "enterFieldControl1";
            this.enterFieldControl1.Size = new System.Drawing.Size(219, 93);
            this.enterFieldControl1.TabIndex = 1;
            this.enterFieldControl1.TemplateData = "";
            this.enterFieldControl1.TemplateRegex = "\\d\\d\\.\\d\\d\\.\\d\\d\\d\\d";
            this.enterFieldControl1.TemplateText = "";
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
            // pdfDiagramComponent1
            // 
            this.pdfDiagramComponent1.FieldType = "Name Count";
            // 
            // excelReporterComponent1
            // 
            this.excelReporterComponent1.FieldType = "Name Pname Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 456);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputComponentControl);
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
        private WindowsFormsControlLibraryComponentSansiel.OutputComponentControl outputComponentControl;
        private System.Windows.Forms.Button button1;
        private WindowsFormsControlLibraryComponentSansiel.PDFDiagramComponent pdfDiagramComponent1;
        private WindowsFormsControlLibraryComponentSansiel.ExcelReporterComponent excelReporterComponent1;
        private WindowsFormsControlLibraryComponentSansiel.CreateBackUpComponent createBackUpComponent1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


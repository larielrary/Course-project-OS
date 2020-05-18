namespace CourseProject2._0
{
    partial class MainForm
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
            this.koeffLabel = new System.Windows.Forms.Label();
            this.Akoeff = new System.Windows.Forms.Label();
            this.Bkoeff = new System.Windows.Forms.Label();
            this.Ckoeff = new System.Windows.Forms.Label();
            this.Dkoeff = new System.Windows.Forms.Label();
            this.aValue = new System.Windows.Forms.TextBox();
            this.bValue = new System.Windows.Forms.TextBox();
            this.cValue = new System.Windows.Forms.TextBox();
            this.dValue = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultPar = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.timeParTextBox = new System.Windows.Forms.TextBox();
            this.timePar = new System.Windows.Forms.Label();
            this.threadCountLabel = new System.Windows.Forms.Label();
            this.threadCount = new System.Windows.Forms.ComboBox();
            this.exportToExcelBtn = new System.Windows.Forms.Button();
            this.result2TextBox = new System.Windows.Forms.TextBox();
            this.res2Label = new System.Windows.Forms.Label();
            this.result2ParTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.absoluteErrorTextBox = new System.Windows.Forms.TextBox();
            this.relativeErrorTextBox = new System.Windows.Forms.TextBox();
            this.absoluteLabel = new System.Windows.Forms.Label();
            this.relatuveLabel = new System.Windows.Forms.Label();
            this.showSurfaceBtn = new System.Windows.Forms.Button();
            this.resultFromPython = new System.Windows.Forms.TextBox();
            this.labelPython = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // koeffLabel
            // 
            this.koeffLabel.AutoSize = true;
            this.koeffLabel.Location = new System.Drawing.Point(54, 23);
            this.koeffLabel.Name = "koeffLabel";
            this.koeffLabel.Size = new System.Drawing.Size(207, 26);
            this.koeffLabel.TabIndex = 0;
            this.koeffLabel.Text = "Введите коэффициенты";
            // 
            // Akoeff
            // 
            this.Akoeff.AutoSize = true;
            this.Akoeff.Location = new System.Drawing.Point(33, 63);
            this.Akoeff.Name = "Akoeff";
            this.Akoeff.Size = new System.Drawing.Size(29, 26);
            this.Akoeff.TabIndex = 1;
            this.Akoeff.Text = "А:";
            // 
            // Bkoeff
            // 
            this.Bkoeff.AutoSize = true;
            this.Bkoeff.Location = new System.Drawing.Point(183, 63);
            this.Bkoeff.Name = "Bkoeff";
            this.Bkoeff.Size = new System.Drawing.Size(27, 26);
            this.Bkoeff.TabIndex = 2;
            this.Bkoeff.Text = "B:";
            // 
            // Ckoeff
            // 
            this.Ckoeff.AutoSize = true;
            this.Ckoeff.Location = new System.Drawing.Point(33, 109);
            this.Ckoeff.Name = "Ckoeff";
            this.Ckoeff.Size = new System.Drawing.Size(26, 26);
            this.Ckoeff.TabIndex = 3;
            this.Ckoeff.Text = "C:";
            // 
            // Dkoeff
            // 
            this.Dkoeff.AutoSize = true;
            this.Dkoeff.Location = new System.Drawing.Point(183, 109);
            this.Dkoeff.Name = "Dkoeff";
            this.Dkoeff.Size = new System.Drawing.Size(28, 26);
            this.Dkoeff.TabIndex = 4;
            this.Dkoeff.Text = "D:";
            // 
            // aValue
            // 
            this.aValue.Location = new System.Drawing.Point(68, 63);
            this.aValue.Multiline = true;
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(67, 26);
            this.aValue.TabIndex = 5;
            this.aValue.Click += new System.EventHandler(this.AValue_Click);
            // 
            // bValue
            // 
            this.bValue.Location = new System.Drawing.Point(218, 63);
            this.bValue.Multiline = true;
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(67, 26);
            this.bValue.TabIndex = 6;
            this.bValue.Click += new System.EventHandler(this.BValue_Click);
            // 
            // cValue
            // 
            this.cValue.Location = new System.Drawing.Point(68, 109);
            this.cValue.Multiline = true;
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(67, 26);
            this.cValue.TabIndex = 7;
            this.cValue.Click += new System.EventHandler(this.CValue_Click);
            // 
            // dValue
            // 
            this.dValue.Location = new System.Drawing.Point(218, 109);
            this.dValue.Multiline = true;
            this.dValue.Name = "dValue";
            this.dValue.Size = new System.Drawing.Size(67, 26);
            this.dValue.TabIndex = 8;
            this.dValue.Click += new System.EventHandler(this.DValue_Click);
            // 
            // processButton
            // 
            this.processButton.BackColor = System.Drawing.Color.PeachPuff;
            this.processButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.processButton.Location = new System.Drawing.Point(172, 232);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(130, 33);
            this.processButton.TabIndex = 9;
            this.processButton.Text = "Обработать";
            this.processButton.UseVisualStyleBackColor = false;
            this.processButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.PeachPuff;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(670, 278);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // resultPar
            // 
            this.resultPar.AutoSize = true;
            this.resultPar.Location = new System.Drawing.Point(332, 99);
            this.resultPar.Name = "resultPar";
            this.resultPar.Size = new System.Drawing.Size(215, 52);
            this.resultPar.TabIndex = 11;
            this.resultPar.Text = "Результат \r\nпараллельных вычислений";
            this.resultPar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(598, 52);
            this.timeTextBox.Multiline = true;
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(113, 26);
            this.timeTextBox.TabIndex = 14;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(575, 23);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(157, 26);
            this.time.TabIndex = 13;
            this.time.Text = "Время выполнения";
            // 
            // timeParTextBox
            // 
            this.timeParTextBox.Location = new System.Drawing.Point(598, 136);
            this.timeParTextBox.Multiline = true;
            this.timeParTextBox.Name = "timeParTextBox";
            this.timeParTextBox.Size = new System.Drawing.Size(113, 26);
            this.timeParTextBox.TabIndex = 15;
            // 
            // timePar
            // 
            this.timePar.AutoSize = true;
            this.timePar.Location = new System.Drawing.Point(575, 81);
            this.timePar.Name = "timePar";
            this.timePar.Size = new System.Drawing.Size(163, 52);
            this.timePar.TabIndex = 16;
            this.timePar.Text = "Время выполнения \r\n(параллельно)\r\n";
            this.timePar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // threadCountLabel
            // 
            this.threadCountLabel.AutoSize = true;
            this.threadCountLabel.Location = new System.Drawing.Point(33, 156);
            this.threadCountLabel.Name = "threadCountLabel";
            this.threadCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.threadCountLabel.Size = new System.Drawing.Size(102, 78);
            this.threadCountLabel.TabIndex = 19;
            this.threadCountLabel.Text = "Выберите \r\nколичество\r\n потоков";
            this.threadCountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // threadCount
            // 
            this.threadCount.FormattingEnabled = true;
            this.threadCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15"});
            this.threadCount.Location = new System.Drawing.Point(172, 171);
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(130, 34);
            this.threadCount.TabIndex = 22;
            // 
            // exportToExcelBtn
            // 
            this.exportToExcelBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.exportToExcelBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.exportToExcelBtn.Location = new System.Drawing.Point(172, 281);
            this.exportToExcelBtn.Name = "exportToExcelBtn";
            this.exportToExcelBtn.Size = new System.Drawing.Size(130, 33);
            this.exportToExcelBtn.TabIndex = 23;
            this.exportToExcelBtn.Text = "Статистика";
            this.exportToExcelBtn.UseVisualStyleBackColor = false;
            this.exportToExcelBtn.Click += new System.EventHandler(this.ExportToExcelBtn_Click);
            // 
            // result2TextBox
            // 
            this.result2TextBox.Location = new System.Drawing.Point(317, 52);
            this.result2TextBox.Multiline = true;
            this.result2TextBox.Name = "result2TextBox";
            this.result2TextBox.Size = new System.Drawing.Size(233, 26);
            this.result2TextBox.TabIndex = 25;
            // 
            // res2Label
            // 
            this.res2Label.AutoSize = true;
            this.res2Label.Location = new System.Drawing.Point(382, 23);
            this.res2Label.Name = "res2Label";
            this.res2Label.Size = new System.Drawing.Size(109, 26);
            this.res2Label.TabIndex = 24;
            this.res2Label.Text = "Результат ";
            this.res2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // result2ParTextBox
            // 
            this.result2ParTextBox.Location = new System.Drawing.Point(317, 160);
            this.result2ParTextBox.Multiline = true;
            this.result2ParTextBox.Name = "result2ParTextBox";
            this.result2ParTextBox.Size = new System.Drawing.Size(233, 26);
            this.result2ParTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Погрешность";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // absoluteErrorTextBox
            // 
            this.absoluteErrorTextBox.Location = new System.Drawing.Point(628, 200);
            this.absoluteErrorTextBox.Multiline = true;
            this.absoluteErrorTextBox.Name = "absoluteErrorTextBox";
            this.absoluteErrorTextBox.Size = new System.Drawing.Size(117, 26);
            this.absoluteErrorTextBox.TabIndex = 28;
            // 
            // relativeErrorTextBox
            // 
            this.relativeErrorTextBox.Location = new System.Drawing.Point(628, 239);
            this.relativeErrorTextBox.Multiline = true;
            this.relativeErrorTextBox.Name = "relativeErrorTextBox";
            this.relativeErrorTextBox.Size = new System.Drawing.Size(117, 26);
            this.relativeErrorTextBox.TabIndex = 30;
            // 
            // absoluteLabel
            // 
            this.absoluteLabel.AutoSize = true;
            this.absoluteLabel.Location = new System.Drawing.Point(561, 194);
            this.absoluteLabel.Name = "absoluteLabel";
            this.absoluteLabel.Size = new System.Drawing.Size(45, 26);
            this.absoluteLabel.TabIndex = 31;
            this.absoluteLabel.Text = "Абс.";
            this.absoluteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // relatuveLabel
            // 
            this.relatuveLabel.AutoSize = true;
            this.relatuveLabel.Location = new System.Drawing.Point(561, 239);
            this.relatuveLabel.Name = "relatuveLabel";
            this.relatuveLabel.Size = new System.Drawing.Size(54, 26);
            this.relatuveLabel.TabIndex = 32;
            this.relatuveLabel.Text = "Отн.";
            this.relatuveLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showSurfaceBtn
            // 
            this.showSurfaceBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.showSurfaceBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.showSurfaceBtn.Location = new System.Drawing.Point(12, 248);
            this.showSurfaceBtn.Name = "showSurfaceBtn";
            this.showSurfaceBtn.Size = new System.Drawing.Size(130, 66);
            this.showSurfaceBtn.TabIndex = 33;
            this.showSurfaceBtn.Text = "Построить поверхность";
            this.showSurfaceBtn.UseVisualStyleBackColor = false;
            this.showSurfaceBtn.Click += new System.EventHandler(this.ShowSurfaceBtn_Click);
            // 
            // resultFromPython
            // 
            this.resultFromPython.Location = new System.Drawing.Point(317, 249);
            this.resultFromPython.Multiline = true;
            this.resultFromPython.Name = "resultFromPython";
            this.resultFromPython.Size = new System.Drawing.Size(233, 26);
            this.resultFromPython.TabIndex = 34;
            // 
            // labelPython
            // 
            this.labelPython.AutoSize = true;
            this.labelPython.Location = new System.Drawing.Point(347, 217);
            this.labelPython.Name = "labelPython";
            this.labelPython.Size = new System.Drawing.Size(185, 26);
            this.labelPython.TabIndex = 35;
            this.labelPython.Text = "Результат из Python";
            this.labelPython.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(757, 320);
            this.ControlBox = false;
            this.Controls.Add(this.labelPython);
            this.Controls.Add(this.resultFromPython);
            this.Controls.Add(this.showSurfaceBtn);
            this.Controls.Add(this.relatuveLabel);
            this.Controls.Add(this.absoluteLabel);
            this.Controls.Add(this.relativeErrorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.absoluteErrorTextBox);
            this.Controls.Add(this.result2ParTextBox);
            this.Controls.Add(this.result2TextBox);
            this.Controls.Add(this.res2Label);
            this.Controls.Add(this.exportToExcelBtn);
            this.Controls.Add(this.threadCount);
            this.Controls.Add(this.threadCountLabel);
            this.Controls.Add(this.timePar);
            this.Controls.Add(this.timeParTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.time);
            this.Controls.Add(this.resultPar);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.dValue);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.bValue);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.Dkoeff);
            this.Controls.Add(this.Ckoeff);
            this.Controls.Add(this.Bkoeff);
            this.Controls.Add(this.Akoeff);
            this.Controls.Add(this.koeffLabel);
            this.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label koeffLabel;
        private System.Windows.Forms.Label Akoeff;
        private System.Windows.Forms.Label Bkoeff;
        private System.Windows.Forms.Label Ckoeff;
        private System.Windows.Forms.Label Dkoeff;
        public System.Windows.Forms.TextBox aValue;
        public System.Windows.Forms.TextBox bValue;
        public System.Windows.Forms.TextBox cValue;
        public System.Windows.Forms.TextBox dValue;
        public System.Windows.Forms.Button processButton;
        public System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultPar;
        public System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label time;
        public System.Windows.Forms.TextBox timeParTextBox;
        private System.Windows.Forms.Label timePar;
        private System.Windows.Forms.Label threadCountLabel;
        public System.Windows.Forms.ComboBox threadCount;
        public System.Windows.Forms.Button exportToExcelBtn;
        public System.Windows.Forms.TextBox result2TextBox;
        private System.Windows.Forms.Label res2Label;
        public System.Windows.Forms.TextBox result2ParTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox absoluteErrorTextBox;
        public System.Windows.Forms.TextBox relativeErrorTextBox;
        private System.Windows.Forms.Label absoluteLabel;
        private System.Windows.Forms.Label relatuveLabel;
        public System.Windows.Forms.Button showSurfaceBtn;
        public System.Windows.Forms.TextBox resultFromPython;
        private System.Windows.Forms.Label labelPython;
    }
}


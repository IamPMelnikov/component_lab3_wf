namespace WindowsFormsControlLibrary1
{
    partial class RGBControl
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
            this.labRed = new System.Windows.Forms.Label();
            this.labGreen = new System.Windows.Forms.Label();
            this.labBlue = new System.Windows.Forms.Label();
            this.rbutDec = new System.Windows.Forms.RadioButton();
            this.rbutHex = new System.Windows.Forms.RadioButton();
            this.ntbBlue = new WindowsFormsControlLibrary1.NumberTextBox(this.components);
            this.ntbGreen = new WindowsFormsControlLibrary1.NumberTextBox(this.components);
            this.ntbRed = new WindowsFormsControlLibrary1.NumberTextBox(this.components);
            this.SuspendLayout();
            // 
            // labRed
            // 
            this.labRed.AutoSize = true;
            this.labRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRed.Location = new System.Drawing.Point(15, 25);
            this.labRed.Name = "labRed";
            this.labRed.Size = new System.Drawing.Size(18, 16);
            this.labRed.TabIndex = 0;
            this.labRed.Text = "R";
            // 
            // labGreen
            // 
            this.labGreen.AutoSize = true;
            this.labGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labGreen.Location = new System.Drawing.Point(15, 53);
            this.labGreen.Name = "labGreen";
            this.labGreen.Size = new System.Drawing.Size(18, 16);
            this.labGreen.TabIndex = 1;
            this.labGreen.Text = "G";
            // 
            // labBlue
            // 
            this.labBlue.AutoSize = true;
            this.labBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labBlue.Location = new System.Drawing.Point(16, 78);
            this.labBlue.Name = "labBlue";
            this.labBlue.Size = new System.Drawing.Size(17, 16);
            this.labBlue.TabIndex = 2;
            this.labBlue.Text = "B";
            // 
            // rbutDec
            // 
            this.rbutDec.AutoSize = true;
            this.rbutDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbutDec.Location = new System.Drawing.Point(55, 104);
            this.rbutDec.Name = "rbutDec";
            this.rbutDec.Size = new System.Drawing.Size(51, 20);
            this.rbutDec.TabIndex = 6;
            this.rbutDec.TabStop = true;
            this.rbutDec.Text = "Dec";
            this.rbutDec.UseVisualStyleBackColor = true;
            this.rbutDec.CheckedChanged += new System.EventHandler(this.RbutDecCheckedChanged);
            // 
            // rbutHex
            // 
            this.rbutHex.AutoSize = true;
            this.rbutHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbutHex.Location = new System.Drawing.Point(55, 130);
            this.rbutHex.Name = "rbutHex";
            this.rbutHex.Size = new System.Drawing.Size(50, 20);
            this.rbutHex.TabIndex = 7;
            this.rbutHex.TabStop = true;
            this.rbutHex.Text = "Hex";
            this.rbutHex.UseVisualStyleBackColor = true;
            this.rbutHex.CheckedChanged += new System.EventHandler(this.RbutHexCheckedChanged);
            // 
            // ntbBlue
            // 
            this.ntbBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ntbBlue.Location = new System.Drawing.Point(55, 78);
            this.ntbBlue.MaxLength = 3;
            this.ntbBlue.Name = "ntbBlue";
            this.ntbBlue.Size = new System.Drawing.Size(66, 22);
            this.ntbBlue.TabIndex = 5;
            this.ntbBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbBlue.TextMode = WindowsFormsControlLibrary1.NumberTextBox.Mode.Dec;
            this.ntbBlue.TextChanged += new System.EventHandler(this.NtbBlueTextChanged);
            // 
            // ntbGreen
            // 
            this.ntbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ntbGreen.Location = new System.Drawing.Point(55, 50);
            this.ntbGreen.MaxLength = 3;
            this.ntbGreen.Name = "ntbGreen";
            this.ntbGreen.Size = new System.Drawing.Size(66, 22);
            this.ntbGreen.TabIndex = 4;
            this.ntbGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbGreen.TextMode = WindowsFormsControlLibrary1.NumberTextBox.Mode.Dec;
            this.ntbGreen.TextChanged += new System.EventHandler(this.NtbGreenTextChanged);
            // 
            // ntbRed
            // 
            this.ntbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ntbRed.Location = new System.Drawing.Point(55, 22);
            this.ntbRed.MaxLength = 3;
            this.ntbRed.Name = "ntbRed";
            this.ntbRed.Size = new System.Drawing.Size(66, 22);
            this.ntbRed.TabIndex = 3;
            this.ntbRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbRed.TextMode = WindowsFormsControlLibrary1.NumberTextBox.Mode.Dec;
            this.ntbRed.TextChanged += new System.EventHandler(this.NtbRedTextChanged);
            // 
            // RGBControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.rbutHex);
            this.Controls.Add(this.rbutDec);
            this.Controls.Add(this.ntbBlue);
            this.Controls.Add(this.ntbGreen);
            this.Controls.Add(this.ntbRed);
            this.Controls.Add(this.labBlue);
            this.Controls.Add(this.labGreen);
            this.Controls.Add(this.labRed);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RGBControl";
            this.Size = new System.Drawing.Size(270, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRed;
        private System.Windows.Forms.Label labGreen;
        private System.Windows.Forms.Label labBlue;
        private NumberTextBox ntbRed;
        private NumberTextBox ntbGreen;
        private NumberTextBox ntbBlue;
        private System.Windows.Forms.RadioButton rbutDec;
        private System.Windows.Forms.RadioButton rbutHex;
    }
}

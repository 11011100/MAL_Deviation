namespace MAL_Deviation
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.labelSavePath = new System.Windows.Forms.Label();
            this.buttonSavePath = new System.Windows.Forms.Button();
            this.labelStartIndex = new System.Windows.Forms.Label();
            this.numericUpDownStartIndex = new System.Windows.Forms.NumericUpDown();
            this.labelStopIndex = new System.Windows.Forms.Label();
            this.numericUpDownStopIndex = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusCurrent = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelIndexCurrent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(12, 177);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(393, 246);
            this.textBoxConsole.TabIndex = 0;
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(12, 29);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.ReadOnly = true;
            this.textBoxSavePath.Size = new System.Drawing.Size(312, 20);
            this.textBoxSavePath.TabIndex = 1;
            // 
            // labelSavePath
            // 
            this.labelSavePath.AutoSize = true;
            this.labelSavePath.Location = new System.Drawing.Point(13, 13);
            this.labelSavePath.Name = "labelSavePath";
            this.labelSavePath.Size = new System.Drawing.Size(59, 13);
            this.labelSavePath.TabIndex = 2;
            this.labelSavePath.Text = "Save path:";
            // 
            // buttonSavePath
            // 
            this.buttonSavePath.Location = new System.Drawing.Point(330, 27);
            this.buttonSavePath.Name = "buttonSavePath";
            this.buttonSavePath.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePath.TabIndex = 3;
            this.buttonSavePath.Text = "Browse";
            this.buttonSavePath.UseVisualStyleBackColor = true;
            this.buttonSavePath.Click += new System.EventHandler(this.buttonSavePath_Click);
            // 
            // labelStartIndex
            // 
            this.labelStartIndex.AutoSize = true;
            this.labelStartIndex.Location = new System.Drawing.Point(12, 69);
            this.labelStartIndex.Name = "labelStartIndex";
            this.labelStartIndex.Size = new System.Drawing.Size(61, 13);
            this.labelStartIndex.TabIndex = 4;
            this.labelStartIndex.Text = "Start Index:";
            // 
            // numericUpDownStartIndex
            // 
            this.numericUpDownStartIndex.Location = new System.Drawing.Point(16, 86);
            this.numericUpDownStartIndex.Name = "numericUpDownStartIndex";
            this.numericUpDownStartIndex.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownStartIndex.TabIndex = 5;
            // 
            // labelStopIndex
            // 
            this.labelStopIndex.AutoSize = true;
            this.labelStopIndex.Location = new System.Drawing.Point(141, 68);
            this.labelStopIndex.Name = "labelStopIndex";
            this.labelStopIndex.Size = new System.Drawing.Size(61, 13);
            this.labelStopIndex.TabIndex = 6;
            this.labelStopIndex.Text = "Stop Index:";
            // 
            // numericUpDownStopIndex
            // 
            this.numericUpDownStopIndex.Location = new System.Drawing.Point(144, 85);
            this.numericUpDownStopIndex.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStopIndex.Name = "numericUpDownStopIndex";
            this.numericUpDownStopIndex.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownStopIndex.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(249, 82);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(330, 82);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 131);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status:";
            // 
            // labelStatusCurrent
            // 
            this.labelStatusCurrent.AutoSize = true;
            this.labelStatusCurrent.Location = new System.Drawing.Point(49, 131);
            this.labelStatusCurrent.Name = "labelStatusCurrent";
            this.labelStatusCurrent.Size = new System.Drawing.Size(47, 13);
            this.labelStatusCurrent.TabIndex = 11;
            this.labelStatusCurrent.Text = "Stopped";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 148);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(393, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(115, 131);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(73, 13);
            this.labelIndex.TabIndex = 13;
            this.labelIndex.Text = "Current Index:";
            // 
            // labelIndexCurrent
            // 
            this.labelIndexCurrent.AutoSize = true;
            this.labelIndexCurrent.Location = new System.Drawing.Point(194, 131);
            this.labelIndexCurrent.Name = "labelIndexCurrent";
            this.labelIndexCurrent.Size = new System.Drawing.Size(13, 13);
            this.labelIndexCurrent.TabIndex = 14;
            this.labelIndexCurrent.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 441);
            this.Controls.Add(this.labelIndexCurrent);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatusCurrent);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownStopIndex);
            this.Controls.Add(this.labelStopIndex);
            this.Controls.Add(this.numericUpDownStartIndex);
            this.Controls.Add(this.labelStartIndex);
            this.Controls.Add(this.buttonSavePath);
            this.Controls.Add(this.labelSavePath);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.textBoxConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStopIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Label labelSavePath;
        private System.Windows.Forms.Button buttonSavePath;
        private System.Windows.Forms.Label labelStartIndex;
        private System.Windows.Forms.NumericUpDown numericUpDownStartIndex;
        private System.Windows.Forms.Label labelStopIndex;
        private System.Windows.Forms.NumericUpDown numericUpDownStopIndex;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusCurrent;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelIndexCurrent;
    }
}


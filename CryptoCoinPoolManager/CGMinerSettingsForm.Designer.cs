namespace CryptoCoinPoolManager
{
    partial class CGMinerSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.displayNameTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.scryptCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.intensityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.overheatTextBox = new System.Windows.Forms.TextBox();
            this.cutoffTextBox = new System.Windows.Forms.TextBox();
            this.autoFanCheckBox = new System.Windows.Forms.CheckBox();
            this.autoGpuCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.overclockRangeTextBox = new System.Windows.Forms.TextBox();
            this.shadersCheckBox = new System.Windows.Forms.CheckBox();
            this.shadersTextBox = new System.Windows.Forms.TextBox();
            this.threadConcurrencyTextBox = new System.Windows.Forms.TextBox();
            this.threadConcurrencyCheckBox = new System.Windows.Forms.CheckBox();
            this.verboseCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.customParametersTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display/pool name:";
            // 
            // displayNameTextBox
            // 
            this.displayNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayNameTextBox.Location = new System.Drawing.Point(105, 13);
            this.displayNameTextBox.Name = "displayNameTextBox";
            this.displayNameTextBox.Size = new System.Drawing.Size(235, 20);
            this.displayNameTextBox.TabIndex = 2;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(105, 19);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(235, 20);
            this.urlTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Url:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(105, 45);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(39, 20);
            this.portTextBox.TabIndex = 11;
            // 
            // scryptCheckBox
            // 
            this.scryptCheckBox.AutoSize = true;
            this.scryptCheckBox.Checked = true;
            this.scryptCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scryptCheckBox.Location = new System.Drawing.Point(176, 41);
            this.scryptCheckBox.Name = "scryptCheckBox";
            this.scryptCheckBox.Size = new System.Drawing.Size(56, 17);
            this.scryptCheckBox.TabIndex = 5;
            this.scryptCheckBox.Text = "Scrypt";
            this.scryptCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.workerPasswordTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.workerNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.urlTextBox);
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection settings";
            // 
            // workerPasswordTextBox
            // 
            this.workerPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workerPasswordTextBox.Location = new System.Drawing.Point(105, 97);
            this.workerPasswordTextBox.Name = "workerPasswordTextBox";
            this.workerPasswordTextBox.Size = new System.Drawing.Size(235, 20);
            this.workerPasswordTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Worker password:";
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workerNameTextBox.Location = new System.Drawing.Point(105, 71);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.Size = new System.Drawing.Size(235, 20);
            this.workerNameTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Worker name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.verboseCheckBox);
            this.groupBox2.Controls.Add(this.intensityComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.scryptCheckBox);
            this.groupBox2.Controls.Add(this.displayNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 68);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic settings";
            // 
            // intensityComboBox
            // 
            this.intensityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intensityComboBox.FormattingEnabled = true;
            this.intensityComboBox.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.intensityComboBox.Location = new System.Drawing.Point(105, 39);
            this.intensityComboBox.Name = "intensityComboBox";
            this.intensityComboBox.Size = new System.Drawing.Size(55, 21);
            this.intensityComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Intensity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Target";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Overheat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cutoff";
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(122, 20);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(32, 20);
            this.targetTextBox.TabIndex = 19;
            // 
            // overheatTextBox
            // 
            this.overheatTextBox.Location = new System.Drawing.Point(217, 20);
            this.overheatTextBox.Name = "overheatTextBox";
            this.overheatTextBox.Size = new System.Drawing.Size(32, 20);
            this.overheatTextBox.TabIndex = 21;
            // 
            // cutoffTextBox
            // 
            this.cutoffTextBox.Location = new System.Drawing.Point(296, 20);
            this.cutoffTextBox.Name = "cutoffTextBox";
            this.cutoffTextBox.Size = new System.Drawing.Size(31, 20);
            this.cutoffTextBox.TabIndex = 23;
            // 
            // autoFanCheckBox
            // 
            this.autoFanCheckBox.AutoSize = true;
            this.autoFanCheckBox.Location = new System.Drawing.Point(6, 22);
            this.autoFanCheckBox.Name = "autoFanCheckBox";
            this.autoFanCheckBox.Size = new System.Drawing.Size(66, 17);
            this.autoFanCheckBox.TabIndex = 17;
            this.autoFanCheckBox.Text = "Auto fan";
            this.autoFanCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoGpuCheckBox
            // 
            this.autoGpuCheckBox.AutoSize = true;
            this.autoGpuCheckBox.Location = new System.Drawing.Point(6, 34);
            this.autoGpuCheckBox.Name = "autoGpuCheckBox";
            this.autoGpuCheckBox.Size = new System.Drawing.Size(69, 17);
            this.autoGpuCheckBox.TabIndex = 26;
            this.autoGpuCheckBox.Text = "Auto-gpu";
            this.autoGpuCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cutoffTextBox);
            this.groupBox3.Controls.Add(this.autoFanCheckBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.overheatTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.targetTextBox);
            this.groupBox3.Location = new System.Drawing.Point(15, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 52);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Temperature settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.threadConcurrencyTextBox);
            this.groupBox4.Controls.Add(this.threadConcurrencyCheckBox);
            this.groupBox4.Controls.Add(this.shadersTextBox);
            this.groupBox4.Controls.Add(this.shadersCheckBox);
            this.groupBox4.Controls.Add(this.overclockRangeTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.autoGpuCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 112);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GPU Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Overclock range";
            // 
            // overclockRangeTextBox
            // 
            this.overclockRangeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overclockRangeTextBox.Location = new System.Drawing.Point(134, 32);
            this.overclockRangeTextBox.Name = "overclockRangeTextBox";
            this.overclockRangeTextBox.Size = new System.Drawing.Size(206, 20);
            this.overclockRangeTextBox.TabIndex = 27;
            // 
            // shadersCheckBox
            // 
            this.shadersCheckBox.AutoSize = true;
            this.shadersCheckBox.Location = new System.Drawing.Point(6, 60);
            this.shadersCheckBox.Name = "shadersCheckBox";
            this.shadersCheckBox.Size = new System.Drawing.Size(65, 17);
            this.shadersCheckBox.TabIndex = 28;
            this.shadersCheckBox.Text = "Shaders";
            this.shadersCheckBox.UseVisualStyleBackColor = true;
            // 
            // shadersTextBox
            // 
            this.shadersTextBox.Location = new System.Drawing.Point(134, 58);
            this.shadersTextBox.Name = "shadersTextBox";
            this.shadersTextBox.Size = new System.Drawing.Size(49, 20);
            this.shadersTextBox.TabIndex = 29;
            // 
            // threadConcurrencyTextBox
            // 
            this.threadConcurrencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threadConcurrencyTextBox.Location = new System.Drawing.Point(134, 83);
            this.threadConcurrencyTextBox.Name = "threadConcurrencyTextBox";
            this.threadConcurrencyTextBox.Size = new System.Drawing.Size(206, 20);
            this.threadConcurrencyTextBox.TabIndex = 31;
            // 
            // threadConcurrencyCheckBox
            // 
            this.threadConcurrencyCheckBox.AutoSize = true;
            this.threadConcurrencyCheckBox.Location = new System.Drawing.Point(6, 86);
            this.threadConcurrencyCheckBox.Name = "threadConcurrencyCheckBox";
            this.threadConcurrencyCheckBox.Size = new System.Drawing.Size(122, 17);
            this.threadConcurrencyCheckBox.TabIndex = 30;
            this.threadConcurrencyCheckBox.Text = "Thread concurrency";
            this.threadConcurrencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // verboseCheckBox
            // 
            this.verboseCheckBox.AutoSize = true;
            this.verboseCheckBox.Location = new System.Drawing.Point(241, 41);
            this.verboseCheckBox.Name = "verboseCheckBox";
            this.verboseCheckBox.Size = new System.Drawing.Size(65, 17);
            this.verboseCheckBox.TabIndex = 6;
            this.verboseCheckBox.Text = "Verbose";
            this.verboseCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.customParametersTextBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(12, 397);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 51);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Custom settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Custom parameters:";
            // 
            // customParametersTextBox
            // 
            this.customParametersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customParametersTextBox.Location = new System.Drawing.Point(134, 19);
            this.customParametersTextBox.Name = "customParametersTextBox";
            this.customParametersTextBox.Size = new System.Drawing.Size(206, 20);
            this.customParametersTextBox.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(202, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(283, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CGMinerSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(386, 524);
            this.MinimumSize = new System.Drawing.Size(386, 524);
            this.Name = "CGMinerSettingsForm";
            this.Text = "CG Miner Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayNameTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.CheckBox scryptCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox workerPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox intensityComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox verboseCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.TextBox overheatTextBox;
        private System.Windows.Forms.TextBox cutoffTextBox;
        private System.Windows.Forms.CheckBox autoFanCheckBox;
        private System.Windows.Forms.CheckBox autoGpuCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox threadConcurrencyTextBox;
        private System.Windows.Forms.CheckBox threadConcurrencyCheckBox;
        private System.Windows.Forms.TextBox shadersTextBox;
        private System.Windows.Forms.CheckBox shadersCheckBox;
        private System.Windows.Forms.TextBox overclockRangeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox customParametersTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
namespace CircuitSolver
{
    partial class CircuitSolver
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
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.VGenTrackBar = new System.Windows.Forms.TrackBar();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SolveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.VGenTextBox = new System.Windows.Forms.TextBox();
            this.FrequencyTextBox = new System.Windows.Forms.TextBox();
            this.VGenLabel = new System.Windows.Forms.Label();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.RGenComboBox = new System.Windows.Forms.ComboBox();
            this.RGenLabel = new System.Windows.Forms.Label();
            this.R1ValueComboBox = new System.Windows.Forms.ComboBox();
            this.C1ValueComboBox = new System.Windows.Forms.ComboBox();
            this.C2ValueComboBox = new System.Windows.Forms.ComboBox();
            this.L1ValueComboBox = new System.Windows.Forms.ComboBox();
            this.R1PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.C1PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.C2PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.L1PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.R1Label = new System.Windows.Forms.Label();
            this.C1Label = new System.Windows.Forms.Label();
            this.C2abel = new System.Windows.Forms.Label();
            this.L1Label = new System.Windows.Forms.Label();
            this.PolarRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangularRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VGenTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(12, 21);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(713, 354);
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            // 
            // VGenTrackBar
            // 
            this.VGenTrackBar.Location = new System.Drawing.Point(12, 381);
            this.VGenTrackBar.Name = "VGenTrackBar";
            this.VGenTrackBar.Size = new System.Drawing.Size(286, 56);
            this.VGenTrackBar.TabIndex = 1;
            this.VGenTrackBar.Scroll += new System.EventHandler(this.VGenTrackBar_Scroll);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(590, 521);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(84, 50);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(680, 521);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(95, 50);
            this.SolveButton.TabIndex = 2;
            this.SolveButton.Text = "&Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(781, 522);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(101, 50);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // VGenTextBox
            // 
            this.VGenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VGenTextBox.Location = new System.Drawing.Point(91, 455);
            this.VGenTextBox.Name = "VGenTextBox";
            this.VGenTextBox.Size = new System.Drawing.Size(64, 30);
            this.VGenTextBox.TabIndex = 3;
            this.VGenTextBox.TextChanged += new System.EventHandler(this.VGenTextBox_TextChanged);
            // 
            // FrequencyTextBox
            // 
            this.FrequencyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyTextBox.Location = new System.Drawing.Point(168, 532);
            this.FrequencyTextBox.Name = "FrequencyTextBox";
            this.FrequencyTextBox.Size = new System.Drawing.Size(126, 30);
            this.FrequencyTextBox.TabIndex = 3;
            this.FrequencyTextBox.TextChanged += new System.EventHandler(this.FrequencyTextBox_TextChanged);
            // 
            // VGenLabel
            // 
            this.VGenLabel.AutoSize = true;
            this.VGenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VGenLabel.Location = new System.Drawing.Point(22, 455);
            this.VGenLabel.Name = "VGenLabel";
            this.VGenLabel.Size = new System.Drawing.Size(63, 25);
            this.VGenLabel.TabIndex = 4;
            this.VGenLabel.Text = "VGen";
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyLabel.Location = new System.Drawing.Point(14, 535);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(148, 25);
            this.FrequencyLabel.TabIndex = 4;
            this.FrequencyLabel.Text = "Frequency (Hz)";
            // 
            // RGenComboBox
            // 
            this.RGenComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGenComboBox.FormattingEnabled = true;
            this.RGenComboBox.Location = new System.Drawing.Point(91, 489);
            this.RGenComboBox.Name = "RGenComboBox";
            this.RGenComboBox.Size = new System.Drawing.Size(64, 33);
            this.RGenComboBox.TabIndex = 5;
            // 
            // RGenLabel
            // 
            this.RGenLabel.AutoSize = true;
            this.RGenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGenLabel.Location = new System.Drawing.Point(22, 496);
            this.RGenLabel.Name = "RGenLabel";
            this.RGenLabel.Size = new System.Drawing.Size(62, 25);
            this.RGenLabel.TabIndex = 4;
            this.RGenLabel.Text = "RGen";
            // 
            // R1ValueComboBox
            // 
            this.R1ValueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1ValueComboBox.FormattingEnabled = true;
            this.R1ValueComboBox.Location = new System.Drawing.Point(346, 412);
            this.R1ValueComboBox.Name = "R1ValueComboBox";
            this.R1ValueComboBox.Size = new System.Drawing.Size(145, 33);
            this.R1ValueComboBox.TabIndex = 5;
            // 
            // C1ValueComboBox
            // 
            this.C1ValueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1ValueComboBox.FormattingEnabled = true;
            this.C1ValueComboBox.Location = new System.Drawing.Point(346, 451);
            this.C1ValueComboBox.Name = "C1ValueComboBox";
            this.C1ValueComboBox.Size = new System.Drawing.Size(145, 33);
            this.C1ValueComboBox.TabIndex = 5;
            // 
            // C2ValueComboBox
            // 
            this.C2ValueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2ValueComboBox.FormattingEnabled = true;
            this.C2ValueComboBox.Location = new System.Drawing.Point(346, 490);
            this.C2ValueComboBox.Name = "C2ValueComboBox";
            this.C2ValueComboBox.Size = new System.Drawing.Size(145, 33);
            this.C2ValueComboBox.TabIndex = 5;
            // 
            // L1ValueComboBox
            // 
            this.L1ValueComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1ValueComboBox.FormattingEnabled = true;
            this.L1ValueComboBox.Location = new System.Drawing.Point(346, 529);
            this.L1ValueComboBox.Name = "L1ValueComboBox";
            this.L1ValueComboBox.Size = new System.Drawing.Size(145, 33);
            this.L1ValueComboBox.TabIndex = 5;
            // 
            // R1PrefixComboBox
            // 
            this.R1PrefixComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1PrefixComboBox.FormattingEnabled = true;
            this.R1PrefixComboBox.Location = new System.Drawing.Point(497, 412);
            this.R1PrefixComboBox.Name = "R1PrefixComboBox";
            this.R1PrefixComboBox.Size = new System.Drawing.Size(68, 33);
            this.R1PrefixComboBox.TabIndex = 5;
            // 
            // C1PrefixComboBox
            // 
            this.C1PrefixComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1PrefixComboBox.FormattingEnabled = true;
            this.C1PrefixComboBox.Location = new System.Drawing.Point(497, 451);
            this.C1PrefixComboBox.Name = "C1PrefixComboBox";
            this.C1PrefixComboBox.Size = new System.Drawing.Size(68, 33);
            this.C1PrefixComboBox.TabIndex = 5;
            // 
            // C2PrefixComboBox
            // 
            this.C2PrefixComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2PrefixComboBox.FormattingEnabled = true;
            this.C2PrefixComboBox.Location = new System.Drawing.Point(497, 490);
            this.C2PrefixComboBox.Name = "C2PrefixComboBox";
            this.C2PrefixComboBox.Size = new System.Drawing.Size(68, 33);
            this.C2PrefixComboBox.TabIndex = 5;
            // 
            // L1PrefixComboBox
            // 
            this.L1PrefixComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1PrefixComboBox.FormattingEnabled = true;
            this.L1PrefixComboBox.Location = new System.Drawing.Point(497, 529);
            this.L1PrefixComboBox.Name = "L1PrefixComboBox";
            this.L1PrefixComboBox.Size = new System.Drawing.Size(68, 33);
            this.L1PrefixComboBox.TabIndex = 5;
            // 
            // R1Label
            // 
            this.R1Label.AutoSize = true;
            this.R1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1Label.Location = new System.Drawing.Point(304, 415);
            this.R1Label.Name = "R1Label";
            this.R1Label.Size = new System.Drawing.Size(36, 25);
            this.R1Label.TabIndex = 4;
            this.R1Label.Text = "R1";
            // 
            // C1Label
            // 
            this.C1Label.AutoSize = true;
            this.C1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1Label.Location = new System.Drawing.Point(304, 454);
            this.C1Label.Name = "C1Label";
            this.C1Label.Size = new System.Drawing.Size(38, 25);
            this.C1Label.TabIndex = 4;
            this.C1Label.Text = "C1";
            // 
            // C2abel
            // 
            this.C2abel.AutoSize = true;
            this.C2abel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2abel.Location = new System.Drawing.Point(304, 493);
            this.C2abel.Name = "C2abel";
            this.C2abel.Size = new System.Drawing.Size(38, 25);
            this.C2abel.TabIndex = 4;
            this.C2abel.Text = "C2";
            // 
            // L1Label
            // 
            this.L1Label.AutoSize = true;
            this.L1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1Label.Location = new System.Drawing.Point(304, 532);
            this.L1Label.Name = "L1Label";
            this.L1Label.Size = new System.Drawing.Size(34, 25);
            this.L1Label.TabIndex = 4;
            this.L1Label.Text = "L1";
            // 
            // PolarRadioButton
            // 
            this.PolarRadioButton.AutoSize = true;
            this.PolarRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolarRadioButton.Location = new System.Drawing.Point(607, 408);
            this.PolarRadioButton.Name = "PolarRadioButton";
            this.PolarRadioButton.Size = new System.Drawing.Size(78, 29);
            this.PolarRadioButton.TabIndex = 6;
            this.PolarRadioButton.TabStop = true;
            this.PolarRadioButton.Text = "Polar";
            this.PolarRadioButton.UseVisualStyleBackColor = true;
            // 
            // RectangularRadioButton
            // 
            this.RectangularRadioButton.AutoSize = true;
            this.RectangularRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangularRadioButton.Location = new System.Drawing.Point(607, 434);
            this.RectangularRadioButton.Name = "RectangularRadioButton";
            this.RectangularRadioButton.Size = new System.Drawing.Size(137, 29);
            this.RectangularRadioButton.TabIndex = 7;
            this.RectangularRadioButton.TabStop = true;
            this.RectangularRadioButton.Text = "Rectangular";
            this.RectangularRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 25;
            this.ResultsListBox.Location = new System.Drawing.Point(832, 27);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(395, 429);
            this.ResultsListBox.TabIndex = 8;
            // 
            // CircuitSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 583);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.RectangularRadioButton);
            this.Controls.Add(this.PolarRadioButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.L1PrefixComboBox);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.L1ValueComboBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.C2PrefixComboBox);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.C2ValueComboBox);
            this.Controls.Add(this.VGenTrackBar);
            this.Controls.Add(this.C1PrefixComboBox);
            this.Controls.Add(this.VGenTextBox);
            this.Controls.Add(this.C1ValueComboBox);
            this.Controls.Add(this.VGenLabel);
            this.Controls.Add(this.R1PrefixComboBox);
            this.Controls.Add(this.RGenComboBox);
            this.Controls.Add(this.R1ValueComboBox);
            this.Controls.Add(this.L1Label);
            this.Controls.Add(this.RGenLabel);
            this.Controls.Add(this.C2abel);
            this.Controls.Add(this.FrequencyTextBox);
            this.Controls.Add(this.C1Label);
            this.Controls.Add(this.FrequencyLabel);
            this.Controls.Add(this.R1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CircuitSolver";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AC Circuit Solver";
            this.Load += new System.EventHandler(this.CircuitSolver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VGenTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.TrackBar VGenTrackBar;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox VGenTextBox;
        private System.Windows.Forms.TextBox FrequencyTextBox;
        private System.Windows.Forms.Label VGenLabel;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.ComboBox RGenComboBox;
        private System.Windows.Forms.Label RGenLabel;
        private System.Windows.Forms.ComboBox R1ValueComboBox;
        private System.Windows.Forms.ComboBox C1ValueComboBox;
        private System.Windows.Forms.ComboBox C2ValueComboBox;
        private System.Windows.Forms.ComboBox L1ValueComboBox;
        private System.Windows.Forms.ComboBox R1PrefixComboBox;
        private System.Windows.Forms.ComboBox C1PrefixComboBox;
        private System.Windows.Forms.ComboBox C2PrefixComboBox;
        private System.Windows.Forms.ComboBox L1PrefixComboBox;
        private System.Windows.Forms.Label R1Label;
        private System.Windows.Forms.Label C1Label;
        private System.Windows.Forms.Label C2abel;
        private System.Windows.Forms.Label L1Label;
        private System.Windows.Forms.RadioButton PolarRadioButton;
        private System.Windows.Forms.RadioButton RectangularRadioButton;
        private System.Windows.Forms.ListBox ResultsListBox;
    }
}


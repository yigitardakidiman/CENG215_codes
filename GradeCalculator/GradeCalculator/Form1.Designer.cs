namespace GradeCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rgbTimer = new System.Windows.Forms.Timer(components);
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlInputCard = new Panel();
            lblHeaderExam = new Label();
            lblHeaderGrade = new Label();
            lblHeaderWeight = new Label();
            pnlDivider = new Panel();
            lblLab = new Label();
            txtLab = new TextBox();
            txtLabWeight = new TextBox();
            lblPercentLab = new Label();
            lblHomework = new Label();
            txtHomework = new TextBox();
            txtHomeworkWeight = new TextBox();
            lblPercentHomework = new Label();
            lblMidterm = new Label();
            txtMidterm = new TextBox();
            txtMidtermWeight = new TextBox();
            lblPercentMidterm = new Label();
            lblFinal = new Label();
            txtFinal = new TextBox();
            txtFinalWeight = new TextBox();
            lblPercentFinal = new Label();
            lblInfoNote = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            pnlAverageCard = new Panel();
            lblAverageTitle = new Label();
            lblAverage = new Label();
            pnlLetterCard = new Panel();
            lblLetterGradeTitle = new Label();
            lblLetterGrade = new Label();
            pnlHeader.SuspendLayout();
            pnlInputCard.SuspendLayout();
            pnlAverageCard.SuspendLayout();
            pnlLetterCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 58, 138);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(480, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(219, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ders Notu Hesaplama";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(219, 234, 254);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(337, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Notlarınızı ve ağırlık yüzdelerini girerek ortalamanızı hesaplayın";
            // 
            // pnlInputCard
            // 
            pnlInputCard.BackColor = Color.White;
            pnlInputCard.BorderStyle = BorderStyle.FixedSingle;
            pnlInputCard.Controls.Add(lblHeaderExam);
            pnlInputCard.Controls.Add(lblHeaderGrade);
            pnlInputCard.Controls.Add(lblHeaderWeight);
            pnlInputCard.Controls.Add(pnlDivider);
            pnlInputCard.Controls.Add(lblLab);
            pnlInputCard.Controls.Add(txtLab);
            pnlInputCard.Controls.Add(txtLabWeight);
            pnlInputCard.Controls.Add(lblPercentLab);
            pnlInputCard.Controls.Add(lblHomework);
            pnlInputCard.Controls.Add(txtHomework);
            pnlInputCard.Controls.Add(txtHomeworkWeight);
            pnlInputCard.Controls.Add(lblPercentHomework);
            pnlInputCard.Controls.Add(lblMidterm);
            pnlInputCard.Controls.Add(txtMidterm);
            pnlInputCard.Controls.Add(txtMidtermWeight);
            pnlInputCard.Controls.Add(lblPercentMidterm);
            pnlInputCard.Controls.Add(lblFinal);
            pnlInputCard.Controls.Add(txtFinal);
            pnlInputCard.Controls.Add(txtFinalWeight);
            pnlInputCard.Controls.Add(lblPercentFinal);
            pnlInputCard.Controls.Add(lblInfoNote);
            pnlInputCard.Location = new Point(24, 96);
            pnlInputCard.Name = "pnlInputCard";
            pnlInputCard.Size = new Size(432, 278);
            pnlInputCard.TabIndex = 1;
            // 
            // lblHeaderExam
            // 
            lblHeaderExam.AutoSize = true;
            lblHeaderExam.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHeaderExam.ForeColor = Color.FromArgb(100, 116, 139);
            lblHeaderExam.Location = new Point(20, 16);
            lblHeaderExam.Name = "lblHeaderExam";
            lblHeaderExam.Size = new Size(104, 15);
            lblHeaderExam.TabIndex = 0;
            lblHeaderExam.Text = "DEĞERLENDİRME";
            // 
            // lblHeaderGrade
            // 
            lblHeaderGrade.AutoSize = true;
            lblHeaderGrade.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHeaderGrade.ForeColor = Color.FromArgb(100, 116, 139);
            lblHeaderGrade.Location = new Point(185, 16);
            lblHeaderGrade.Name = "lblHeaderGrade";
            lblHeaderGrade.Size = new Size(76, 15);
            lblHeaderGrade.TabIndex = 1;
            lblHeaderGrade.Text = "NOT (0-100)";
            // 
            // lblHeaderWeight
            // 
            lblHeaderWeight.AutoSize = true;
            lblHeaderWeight.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblHeaderWeight.ForeColor = Color.FromArgb(100, 116, 139);
            lblHeaderWeight.Location = new Point(305, 16);
            lblHeaderWeight.Name = "lblHeaderWeight";
            lblHeaderWeight.Size = new Size(75, 15);
            lblHeaderWeight.TabIndex = 2;
            lblHeaderWeight.Text = "AĞIRLIK (%)";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(226, 232, 240);
            pnlDivider.Location = new Point(20, 38);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(390, 1);
            pnlDivider.TabIndex = 3;
            // 
            // lblLab
            // 
            lblLab.AutoSize = true;
            lblLab.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblLab.ForeColor = Color.FromArgb(30, 41, 59);
            lblLab.Location = new Point(20, 58);
            lblLab.Name = "lblLab";
            lblLab.Size = new Size(70, 19);
            lblLab.TabIndex = 4;
            lblLab.Text = "Lab Notu";
            // 
            // txtLab
            // 
            txtLab.Font = new Font("Segoe UI", 10.5F);
            txtLab.Location = new Point(185, 54);
            txtLab.Name = "txtLab";
            txtLab.PlaceholderText = "0 - 100";
            txtLab.Size = new Size(95, 26);
            txtLab.TabIndex = 5;
            txtLab.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLabWeight
            // 
            txtLabWeight.Font = new Font("Segoe UI", 10.5F);
            txtLabWeight.Location = new Point(305, 54);
            txtLabWeight.Name = "txtLabWeight";
            txtLabWeight.PlaceholderText = "Örn: 15";
            txtLabWeight.Size = new Size(80, 26);
            txtLabWeight.TabIndex = 6;
            txtLabWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPercentLab
            // 
            lblPercentLab.AutoSize = true;
            lblPercentLab.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPercentLab.ForeColor = Color.FromArgb(100, 116, 139);
            lblPercentLab.Location = new Point(391, 58);
            lblPercentLab.Name = "lblPercentLab";
            lblPercentLab.Size = new Size(21, 19);
            lblPercentLab.TabIndex = 7;
            lblPercentLab.Text = "%";
            // 
            // lblHomework
            // 
            lblHomework.AutoSize = true;
            lblHomework.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHomework.ForeColor = Color.FromArgb(30, 41, 59);
            lblHomework.Location = new Point(20, 108);
            lblHomework.Name = "lblHomework";
            lblHomework.Size = new Size(121, 19);
            lblHomework.TabIndex = 8;
            lblHomework.Text = "Homework Notu";
            // 
            // txtHomework
            // 
            txtHomework.Font = new Font("Segoe UI", 10.5F);
            txtHomework.Location = new Point(185, 104);
            txtHomework.Name = "txtHomework";
            txtHomework.PlaceholderText = "0 - 100";
            txtHomework.Size = new Size(95, 26);
            txtHomework.TabIndex = 9;
            txtHomework.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHomeworkWeight
            // 
            txtHomeworkWeight.Font = new Font("Segoe UI", 10.5F);
            txtHomeworkWeight.Location = new Point(305, 104);
            txtHomeworkWeight.Name = "txtHomeworkWeight";
            txtHomeworkWeight.PlaceholderText = "Örn: 15";
            txtHomeworkWeight.Size = new Size(80, 26);
            txtHomeworkWeight.TabIndex = 10;
            txtHomeworkWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPercentHomework
            // 
            lblPercentHomework.AutoSize = true;
            lblPercentHomework.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPercentHomework.ForeColor = Color.FromArgb(100, 116, 139);
            lblPercentHomework.Location = new Point(391, 108);
            lblPercentHomework.Name = "lblPercentHomework";
            lblPercentHomework.Size = new Size(21, 19);
            lblPercentHomework.TabIndex = 11;
            lblPercentHomework.Text = "%";
            // 
            // lblMidterm
            // 
            lblMidterm.AutoSize = true;
            lblMidterm.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblMidterm.ForeColor = Color.FromArgb(30, 41, 59);
            lblMidterm.Location = new Point(20, 158);
            lblMidterm.Name = "lblMidterm";
            lblMidterm.Size = new Size(104, 19);
            lblMidterm.TabIndex = 12;
            lblMidterm.Text = "Midterm Notu";
            // 
            // txtMidterm
            // 
            txtMidterm.Font = new Font("Segoe UI", 10.5F);
            txtMidterm.Location = new Point(185, 154);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.PlaceholderText = "0 - 100";
            txtMidterm.Size = new Size(95, 26);
            txtMidterm.TabIndex = 13;
            txtMidterm.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMidtermWeight
            // 
            txtMidtermWeight.Font = new Font("Segoe UI", 10.5F);
            txtMidtermWeight.Location = new Point(305, 154);
            txtMidtermWeight.Name = "txtMidtermWeight";
            txtMidtermWeight.PlaceholderText = "Örn: 30";
            txtMidtermWeight.Size = new Size(80, 26);
            txtMidtermWeight.TabIndex = 14;
            txtMidtermWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPercentMidterm
            // 
            lblPercentMidterm.AutoSize = true;
            lblPercentMidterm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPercentMidterm.ForeColor = Color.FromArgb(100, 116, 139);
            lblPercentMidterm.Location = new Point(391, 158);
            lblPercentMidterm.Name = "lblPercentMidterm";
            lblPercentMidterm.Size = new Size(21, 19);
            lblPercentMidterm.TabIndex = 15;
            lblPercentMidterm.Text = "%";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFinal.ForeColor = Color.FromArgb(30, 41, 59);
            lblFinal.Location = new Point(20, 208);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(77, 19);
            lblFinal.TabIndex = 16;
            lblFinal.Text = "Final Notu";
            // 
            // txtFinal
            // 
            txtFinal.Font = new Font("Segoe UI", 10.5F);
            txtFinal.Location = new Point(185, 204);
            txtFinal.Name = "txtFinal";
            txtFinal.PlaceholderText = "0 - 100";
            txtFinal.Size = new Size(95, 26);
            txtFinal.TabIndex = 17;
            txtFinal.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFinalWeight
            // 
            txtFinalWeight.Font = new Font("Segoe UI", 10.5F);
            txtFinalWeight.Location = new Point(305, 204);
            txtFinalWeight.Name = "txtFinalWeight";
            txtFinalWeight.PlaceholderText = "Örn: 40";
            txtFinalWeight.Size = new Size(80, 26);
            txtFinalWeight.TabIndex = 18;
            txtFinalWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPercentFinal
            // 
            lblPercentFinal.AutoSize = true;
            lblPercentFinal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPercentFinal.ForeColor = Color.FromArgb(100, 116, 139);
            lblPercentFinal.Location = new Point(391, 208);
            lblPercentFinal.Name = "lblPercentFinal";
            lblPercentFinal.Size = new Size(21, 19);
            lblPercentFinal.TabIndex = 19;
            lblPercentFinal.Text = "%";
            // 
            // lblInfoNote
            // 
            lblInfoNote.AutoSize = true;
            lblInfoNote.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            lblInfoNote.ForeColor = Color.FromArgb(100, 116, 139);
            lblInfoNote.Location = new Point(20, 246);
            lblInfoNote.Name = "lblInfoNote";
            lblInfoNote.Size = new Size(313, 13);
            lblInfoNote.TabIndex = 20;
            lblInfoNote.Text = "* Dersinizde bulunmayan değerlendirmeler için 0 değerini giriniz.";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(37, 99, 235);
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(24, 390);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(310, 46);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "ORTALAMAYI HESAPLA";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(226, 232, 240);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(346, 390);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 46);
            btnClear.TabIndex = 3;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlAverageCard
            // 
            pnlAverageCard.BackColor = Color.White;
            pnlAverageCard.BorderStyle = BorderStyle.FixedSingle;
            pnlAverageCard.Controls.Add(lblAverageTitle);
            pnlAverageCard.Controls.Add(lblAverage);
            pnlAverageCard.Location = new Point(24, 452);
            pnlAverageCard.Name = "pnlAverageCard";
            pnlAverageCard.Size = new Size(208, 125);
            pnlAverageCard.TabIndex = 4;
            // 
            // lblAverageTitle
            // 
            lblAverageTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAverageTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblAverageTitle.Location = new Point(0, 16);
            lblAverageTitle.Name = "lblAverageTitle";
            lblAverageTitle.Size = new Size(206, 20);
            lblAverageTitle.TabIndex = 0;
            lblAverageTitle.Text = "SAYISAL ORTALAMA";
            lblAverageTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAverage
            // 
            lblAverage.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAverage.ForeColor = Color.FromArgb(37, 99, 235);
            lblAverage.Location = new Point(0, 44);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(206, 60);
            lblAverage.TabIndex = 1;
            lblAverage.Text = "0.00";
            lblAverage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLetterCard
            // 
            pnlLetterCard.BackColor = Color.White;
            pnlLetterCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLetterCard.Controls.Add(lblLetterGradeTitle);
            pnlLetterCard.Controls.Add(lblLetterGrade);
            pnlLetterCard.Location = new Point(248, 452);
            pnlLetterCard.Name = "pnlLetterCard";
            pnlLetterCard.Size = new Size(208, 125);
            pnlLetterCard.TabIndex = 5;
            // 
            // lblLetterGradeTitle
            // 
            lblLetterGradeTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLetterGradeTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblLetterGradeTitle.Location = new Point(0, 16);
            lblLetterGradeTitle.Name = "lblLetterGradeTitle";
            lblLetterGradeTitle.Size = new Size(206, 20);
            lblLetterGradeTitle.TabIndex = 0;
            lblLetterGradeTitle.Text = "HARF NOTU";
            lblLetterGradeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetterGrade
            // 
            lblLetterGrade.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLetterGrade.ForeColor = Color.FromArgb(15, 23, 42);
            lblLetterGrade.Location = new Point(0, 44);
            lblLetterGrade.Name = "lblLetterGrade";
            lblLetterGrade.Size = new Size(206, 60);
            lblLetterGrade.TabIndex = 1;
            lblLetterGrade.Text = "--";
            lblLetterGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rgbTimer
            // 
            rgbTimer.Enabled = true;
            rgbTimer.Interval = 20;
            rgbTimer.Tick += rgbTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 0, 0);
            ClientSize = new Size(480, 600);
            Controls.Add(pnlLetterCard);
            Controls.Add(pnlAverageCard);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(pnlInputCard);
            Controls.Add(pnlHeader);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ders Notu Hesaplama";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInputCard.ResumeLayout(false);
            pnlInputCard.PerformLayout();
            pnlAverageCard.ResumeLayout(false);
            pnlLetterCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private int rgbR = 255;
        private int rgbG = 0;
        private int rgbB = 0;

        private void rgbTimer_Tick(object? sender, EventArgs e)
        {
            const int step = 9;

            if (rgbR == 255 && rgbB == 0 && rgbG < 255)
                rgbG = Math.Clamp(rgbG + step, 0, 255);
            else if (rgbG == 255 && rgbB == 0 && rgbR > 0)
                rgbR = Math.Clamp(rgbR - step, 0, 255);
            else if (rgbG == 255 && rgbR == 0 && rgbB < 255)
                rgbB = Math.Clamp(rgbB + step, 0, 255);
            else if (rgbB == 255 && rgbR == 0 && rgbG > 0)
                rgbG = Math.Clamp(rgbG - step, 0, 255);
            else if (rgbB == 255 && rgbG == 0 && rgbR < 255)
                rgbR = Math.Clamp(rgbR + step, 0, 255);
            else if (rgbR == 255 && rgbG == 0 && rgbB > 0)
                rgbB = Math.Clamp(rgbB - step, 0, 255);

            Color accentRgb = Color.FromArgb(rgbR * 2 / 3, rgbG * 2 / 3, rgbB * 2 / 3);
            BackColor = Color.FromArgb(rgbR, rgbG, rgbB);
            pnlHeader.BackColor = accentRgb;
            btnCalculate.BackColor = accentRgb;
            btnClear.BackColor = accentRgb;
            lblAverage.ForeColor = accentRgb;
            lblLetterGrade.ForeColor = accentRgb;
        }

        private System.Windows.Forms.Timer rgbTimer;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlInputCard;
        private Label lblHeaderExam;
        private Label lblHeaderGrade;
        private Label lblHeaderWeight;
        private Panel pnlDivider;
        private Label lblLab;
        private TextBox txtLab;
        private TextBox txtLabWeight;
        private Label lblPercentLab;
        private Label lblHomework;
        private TextBox txtHomework;
        private TextBox txtHomeworkWeight;
        private Label lblPercentHomework;
        private Label lblMidterm;
        private TextBox txtMidterm;
        private TextBox txtMidtermWeight;
        private Label lblPercentMidterm;
        private Label lblFinal;
        private TextBox txtFinal;
        private TextBox txtFinalWeight;
        private Label lblPercentFinal;
        private Label lblInfoNote;
        private Button btnCalculate;
        private Button btnClear;
        private Panel pnlAverageCard;
        private Label lblAverageTitle;
        private Label lblAverage;
        private Panel pnlLetterCard;
        private Label lblLetterGradeTitle;
        private Label lblLetterGrade;
    }
}


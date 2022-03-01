
namespace MasterMind
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
            this.buttonPopytka = new System.Windows.Forms.Button();
            this.labelLevelTextUp = new System.Windows.Forms.Label();
            this.labelLevelTextDown = new System.Windows.Forms.Label();
            this.labelInputOtgadka = new System.Windows.Forms.Label();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.mtbInputOtgadka = new System.Windows.Forms.MaskedTextBox();
            this.labelScoreText = new System.Windows.Forms.Label();
            this.labelScorePoint = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.panelLevelSelect = new System.Windows.Forms.Panel();
            this.rtbHintHard = new System.Windows.Forms.RichTextBox();
            this.rtbHintMiddle = new System.Windows.Forms.RichTextBox();
            this.rtbHintEasy = new System.Windows.Forms.RichTextBox();
            this.buttonLevelHard = new System.Windows.Forms.Button();
            this.buttonLevelMiddle = new System.Windows.Forms.Button();
            this.buttonLevelEasy = new System.Windows.Forms.Button();
            this.labelLevelSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLevelSelect.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPopytka
            // 
            this.buttonPopytka.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPopytka.Location = new System.Drawing.Point(13, 448);
            this.buttonPopytka.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPopytka.Name = "buttonPopytka";
            this.buttonPopytka.Size = new System.Drawing.Size(95, 64);
            this.buttonPopytka.TabIndex = 3;
            this.buttonPopytka.Text = "Угадать!";
            this.buttonPopytka.UseVisualStyleBackColor = true;
            this.buttonPopytka.Click += new System.EventHandler(this.buttonPopytka_Click);
            // 
            // labelLevelTextUp
            // 
            this.labelLevelTextUp.AutoSize = true;
            this.labelLevelTextUp.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelTextUp.Location = new System.Drawing.Point(8, 47);
            this.labelLevelTextUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLevelTextUp.Name = "labelLevelTextUp";
            this.labelLevelTextUp.Size = new System.Drawing.Size(378, 26);
            this.labelLevelTextUp.TabIndex = 4;
            this.labelLevelTextUp.Text = "Компьютер загадал    -значное число с ";
            // 
            // labelLevelTextDown
            // 
            this.labelLevelTextDown.AutoSize = true;
            this.labelLevelTextDown.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelTextDown.Location = new System.Drawing.Point(8, 73);
            this.labelLevelTextDown.Name = "labelLevelTextDown";
            this.labelLevelTextDown.Size = new System.Drawing.Size(297, 26);
            this.labelLevelTextDown.TabIndex = 6;
            this.labelLevelTextDown.Text = "НЕповторяющимися цифрами.";
            // 
            // labelInputOtgadka
            // 
            this.labelInputOtgadka.AutoSize = true;
            this.labelInputOtgadka.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputOtgadka.Location = new System.Drawing.Point(13, 146);
            this.labelInputOtgadka.Name = "labelInputOtgadka";
            this.labelInputOtgadka.Size = new System.Drawing.Size(147, 26);
            this.labelInputOtgadka.TabIndex = 7;
            this.labelInputOtgadka.Text = "Введите число";
            // 
            // rtbChat
            // 
            this.rtbChat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbChat.Location = new System.Drawing.Point(13, 178);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbChat.Size = new System.Drawing.Size(380, 263);
            this.rtbChat.TabIndex = 13;
            this.rtbChat.Text = "";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(298, 448);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(95, 64);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // mtbInputOtgadka
            // 
            this.mtbInputOtgadka.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbInputOtgadka.Location = new System.Drawing.Point(247, 138);
            this.mtbInputOtgadka.Mask = "000000";
            this.mtbInputOtgadka.Name = "mtbInputOtgadka";
            this.mtbInputOtgadka.Size = new System.Drawing.Size(144, 34);
            this.mtbInputOtgadka.TabIndex = 15;
            this.mtbInputOtgadka.ValidatingType = typeof(int);
            // 
            // labelScoreText
            // 
            this.labelScoreText.AutoSize = true;
            this.labelScoreText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScoreText.Location = new System.Drawing.Point(8, 102);
            this.labelScoreText.Name = "labelScoreText";
            this.labelScoreText.Size = new System.Drawing.Size(76, 26);
            this.labelScoreText.TabIndex = 16;
            this.labelScoreText.Text = "Очки:  ";
            // 
            // labelScorePoint
            // 
            this.labelScorePoint.AutoSize = true;
            this.labelScorePoint.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScorePoint.Location = new System.Drawing.Point(242, 102);
            this.labelScorePoint.Name = "labelScorePoint";
            this.labelScorePoint.Size = new System.Drawing.Size(24, 26);
            this.labelScorePoint.TabIndex = 17;
            this.labelScorePoint.Text = "0";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.Location = new System.Drawing.Point(191, 47);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 26);
            this.labelLevel.TabIndex = 18;
            this.labelLevel.Text = "10";
            // 
            // panelLevelSelect
            // 
            this.panelLevelSelect.Controls.Add(this.rtbHintHard);
            this.panelLevelSelect.Controls.Add(this.rtbHintMiddle);
            this.panelLevelSelect.Controls.Add(this.rtbHintEasy);
            this.panelLevelSelect.Controls.Add(this.buttonLevelHard);
            this.panelLevelSelect.Controls.Add(this.buttonLevelMiddle);
            this.panelLevelSelect.Controls.Add(this.buttonLevelEasy);
            this.panelLevelSelect.Controls.Add(this.labelLevelSelect);
            this.panelLevelSelect.Location = new System.Drawing.Point(454, 73);
            this.panelLevelSelect.Name = "panelLevelSelect";
            this.panelLevelSelect.Size = new System.Drawing.Size(372, 345);
            this.panelLevelSelect.TabIndex = 19;
            // 
            // rtbHintHard
            // 
            this.rtbHintHard.Enabled = false;
            this.rtbHintHard.Location = new System.Drawing.Point(123, 249);
            this.rtbHintHard.Name = "rtbHintHard";
            this.rtbHintHard.Size = new System.Drawing.Size(231, 84);
            this.rtbHintHard.TabIndex = 6;
            this.rtbHintHard.Text = "Компьютер загадывает число из 8 неповторяющихся цифр, отсчёт до нуля идёт с 40 оч" +
    "ков.";
            // 
            // rtbHintMiddle
            // 
            this.rtbHintMiddle.Enabled = false;
            this.rtbHintMiddle.Location = new System.Drawing.Point(123, 150);
            this.rtbHintMiddle.Name = "rtbHintMiddle";
            this.rtbHintMiddle.Size = new System.Drawing.Size(231, 84);
            this.rtbHintMiddle.TabIndex = 5;
            this.rtbHintMiddle.Text = "Компьютер загадывает число из 6 неповторяющихся цифр, отсчёт до нуля идёт с 20 оч" +
    "ков.";
            // 
            // rtbHintEasy
            // 
            this.rtbHintEasy.Enabled = false;
            this.rtbHintEasy.Location = new System.Drawing.Point(123, 54);
            this.rtbHintEasy.Name = "rtbHintEasy";
            this.rtbHintEasy.Size = new System.Drawing.Size(231, 84);
            this.rtbHintEasy.TabIndex = 4;
            this.rtbHintEasy.Text = "Компьютер загадывает число из 4 неповторяющихся цифр, отсчёт до нуля идёт с 10 оч" +
    "ков.";
            // 
            // buttonLevelHard
            // 
            this.buttonLevelHard.Location = new System.Drawing.Point(20, 249);
            this.buttonLevelHard.Name = "buttonLevelHard";
            this.buttonLevelHard.Size = new System.Drawing.Size(85, 37);
            this.buttonLevelHard.TabIndex = 3;
            this.buttonLevelHard.Text = "Сложный";
            this.buttonLevelHard.UseVisualStyleBackColor = true;
            this.buttonLevelHard.Click += new System.EventHandler(this.buttonLevelHard_Click);
            // 
            // buttonLevelMiddle
            // 
            this.buttonLevelMiddle.Location = new System.Drawing.Point(20, 150);
            this.buttonLevelMiddle.Name = "buttonLevelMiddle";
            this.buttonLevelMiddle.Size = new System.Drawing.Size(85, 38);
            this.buttonLevelMiddle.TabIndex = 2;
            this.buttonLevelMiddle.Text = "Обычный";
            this.buttonLevelMiddle.UseVisualStyleBackColor = true;
            this.buttonLevelMiddle.Click += new System.EventHandler(this.buttonLevelMiddle_Click);
            // 
            // buttonLevelEasy
            // 
            this.buttonLevelEasy.Location = new System.Drawing.Point(20, 54);
            this.buttonLevelEasy.Name = "buttonLevelEasy";
            this.buttonLevelEasy.Size = new System.Drawing.Size(85, 36);
            this.buttonLevelEasy.TabIndex = 1;
            this.buttonLevelEasy.Text = "Лёгкий";
            this.buttonLevelEasy.UseVisualStyleBackColor = true;
            this.buttonLevelEasy.Click += new System.EventHandler(this.buttonLevelEasy_Click);
            // 
            // labelLevelSelect
            // 
            this.labelLevelSelect.AutoSize = true;
            this.labelLevelSelect.Location = new System.Drawing.Point(74, 19);
            this.labelLevelSelect.Name = "labelLevelSelect";
            this.labelLevelSelect.Size = new System.Drawing.Size(225, 18);
            this.labelLevelSelect.TabIndex = 0;
            this.labelLevelSelect.Text = "Выберите уровень сложности";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкаяToolStripMenuItem,
            this.обычнаяToolStripMenuItem,
            this.сложнаяToolStripMenuItem});
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            // 
            // легкаяToolStripMenuItem
            // 
            this.легкаяToolStripMenuItem.Name = "легкаяToolStripMenuItem";
            this.легкаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.легкаяToolStripMenuItem.Text = "Легкая";
            this.легкаяToolStripMenuItem.Click += new System.EventHandler(this.buttonLevelEasy_Click);
            // 
            // обычнаяToolStripMenuItem
            // 
            this.обычнаяToolStripMenuItem.Name = "обычнаяToolStripMenuItem";
            this.обычнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обычнаяToolStripMenuItem.Text = "Обычная";
            this.обычнаяToolStripMenuItem.Click += new System.EventHandler(this.buttonLevelMiddle_Click);
            // 
            // сложнаяToolStripMenuItem
            // 
            this.сложнаяToolStripMenuItem.Name = "сложнаяToolStripMenuItem";
            this.сложнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сложнаяToolStripMenuItem.Text = "Сложная";
            this.сложнаяToolStripMenuItem.Click += new System.EventHandler(this.buttonLevelHard_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLevelSelect);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelScorePoint);
            this.Controls.Add(this.labelScoreText);
            this.Controls.Add(this.mtbInputOtgadka);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.labelInputOtgadka);
            this.Controls.Add(this.labelLevelTextDown);
            this.Controls.Add(this.labelLevelTextUp);
            this.Controls.Add(this.buttonPopytka);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLevelSelect.ResumeLayout(false);
            this.panelLevelSelect.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPopytka;
        private System.Windows.Forms.Label labelLevelTextUp;
        private System.Windows.Forms.Label labelLevelTextDown;
        private System.Windows.Forms.Label labelInputOtgadka;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.MaskedTextBox mtbInputOtgadka;
        private System.Windows.Forms.Label labelScoreText;
        private System.Windows.Forms.Label labelScorePoint;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Panel panelLevelSelect;
        private System.Windows.Forms.RichTextBox rtbHintEasy;
        private System.Windows.Forms.Button buttonLevelHard;
        private System.Windows.Forms.Button buttonLevelMiddle;
        private System.Windows.Forms.Button buttonLevelEasy;
        private System.Windows.Forms.Label labelLevelSelect;
        private System.Windows.Forms.RichTextBox rtbHintHard;
        private System.Windows.Forms.RichTextBox rtbHintMiddle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}


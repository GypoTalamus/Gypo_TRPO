
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelScorePoint = new System.Windows.Forms.Label();
            this.labelScoreText = new System.Windows.Forms.Label();
            this.mtbInputOtgadka = new System.Windows.Forms.MaskedTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.labelInputOtgadka = new System.Windows.Forms.Label();
            this.labelLevelTextDown = new System.Windows.Forms.Label();
            this.labelLevelTextUp = new System.Windows.Forms.Label();
            this.buttonPopytka = new System.Windows.Forms.Button();
            this.panelLevelSelect = new System.Windows.Forms.Panel();
            this.rtbHintHard = new System.Windows.Forms.RichTextBox();
            this.rtbHintMiddle = new System.Windows.Forms.RichTextBox();
            this.rtbHintEasy = new System.Windows.Forms.RichTextBox();
            this.buttonLevelHard = new System.Windows.Forms.Button();
            this.buttonLevelMiddle = new System.Windows.Forms.Button();
            this.buttonLevelEasy = new System.Windows.Forms.Button();
            this.labelLevelSelect = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLevelSelect.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.referenceToolStripMenuItem,
            this.ExitToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            resources.ApplyResources(this.новаяИграToolStripMenuItem, "новаяИграToolStripMenuItem");
            this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкаяToolStripMenuItem,
            this.обычнаяToolStripMenuItem,
            this.сложнаяToolStripMenuItem});
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            // 
            // легкаяToolStripMenuItem
            // 
            resources.ApplyResources(this.легкаяToolStripMenuItem, "легкаяToolStripMenuItem");
            this.легкаяToolStripMenuItem.Name = "легкаяToolStripMenuItem";
            this.легкаяToolStripMenuItem.Click += new System.EventHandler(this.buttonLevelEasy_Click);
            // 
            // обычнаяToolStripMenuItem
            // 
            resources.ApplyResources(this.обычнаяToolStripMenuItem, "обычнаяToolStripMenuItem");
            this.обычнаяToolStripMenuItem.Name = "обычнаяToolStripMenuItem";
            this.обычнаяToolStripMenuItem.Click += new System.EventHandler(this.buttonLevelMiddle_Click);
            // 
            // сложнаяToolStripMenuItem
            // 
            resources.ApplyResources(this.сложнаяToolStripMenuItem, "сложнаяToolStripMenuItem");
            this.сложнаяToolStripMenuItem.Name = "сложнаяToolStripMenuItem";
            this.сложнаяToolStripMenuItem.Click += new System.EventHandler(this.buttonLevelHard_Click);
            // 
            // referenceToolStripMenuItem
            // 
            resources.ApplyResources(this.referenceToolStripMenuItem, "referenceToolStripMenuItem");
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Click += new System.EventHandler(this.referenceToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.labelLevel);
            this.panel1.Controls.Add(this.labelScorePoint);
            this.panel1.Controls.Add(this.labelScoreText);
            this.panel1.Controls.Add(this.mtbInputOtgadka);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.rtbChat);
            this.panel1.Controls.Add(this.labelInputOtgadka);
            this.panel1.Controls.Add(this.labelLevelTextDown);
            this.panel1.Controls.Add(this.labelLevelTextUp);
            this.panel1.Controls.Add(this.buttonPopytka);
            this.panel1.Name = "panel1";
            // 
            // labelLevel
            // 
            resources.ApplyResources(this.labelLevel, "labelLevel");
            this.labelLevel.Name = "labelLevel";
            // 
            // labelScorePoint
            // 
            resources.ApplyResources(this.labelScorePoint, "labelScorePoint");
            this.labelScorePoint.Name = "labelScorePoint";
            this.labelScorePoint.Click += new System.EventHandler(this.labelScorePoint_Click);
            // 
            // labelScoreText
            // 
            resources.ApplyResources(this.labelScoreText, "labelScoreText");
            this.labelScoreText.Name = "labelScoreText";
            // 
            // mtbInputOtgadka
            // 
            resources.ApplyResources(this.mtbInputOtgadka, "mtbInputOtgadka");
            this.mtbInputOtgadka.Name = "mtbInputOtgadka";
            this.mtbInputOtgadka.ValidatingType = typeof(int);
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // rtbChat
            // 
            resources.ApplyResources(this.rtbChat, "rtbChat");
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            // 
            // labelInputOtgadka
            // 
            resources.ApplyResources(this.labelInputOtgadka, "labelInputOtgadka");
            this.labelInputOtgadka.Name = "labelInputOtgadka";
            // 
            // labelLevelTextDown
            // 
            resources.ApplyResources(this.labelLevelTextDown, "labelLevelTextDown");
            this.labelLevelTextDown.Name = "labelLevelTextDown";
            // 
            // labelLevelTextUp
            // 
            resources.ApplyResources(this.labelLevelTextUp, "labelLevelTextUp");
            this.labelLevelTextUp.Name = "labelLevelTextUp";
            // 
            // buttonPopytka
            // 
            resources.ApplyResources(this.buttonPopytka, "buttonPopytka");
            this.buttonPopytka.Name = "buttonPopytka";
            this.buttonPopytka.UseVisualStyleBackColor = true;
            this.buttonPopytka.Click += new System.EventHandler(this.buttonPopytka_Click);
            // 
            // panelLevelSelect
            // 
            resources.ApplyResources(this.panelLevelSelect, "panelLevelSelect");
            this.panelLevelSelect.Controls.Add(this.rtbHintHard);
            this.panelLevelSelect.Controls.Add(this.rtbHintMiddle);
            this.panelLevelSelect.Controls.Add(this.rtbHintEasy);
            this.panelLevelSelect.Controls.Add(this.buttonLevelHard);
            this.panelLevelSelect.Controls.Add(this.buttonLevelMiddle);
            this.panelLevelSelect.Controls.Add(this.buttonLevelEasy);
            this.panelLevelSelect.Controls.Add(this.labelLevelSelect);
            this.panelLevelSelect.Name = "panelLevelSelect";
            // 
            // rtbHintHard
            // 
            resources.ApplyResources(this.rtbHintHard, "rtbHintHard");
            this.rtbHintHard.Name = "rtbHintHard";
            // 
            // rtbHintMiddle
            // 
            resources.ApplyResources(this.rtbHintMiddle, "rtbHintMiddle");
            this.rtbHintMiddle.Name = "rtbHintMiddle";
            // 
            // rtbHintEasy
            // 
            resources.ApplyResources(this.rtbHintEasy, "rtbHintEasy");
            this.rtbHintEasy.Name = "rtbHintEasy";
            // 
            // buttonLevelHard
            // 
            resources.ApplyResources(this.buttonLevelHard, "buttonLevelHard");
            this.buttonLevelHard.Name = "buttonLevelHard";
            this.buttonLevelHard.UseVisualStyleBackColor = true;
            this.buttonLevelHard.Click += new System.EventHandler(this.buttonLevelHard_Click);
            // 
            // buttonLevelMiddle
            // 
            resources.ApplyResources(this.buttonLevelMiddle, "buttonLevelMiddle");
            this.buttonLevelMiddle.Name = "buttonLevelMiddle";
            this.buttonLevelMiddle.UseVisualStyleBackColor = true;
            this.buttonLevelMiddle.Click += new System.EventHandler(this.buttonLevelMiddle_Click);
            // 
            // buttonLevelEasy
            // 
            resources.ApplyResources(this.buttonLevelEasy, "buttonLevelEasy");
            this.buttonLevelEasy.Name = "buttonLevelEasy";
            this.buttonLevelEasy.UseVisualStyleBackColor = true;
            this.buttonLevelEasy.Click += new System.EventHandler(this.buttonLevelEasy_Click);
            // 
            // labelLevelSelect
            // 
            resources.ApplyResources(this.labelLevelSelect, "labelLevelSelect");
            this.labelLevelSelect.Name = "labelLevelSelect";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Name = "panel2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLevelSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLevelSelect.ResumeLayout(false);
            this.panelLevelSelect.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelScorePoint;
        private System.Windows.Forms.Label labelScoreText;
        private System.Windows.Forms.MaskedTextBox mtbInputOtgadka;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Label labelInputOtgadka;
        private System.Windows.Forms.Label labelLevelTextDown;
        private System.Windows.Forms.Label labelLevelTextUp;
        private System.Windows.Forms.Button buttonPopytka;
        private System.Windows.Forms.Panel panelLevelSelect;
        private System.Windows.Forms.RichTextBox rtbHintHard;
        private System.Windows.Forms.RichTextBox rtbHintMiddle;
        private System.Windows.Forms.RichTextBox rtbHintEasy;
        private System.Windows.Forms.Button buttonLevelHard;
        private System.Windows.Forms.Button buttonLevelMiddle;
        private System.Windows.Forms.Button buttonLevelEasy;
        private System.Windows.Forms.Label labelLevelSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}


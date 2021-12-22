
namespace WindowsFormsApp1
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.rbEmitter = new System.Windows.Forms.RadioButton();
            this.rbBlackEater = new System.Windows.Forms.RadioButton();
            this.rbTeleport = new System.Windows.Forms.RadioButton();
            this.rbMagnite = new System.Windows.Forms.RadioButton();
            this.rbDeMagnite = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPowerGravitone = new System.Windows.Forms.TrackBar();
            this.tbPowerAntiGraviton = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPowerGravitone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPowerAntiGraviton)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(0, 0);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1280, 720);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(6, 19);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(224, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(6, 70);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(224, 45);
            this.tbSpreading.TabIndex = 3;
            this.tbSpreading.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // rbEmitter
            // 
            this.rbEmitter.AutoSize = true;
            this.rbEmitter.Location = new System.Drawing.Point(304, 12);
            this.rbEmitter.Name = "rbEmitter";
            this.rbEmitter.Size = new System.Drawing.Size(131, 17);
            this.rbEmitter.TabIndex = 4;
            this.rbEmitter.TabStop = true;
            this.rbEmitter.Text = "Точка спавна частиц";
            this.rbEmitter.UseVisualStyleBackColor = true;
            // 
            // rbBlackEater
            // 
            this.rbBlackEater.AutoSize = true;
            this.rbBlackEater.Location = new System.Drawing.Point(441, 12);
            this.rbBlackEater.Name = "rbBlackEater";
            this.rbBlackEater.Size = new System.Drawing.Size(164, 17);
            this.rbBlackEater.TabIndex = 5;
            this.rbBlackEater.TabStop = true;
            this.rbBlackEater.Text = "Черный пожиратель(Дыра)";
            this.rbBlackEater.UseVisualStyleBackColor = true;
            // 
            // rbTeleport
            // 
            this.rbTeleport.AutoSize = true;
            this.rbTeleport.Location = new System.Drawing.Point(611, 12);
            this.rbTeleport.Name = "rbTeleport";
            this.rbTeleport.Size = new System.Drawing.Size(73, 17);
            this.rbTeleport.TabIndex = 6;
            this.rbTeleport.TabStop = true;
            this.rbTeleport.Text = "Телепорт";
            this.rbTeleport.UseVisualStyleBackColor = true;
            // 
            // rbMagnite
            // 
            this.rbMagnite.AutoSize = true;
            this.rbMagnite.Location = new System.Drawing.Point(921, 31);
            this.rbMagnite.Name = "rbMagnite";
            this.rbMagnite.Size = new System.Drawing.Size(72, 17);
            this.rbMagnite.TabIndex = 7;
            this.rbMagnite.TabStop = true;
            this.rbMagnite.Text = "Гравитон";
            this.rbMagnite.UseVisualStyleBackColor = true;
            // 
            // rbDeMagnite
            // 
            this.rbDeMagnite.AutoSize = true;
            this.rbDeMagnite.Location = new System.Drawing.Point(921, 82);
            this.rbDeMagnite.Name = "rbDeMagnite";
            this.rbDeMagnite.Size = new System.Drawing.Size(96, 17);
            this.rbDeMagnite.TabIndex = 8;
            this.rbDeMagnite.TabStop = true;
            this.rbDeMagnite.Text = "АнтиГравитон";
            this.rbDeMagnite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDirection);
            this.groupBox1.Controls.Add(this.tbSpreading);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Полузнки управление спавном частиц";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вращение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Расброс";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPowerGravitone);
            this.groupBox2.Controls.Add(this.tbPowerAntiGraviton);
            this.groupBox2.Location = new System.Drawing.Point(1023, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 126);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Полузнки силы";
            // 
            // tbPowerGravitone
            // 
            this.tbPowerGravitone.Location = new System.Drawing.Point(6, 19);
            this.tbPowerGravitone.Maximum = 200;
            this.tbPowerGravitone.Minimum = 30;
            this.tbPowerGravitone.Name = "tbPowerGravitone";
            this.tbPowerGravitone.Size = new System.Drawing.Size(224, 45);
            this.tbPowerGravitone.TabIndex = 1;
            this.tbPowerGravitone.Value = 30;
            this.tbPowerGravitone.Scroll += new System.EventHandler(this.tbPowerGravitone_Scroll);
            // 
            // tbPowerAntiGraviton
            // 
            this.tbPowerAntiGraviton.Location = new System.Drawing.Point(6, 70);
            this.tbPowerAntiGraviton.Maximum = 200;
            this.tbPowerAntiGraviton.Minimum = 30;
            this.tbPowerAntiGraviton.Name = "tbPowerAntiGraviton";
            this.tbPowerAntiGraviton.Size = new System.Drawing.Size(224, 45);
            this.tbPowerAntiGraviton.TabIndex = 3;
            this.tbPowerAntiGraviton.Value = 30;
            this.tbPowerAntiGraviton.Scroll += new System.EventHandler(this.tbPowerAntiGraviton_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbDeMagnite);
            this.Controls.Add(this.rbMagnite);
            this.Controls.Add(this.rbTeleport);
            this.Controls.Add(this.rbBlackEater);
            this.Controls.Add(this.rbEmitter);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPowerGravitone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPowerAntiGraviton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.RadioButton rbEmitter;
        private System.Windows.Forms.RadioButton rbBlackEater;
        private System.Windows.Forms.RadioButton rbTeleport;
        private System.Windows.Forms.RadioButton rbMagnite;
        private System.Windows.Forms.RadioButton rbDeMagnite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbPowerGravitone;
        private System.Windows.Forms.TrackBar tbPowerAntiGraviton;
    }
}


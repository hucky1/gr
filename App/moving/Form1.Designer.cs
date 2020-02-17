namespace moving
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
            this.trbFigSize = new System.Windows.Forms.TrackBar();
            this.btnDefaultA = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblXcYc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trbFigRotRate = new System.Windows.Forms.TrackBar();
            this.trbFigSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigRotRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // trbFigSize
            // 
            this.trbFigSize.Location = new System.Drawing.Point(633, 37);
            this.trbFigSize.Maximum = 140;
            this.trbFigSize.Minimum = 80;
            this.trbFigSize.Name = "trbFigSize";
            this.trbFigSize.Size = new System.Drawing.Size(150, 45);
            this.trbFigSize.TabIndex = 22;
            this.trbFigSize.Value = 80;
            this.trbFigSize.Scroll += new System.EventHandler(this.trbFigSize_Scroll);
            // 
            // btnDefaultA
            // 
            this.btnDefaultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefaultA.Location = new System.Drawing.Point(642, 387);
            this.btnDefaultA.Name = "btnDefaultA";
            this.btnDefaultA.Size = new System.Drawing.Size(137, 41);
            this.btnDefaultA.TabIndex = 21;
            this.btnDefaultA.Text = "Размер по умолчанию";
            this.btnDefaultA.UseVisualStyleBackColor = true;
            this.btnDefaultA.Click += new System.EventHandler(this.btnDefaultA_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDraw.Location = new System.Drawing.Point(642, 332);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(137, 49);
            this.btnDraw.TabIndex = 20;
            this.btnDraw.Text = "Нарисовать фигуру";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(642, 290);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 36);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Движение фигуры";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(642, 243);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(137, 40);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Остановить вращение";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(7, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 412);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblXcYc
            // 
            this.lblXcYc.AutoSize = true;
            this.lblXcYc.Location = new System.Drawing.Point(639, 212);
            this.lblXcYc.Name = "lblXcYc";
            this.lblXcYc.Size = new System.Drawing.Size(155, 13);
            this.lblXcYc.TabIndex = 29;
            this.lblXcYc.Text = "Координаты центра тяжести:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(639, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Скорость вращения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(639, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Размер фигуры";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 25;
            // 
            // trbFigRotRate
            // 
            this.trbFigRotRate.Location = new System.Drawing.Point(634, 152);
            this.trbFigRotRate.Maximum = 20;
            this.trbFigRotRate.Minimum = 5;
            this.trbFigRotRate.Name = "trbFigRotRate";
            this.trbFigRotRate.Size = new System.Drawing.Size(149, 45);
            this.trbFigRotRate.TabIndex = 24;
            this.trbFigRotRate.Value = 10;
            this.trbFigRotRate.Scroll += new System.EventHandler(this.trbFigRotRate_Scroll);
            // 
            // trbFigSpeed
            // 
            this.trbFigSpeed.Location = new System.Drawing.Point(634, 90);
            this.trbFigSpeed.Minimum = 1;
            this.trbFigSpeed.Name = "trbFigSpeed";
            this.trbFigSpeed.Size = new System.Drawing.Size(149, 45);
            this.trbFigSpeed.TabIndex = 23;
            this.trbFigSpeed.Value = 10;
            this.trbFigSpeed.Scroll += new System.EventHandler(this.trbFigSpeed_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(639, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Скорость фигуры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trbFigSize);
            this.Controls.Add(this.btnDefaultA);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblXcYc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trbFigRotRate);
            this.Controls.Add(this.trbFigSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbFigSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigRotRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbFigSize;
        private System.Windows.Forms.Button btnDefaultA;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblXcYc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trbFigRotRate;
        private System.Windows.Forms.TrackBar trbFigSpeed;
        private System.Windows.Forms.Label label2;
    }
}


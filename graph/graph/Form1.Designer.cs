namespace graph
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
            this.btnDefaultA = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.trbFigSize = new System.Windows.Forms.TrackBar();
            this.lblXcYc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trbFigRotRate = new System.Windows.Forms.TrackBar();
            this.trbFigSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigRotRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultA
            // 
            this.btnDefaultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDefaultA.Location = new System.Drawing.Point(869, 380);
            this.btnDefaultA.Name = "btnDefaultA";
            this.btnDefaultA.Size = new System.Drawing.Size(137, 41);
            this.btnDefaultA.TabIndex = 35;
            this.btnDefaultA.Text = "Размер по умолчанию";
            this.btnDefaultA.UseVisualStyleBackColor = true;
            this.btnDefaultA.Click += new System.EventHandler(this.btnDefaultA_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDraw.Location = new System.Drawing.Point(869, 325);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(137, 49);
            this.btnDraw.TabIndex = 34;
            this.btnDraw.Text = "Нарисовать фигуру";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(869, 283);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 36);
            this.btnStart.TabIndex = 33;
            this.btnStart.Text = "Движение фигуры";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(869, 236);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(137, 40);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "Остановить вращение";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 584);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(866, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Размер фигуры";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(866, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Скорость фигуры";
            // 
            // trbFigSize
            // 
            this.trbFigSize.Location = new System.Drawing.Point(860, 30);
            this.trbFigSize.Maximum = 12;
            this.trbFigSize.Minimum = 5;
            this.trbFigSize.Name = "trbFigSize";
            this.trbFigSize.Size = new System.Drawing.Size(150, 45);
            this.trbFigSize.TabIndex = 36;
            this.trbFigSize.Value = 10;
            this.trbFigSize.Scroll += new System.EventHandler(this.trbFigSize_Scroll);
            // 
            // lblXcYc
            // 
            this.lblXcYc.AutoSize = true;
            this.lblXcYc.Location = new System.Drawing.Point(866, 205);
            this.lblXcYc.Name = "lblXcYc";
            this.lblXcYc.Size = new System.Drawing.Size(155, 13);
            this.lblXcYc.TabIndex = 42;
            this.lblXcYc.Text = "Координаты центра тяжести:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(866, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Скорость вращения";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(869, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 39;
            // 
            // trbFigRotRate
            // 
            this.trbFigRotRate.Location = new System.Drawing.Point(861, 145);
            this.trbFigRotRate.Maximum = 20;
            this.trbFigRotRate.Name = "trbFigRotRate";
            this.trbFigRotRate.Size = new System.Drawing.Size(149, 45);
            this.trbFigRotRate.TabIndex = 38;
            this.trbFigRotRate.Scroll += new System.EventHandler(this.trbFigRotRate_Scroll);
            // 
            // trbFigSpeed
            // 
            this.trbFigSpeed.Location = new System.Drawing.Point(861, 83);
            this.trbFigSpeed.Maximum = 15;
            this.trbFigSpeed.Minimum = 3;
            this.trbFigSpeed.Name = "trbFigSpeed";
            this.trbFigSpeed.Size = new System.Drawing.Size(149, 45);
            this.trbFigSpeed.TabIndex = 37;
            this.trbFigSpeed.Value = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 609);
            this.Controls.Add(this.btnDefaultA);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trbFigSize);
            this.Controls.Add(this.lblXcYc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trbFigRotRate);
            this.Controls.Add(this.trbFigSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigRotRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFigSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDefaultA;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbFigSize;
        private System.Windows.Forms.Label lblXcYc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trbFigRotRate;
        private System.Windows.Forms.TrackBar trbFigSpeed;
    }
}


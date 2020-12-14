
namespace PaintCompGraph
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonCurve = new System.Windows.Forms.Button();
            this.buttonOval = new System.Windows.Forms.Button();
            this.buttonRect = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(217, 3);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(80, 32);
            this.buttonClean.TabIndex = 1;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonCurve
            // 
            this.buttonCurve.Location = new System.Drawing.Point(4, 128);
            this.buttonCurve.Name = "buttonCurve";
            this.buttonCurve.Size = new System.Drawing.Size(45, 29);
            this.buttonCurve.TabIndex = 3;
            this.buttonCurve.Text = "Curve";
            this.buttonCurve.UseVisualStyleBackColor = true;
            // 
            // buttonOval
            // 
            this.buttonOval.Location = new System.Drawing.Point(4, 99);
            this.buttonOval.Name = "buttonOval";
            this.buttonOval.Size = new System.Drawing.Size(45, 29);
            this.buttonOval.TabIndex = 5;
            this.buttonOval.Text = "Oval";
            this.buttonOval.UseVisualStyleBackColor = true;
            this.buttonOval.Click += new System.EventHandler(this.buttonOval_Click);
            // 
            // buttonRect
            // 
            this.buttonRect.Location = new System.Drawing.Point(4, 70);
            this.buttonRect.Name = "buttonRect";
            this.buttonRect.Size = new System.Drawing.Size(45, 29);
            this.buttonRect.TabIndex = 6;
            this.buttonRect.Text = "Rect";
            this.buttonRect.UseVisualStyleBackColor = true;
            this.buttonRect.Click += new System.EventHandler(this.buttonRect_Click);
            // 
            // buttonPen
            // 
            this.buttonPen.Location = new System.Drawing.Point(4, 41);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(45, 29);
            this.buttonPen.TabIndex = 7;
            this.buttonPen.Text = "Pen";
            this.buttonPen.UseVisualStyleBackColor = true;
            this.buttonPen.Click += new System.EventHandler(this.buttonPen_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(136, 3);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(80, 32);
            this.buttonColor.TabIndex = 8;
            this.buttonColor.Text = "Select color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(55, 3);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(80, 32);
            this.buttonLoadImage.TabIndex = 9;
            this.buttonLoadImage.Text = "Load image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(4, 157);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(45, 29);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(55, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 423);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonPen);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonRect);
            this.Controls.Add(this.buttonOval);
            this.Controls.Add(this.buttonCurve);
            this.Controls.Add(this.buttonLine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonCurve;
        private System.Windows.Forms.Button buttonOval;
        private System.Windows.Forms.Button buttonRect;
        private System.Windows.Forms.Button buttonPen;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


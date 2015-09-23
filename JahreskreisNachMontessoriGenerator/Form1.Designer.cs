namespace JahreskreisNachMontessoriGenerator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAeuﬂereRadius = new System.Windows.Forms.TextBox();
            this.textBoxInnereRadius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelVorschauX = new System.Windows.Forms.Label();
            this.labelVorschauY = new System.Windows.Forms.Label();
            this.buttonVorschau = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(98, 58);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ƒuﬂere Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Innere Radius";
            // 
            // textBoxAeuﬂereRadius
            // 
            this.textBoxAeuﬂereRadius.Location = new System.Drawing.Point(98, 6);
            this.textBoxAeuﬂereRadius.Name = "textBoxAeuﬂereRadius";
            this.textBoxAeuﬂereRadius.Size = new System.Drawing.Size(100, 20);
            this.textBoxAeuﬂereRadius.TabIndex = 3;
            // 
            // textBoxInnereRadius
            // 
            this.textBoxInnereRadius.Location = new System.Drawing.Point(98, 32);
            this.textBoxInnereRadius.Name = "textBoxInnereRadius";
            this.textBoxInnereRadius.Size = new System.Drawing.Size(100, 20);
            this.textBoxInnereRadius.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 52);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tip: Wenn ein Element nicht auf ein A4 Blatt passt,\r\num die H‰lfte kleinere Angab" +
                "en machen und von A4 \r\nauf A3 kopieren.gaben machen und von A4 auf A3 \r\ngrˆﬂer k" +
                "opieren";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 65);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jahreskreis nach Montessori Generator\r\nCopyright (c) 2007 by Thomas Gassner, B.Sc" +
                "\r\nthomas.gassner@gmx.net\r\nFreeware - darf nach beliegen eingetzt werden\r\nDer Aut" +
                "or haftet f¸r gar nichts.";
            // 
            // labelVorschauX
            // 
            this.labelVorschauX.AutoSize = true;
            this.labelVorschauX.Location = new System.Drawing.Point(293, 9);
            this.labelVorschauX.Name = "labelVorschauX";
            this.labelVorschauX.Size = new System.Drawing.Size(0, 13);
            this.labelVorschauX.TabIndex = 9;
            // 
            // labelVorschauY
            // 
            this.labelVorschauY.AutoSize = true;
            this.labelVorschauY.Location = new System.Drawing.Point(294, 35);
            this.labelVorschauY.Name = "labelVorschauY";
            this.labelVorschauY.Size = new System.Drawing.Size(0, 13);
            this.labelVorschauY.TabIndex = 10;
            // 
            // buttonVorschau
            // 
            this.buttonVorschau.Location = new System.Drawing.Point(297, 58);
            this.buttonVorschau.Name = "buttonVorschau";
            this.buttonVorschau.Size = new System.Drawing.Size(93, 23);
            this.buttonVorschau.TabIndex = 11;
            this.buttonVorschau.Text = "Vorschau";
            this.buttonVorschau.UseVisualStyleBackColor = true;
            this.buttonVorschau.Click += new System.EventHandler(this.buttonVorschau_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grˆﬂe des\r\nerzeugten Bildes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 237);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonVorschau);
            this.Controls.Add(this.labelVorschauY);
            this.Controls.Add(this.labelVorschauX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInnereRadius);
            this.Controls.Add(this.textBoxAeuﬂereRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "Jahreskreis nach Montessori Generator Version 1.01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAeuﬂereRadius;
        private System.Windows.Forms.TextBox textBoxInnereRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVorschauX;
        private System.Windows.Forms.Label labelVorschauY;
        private System.Windows.Forms.Button buttonVorschau;
        private System.Windows.Forms.Label label7;
    }
}


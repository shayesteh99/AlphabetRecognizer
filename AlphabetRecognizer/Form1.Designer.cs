namespace AlphabetRecognizer
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clrButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.sLbl = new System.Windows.Forms.Label();
            this.recButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            //this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            //this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            //this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 223);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(267, 214);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(90, 25);
            this.clrButton.TabIndex = 1;
            this.clrButton.Text = "Clear";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "A";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(280, 111);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 24);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sLbl
            // 
            this.sLbl.AutoSize = true;
            this.sLbl.Location = new System.Drawing.Point(286, 40);
            this.sLbl.Name = "sLbl";
            this.sLbl.Size = new System.Drawing.Size(77, 13);
            this.sLbl.TabIndex = 4;
            this.sLbl.Text = "Save Alphabet";
            // 
            // recButton
            // 
            this.recButton.Location = new System.Drawing.Point(407, 70);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(90, 25);
            this.recButton.TabIndex = 5;
            this.recButton.Text = "Recognize";
            this.recButton.UseVisualStyleBackColor = true;
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recognize Alphabet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(533, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Draw Alphabet";
            // 
            // shapeContainer1
            // 
            //this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            //this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            //this.shapeContainer1.Name = "shapeContainer1";
            //this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            //this.lineShape2,
            //this.lineShape1});
            //this.shapeContainer1.Size = new System.Drawing.Size(654, 249);
            //this.shapeContainer1.TabIndex = 11;
            //this.shapeContainer1.TabStop = false;
            //// 
            //// lineShape2
            //// 
            //this.lineShape2.Name = "lineShape2";
            //this.lineShape2.X1 = 516;
            //this.lineShape2.X2 = 516;
            //this.lineShape2.Y1 = 34;
            //this.lineShape2.Y2 = 212;
            //// 
            //// lineShape1
            //// 
            //this.lineShape1.Name = "lineShape1";
            //this.lineShape1.X1 = 385;
            //this.lineShape1.X2 = 385;
            //this.lineShape1.Y1 = 33;
            //this.lineShape1.Y2 = 211;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 249);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.recButton);
            this.Controls.Add(this.sLbl);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clrButton);
            this.Controls.Add(this.panel1);
            //this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label sLbl;
        private System.Windows.Forms.Button recButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}


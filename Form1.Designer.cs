namespace OOP_lab4._1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.countLb = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(16, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(786, 528);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(811, 457);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(259, 42);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deleteBtn_MouseDown);
            // 
            // countLb
            // 
            this.countLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLb.Location = new System.Drawing.Point(811, 514);
            this.countLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLb.Name = "countLb";
            this.countLb.Size = new System.Drawing.Size(273, 28);
            this.countLb.TabIndex = 2;
            this.countLb.Text = "Objects in storage: ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(851, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Зажата ctrl";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox1_KeyDown);
            this.checkBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkBox1_KeyUp);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(851, 76);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(210, 36);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "‘Выделять один объект при \nпересечении’";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 554);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.countLb);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label countLb;

        private System.Windows.Forms.Button deleteBtn;

        private System.Windows.Forms.PictureBox pictureBox;

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
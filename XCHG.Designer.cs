﻿namespace Projekt8086
{
    partial class XCHG
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DX1_btn = new System.Windows.Forms.RadioButton();
            this.CX1_btn = new System.Windows.Forms.RadioButton();
            this.BX1_btn = new System.Windows.Forms.RadioButton();
            this.AX1_btn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DX2_btn = new System.Windows.Forms.RadioButton();
            this.CX2_btn = new System.Windows.Forms.RadioButton();
            this.BX2_btn = new System.Windows.Forms.RadioButton();
            this.AX2_btn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.exec_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ax_value_box = new System.Windows.Forms.TextBox();
            this.bx_value_box = new System.Windows.Forms.TextBox();
            this.cx_value_box = new System.Windows.Forms.TextBox();
            this.dx_value_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
  

            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.DX1_btn);
            this.groupBox1.Controls.Add(this.CX1_btn);
            this.groupBox1.Controls.Add(this.BX1_btn);
            this.groupBox1.Controls.Add(this.AX1_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(228, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;


            this.DX1_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.DX1_btn.AutoSize = true;
            this.DX1_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DX1_btn.Location = new System.Drawing.Point(23, 124);
            this.DX1_btn.Name = "DX1_btn";
            this.DX1_btn.Size = new System.Drawing.Size(46, 20);
            this.DX1_btn.TabIndex = 1;
            this.DX1_btn.TabStop = true;
            this.DX1_btn.Text = "DX";
            this.DX1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DX1_btn.UseVisualStyleBackColor = true;
            this.DX1_btn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);


            this.CX1_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.CX1_btn.AutoSize = true;
            this.CX1_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CX1_btn.Location = new System.Drawing.Point(23, 99);
            this.CX1_btn.Name = "CX1_btn";
            this.CX1_btn.Size = new System.Drawing.Size(46, 20);
            this.CX1_btn.TabIndex = 1;
            this.CX1_btn.TabStop = true;
            this.CX1_btn.Text = "CX";
            this.CX1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CX1_btn.UseVisualStyleBackColor = true;
            this.CX1_btn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);


            this.BX1_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.BX1_btn.AutoSize = true;
            this.BX1_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BX1_btn.Location = new System.Drawing.Point(23, 74);
            this.BX1_btn.Name = "BX1_btn";
            this.BX1_btn.Size = new System.Drawing.Size(45, 20);
            this.BX1_btn.TabIndex = 1;
            this.BX1_btn.TabStop = true;
            this.BX1_btn.Text = "BX";
            this.BX1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BX1_btn.UseVisualStyleBackColor = true;
            this.BX1_btn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);


            this.AX1_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX1_btn.AutoSize = true;
            this.AX1_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AX1_btn.Location = new System.Drawing.Point(23, 49);
            this.AX1_btn.Name = "AX1_btn";
            this.AX1_btn.Size = new System.Drawing.Size(46, 20);
            this.AX1_btn.TabIndex = 1;
            this.AX1_btn.TabStop = true;
            this.AX1_btn.Text = "AX";
            this.AX1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AX1_btn.UseVisualStyleBackColor = true;
            this.AX1_btn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);


            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(35, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
 

            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.DX2_btn);
            this.groupBox2.Controls.Add(this.CX2_btn);
            this.groupBox2.Controls.Add(this.BX2_btn);
            this.groupBox2.Controls.Add(this.AX2_btn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(96, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 176);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;


            this.DX2_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.DX2_btn.AutoSize = true;
            this.DX2_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DX2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.DX2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DX2_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DX2_btn.Location = new System.Drawing.Point(24, 126);
            this.DX2_btn.Name = "DX2_btn";
            this.DX2_btn.Size = new System.Drawing.Size(46, 20);
            this.DX2_btn.TabIndex = 1;
            this.DX2_btn.Text = "DX";
            this.DX2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DX2_btn.UseVisualStyleBackColor = false;
            this.DX2_btn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);


            this.CX2_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.CX2_btn.AutoSize = true;
            this.CX2_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CX2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.CX2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CX2_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CX2_btn.Location = new System.Drawing.Point(24, 101);
            this.CX2_btn.Name = "CX2_btn";
            this.CX2_btn.Size = new System.Drawing.Size(46, 20);
            this.CX2_btn.TabIndex = 1;
            this.CX2_btn.Text = "CX";
            this.CX2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CX2_btn.UseVisualStyleBackColor = false;
            this.CX2_btn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);


            this.BX2_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.BX2_btn.AutoSize = true;
            this.BX2_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BX2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.BX2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BX2_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BX2_btn.Location = new System.Drawing.Point(24, 74);
            this.BX2_btn.Name = "BX2_btn";
            this.BX2_btn.Size = new System.Drawing.Size(45, 20);
            this.BX2_btn.TabIndex = 1;
            this.BX2_btn.Text = "BX";
            this.BX2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BX2_btn.UseVisualStyleBackColor = false;
            this.BX2_btn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);


            this.AX2_btn.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX2_btn.AutoSize = true;
            this.AX2_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AX2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AX2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AX2_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AX2_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AX2_btn.Location = new System.Drawing.Point(24, 49);
            this.AX2_btn.Name = "AX2_btn";
            this.AX2_btn.Size = new System.Drawing.Size(46, 20);
            this.AX2_btn.TabIndex = 1;
            this.AX2_btn.Text = "AX";
            this.AX2_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AX2_btn.UseVisualStyleBackColor = false;
            this.AX2_btn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);


            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";


            this.exec_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exec_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exec_btn.Location = new System.Drawing.Point(112, 235);
            this.exec_btn.Name = "exec_btn";
            this.exec_btn.Size = new System.Drawing.Size(75, 23);
            this.exec_btn.TabIndex = 1;
            this.exec_btn.Text = "EXECUTE";
            this.exec_btn.UseVisualStyleBackColor = true;
            this.exec_btn.Click += new System.EventHandler(this.exec_btn_Click);


            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(338, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "AX";


            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(338, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "BX";


            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(338, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "CX";


            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(338, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "DX";


            this.ax_value_box.Location = new System.Drawing.Point(371, 73);
            this.ax_value_box.Multiline = true;
            this.ax_value_box.Name = "ax_value_box";
            this.ax_value_box.ReadOnly = true;
            this.ax_value_box.Size = new System.Drawing.Size(34, 20);
            this.ax_value_box.TabIndex = 3;
            this.ax_value_box.TextChanged += new System.EventHandler(this.ax_value_box_TextChanged);


            this.bx_value_box.Location = new System.Drawing.Point(371, 98);
            this.bx_value_box.Multiline = true;
            this.bx_value_box.Name = "bx_value_box";
            this.bx_value_box.ReadOnly = true;
            this.bx_value_box.Size = new System.Drawing.Size(34, 20);
            this.bx_value_box.TabIndex = 3;
            this.bx_value_box.TextChanged += new System.EventHandler(this.bx_value_box_TextChanged);


            this.cx_value_box.Location = new System.Drawing.Point(371, 123);
            this.cx_value_box.Multiline = true;
            this.cx_value_box.Name = "cx_value_box";
            this.cx_value_box.ReadOnly = true;
            this.cx_value_box.Size = new System.Drawing.Size(34, 20);
            this.cx_value_box.TabIndex = 3;
            this.cx_value_box.TextChanged += new System.EventHandler(this.cx_value_box_TextChanged);


            this.dx_value_box.Location = new System.Drawing.Point(371, 148);
            this.dx_value_box.Multiline = true;
            this.dx_value_box.Name = "dx_value_box";
            this.dx_value_box.ReadOnly = true;
            this.dx_value_box.Size = new System.Drawing.Size(34, 20);
            this.dx_value_box.TabIndex = 3;
            this.dx_value_box.TextChanged += new System.EventHandler(this.dx_value_box_TextChanged);


            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(362, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Value :";
            this.label7.Click += new System.EventHandler(this.label7_Click);


            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "XCHG";


            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(228, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);


            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dx_value_box);
            this.Controls.Add(this.cx_value_box);
            this.Controls.Add(this.bx_value_box);
            this.Controls.Add(this.ax_value_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exec_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "XCHG";
            this.Size = new System.Drawing.Size(460, 310);
            this.Load += new System.EventHandler(this.MOV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton DX1_btn;
        private RadioButton CX1_btn;
        private RadioButton BX1_btn;
        private RadioButton AX1_btn;
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
        private Button exec_btn;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ax_value_box;
        private TextBox bx_value_box;
        private TextBox cx_value_box;
        private TextBox dx_value_box;
        private Label label7;
        private Label label8;
        private RadioButton DX2_btn;
        private RadioButton CX2_btn;
        private RadioButton BX2_btn;
        private RadioButton AX2_btn;
        private Button button1;
    }
}

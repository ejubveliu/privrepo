
namespace Taschenrechner.App
{
    partial class Taschenrechner
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(288, 62);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(250, 60);
            this.textBox.TabIndex = 0;
            // 
            // lab
            // 
            this.lab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lab.Location = new System.Drawing.Point(265, 45);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(298, 385);
            this.lab.TabIndex = 1;
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dot.Location = new System.Drawing.Point(352, 357);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(58, 53);
            this.dot.TabIndex = 3;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.oper_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.equal.Location = new System.Drawing.Point(416, 357);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(58, 53);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.plus.Location = new System.Drawing.Point(480, 357);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(58, 53);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.oper_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.zero.Location = new System.Drawing.Point(288, 357);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(58, 53);
            this.zero.TabIndex = 6;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.oper_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.one.Location = new System.Drawing.Point(288, 298);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(58, 53);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.oper_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.two.Location = new System.Drawing.Point(352, 298);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(58, 53);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.oper_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.three.Location = new System.Drawing.Point(416, 298);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(58, 53);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.oper_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.minus.Location = new System.Drawing.Point(480, 298);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(58, 53);
            this.minus.TabIndex = 10;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.oper_Click);
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.multi.Location = new System.Drawing.Point(480, 239);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(58, 53);
            this.multi.TabIndex = 11;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.oper_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.six.Location = new System.Drawing.Point(416, 239);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(58, 53);
            this.six.TabIndex = 12;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.oper_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.five.Location = new System.Drawing.Point(352, 239);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(58, 53);
            this.five.TabIndex = 13;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.oper_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.four.Location = new System.Drawing.Point(288, 239);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(58, 53);
            this.four.TabIndex = 14;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.oper_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.divide.Location = new System.Drawing.Point(480, 180);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(58, 53);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.oper_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nine.Location = new System.Drawing.Point(416, 180);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(58, 53);
            this.nine.TabIndex = 16;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.oper_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.eight.Location = new System.Drawing.Point(352, 180);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(58, 53);
            this.eight.TabIndex = 17;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.oper_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.seven.Location = new System.Drawing.Point(288, 180);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(58, 53);
            this.seven.TabIndex = 18;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.oper_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.clear.Location = new System.Drawing.Point(454, 141);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(84, 33);
            this.clear.TabIndex = 19;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Taschenrechner
            // 
            this.ClientSize = new System.Drawing.Size(865, 522);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lab);
            this.Name = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button clear;
    }
}


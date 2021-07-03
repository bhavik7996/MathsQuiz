
namespace MathsQuiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLable = new System.Windows.Forms.Label();
            this.timeLeftTextBox = new System.Windows.Forms.Label();
            this.plusLeftLable = new System.Windows.Forms.Label();
            this.equalSign = new System.Windows.Forms.Label();
            this.plusRightLable = new System.Windows.Forms.Label();
            this.plusSign = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.NumericUpDown();
            this.minusRightLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minusLeftLable = new System.Windows.Forms.Label();
            this.equalSignTwo = new System.Windows.Forms.Label();
            this.substraction = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.equalSign3 = new System.Windows.Forms.Label();
            this.timesSign = new System.Windows.Forms.Label();
            this.timesRightLable = new System.Windows.Forms.Label();
            this.timesLeftLable = new System.Windows.Forms.Label();
            this.rightDivisionLable = new System.Windows.Forms.Label();
            this.leftDivision = new System.Windows.Forms.Label();
            this.divisionSign = new System.Windows.Forms.Label();
            this.equal4 = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLable
            // 
            this.timeLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLable.Location = new System.Drawing.Point(346, 9);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(200, 30);
            this.timeLable.TabIndex = 0;
            this.timeLable.Click += new System.EventHandler(this.timeLable_Click);
            // 
            // timeLeftTextBox
            // 
            this.timeLeftTextBox.AutoSize = true;
            this.timeLeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftTextBox.Location = new System.Drawing.Point(181, 9);
            this.timeLeftTextBox.Name = "timeLeftTextBox";
            this.timeLeftTextBox.Size = new System.Drawing.Size(120, 30);
            this.timeLeftTextBox.TabIndex = 1;
            this.timeLeftTextBox.Text = "Time Left";
            // 
            // plusLeftLable
            // 
            this.plusLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLable.Location = new System.Drawing.Point(36, 87);
            this.plusLeftLable.Name = "plusLeftLable";
            this.plusLeftLable.Size = new System.Drawing.Size(67, 48);
            this.plusLeftLable.TabIndex = 2;
            this.plusLeftLable.Text = "?";
            this.plusLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSign
            // 
            this.equalSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign.Location = new System.Drawing.Point(325, 89);
            this.equalSign.Name = "equalSign";
            this.equalSign.Size = new System.Drawing.Size(60, 50);
            this.equalSign.TabIndex = 3;
            this.equalSign.Text = "=";
            this.equalSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLable
            // 
            this.plusRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLable.Location = new System.Drawing.Point(232, 89);
            this.plusRightLable.Name = "plusRightLable";
            this.plusRightLable.Size = new System.Drawing.Size(60, 50);
            this.plusRightLable.TabIndex = 4;
            this.plusRightLable.Text = "?";
            this.plusRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            this.plusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSign.Location = new System.Drawing.Point(131, 89);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(60, 50);
            this.plusSign.TabIndex = 5;
            this.plusSign.Text = "+";
            this.plusSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(415, 93);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(159, 42);
            this.addition.TabIndex = 2;
            this.addition.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusRightLable
            // 
            this.minusRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLable.Location = new System.Drawing.Point(225, 156);
            this.minusRightLable.Name = "minusRightLable";
            this.minusRightLable.Size = new System.Drawing.Size(76, 48);
            this.minusRightLable.TabIndex = 7;
            this.minusRightLable.Text = "?";
            this.minusRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLable
            // 
            this.minusLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLable.Location = new System.Drawing.Point(43, 154);
            this.minusLeftLable.Name = "minusLeftLable";
            this.minusLeftLable.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLable.TabIndex = 9;
            this.minusLeftLable.Text = "?";
            this.minusLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSignTwo
            // 
            this.equalSignTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSignTwo.Location = new System.Drawing.Point(325, 157);
            this.equalSignTwo.Name = "equalSignTwo";
            this.equalSignTwo.Size = new System.Drawing.Size(60, 50);
            this.equalSignTwo.TabIndex = 10;
            this.equalSignTwo.Text = "=";
            this.equalSignTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // substraction
            // 
            this.substraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substraction.Location = new System.Drawing.Point(415, 162);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(159, 42);
            this.substraction.TabIndex = 3;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(415, 235);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(159, 42);
            this.product.TabIndex = 4;
            // 
            // equalSign3
            // 
            this.equalSign3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign3.Location = new System.Drawing.Point(325, 227);
            this.equalSign3.Name = "equalSign3";
            this.equalSign3.Size = new System.Drawing.Size(60, 50);
            this.equalSign3.TabIndex = 13;
            this.equalSign3.Text = "=";
            this.equalSign3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesSign
            // 
            this.timesSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesSign.Location = new System.Drawing.Point(131, 235);
            this.timesSign.Name = "timesSign";
            this.timesSign.Size = new System.Drawing.Size(60, 50);
            this.timesSign.TabIndex = 14;
            this.timesSign.Text = "x";
            this.timesSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLable
            // 
            this.timesRightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLable.Location = new System.Drawing.Point(241, 235);
            this.timesRightLable.Name = "timesRightLable";
            this.timesRightLable.Size = new System.Drawing.Size(60, 50);
            this.timesRightLable.TabIndex = 15;
            this.timesRightLable.Text = "?";
            this.timesRightLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLable
            // 
            this.timesLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLable.Location = new System.Drawing.Point(43, 235);
            this.timesLeftLable.Name = "timesLeftLable";
            this.timesLeftLable.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLable.TabIndex = 16;
            this.timesLeftLable.Text = "?";
            this.timesLeftLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightDivisionLable
            // 
            this.rightDivisionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightDivisionLable.Location = new System.Drawing.Point(241, 307);
            this.rightDivisionLable.Name = "rightDivisionLable";
            this.rightDivisionLable.Size = new System.Drawing.Size(60, 50);
            this.rightDivisionLable.TabIndex = 17;
            this.rightDivisionLable.Text = "?";
            this.rightDivisionLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftDivision
            // 
            this.leftDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftDivision.Location = new System.Drawing.Point(43, 307);
            this.leftDivision.Name = "leftDivision";
            this.leftDivision.Size = new System.Drawing.Size(60, 50);
            this.leftDivision.TabIndex = 18;
            this.leftDivision.Text = "?";
            this.leftDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisionSign
            // 
            this.divisionSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionSign.Location = new System.Drawing.Point(131, 307);
            this.divisionSign.Name = "divisionSign";
            this.divisionSign.Size = new System.Drawing.Size(60, 50);
            this.divisionSign.TabIndex = 19;
            this.divisionSign.Text = "÷";
            this.divisionSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equal4
            // 
            this.equal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal4.Location = new System.Drawing.Point(325, 307);
            this.equal4.Name = "equal4";
            this.equal4.Size = new System.Drawing.Size(60, 50);
            this.equal4.TabIndex = 20;
            this.equal4.Text = "=";
            this.equal4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(415, 312);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(159, 42);
            this.quotient.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(92, 387);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(337, 49);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 490);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.equal4);
            this.Controls.Add(this.divisionSign);
            this.Controls.Add(this.leftDivision);
            this.Controls.Add(this.rightDivisionLable);
            this.Controls.Add(this.timesLeftLable);
            this.Controls.Add(this.timesRightLable);
            this.Controls.Add(this.timesSign);
            this.Controls.Add(this.equalSign3);
            this.Controls.Add(this.product);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.equalSignTwo);
            this.Controls.Add(this.minusLeftLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minusRightLable);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.plusRightLable);
            this.Controls.Add(this.equalSign);
            this.Controls.Add(this.plusLeftLable);
            this.Controls.Add(this.timeLeftTextBox);
            this.Controls.Add(this.timeLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "MathsQuiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // This Code is Generated when we add component through windows designer (Auto Generated). 

        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Label timeLeftTextBox;
        private System.Windows.Forms.Label plusLeftLable;
        private System.Windows.Forms.Label equalSign;
        private System.Windows.Forms.Label plusRightLable;
        private System.Windows.Forms.Label plusSign;
        private System.Windows.Forms.NumericUpDown addition;
        private System.Windows.Forms.Label minusRightLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minusLeftLable;
        private System.Windows.Forms.Label equalSignTwo;
        private System.Windows.Forms.NumericUpDown substraction;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label equalSign3;
        private System.Windows.Forms.Label timesSign;
        private System.Windows.Forms.Label timesRightLable;
        private System.Windows.Forms.Label timesLeftLable;
        private System.Windows.Forms.Label rightDivisionLable;
        private System.Windows.Forms.Label leftDivision;
        private System.Windows.Forms.Label divisionSign;
        private System.Windows.Forms.Label equal4;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}


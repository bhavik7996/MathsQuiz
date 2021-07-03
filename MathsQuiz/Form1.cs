using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsQuiz // Project Name.
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random(); // It is a method for calling Random Nos.

        int addnum1, addnum2;                                                   // initialisation
     
        int subnum1, subnum2;                                                   // initialisation

        int mulnum1, mulnum2;                                                   // initialisation

        int divnum1, divnum2;                                                   // initialisation

        int clock;

        public void StartQuiz()
        {
            // Addition of 2 random Generated nos.

            addnum1 = randomizer.Next(51);                                         //It generate Random No's upto 51.
            addnum2 = randomizer.Next(51);                                         //It generate Random No's upto 51.
            plusLeftLable.Text = addnum1.ToString();                               //It assign No1 to Leftside Question mark.
            plusRightLable.Text = addnum2.ToString();                              //It assign No2 to Rightside Question mark.
            addition.Value = 0;                                                    //Addition value is set to 0.

            // Substraction of 2 random Generated nos.

            subnum1 = randomizer.Next(1,101);                                      //It generate Random No's in between 1 to 101.
            subnum2 = randomizer.Next(1,subnum1);                                  //It generate Random No's in between 2 to subNum1.(upto subNum1 coz avoid ans in - sign.)
            minusLeftLable.Text = subnum1.ToString();
            minusRightLable.Text = subnum2.ToString();
            substraction.Value = 0;                                                 //Substraction value is set to 0.

            // Multiplication of 2 random Generated nos.

            mulnum1 = randomizer.Next(2, 11);                                       // It generate Random No's in between 2 to 11.
            mulnum2 = randomizer.Next(2, 11);                                       // It generate Random No's in between 2 to 11.
            timesLeftLable.Text = mulnum1.ToString();
            timesRightLable.Text = mulnum2.ToString();
            product.Value = 0;                                                       //product value is set to 0.

            // Division of 2 random Generated nos.

            divnum2 = randomizer.Next(2, 11);                                       // It generate Random No's in between 2 to 11.
            int tempquotient = randomizer.Next(2, 11);                              //It generate Random No's in between 2 to 11.
            divnum1 = divnum2 * tempquotient;
            leftDivision.Text = divnum1.ToString();
            rightDivisionLable.Text = divnum2.ToString();
            quotient.Value = 0;                                                      //Division value is set to 0.

            clock = 25;                                                              // Timer set to 25 sec. we can change it.
            timeLable.Text = " 25 Seconds";                                         
            timer1.Start();                                                          // timer Start due to start method which is predefined.
        }
        private bool checkAnswer()                                                   // method for answer Check.
        {
            if ((((addnum1 + addnum2 == addition.Value)                              // No1 & No2 will be added and value stored in addition variable.
                && (subnum1 - subnum2 == substraction.Value))
                && (mulnum1 * mulnum2 == product.Value))
                && (divnum1 / divnum2 == quotient.Value))

                return true;                                                        // If all condition true then return true.
            else
                return false;                                                       // If anyone condition false then return false.

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timeLable_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();                        
            startButton.Enabled = true;                                             // Enable Start Quiz button.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkAnswer())                                                     
            {
                timer1.Stop();
                MessageBox.Show("You Won the Quiz.","Congratulations");
            }
             else if (clock > 0)
            {
                clock = clock - 1;
                timeLable.Text = clock + "second";
            }
            else
            {
                timer1.Stop();
                timeLable.Text = "Time's up!";
                MessageBox.Show(" You didn't finish in time.", "Sorry");

                addition.Value = addnum1 + addnum2;
                substraction.Value = subnum1 - subnum2;
                product.Value = mulnum1 * mulnum2;
                quotient.Value = divnum1 / divnum2;
                startButton.Enabled = true;
            }
        }
           

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the whole answer in the NumericUpDown control.

            NumericUpDown answerBox = sender as NumericUpDown;

            if(answerBox!=null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}

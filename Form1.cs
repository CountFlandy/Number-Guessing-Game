using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumberGuess
{
    public partial class Form1 : Form
    {
        int usrNumGuess = 0; //user number
        static int rndNumber = 0; //generated number
        //static string guessResponse; //helps user tell if guess is too high or too low //replaced by message box
        static int usrRange = 0; //helps user know if new guess is closer or farther away than prev guess

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void buttonGuess_Click(object sender, EventArgs e)
        {
            usrNumGuess = Convert.ToInt32(textNumberGuess1.Text);
            if (Math.Abs(rndNumber - usrNumGuess) < usrRange) //if user is getting closer to the correct number
            {
                textNumberGuess1.BackColor = Color.Blue;
                labelCloser.Text = "Getting Closer!";
            }
            else //farther away from correct number
            {
                textNumberGuess1.BackColor = Color.Red;
            }

            if (usrNumGuess > rndNumber) //user too high
            {
                labelClose1.Text = "Too High";
            }
            else if (usrNumGuess < rndNumber) //user too low
            {
                labelClose1.Text = "Too Low";
            }
            else //if user is correct
            {
                textNumberGuess1.BackColor = Color.Green;
                labelClose1.Text = "Correct! You guessed right!";
                labelCloser.Text = "";
                buttonGuess.Enabled = false; //disable it to prevent further guesses
                string message = "Correct!";
                string caption = "Correct!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    textNumberGuess1.Focus();
                }
            }
            usrRange = Math.Abs(rndNumber - usrNumGuess); //remember the difference after each user guess. Absolute Value is to prevent any negative numbers
        }

        private void buttonNewGame_Click(object sender, EventArgs e) //reset whole application for new game
        {
            Init();
        }

        private void Init() //initalizing, used to help reset the game each time
        {
            var rand = new Random(); //new random variable
            rndNumber = rand.Next(1, 1001); //1001 is to ensure 1,000 can be the number as well
            buttonGuess.Enabled = true; //reenable the button for new games
            textNumberGuess1.Clear(); // clear text box for new games
            textNumberGuess1.BackColor = Color.White; // reset the color for new games
            labelClose1.Text = ""; //mark the text blank for new games //Shows "Too High" or "Too Low" or "Correct"
            labelCloser.Text = ""; //mark the text blank for new games  // "Shows "Getting Closer!" when the text box turns blue. 
        }
    }
}

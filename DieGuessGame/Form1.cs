using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieGuessGame
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //All Text Box headers
            richTextBox2.Text = ("Face\t     Frequency     Percent     Number Of Times Guessed");
            GameInfo.Text = $"Game Info\n\nAmount of times played: {rollCount} \n\nAmount of time won: {wincount}\n\nAmount of times lost: {lossCount}";

        }



        /// <summary>
        /// All variable initialization is stored in this region
        /// </summary>
        #region VariableInitialization

        private int rollCount = 0; // initializing roll count outside of the rollButton_click method
        private int wincount = 0; // initializing win count
        private int lossCount = 0; // intitializing loss count


        private int frequency1 = 0; // count of 1's rolled
        private int frequency2 = 0; // count of 2's rolled
        private int frequency3 = 0; // count of 3's rolled
        private int frequency4 = 0; // count of 4's rolled
        private int frequency5 = 0; // count of 5's rolled
        private int frequency6 = 0; // count of 6's rolled

        private int guessNumber1 = 0; // number of times 1 is guessed
        private int guessNumber2 = 0; // number of times 2 is guessed
        private int guessNumber3 = 0; // number of times 3 is guessed
        private int guessNumber4 = 0; // number of times 4 is guessed
        private int guessNumber5 = 0; // number of times 5 is guessed
        private int guessNumber6 = 0; // number of times 6 is guessed

        private double percent1 = 0; // percent of 1 rolled
        private double percent2 = 0; // percent of 2 rolled
        private double percent3 = 0; // percent of 3 rolled
        private double percent4 = 0; // percent of 4 rolled
        private double percent5 = 0; // percent of 5 rolled
        private double percent6 = 0; // percent of 6 rolled

        #endregion VariableInitialization

        /// <summary>
        /// This method displays all of the data from the game
        /// </summary>
        private void displayResults()
        {
            richTextBox2.Text = ("Face\t     Frequency     Percent     Number Of Times Guessed");
            richTextBox2.Text += Environment.NewLine + ($"1\t\t{frequency1}\t     {percent1.ToString("P")}\t\t{guessNumber1}\n2\t\t{frequency2}\t     {percent2.ToString("P")}\t\t{guessNumber2}");
            richTextBox2.Text += Environment.NewLine + ($"3\t\t{frequency3}\t     {percent3.ToString("P")}\t\t{guessNumber3}\n4\t\t{frequency4}\t     {percent4.ToString("P")}\t\t{guessNumber4}");
            richTextBox2.Text += Environment.NewLine + ($"5\t\t{frequency5}\t     {percent5.ToString("P")}\t\t{guessNumber5}\n6\t\t{frequency6}\t     {percent6.ToString("P")}\t\t{guessNumber6}");
        }

        /// <summary>
        /// This method will print everything in the GameInfo box
        /// </summary>
        private void displayGameInfoResults()
        {
            GameInfo.Text = $"Game Info\n\nAmount of times played: {rollCount} \n\nAmount of time won: {wincount}\n\nAmount of times lost: {lossCount}";
        }

        /// <summary>
        /// This reset method sets the game back into it's initial state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {

            dice.Image = null; // setting the dice image to null when reset is clicked

            userGuessBox.Text = ""; // wiping the game information slate when clicked

            rollCount = 0; // initializing roll count outside of the rollButton_click method
            wincount  = 0; // initializing win count
            lossCount = 0; // intitializing loss count

            frequency1 = 0; // count of 1's rolled
            frequency2 = 0; // count of 2's rolled
            frequency3 = 0; // count of 3's rolled
            frequency4 = 0; // count of 4's rolled
            frequency5 = 0; // count of 5's rolled
            frequency6 = 0; // count of 6's rolled

            guessNumber1 = 0; // number of times 1 is guessed
            guessNumber2 = 0; // number of times 2 is guessed
            guessNumber3 = 0; // number of times 3 is guessed
            guessNumber4 = 0; // number of times 4 is guessed
            guessNumber5 = 0; // number of times 5 is guessed
            guessNumber6 = 0; // number of times 6 is guessed

            percent1 = 0; // percent of 1 rolled
            percent2 = 0; // percent of 2 rolled
            percent3 = 0; // percent of 3 rolled
            percent4 = 0; // percent of 4 rolled
            percent5 = 0; // percent of 5 rolled
            percent6 = 0; // percent of 6 rolled


            displayResults();
            displayGameInfoResults();
            
        }

        /// <summary>
        /// This method will trigger the Random Number Generator as well as comparisons to the users choice
        /// Face is the result of the random roll
        /// This will also handle trigger the of the gameResults method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void rollButton_Click(object sender, EventArgs e)
        {
                 
            int userGuess;

            try
            {
                userGuess = (Int32.Parse(userGuessBox.Text));
            }
            catch (Exception)
            {
                errorBox.Text = "Must enter a number (1 - 6)";
                return;
            }

            if(userGuess <= 0 || userGuess > 6)
            {
                errorBox.Text = "Must enter a number (1 - 6)";
                return;
            }

            errorBox.Text = "";

            rollCount++; // iterate the rollCount / amount of times played

            int face = randomNumberGenerator();

            gameResults(face, userGuess);

            diceImg(face);

        }

        /// <summary>
        /// This is the random number generator that will provide a random number. Being called from the rollButton_Click method
        /// </summary>
        /// <returns></returns>
        public int randomNumberGenerator()
        {   
            Random randomNumber = new Random();// Setting up the RNG
            int number = randomNumber.Next(1, 7);
            return number;
        }      

        /// <summary>
        /// This method will update both the game results box at the bottom and the gameinfo box at the top
        /// This method is being passed in the 'face' value from the randomNumberGenerator
        /// It is also being passed in the userGuess
        /// </summary>
        /// <param name="x"></param>
        public void gameResults(int faceValue, int userGuess)
        {
            #region GameInfo

            #region GameInfoBox
           
            if(userGuess == faceValue)
            {
                ++wincount;
            }
            else
            {
                ++lossCount;
            }

            displayGameInfoResults();
            #endregion GameInfoBox

            #region FrequencyStats


            //keep track of what number was rolled and increment appropriate counter
            switch (faceValue)
            {
                case 1:
                    ++frequency1; // increment 1
                    break;
                case 2:
                    ++frequency2; // increment 2
                    break;
                case 3:
                    ++frequency3; // increment 3
                    break;
                case 4:
                    ++frequency4; // increment 4
                    break;
                case 5:
                    ++frequency5; // increment 5
                    break;
                case 6:
                    ++frequency6; // increment 6
                    break;

            }


            // Ugly print format for the frequency stats. **These need to update / replace numbers, not keep re-printing** 
            // Also need to send all of these to a function to clean up code


            #endregion FrequencyStats

            #region Percent

            percent1 = ((double)frequency1 / rollCount);
            percent2 = ((double)frequency2 / rollCount);
            percent3 = ((double)frequency3 / rollCount);
            percent4 = ((double)frequency4 / rollCount);
            percent5 = ((double)frequency5 / rollCount);
            percent6 = ((double)frequency6 / rollCount);

            #endregion Percent

            #region NumberOfTimesGuessed



            switch (userGuess)
            {
                case 1:
                    ++guessNumber1;
                    break;
                case 2:
                    ++guessNumber2;
                    break;
                case 3:
                    ++guessNumber3;
                    break;
                case 4:
                    ++guessNumber4;
                    break;
                case 5:
                    ++guessNumber5;
                    break;
                case 6:
                    ++guessNumber6;
                    break;
            }

            #endregion NumberOfTimesGuessed

            #region PrintingResults
            displayResults();
            #endregion PrintingResults

            #endregion GameInfo
        }

        /// <summary>
        /// This method randomizes the dice gif presented on the app
        /// </summary>
        private void diceImg(int face)
        {

            dice.SizeMode = PictureBoxSizeMode.StretchImage;

            Random diceNumber = new Random();// Setting up the RNG
            int j = diceNumber.Next(1, 7);

            for (int i = 1; i < 4; i++)
            {
                j = diceNumber.Next(1, 7);
                dice.Image = Image.FromFile("die" + j.ToString() + ".gif");
                dice.Refresh();
                Thread.Sleep(200);
            }

            dice.Image = Image.FromFile("die" + face.ToString() + ".gif");



        }

    }
   
}
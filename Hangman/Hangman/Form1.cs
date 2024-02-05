using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        int wordLength, wordSelector, strikeCount, displayedCount, checkCount = 0, letterValue;
        string realWord, displayed, letterString, wordBreaker;
        char letter;
        char[] wordAsChars, realWordAsChars;
        List<string> fourLetter = new List<string> { "able", "acid", "baby", "ball", "band", "bear", "beat", "bell", "belt", "bird", "boat", "bomb", "bone", "book", "call", "card", "cell", "cook", "core", "dark", "data", "dawn", "desk", "easy", "exit", "farm", "fill", "game", "gulf", "half", "hero", "iron", "item", "join", "jump", "keen", "kick", "lock", "luck", "mass", "moon", "neck", "nine", "once", "open", "palm", "pipe", "rare", "root", "sake", "slip", "tale", "turn", "upon", "user", "vice", "vote", "weak", "wine", "yard", "year", "zero", "zone"};
        List<string> fiveLetter = new List<string> { "abyss", "augur", "bacon", "burst", "cable", "clash", "death", "digit", "earth", "ember", "fable", "forms", "ghost", "grave", "hedge", "hotel", "index", "issue", "jewel", "joint", "knees", "knife", "laser", "loans", "magic", "melee", "nerve", "notch", "oasis", "oxide", "patch", "pixel", "quest", "quote", "ranch", "route", "satin", "scrap", "tanks", "tempo", "ultra", "urban", "vault", "vinyl", "waste", "witch", "yacht", "yards", "zone"};
        List<string> sixLetter = new List<string> { "agenda", "amount", "beyond", "bureau", "castle", "combat", "debate", "domain", "effort", "engine", "fallen", "future", "garden", "guilty", "handle", "honest", "income", "invest", "jersey", "junior", "killed", "leader", "legacy", "marine", "modern", "narrow", "nature", "office", "origin", "phrase", "profit", "random", "region", "screen", "server", "target", "timing", "unique", "update", "version", "visual", "winter", "worker", "yellow"};
        Boolean letterCheck;
        Random rnd = new Random();

        //checks if there was a change of input in the letter text box
        private void letterInput_TextChanged(object sender, EventArgs e)
        {
            //checks if the text box is empty
            if (string.IsNullOrEmpty(letterInput.Text))
            {
                //sets the letter guess button to false if the text box is empty
                letterGuessButton.Enabled = false;
            }
            else
            {
                //converts the input to a char
                letter = Convert.ToChar(letterInput.Text);
                //converts the char to it's ASCII value
                letterValue = Convert.ToInt32(letter);
                //check if it's ASCII value is that of a letter
                if (letterValue >= 65 & letterValue <= 90 || letterValue >= 97 & letterValue <= 122)
                {
                    //let's you guess it if it's actually a letter
                    letterGuessButton.Enabled = true;
                }
                
            }
        }

        //checks if there was a change of input in the word text box
        private void wordInput_TextChanged(object sender, EventArgs e)
        {
            //checks if the word you typed is the same length as the real word
            if (wordInput.TextLength == realWord.Length)
            {
                //if it is it'll let you guess it
                wordGuessButton.Enabled = true;
            }
        }
        public Hangman()
        {
            InitializeComponent();
        }

        //starts the game
        private void startButton_Click(object sender, EventArgs e)
        {
            //enables the letter input
            letterInput.Enabled = true;
            //enables the word input
            wordInput.Enabled = true;

            //choses a word length between 4 and 6 at random
            wordLength = rnd.Next(4, 6);
            //runs to make the _ display for how many letters are in the word
            while (displayedCount < wordLength)
            {
                // adds onto itself while leaving a space between the _
                displayed = displayed + " _";
                //makes it so the loop breaks when the right amount of _ have been placed
                displayedCount++;
            }

            //changes the label to all the _
            realWordLabel.Text = displayed;
            //displays the _ to the player
            realWordLabel.Visible = true;
            //checks if the word is 4 letters long
            if (wordLength == 4)
            {
                //selects a word at random from the set 4 letter words
                wordSelector = rnd.Next(0, fourLetter.Count);
                realWord = fourLetter[wordSelector];
            }
            //checks if the word is 5 letters long
            else if (wordLength == 5)
            {
                //selects a word at random from the set 5 letter words
                wordSelector = rnd.Next(0, fiveLetter.Count);
                realWord = fiveLetter[wordSelector];
            }
            //checks if the word is 6 letters long
            else if (wordLength == 6)
            {
                //selects a word at random from the set 6 letter words
                wordSelector = rnd.Next(0, sixLetter.Count);
                realWord = sixLetter[wordSelector];
            }

            //changes the amount of letters you can put into the word guessing text box to match how long the word is
            wordInput.MaxLength = realWord.Length;

            //makes a char array out of the display
            wordAsChars = displayed.ToCharArray();
            //breaks the actual word into chars
            realWordAsChars = realWord.ToCharArray();
            //stops you from starting a new game
            startButton.Enabled = false;
            //enables the reset button
            resetButton.Enabled = true;
        }
        
        //restes all the values in the game that needs to be reset to start a new game
        private void resetButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            resetButton.Enabled = true;
            letterInput.Enabled = false;
            wordInput.Enabled = false;
            letterGuessButton.Enabled = false;
            wordGuessButton.Enabled = false;
            realWordLabel.Text = null;
            realWordLabel.Visible = false;
            winOrLoseLabel.Visible = false;
            strikeCount = 0;
            displayedCount = 0;
            wordAsChars = null;
            realWordAsChars = null;
            displayed = null;
            hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\base.png");

        }

        //lets you guess a letter
        private void letterGuessButton_Click(object sender, EventArgs e)
        {
            //resets the check count
            checkCount = 0;
            //makes a string equal the letter input
            letterString = letterInput.Text;
            //converts the string to a lowercase char
            letter = Convert.ToChar(letterString.ToLower());
            //checks if the char array contains the letter
            letterCheck = realWord.Contains(letter);
            //if it does it runs this
            if (letterCheck == true)
            {
                //runs through the whole word to determine where the matching char is
                while (checkCount + 1 <= wordLength)
                {
                    //converts the the chosen char for each run to a string
                    wordBreaker = Convert.ToString(realWordAsChars[checkCount]);
                    
                    //adds on to the count
                    checkCount = checkCount + 1;
                    //checks if the current letter matched the one guessed
                    if (wordBreaker == letterString)
                    {
                        //changes the char array used for display to have the letter instead of _
                        wordAsChars[checkCount*2-1] = letter;
                    }
                    
                }
                //updates the display label so that it can show where the correct letter you have guessed is
                string displayedUpdate = new String(wordAsChars);
                realWordLabel.Text = displayedUpdate;

            }
            //otherwise it runs this
            else
            {
                //checks how many strikes you have and while chnage the image appropiatley as well as update your strike value
                if (strikeCount == 0)
                {
                    strikeCount = 1;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\oneStrike.png");
                }
                else if (strikeCount == 1)
                {
                    strikeCount = 2;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\twoStrike.png");
                }
                else if (strikeCount == 2)
                {
                    strikeCount = 3;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\threeStrike.png");
                }
                else if (strikeCount == 3)
                {
                    strikeCount = 4;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\fourStrike.png");
                }
                else if (strikeCount == 4)
                {
                    strikeCount = 5;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\fiveStrike.png");
                }
                //shows you that you lost if you hit too many strikes
                else if (strikeCount == 5)
                {
                    strikeCount = 6;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\sixStrike.png");
                    winOrLoseLabel.Text = "You Lose";
                    winOrLoseLabel.Visible = true;
                    letterInput.Enabled = false;
                    wordInput.Enabled = false;
                    letterGuessButton.Enabled = false;
                    wordGuessButton.Enabled = false;
                }
            }
            //clears the letter input after each letter guess so you don't have to
            letterInput.Text = null;
        }

        //lets you guess a word
        private void wordGuessButton_Click(object sender, EventArgs e)
        {
            checkCount = 0;
            //checks if you entered the real word
            if (wordInput.Text == realWord)
            {
                //displays it at the top for you to see it
                while (checkCount + 1 <= wordLength)
                {
                    wordBreaker = Convert.ToString(realWordAsChars[checkCount]);
                    checkCount = checkCount + 1;
                    wordAsChars[checkCount * 2 - 1] = Convert.ToChar(wordBreaker);
                }
                string displayedUpdate = new String(wordAsChars);
                realWordLabel.Text = displayedUpdate;
                //lets you know that you won while disabling you from guessing anymore
                winOrLoseLabel.Text = "You Win!";
                winOrLoseLabel.Visible = true;
                letterInput.Enabled = false;
                wordInput.Enabled = false;
                letterGuessButton.Enabled = false;
                wordGuessButton.Enabled = false;
            }
            //runs the strike check just like the letter one if you didn't guess the word correctly
            else
            {
                if (strikeCount == 0)
                {
                    strikeCount = 1;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\oneStrike.png");
                }
                else if (strikeCount == 1)
                {
                    strikeCount = 2;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\twoStrike.png");
                }
                else if (strikeCount == 2)
                {
                    strikeCount = 3;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\threeStrike.png");
                }
                else if (strikeCount == 3)
                {
                    strikeCount = 4;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\fourStrike.png");
                }
                else if (strikeCount == 4)
                {
                    strikeCount = 5;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\fiveStrike.png");
                }
                else if (strikeCount == 5)
                {
                    strikeCount = 6;
                    hangmanPicture.Image = new Bitmap("C:\\Users\\aidan\\source\\repos\\Hangman\\Hangman\\Resources\\sixStrike.png");
                    winOrLoseLabel.Text = "You Lose";
                    winOrLoseLabel.Visible = true;
                    letterInput.Enabled = false;
                    wordInput.Enabled = false;
                    letterGuessButton.Enabled = false;
                    wordGuessButton.Enabled = false;
                }
            }
            //clears the word input text box
            wordInput.Text = null;
        }

    }
}

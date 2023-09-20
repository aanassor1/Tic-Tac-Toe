using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialiseGame();
        }

        int Turn = 1; //    Variable used to track which player's go it is

        private void initialiseGame()
        {
            this.Retry.Visible = false;
            this.Retry.Click -= RetryButtonClick;
            Turn = 1;
            foreach (Button button in this.Grid.Controls)
            {
                button.Text = "";
                button.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
                button.FlatAppearance.MouseDownBackColor = Color.SlateBlue;
                button.Click += new EventHandler(gridButtonClick); //   Create a click event
            }
            Message.Text = "Player 1's Turn";
        }

        private void disableHover(Button btn)
        {
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
            btn.Click -= gridButtonClick;   // Delete the click event
        }

        //  Function that checks if the given array has a winning combination or not
        private bool won(Button[] buttons, string letter)
        {
            //  Contains array positions of winning combinations
            int[][] winningCombinations = {
              new []{0, 1, 2},
              new []{3, 4, 5},
              new []{6, 7, 8},
              new []{0, 3, 6},
              new []{1, 4, 7},
              new []{2, 5, 8},
              new []{0, 4, 8},
              new []{2, 4, 6},
            };

            bool found = false;
            for (int i = 0; i < winningCombinations.Length; i++)
            {
                int x = winningCombinations[i][0];
                int y = winningCombinations[i][1];
                int z = winningCombinations[i][2];
                if (buttons[x].Text == letter && buttons[y].Text == letter && buttons[z].Text == letter)
                {
                    found = true;
                }
            }

            return found;
        }

        //  Function that checks if the current grid is a draw or not
        private bool draw(Button[] buttons)
        {
            int notEmpty = 0;
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].Text != "")
                {
                    notEmpty++;
                }
            }
            if (notEmpty == 9) {
                return true;
            }
            return false;
        }

        //  Used to check if the game has been concluded or not
        private void checkGameStatus()
        {
            string letter;
            string player;
            if (Turn == 2) { // Make the letter opposite to check previous turn
                letter = "X";
                player = "Player 1";
            } else {
                letter = "O";
                player = "Player 2";
            }

            //  Initialise a buttons array to make a grid
            Button[] buttons = new Button[9];
            String[] buttonNames = {
                "ButtonTopLeft", "ButtonTopMiddle", "ButtonTopRight",
                "ButtonMiddleLeft", "ButtonMiddleCentre", "ButtonMiddleRight",
                "ButtonBottomLeft", "ButtonBottomCentre", "ButtonBottomRight"
            };
            for (int i = 0; i < 9; i++)
            {
                buttons[i] = (Button)this.Grid.Controls[buttonNames[i]];
            }

            //  If game is concluded, finish the game and make the retry button visible
            if (won(buttons, letter) == true)
            {
                Message.Text = player + "'s won!";
                foreach (Button button in this.Grid.Controls)
                {
                    disableHover(button);
                }
                this.Retry.Visible = true;
                this.Retry.Click += new EventHandler(RetryButtonClick);
            } else if (draw(buttons) == true)
            {
                Message.Text = "No one won.";
                foreach (Button button in this.Grid.Controls)
                {
                    disableHover(button);
                }
                this.Retry.Visible = true;
                this.Retry.Click += new EventHandler(RetryButtonClick);
            }
        }

        private void RetryButtonClick(object sender, EventArgs e)
        {
            initialiseGame();
        }

        //  Handles click events for the main grid
        private void gridButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Turn == 1)
            {
                btn.Text = "X";
                btn.ForeColor = SystemColors.ControlText;
                disableHover(btn);
                Message.Text = "Player 2's Turn";
                Turn = 2;
            } else
            {
                btn.Text = "O";
                btn.ForeColor = SystemColors.ControlLight;
                disableHover(btn);
                Message.Text = "Player 1's Turn";
                Turn = 1;
            }
            checkGameStatus();
            btn.Click -= gridButtonClick; //    Disable the button once it has been clicked
        }
    }
}

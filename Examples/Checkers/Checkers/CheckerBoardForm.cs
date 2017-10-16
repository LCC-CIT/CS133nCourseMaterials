// This program demonstrates a 2D Array
// by simulating a Checker board
// Written by Brian Bird, 5/30/13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class CheckerBoardForm : Form
    {
        public CheckerBoardForm()
        {
            InitializeComponent();
        }


        // Define and initialize an array that represents a Checker board
        // B = black checker, R = red checker, 
        // E = empty white square, X = empty black square

        char[,] board =  {  {'B', 'X', 'B', 'X', 'B', 'X', 'B', 'X'},
                            {'X', 'B', 'X', 'B', 'X', 'B', 'X', 'B'},
                            {'E', 'X', 'E', 'X', 'E', 'X', 'E', 'X'},
                            {'X', 'E', 'X', 'E', 'X', 'E', 'X', 'E'},
                            {'E', 'X', 'E', 'X', 'E', 'X', 'E', 'X'},
                            {'X', 'E', 'X', 'E', 'X', 'E', 'X', 'E'},
                            {'R', 'X', 'R', 'X', 'R', 'X', 'R', 'X'},
                            {'X', 'R', 'X', 'R', 'X', 'R', 'X', 'R'},
                         };

        // Variables to store the coordinates for moving checkers
        int fromRow = 0, fromCol = 0;  // Original position
        int toRow = 0, toCol = 0;      // destination position


        private void Form1_Load(object sender, EventArgs e)
        {
            DrawBoard();    // Show the initial positions when the program starts
        }


        // Move the checker to a new poistion (new coordinates)
        private void toButton_Click(object sender, EventArgs e)
        {
            toRow = int.Parse(rowTextBox.Text);         // store the destination  
            toCol = int.Parse(columnTextBox.Text);

            rowTextBox.Text = "";                       // clear the text box
            columnTextBox.Text = "";

            board[toRow, toCol] = board[fromRow, fromCol];      // "move" the checker
            board[fromRow, fromCol] = 'E';                      // mark it's original location as empty

           DrawBoard();                            // Redraw the board to show the checker in it's new position
        }


        // Select the checker to move by selecting it's coordinates
        private void fromButton_Click(object sender, EventArgs e)
        {
            fromRow = int.Parse(rowTextBox.Text);       // store the starting location
            fromCol = int.Parse(columnTextBox.Text);

            rowTextBox.Text = "";                       // clear the text box
            columnTextBox.Text = "";    
        }


        // Show the position of the checkers on the board
        private void DrawBoard()
        {
            boardTextBox.Text = "";             // clear the board

            for (int r = 0; r < 8; r++)         // loop through the rows
            {
                for (int c = 0; c < 8; c++)     // loop through the columns
                {
                    // Display the character representing a checker or square
                    boardTextBox.Text += "     " + board[r, c];   
                }
                boardTextBox.Text += "\r\n";    // start a new row
            }
        }

    }
}

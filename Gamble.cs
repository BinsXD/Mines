using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Mines
{
    public partial class Gamble : Form
    {
        const int TotalTiles = 25;
        int Mines { get; set; }
        int RemainingMines { get; set; }
        int SafePicks { get; set; } = 0;
        double Probability { get; set; } = 1.0;
        public Gamble()
        {
            InitializeComponent();
        }
        PlaceHolderManager placeholder = new PlaceHolderManager();
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gamble_Load(object sender, EventArgs e)
        {
            placeholder.AddPlaceholder(txtBet, txtBet.Text);
            placeholder.AddPlaceholder(txtCustomMines, txtCustomMines.Text);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;

            if (clickedButton != null)
            {
                // Check if the clicked button is currently blue (selected)
                bool wasSelected = clickedButton.FillColor == Color.Blue;

                // First reset all buttons to black
                btn1.FillColor = Color.Black;
                btn3.FillColor = Color.Black;
                btn5.FillColor = Color.Black;
                btn10.FillColor = Color.Black;

                // If the button was NOT selected before, make it blue and set the mine count
                if (!wasSelected)
                {
                    clickedButton.FillColor = Color.Blue;

                    if (int.TryParse(clickedButton.Text, out int value))
                    {
                        Mines = value;
                    }
                    else
                    {
                        MessageBox.Show("Button text is not a valid number.");
                    }
                }
                else
                {
                    // If it was selected, leave it black (deselected) and reset Mines
                    Mines = 0;
                }
            }
        }

        private void LandMines(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;

            if (clickedButton != null && clickedButton.Tag != null)
            {
                if (int.TryParse(clickedButton.Tag.ToString(), out int value))
                {
                    if (minePositions.Contains(value))
                    {
                        clickedButton.FillColor = Color.Red;
                        MessageBox.Show("IT'S A MINE!");
                        resetTiles(false);
                        ResetGame();
                    }
                    else
                    {
                        if (clickedButton.FillColor == Color.Black)
                        {
                            clickedButton.FillColor = Color.Lime;
                            SafePicks++;

                            // Calculate new multiplier
                            double multiplier = CalculateMultiplier(SafePicks, Mines);

                            if (double.TryParse(txtBet.Text, out double bet))
                            {
                                double cashout = bet * multiplier;
                                btnStartNCashout.Text = $"Cashout: {cashout:F2}";
                            }

                            // Check win condition
                            if (SafePicks == (TotalTiles - Mines))
                            {
                                MessageBox.Show($"YOU WON! Final Multiplier: {multiplier:F2}x");
                                resetTiles(false);
                                ResetGame();
                            }
                        }
                    }
                }
            }
        }

        private double CalculateMultiplier(int safePicks, int totalMines)
        {
            const int totalTiles = 25;
            double probability = 1.0;

            for (int i = 0; i < safePicks; i++)
            {
                int remainingSafeTiles = totalTiles - totalMines - i;
                int remainingTiles = totalTiles - i;

                probability *= (double)remainingSafeTiles / remainingTiles;
            }

            double multiplier = 1.0 / probability;

            double houseEdge = 0.04;
            multiplier *= (1.0 - houseEdge);

            return Math.Round(multiplier, 4);
        }

        private void ResetGame()
        {
            SafePicks = 0;
            Probability = 1.0;
            btnStartNCashout.Text = "Start Game";
        }
        private void resetTiles(bool en)
        {
            for (int i = 1; i <= 25; i++)
            {
                string tileName = $"tile{i}";
                Control[] found = this.Controls.Find(tileName, true); // `true` to search all child containers

                if (found.Length > 0 && found[0] is Guna2Button tile)
                {
                    tile.FillColor = Color.Black; // or your default color
                    tile.Enabled = en;          // re-enable it if it was disabled
                }
            }
        }


        private List<int> minePositions = new List<int>();

        private List<int> GenerateUniqueRandomNumbers(int count)
        {
            if (count < 1 || count > 24)
                throw new ArgumentOutOfRangeException("Count must be between 1 and 24.");

            List<int> numbers = Enumerable.Range(1, 25).ToList(); // numbers 1–25
            Random rand = new Random();

            // Shuffle the list
            for (int i = numbers.Count - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
            }

            // Take the first 'count' numbers from the shuffled list
            return numbers.Take(count).ToList();
        }
        private void btnStartNCashout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Mines.ToString()) || Mines < 1)
            {
                MessageBox.Show("Please select the number of mines first.");
            }
            else if (string.IsNullOrEmpty(txtBet.Text) || !double.TryParse(txtBet.Text, out double bet) || bet <= 0)
            {
                MessageBox.Show("Please enter a valid bet amount.");
            }
            else
            {
                RemainingMines = 25 - Mines;
                resetTiles(true);
                btnStartNCashout.Text = $"Cashout: {txtBet.Text}";
                try
                {
                    minePositions = GenerateUniqueRandomNumbers(Mines);
                    string output = string.Join(", ", minePositions);
                    MessageBox.Show($"Mines are placed at: {output}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void txtCustomMines_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCustomMines.Text, out int value))
            {
                Mines = value;
            }
            else
            {
                Mines = 0;
            }
            btn1.FillColor = Color.Black;
            btn3.FillColor = Color.Black;
            btn5.FillColor = Color.Black;
            btn10.FillColor = Color.Black;
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if(txtCustomMines.Visible == false)
            {
                txtCustomMines.Visible = true;
                btnStartNCashout.Width = 243;
            }
            else
            {
                txtCustomMines.Visible = false;
                btnStartNCashout.Width = 347;
            }
            
        }
    }
}

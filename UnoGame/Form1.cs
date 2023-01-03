using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var playerCount = (int)playersNumField.Value;
            var botCount = (int)botNumField.Value;

            Form2 game = new Form2(playerCount, botCount);
            Hide();
        }
    }
}
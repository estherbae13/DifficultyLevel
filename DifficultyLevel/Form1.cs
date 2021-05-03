using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultyLevel
{
    public partial class Form1 : Form
    {
        //global varities
        string name;
        string difficultyLevel;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            name = nameInput.Text;
            difficultyLevel = 

            outputLabel.Text = $"Welcome {name}! Good luck on your journey down the {difficultyLevel} path!";
        }

        private void easyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            difficultyLevel = "easy";
        }

        private void mediumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            difficultyLevel = "medium";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            difficultyLevel = "hard";
        }
    }
}

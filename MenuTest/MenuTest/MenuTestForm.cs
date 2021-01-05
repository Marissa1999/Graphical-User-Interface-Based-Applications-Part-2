﻿//ID: 1775227
//Name: Marissa Goncalves
//Lab 3 - Menu Test

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MenuTest
{
    public partial class MenuTestForm : Form
    {
        public MenuTestForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an exmaple\nof using menus.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

            displayLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

            displayLabel.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

            displayLabel.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

            displayLabel.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void ClearFont()
        {
            timesToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicToolStripMenuItem.Checked = false;
        }

        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();

            timesToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Times New Roman", 14, displayLabel.Font.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();

            courierToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Courier", 14, displayLabel.Font.Style);

        }

        private void comicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();

            comicToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Comic Sans MS", 14, displayLabel.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            displayLabel.Font = new Font(displayLabel.Font, displayLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            displayLabel.Font = new Font(displayLabel.Font, displayLabel.Font.Style ^ FontStyle.Italic);
        }

    }
}

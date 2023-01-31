using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG211_WinFormsDemo
{
    /// <summary>
    /// Sample calculator WinForms app
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: January 30, 2023</remarks>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the "+" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string firstString = this.textBoxFirst.Text;
            double first = double.Parse(firstString);

            string secondString = this.textBoxSecond.Text;
            double second = double.Parse(secondString);

            double result = first + second;

            this.textBoxResult.Text = result.ToString("N");
        }

        /// <summary>
        /// Called when the "-" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            string firstString = this.textBoxFirst.Text;
            double first = double.Parse(firstString);

            string secondString = this.textBoxSecond.Text;
            double second = double.Parse(secondString);

            double result = first - second;

            this.textBoxResult.Text = result.ToString("N");
        }

        /// <summary>
        /// Called when the "*" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            string firstString = this.textBoxFirst.Text;
            double first = double.Parse(firstString);

            string secondString = this.textBoxSecond.Text;
            double second = double.Parse(secondString);

            double result = first * second;

            this.textBoxResult.Text = result.ToString("N");
        }

        /// <summary>
        /// Called when the "/" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            string firstString = this.textBoxFirst.Text;
            double first = double.Parse(firstString);

            string secondString = this.textBoxSecond.Text;
            double second = double.Parse(secondString);

            double result = first / second;

            this.textBoxResult.Text = result.ToString("N");
        }

        /// <summary>
        /// Called when the "%" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModulus_Click(object sender, EventArgs e)
        {
            string firstString = this.textBoxFirst.Text;
            double first = double.Parse(firstString);

            string secondString = this.textBoxSecond.Text;
            double second = double.Parse(secondString);

            double result = first % second;

            this.textBoxResult.Text = result.ToString("N");
        }
    }
}

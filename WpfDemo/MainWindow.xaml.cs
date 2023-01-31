using System.Windows;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml view
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 30, 2023</remarks>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when user clicks "+" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first + second;

            this.textBoxResult.Text = result.ToString();
        }

        /// <summary>
        /// Called when user clicks "-" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first - second;

            this.textBoxResult.Text = result.ToString();
        }

        /// <summary>
        /// Called when user clicks "*" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first * second;

            this.textBoxResult.Text = result.ToString();
        }

        /// <summary>
        /// Called when user clicks "/" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first / second;

            this.textBoxResult.Text = result.ToString();
        }

        /// <summary>
        /// Called when user clicks "%" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModulus_Click(object sender, RoutedEventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first % second;

            this.textBoxResult.Text = result.ToString();
        }
    }
}

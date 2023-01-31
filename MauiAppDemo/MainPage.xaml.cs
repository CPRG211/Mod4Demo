namespace MauiAppDemo
{
    /// <summary>
    /// Demo MAUI page
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 30, 2023</remarks>
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when "+" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Clicked(object sender, EventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first + second;

            this.textBoxResult.Text = result.ToString();
        }

        /// <summary>
        /// Called when "-" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubtract_Clicked(object sender, EventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first - second;

            this.textBoxResult.Text = result.ToString();
        }

        /// <summary>
        /// Called when "*" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Clicked(object sender, EventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first * second;

            this.textBoxResult.Text = result.ToString();
        }

        /// <summary>
        /// Called when "/" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDivide_Clicked(object sender, EventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first / second;

            this.textBoxResult.Text = result.ToString();
        }

        /// <summary>
        /// Called when "%" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModulus_Clicked(object sender, EventArgs e)
        {
            double first = double.Parse(this.textBoxFirst.Text);
            double second = double.Parse(this.textBoxSecond.Text);

            double result = first % second;

            this.textBoxResult.Text = result.ToString();
        }
    }
}
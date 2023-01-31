using System.Windows;

namespace WpfMVVMDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml view
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 30, 2023</remarks>
    public partial class MainWindow : Window
    {
        protected ViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            // Create ViewModel instance
            this.viewModel = new ViewModel();

            // Set instance to pull/push data for view
            this.DataContext = viewModel;
        }

        /// <summary>
        /// Called when user clicks "+" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            double first = this.viewModel.First.Double;
            double second = this.viewModel.Second.Double;

            double result = first + second;

            this.viewModel.Result.Double = result;
        }

        /// <summary>
        /// Called when user clicks "-" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            double first = this.viewModel.First.Double;
            double second = this.viewModel.Second.Double;

            double result = first - second;

            this.viewModel.Result.Double = result;
        }

        /// <summary>
        /// Called when user clicks "*" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            double first = this.viewModel.First.Double;
            double second = this.viewModel.Second.Double;

            double result = first * second;

            this.viewModel.Result.Double = result;
        }

        /// <summary>
        /// Called when user clicks "/" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            double first = this.viewModel.First.Double;
            double second = this.viewModel.Second.Double;

            double result = first / second;

            this.viewModel.Result.Double = result;
        }

        /// <summary>
        /// Called when user clicks "%" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModulus_Click(object sender, RoutedEventArgs e)
        {
            double first = this.viewModel.First.Double;
            double second = this.viewModel.Second.Double;

            double result = first % second;

            this.viewModel.Result.Double = result;
        }
    }
}

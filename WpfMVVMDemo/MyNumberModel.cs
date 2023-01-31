using System.ComponentModel;

namespace WpfMVVMDemo
{
    /// <summary>
    /// Represents a number as a string or double
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 30, 2023</remarks>
    public class MyNumberModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Holds formatted number
        /// </summary>
        private string formatted;

        /// <summary>
        /// Provides access to number as string
        /// </summary>
        public string Formatted
        {
            get { return this.formatted; }
            set 
            {
                // Check value being assigned is valid number.
                if (this.Validate(value))
                {
                    // Set formatted to value being assigned.
                    this.formatted = value;
                }

                // Notify view(s) using this property that it may have changed.
                this.OnPropertyChanged("Formatted");
                //this.OnPropertyChanged(nameof(Formatted));
            }
        }

        /// <summary>
        /// Gets and sets number as double
        /// </summary>
        public double Double
        {
            get
            {
                
                return double.Parse(this.formatted);
            }
            set
            {
                // Notice it's "Formatted =" and not "formatted ="
                this.Formatted = value.ToString();
            }
        }

        /// <summary>
        /// No-arg constructor
        /// </summary>
        public MyNumberModel()
        {
            // Sets initial number as '0'
            this.formatted = "0";
        }

        /// <summary>
        /// Checks that string is formatted as decimal number
        /// </summary>
        /// <param name="input">String</param>
        /// <returns>True if string input is able to be parsed as double</returns>
        private bool Validate(string input)
        {
            return double.TryParse(input, out double value);
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Invokes the PropertyChanged event
        /// </summary>
        /// <param name="propertyName">Name of property that was changed.</param>
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            
        }
        #endregion
    }
}

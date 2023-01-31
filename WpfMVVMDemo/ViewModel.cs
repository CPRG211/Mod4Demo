namespace WpfMVVMDemo
{
    /// <summary>
    /// Bridges view and model together
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 30, 2023</remarks>
    public class ViewModel
    {
        protected MyNumberModel first;
        protected MyNumberModel second;
        protected MyNumberModel result;

        /// <summary>
        /// Provides access to first number model.
        /// </summary>
        public MyNumberModel First
        {
            get { return first; }
        }

        /// <summary>
        /// Provides access to second number model.
        /// </summary>
        public MyNumberModel Second
        {
            get { return second; }
        }

        /// <summary>
        /// Provides access to result number model.
        /// </summary>
        public MyNumberModel Result
        {
            get { return result; }
        }

        /// <summary>
        /// No-arg constructor
        /// </summary>
        public ViewModel()
        {
            // Creates 3 instances of MyNumberModel for 3 fields.
            first = new MyNumberModel();
            second = new MyNumberModel();
            result = new MyNumberModel();
        }
    }
}

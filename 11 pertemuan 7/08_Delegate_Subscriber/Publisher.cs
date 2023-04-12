 //public delegate void EventHandler(object sender, EventArgs e);

 public delegate void MyDelegate (string masage);

    // Define a publisher class that will raise an event
    public class Publisher
    {
        // Declare the event using the delegate
        public event EventHandler SomethingHappened;

        // Method to simulate something happening
        public void DoSomething()
        {
            // Check if there are subscribers to the event
            if (SomethingHappened != null)
            {
                // Raise the event
                SomethingHappened(this, EventArgs.Empty);
            }
        }
    }
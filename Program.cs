namespace SmartHomeSimulator
{
    /// <summary>
    /// The main entry point for the smart home simulation application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Executes the simulation.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        public static void Main(string[] args)
        {
            SmartHub hub = new SmartHub();
            Thermostat livingRoom = new Thermostat("TH-01", 18.5);

            hub.RegisterDevice(livingRoom);
            livingRoom.TurnOn();
        }
    }
}
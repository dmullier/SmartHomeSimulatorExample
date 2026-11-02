namespace SmartHomeSimulator
{
    /// <summary>
    /// Represents a smart thermostat capable of monitoring and adjusting room temperature.
    /// </summary>
    public class Thermostat : IDevice
    {
        private double _currentTemperature;

        /// <inheritdoc />
        public string DeviceId { get; }

        /// <inheritdoc />
        public bool IsOn { get; private set; }

        /// <summary>
        /// Gets the current temperature measured by the thermostat in Celsius.
        /// </summary>
        public double CurrentTemperature => _currentTemperature;

        /// <summary>
        /// Gets or sets the target temperature set point in Celsius.
        /// </summary>
        public double TargetTemperature { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thermostat"/> class.
        /// </summary>
        /// <param name="deviceId">The unique identifier for the thermostat.</param>
        /// <param name="initialTemperature">The starting ambient temperature.</param>
        public Thermostat(string deviceId, double initialTemperature)
        {
            DeviceId = deviceId;
            _currentTemperature = initialTemperature;
            TargetTemperature = 21.0; // Default comfortable room temp
            IsOn = false;
        }

        /// <summary>
        /// Adjusts the target temperature by a specified delta value.
        /// </summary>
        /// <param name="delta">The amount to increase or decrease the target temperature.</param>
        /// <returns>The newly updated target temperature.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the thermostat is currently turned off.</exception>
        public double AdjustTargetTemperature(double delta)
        {
            if (!IsOn)
            {
                throw new InvalidOperationException("Cannot adjust temperature while the thermostat is off.");
            }

            TargetTemperature += delta;
            return TargetTemperature;
        }

        /// <inheritdoc />
        public void TurnOn() => IsOn = true;

        /// <inheritdoc />
        public void TurnOff() => IsOn = false;
    }
}
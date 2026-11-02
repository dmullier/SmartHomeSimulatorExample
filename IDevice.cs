using System.Xml;

namespace SmartHomeSimulator
{


    /// <summary>
    /// Represents a generic controllable smart home device.
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// Gets the unique identifier of the device.
        /// </summary>
        string DeviceId { get; }

        /// <summary>
        /// Gets a value indicating whether the device is currently turned on.
        /// </summary>
        bool IsOn { get; }

        /// <summary>
        /// Turns the device on.
        /// </summary>
        void TurnOn();

        /// <summary>
        /// Turns the device off.
        /// </summary>
        void TurnOff();
    }
}
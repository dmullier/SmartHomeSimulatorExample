using System.Collections.Generic;

namespace SmartHomeSimulator
{
    /// <summary>
    /// Manages a collection of connected smart home devices within a household.
    /// </summary>
    public class SmartHub
    {
        private readonly List<IDevice> _devices = new();

        /// <summary>
        /// Gets a read-only collection of all registered devices in the hub.
        /// </summary>
        public IReadOnlyCollection<IDevice> Devices => _devices.AsReadOnly();

        /// <summary>
        /// Registers a new device with the smart hub.
        /// </summary>
        /// <param name="device">The device instance to add.</param>
        public void RegisterDevice(IDevice device)
        {
            if (!_devices.Contains(device))
            {
                _devices.Add(device);
            }
        }

        /// <summary>
        /// Sends a broadcast command to turn off all registered devices.
        /// </summary>
        public void EmergencyShutdown()
        {
            foreach (var device in _devices)
            {
                device.TurnOff();
            }
        }
    }
}
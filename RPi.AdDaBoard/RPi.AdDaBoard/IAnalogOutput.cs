﻿namespace Emmellsoft.IoT.Rpi.AdDaBoard
{
    /// <summary>
    /// A digital-to-analog converter.
    /// </summary>
    public interface IAnalogOutput
    {
        /// <summary>
        /// Set the analog output voltage.
        /// </summary>
        /// <param name="channel">The output channel.</param>
        /// <param name="normalizedOutputLevel">The output level between 0.0 (minimum voltage) and 1.0 (maximum voltage).</param>
        void SetOutput(OutputChannel channel, double normalizedOutputLevel);

        /// <summary>
        /// Set the analog output voltage.
        /// </summary>
        /// <param name="channel">The output channel.</param>
        /// <param name="voltage">The voltage level between 0 and <paramref name="vRef"/>.</param>
        /// <param name="vRef">The voltage reference (usually 3.3 or 5 Volt).</param>
        void SetOutput(OutputChannel channel, double voltage, double vRef);
    }
}
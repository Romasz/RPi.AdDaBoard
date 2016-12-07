﻿using System;
using Windows.Devices.Spi;

namespace Emmellsoft.IoT.Rpi.AdDaBoard
{
    /// <summary>
    /// SPI communication helper.
    /// </summary>
    internal interface ISpiComm : IDisposable
    {
        /// <summary>
        /// Use the SPI connection.
        /// </summary>
        /// <param name="spiAction">Callback that gives access to the actual <see cref="SpiDevice"/>.</param>
        void Use(Action<SpiDevice> spiAction);
    }
}
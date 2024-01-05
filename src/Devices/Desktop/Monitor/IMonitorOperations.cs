
using System.Collections.Generic;

namespace iTin.Core.Hardware.Abstractions.Devices.Desktop.Monitor;

/// <summary>
/// Define a generic <strong>Monitor</strong> operations.
/// </summary>
public interface IMonitorOperations
{
    /// <summary>
    /// Gets a value containing the raw <strong>EDID</strong> data.
    /// </summary>
    /// <returns>
    /// The raw <strong>EDID</strong> data.
    /// </returns>
    IEnumerable<byte[]> GetEdidDataCollection();
}

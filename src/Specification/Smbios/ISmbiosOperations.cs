
namespace iTin.Core.Hardware.Abstractions.Specification.Smbios;

/// <summary>
/// Define a generic <strong>SMBIOS</strong> operations.
/// </summary>
public interface ISmbiosOperations
{
    /// <summary>
    /// Gets a value containing the raw <strong>SMBIOS</strong> data.
    /// </summary>
    /// <param name="options">Connection options for remote use</param>
    /// <returns>
    /// The raw <strong>SMBIOS</strong> data.
    /// </returns>
    byte[] GetSmbiosDataArray(ISmbiosConnectOptions options);
}

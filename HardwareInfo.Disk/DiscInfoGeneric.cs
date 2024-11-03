namespace HardwareInfo.Disk;

internal sealed class DiscInfoGeneric : IDiskInfo
{
    public DiskType DiskType { get; set; }

    public ISmart Smart { get; set; } = default!;

    public string DeviceId { get; set; } = default!;

    public int Index { get; set; }

    public ulong Size { get; set; }

    public string PnpDeviceId { get; set; } = default!;

    public string Status { get; set; } = default!;

    public string Model { get; set; } = default!;

    public string SerialNumber { get; set; } = default!;

    public string FirmwareRevision { get; set; } = default!;

    public bool Removable { get; set; }

    public void Dispose()
    {
        (Smart as IDisposable)?.Dispose();
    }
}
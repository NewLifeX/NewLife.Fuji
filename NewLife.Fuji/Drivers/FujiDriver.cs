using System.ComponentModel;
using NewLife.IoT.Drivers;
using NewLife.IoT.Protocols;

namespace NewLife.Fuji.Drivers;

/// <summary>
/// 富士PLC协议封装
/// </summary>
[Driver("FujiPLC")]
[DisplayName("富士PLC")]
public class FujiDriver : DriverBase<FujiNode, FujiParameter>
{
}
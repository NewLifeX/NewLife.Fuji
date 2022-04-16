using NewLife.IoT.Drivers;
using NewLife.IoT.Protocols;

namespace NewLife.Fuji.Drivers;

/// <summary>
/// FujiPLC协议封装
/// </summary>
[Driver("FujiPLC")]
public class FujiDriver : ModbusDriver, IDriver
{
    #region 方法
    /// <summary>
    /// 创建Modbus通道
    /// </summary>
    /// <param name="channel"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    protected override Modbus CreateModbus(IChannel channel, IDictionary<String, Object> parameters)
    {
        var address = parameters["Address"] as String;
        if (address.IsNullOrEmpty()) throw new ArgumentException("参数中未指定地址address");

        var modbus = new ModbusTcp
        {
            Server = address,
            Tracer = Tracer,
            Log = Log,
        };

        return modbus;
    }
    #endregion
}
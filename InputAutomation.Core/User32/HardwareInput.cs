using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

[StructLayout(LayoutKind.Sequential)]
public struct HardwareInput {
	public int uMsg;
	public short wParamL;
	public short wParamH;
}
using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

[StructLayout(LayoutKind.Sequential)]
public struct MouseInput {
	public int dx;
	public int dy;
	public int mouseData;
	public MouseEventF dwFlags;
	public uint time;
	public UIntPtr dwExtraInfo;
}

[Flags]
public enum MouseEventF : uint {
	ABSOLUTE = 0x8000,
	HWHEEL = 0x01000,
	MOVE = 0x0001,
	MOVE_NOCOALESCE = 0x2000,
	LEFTDOWN = 0x0002,
	LEFTUP = 0x0004,
	RIGHTDOWN = 0x0008,
	RIGHTUP = 0x0010,
	MIDDLEDOWN = 0x0020,
	MIDDLEUP = 0x0040,
	VIRTUALDESK = 0x4000,
	WHEEL = 0x0800,
	XDOWN = 0x0080,
	XUP = 0x0100
}
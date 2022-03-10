using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

[StructLayout(LayoutKind.Explicit)]
public struct InputUnion {
	[FieldOffset(0)] public MouseInput Mouse;
	[FieldOffset(0)] public KeyboardInput Key;
	[FieldOffset(0)] public HardwareInput HW;
}
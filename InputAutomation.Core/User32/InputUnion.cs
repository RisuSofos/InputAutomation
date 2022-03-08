using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

[StructLayout(LayoutKind.Explicit)]
public struct InputUnion {
	[FieldOffset(0)] internal MouseInput mouse;
	[FieldOffset(0)] internal KeyboardInput key;
	[FieldOffset(0)] internal HardwareInput hw;
}
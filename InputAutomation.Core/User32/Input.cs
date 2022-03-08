using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

[StructLayout(LayoutKind.Sequential)]
public struct Input {
	internal InputType Type;
	internal static int Size => Marshal.SizeOf(typeof(Input));
}

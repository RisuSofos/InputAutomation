using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

[StructLayout(LayoutKind.Sequential)]
public struct Input {
	public InputType InputType;
	public InputUnion Union;
	public static int Size => Marshal.SizeOf(typeof(Input));
}

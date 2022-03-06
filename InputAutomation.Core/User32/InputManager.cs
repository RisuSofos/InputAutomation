using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

/*public*/internal class InputManager {
	[StructLayout(LayoutKind.Explicit)]
	internal struct InputUnion {
		[FieldOffset(0)] internal MouseInput mouse;
		[FieldOffset(0)] internal KeyboardInput key;
		[FieldOffset(0)] internal HardwareInput hw;
	}

	[StructLayout(LayoutKind.Sequential)]
	/*public*/internal struct Input {
		internal uint type;
		internal static int Size => Marshal.SizeOf(typeof(Input));
	}


	[DllImport("user32.dll")]
	internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] Input[] pInputs, int cbSize);
}

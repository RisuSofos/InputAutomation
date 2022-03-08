using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

/// <summary>
/// Wrapper for the User32.dll SendInput API call
/// </summary>
public class API {
	public delegate void HandleInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] Input[] pInputs, int cbSize);

	[DllImport("user32.dll")]
	internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] Input[] pInputs, int cbSize);
}

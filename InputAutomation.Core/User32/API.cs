using System.Runtime.InteropServices;

namespace InputAutomation.Core.User32;

/// <summary>
/// Wrapper for the User32.dll SendInput API call
/// </summary>
public class API {
	public static async Task<uint> ProcessInput(Input[] inputs) {
		uint result = SendInput((uint)inputs.Length, inputs, Input.Size);
		return await Task.FromResult(result);
	}

	[DllImport("user32.dll")]
	private static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] Input[] pInputs, int cbSize);
}

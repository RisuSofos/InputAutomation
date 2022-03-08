namespace InputAutomation.Core.User32;

public struct KeyboardInput {
	public VirtualKeyShort wvk;
	public ScanCodeShort wScan;
	public KeyEventF dwFlags;
	public int time;
	public UIntPtr dwExtraInfo;
}

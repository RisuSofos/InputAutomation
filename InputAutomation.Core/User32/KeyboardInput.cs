namespace InputAutomation.Core.User32;

internal struct KeyboardInput {
	internal VirtualKeyShort wvk;
	internal ScanCodeShort wScan;
	internal KeyEventF dwFlags;
	internal int time;
	internal UIntPtr dwExtraInfo;
}

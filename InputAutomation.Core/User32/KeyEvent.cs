namespace InputAutomation.Core.User32;

[Flags]
public enum KeyEventF: uint {
	EXTENDEDKEY = 0x0001,
	KEYUP       = 0x0002,
	UNICODE     = 0x0004,
	SCANCODE    = 0x0008
}

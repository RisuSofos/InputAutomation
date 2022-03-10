using InputAutomation.Core.User32;

namespace InputAutomation.Core;

public class InputObject {
	public string Comment { get; set; } = string.Empty;
	public TimeSpan Delay { get; set; }
	public Input Data { get; set; }
}

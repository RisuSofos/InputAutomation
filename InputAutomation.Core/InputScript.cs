namespace InputAutomation.Core;
public class InputScript: Queue<InputObject> {
	public int RepeatCount { get; set; } = 0;
}
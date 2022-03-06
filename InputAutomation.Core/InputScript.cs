namespace InputAutomation.Core;
public class InputScript<T>: Queue<T> {
	public int RepeatCount { get; set; } = 0;
}
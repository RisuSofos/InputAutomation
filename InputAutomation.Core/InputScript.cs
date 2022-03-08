
namespace InputAutomation.Core;
public class InputScript<InputUnion>: Queue<InputUnion> {
	public int RepeatCount { get; set; } = 0;
}
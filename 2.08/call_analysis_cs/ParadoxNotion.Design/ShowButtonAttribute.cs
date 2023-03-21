using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ShowButtonAttribute : DrawerAttribute
{
	public readonly string buttonTitle;

	public readonly string methodnameCallback;

	[CallerCount(Count = 263)]
	[DeduplicatedMethod]
	public ShowButtonAttribute(string buttonTitle, string methodnameCallback)
	{
	}
}

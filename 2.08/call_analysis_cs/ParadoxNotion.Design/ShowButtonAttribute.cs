using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ShowButtonAttribute : DrawerAttribute
{
	public readonly string buttonTitle;

	public readonly string methodnameCallback;

	[DeduplicatedMethod]
	[CallerCount(Count = 268)]
	public ShowButtonAttribute(string buttonTitle, string methodnameCallback)
	{
	}
}

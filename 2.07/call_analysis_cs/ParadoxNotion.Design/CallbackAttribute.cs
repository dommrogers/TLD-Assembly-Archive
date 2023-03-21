using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class CallbackAttribute : DrawerAttribute
{
	public readonly string methodName;

	public override int priority
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 282)]
	public CallbackAttribute(string methodName)
	{
	}
}

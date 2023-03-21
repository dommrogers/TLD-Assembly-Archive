using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ShowIfAttribute : DrawerAttribute
{
	public readonly string fieldName;

	public readonly int checkValue;

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
	[CallerCount(Count = 1)]
	public ShowIfAttribute(string fieldName, int checkValue)
	{
	}
}

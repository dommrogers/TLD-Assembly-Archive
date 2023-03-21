using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ShowIfAttribute : DrawerAttribute
{
	public readonly string fieldName;

	public readonly int checkValue;

	public override int priority
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 22)]
	public ShowIfAttribute(string fieldName, int checkValue)
	{
	}
}

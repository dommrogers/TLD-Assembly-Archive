using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class MinValueAttribute : DrawerAttribute
{
	public readonly float min;

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
	[CallerCount(Count = 0)]
	public MinValueAttribute(float min)
	{
	}

	[CallerCount(Count = 0)]
	public MinValueAttribute(int min)
	{
	}
}

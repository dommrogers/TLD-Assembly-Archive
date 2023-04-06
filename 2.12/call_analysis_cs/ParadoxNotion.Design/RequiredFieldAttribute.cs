using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class RequiredFieldAttribute : DrawerAttribute
{
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
	[CallerCount(Count = 6)]
	public RequiredFieldAttribute()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class DelayedFieldAttribute : DrawerAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public DelayedFieldAttribute()
	{
	}
}

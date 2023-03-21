using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class DelayedFieldAttribute : DrawerAttribute
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public DelayedFieldAttribute()
	{
	}
}

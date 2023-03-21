using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class DelayedFieldAttribute : DrawerAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public DelayedFieldAttribute()
	{
	}
}

using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class TagFieldAttribute : DrawerAttribute
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public TagFieldAttribute()
	{
	}
}

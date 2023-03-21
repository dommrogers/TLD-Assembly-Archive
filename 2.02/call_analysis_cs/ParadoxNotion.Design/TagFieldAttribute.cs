using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class TagFieldAttribute : DrawerAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public TagFieldAttribute()
	{
	}
}

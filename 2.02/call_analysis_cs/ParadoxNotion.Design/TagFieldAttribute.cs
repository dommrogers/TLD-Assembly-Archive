using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class TagFieldAttribute : DrawerAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TagFieldAttribute()
	{
	}
}

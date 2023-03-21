using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class ForceObjectFieldAttribute : DrawerAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ForceObjectFieldAttribute()
	{
	}
}

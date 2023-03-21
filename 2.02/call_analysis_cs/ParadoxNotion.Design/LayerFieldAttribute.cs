using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class LayerFieldAttribute : DrawerAttribute
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LayerFieldAttribute()
	{
	}
}

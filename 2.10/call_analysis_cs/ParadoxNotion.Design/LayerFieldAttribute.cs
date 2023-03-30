using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class LayerFieldAttribute : DrawerAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LayerFieldAttribute()
	{
	}
}

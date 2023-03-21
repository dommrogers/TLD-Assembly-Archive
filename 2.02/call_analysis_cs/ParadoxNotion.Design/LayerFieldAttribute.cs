using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class LayerFieldAttribute : DrawerAttribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LayerFieldAttribute()
	{
	}
}

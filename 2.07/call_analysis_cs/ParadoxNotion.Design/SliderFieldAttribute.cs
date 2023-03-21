using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class SliderFieldAttribute : DrawerAttribute
{
	public readonly float min;

	public readonly float max;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SliderFieldAttribute(float min, float max)
	{
	}

	[CallerCount(Count = 0)]
	public SliderFieldAttribute(int min, int max)
	{
	}
}

using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class TextAreaFieldAttribute : DrawerAttribute
{
	public readonly int numberOfLines;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TextAreaFieldAttribute(int numberOfLines)
	{
	}
}

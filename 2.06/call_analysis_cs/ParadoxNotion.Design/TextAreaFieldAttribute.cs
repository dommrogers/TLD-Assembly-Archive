using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class TextAreaFieldAttribute : DrawerAttribute
{
	public readonly int numberOfLines;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TextAreaFieldAttribute(int numberOfLines)
	{
	}
}

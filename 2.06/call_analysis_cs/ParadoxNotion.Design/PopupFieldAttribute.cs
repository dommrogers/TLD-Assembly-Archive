using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Design;

public class PopupFieldAttribute : DrawerAttribute
{
	public readonly object[] options;

	[DeduplicatedMethod]
	[CallerCount(Count = 265)]
	public PopupFieldAttribute(object[] options)
	{
	}
}

using Cpp2ILInjected.CallAnalysis;

public class EditorDraw
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public EditorDraw()
	{
	}
}

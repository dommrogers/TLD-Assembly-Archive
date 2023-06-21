using Cpp2ILInjected.CallAnalysis;

public class StringArray
{
	public string[] strings;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public StringArray()
	{
	}
}

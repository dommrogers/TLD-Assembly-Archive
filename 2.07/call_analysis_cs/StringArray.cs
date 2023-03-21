using Cpp2ILInjected.CallAnalysis;

public class StringArray
{
	public string[] strings;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public StringArray()
	{
	}
}

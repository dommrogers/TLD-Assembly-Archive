using Cpp2ILInjected.CallAnalysis;

public class StringArray
{
	public string[] strings;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public StringArray()
	{
	}
}

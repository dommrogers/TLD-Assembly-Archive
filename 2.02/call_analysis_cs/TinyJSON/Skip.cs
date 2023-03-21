using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class Skip : Exclude
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Skip()
	{
	}
}

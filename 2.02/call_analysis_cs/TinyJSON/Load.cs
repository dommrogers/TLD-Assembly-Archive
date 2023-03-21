using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class Load : AfterDecode
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Load()
	{
	}
}

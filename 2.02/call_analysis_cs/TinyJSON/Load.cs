using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class Load : AfterDecode
{
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Load()
	{
	}
}

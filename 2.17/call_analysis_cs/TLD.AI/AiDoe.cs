using Cpp2ILInjected.CallAnalysis;

namespace TLD.AI;

public class AiDoe : AiBaseDeer
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = ".ctor")]
	public AiDoe()
	{
	}
}

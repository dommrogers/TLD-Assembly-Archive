using Cpp2ILInjected.CallAnalysis;

namespace TLD.AI;

public class AiStag : AiBaseDeer
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = ".ctor")]
	public AiStag()
	{
	}
}

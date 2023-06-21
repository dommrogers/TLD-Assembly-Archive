using Cpp2ILInjected.CallAnalysis;

namespace TLD.AI;

public class AiBaseDeer : BaseAi
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = ".ctor")]
	public AiBaseDeer()
	{
	}
}

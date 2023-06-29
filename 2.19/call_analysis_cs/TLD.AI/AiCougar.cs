using Cpp2ILInjected.CallAnalysis;

namespace TLD.AI;

public class AiCougar : BaseAi
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = ".ctor")]
	public AiCougar()
	{
	}
}

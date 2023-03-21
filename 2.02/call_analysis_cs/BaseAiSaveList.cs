using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BaseAiSaveList
{
	public List<BaseAiData> m_SerializedBaseAI;

	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public BaseAiSaveList()
	{
	}
}

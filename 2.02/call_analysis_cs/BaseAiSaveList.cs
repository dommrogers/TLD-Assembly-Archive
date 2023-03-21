using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BaseAiSaveList
{
	public List<BaseAiData> m_SerializedBaseAI;

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Serialize")]
	public BaseAiSaveList()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BaseAiSaveList
{
	public List<BaseAiData> m_SerializedBaseAI;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public BaseAiSaveList()
	{
	}
}

using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ChimneySaveList
{
	public List<LinkedChimneySaveData> m_SerializedChimneyData;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public ChimneySaveList()
	{
	}
}

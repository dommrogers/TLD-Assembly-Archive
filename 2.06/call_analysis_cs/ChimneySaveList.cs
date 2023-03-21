using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ChimneySaveList
{
	public List<LinkedChimneySaveData> m_SerializedChimneyData;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public ChimneySaveList()
	{
	}
}

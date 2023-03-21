using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class ChimneySaveList
{
	public List<LinkedChimneySaveData> m_SerializedChimneyData;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ChimneySaveList()
	{
	}
}
